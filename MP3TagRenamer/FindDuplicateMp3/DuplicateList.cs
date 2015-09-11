using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows.Forms;

using Mp3TagEditor.ManageDuplicates.Properties;

namespace Mp3TagEditor.ManageDuplicates
{
  public partial class DuplicateList : UserControl
  {
    private bool m_CancelScanning;
    private Stopwatch m_Stopwatch;
    private ConcurrentBag<Track> m_allTrackList;
    private readonly ConcurrentDictionary<int, int> m_processedIndexes = new ConcurrentDictionary<int, int>();
    private const string DeleteTag = "DELETE";
    private const string UndeleteTag = "UNDELETE";

    public DuplicateList()
    {
      InitializeComponent();
    }

    public ListDictionary SelectedFolders { get; set; }


    private void LoadSettings()
    {

      ColumnPlay.Image = Resources._1308841068_Play;
      ColumnPlayMarkedForDel.Image = Resources._1308841068_Play;
      ColumnDelete.Image = Resources._1309256835_Delete;
      ColumnUndelete.Image = Resources._1308841035_Undo;
      
      ColumnDelete.Image.Tag = DeleteTag;
      ColumnUndelete.Image.Tag = UndeleteTag;

      ColumnPlayMarkedForDel.ImageLayout = DataGridViewImageCellLayout.Zoom;
      ColumnDelete.ImageLayout = DataGridViewImageCellLayout.Zoom;
      ColumnUndelete.ImageLayout = DataGridViewImageCellLayout.Zoom;

      m_compareArtistCheckBox.Checked = Settings.Default.CompareArtist;
      m_compareFileNameCheckBox.Checked = Settings.Default.CompareFileName;
      m_compareSizeCheckBox.Checked = Settings.Default.CompareSize;
      m_compareLengthCheckBox.Checked = Settings.Default.CompareTime;
      m_compareTitleCheckBox.Checked = Settings.Default.CompareTitle;
      m_compareIdenticalCheckBox.Checked = Settings.Default.CompareIdentical;
    }


    private void SaveSettings()
    {
      Settings.Default.CompareArtist = m_compareArtistCheckBox.Checked;
      Settings.Default.CompareFileName = m_compareFileNameCheckBox.Checked;
      Settings.Default.CompareSize = m_compareSizeCheckBox.Checked;
      Settings.Default.CompareTime = m_compareLengthCheckBox.Checked;
      Settings.Default.CompareTitle = m_compareTitleCheckBox.Checked;      
      Settings.Default.CompareIdentical= m_compareIdenticalCheckBox.Checked;
      Settings.Default.Save();
    }
    
    private void InitializeSearch()
    {
      m_CancelScanning = false;
      m_ProgressBar.Value = 0;
      m_ProgressBar.Maximum = 1;
      m_ProgressBar.Visible = true;
      m_LabelProgresBarInfo.Tag = Resources.ScanningAllFiles;
      m_LabelProgresBarInfo.Text = Resources.ScanningAllFiles;
      m_LabelProgresBarInfo.Visible = true;
      m_GroupBoxCompare.Enabled = false;
  
      m_ButtonSearch.Enabled = false;
      m_allTrackList = new ConcurrentBag<Track>();
      m_Stopwatch = new Stopwatch();
      m_Stopwatch.Start();

      m_TracksDataSet.DeletedFiles.Clear();
      m_TracksDataSet.ChildTrac.Clear();
      m_TracksDataSet.ParentTrack.Clear();
    }

    private void OnSearchEnd()
    {
      if( InvokeRequired )
      {
        Invoke( new MethodInvoker( OnSearchEnd ) );
      }
      else
      {

        m_ButtonSearch.Text = Resources.SearchNow;
        m_ButtonSearch.Enabled = true;
        m_GroupBoxCompare.Enabled = true;

        m_LabelProgresBarInfo.Visible = false;
        m_ProgressBar.Visible = false;
        m_Stopwatch.Stop();
        m_LabelDuplicateCount.Text = string.Format("{0} {1}",
                                                   Math.Max(0,
                                                            m_TracksDataSet.ChildTrac.Count -
                                                            m_TracksDataSet.ParentTrack.Count)
                                                   ,
                                                   m_compareIdenticalCheckBox.Checked ? "identical files" : "duplicates");

      }
    }
    private void SetCompareFilter()
    {
      Track.CompareFileds = CompareFileds.None;

      Track.CompareFileds = Track.CompareFileds | ((m_compareFileNameCheckBox.Checked)
                                                     ? CompareFileds.FileName
                                                     : CompareFileds.None);

      Track.CompareFileds = Track.CompareFileds | ((m_compareLengthCheckBox.Checked)
                                                     ? CompareFileds.Length
                                                     : CompareFileds.None);

      Track.CompareFileds = Track.CompareFileds | ((m_compareSizeCheckBox.Checked)
                                                     ? CompareFileds.Size
                                                     : CompareFileds.None);

      Track.CompareFileds = Track.CompareFileds | ((m_compareTitleCheckBox.Checked)
                                                     ? CompareFileds.Title
                                                     : CompareFileds.None);
     
      Track.CompareFileds = Track.CompareFileds | ( ( m_compareTitleCheckBox.Checked && m_compareArtistCheckBox.Checked )
                                               ? CompareFileds.Artist
                                               : CompareFileds.None );

      Track.CompareFileds = Track.CompareFileds | ( ( m_compareIdenticalCheckBox.Checked )
                                               ? CompareFileds.Identical
                                               : CompareFileds.None );

      Track.MatchAllConditions = m_compareAllRadioButton.Checked;
    }


    private class EqualFilesInfo
    {
      public Track Parent { get; set; }
      public List<Track> AllTracks{get; set; }
      public int StartIndex { get; set; }
    }
  }

}