using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Mp3TagEditor.ManageDuplicates.Properties;

namespace Mp3TagEditor.ManageDuplicates
{
  partial class DuplicateList
  { 

    /// <summary>
    /// Handles Search button click event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnSearchClick(object sender, EventArgs e)
    {
      StartRecursiveScanConcurrent();
    }
  
    /// <summary>
    /// On DuplicateList load
    /// </summary>
    public void OnLoad()
    {
      LoadSettings();
    }

    /// <summary>
    /// On DuplicateList close
    /// </summary>
    public void OnClosing()
    {
      SaveSettings();
    }

    /// <summary>
    /// Handles click on Undelete all button event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnUndeleteAllClick(object sender, EventArgs e)
    {
      m_TracksDataSet.DeletedFiles.Clear();
      foreach (TracksDataSet.ChildTracRow row in m_TracksDataSet.ChildTrac.Rows)
      {
        row.IsMarkedForDelete = false;
      }
    }

    /// <summary>
    /// Handles click on Delete All button event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDeleteAllClick( object sender, EventArgs e )
    {
      if (m_TracksDataSet.DeletedFiles.Count == 0)
      {
        return;
      }

      if( DialogResult.No ==
            MessageBox.Show( this, 
            string.Format( Resources.Files_will_be_deleted_permanetly, m_TracksDataSet.DeletedFiles.Count ),
            Resources.Do_you_want_to_delete_files,
            MessageBoxButtons.YesNo ) )
      {
        return;
      }

      int count = 0;
      for (int i = 0 ; i < m_TracksDataSet.DeletedFiles.Count; i++)
      {
        try
        {
          TracksDataSet.DeletedFilesRow rowToDelete = (TracksDataSet.DeletedFilesRow)m_TracksDataSet.DeletedFiles.Rows[i];
          File.Delete( rowToDelete.Path );
          if( rowToDelete.ChildTracRow != null )
          {
            rowToDelete.ChildTracRow.IsDeleted = true;
          }
          rowToDelete.Delete();
          count++;
        }
        catch
        {
        }
      }
      m_TracksDataSet.DeletedFiles.AcceptChanges();
      if (count == 0)
      {
        MessageBox.Show(this, Resources.No_file_deleted_);
      }
      else
      {
        MessageBox.Show(this, string.Format(Resources.Files_succesfuly_deleted, count));
      }
    }

    /// <summary>
    /// Handles check change event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnCheckChange( object sender, EventArgs e )
    {
      m_groupBoxCompareSimulare.Enabled = !m_compareIdenticalCheckBox.Checked;
      
      if( sender == m_compareIdenticalCheckBox )
      {
      return;
      }

      if( !m_compareFileNameCheckBox.Checked &&
          !m_compareLengthCheckBox.Checked &&
          !m_compareSizeCheckBox.Checked &&
          !m_compareTitleCheckBox.Checked )
      {
        ((CheckBox) sender).Checked = true;
        return;
      }
      m_compareArtistCheckBox.Enabled = m_compareTitleCheckBox.Checked;
    }

   
    /// <summary>
    /// Handles click on Play and click on Delete row button.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDiplicateFilesCellContentClick( object sender, DataGridViewCellEventArgs e )
    {
      switch (e.ColumnIndex)
      {

        case 0: // PLAY
          if (m_DataGridViewDuplicateFiles.CurrentRow != null)
          {
            var rowToPlay =
              ((DataRowView) m_DataGridViewDuplicateFiles.CurrentRow.DataBoundItem).Row as TracksDataSet.ChildTracRow;
            if (rowToPlay != null)
            {
              Process mp3PlayerProcess = new Process
                                           {
                                             StartInfo =
                                               {
                                                 FileName = "\"" + rowToPlay.Path + "\"",
                                                 WindowStyle = ProcessWindowStyle.Minimized,
                                                 UseShellExecute = true
                                               }
                                           };

              mp3PlayerProcess.Start();
            }
          }
          break;


        case 1: // DELETE / UNDELETE
          if (m_DataGridViewDuplicateFiles.CurrentRow != null)
          {
            var rowToDelete =
              ((DataRowView) m_DataGridViewDuplicateFiles.CurrentRow.DataBoundItem).Row as TracksDataSet.ChildTracRow;
            
            if( rowToDelete != null && rowToDelete.IsMarkedForDelete )
            {
              // row is already deleted / undo delete
              TracksDataSet.DeletedFilesRow[] deletedRows =  rowToDelete.GetDeletedFilesRows();
              if( deletedRows != null && deletedRows.Length > 0 )
              {
                deletedRows[0].Delete();
              }
              rowToDelete.IsMarkedForDelete = false;
              m_TracksDataSet.AcceptChanges();
              break;
            }
            
            if (rowToDelete != null && m_TracksDataSet.DeletedFiles.FindByPath(rowToDelete.Path) == null)
            {
              // Mark row as DELETED
              m_TracksDataSet.DeletedFiles.AddDeletedFilesRow(rowToDelete, rowToDelete.Title, rowToDelete.Length,
                                                              rowToDelete.Size, rowToDelete.Artist);
              rowToDelete.IsMarkedForDelete = true;
              m_TracksDataSet.AcceptChanges();
            }
          }
          break;
      }
    }

