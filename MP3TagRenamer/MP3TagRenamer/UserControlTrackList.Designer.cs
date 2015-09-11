namespace Mp3TagEditor.UI
{
	partial class UserControlTrackList
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTrackList));
            this.m_DataGridViewTrackList = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_BindingSourceUltraID3 = new System.Windows.Forms.BindingSource(this.components);
            this.m_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.m_UserControlFolderSelector = new Mp3TagEditor.UI.UserControlFolderSelector();
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewTrackList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceUltraID3)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_DataGridViewTrackList
            // 
            this.m_DataGridViewTrackList.AllowUserToAddRows = false;
            this.m_DataGridViewTrackList.AllowUserToOrderColumns = true;
            this.m_DataGridViewTrackList.AutoGenerateColumns = false;
            this.m_DataGridViewTrackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.m_DataGridViewTrackList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.m_DataGridViewTrackList.DataSource = this.m_BindingSourceUltraID3;
            resources.ApplyResources(this.m_DataGridViewTrackList, "m_DataGridViewTrackList");
            this.m_DataGridViewTrackList.Name = "m_DataGridViewTrackList";
            this.m_DataGridViewTrackList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.m_DataGridViewTrackList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MP3s_CellContentClick);
            this.m_DataGridViewTrackList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTrackList_CellValueChanged);
            this.m_DataGridViewTrackList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_MP3s_RowEnter);
            // 
            // dataGridViewImageColumn1
            // 
            resources.ApplyResources(this.dataGridViewImageColumn1, "dataGridViewImageColumn1");
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TrackNum";
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Artist";
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Genre";
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Album";
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Year";
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Size";
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Comments";
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Duration";
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "FileName";
            resources.ApplyResources(this.dataGridViewTextBoxColumn10, "dataGridViewTextBoxColumn10");
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // m_BindingSourceUltraID3
            // 
            this.m_BindingSourceUltraID3.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
            this.m_BindingSourceUltraID3.DataError += new System.Windows.Forms.BindingManagerDataErrorEventHandler(this.BindingSourceUltraID3_DataError);
            // 
            // buttonLoad
            // 
            resources.ApplyResources(this.buttonLoad, "buttonLoad");
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.m_UserControlFolderSelector);
            this.panelTop.Controls.Add(this.buttonLoad);
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Name = "panelTop";
            // 
            // m_UserControlFolderSelector
            // 
            this.m_UserControlFolderSelector.ActualPath = "";
            resources.ApplyResources(this.m_UserControlFolderSelector, "m_UserControlFolderSelector");
            this.m_UserControlFolderSelector.Name = "m_UserControlFolderSelector";
            this.m_UserControlFolderSelector.Paths = new string[] {
        ""};
            // 
            // UserControlTrackList
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_DataGridViewTrackList);
            this.Controls.Add(this.panelTop);
            this.Name = "UserControlTrackList";
            ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewTrackList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceUltraID3)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private UserControlFolderSelector m_UserControlFolderSelector;
        private System.Windows.Forms.DataGridView m_DataGridViewTrackList;
		private System.Windows.Forms.BindingSource m_BindingSourceUltraID3;
		private System.Windows.Forms.FolderBrowserDialog m_FolderBrowserDialog;

		/// Save statistics
		private System.Collections.Hashtable batchCounting_Artist;
		private System.Collections.Hashtable batchCounting_Album;
		private System.Collections.Hashtable batchCounting_Ganre;
		private System.Collections.Hashtable batchCounting_Year;
		private System.Collections.Hashtable m_VisitedDirsPaths;
		private string m_ActivePath;
		private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}
