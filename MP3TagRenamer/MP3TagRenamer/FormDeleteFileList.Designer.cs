namespace MP3TagRenamer
{
    partial class FormDeleteFileList
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeleteFileList));
      this.panel1 = new System.Windows.Forms.Panel();
      this.my_checkedListBox_FilesPaths = new System.Windows.Forms.CheckedListBox();
      this.panel_selectButtons = new System.Windows.Forms.Panel();
      this.button_Unselect = new System.Windows.Forms.Button();
      this.button_Select = new System.Windows.Forms.Button();
      this.panel_okcancel = new System.Windows.Forms.Panel();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.button_OK = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.panel_selectButtons.SuspendLayout();
      this.panel_okcancel.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.my_checkedListBox_FilesPaths);
      this.panel1.Controls.Add(this.panel_selectButtons);
      this.panel1.Controls.Add(this.panel_okcancel);
      resources.ApplyResources(this.panel1, "panel1");
      this.panel1.Name = "panel1";
      // 
      // my_checkedListBox_FilesPaths
      // 
      this.my_checkedListBox_FilesPaths.CheckOnClick = true;
      resources.ApplyResources(this.my_checkedListBox_FilesPaths, "my_checkedListBox_FilesPaths");
      this.my_checkedListBox_FilesPaths.FormattingEnabled = true;
      this.my_checkedListBox_FilesPaths.Name = "my_checkedListBox_FilesPaths";
      this.my_checkedListBox_FilesPaths.Sorted = true;
      // 
      // panel_selectButtons
      // 
      this.panel_selectButtons.Controls.Add(this.button_Unselect);
      this.panel_selectButtons.Controls.Add(this.button_Select);
      resources.ApplyResources(this.panel_selectButtons, "panel_selectButtons");
      this.panel_selectButtons.Name = "panel_selectButtons";
      // 
      // button_Unselect
      // 
      resources.ApplyResources(this.button_Unselect, "button_Unselect");
      this.button_Unselect.Name = "button_Unselect";
      this.button_Unselect.UseVisualStyleBackColor = true;
      // 
      // button_Select
      // 
      resources.ApplyResources(this.button_Select, "button_Select");
      this.button_Select.Name = "button_Select";
      this.button_Select.UseVisualStyleBackColor = true;
      // 
      // panel_okcancel
      // 
      this.panel_okcancel.Controls.Add(this.button_Cancel);
      this.panel_okcancel.Controls.Add(this.button_OK);
      resources.ApplyResources(this.panel_okcancel, "panel_okcancel");
      this.panel_okcancel.Name = "panel_okcancel";
      // 
      // button_Cancel
      // 
      this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      resources.ApplyResources(this.button_Cancel, "button_Cancel");
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.UseVisualStyleBackColor = true;
      // 
      // button_OK
      // 
      this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
      resources.ApplyResources(this.button_OK, "button_OK");
      this.button_OK.Name = "button_OK";
      this.button_OK.UseVisualStyleBackColor = true;
      this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
      // 
      // FormDeleteFileList
      // 
      this.AcceptButton = this.button_OK;
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.button_Cancel;
      this.Controls.Add(this.panel1);
      this.MinimizeBox = false;
      this.Name = "FormDeleteFileList";
      this.panel1.ResumeLayout(false);
      this.panel_selectButtons.ResumeLayout(false);
      this.panel_okcancel.ResumeLayout(false);
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox my_checkedListBox_FilesPaths;
        private System.Windows.Forms.Panel panel_selectButtons;
        private System.Windows.Forms.Panel panel_okcancel;
        private System.Windows.Forms.Button button_Unselect;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
    }
}