    /// <summary>
    /// Handles click on Play and click on UnDelete row button.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDeletedListCellContentClick( object sender, DataGridViewCellEventArgs e )
    {

      switch (e.ColumnIndex)
      {

        case 0: // PLAY
          if (m_dataGridViewDeletedList.CurrentRow != null)
          {
            var rowToPlay =
              ((DataRowView) m_dataGridViewDeletedList.CurrentRow.DataBoundItem).Row as TracksDataSet.DeletedFilesRow;
            if (rowToPlay != null)
            {
              Process mp3PlayerProcess = new Process
                                           {
                                             StartInfo =
                                               {
                                                 FileName = "\"" + rowToPlay.Path + "\"",
                                                 WindowStyle = ProcessWindowStyle.Minimized,
                                                 UseShellExecute = true
                                               }
                                           };

              mp3PlayerProcess.Start();
            }
          }
          break;



        case 1: // UnDelete
          if (m_dataGridViewDeletedList.CurrentRow != null)
          {
            var rowToUnDelete =
              ((DataRowView) m_dataGridViewDeletedList.CurrentRow.DataBoundItem).Row as TracksDataSet.DeletedFilesRow;

            if (rowToUnDelete != null && rowToUnDelete.ChildTracRow != null)
            {
              rowToUnDelete.ChildTracRow.IsMarkedForDelete = false;
              rowToUnDelete.ChildTracRow.IsDeleted = false;
            }
            m_TracksDataSet.DeletedFiles.RemoveDeletedFilesRow(rowToUnDelete);
            m_TracksDataSet.AcceptChanges();
          }
          break;

      }
    }

    /// <summary>
    /// Paint marked rows with difrent color.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnDiplicateFilesRowPrePaint( object sender, DataGridViewRowPrePaintEventArgs e )
    {
      if( e.RowIndex < 0 || e.RowIndex >= m_DataGridViewDuplicateFiles.Rows.Count )
      {
        return;
      }
      var row =
        ((DataRowView) (m_DataGridViewDuplicateFiles.Rows[e.RowIndex].DataBoundItem)).Row as TracksDataSet.ChildTracRow;

      if( row == null )
      {
      return;
      }
      m_DataGridViewDuplicateFiles.Rows[e.RowIndex].DefaultCellStyle.BackColor = row.IsMarkedForDelete
                                                                                ? Color.Firebrick
                                                                                : Color.White;

      m_DataGridViewDuplicateFiles.Rows[e.RowIndex].DefaultCellStyle.ForeColor = row.IsMarkedForDelete
                                                                                 ? Color.White
                                                                                 : Color.Black;

      // Set correcte icon
      string imageTag = DeleteTag;
      if( null != ( (Bitmap)m_DataGridViewDuplicateFiles.Rows[e.RowIndex].Cells[1].Value ).Tag )
      {
       imageTag = ((Bitmap) m_DataGridViewDuplicateFiles.Rows[e.RowIndex].Cells[1].Value).Tag.ToString();
      }
      if( ( row.IsMarkedForDelete && imageTag == DeleteTag) || ( !row.IsMarkedForDelete && imageTag == UndeleteTag ))
      {
        Bitmap img = row.IsMarkedForDelete 
                       ? Resources._1308841035_Undo
                       : Resources._1309256835_Delete;
        img.Tag = row.IsMarkedForDelete ? UndeleteTag : DeleteTag;
        m_DataGridViewDuplicateFiles.Rows[e.RowIndex].Cells[1].Value = img;
      }
      if( m_DataGridViewDuplicateFiles.CurrentRow == null || e.RowIndex != m_DataGridViewDuplicateFiles.CurrentRow.Index )
      {
        m_DataGridViewDuplicateFiles.Rows[e.RowIndex].Visible = !row.IsDeleted;
      }

    }
  }
}
