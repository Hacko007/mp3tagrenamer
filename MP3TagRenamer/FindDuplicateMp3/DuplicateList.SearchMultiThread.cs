using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HundredMilesSoftware.UltraID3Lib;

namespace FindDuplicateMp3s
{
  partial class DuplicateList
  {
    private static Mutex m_mutex = new Mutex();

    private void StartRecursiveScanConcurrent()
    {
      InitializeSearch();

      foreach (DictionaryEntry searchDirectory in SelectedFolders)
      {
        Task.Factory.StartNew(ScanDirectoryConcurrent, searchDirectory);
      }
    }

    private void ScanDirectoryConcurrent(object searchDirectory)
    {
      int totalFiles = 0;

      try
      {
        DictionaryEntry baseDirectory = (DictionaryEntry) searchDirectory;

        DirectoryInfo di = new DirectoryInfo(baseDirectory.Key.ToString());
        FileInfo[] fileList = di.GetFiles("*.mp3",
                                          (bool) baseDirectory.Value
                                            ? SearchOption.AllDirectories
                                            : SearchOption.TopDirectoryOnly);

        //EnableCancelButton();

        totalFiles = fileList.Length;
        SetProgressMaximum(totalFiles);

        for (int i = 0; i < totalFiles; i++)
        {
          if (m_CancelScanning)
          {
            totalFiles = i;
            break;
          }
          try
          {
            UltraID3 id3 = new UltraID3();
            id3.Read(fileList[i].FullName);

            m_allTrackList.Add(new Track
                                 {
                                   Artist = id3.Artist,
                                   Title = id3.Title,
                                   Album = id3.Album,
                                   Genre = id3.Genre,
                                   Length = id3.Duration,
                                   Size = id3.Size,
                                   FileName = fileList[i].Name,
                                   Path = fileList[i].FullName
                                 });
          }
          catch
          {
          }

          if ((i%20) == 0)
          {
            UpdateProgress(20);
          }
        }
      }
      finally
      {
        EndRecursiveScanningConcurrent(totalFiles, m_allTrackList);
      }
    }


    private void EndRecursiveScanningConcurrent(int totalFiles, ConcurrentBag<Track> trackList)
    {
      if (!InvokeRequired)
      {
        m_ProgressBar.Value = 0;
        m_ProgressBar.Maximum = trackList.Count;
        m_ProgressBar.Visible = true;

        m_LabelProgresBarInfo.Tag = "Scanning for duplicates...";

        FindDuplicateFilesConcurrent();
      }
      else
      {
        Invoke(new EndRecursiveScanningDelegate(EndRecursiveScanningConcurrent), totalFiles, trackList);
      }
    }


    private void FindDuplicateFilesConcurrent()
    {
      if (m_allTrackList == null || m_allTrackList.Count == 0)
      {
        return;
      }
      SetCompareFilter();
      SetProgressMaximum(m_allTrackList.Count);

      List<Track> allTracks = m_allTrackList.ToList();
      m_processedIndexes.Clear();
      try
      {
        for (int i = 0; i < allTracks.Count; i++)
        {
          if (m_processedIndexes.ContainsKey(i))
          {
            continue;
          }

          Track parent = allTracks[i];
          var findEqualFilesVarables = new EqualFilesInfo
                                         {
                                           AllTracks = allTracks,
                                           Parent = parent,
                                           StartIndex = i
                                         };
          FindEqualFilesCuncurrent(findEqualFilesVarables);
          if ((i%10) == 0)
          {
            UpdateProgress(10);
          }
        }
      }
      finally
      {
        OnSearchEnd();
      }
    }

    private void FindEqualFilesCuncurrent(object methodParams)
    {
      if (InvokeRequired)
      {
        Invoke(new FindEqualFilesDelegate(FindEqualFilesCuncurrent), methodParams);
      }
      else
      {
        m_mutex.WaitOne();
        var findEqualFilesVarables = methodParams as EqualFilesInfo;
        List<Track> allTracks = findEqualFilesVarables.AllTracks;
        Track parent = findEqualFilesVarables.Parent;
        int i = findEqualFilesVarables.StartIndex;
        int duplicateCount = 0;


        TracksDataSet.ParentTrackRow parentRow = null;

        for (int k = i + 1; k < allTracks.Count; k++)
        {
          try
          {
            Track child = allTracks[k];

            if (parent == child && m_TracksDataSet.ChildTrac.FindByPath(child.Path) == null)
            {
              if (duplicateCount == 0)
              {
                parentRow = m_TracksDataSet.ParentTrack.AddParentTrackRow(parent.Title,
                                                                          parent.Length.ToString(),
                                                                          parent.Size.ToString(),
                                                                          parent.FileName,
                                                                          parent.Artist);


                m_TracksDataSet.ChildTrac.AddChildTracRow(parent.Title,
                                                          parent.Length.ToString(),
                                                          parent.Size.ToString(),
                                                          parent.FileName,
                                                          parent.Path,
                                                          parentRow,
                                                          parent.Artist, false, false);


                if (!m_processedIndexes.ContainsKey(i))
                {
                  m_processedIndexes.TryAdd(i, i);
                }
              }

              m_TracksDataSet.ChildTrac.AddChildTracRow(child.Title,
                                                        child.Length.ToString(),
                                                        child.Size.ToString(),
                                                        child.FileName,
                                                        child.Path,
                                                        parentRow,
                                                        child.Artist, false, false);

              if (!m_processedIndexes.ContainsKey(k))
              {
                m_processedIndexes.TryAdd(k, k);
              }
              duplicateCount++;
            }
          }
          catch
          {
          }
        }
        m_mutex.ReleaseMutex();
      }
    }


    private void SetProgressMaximum(int maximumValue)
    {
      if (!InvokeRequired)
      {
        m_ProgressBar.Maximum += maximumValue;
      }
      else
      {
        Invoke(new UpdateProgressDelegate(SetProgressMaximum), maximumValue);
      }
    }

    private void UpdateProgress(int progressValue)
    {
      if (!InvokeRequired)
      {
        m_ProgressBar.Value = Math.Min(m_ProgressBar.Maximum, m_ProgressBar.Value + progressValue);
        m_LabelProgresBarInfo.Text = string.Format("{0}  ({1}/{2} files) (Elapsed time:{3})"
                                                   , m_LabelProgresBarInfo.Tag
                                                   , m_ProgressBar.Value
                                                   , m_ProgressBar.Maximum
                                                   , m_Stopwatch.Elapsed.ToString("hh':'mm':'ss"));
      }
      else
      {
        Invoke(new UpdateProgressDelegate(UpdateProgress), progressValue);
      }
    }

    #region Nested type: EndRecursiveScanningDelegate

    private delegate void EndRecursiveScanningDelegate(int totalFiles, ConcurrentBag<Track> trackList);

    #endregion

    #region Nested type: FindEqualFilesDelegate

    private delegate void FindEqualFilesDelegate(object findEqualFilesVarables);

    #endregion

    #region Nested type: UpdateProgressDelegate

    private delegate void UpdateProgressDelegate(int progressValue);

    #endregion
  }
}