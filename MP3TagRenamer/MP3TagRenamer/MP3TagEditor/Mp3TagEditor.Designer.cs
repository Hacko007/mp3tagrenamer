namespace Mp3TagEditor.UI.MP3TagEditor
{
    partial class Mp3TagEditor
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
            this.components = new System.ComponentModel.Container();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.Button_Undo = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.Button_Update = new System.Windows.Forms.Button();
            this.panel_middle = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.my_checkBox_v1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.my_comboBox_v1_ganre = new System.Windows.Forms.ComboBox();
            this.my_iD3v1TagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.my_textBox_v1_title = new System.Windows.Forms.TextBox();
            this.my_textBox_v1_tracknr = new System.Windows.Forms.TextBox();
            this.my_textBox_v1_artist = new System.Windows.Forms.TextBox();
            this.my_textBox_v1_album = new System.Windows.Forms.TextBox();
            this.my_textBox_v1_year = new System.Windows.Forms.TextBox();
            this.my_textBox_v1_comment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.my_checkBox_v2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.my_comboBox_v2_ganre = new System.Windows.Forms.ComboBox();
            this.my_iD3v23TagBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.my_textBox_v2_title = new System.Windows.Forms.TextBox();
            this.my_textBox_v2_tracknr = new System.Windows.Forms.TextBox();
            this.my_textBox_v2_artist = new System.Windows.Forms.TextBox();
            this.my_textBox_v2_album = new System.Windows.Forms.TextBox();
            this.my_textBox_v2_year = new System.Windows.Forms.TextBox();
            this.my_textBox_v2_comment = new System.Windows.Forms.TextBox();
            this.panel_top = new System.Windows.Forms.Panel();
            this.My_TextBox_Path = new System.Windows.Forms.TextBox();
            this.my_ultraID3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Button_Close = new System.Windows.Forms.Button();
            this.main_panel.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_middle.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_iD3v1TagBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_iD3v23TagBindingSource)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_ultraID3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.Controls.Add(this.panel_bottom);
            this.main_panel.Controls.Add(this.panel_middle);
            this.main_panel.Controls.Add(this.panel_top);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(747, 405);
            this.main_panel.TabIndex = 0;
            // 
            // panel_bottom
            // 
            this.panel_bottom.BackColor = System.Drawing.Color.Gray;
            this.panel_bottom.Controls.Add(this.Button_Undo);
            this.panel_bottom.Controls.Add(this.Button_Cancel);
            this.panel_bottom.Controls.Add(this.Button_Update);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 363);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(747, 42);
            this.panel_bottom.TabIndex = 3;
            // 
            // Button_Undo
            // 
            this.Button_Undo.BackColor = System.Drawing.Color.Black;
            this.Button_Undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Undo.ForeColor = System.Drawing.Color.White;
            this.Button_Undo.Location = new System.Drawing.Point(609, 10);
            this.Button_Undo.Name = "Button_Undo";
            this.Button_Undo.Size = new System.Drawing.Size(126, 23);
            this.Button_Undo.TabIndex = 2;
            this.Button_Undo.Text = "Un&do";
            this.Button_Undo.UseVisualStyleBackColor = false;
            this.Button_Undo.Click += new System.EventHandler(this.Button_Undo_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.BackColor = System.Drawing.Color.Black;
            this.Button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Cancel.ForeColor = System.Drawing.Color.White;
            this.Button_Cancel.Location = new System.Drawing.Point(475, 10);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(126, 23);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "&Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = false;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // Button_Update
            // 
            this.Button_Update.BackColor = System.Drawing.Color.Black;
            this.Button_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.Button_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Update.ForeColor = System.Drawing.Color.White;
            this.Button_Update.Location = new System.Drawing.Point(341, 10);
            this.Button_Update.Name = "Button_Update";
            this.Button_Update.Size = new System.Drawing.Size(126, 23);
            this.Button_Update.TabIndex = 0;
            this.Button_Update.Text = "&Update";
            this.Button_Update.UseVisualStyleBackColor = false;
            this.Button_Update.Click += new System.EventHandler(this.Button_Update_Click);
            // 
            // panel_middle
            // 
            this.panel_middle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel_middle.Controls.Add(this.groupBox3);
            this.panel_middle.Controls.Add(this.groupBox2);
            this.panel_middle.Controls.Add(this.groupBox1);
            this.panel_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_middle.Location = new System.Drawing.Point(0, 26);
            this.panel_middle.Name = "panel_middle";
            this.panel_middle.Size = new System.Drawing.Size(747, 379);
            this.panel_middle.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(3, 212);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 117);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MPEG info";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.my_checkBox_v1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.my_comboBox_v1_ganre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.my_textBox_v1_title);
            this.groupBox2.Controls.Add(this.my_textBox_v1_tracknr);
            this.groupBox2.Controls.Add(this.my_textBox_v1_artist);
            this.groupBox2.Controls.Add(this.my_textBox_v1_album);
            this.groupBox2.Controls.Add(this.my_textBox_v1_year);
            this.groupBox2.Controls.Add(this.my_textBox_v1_comment);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 14);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 192);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ID3v1";
            // 
            // my_checkBox_v1
            // 
            this.my_checkBox_v1.AutoSize = true;
            this.my_checkBox_v1.Location = new System.Drawing.Point(64, 21);
            this.my_checkBox_v1.Name = "my_checkBox_v1";
            this.my_checkBox_v1.Size = new System.Drawing.Size(73, 17);
            this.my_checkBox_v1.TabIndex = 47;
            this.my_checkBox_v1.Text = "ID3v1 tag";
            this.my_checkBox_v1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ganre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // my_comboBox_v1_ganre
            // 
            this.my_comboBox_v1_ganre.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.my_iD3v1TagBindingSource, "Genre", true));
            this.my_comboBox_v1_ganre.FormattingEnabled = true;
            this.my_comboBox_v1_ganre.Location = new System.Drawing.Point(177, 133);
            this.my_comboBox_v1_ganre.Name = "my_comboBox_v1_ganre";
            this.my_comboBox_v1_ganre.Size = new System.Drawing.Size(172, 21);
            this.my_comboBox_v1_ganre.TabIndex = 45;
            // 
            // my_iD3v1TagBindingSource
            // 
            this.my_iD3v1TagBindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.ID3v1Tag);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Artist";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Album";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Year";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Comment";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(257, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Track#";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // my_textBox_v1_title
            // 
            this.my_textBox_v1_title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v1TagBindingSource, "Title", true));
            this.my_textBox_v1_title.Location = new System.Drawing.Point(64, 49);
            this.my_textBox_v1_title.Name = "my_textBox_v1_title";
            this.my_textBox_v1_title.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v1_title.TabIndex = 25;
            // 
            // my_textBox_v1_tracknr
            // 
            this.my_textBox_v1_tracknr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v1TagBindingSource, "TrackNum", true));
            this.my_textBox_v1_tracknr.Location = new System.Drawing.Point(305, 21);
            this.my_textBox_v1_tracknr.Name = "my_textBox_v1_tracknr";
            this.my_textBox_v1_tracknr.Size = new System.Drawing.Size(44, 20);
            this.my_textBox_v1_tracknr.TabIndex = 24;
            // 
            // my_textBox_v1_artist
            // 
            this.my_textBox_v1_artist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v1TagBindingSource, "Artist", true));
            this.my_textBox_v1_artist.Location = new System.Drawing.Point(64, 77);
            this.my_textBox_v1_artist.Name = "my_textBox_v1_artist";
            this.my_textBox_v1_artist.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v1_artist.TabIndex = 26;
            // 
            // my_textBox_v1_album
            // 
            this.my_textBox_v1_album.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v1TagBindingSource, "Album", true));
            this.my_textBox_v1_album.Location = new System.Drawing.Point(64, 105);
            this.my_textBox_v1_album.Name = "my_textBox_v1_album";
            this.my_textBox_v1_album.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v1_album.TabIndex = 27;
            // 
            // my_textBox_v1_year
            // 
            this.my_textBox_v1_year.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v1TagBindingSource, "Year", true));
            this.my_textBox_v1_year.Location = new System.Drawing.Point(64, 133);
            this.my_textBox_v1_year.Name = "my_textBox_v1_year";
            this.my_textBox_v1_year.Size = new System.Drawing.Size(51, 20);
            this.my_textBox_v1_year.TabIndex = 28;
            // 
            // my_textBox_v1_comment
            // 
            this.my_textBox_v1_comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v1TagBindingSource, "Comments", true));
            this.my_textBox_v1_comment.Location = new System.Drawing.Point(64, 161);
            this.my_textBox_v1_comment.Name = "my_textBox_v1_comment";
            this.my_textBox_v1_comment.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v1_comment.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.my_checkBox_v2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.my_comboBox_v2_ganre);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.my_textBox_v2_title);
            this.groupBox1.Controls.Add(this.my_textBox_v2_tracknr);
            this.groupBox1.Controls.Add(this.my_textBox_v2_artist);
            this.groupBox1.Controls.Add(this.my_textBox_v2_album);
            this.groupBox1.Controls.Add(this.my_textBox_v2_year);
            this.groupBox1.Controls.Add(this.my_textBox_v2_comment);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(364, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 244);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID3v2";
            // 
            // my_checkBox_v2
            // 
            this.my_checkBox_v2.AutoSize = true;
            this.my_checkBox_v2.Location = new System.Drawing.Point(64, 23);
            this.my_checkBox_v2.Name = "my_checkBox_v2";
            this.my_checkBox_v2.Size = new System.Drawing.Size(73, 17);
            this.my_checkBox_v2.TabIndex = 48;
            this.my_checkBox_v2.Text = "ID3v2 tag";
            this.my_checkBox_v2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(135, 136);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Ganre";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // my_comboBox_v2_ganre
            // 
            this.my_comboBox_v2_ganre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "Genre", true));
            this.my_comboBox_v2_ganre.FormattingEnabled = true;
            this.my_comboBox_v2_ganre.Location = new System.Drawing.Point(177, 133);
            this.my_comboBox_v2_ganre.Name = "my_comboBox_v2_ganre";
            this.my_comboBox_v2_ganre.Size = new System.Drawing.Size(172, 21);
            this.my_comboBox_v2_ganre.TabIndex = 45;
            // 
            // my_iD3v23TagBindingSource
            // 
            this.my_iD3v23TagBindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.ID3v2Tag);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(31, 52);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(27, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "Title";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(28, 80);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(30, 13);
            this.label23.TabIndex = 43;
            this.label23.Text = "Artist";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(22, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(36, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "Album";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(29, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Year";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(7, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Comment";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(257, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Track#";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // my_textBox_v2_title
            // 
            this.my_textBox_v2_title.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "Title", true));
            this.my_textBox_v2_title.Location = new System.Drawing.Point(64, 49);
            this.my_textBox_v2_title.Name = "my_textBox_v2_title";
            this.my_textBox_v2_title.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v2_title.TabIndex = 25;
            // 
            // my_textBox_v2_tracknr
            // 
            this.my_textBox_v2_tracknr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "TrackNum", true));
            this.my_textBox_v2_tracknr.Location = new System.Drawing.Point(305, 21);
            this.my_textBox_v2_tracknr.Name = "my_textBox_v2_tracknr";
            this.my_textBox_v2_tracknr.Size = new System.Drawing.Size(44, 20);
            this.my_textBox_v2_tracknr.TabIndex = 24;
            // 
            // my_textBox_v2_artist
            // 
            this.my_textBox_v2_artist.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "Artist", true));
            this.my_textBox_v2_artist.Location = new System.Drawing.Point(64, 77);
            this.my_textBox_v2_artist.Name = "my_textBox_v2_artist";
            this.my_textBox_v2_artist.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v2_artist.TabIndex = 26;
            // 
            // my_textBox_v2_album
            // 
            this.my_textBox_v2_album.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "Album", true));
            this.my_textBox_v2_album.Location = new System.Drawing.Point(64, 105);
            this.my_textBox_v2_album.Name = "my_textBox_v2_album";
            this.my_textBox_v2_album.Size = new System.Drawing.Size(285, 20);
            this.my_textBox_v2_album.TabIndex = 27;
            // 
            // my_textBox_v2_year
            // 
            this.my_textBox_v2_year.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "Year", true));
            this.my_textBox_v2_year.Location = new System.Drawing.Point(64, 133);
            this.my_textBox_v2_year.Name = "my_textBox_v2_year";
            this.my_textBox_v2_year.Size = new System.Drawing.Size(51, 20);
            this.my_textBox_v2_year.TabIndex = 28;
            // 
            // my_textBox_v2_comment
            // 
            this.my_textBox_v2_comment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_iD3v23TagBindingSource, "Comments", true));
            this.my_textBox_v2_comment.Location = new System.Drawing.Point(64, 161);
            this.my_textBox_v2_comment.Multiline = true;
            this.my_textBox_v2_comment.Name = "my_textBox_v2_comment";
            this.my_textBox_v2_comment.Size = new System.Drawing.Size(285, 69);
            this.my_textBox_v2_comment.TabIndex = 29;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.Silver;
            this.panel_top.Controls.Add(this.My_TextBox_Path);
            this.panel_top.Controls.Add(this.Button_Close);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(747, 26);
            this.panel_top.TabIndex = 2;
            // 
            // My_TextBox_Path
            // 
            this.My_TextBox_Path.BackColor = System.Drawing.Color.Silver;
            this.My_TextBox_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.My_TextBox_Path.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.my_ultraID3BindingSource, "FileName", true));
            this.My_TextBox_Path.ForeColor = System.Drawing.Color.Black;
            this.My_TextBox_Path.Location = new System.Drawing.Point(3, 3);
            this.My_TextBox_Path.Name = "My_TextBox_Path";
            this.My_TextBox_Path.ReadOnly = true;
            this.My_TextBox_Path.Size = new System.Drawing.Size(719, 20);
            this.My_TextBox_Path.TabIndex = 1;
            // 
            // my_ultraID3BindingSource
            // 
            this.my_ultraID3BindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Webdings", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.Button_Close.Location = new System.Drawing.Point(725, 0);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(22, 23);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.Text = "r";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Mp3TagEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Button_Cancel;
            this.ClientSize = new System.Drawing.Size(747, 405);
            this.ControlBox = false;
            this.Controls.Add(this.main_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Mp3TagEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Tag Editor";
            this.main_panel.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_middle.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_iD3v1TagBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_iD3v23TagBindingSource)).EndInit();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.my_ultraID3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Panel panel_middle;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox my_textBox_v2_comment;
        private System.Windows.Forms.TextBox my_textBox_v2_year;
        private System.Windows.Forms.TextBox my_textBox_v2_album;
        private System.Windows.Forms.TextBox my_textBox_v2_artist;
        private System.Windows.Forms.TextBox my_textBox_v2_title;
        private System.Windows.Forms.TextBox my_textBox_v2_tracknr;
        private System.Windows.Forms.ComboBox my_comboBox_v2_ganre;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox my_comboBox_v1_ganre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox my_textBox_v1_title;
        private System.Windows.Forms.TextBox my_textBox_v1_tracknr;
        private System.Windows.Forms.TextBox my_textBox_v1_artist;
        private System.Windows.Forms.TextBox my_textBox_v1_album;
        private System.Windows.Forms.TextBox my_textBox_v1_year;
        private System.Windows.Forms.TextBox my_textBox_v1_comment;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Button_Undo;
        private System.Windows.Forms.Button Button_Cancel;
        private System.Windows.Forms.Button Button_Update;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox My_TextBox_Path;
        private System.Windows.Forms.CheckBox my_checkBox_v1;
        private System.Windows.Forms.CheckBox my_checkBox_v2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource my_ultraID3BindingSource;
        private System.Windows.Forms.BindingSource my_iD3v23TagBindingSource;
        private System.Windows.Forms.BindingSource my_iD3v1TagBindingSource;
    }
}