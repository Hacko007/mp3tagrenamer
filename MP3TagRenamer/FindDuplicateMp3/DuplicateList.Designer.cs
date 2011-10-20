using FindDuplicateMp3s.Properties;

namespace FindDuplicateMp3s
{
  partial class DuplicateList
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuplicateList));
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      FindDuplicateMp3s.Properties.Settings settings1 = new FindDuplicateMp3s.Properties.Settings();
      FindDuplicateMp3s.Properties.Settings settings2 = new FindDuplicateMp3s.Properties.Settings();
      this.m_PanelMain = new System.Windows.Forms.Panel();
      this.m_SplitContainerMain = new System.Windows.Forms.SplitContainer();
      this.m_SplitContainerSub = new System.Windows.Forms.SplitContainer();
      this.m_DataGridViewDuplicates = new System.Windows.Forms.DataGridView();
      this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.artistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.m_BindingSourceParent = new System.Windows.Forms.BindingSource(this.components);
      this.m_TracksDataSet = new FindDuplicateMp3s.TracksDataSet();
      this.panel2 = new System.Windows.Forms.Panel();
      this.m_LabelDuplicateCount = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.m_DataGridViewDuplicateFiles = new System.Windows.Forms.DataGridView();
      this.ColumnPlay = new System.Windows.Forms.DataGridViewImageColumn();
      this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
      this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lengthDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fileNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.artistDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.m_BindingSourceChild = new System.Windows.Forms.BindingSource(this.components);
      this.panel3 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.m_dataGridViewDeletedList = new System.Windows.Forms.DataGridView();
      this.ColumnPlayMarkedForDel = new System.Windows.Forms.DataGridViewImageColumn();
      this.ColumnUndelete = new System.Windows.Forms.DataGridViewImageColumn();
      this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lengthDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sizeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.artistDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pathDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.m_BindingSourceDeleted = new System.Windows.Forms.BindingSource(this.components);
      this.panel1 = new System.Windows.Forms.Panel();
      this.m_ButtonUndelete = new System.Windows.Forms.Button();
      this.m_ImageList25 = new System.Windows.Forms.ImageList(this.components);
      this.label3 = new System.Windows.Forms.Label();
      this.m_ButtonDeleteAll = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.m_LabelProgresBarInfo = new System.Windows.Forms.Label();
      this.m_ProgressBar = new System.Windows.Forms.ProgressBar();
      this.m_GroupBoxCompare = new System.Windows.Forms.GroupBox();
      this.m_groupBoxIdentical = new System.Windows.Forms.GroupBox();
      this.m_compareIdenticalCheckBox = new System.Windows.Forms.CheckBox();
      this.m_groupBoxCompareSimulare = new System.Windows.Forms.GroupBox();
      this.m_compareArtistCheckBox = new System.Windows.Forms.CheckBox();
      this.m_compareAnyRadioButton = new System.Windows.Forms.RadioButton();
      this.m_compareAllRadioButton = new System.Windows.Forms.RadioButton();
      this.label4 = new System.Windows.Forms.Label();
      this.m_compareTitleCheckBox = new System.Windows.Forms.CheckBox();
      this.m_compareSizeCheckBox = new System.Windows.Forms.CheckBox();
      this.m_compareFileNameCheckBox = new System.Windows.Forms.CheckBox();
      this.m_compareLengthCheckBox = new System.Windows.Forms.CheckBox();
      this.m_ButtonSearch = new System.Windows.Forms.Button();
      this.m_ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.m_PanelMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_SplitContainerMain)).BeginInit();
      this.m_SplitContainerMain.Panel1.SuspendLayout();
      this.m_SplitContainerMain.Panel2.SuspendLayout();
      this.m_SplitContainerMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_SplitContainerSub)).BeginInit();
      this.m_SplitContainerSub.Panel1.SuspendLayout();
      this.m_SplitContainerSub.Panel2.SuspendLayout();
      this.m_SplitContainerSub.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewDuplicates)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceParent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_TracksDataSet)).BeginInit();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewDuplicateFiles)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceChild)).BeginInit();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewDeletedList)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceDeleted)).BeginInit();
      this.panel1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.m_GroupBoxCompare.SuspendLayout();
      this.m_groupBoxIdentical.SuspendLayout();
      this.m_groupBoxCompareSimulare.SuspendLayout();
      this.SuspendLayout();
      // 
      // m_PanelMain
      // 
      this.m_PanelMain.AutoScroll = true;
      this.m_PanelMain.Controls.Add(this.m_SplitContainerMain);
      this.m_PanelMain.Controls.Add(this.groupBox1);
      this.m_PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_PanelMain.Location = new System.Drawing.Point(0, 0);
      this.m_PanelMain.Name = "m_PanelMain";
      this.m_PanelMain.Size = new System.Drawing.Size(945, 600);
      this.m_PanelMain.TabIndex = 0;
      // 
      // m_SplitContainerMain
      // 
      this.m_SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
      this.m_SplitContainerMain.Location = new System.Drawing.Point(0, 120);
      this.m_SplitContainerMain.Name = "m_SplitContainerMain";
      this.m_SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // m_SplitContainerMain.Panel1
      // 
      this.m_SplitContainerMain.Panel1.Controls.Add(this.m_SplitContainerSub);
      // 
      // m_SplitContainerMain.Panel2
      // 
      this.m_SplitContainerMain.Panel2.Controls.Add(this.m_dataGridViewDeletedList);
      this.m_SplitContainerMain.Panel2.Controls.Add(this.panel1);
      this.m_SplitContainerMain.Size = new System.Drawing.Size(945, 480);
      this.m_SplitContainerMain.SplitterDistance = 324;
      this.m_SplitContainerMain.TabIndex = 2;
      // 
      // m_SplitContainerSub
      // 
      this.m_SplitContainerSub.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_SplitContainerSub.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.m_SplitContainerSub.Location = new System.Drawing.Point(0, 0);
      this.m_SplitContainerSub.Name = "m_SplitContainerSub";
      // 
      // m_SplitContainerSub.Panel1
      // 
      this.m_SplitContainerSub.Panel1.Controls.Add(this.m_DataGridViewDuplicates);
      this.m_SplitContainerSub.Panel1.Controls.Add(this.panel2);
      // 
      // m_SplitContainerSub.Panel2
      // 
      this.m_SplitContainerSub.Panel2.Controls.Add(this.m_DataGridViewDuplicateFiles);
      this.m_SplitContainerSub.Panel2.Controls.Add(this.panel3);
      this.m_SplitContainerSub.Size = new System.Drawing.Size(945, 324);
      this.m_SplitContainerSub.SplitterDistance = 430;
      this.m_SplitContainerSub.TabIndex = 0;
      // 
      // m_DataGridViewDuplicates
      // 
      this.m_DataGridViewDuplicates.AllowUserToAddRows = false;
      this.m_DataGridViewDuplicates.AllowUserToDeleteRows = false;
      this.m_DataGridViewDuplicates.AllowUserToOrderColumns = true;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.m_DataGridViewDuplicates.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.m_DataGridViewDuplicates.AutoGenerateColumns = false;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.PeachPuff;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.m_DataGridViewDuplicates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
      this.m_DataGridViewDuplicates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.m_DataGridViewDuplicates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.lengthDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.artistDataGridViewTextBoxColumn});
      this.m_DataGridViewDuplicates.DataSource = this.m_BindingSourceParent;
      this.m_DataGridViewDuplicates.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_DataGridViewDuplicates.GridColor = System.Drawing.Color.Silver;
      this.m_DataGridViewDuplicates.Location = new System.Drawing.Point(0, 29);
      this.m_DataGridViewDuplicates.MultiSelect = false;
      this.m_DataGridViewDuplicates.Name = "m_DataGridViewDuplicates";
      this.m_DataGridViewDuplicates.ReadOnly = true;
      this.m_DataGridViewDuplicates.RowHeadersWidth = 25;
      this.m_DataGridViewDuplicates.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
      this.m_DataGridViewDuplicates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.m_DataGridViewDuplicates.Size = new System.Drawing.Size(430, 295);
      this.m_DataGridViewDuplicates.TabIndex = 1;
      // 
      // titleDataGridViewTextBoxColumn
      // 
      this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
      this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
      this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
      this.titleDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // lengthDataGridViewTextBoxColumn
      // 
      this.lengthDataGridViewTextBoxColumn.DataPropertyName = "Length";
      this.lengthDataGridViewTextBoxColumn.HeaderText = "Length";
      this.lengthDataGridViewTextBoxColumn.Name = "lengthDataGridViewTextBoxColumn";
      this.lengthDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // sizeDataGridViewTextBoxColumn
      // 
      this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
      this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
      this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
      this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      this.idDataGridViewTextBoxColumn.ReadOnly = true;
      this.idDataGridViewTextBoxColumn.Visible = false;
      // 
      // fileNameDataGridViewTextBoxColumn
      // 
      this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "FileName";
      this.fileNameDataGridViewTextBoxColumn.HeaderText = "FileName";
      this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
      this.fileNameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // artistDataGridViewTextBoxColumn
      // 
      this.artistDataGridViewTextBoxColumn.DataPropertyName = "Artist";
      this.artistDataGridViewTextBoxColumn.HeaderText = "Artist";
      this.artistDataGridViewTextBoxColumn.Name = "artistDataGridViewTextBoxColumn";
      this.artistDataGridViewTextBoxColumn.ReadOnly = true;
      this.artistDataGridViewTextBoxColumn.Visible = false;
      // 
      // m_BindingSourceParent
      // 
      this.m_BindingSourceParent.DataMember = "ParentTrack";
      this.m_BindingSourceParent.DataSource = this.m_TracksDataSet;
      // 
      // m_TracksDataSet
      // 
      this.m_TracksDataSet.DataSetName = "TracksDataSet";
      this.m_TracksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.m_LabelDuplicateCount);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(430, 29);
      this.panel2.TabIndex = 0;
      // 
      // m_LabelDuplicateCount
      // 
      this.m_LabelDuplicateCount.AutoSize = true;
      this.m_LabelDuplicateCount.Location = new System.Drawing.Point(208, 5);
      this.m_LabelDuplicateCount.Name = "m_LabelDuplicateCount";
      this.m_LabelDuplicateCount.Size = new System.Drawing.Size(0, 13);
      this.m_LabelDuplicateCount.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(17, 4);
      this.label1.Name = "label1";
      this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.label1.Size = new System.Drawing.Size(111, 21);
      this.label1.TabIndex = 0;
      this.label1.Text = "Found duplicates";
      // 
      // m_DataGridViewDuplicateFiles
      // 
      this.m_DataGridViewDuplicateFiles.AllowUserToAddRows = false;
      this.m_DataGridViewDuplicateFiles.AllowUserToDeleteRows = false;
      this.m_DataGridViewDuplicateFiles.AllowUserToOrderColumns = true;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.m_DataGridViewDuplicateFiles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
      this.m_DataGridViewDuplicateFiles.AutoGenerateColumns = false;
      this.m_DataGridViewDuplicateFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.m_DataGridViewDuplicateFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlay,
            this.ColumnDelete,
            this.titleDataGridViewTextBoxColumn1,
            this.lengthDataGridViewTextBoxColumn1,
            this.sizeDataGridViewTextBoxColumn1,
            this.fileNameDataGridViewTextBoxColumn1,
            this.artistDataGridViewTextBoxColumn1,
            this.pathDataGridViewTextBoxColumn,
            this.parentIdDataGridViewTextBoxColumn});
      this.m_DataGridViewDuplicateFiles.DataSource = this.m_BindingSourceChild;
      this.m_DataGridViewDuplicateFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_DataGridViewDuplicateFiles.GridColor = System.Drawing.Color.Silver;
      this.m_DataGridViewDuplicateFiles.Location = new System.Drawing.Point(0, 29);
      this.m_DataGridViewDuplicateFiles.Name = "m_DataGridViewDuplicateFiles";
      this.m_DataGridViewDuplicateFiles.ReadOnly = true;
      this.m_DataGridViewDuplicateFiles.RowHeadersWidth = 25;
      this.m_DataGridViewDuplicateFiles.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.m_DataGridViewDuplicateFiles.Size = new System.Drawing.Size(511, 295);
      this.m_DataGridViewDuplicateFiles.TabIndex = 1;
      this.m_DataGridViewDuplicateFiles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDiplicateFilesCellContentClick);
      this.m_DataGridViewDuplicateFiles.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.OnDiplicateFilesRowPrePaint);
      // 
      // ColumnPlay
      // 
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
      this.ColumnPlay.DefaultCellStyle = dataGridViewCellStyle4;
      this.ColumnPlay.FillWeight = 80F;
      this.ColumnPlay.HeaderText = "Play";
      this.ColumnPlay.Image = global::FindDuplicateMp3s.Properties.Resources._1308841068_Play;
      this.ColumnPlay.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.ColumnPlay.Name = "ColumnPlay";
      this.ColumnPlay.ReadOnly = true;
      this.ColumnPlay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnPlay.ToolTipText = "Play";
      this.ColumnPlay.Width = 80;
      // 
      // ColumnDelete
      // 
      this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle5.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
      dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
      this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle5;
      this.ColumnDelete.FillWeight = 50F;
      this.ColumnDelete.HeaderText = "Delete";
      this.ColumnDelete.Image = global::FindDuplicateMp3s.Properties.Resources._1309256835_Delete;
      this.ColumnDelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.ColumnDelete.Name = "ColumnDelete";
      this.ColumnDelete.ReadOnly = true;
      this.ColumnDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnDelete.ToolTipText = "Delete file";
      this.ColumnDelete.Width = 44;
      // 
      // titleDataGridViewTextBoxColumn1
      // 
      this.titleDataGridViewTextBoxColumn1.DataPropertyName = "Title";
      this.titleDataGridViewTextBoxColumn1.HeaderText = "Title";
      this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
      this.titleDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // lengthDataGridViewTextBoxColumn1
      // 
      this.lengthDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.lengthDataGridViewTextBoxColumn1.DataPropertyName = "Length";
      this.lengthDataGridViewTextBoxColumn1.HeaderText = "Length";
      this.lengthDataGridViewTextBoxColumn1.Name = "lengthDataGridViewTextBoxColumn1";
      this.lengthDataGridViewTextBoxColumn1.ReadOnly = true;
      this.lengthDataGridViewTextBoxColumn1.Width = 65;
      // 
      // sizeDataGridViewTextBoxColumn1
      // 
      this.sizeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
      this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
      this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
      this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
      this.sizeDataGridViewTextBoxColumn1.Width = 52;
      // 
      // fileNameDataGridViewTextBoxColumn1
      // 
      this.fileNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
      this.fileNameDataGridViewTextBoxColumn1.DataPropertyName = "FileName";
      this.fileNameDataGridViewTextBoxColumn1.HeaderText = "FileName";
      this.fileNameDataGridViewTextBoxColumn1.Name = "fileNameDataGridViewTextBoxColumn1";
      this.fileNameDataGridViewTextBoxColumn1.ReadOnly = true;
      this.fileNameDataGridViewTextBoxColumn1.Width = 5;
      // 
      // artistDataGridViewTextBoxColumn1
      // 
      this.artistDataGridViewTextBoxColumn1.DataPropertyName = "Artist";
      this.artistDataGridViewTextBoxColumn1.HeaderText = "Artist";
      this.artistDataGridViewTextBoxColumn1.Name = "artistDataGridViewTextBoxColumn1";
      this.artistDataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // pathDataGridViewTextBoxColumn
      // 
      this.pathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
      this.pathDataGridViewTextBoxColumn.FillWeight = 400F;
      this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
      this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
      this.pathDataGridViewTextBoxColumn.ReadOnly = true;
      this.pathDataGridViewTextBoxColumn.Width = 54;
      // 
      // parentIdDataGridViewTextBoxColumn
      // 
      this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
      this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
      this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
      this.parentIdDataGridViewTextBoxColumn.ReadOnly = true;
      this.parentIdDataGridViewTextBoxColumn.Visible = false;
      // 
      // m_BindingSourceChild
      // 
      this.m_BindingSourceChild.DataMember = "FK_ChildTrac_ParentTrack";
      this.m_BindingSourceChild.DataSource = this.m_BindingSourceParent;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.label2);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(511, 29);
      this.panel3.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(23, 4);
      this.label2.Name = "label2";
      this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.label2.Size = new System.Drawing.Size(92, 21);
      this.label2.TabIndex = 0;
      this.label2.Text = "Duplicate files";
      // 
      // m_dataGridViewDeletedList
      // 
      this.m_dataGridViewDeletedList.AllowUserToAddRows = false;
      this.m_dataGridViewDeletedList.AllowUserToDeleteRows = false;
      dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.m_dataGridViewDeletedList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
      this.m_dataGridViewDeletedList.AutoGenerateColumns = false;
      this.m_dataGridViewDeletedList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.m_dataGridViewDeletedList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayMarkedForDel,
            this.ColumnUndelete,
            this.titleDataGridViewTextBoxColumn2,
            this.lengthDataGridViewTextBoxColumn2,
            this.sizeDataGridViewTextBoxColumn2,
            this.artistDataGridViewTextBoxColumn2,
            this.pathDataGridViewTextBoxColumn1});
      this.m_dataGridViewDeletedList.DataSource = this.m_BindingSourceDeleted;
      this.m_dataGridViewDeletedList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.m_dataGridViewDeletedList.GridColor = System.Drawing.Color.Silver;
      this.m_dataGridViewDeletedList.Location = new System.Drawing.Point(0, 32);
      this.m_dataGridViewDeletedList.Name = "m_dataGridViewDeletedList";
      this.m_dataGridViewDeletedList.ReadOnly = true;
      this.m_dataGridViewDeletedList.RowHeadersWidth = 25;
      this.m_dataGridViewDeletedList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.m_dataGridViewDeletedList.Size = new System.Drawing.Size(945, 120);
      this.m_dataGridViewDeletedList.TabIndex = 1;
      this.m_dataGridViewDeletedList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDeletedListCellContentClick);
      // 
      // ColumnPlayMarkedForDel
      // 
      this.ColumnPlayMarkedForDel.HeaderText = "Play";
      this.ColumnPlayMarkedForDel.Image = global::FindDuplicateMp3s.Properties.Resources._1308841068_Play;
      this.ColumnPlayMarkedForDel.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.ColumnPlayMarkedForDel.Name = "ColumnPlayMarkedForDel";
      this.ColumnPlayMarkedForDel.ReadOnly = true;
      // 
      // ColumnUndelete
      // 
      this.ColumnUndelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
      this.ColumnUndelete.DefaultCellStyle = dataGridViewCellStyle7;
      this.ColumnUndelete.FillWeight = 80F;
      this.ColumnUndelete.HeaderText = "Undelete";
      this.ColumnUndelete.Image = global::FindDuplicateMp3s.Properties.Resources._1308841035_Undo;
      this.ColumnUndelete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
      this.ColumnUndelete.Name = "ColumnUndelete";
      this.ColumnUndelete.ReadOnly = true;
      this.ColumnUndelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.ColumnUndelete.Width = 56;
      // 
      // titleDataGridViewTextBoxColumn2
      // 
      this.titleDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.titleDataGridViewTextBoxColumn2.DataPropertyName = "Title";
      this.titleDataGridViewTextBoxColumn2.HeaderText = "Title";
      this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
      this.titleDataGridViewTextBoxColumn2.ReadOnly = true;
      this.titleDataGridViewTextBoxColumn2.Width = 52;
      // 
      // lengthDataGridViewTextBoxColumn2
      // 
      this.lengthDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.lengthDataGridViewTextBoxColumn2.DataPropertyName = "Length";
      this.lengthDataGridViewTextBoxColumn2.HeaderText = "Length";
      this.lengthDataGridViewTextBoxColumn2.Name = "lengthDataGridViewTextBoxColumn2";
      this.lengthDataGridViewTextBoxColumn2.ReadOnly = true;
      this.lengthDataGridViewTextBoxColumn2.Width = 65;
      // 
      // sizeDataGridViewTextBoxColumn2
      // 
      this.sizeDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.sizeDataGridViewTextBoxColumn2.DataPropertyName = "Size";
      this.sizeDataGridViewTextBoxColumn2.HeaderText = "Size";
      this.sizeDataGridViewTextBoxColumn2.Name = "sizeDataGridViewTextBoxColumn2";
      this.sizeDataGridViewTextBoxColumn2.ReadOnly = true;
      this.sizeDataGridViewTextBoxColumn2.Width = 52;
      // 
      // artistDataGridViewTextBoxColumn2
      // 
      this.artistDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.artistDataGridViewTextBoxColumn2.DataPropertyName = "Artist";
      this.artistDataGridViewTextBoxColumn2.HeaderText = "Artist";
      this.artistDataGridViewTextBoxColumn2.Name = "artistDataGridViewTextBoxColumn2";
      this.artistDataGridViewTextBoxColumn2.ReadOnly = true;
      this.artistDataGridViewTextBoxColumn2.Width = 55;
      // 
      // pathDataGridViewTextBoxColumn1
      // 
      this.pathDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
      this.pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
      this.pathDataGridViewTextBoxColumn1.FillWeight = 500F;
      this.pathDataGridViewTextBoxColumn1.HeaderText = "Path";
      this.pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
      this.pathDataGridViewTextBoxColumn1.ReadOnly = true;
      this.pathDataGridViewTextBoxColumn1.Width = 54;
      // 
      // m_BindingSourceDeleted
      // 
      this.m_BindingSourceDeleted.DataMember = "DeletedFiles";
      this.m_BindingSourceDeleted.DataSource = this.m_TracksDataSet;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.m_ButtonUndelete);
      this.panel1.Controls.Add(this.label3);
      this.panel1.Controls.Add(this.m_ButtonDeleteAll);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(945, 32);
      this.panel1.TabIndex = 0;
      // 
      // m_ButtonUndelete
      // 
      this.m_ButtonUndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.m_ButtonUndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.m_ButtonUndelete.ImageIndex = 3;
      this.m_ButtonUndelete.ImageList = this.m_ImageList25;
      this.m_ButtonUndelete.Location = new System.Drawing.Point(822, 2);
      this.m_ButtonUndelete.Name = "m_ButtonUndelete";
      this.m_ButtonUndelete.Size = new System.Drawing.Size(105, 29);
      this.m_ButtonUndelete.TabIndex = 2;
      this.m_ButtonUndelete.Text = "Undelete all";
      this.m_ButtonUndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.m_ButtonUndelete.UseVisualStyleBackColor = true;
      this.m_ButtonUndelete.Click += new System.EventHandler(this.OnUndeleteAllClick);
      // 
      // m_ImageList25
      // 
      this.m_ImageList25.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("m_ImageList25.ImageStream")));
      this.m_ImageList25.TransparentColor = System.Drawing.Color.Transparent;
      this.m_ImageList25.Images.SetKeyName(0, "1308840793_Search.ico");
      this.m_ImageList25.Images.SetKeyName(1, "1308840768_Play.ico");
      this.m_ImageList25.Images.SetKeyName(2, "1309256841_Delete.ico");
      this.m_ImageList25.Images.SetKeyName(3, "1308841035_Undo.png");
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(9, 8);
      this.label3.Name = "label3";
      this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
      this.label3.Size = new System.Drawing.Size(134, 21);
      this.label3.TabIndex = 0;
      this.label3.Text = "Marked for deletation";
      // 
      // m_ButtonDeleteAll
      // 
      this.m_ButtonDeleteAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.m_ButtonDeleteAll.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.m_ButtonDeleteAll.ImageIndex = 2;
      this.m_ButtonDeleteAll.ImageList = this.m_ImageList25;
      this.m_ButtonDeleteAll.Location = new System.Drawing.Point(717, 3);
      this.m_ButtonDeleteAll.Name = "m_ButtonDeleteAll";
      this.m_ButtonDeleteAll.Size = new System.Drawing.Size(99, 29);
      this.m_ButtonDeleteAll.TabIndex = 1;
      this.m_ButtonDeleteAll.Text = "Delete all";
      this.m_ButtonDeleteAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.m_ButtonDeleteAll.UseVisualStyleBackColor = true;
      this.m_ButtonDeleteAll.Click += new System.EventHandler(this.OnDeleteAllClick);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.m_LabelProgresBarInfo);
      this.groupBox1.Controls.Add(this.m_ProgressBar);
      this.groupBox1.Controls.Add(this.m_GroupBoxCompare);
      this.groupBox1.Controls.Add(this.m_ButtonSearch);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(945, 120);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      // 
      // m_LabelProgresBarInfo
      // 
      this.m_LabelProgresBarInfo.AutoSize = true;
      this.m_LabelProgresBarInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.m_LabelProgresBarInfo.ForeColor = System.Drawing.Color.Black;
      this.m_LabelProgresBarInfo.Location = new System.Drawing.Point(517, 14);
      this.m_LabelProgresBarInfo.Name = "m_LabelProgresBarInfo";
      this.m_LabelProgresBarInfo.Size = new System.Drawing.Size(76, 13);
      this.m_LabelProgresBarInfo.TabIndex = 2;
      this.m_LabelProgresBarInfo.Text = "Scaning files...";
      this.m_LabelProgresBarInfo.Visible = false;
      // 
      // m_ProgressBar
      // 
      this.m_ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.m_ProgressBar.Location = new System.Drawing.Point(520, 31);
      this.m_ProgressBar.Name = "m_ProgressBar";
      this.m_ProgressBar.Size = new System.Drawing.Size(407, 14);
      this.m_ProgressBar.TabIndex = 3;
      this.m_ProgressBar.Visible = false;
      // 
      // m_GroupBoxCompare
      // 
      this.m_GroupBoxCompare.Controls.Add(this.m_groupBoxIdentical);
      this.m_GroupBoxCompare.Controls.Add(this.m_groupBoxCompareSimulare);
      this.m_GroupBoxCompare.Location = new System.Drawing.Point(6, 6);
      this.m_GroupBoxCompare.Name = "m_GroupBoxCompare";
      this.m_GroupBoxCompare.Size = new System.Drawing.Size(395, 97);
      this.m_GroupBoxCompare.TabIndex = 0;
      this.m_GroupBoxCompare.TabStop = false;
      this.m_GroupBoxCompare.Text = "Compare";
      // 
      // m_groupBoxIdentical
      // 
      this.m_groupBoxIdentical.Controls.Add(this.m_compareIdenticalCheckBox);
      this.m_groupBoxIdentical.Location = new System.Drawing.Point(302, 11);
      this.m_groupBoxIdentical.Name = "m_groupBoxIdentical";
      this.m_groupBoxIdentical.Size = new System.Drawing.Size(87, 82);
      this.m_groupBoxIdentical.TabIndex = 2;
      this.m_groupBoxIdentical.TabStop = false;
      // 
      // m_compareIdenticalCheckBox
      // 
      this.m_compareIdenticalCheckBox.AutoSize = true;
      settings1.CompareArtist = true;
      settings1.CompareFileName = true;
      settings1.CompareIdentical = false;
      settings1.CompareSize = true;
      settings1.CompareTime = true;
      settings1.CompareTitle = true;
      settings1.SelectedFolders = null;
      settings1.SettingsKey = "";
      this.m_compareIdenticalCheckBox.Checked = settings1.CompareIdentical;
      this.m_compareIdenticalCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "CompareIdentical", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.m_compareIdenticalCheckBox.Location = new System.Drawing.Point(6, 17);
      this.m_compareIdenticalCheckBox.Name = "m_compareIdenticalCheckBox";
      this.m_compareIdenticalCheckBox.Size = new System.Drawing.Size(66, 17);
      this.m_compareIdenticalCheckBox.TabIndex = 1;
      this.m_compareIdenticalCheckBox.Text = "&Identical";
      this.m_ToolTip.SetToolTip(this.m_compareIdenticalCheckBox, "Find all mp3 that have equal File name, Time, Title and Size.");
      this.m_compareIdenticalCheckBox.UseVisualStyleBackColor = true;
      this.m_compareIdenticalCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
      // 
      // m_groupBoxCompareSimulare
      // 
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareArtistCheckBox);
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareAnyRadioButton);
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareAllRadioButton);
      this.m_groupBoxCompareSimulare.Controls.Add(this.label4);
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareTitleCheckBox);
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareSizeCheckBox);
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareFileNameCheckBox);
      this.m_groupBoxCompareSimulare.Controls.Add(this.m_compareLengthCheckBox);
      this.m_groupBoxCompareSimulare.Location = new System.Drawing.Point(6, 11);
      this.m_groupBoxCompareSimulare.Margin = new System.Windows.Forms.Padding(0);
      this.m_groupBoxCompareSimulare.Name = "m_groupBoxCompareSimulare";
      this.m_groupBoxCompareSimulare.Padding = new System.Windows.Forms.Padding(1);
      this.m_groupBoxCompareSimulare.Size = new System.Drawing.Size(293, 82);
      this.m_groupBoxCompareSimulare.TabIndex = 0;
      this.m_groupBoxCompareSimulare.TabStop = false;
      // 
      // m_compareArtistCheckBox
      // 
      this.m_compareArtistCheckBox.AutoSize = true;
      settings2.CompareArtist = true;
      settings2.CompareFileName = true;
      settings2.CompareIdentical = false;
      settings2.CompareSize = true;
      settings2.CompareTime = true;
      settings2.CompareTitle = true;
      settings2.SelectedFolders = null;
      settings2.SettingsKey = "";
      this.m_compareArtistCheckBox.Checked = settings2.CompareArtist;
      this.m_compareArtistCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.m_compareArtistCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings2, "CompareArtist", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.m_compareArtistCheckBox.Location = new System.Drawing.Point(18, 29);
      this.m_compareArtistCheckBox.Name = "m_compareArtistCheckBox";
      this.m_compareArtistCheckBox.Size = new System.Drawing.Size(49, 17);
      this.m_compareArtistCheckBox.TabIndex = 1;
      this.m_compareArtistCheckBox.Text = "&Artist";
      this.m_compareArtistCheckBox.UseVisualStyleBackColor = true;
      this.m_compareArtistCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
      // 
      // m_compareAnyRadioButton
      // 
      this.m_compareAnyRadioButton.AutoSize = true;
      this.m_compareAnyRadioButton.Checked = true;
      this.m_compareAnyRadioButton.Location = new System.Drawing.Point(179, 51);
      this.m_compareAnyRadioButton.Name = "m_compareAnyRadioButton";
      this.m_compareAnyRadioButton.Size = new System.Drawing.Size(43, 17);
      this.m_compareAnyRadioButton.TabIndex = 7;
      this.m_compareAnyRadioButton.TabStop = true;
      this.m_compareAnyRadioButton.Text = "A&ny";
      this.m_ToolTip.SetToolTip(this.m_compareAnyRadioButton, "Any of selected conditions should be equal.");
      this.m_compareAnyRadioButton.UseVisualStyleBackColor = true;
      // 
      // m_compareAllRadioButton
      // 
      this.m_compareAllRadioButton.AutoSize = true;
      this.m_compareAllRadioButton.Location = new System.Drawing.Point(128, 51);
      this.m_compareAllRadioButton.Name = "m_compareAllRadioButton";
      this.m_compareAllRadioButton.Size = new System.Drawing.Size(36, 17);
      this.m_compareAllRadioButton.TabIndex = 6;
      this.m_compareAllRadioButton.Text = "&All";
      this.m_ToolTip.SetToolTip(this.m_compareAllRadioButton, "All selected conditions should be equal .");
      this.m_compareAllRadioButton.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(4, 53);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(91, 13);
      this.label4.TabIndex = 5;
      this.label4.Text = "Match conditions:";
      // 
      // m_compareTitleCheckBox
      // 
      this.m_compareTitleCheckBox.AutoSize = true;
      this.m_compareTitleCheckBox.Checked = settings1.CompareTitle;
      this.m_compareTitleCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.m_compareTitleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "CompareTitle", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.m_compareTitleCheckBox.Location = new System.Drawing.Point(4, 10);
      this.m_compareTitleCheckBox.Name = "m_compareTitleCheckBox";
      this.m_compareTitleCheckBox.Size = new System.Drawing.Size(46, 17);
      this.m_compareTitleCheckBox.TabIndex = 0;
      this.m_compareTitleCheckBox.Text = "&Title";
      this.m_compareTitleCheckBox.UseVisualStyleBackColor = true;
      this.m_compareTitleCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
      // 
      // m_compareSizeCheckBox
      // 
      this.m_compareSizeCheckBox.AutoSize = true;
      this.m_compareSizeCheckBox.Checked = settings1.CompareSize;
      this.m_compareSizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.m_compareSizeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "CompareSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.m_compareSizeCheckBox.Location = new System.Drawing.Point(144, 10);
      this.m_compareSizeCheckBox.Name = "m_compareSizeCheckBox";
      this.m_compareSizeCheckBox.Size = new System.Drawing.Size(46, 17);
      this.m_compareSizeCheckBox.TabIndex = 3;
      this.m_compareSizeCheckBox.Text = "Si&ze";
      this.m_compareSizeCheckBox.UseVisualStyleBackColor = true;
      this.m_compareSizeCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
      // 
      // m_compareFileNameCheckBox
      // 
      this.m_compareFileNameCheckBox.AutoSize = true;
      this.m_compareFileNameCheckBox.Checked = settings1.CompareFileName;
      this.m_compareFileNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.m_compareFileNameCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "CompareFileName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.m_compareFileNameCheckBox.Location = new System.Drawing.Point(197, 10);
      this.m_compareFileNameCheckBox.Name = "m_compareFileNameCheckBox";
      this.m_compareFileNameCheckBox.Size = new System.Drawing.Size(71, 17);
      this.m_compareFileNameCheckBox.TabIndex = 4;
      this.m_compareFileNameCheckBox.Text = "&File name";
      this.m_compareFileNameCheckBox.UseVisualStyleBackColor = true;
      this.m_compareFileNameCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
      // 
      // m_compareLengthCheckBox
      // 
      this.m_compareLengthCheckBox.AutoSize = true;
      this.m_compareLengthCheckBox.Checked = settings1.CompareTime;
      this.m_compareLengthCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
      this.m_compareLengthCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", settings1, "CompareTime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.m_compareLengthCheckBox.Location = new System.Drawing.Point(71, 10);
      this.m_compareLengthCheckBox.Name = "m_compareLengthCheckBox";
      this.m_compareLengthCheckBox.Size = new System.Drawing.Size(66, 17);
      this.m_compareLengthCheckBox.TabIndex = 2;
      this.m_compareLengthCheckBox.Text = "&Duration";
      this.m_compareLengthCheckBox.UseVisualStyleBackColor = true;
      this.m_compareLengthCheckBox.CheckedChanged += new System.EventHandler(this.OnCheckChange);
      // 
      // m_ButtonSearch
      // 
      this.m_ButtonSearch.ForeColor = System.Drawing.Color.Black;
      this.m_ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.m_ButtonSearch.ImageIndex = 0;
      this.m_ButtonSearch.ImageList = this.m_ImageList25;
      this.m_ButtonSearch.Location = new System.Drawing.Point(407, 14);
      this.m_ButtonSearch.Name = "m_ButtonSearch";
      this.m_ButtonSearch.Size = new System.Drawing.Size(104, 29);
      this.m_ButtonSearch.TabIndex = 1;
      this.m_ButtonSearch.Text = "&Search Now";
      this.m_ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.m_ButtonSearch.UseVisualStyleBackColor = true;
      this.m_ButtonSearch.Click += new System.EventHandler(this.OnSearchClick);
      // 
      // m_ToolTip
      // 
      this.m_ToolTip.AutoPopDelay = 20000;
      this.m_ToolTip.InitialDelay = 500;
      this.m_ToolTip.ReshowDelay = 100;
      // 
      // DuplicateList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.m_PanelMain);
      this.Name = "DuplicateList";
      this.Size = new System.Drawing.Size(945, 600);
      this.m_PanelMain.ResumeLayout(false);
      this.m_SplitContainerMain.Panel1.ResumeLayout(false);
      this.m_SplitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_SplitContainerMain)).EndInit();
      this.m_SplitContainerMain.ResumeLayout(false);
      this.m_SplitContainerSub.Panel1.ResumeLayout(false);
      this.m_SplitContainerSub.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_SplitContainerSub)).EndInit();
      this.m_SplitContainerSub.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewDuplicates)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceParent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_TracksDataSet)).EndInit();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_DataGridViewDuplicateFiles)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceChild)).EndInit();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_dataGridViewDeletedList)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_BindingSourceDeleted)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.m_GroupBoxCompare.ResumeLayout(false);
      this.m_groupBoxIdentical.ResumeLayout(false);
      this.m_groupBoxIdentical.PerformLayout();
      this.m_groupBoxCompareSimulare.ResumeLayout(false);
      this.m_groupBoxCompareSimulare.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel m_PanelMain;
    private System.Windows.Forms.SplitContainer m_SplitContainerSub;
    private System.Windows.Forms.DataGridView m_DataGridViewDuplicates;
    private System.Windows.Forms.DataGridView m_DataGridViewDuplicateFiles;
    private System.Windows.Forms.SplitContainer m_SplitContainerMain;
    private System.Windows.Forms.DataGridView m_dataGridViewDeletedList;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button m_ButtonUndelete;
    private System.Windows.Forms.Button m_ButtonDeleteAll;
    private System.Windows.Forms.Button m_ButtonSearch;
    private System.Windows.Forms.GroupBox m_GroupBoxCompare;
    private System.Windows.Forms.CheckBox m_compareFileNameCheckBox;
    private System.Windows.Forms.CheckBox m_compareLengthCheckBox;
    private System.Windows.Forms.CheckBox m_compareSizeCheckBox;
    private System.Windows.Forms.CheckBox m_compareTitleCheckBox;
    private System.Windows.Forms.ProgressBar m_ProgressBar;
    private System.Windows.Forms.BindingSource m_BindingSourceParent;
    private TracksDataSet m_TracksDataSet;
    private System.Windows.Forms.BindingSource m_BindingSourceChild;
    private System.Windows.Forms.BindingSource m_BindingSourceDeleted;
    private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn;
    private System.Windows.Forms.Label m_LabelProgresBarInfo;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label m_LabelDuplicateCount;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.CheckBox m_compareIdenticalCheckBox;
    private System.Windows.Forms.ToolTip m_ToolTip;
    private System.Windows.Forms.GroupBox m_groupBoxCompareSimulare;
    private System.Windows.Forms.RadioButton m_compareAnyRadioButton;
    private System.Windows.Forms.RadioButton m_compareAllRadioButton;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ImageList m_ImageList25;
    private System.Windows.Forms.CheckBox m_compareArtistCheckBox;
    private System.Windows.Forms.GroupBox m_groupBoxIdentical;
    private System.Windows.Forms.DataGridViewImageColumn ColumnPlay;
    private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewImageColumn ColumnPlayMarkedForDel;
    private System.Windows.Forms.DataGridViewImageColumn ColumnUndelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn lengthDataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn artistDataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn1;
  }
}
