namespace FindDuplicateMp3s
{
  partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.findDuplicates1 = new FindDuplicateMp3s.FindDuplicates();
      this.SuspendLayout();
      // 
      // findDuplicates1
      // 
      this.findDuplicates1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.findDuplicates1.Location = new System.Drawing.Point(0, 0);
      this.findDuplicates1.Name = "findDuplicates1";
      this.findDuplicates1.Size = new System.Drawing.Size(1004, 708);
      this.findDuplicates1.TabIndex = 0;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1004, 708);
      this.Controls.Add(this.findDuplicates1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Form1";
      this.Text = "Find duplicate MP3 files";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
      this.Load += new System.EventHandler(this.OnLoad);
      this.ResumeLayout(false);

    }

    #endregion

    private FindDuplicates findDuplicates1;
  }
}

