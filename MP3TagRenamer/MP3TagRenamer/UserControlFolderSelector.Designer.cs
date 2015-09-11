namespace Mp3TagEditor.UI
{
    partial class UserControlFolderSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlFolderSelector));
            this.my_groupBox = new System.Windows.Forms.GroupBox();
            this.my_button_Browse = new System.Windows.Forms.Button();
            this.my_comboBox_Folder = new System.Windows.Forms.ComboBox();
            this.my_folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.my_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // my_groupBox
            // 
            resources.ApplyResources(this.my_groupBox, "my_groupBox");
            this.my_groupBox.Controls.Add(this.my_button_Browse);
            this.my_groupBox.Controls.Add(this.my_comboBox_Folder);
            this.my_groupBox.Name = "my_groupBox";
            this.my_groupBox.TabStop = false;
            // 
            // my_button_Browse
            // 
            resources.ApplyResources(this.my_button_Browse, "my_button_Browse");
            this.my_button_Browse.Name = "my_button_Browse";
            this.my_button_Browse.UseVisualStyleBackColor = true;
            this.my_button_Browse.Click += new System.EventHandler(this.Button_Browse_Click);
            // 
            // my_comboBox_Folder
            // 
            resources.ApplyResources(this.my_comboBox_Folder, "my_comboBox_Folder");
            this.my_comboBox_Folder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.my_comboBox_Folder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.my_comboBox_Folder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Mp3TagEditor.UI.Properties.Settings.Default, "LastUsedPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.my_comboBox_Folder.FormattingEnabled = true;
            this.my_comboBox_Folder.Name = "my_comboBox_Folder";
            this.my_comboBox_Folder.Text = global::Mp3TagEditor.UI.Properties.Settings.Default.LastUsedPath;
            this.my_comboBox_Folder.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFolder_SelectedIndexChanged);
            this.my_comboBox_Folder.DropDownClosed += new System.EventHandler(this.ComboBox_Folder_DropDownClosed);
            this.my_comboBox_Folder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBoxFolder_KeyDown);
            this.my_comboBox_Folder.TextChanged += new System.EventHandler(this.ComboBox_Folder_TextChanged);
            // 
            // UserControlFolderSelector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.my_groupBox);
            this.Name = "UserControlFolderSelector";
            this.my_groupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox my_groupBox;
        private System.Windows.Forms.Button my_button_Browse;
        private System.Windows.Forms.ComboBox my_comboBox_Folder;
        private System.Windows.Forms.FolderBrowserDialog my_folderBrowserDialog;
    }
}
