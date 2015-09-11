namespace Mp3TagEditor.UI
{
	partial class FormComposePressets
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComposePressets));
            this.m_GroupBoxBottom = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.m_FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonFolderSeparator = new MovableButton(this.components);
            this.buttonSeparator = new MovableButton(this.components);
            this.buttonTitle = new MovableButton(this.components);
            this.buttonTrackNr = new MovableButton(this.components);
            this.buttonYear = new MovableButton(this.components);
            this.buttonArtist = new MovableButton(this.components);
            this.buttonAlbum = new MovableButton(this.components);
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.m_GroupBoxBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_GroupBoxBottom
            // 
            this.m_GroupBoxBottom.Controls.Add(this.buttonCancel);
            this.m_GroupBoxBottom.Controls.Add(this.buttonOK);
            resources.ApplyResources(this.m_GroupBoxBottom, "m_GroupBoxBottom");
            this.m_GroupBoxBottom.Name = "m_GroupBoxBottom";
            this.m_GroupBoxBottom.TabStop = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            resources.ApplyResources(this.buttonOK, "buttonOK");
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxResult
            // 
            resources.ApplyResources(this.textBoxResult, "textBoxResult");
            this.textBoxResult.Name = "textBoxResult";
            // 
            // m_FlowLayoutPanel
            // 
            this.m_FlowLayoutPanel.AllowDrop = true;
            resources.ApplyResources(this.m_FlowLayoutPanel, "m_FlowLayoutPanel");
            this.m_FlowLayoutPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.m_FlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_FlowLayoutPanel.Name = "m_FlowLayoutPanel";
            this.m_FlowLayoutPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel_ControlChange);
            this.m_FlowLayoutPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.FlowLayoutPanel_DragDrop);
            this.m_FlowLayoutPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FlowLayoutPanel_MouseDown);
            this.m_FlowLayoutPanel.DragLeave += new System.EventHandler(this.FlowLayoutPanel_DragLeave);
            this.m_FlowLayoutPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.FlowLayoutPanel_DragEnter);
            this.m_FlowLayoutPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.FlowLayoutPanel_ControlChange);
            // 
            // buttonClear
            // 
            resources.ApplyResources(this.buttonClear, "buttonClear");
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonFolderSeparator
            // 
            resources.ApplyResources(this.buttonFolderSeparator, "buttonFolderSeparator");
            this.buttonFolderSeparator.Name = "buttonFolderSeparator";
            this.buttonFolderSeparator.UseVisualStyleBackColor = true;
            this.buttonFolderSeparator.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // buttonSeparator
            // 
            resources.ApplyResources(this.buttonSeparator, "buttonSeparator");
            this.buttonSeparator.Name = "buttonSeparator";
            this.buttonSeparator.UseVisualStyleBackColor = true;
            this.buttonSeparator.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // buttonTitle
            // 
            resources.ApplyResources(this.buttonTitle, "buttonTitle");
            this.buttonTitle.Name = "buttonTitle";
            this.buttonTitle.UseVisualStyleBackColor = true;
            this.buttonTitle.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // buttonTrackNr
            // 
            resources.ApplyResources(this.buttonTrackNr, "buttonTrackNr");
            this.buttonTrackNr.Name = "buttonTrackNr";
            this.buttonTrackNr.UseVisualStyleBackColor = true;
            this.buttonTrackNr.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // buttonYear
            // 
            resources.ApplyResources(this.buttonYear, "buttonYear");
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // buttonArtist
            // 
            resources.ApplyResources(this.buttonArtist, "buttonArtist");
            this.buttonArtist.Name = "buttonArtist";
            this.buttonArtist.UseVisualStyleBackColor = true;
            this.buttonArtist.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // buttonAlbum
            // 
            resources.ApplyResources(this.buttonAlbum, "buttonAlbum");
            this.buttonAlbum.Name = "buttonAlbum";
            this.buttonAlbum.UseVisualStyleBackColor = true;
            this.buttonAlbum.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // textBoxPath
            // 
            resources.ApplyResources(this.textBoxPath, "textBoxPath");
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            // 
            // buttonTest
            // 
            resources.ApplyResources(this.buttonTest, "buttonTest");
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelTest
            // 
            resources.ApplyResources(this.labelTest, "labelTest");
            this.labelTest.Name = "labelTest";
            // 
            // FormComposePressets
            // 
            this.AcceptButton = this.buttonOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.m_FlowLayoutPanel);
            this.Controls.Add(this.buttonFolderSeparator);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSeparator);
            this.Controls.Add(this.buttonTitle);
            this.Controls.Add(this.buttonTrackNr);
            this.Controls.Add(this.buttonYear);
            this.Controls.Add(this.buttonArtist);
            this.Controls.Add(this.buttonAlbum);
            this.Controls.Add(this.m_GroupBoxBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormComposePressets";
            this.m_GroupBoxBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox m_GroupBoxBottom;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonOK;
		private MovableButton buttonArtist;
		private MovableButton buttonYear;
		private MovableButton buttonTrackNr;
		private MovableButton buttonTitle;
		private MovableButton buttonSeparator;
		private System.Windows.Forms.TextBox textBoxResult;
		private MovableButton buttonFolderSeparator;
		private System.Windows.Forms.FlowLayoutPanel m_FlowLayoutPanel;
		private MovableButton buttonAlbum;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonTest;
		private System.Windows.Forms.Label labelTest;
	}
}