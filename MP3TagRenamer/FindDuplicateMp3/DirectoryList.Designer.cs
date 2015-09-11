namespace Mp3TagEditor.ManageDuplicates
{
  partial class DirectoryList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryList));
      this.m_DirectoriesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.m_ButtonAddSearchDir = new System.Windows.Forms.Button();
      this.m_ImageList = new System.Windows.Forms.ImageList(this.components);
      this.m_PanelMain = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.m_WithButtonFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
      this.m_PanelMain.SuspendLayout();
      this.m_WithButtonFlowLayoutPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_DirectoriesFlowLayoutPanel
      // 
      this.m_DirectoriesFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_DirectoriesFlowLayoutPanel.AutoSize = true;
      this.m_DirectoriesFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.m_DirectoriesFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.m_DirectoriesFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
      this.m_DirectoriesFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
      this.m_DirectoriesFlowLayoutPanel.Name = "m_DirectoriesFlowLayoutPanel";
      this.m_DirectoriesFlowLayoutPanel.Size = new System.Drawing.Size(111, 0);
      this.m_DirectoriesFlowLayoutPanel.TabIndex = 0;
      // 
      // m_ButtonAddSearchDir
      // 
      this.m_ButtonAddSearchDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.m_ButtonAddSearchDir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.m_ButtonAddSearchDir.ImageIndex = 0;
      this.m_ButtonAddSearchDir.ImageList = this.m_ImageList;
      this.m_ButtonAddSearchDir.Location = new System.Drawing.Point(3, 3);
      this.m_ButtonAddSearchDir.Name = "m_ButtonAddSearchDir";
      this.m_ButtonAddSearchDir.Size = new System.Drawing.Size(105, 29);
      this.m_ButtonAddSearchDir.TabIndex = 1;
      this.m_ButtonAddSearchDir.Text = "Add directory";
      this.m_ButtonAddSearchDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.m_ButtonAddSearchDir.UseVisualStyleBackColor = true;
      this.m_ButtonAddSearchDir.Click += new System.EventHandler(this.OnAddSearchDirClick);
      // 
      // m_ImageList
      // 
      this.m_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ImageList.ImageStream")));
      this.m_ImageList.TransparentColor = System.Drawing.Color.Transparent;
      this.m_ImageList.Images.SetKeyName(0, "1308842465_Add.ico");
      // 
      // m_PanelMain
      // 
      this.m_PanelMain.AutoScroll = true;
      this.m_PanelMain.Controls.Add(this.label1);
      this.m_PanelMain.Controls.Add(this.m_WithButtonFlowLayoutPanel);
      this.m_PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_PanelMain.Location = new System.Drawing.Point(0, 0);
      this.m_PanelMain.Name = "m_PanelMain";
      this.m_PanelMain.Size = new System.Drawing.Size(615, 305);
      this.m_PanelMain.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 16);
      this.label1.TabIndex = 4;
      this.label1.Text = "Where to look:";
      // 
      // m_WithButtonFlowLayoutPanel
      // 
      this.m_WithButtonFlowLayoutPanel.AutoSize = true;
      this.m_WithButtonFlowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.m_WithButtonFlowLayoutPanel.Controls.Add(this.m_DirectoriesFlowLayoutPanel);
      this.m_WithButtonFlowLayoutPanel.Controls.Add(this.m_ButtonAddSearchDir);
      this.m_WithButtonFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
      this.m_WithButtonFlowLayoutPanel.Location = new System.Drawing.Point(6, 28);
      this.m_WithButtonFlowLayoutPanel.Name = "m_WithButtonFlowLayoutPanel";
      this.m_WithButtonFlowLayoutPanel.Size = new System.Drawing.Size(111, 35);
      this.m_WithButtonFlowLayoutPanel.TabIndex = 3;
      // 
      // DirectoryList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_PanelMain);
      this.Name = "DirectoryList";
      this.Size = new System.Drawing.Size(615, 305);
      this.m_PanelMain.ResumeLayout(false);
      this.m_PanelMain.PerformLayout();
      this.m_WithButtonFlowLayoutPanel.ResumeLayout(false);
      this.m_WithButtonFlowLayoutPanel.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.FlowLayoutPanel m_DirectoriesFlowLayoutPanel;
    private System.Windows.Forms.Button m_ButtonAddSearchDir;
    private System.Windows.Forms.Panel m_PanelMain;
    private System.Windows.Forms.FlowLayoutPanel m_WithButtonFlowLayoutPanel;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ImageList m_ImageList;
  }
}
