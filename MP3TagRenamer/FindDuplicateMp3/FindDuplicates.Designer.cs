namespace FindDuplicateMp3s
{
  public partial class FindDuplicates
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if( disposing && ( components != null ) )
      {
        components.Dispose();
      }
      base.Dispose( disposing );
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDuplicates));
      this.m_TabControlWizard = new System.Windows.Forms.TabControl();
      this.m_TabPageDirectoryList = new System.Windows.Forms.TabPage();
      this.m_FindDuplictesSettings = new FindDuplicateMp3s.DirectoryList();
      this.m_TabPageSearchForDuplicates = new System.Windows.Forms.TabPage();
      this.m_DuplicateList = new FindDuplicateMp3s.DuplicateList();
      this.m_ImageList = new System.Windows.Forms.ImageList(this.components);
      this.m_TabControlWizard.SuspendLayout();
      this.m_TabPageDirectoryList.SuspendLayout();
      this.m_TabPageSearchForDuplicates.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_TabControlWizard
      // 
      this.m_TabControlWizard.Controls.Add(this.m_TabPageDirectoryList);
      this.m_TabControlWizard.Controls.Add(this.m_TabPageSearchForDuplicates);
      this.m_TabControlWizard.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_TabControlWizard.ImageList = this.m_ImageList;
      this.m_TabControlWizard.Location = new System.Drawing.Point(0, 0);
      this.m_TabControlWizard.Name = "m_TabControlWizard";
      this.m_TabControlWizard.SelectedIndex = 0;
      this.m_TabControlWizard.Size = new System.Drawing.Size(821, 446);
      this.m_TabControlWizard.TabIndex = 0;
      // 
      // m_TabPageDirectoryList
      // 
      this.m_TabPageDirectoryList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.m_TabPageDirectoryList.Controls.Add(this.m_FindDuplictesSettings);
      this.m_TabPageDirectoryList.ImageIndex = 0;
      this.m_TabPageDirectoryList.Location = new System.Drawing.Point(4, 23);
      this.m_TabPageDirectoryList.Name = "m_TabPageDirectoryList";
      this.m_TabPageDirectoryList.Padding = new System.Windows.Forms.Padding(3);
      this.m_TabPageDirectoryList.Size = new System.Drawing.Size(813, 419);
      this.m_TabPageDirectoryList.TabIndex = 0;
      this.m_TabPageDirectoryList.Text = "Search paths";
      this.m_TabPageDirectoryList.UseVisualStyleBackColor = true;
      // 
      // m_FindDuplictesSettings
      // 
      this.m_FindDuplictesSettings.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_FindDuplictesSettings.Location = new System.Drawing.Point(3, 3);
      this.m_FindDuplictesSettings.Name = "m_FindDuplictesSettings";
      this.m_FindDuplictesSettings.Size = new System.Drawing.Size(807, 413);
      this.m_FindDuplictesSettings.TabIndex = 0;
      this.m_FindDuplictesSettings.SelectedFoldersChanged += new System.EventHandler(this.OnFindDuplictesSettingsSelectedFoldersChanged);
      // 
      // m_TabPageSearchForDuplicates
      // 
      this.m_TabPageSearchForDuplicates.Controls.Add(this.m_DuplicateList);
      this.m_TabPageSearchForDuplicates.ImageIndex = 1;
      this.m_TabPageSearchForDuplicates.Location = new System.Drawing.Point(4, 23);
      this.m_TabPageSearchForDuplicates.Name = "m_TabPageSearchForDuplicates";
      this.m_TabPageSearchForDuplicates.Padding = new System.Windows.Forms.Padding(3);
      this.m_TabPageSearchForDuplicates.Size = new System.Drawing.Size(813, 419);
      this.m_TabPageSearchForDuplicates.TabIndex = 1;
      this.m_TabPageSearchForDuplicates.Text = "Search for duplicates";
      this.m_TabPageSearchForDuplicates.UseVisualStyleBackColor = true;
      // 
      // m_DuplicateList
      // 
      this.m_DuplicateList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_DuplicateList.Location = new System.Drawing.Point(3, 3);
      this.m_DuplicateList.Name = "m_DuplicateList";
      this.m_DuplicateList.SelectedFolders = null;
      this.m_DuplicateList.Size = new System.Drawing.Size(807, 413);
      this.m_DuplicateList.TabIndex = 0;
      // 
      // m_ImageList
      // 
      this.m_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ImageList.ImageStream")));
      this.m_ImageList.TransparentColor = System.Drawing.Color.Transparent;
      this.m_ImageList.Images.SetKeyName(0, "1308839315_Folder-Searches.ico");
      this.m_ImageList.Images.SetKeyName(1, "1308840793_Search.ico");
      // 
      // FindDuplicates
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_TabControlWizard);
      this.Name = "FindDuplicates";
      this.Size = new System.Drawing.Size(821, 446);
      this.m_TabControlWizard.ResumeLayout(false);
      this.m_TabPageDirectoryList.ResumeLayout(false);
      this.m_TabPageSearchForDuplicates.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl m_TabControlWizard;
    private System.Windows.Forms.TabPage m_TabPageDirectoryList;
    private System.Windows.Forms.TabPage m_TabPageSearchForDuplicates;
    private DirectoryList m_FindDuplictesSettings;
    private DuplicateList m_DuplicateList;
    private System.Windows.Forms.ImageList m_ImageList;
  }
}
