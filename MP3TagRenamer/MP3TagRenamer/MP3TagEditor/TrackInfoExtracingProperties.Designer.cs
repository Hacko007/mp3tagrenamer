namespace Mp3TagEditor.UI.MP3TagEditor
{
    partial class TrackInfoExtracingProperties
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
            if ( disposing && ( components != null ) )
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
            this.TextBox_Album = new System.Windows.Forms.TextBox();
            this.TextBox_Artist = new System.Windows.Forms.TextBox();
            this.TextBox_Title = new System.Windows.Forms.TextBox();
            this.TextBox_Year = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Update = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_TrackNr = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TextBox_Album
            // 
            this.TextBox_Album.DataBindings.Add( new System.Windows.Forms.Binding( "Text" , global::Mp3TagEditor.UI.Properties.Settings.Default , "regex_album" , true , System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
            this.TextBox_Album.Location = new System.Drawing.Point( 69 , 26 );
            this.TextBox_Album.Name = "TextBox_Album";
            this.TextBox_Album.Size = new System.Drawing.Size( 261 , 20 );
            this.TextBox_Album.TabIndex = 0;
            this.TextBox_Album.Text = global::Mp3TagEditor.UI.Properties.Settings.Default.regex_album;
            // 
            // TextBox_Artist
            // 
            this.TextBox_Artist.DataBindings.Add( new System.Windows.Forms.Binding( "Text" , global::Mp3TagEditor.UI.Properties.Settings.Default , "regex_artist" , true , System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
            this.TextBox_Artist.Location = new System.Drawing.Point( 69 , 54 );
            this.TextBox_Artist.Name = "TextBox_Artist";
            this.TextBox_Artist.Size = new System.Drawing.Size( 261 , 20 );
            this.TextBox_Artist.TabIndex = 1;
            this.TextBox_Artist.Text = global::Mp3TagEditor.UI.Properties.Settings.Default.regex_artist;
            // 
            // TextBox_Title
            // 
            this.TextBox_Title.DataBindings.Add( new System.Windows.Forms.Binding( "Text" , global::Mp3TagEditor.UI.Properties.Settings.Default , "regex_titel" , true , System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
            this.TextBox_Title.Location = new System.Drawing.Point( 69 , 82 );
            this.TextBox_Title.Name = "TextBox_Title";
            this.TextBox_Title.Size = new System.Drawing.Size( 261 , 20 );
            this.TextBox_Title.TabIndex = 2;
            this.TextBox_Title.Text = global::Mp3TagEditor.UI.Properties.Settings.Default.regex_titel;
            // 
            // TextBox_Year
            // 
            this.TextBox_Year.DataBindings.Add( new System.Windows.Forms.Binding( "Text" , global::Mp3TagEditor.UI.Properties.Settings.Default , "regex_year" , true , System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
            this.TextBox_Year.Location = new System.Drawing.Point( 69 , 110 );
            this.TextBox_Year.Name = "TextBox_Year";
            this.TextBox_Year.Size = new System.Drawing.Size( 261 , 20 );
            this.TextBox_Year.TabIndex = 3;
            this.TextBox_Year.Text = global::Mp3TagEditor.UI.Properties.Settings.Default.regex_year;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12 , 29 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 36 , 13 );
            this.label1.TabIndex = 4;
            this.label1.Text = "Album";
            // 
            // Button_Update
            // 
            this.Button_Update.Location = new System.Drawing.Point( 371 , 24 );
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size( 134 , 23 );
            this.Button_Update.TabIndex = 5;
            this.Button_Update.Text = "Update";
            this.Button_Update.UseVisualStyleBackColor = true;
            this.Button_Update.Click += new System.EventHandler( this.Button_Update_Click );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 12 , 57 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 30 , 13 );
            this.label2.TabIndex = 6;
            this.label2.Text = "Artist";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 12 , 82 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 27 , 13 );
            this.label3.TabIndex = 7;
            this.label3.Text = "Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 10 , 113 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 29 , 13 );
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point( 10 , 139 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 47 , 13 );
            this.label5.TabIndex = 9;
            this.label5.Text = "Track nr";
            // 
            // TextBox_TrackNr
            // 
            this.TextBox_TrackNr.DataBindings.Add( new System.Windows.Forms.Binding( "Text" , global::Mp3TagEditor.UI.Properties.Settings.Default , "regex_tracknr" , true , System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged ) );
            this.TextBox_TrackNr.Location = new System.Drawing.Point( 69 , 136 );
            this.TextBox_TrackNr.Name = "TextBox_TrackNr";
            this.TextBox_TrackNr.Size = new System.Drawing.Size( 261 , 20 );
            this.TextBox_TrackNr.TabIndex = 10;
            this.TextBox_TrackNr.Text = global::Mp3TagEditor.UI.Properties.Settings.Default.regex_tracknr;
            // 
            // TrackInfoExtracingProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F , 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 520 , 189 );
            this.Controls.Add( this.TextBox_TrackNr );
            this.Controls.Add( this.label5 );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.Button_Update );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.TextBox_Year );
            this.Controls.Add( this.TextBox_Title );
            this.Controls.Add( this.TextBox_Artist );
            this.Controls.Add( this.TextBox_Album );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TrackInfoExtracingProperties";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Track Info Extracing Properties";
            this.ResumeLayout( false );
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TextBox_Album;
        public System.Windows.Forms.TextBox TextBox_Artist;
        public System.Windows.Forms.TextBox TextBox_Title;
        public System.Windows.Forms.TextBox TextBox_Year;
        public System.Windows.Forms.TextBox TextBox_TrackNr;
    }
}