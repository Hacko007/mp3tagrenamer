using FindDuplicateMp3s;

namespace MP3TagRenamer
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.m_TabControlMain = new System.Windows.Forms.TabControl();
      this.m_TabPageRenamer = new System.Windows.Forms.TabPage();
      this.m_splitContainerRenameMain = new System.Windows.Forms.SplitContainer();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.my_label_ID3V2 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.my_label_ID3V1 = new System.Windows.Forms.Label();
      this.My_TabControl_BatchRen = new System.Windows.Forms.TabControl();
      this.m_TabPageBatch = new System.Windows.Forms.TabPage();
      this.m_UserControlBatchRenameFields = new MP3TagRenamer.UserControlBatchRenameFields();
      this.m_TabPageRenaming = new System.Windows.Forms.TabPage();
      this.GroupBox_ExtractFromFName = new System.Windows.Forms.GroupBox();
      this.m_ButtonSuggest = new System.Windows.Forms.Button();
      this.m_ButtonAddRemovePressets = new System.Windows.Forms.Button();
      this.m_LabelRealRexExpression = new System.Windows.Forms.Label();
      this.ComboBox_ExtractTagsFromFNmane = new System.Windows.Forms.ComboBox();
      this.Button_ExtractFRomFName = new System.Windows.Forms.Button();
      this.Button_regexp_properties = new System.Windows.Forms.Button();
      this.Button_ExtracFromFName_Test = new System.Windows.Forms.Button();
      this.Label_Regextpresult = new System.Windows.Forms.Label();
      this.TextBox_TestPath = new System.Windows.Forms.TextBox();
      this.m_TabPageCleaning = new System.Windows.Forms.TabPage();
      this.my_textBox_removeText = new System.Windows.Forms.TextBox();
      this.my_checkBox_UseRegExp = new System.Windows.Forms.CheckBox();
      this.my_button_ClearComments = new System.Windows.Forms.Button();
      this.my_button_removeText = new System.Windows.Forms.Button();
      this.my_button_GetTrackNrFronTitle = new System.Windows.Forms.Button();
      this.my_textBox_fixTitle = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.my_button_fixTitle = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.m_UserControlTrackList = new MP3TagRenamer.UserControlTrackList();
      this.m_TabPageFindDuplicates = new System.Windows.Forms.TabPage();
      this.m_CompareDuplicates = new FindDuplicateMp3s.FindDuplicates();
      this.m_TabPageOptions = new System.Windows.Forms.TabPage();
      this.m_Options = new MP3TagRenamer.Options();
      this.m_ImageList = new System.Windows.Forms.ImageList(this.components);
      this.My_UltraID3BindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.My_HelpProvider = new System.Windows.Forms.HelpProvider();
      this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.m_TabControlMain.SuspendLayout();
      this.m_TabPageRenamer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerRenameMain)).BeginInit();
      this.m_splitContainerRenameMain.Panel1.SuspendLayout();
      this.m_splitContainerRenameMain.Panel2.SuspendLayout();
      this.m_splitContainerRenameMain.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.My_TabControl_BatchRen.SuspendLayout();
      this.m_TabPageBatch.SuspendLayout();
      this.m_TabPageRenaming.SuspendLayout();
      this.GroupBox_ExtractFromFName.SuspendLayout();
      this.m_TabPageCleaning.SuspendLayout();
      this.m_TabPageFindDuplicates.SuspendLayout();
      this.m_TabPageOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // m_TabControlMain
      // 
      resources.ApplyResources(this.m_TabControlMain, "m_TabControlMain");
      this.m_TabControlMain.Controls.Add(this.m_TabPageRenamer);
      this.m_TabControlMain.Controls.Add(this.m_TabPageFindDuplicates);
      this.m_TabControlMain.Controls.Add(this.m_TabPageOptions);
      this.m_TabControlMain.HotTrack = true;
      this.m_TabControlMain.ImageList = this.m_ImageList;
      this.m_TabControlMain.Name = "m_TabControlMain";
      this.m_TabControlMain.SelectedIndex = 0;
      this.My_HelpProvider.SetShowHelp(this.m_TabControlMain, ((bool)(resources.GetObject("m_TabControlMain.ShowHelp"))));
      // 
      // m_TabPageRenamer
      // 
      resources.ApplyResources(this.m_TabPageRenamer, "m_TabPageRenamer");
      this.m_TabPageRenamer.Controls.Add(this.m_splitContainerRenameMain);
      this.m_TabPageRenamer.Name = "m_TabPageRenamer";
      this.My_HelpProvider.SetShowHelp(this.m_TabPageRenamer, ((bool)(resources.GetObject("m_TabPageRenamer.ShowHelp"))));
      this.m_TabPageRenamer.UseVisualStyleBackColor = true;
      // 
      // m_splitContainerRenameMain
      // 
      this.m_splitContainerRenameMain.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.m_splitContainerRenameMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      resources.ApplyResources(this.m_splitContainerRenameMain, "m_splitContainerRenameMain");
      this.m_splitContainerRenameMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.m_splitContainerRenameMain.Name = "m_splitContainerRenameMain";
      // 
      // m_splitContainerRenameMain.Panel1
      // 
      this.m_splitContainerRenameMain.Panel1.BackColor = System.Drawing.SystemColors.Control;
      this.m_splitContainerRenameMain.Panel1.Controls.Add(this.groupBox1);
      this.m_splitContainerRenameMain.Panel1.Controls.Add(this.groupBox2);
      this.m_splitContainerRenameMain.Panel1.Controls.Add(this.My_TabControl_BatchRen);
      this.My_HelpProvider.SetShowHelp(this.m_splitContainerRenameMain.Panel1, ((bool)(resources.GetObject("m_splitContainerRenameMain.Panel1.ShowHelp"))));
      // 
      // m_splitContainerRenameMain.Panel2
      // 
      this.m_splitContainerRenameMain.Panel2.BackColor = System.Drawing.SystemColors.Control;
      this.m_splitContainerRenameMain.Panel2.Controls.Add(this.m_UserControlTrackList);
      this.My_HelpProvider.SetShowHelp(this.m_splitContainerRenameMain.Panel2, ((bool)(resources.GetObject("m_splitContainerRenameMain.Panel2.ShowHelp"))));
      this.My_HelpProvider.SetShowHelp(this.m_splitContainerRenameMain, ((bool)(resources.GetObject("m_splitContainerRenameMain.ShowHelp"))));
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.my_label_ID3V2);
      resources.ApplyResources(this.groupBox1, "groupBox1");
      this.groupBox1.Name = "groupBox1";
      this.My_HelpProvider.SetShowHelp(this.groupBox1, ((bool)(resources.GetObject("groupBox1.ShowHelp"))));
      this.groupBox1.TabStop = false;
      // 
      // my_label_ID3V2
      // 
      resources.ApplyResources(this.my_label_ID3V2, "my_label_ID3V2");
      this.my_label_ID3V2.Name = "my_label_ID3V2";
      this.My_HelpProvider.SetShowHelp(this.my_label_ID3V2, ((bool)(resources.GetObject("my_label_ID3V2.ShowHelp"))));
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.my_label_ID3V1);
      resources.ApplyResources(this.groupBox2, "groupBox2");
      this.groupBox2.Name = "groupBox2";
      this.My_HelpProvider.SetShowHelp(this.groupBox2, ((bool)(resources.GetObject("groupBox2.ShowHelp"))));
      this.groupBox2.TabStop = false;
      // 
      // my_label_ID3V1
      // 
      resources.ApplyResources(this.my_label_ID3V1, "my_label_ID3V1");
      this.my_label_ID3V1.Name = "my_label_ID3V1";
      this.My_HelpProvider.SetShowHelp(this.my_label_ID3V1, ((bool)(resources.GetObject("my_label_ID3V1.ShowHelp"))));
      // 
      // My_TabControl_BatchRen
      // 
      resources.ApplyResources(this.My_TabControl_BatchRen, "My_TabControl_BatchRen");
      this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageBatch);
      this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageRenaming);
      this.My_TabControl_BatchRen.Controls.Add(this.m_TabPageCleaning);
      this.My_TabControl_BatchRen.Name = "My_TabControl_BatchRen";
      this.My_TabControl_BatchRen.SelectedIndex = 0;
      this.My_HelpProvider.SetShowHelp(this.My_TabControl_BatchRen, ((bool)(resources.GetObject("My_TabControl_BatchRen.ShowHelp"))));
      // 
      // m_TabPageBatch
      // 
      this.m_TabPageBatch.Controls.Add(this.m_UserControlBatchRenameFields);
      resources.ApplyResources(this.m_TabPageBatch, "m_TabPageBatch");
      this.m_TabPageBatch.Name = "m_TabPageBatch";
      this.My_HelpProvider.SetShowHelp(this.m_TabPageBatch, ((bool)(resources.GetObject("m_TabPageBatch.ShowHelp"))));
      this.m_TabPageBatch.UseVisualStyleBackColor = true;
      // 
      // m_UserControlBatchRenameFields
      // 
      this.m_UserControlBatchRenameFields.Album = "";
      this.m_UserControlBatchRenameFields.Artist = "";
      resources.ApplyResources(this.m_UserControlBatchRenameFields, "m_UserControlBatchRenameFields");
      this.m_UserControlBatchRenameFields.Ganre = "";
      this.m_UserControlBatchRenameFields.Name = "m_UserControlBatchRenameFields";
      this.My_HelpProvider.SetShowHelp(this.m_UserControlBatchRenameFields, ((bool)(resources.GetObject("m_UserControlBatchRenameFields.ShowHelp"))));
      this.m_UserControlBatchRenameFields.Year = null;
      // 
      // m_TabPageRenaming
      // 
      this.m_TabPageRenaming.Controls.Add(this.GroupBox_ExtractFromFName);
      resources.ApplyResources(this.m_TabPageRenaming, "m_TabPageRenaming");
      this.m_TabPageRenaming.Name = "m_TabPageRenaming";
      this.My_HelpProvider.SetShowHelp(this.m_TabPageRenaming, ((bool)(resources.GetObject("m_TabPageRenaming.ShowHelp"))));
      this.m_TabPageRenaming.UseVisualStyleBackColor = true;
      // 
      // GroupBox_ExtractFromFName
      // 
      resources.ApplyResources(this.GroupBox_ExtractFromFName, "GroupBox_ExtractFromFName");
      this.GroupBox_ExtractFromFName.Controls.Add(this.m_ButtonSuggest);
      this.GroupBox_ExtractFromFName.Controls.Add(this.m_ButtonAddRemovePressets);
      this.GroupBox_ExtractFromFName.Controls.Add(this.m_LabelRealRexExpression);
      this.GroupBox_ExtractFromFName.Controls.Add(this.ComboBox_ExtractTagsFromFNmane);
      this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtractFRomFName);
      this.GroupBox_ExtractFromFName.Controls.Add(this.Button_regexp_properties);
      this.GroupBox_ExtractFromFName.Controls.Add(this.Button_ExtracFromFName_Test);
      this.GroupBox_ExtractFromFName.Controls.Add(this.Label_Regextpresult);
      this.GroupBox_ExtractFromFName.Controls.Add(this.TextBox_TestPath);
      this.GroupBox_ExtractFromFName.Name = "GroupBox_ExtractFromFName";
      this.My_HelpProvider.SetShowHelp(this.GroupBox_ExtractFromFName, ((bool)(resources.GetObject("GroupBox_ExtractFromFName.ShowHelp"))));
      this.GroupBox_ExtractFromFName.TabStop = false;
      // 
      // m_ButtonSuggest
      // 
      resources.ApplyResources(this.m_ButtonSuggest, "m_ButtonSuggest");
      this.m_ButtonSuggest.Name = "m_ButtonSuggest";
      this.My_HelpProvider.SetShowHelp(this.m_ButtonSuggest, ((bool)(resources.GetObject("m_ButtonSuggest.ShowHelp"))));
      this.m_ToolTip.SetToolTip(this.m_ButtonSuggest, resources.GetString("m_ButtonSuggest.ToolTip"));
      this.m_ButtonSuggest.UseVisualStyleBackColor = true;
      this.m_ButtonSuggest.Click += new System.EventHandler(this.ButtonSuggest_Click);
      // 
      // m_ButtonAddRemovePressets
      // 
      resources.ApplyResources(this.m_ButtonAddRemovePressets, "m_ButtonAddRemovePressets");
      this.m_ButtonAddRemovePressets.Name = "m_ButtonAddRemovePressets";
      this.My_HelpProvider.SetShowHelp(this.m_ButtonAddRemovePressets, ((bool)(resources.GetObject("m_ButtonAddRemovePressets.ShowHelp"))));
      this.m_ToolTip.SetToolTip(this.m_ButtonAddRemovePressets, resources.GetString("m_ButtonAddRemovePressets.ToolTip"));
      this.m_ButtonAddRemovePressets.UseVisualStyleBackColor = true;
      this.m_ButtonAddRemovePressets.Click += new System.EventHandler(this.ButtonAddRemovePressets_Click);
      // 
      // m_LabelRealRexExpression
      // 
      resources.ApplyResources(this.m_LabelRealRexExpression, "m_LabelRealRexExpression");
      this.m_LabelRealRexExpression.Name = "m_LabelRealRexExpression";
      this.My_HelpProvider.SetShowHelp(this.m_LabelRealRexExpression, ((bool)(resources.GetObject("m_LabelRealRexExpression.ShowHelp"))));
      // 
      // ComboBox_ExtractTagsFromFNmane
      // 
      this.ComboBox_ExtractTagsFromFNmane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.ComboBox_ExtractTagsFromFNmane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.ComboBox_ExtractTagsFromFNmane.FormattingEnabled = true;
      resources.ApplyResources(this.ComboBox_ExtractTagsFromFNmane, "ComboBox_ExtractTagsFromFNmane");
      this.ComboBox_ExtractTagsFromFNmane.Name = "ComboBox_ExtractTagsFromFNmane";
      this.My_HelpProvider.SetShowHelp(this.ComboBox_ExtractTagsFromFNmane, ((bool)(resources.GetObject("ComboBox_ExtractTagsFromFNmane.ShowHelp"))));
      this.ComboBox_ExtractTagsFromFNmane.TextChanged += new System.EventHandler(this.ComboBox_ExtractTagsFromFNmane_TextChanged);
      // 
      // Button_ExtractFRomFName
      // 
      resources.ApplyResources(this.Button_ExtractFRomFName, "Button_ExtractFRomFName");
      this.Button_ExtractFRomFName.Name = "Button_ExtractFRomFName";
      this.My_HelpProvider.SetShowHelp(this.Button_ExtractFRomFName, ((bool)(resources.GetObject("Button_ExtractFRomFName.ShowHelp"))));
      this.Button_ExtractFRomFName.UseVisualStyleBackColor = true;
      this.Button_ExtractFRomFName.Click += new System.EventHandler(this.Button_ExtractFRomFName_Click);
      // 
      // Button_regexp_properties
      // 
      resources.ApplyResources(this.Button_regexp_properties, "Button_regexp_properties");
      this.Button_regexp_properties.Name = "Button_regexp_properties";
      this.My_HelpProvider.SetShowHelp(this.Button_regexp_properties, ((bool)(resources.GetObject("Button_regexp_properties.ShowHelp"))));
      this.m_ToolTip.SetToolTip(this.Button_regexp_properties, resources.GetString("Button_regexp_properties.ToolTip"));
      this.Button_regexp_properties.UseVisualStyleBackColor = true;
      this.Button_regexp_properties.Click += new System.EventHandler(this.Button_regexp_properties_Click);
      // 
      // Button_ExtracFromFName_Test
      // 
      resources.ApplyResources(this.Button_ExtracFromFName_Test, "Button_ExtracFromFName_Test");
      this.Button_ExtracFromFName_Test.Name = "Button_ExtracFromFName_Test";
      this.My_HelpProvider.SetShowHelp(this.Button_ExtracFromFName_Test, ((bool)(resources.GetObject("Button_ExtracFromFName_Test.ShowHelp"))));
      this.m_ToolTip.SetToolTip(this.Button_ExtracFromFName_Test, resources.GetString("Button_ExtracFromFName_Test.ToolTip"));
      this.Button_ExtracFromFName_Test.UseVisualStyleBackColor = true;
      this.Button_ExtracFromFName_Test.Click += new System.EventHandler(this.Button_ExtracFromFNameTEST_Click);
      // 
      // Label_Regextpresult
      // 
      this.Label_Regextpresult.AutoEllipsis = true;
      resources.ApplyResources(this.Label_Regextpresult, "Label_Regextpresult");
      this.Label_Regextpresult.Name = "Label_Regextpresult";
      this.My_HelpProvider.SetShowHelp(this.Label_Regextpresult, ((bool)(resources.GetObject("Label_Regextpresult.ShowHelp"))));
      // 
      // TextBox_TestPath
      // 
      resources.ApplyResources(this.TextBox_TestPath, "TextBox_TestPath");
      this.TextBox_TestPath.Name = "TextBox_TestPath";
      this.TextBox_TestPath.ReadOnly = true;
      this.My_HelpProvider.SetShowHelp(this.TextBox_TestPath, ((bool)(resources.GetObject("TextBox_TestPath.ShowHelp"))));
      // 
      // m_TabPageCleaning
      // 
      this.m_TabPageCleaning.Controls.Add(this.my_textBox_removeText);
      this.m_TabPageCleaning.Controls.Add(this.my_checkBox_UseRegExp);
      this.m_TabPageCleaning.Controls.Add(this.my_button_ClearComments);
      this.m_TabPageCleaning.Controls.Add(this.my_button_removeText);
      this.m_TabPageCleaning.Controls.Add(this.my_button_GetTrackNrFronTitle);
      this.m_TabPageCleaning.Controls.Add(this.my_textBox_fixTitle);
      this.m_TabPageCleaning.Controls.Add(this.label2);
      this.m_TabPageCleaning.Controls.Add(this.my_button_fixTitle);
      this.m_TabPageCleaning.Controls.Add(this.label1);
      resources.ApplyResources(this.m_TabPageCleaning, "m_TabPageCleaning");
      this.m_TabPageCleaning.Name = "m_TabPageCleaning";
      this.My_HelpProvider.SetShowHelp(this.m_TabPageCleaning, ((bool)(resources.GetObject("m_TabPageCleaning.ShowHelp"))));
      this.m_TabPageCleaning.UseVisualStyleBackColor = true;
      // 
      // my_textBox_removeText
      // 
      resources.ApplyResources(this.my_textBox_removeText, "my_textBox_removeText");
      this.my_textBox_removeText.Name = "my_textBox_removeText";
      this.My_HelpProvider.SetShowHelp(this.my_textBox_removeText, ((bool)(resources.GetObject("my_textBox_removeText.ShowHelp"))));
      // 
      // my_checkBox_UseRegExp
      // 
      resources.ApplyResources(this.my_checkBox_UseRegExp, "my_checkBox_UseRegExp");
      this.my_checkBox_UseRegExp.Checked = true;
      this.my_checkBox_UseRegExp.CheckState = System.Windows.Forms.CheckState.Checked;
      this.my_checkBox_UseRegExp.Name = "my_checkBox_UseRegExp";
      this.My_HelpProvider.SetShowHelp(this.my_checkBox_UseRegExp, ((bool)(resources.GetObject("my_checkBox_UseRegExp.ShowHelp"))));
      this.my_checkBox_UseRegExp.UseVisualStyleBackColor = true;
      // 
      // my_button_ClearComments
      // 
      resources.ApplyResources(this.my_button_ClearComments, "my_button_ClearComments");
      this.my_button_ClearComments.Name = "my_button_ClearComments";
      this.My_HelpProvider.SetShowHelp(this.my_button_ClearComments, ((bool)(resources.GetObject("my_button_ClearComments.ShowHelp"))));
      this.my_button_ClearComments.UseVisualStyleBackColor = true;
      this.my_button_ClearComments.Click += new System.EventHandler(this.Button_ClearComments_Click);
      // 
      // my_button_removeText
      // 
      resources.ApplyResources(this.my_button_removeText, "my_button_removeText");
      this.my_button_removeText.Name = "my_button_removeText";
      this.My_HelpProvider.SetShowHelp(this.my_button_removeText, ((bool)(resources.GetObject("my_button_removeText.ShowHelp"))));
      this.my_button_removeText.UseVisualStyleBackColor = true;
      this.my_button_removeText.Click += new System.EventHandler(this.Button_removeText_Click);
      // 
      // my_button_GetTrackNrFronTitle
      // 
      resources.ApplyResources(this.my_button_GetTrackNrFronTitle, "my_button_GetTrackNrFronTitle");
      this.my_button_GetTrackNrFronTitle.Name = "my_button_GetTrackNrFronTitle";
      this.My_HelpProvider.SetShowHelp(this.my_button_GetTrackNrFronTitle, ((bool)(resources.GetObject("my_button_GetTrackNrFronTitle.ShowHelp"))));
      this.my_button_GetTrackNrFronTitle.UseVisualStyleBackColor = true;
      this.my_button_GetTrackNrFronTitle.Click += new System.EventHandler(this.Button_GetTrackNrFronTitle_Click);
      // 
      // my_textBox_fixTitle
      // 
      this.My_HelpProvider.SetHelpKeyword(this.my_textBox_fixTitle, resources.GetString("my_textBox_fixTitle.HelpKeyword"));
      this.My_HelpProvider.SetHelpNavigator(this.my_textBox_fixTitle, ((System.Windows.Forms.HelpNavigator)(resources.GetObject("my_textBox_fixTitle.HelpNavigator"))));
      this.My_HelpProvider.SetHelpString(this.my_textBox_fixTitle, resources.GetString("my_textBox_fixTitle.HelpString"));
      resources.ApplyResources(this.my_textBox_fixTitle, "my_textBox_fixTitle");
      this.my_textBox_fixTitle.Name = "my_textBox_fixTitle";
      this.My_HelpProvider.SetShowHelp(this.my_textBox_fixTitle, ((bool)(resources.GetObject("my_textBox_fixTitle.ShowHelp"))));
      // 
      // label2
      // 
      resources.ApplyResources(this.label2, "label2");
      this.label2.Name = "label2";
      this.My_HelpProvider.SetShowHelp(this.label2, ((bool)(resources.GetObject("label2.ShowHelp"))));
      // 
      // my_button_fixTitle
      // 
      resources.ApplyResources(this.my_button_fixTitle, "my_button_fixTitle");
      this.my_button_fixTitle.Name = "my_button_fixTitle";
      this.My_HelpProvider.SetShowHelp(this.my_button_fixTitle, ((bool)(resources.GetObject("my_button_fixTitle.ShowHelp"))));
      this.my_button_fixTitle.UseVisualStyleBackColor = true;
      this.my_button_fixTitle.Click += new System.EventHandler(this.Button_fixTitle_Click);
      // 
      // label1
      // 
      resources.ApplyResources(this.label1, "label1");
      this.label1.Name = "label1";
      this.My_HelpProvider.SetShowHelp(this.label1, ((bool)(resources.GetObject("label1.ShowHelp"))));
      // 
      // m_UserControlTrackList
      // 
      resources.ApplyResources(this.m_UserControlTrackList, "m_UserControlTrackList");
      this.m_UserControlTrackList.ID3V1Text = null;
      this.m_UserControlTrackList.ID3V2Text = null;
      this.m_UserControlTrackList.Name = "m_UserControlTrackList";
      this.m_UserControlTrackList.SelectedTracksPath = null;
      this.My_HelpProvider.SetShowHelp(this.m_UserControlTrackList, ((bool)(resources.GetObject("m_UserControlTrackList.ShowHelp"))));
      // 
      // m_TabPageFindDuplicates
      // 
      this.m_TabPageFindDuplicates.Controls.Add(this.m_CompareDuplicates);
      resources.ApplyResources(this.m_TabPageFindDuplicates, "m_TabPageFindDuplicates");
      this.m_TabPageFindDuplicates.Name = "m_TabPageFindDuplicates";
      this.My_HelpProvider.SetShowHelp(this.m_TabPageFindDuplicates, ((bool)(resources.GetObject("m_TabPageFindDuplicates.ShowHelp"))));
      this.m_TabPageFindDuplicates.UseVisualStyleBackColor = true;
      // 
      // m_CompareDuplicates
      // 
      resources.ApplyResources(this.m_CompareDuplicates, "m_CompareDuplicates");
      this.m_CompareDuplicates.Name = "m_CompareDuplicates";
      this.My_HelpProvider.SetShowHelp(this.m_CompareDuplicates, ((bool)(resources.GetObject("m_CompareDuplicates.ShowHelp"))));
      // 
      // m_TabPageOptions
      // 
      this.m_TabPageOptions.Controls.Add(this.m_Options);
      resources.ApplyResources(this.m_TabPageOptions, "m_TabPageOptions");
      this.m_TabPageOptions.Name = "m_TabPageOptions";
      this.My_HelpProvider.SetShowHelp(this.m_TabPageOptions, ((bool)(resources.GetObject("m_TabPageOptions.ShowHelp"))));
      this.m_TabPageOptions.UseVisualStyleBackColor = true;
      // 
      // m_Options
      // 
      resources.ApplyResources(this.m_Options, "m_Options");
      this.m_Options.Name = "m_Options";
      // 
      // m_ImageList
      // 
      this.m_ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ImageList.ImageStream")));
      this.m_ImageList.TransparentColor = System.Drawing.Color.Transparent;
      this.m_ImageList.Images.SetKeyName(0, "1308839077_MP3.ico");
      this.m_ImageList.Images.SetKeyName(1, "1308839315_Folder-Searches.ico");
      this.m_ImageList.Images.SetKeyName(2, "1308839380_41.ico");
      // 
      // My_UltraID3BindingSource
      // 
      this.My_UltraID3BindingSource.DataSource = typeof(HundredMilesSoftware.UltraID3Lib.UltraID3);
      // 
      // My_HelpProvider
      // 
      resources.ApplyResources(this.My_HelpProvider, "My_HelpProvider");
      // 
      // MainForm
      // 
      resources.ApplyResources(this, "$this");
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_TabControlMain);
      this.HelpButton = true;
      this.My_HelpProvider.SetHelpKeyword(this, resources.GetString("$this.HelpKeyword"));
      this.My_HelpProvider.SetHelpString(this, resources.GetString("$this.HelpString"));
      this.Name = "MainForm";
      this.My_HelpProvider.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);      
      this.m_TabControlMain.ResumeLayout(false);
      this.m_TabPageRenamer.ResumeLayout(false);
      this.m_splitContainerRenameMain.Panel1.ResumeLayout(false);
      this.m_splitContainerRenameMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_splitContainerRenameMain)).EndInit();
      this.m_splitContainerRenameMain.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.My_TabControl_BatchRen.ResumeLayout(false);
      this.m_TabPageBatch.ResumeLayout(false);
      this.m_TabPageRenaming.ResumeLayout(false);
      this.GroupBox_ExtractFromFName.ResumeLayout(false);
      this.GroupBox_ExtractFromFName.PerformLayout();
      this.m_TabPageCleaning.ResumeLayout(false);
      this.m_TabPageCleaning.PerformLayout();
      this.m_TabPageFindDuplicates.ResumeLayout(false);
      this.m_TabPageOptions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.My_UltraID3BindingSource)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.BindingSource My_UltraID3BindingSource;
        private System.Windows.Forms.Label my_label_ID3V2;
		private System.Windows.Forms.Label my_label_ID3V1;
        private System.Windows.Forms.TabControl My_TabControl_BatchRen;
        private System.Windows.Forms.TabPage m_TabPageBatch;
		private System.Windows.Forms.TabPage m_TabPageRenaming;
    private System.Windows.Forms.SplitContainer m_splitContainerRenameMain;
    private System.Windows.Forms.HelpProvider My_HelpProvider;        
        private System.Windows.Forms.Button Button_ExtracFromFName_Test;
        private System.Windows.Forms.Label Label_Regextpresult;
        private System.Windows.Forms.TextBox TextBox_TestPath;
        private System.Windows.Forms.Button Button_regexp_properties;
        private System.Windows.Forms.GroupBox GroupBox_ExtractFromFName;
        private System.Windows.Forms.Button Button_ExtractFRomFName;
		private System.Windows.Forms.ComboBox ComboBox_ExtractTagsFromFNmane;
		private UserControlTrackList m_UserControlTrackList;
		private UserControlBatchRenameFields m_UserControlBatchRenameFields;
		private System.Windows.Forms.TabPage m_TabPageCleaning;
		private System.Windows.Forms.TextBox my_textBox_removeText;
		private System.Windows.Forms.CheckBox my_checkBox_UseRegExp;
		private System.Windows.Forms.Button my_button_ClearComments;
		private System.Windows.Forms.Button my_button_removeText;
		private System.Windows.Forms.Button my_button_GetTrackNrFronTitle;
		private System.Windows.Forms.TextBox my_textBox_fixTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button my_button_fixTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label m_LabelRealRexExpression;
		private System.Windows.Forms.Button m_ButtonAddRemovePressets;
		private System.Windows.Forms.ToolTip m_ToolTip;
		private System.Windows.Forms.Button m_ButtonSuggest;
      private FindDuplicates m_CompareDuplicates;
      private System.Windows.Forms.TabControl m_TabControlMain;
      private System.Windows.Forms.TabPage m_TabPageRenamer;
      private System.Windows.Forms.TabPage m_TabPageFindDuplicates;
      private System.Windows.Forms.TabPage m_TabPageOptions;
      private Options m_Options;
      private System.Windows.Forms.ImageList m_ImageList;
      
    }
}

