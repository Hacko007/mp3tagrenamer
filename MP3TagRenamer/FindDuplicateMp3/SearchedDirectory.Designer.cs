namespace Mp3TagEditor.ManageDuplicates
{
  partial class SearchedDirectory
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchedDirectory));
      this.m_TextBoxPath = new System.Windows.Forms.TextBox();
      this.m_ButtonBrowse = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.m_ButtonRemove = new System.Windows.Forms.Button();
      this.m_CheckBoxIncludSubSirectories = new System.Windows.Forms.CheckBox();
      this.m_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.m_ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.m_FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.m_FlowLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_ErrorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // m_TextBoxPath
      // 
      this.m_TextBoxPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.m_TextBoxPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
      this.m_TextBoxPath.Location = new System.Drawing.Point(5, 8);
      this.m_TextBoxPath.Margin = new System.Windows.Forms.Padding(5, 8, 3, 3);
      this.m_TextBoxPath.Name = "m_TextBoxPath";
      this.m_TextBoxPath.Size = new System.Drawing.Size(317, 20);
      this.m_TextBoxPath.TabIndex = 0;
      this.m_TextBoxPath.TextChanged += new System.EventHandler(this.OnTextChanged);
      this.m_TextBoxPath.Validating += new System.ComponentModel.CancelEventHandler(this.OnPathValidating);
      // 
      // m_ButtonBrowse
      // 
      this.m_ButtonBrowse.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
      this.m_ButtonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.m_ButtonBrowse.ImageIndex = 0;
      this.m_ButtonBrowse.ImageList = this.imageList1;
      this.m_ButtonBrowse.Location = new System.Drawing.Point(330, 5);
      this.m_ButtonBrowse.Margin = new System.Windows.Forms.Padding(5);
      this.m_ButtonBrowse.Name = "m_ButtonBrowse";
      this.m_ButtonBrowse.Size = new System.Drawing.Size(33, 26);
      this.m_ButtonBrowse.TabIndex = 1;
      this.m_ButtonBrowse.TextAlign = System.Drawing.ContentAlignment.BottomRight;
      this.m_ButtonBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      this.m_ToolTip.SetToolTip(this.m_ButtonBrowse, "Browse directory");
      this.m_ButtonBrowse.UseVisualStyleBackColor = true;
      this.m_ButtonBrowse.Click += new System.EventHandler(this.OnBrowseClick);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "1308839897_Folder-Music-2.ico");
      this.imageList1.Images.SetKeyName(1, "1308840815_Delete.ico");
      // 
      // m_ButtonRemove
      // 
      this.m_ButtonRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.m_ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.m_ButtonRemove.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      this.m_ButtonRemove.ForeColor = System.Drawing.Color.White;
      this.m_ButtonRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.m_ButtonRemove.ImageIndex = 1;
      this.m_ButtonRemove.ImageList = this.imageList1;
      this.m_ButtonRemove.Location = new System.Drawing.Point(502, 5);
      this.m_ButtonRemove.Margin = new System.Windows.Forms.Padding(5);
      this.m_ButtonRemove.Name = "m_ButtonRemove";
      this.m_ButtonRemove.Size = new System.Drawing.Size(33, 26);
      this.m_ButtonRemove.TabIndex = 3;
      this.m_ButtonRemove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.m_ToolTip.SetToolTip(this.m_ButtonRemove, "Remove directory");
      this.m_ButtonRemove.UseVisualStyleBackColor = false;
      this.m_ButtonRemove.Click += new System.EventHandler(this.OnRemoveClick);
      // 
      // m_CheckBoxIncludSubSirectories
      // 
      this.m_CheckBoxIncludSubSirectories.AutoSize = true;
      this.m_CheckBoxIncludSubSirectories.Location = new System.Drawing.Point(371, 10);
      this.m_CheckBoxIncludSubSirectories.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
      this.m_CheckBoxIncludSubSirectories.Name = "m_CheckBoxIncludSubSirectories";
      this.m_CheckBoxIncludSubSirectories.Size = new System.Drawing.Size(123, 17);
      this.m_CheckBoxIncludSubSirectories.TabIndex = 2;
      this.m_CheckBoxIncludSubSirectories.Text = "Inlude subdirectories";
      this.m_CheckBoxIncludSubSirectories.UseVisualStyleBackColor = true;
      this.m_CheckBoxIncludSubSirectories.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
      // 
      // m_FlowLayoutPanel
      // 
      this.m_FlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.m_FlowLayoutPanel.Controls.Add(this.m_TextBoxPath);
      this.m_FlowLayoutPanel.Controls.Add(this.m_ButtonBrowse);
      this.m_FlowLayoutPanel.Controls.Add(this.m_CheckBoxIncludSubSirectories);
      this.m_FlowLayoutPanel.Controls.Add(this.m_ButtonRemove);
      this.m_FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_FlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.m_FlowLayoutPanel.Name = "m_FlowLayoutPanel";
      this.m_FlowLayoutPanel.Size = new System.Drawing.Size(551, 38);
      this.m_FlowLayoutPanel.TabIndex = 0;
      // 
      // m_ErrorProvider
      // 
      this.m_ErrorProvider.ContainerControl = this;
      // 
      // m_FolderBrowserDialog
      // 
      this.m_FolderBrowserDialog.ShowNewFolderButton = false;
      // 
      // m_ToolTip
      // 
      this.m_ToolTip.AutoPopDelay = 15000;
      this.m_ToolTip.InitialDelay = 500;
      this.m_ToolTip.ReshowDelay = 100;
      // 
      // SearchedDirectory
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_FlowLayoutPanel);
      this.Name = "SearchedDirectory";
      this.Size = new System.Drawing.Size(551, 38);
      this.m_FlowLayoutPanel.ResumeLayout(false);
      this.m_FlowLayoutPanel.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_ErrorProvider)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox m_TextBoxPath;
    private System.Windows.Forms.Button m_ButtonBrowse;
    private System.Windows.Forms.Button m_ButtonRemove;
    private System.Windows.Forms.CheckBox m_CheckBoxIncludSubSirectories;
    private System.Windows.Forms.FlowLayoutPanel m_FlowLayoutPanel;
    private System.Windows.Forms.ErrorProvider m_ErrorProvider;
    private System.Windows.Forms.FolderBrowserDialog m_FolderBrowserDialog;
    private System.Windows.Forms.ToolTip m_ToolTip;
    private System.Windows.Forms.ImageList imageList1;
  }
}
