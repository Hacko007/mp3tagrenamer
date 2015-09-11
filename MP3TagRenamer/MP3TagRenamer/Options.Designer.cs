namespace Mp3TagEditor.UI
{
  partial class Options
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
      this.m_TabControl = new System.Windows.Forms.TabControl();
      this.m_TabPageLanguage = new System.Windows.Forms.TabPage();
      this.language1 = new Language();
      this.m_TabPageAbout = new System.Windows.Forms.TabPage();
      this.about1 = new About();
      this.m_TabControl.SuspendLayout();
      this.m_TabPageLanguage.SuspendLayout();
      this.m_TabPageAbout.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_TabControl
      // 
      this.m_TabControl.Controls.Add(this.m_TabPageLanguage);
      this.m_TabControl.Controls.Add(this.m_TabPageAbout);
      this.m_TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_TabControl.Location = new System.Drawing.Point(0, 0);
      this.m_TabControl.Name = "m_TabControl";
      this.m_TabControl.SelectedIndex = 0;
      this.m_TabControl.Size = new System.Drawing.Size(489, 314);
      this.m_TabControl.TabIndex = 0;
      // 
      // m_TabPageLanguage
      // 
      this.m_TabPageLanguage.Controls.Add(this.language1);
      this.m_TabPageLanguage.Location = new System.Drawing.Point(4, 22);
      this.m_TabPageLanguage.Name = "m_TabPageLanguage";
      this.m_TabPageLanguage.Padding = new System.Windows.Forms.Padding(3);
      this.m_TabPageLanguage.Size = new System.Drawing.Size(481, 288);
      this.m_TabPageLanguage.TabIndex = 0;
      this.m_TabPageLanguage.Text = "Language";
      this.m_TabPageLanguage.UseVisualStyleBackColor = true;
      // 
      // language1
      // 
      this.language1.Location = new System.Drawing.Point(6, 6);
      this.language1.Name = "language1";
      this.language1.Size = new System.Drawing.Size(311, 197);
      this.language1.TabIndex = 0;
      // 
      // m_TabPageAbout
      // 
      this.m_TabPageAbout.Controls.Add(this.about1);
      this.m_TabPageAbout.Location = new System.Drawing.Point(4, 22);
      this.m_TabPageAbout.Name = "m_TabPageAbout";
      this.m_TabPageAbout.Size = new System.Drawing.Size(481, 288);
      this.m_TabPageAbout.TabIndex = 1;
      this.m_TabPageAbout.Text = "About";
      this.m_TabPageAbout.UseVisualStyleBackColor = true;
      // 
      // about1
      // 
      this.about1.Location = new System.Drawing.Point(0, 9);
      this.about1.Name = "about1";
      this.about1.Padding = new System.Windows.Forms.Padding(9);
      this.about1.Size = new System.Drawing.Size(435, 283);
      this.about1.TabIndex = 0;
      // 
      // Options
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_TabControl);
      this.Name = "Options";
      this.Size = new System.Drawing.Size(489, 314);
      this.m_TabControl.ResumeLayout(false);
      this.m_TabPageLanguage.ResumeLayout(false);
      this.m_TabPageAbout.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl m_TabControl;
    private System.Windows.Forms.TabPage m_TabPageLanguage;
    private Language language1;
    private System.Windows.Forms.TabPage m_TabPageAbout;
    private About about1;
  }
}
