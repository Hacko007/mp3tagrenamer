using System;
using System.Windows.Forms;

namespace Mp3TagEditor.ManageDuplicates
{
  public partial class FindDuplicates : UserControl
  {
    public FindDuplicates()
    {
      InitializeComponent();
      OnFindDuplictesSettingsSelectedFoldersChanged(this, EventArgs.Empty);
    }

    private void OnFindDuplictesSettingsSelectedFoldersChanged( object sender, EventArgs e )
    {
      m_TabPageSearchForDuplicates.Enabled = m_FindDuplictesSettings.SelectedFolders != null &&
                                             m_FindDuplictesSettings.SelectedFolders.Count != 0;
      m_DuplicateList.SelectedFolders = m_FindDuplictesSettings.SelectedFolders;
    }

    public void OnLoad()
    {
      m_FindDuplictesSettings.OnLoad();
      m_DuplicateList.OnLoad();
    }

    public void OnClosing()
    {
      m_FindDuplictesSettings.OnClosing();
      m_DuplicateList.OnClosing();
    }
  }
}
