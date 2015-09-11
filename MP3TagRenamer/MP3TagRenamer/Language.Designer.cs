namespace Mp3TagEditor.UI
{
  partial class Language
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
      this.m_GroupBoxLanguage = new System.Windows.Forms.GroupBox();
      this.m_LabelRestart = new System.Windows.Forms.Label();
      this.m_RadioButtonBosnian = new System.Windows.Forms.RadioButton();
      this.m_RadioButtonSwedish = new System.Windows.Forms.RadioButton();
      this.m_RadioButtonEnglish = new System.Windows.Forms.RadioButton();
      this.m_GroupBoxLanguage.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_GroupBoxLanguage
      // 
      this.m_GroupBoxLanguage.Controls.Add(this.m_LabelRestart);
      this.m_GroupBoxLanguage.Controls.Add(this.m_RadioButtonBosnian);
      this.m_GroupBoxLanguage.Controls.Add(this.m_RadioButtonSwedish);
      this.m_GroupBoxLanguage.Controls.Add(this.m_RadioButtonEnglish);
      this.m_GroupBoxLanguage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_GroupBoxLanguage.Location = new System.Drawing.Point(0, 0);
      this.m_GroupBoxLanguage.Name = "m_GroupBoxLanguage";
      this.m_GroupBoxLanguage.Size = new System.Drawing.Size(255, 168);
      this.m_GroupBoxLanguage.TabIndex = 1;
      this.m_GroupBoxLanguage.TabStop = false;
      this.m_GroupBoxLanguage.Text = "Choose language";
      // 
      // m_LabelRestart
      // 
      this.m_LabelRestart.AutoSize = true;
      this.m_LabelRestart.Location = new System.Drawing.Point(24, 106);
      this.m_LabelRestart.Name = "m_LabelRestart";
      this.m_LabelRestart.Size = new System.Drawing.Size(151, 13);
      this.m_LabelRestart.TabIndex = 3;
      this.m_LabelRestart.Text = "You need to restart application";
      this.m_LabelRestart.Visible = false;
      // 
      // m_RadioButtonBosnian
      // 
      this.m_RadioButtonBosnian.AutoSize = true;
      this.m_RadioButtonBosnian.Location = new System.Drawing.Point(6, 82);
      this.m_RadioButtonBosnian.Name = "m_RadioButtonBosnian";
      this.m_RadioButtonBosnian.Size = new System.Drawing.Size(63, 17);
      this.m_RadioButtonBosnian.TabIndex = 2;
      this.m_RadioButtonBosnian.Text = "Bosnian";
      this.m_RadioButtonBosnian.UseVisualStyleBackColor = true;
      this.m_RadioButtonBosnian.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
      // 
      // m_RadioButtonSwedish
      // 
      this.m_RadioButtonSwedish.AutoSize = true;
      this.m_RadioButtonSwedish.Location = new System.Drawing.Point(6, 57);
      this.m_RadioButtonSwedish.Name = "m_RadioButtonSwedish";
      this.m_RadioButtonSwedish.Size = new System.Drawing.Size(65, 17);
      this.m_RadioButtonSwedish.TabIndex = 1;
      this.m_RadioButtonSwedish.Text = "Swedish";
      this.m_RadioButtonSwedish.UseVisualStyleBackColor = true;
      this.m_RadioButtonSwedish.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
      // 
      // m_RadioButtonEnglish
      // 
      this.m_RadioButtonEnglish.AutoSize = true;
      this.m_RadioButtonEnglish.Checked = true;
      this.m_RadioButtonEnglish.Location = new System.Drawing.Point(6, 31);
      this.m_RadioButtonEnglish.Name = "m_RadioButtonEnglish";
      this.m_RadioButtonEnglish.Size = new System.Drawing.Size(59, 17);
      this.m_RadioButtonEnglish.TabIndex = 0;
      this.m_RadioButtonEnglish.TabStop = true;
      this.m_RadioButtonEnglish.Text = "English";
      this.m_RadioButtonEnglish.UseVisualStyleBackColor = true;
      this.m_RadioButtonEnglish.CheckedChanged += new System.EventHandler(this.OnLanguageChange);
      // 
      // Language
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_GroupBoxLanguage);
      this.Name = "Language";
      this.Size = new System.Drawing.Size(255, 168);
      this.m_GroupBoxLanguage.ResumeLayout(false);
      this.m_GroupBoxLanguage.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox m_GroupBoxLanguage;
    private System.Windows.Forms.Label m_LabelRestart;
    private System.Windows.Forms.RadioButton m_RadioButtonBosnian;
    private System.Windows.Forms.RadioButton m_RadioButtonSwedish;
    private System.Windows.Forms.RadioButton m_RadioButtonEnglish;
  }
}
