using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HundredMilesSoftware.UltraID3Lib;

namespace FindDuplicateMp3s
{
  //partial class DuplicateList
  //{
  //  private void StartRecursiveScan()
  //  {
  //    InitializeSearch();

  //    foreach( DictionaryEntry searchDirectory in SelectedFolders )
  //    {
  //      ScanDirectory( searchDirectory );
  //    }
  //  }

  //  private void ScanDirectory( DictionaryEntry searchDirectory )
  //  {
  //    int totalFiles = 0;

  //    try
  //    {

  //      DirectoryInfo di = new DirectoryInfo( searchDirectory.Key.ToString() );
  //      FileInfo[] fileList = di.GetFiles( "*.mp3",
  //                                        (bool)searchDirectory.Value
  //                                          ? SearchOption.AllDirectories
  //                                          : SearchOption.TopDirectoryOnly );

  //      EnableCancelButton();

  //      totalFiles = fileList.Length;
  //      SetProgressMaximum( totalFiles );

  //      for( int i = 0; i < totalFiles; i++ )
  //      {
  //        if( m_CancelScanning )
  //        {
  //          totalFiles = i;
  //          break;
  //        }
  //        try
  //        {
  //          UltraID3 id3 = new UltraID3();
  //          id3.Read( fileList[i].FullName );

  //          m_allTrackList.Add( new Track
  //          {
  //            Artist = id3.Artist,
  //            Title = id3.Title,
  //            Album = id3.Album,
  //            Genre = id3.Genre,
  //            Length = id3.Duration,
  //            Size = id3.Size,
  //            FileName = fileList[i].Name,
  //            Path = fileList[i].FullName
  //          } );

  //        }
  //        catch
  //        {
  //        }

  //        if( ( i % 100 ) == 0 )
  //        {
  //          UpdateProgress( i );
  //        }
  //      }
  //    }
  //    finally
  //    {
  //      EndRecursiveScanning( totalFiles, m_allTrackList );
  //    }
  //  }

  //  private void EndRecursiveScanning( int totalFiles, ConcurrentBag<Track> trackList )
  //  {
     
  //      m_ProgressBar.Value = 0;
  //      m_ProgressBar.Maximum = trackList.Count;
  //      m_ProgressBar.Visible = true;

  //      m_LabelProgresBarInfo.Tag = "Scanning for duplicates...";

  //      FindDuplicateFiles();     
  //  }

  //  private void FindDuplicateFiles()
  //  {
  //    if( m_allTrackList == null || m_allTrackList.Count == 0 )
  //    {
  //      return;
  //    }
  //    SetCompareFilter();
  //    SetProgressMaximum( m_allTrackList.Count );

  //    List<Track> allTracks = m_allTrackList.ToList();
  //    m_processedIndexes.Clear();
  //    try
  //    {
  //      for( int i = 0; i < allTracks.Count; i++ )
  //      {
  //        if( m_processedIndexes.ContainsKey( i ) )
  //        {
  //          continue;
  //        }

  //        Track parent = allTracks[i];
  //        var findEqualFilesVarables = new EqualFilesInfo
  //        {
  //          AllTracks = allTracks,
  //          Parent = parent,
  //          StartIndex = i
  //        };
  //        FindEqualFiles( findEqualFilesVarables );
  //        if( ( i % 10 ) == 0 )
  //        {
  //          UpdateProgress( i );
  //        }
  //      }
  //    }
  //    finally
  //    {  
  //      OnSearchEnd();
  //    }
  //  }

  //  private void FindEqualFiles( EqualFilesInfo methodParams )
  //  {
     
  //      var findEqualFilesVarables = methodParams;
  //      List<Track> allTracks = findEqualFilesVarables.AllTracks;
  //      Track parent = findEqualFilesVarables.Parent;
  //      int i = findEqualFilesVarables.StartIndex;
  //      int duplicateCount = 0;
  //      Console.WriteLine( i );

  //      TracksDataSet.ParentTrackRow parentRow = null;

  //      for( int k = i + 1; k < allTracks.Count; k++ )
  //      {
  //        try
  //        {
  //          Track child = allTracks[k];
  //          if (parent == child && m_TracksDataSet.ChildTrac.FindByPath(child.Path) == null)
  //          {
  //            if (duplicateCount == 0)
  //            {
  //              lock (m_TracksDataSet.ParentTrack.Rows.SyncRoot)
  //              {
  //                parentRow = m_TracksDataSet.ParentTrack.AddParentTrackRow(parent.Title,
  //                                                                          parent.Length.ToString(),
  //                                                                          parent.Size.ToString(),
  //                                                                          parent.FileName,
  //                                                                          parent.Artist);

  //              }
  //              lock (m_TracksDataSet.ChildTrac.Rows.SyncRoot)
  //              {

  //                m_TracksDataSet.ChildTrac.AddChildTracRow(parent.Title,
  //                                                          parent.Length.ToString(),
  //                                                          parent.Size.ToString(),
  //                                                          parent.FileName,
  //                                                          parent.Path,
  //                                                          parentRow,
  //                                                          parent.Artist, false, false);
  //              }

  //              if (!m_processedIndexes.ContainsKey(i))
  //              {
  //                m_processedIndexes.TryAdd(i, i);
  //              }
  //            }
  //            lock (m_TracksDataSet.ChildTrac.Rows.SyncRoot)
  //            {
  //              m_TracksDataSet.ChildTrac.AddChildTracRow(child.Title,
  //                                                        child.Length.ToString(),
  //                                                        child.Size.ToString(),
  //                                                        child.FileName,
  //                                                        child.Path,
  //                                                        parentRow,
  //                                                        child.Artist, false, false);
  //            }
  //            if (!m_processedIndexes.ContainsKey(k))
  //            {
  //              m_processedIndexes.TryAdd(k, k);
  //            }
  //            duplicateCount++;
  //          }
  //          m_TracksDataSet.AcceptChanges();
  //        }
  //        catch
  //        {
  //          m_TracksDataSet.RejectChanges();
  //        }
  //      }

  //  }

  //}
}
