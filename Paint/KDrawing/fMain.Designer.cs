namespace KDrawing
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.tblpnlMain = new System.Windows.Forms.TableLayoutPanel();
            this.titleBar = new KDrawing.KControls.TitleBar();
            this.dragMovePnl = new KDrawing.KControls.DragMovePanel();
            this.mnu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFile_Quit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFillColor = new KDrawing.KControls.SelectColorButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cboDashStyle = new System.Windows.Forms.ComboBox();
            this.nudLineWeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnableFill = new KDrawing.KControls.ToggleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dragMovePanel1 = new KDrawing.KControls.DragMovePanel();
            this.tblpnlMidArea = new System.Windows.Forms.TableLayoutPanel();
            this.pnlToolbar = new System.Windows.Forms.Panel();
            this.btnForeColor = new KDrawing.KControls.SelectColorButton();
            this.btnBackColor = new KDrawing.KControls.SelectColorButton();
            this.btnRectangle = new KDrawing.KControls.FlatButton();
            this.btnEllipse = new KDrawing.KControls.FlatButton();
            this.btnCurve = new KDrawing.KControls.FlatButton();
            this.btnPencil = new KDrawing.KControls.FlatButton();
            this.btnDelete = new KDrawing.KControls.FlatButton();
            this.btnSelect = new KDrawing.KControls.FlatButton();
            this.psfMain = new KDrawing.KControls.PaintSurface();
            this.imgCboDashStyle = new System.Windows.Forms.ImageList(this.components);
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.shapeLayers = new KDrawing.MyUserControls.ShapeLayersManager();
            this.tblpnlMain.SuspendLayout();
            this.dragMovePnl.SuspendLayout();
            this.mnu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tblpnlMidArea.SuspendLayout();
            this.pnlToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblpnlMain
            // 
            this.tblpnlMain.ColumnCount = 1;
            this.tblpnlMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.Controls.Add(this.titleBar, 0, 0);
            this.tblpnlMain.Controls.Add(this.dragMovePnl, 0, 1);
            this.tblpnlMain.Controls.Add(this.tblpnlMidArea, 0, 2);
            this.tblpnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMain.Location = new System.Drawing.Point(0, 0);
            this.tblpnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnlMain.Name = "tblpnlMain";
            this.tblpnlMain.RowCount = 4;
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblpnlMain.Size = new System.Drawing.Size(1582, 853);
            this.tblpnlMain.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.titleBar.ButtonForeColor = KDrawing.KControls.TitleBar.ButtonColor.White;
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.Location = new System.Drawing.Point(2, 2);
            this.titleBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.ResizeWindowsBox = KDrawing.KControls.TitleBar.ResizeBox.MinimizeAndMaximize;
            this.titleBar.Size = new System.Drawing.Size(1578, 34);
            this.titleBar.TabIndex = 0;
            this.titleBar.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.TitleForeColor = System.Drawing.Color.White;
            this.titleBar.TitleIcon = ((System.Drawing.Image)(resources.GetObject("titleBar.TitleIcon")));
            this.titleBar.TitleText = "KDrawing";
            // 
            // dragMovePnl
            // 
            this.dragMovePnl.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.dragMovePnl.Controls.Add(this.mnu);
            this.dragMovePnl.Controls.Add(this.panel1);
            this.dragMovePnl.Controls.Add(this.dragMovePanel1);
            this.dragMovePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragMovePnl.Location = new System.Drawing.Point(2, 36);
            this.dragMovePnl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.dragMovePnl.Name = "dragMovePnl";
            this.dragMovePnl.Size = new System.Drawing.Size(1578, 34);
            this.dragMovePnl.TabIndex = 1;
            // 
            // mnu
            // 
            this.mnu.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.mnu.Location = new System.Drawing.Point(0, 4);
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(82, 40);
            this.mnu.TabIndex = 0;
            this.mnu.Text = "mnu";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile_Open,
            this.mnuFile_New,
            this.toolStripSeparator4,
            this.mnuFile_Save,
            this.toolStripSeparator5,
            this.mnuFile_Quit});
            this.mnuFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.mnuFile.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(61, 36);
            this.mnuFile.Text = "File";
            // 
            // mnuFile_Open
            // 
            this.mnuFile_Open.Name = "mnuFile_Open";
            this.mnuFile_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuFile_Open.Size = new System.Drawing.Size(246, 38);
            this.mnuFile_Open.Text = "Open";
            this.mnuFile_Open.Click += new System.EventHandler(this.mnuFile_Open_Click);
            // 
            // mnuFile_New
            // 
            this.mnuFile_New.Name = "mnuFile_New";
            this.mnuFile_New.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFile_New.Size = new System.Drawing.Size(246, 38);
            this.mnuFile_New.Text = "New";
            this.mnuFile_New.Click += new System.EventHandler(this.mnuFile_New_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(243, 6);
            // 
            // mnuFile_Save
            // 
            this.mnuFile_Save.Name = "mnuFile_Save";
            this.mnuFile_Save.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuFile_Save.Size = new System.Drawing.Size(246, 38);
            this.mnuFile_Save.Text = "Save";
            this.mnuFile_Save.Click += new System.EventHandler(this.mnuFile_Save_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(243, 6);
            // 
            // mnuFile_Quit
            // 
            this.mnuFile_Quit.Name = "mnuFile_Quit";
            this.mnuFile_Quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuFile_Quit.Size = new System.Drawing.Size(246, 38);
            this.mnuFile_Quit.Text = "Quit";
            this.mnuFile_Quit.Click += new System.EventHandler(this.mnuFile_Quit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFillColor);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.cboDashStyle);
            this.panel1.Controls.Add(this.nudLineWeight);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEnableFill);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(565, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 34);
            this.panel1.TabIndex = 4;
            // 
            // btnFillColor
            // 
            this.btnFillColor.BackColor = System.Drawing.Color.Black;
            this.btnFillColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFillColor.Enabled = false;
            this.btnFillColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFillColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFillColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFillColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillColor.Location = new System.Drawing.Point(174, 5);
            this.btnFillColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnFillColor.Name = "btnFillColor";
            this.btnFillColor.Size = new System.Drawing.Size(24, 24);
            this.btnFillColor.TabIndex = 1;
            this.btnFillColor.ToolTipActive = true;
            this.btnFillColor.ToolTipAutomaticDelay = 500;
            this.btnFillColor.ToolTipAutoPopDelay = 5000;
            this.btnFillColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnFillColor.ToolTipCaption = "";
            this.btnFillColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnFillColor.ToolTipInitialDelay = 200;
            this.btnFillColor.ToolTipIsBalloon = false;
            this.btnFillColor.ToolTipReshowDelay = 100;
            this.btnFillColor.ToolTipShowAlways = true;
            this.btnFillColor.ToolTipTitle = "fill color";
            this.btnFillColor.UseVisualStyleBackColor = false;
            this.btnFillColor.BackColorChanged += new System.EventHandler(this.btnFillColor_BackColorChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(7, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(2, 20);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // cboDashStyle
            // 
            this.cboDashStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDashStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDashStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDashStyle.FormattingEnabled = true;
            this.cboDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "Dash Dot",
            "Dash Dot Dot"});
            this.cboDashStyle.Location = new System.Drawing.Point(565, 4);
            this.cboDashStyle.Name = "cboDashStyle";
            this.cboDashStyle.Size = new System.Drawing.Size(150, 32);
            this.cboDashStyle.TabIndex = 2;
            this.cboDashStyle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboDashStyle_DrawItem);
            this.cboDashStyle.SelectedIndexChanged += new System.EventHandler(this.cboDashStyle_SelectedIndexChanged);
            // 
            // nudLineWeight
            // 
            this.nudLineWeight.DecimalPlaces = 2;
            this.nudLineWeight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLineWeight.Location = new System.Drawing.Point(349, 4);
            this.nudLineWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWeight.Name = "nudLineWeight";
            this.nudLineWeight.Size = new System.Drawing.Size(79, 31);
            this.nudLineWeight.TabIndex = 2;
            this.nudLineWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudLineWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLineWeight.ValueChanged += new System.EventHandler(this.nudLineWeight_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(481, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dash style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(254, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Line weight";
            // 
            // btnEnableFill
            // 
            this.btnEnableFill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnableFill.BackgroundImage")));
            this.btnEnableFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnableFill.FlatAppearance.BorderSize = 0;
            this.btnEnableFill.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEnableFill.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEnableFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnableFill.Location = new System.Drawing.Point(68, 5);
            this.btnEnableFill.Name = "btnEnableFill";
            this.btnEnableFill.Size = new System.Drawing.Size(48, 24);
            this.btnEnableFill.TabIndex = 0;
            this.btnEnableFill.ToggleButtonStyle = KDrawing.KControls.ToggleButton.Style.ToggleButtonStyle3;
            this.btnEnableFill.ToggleStage = false;
            this.btnEnableFill.ToolTipActive = true;
            this.btnEnableFill.ToolTipAutomaticDelay = 500;
            this.btnEnableFill.ToolTipAutoPopDelay = 5000;
            this.btnEnableFill.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnEnableFill.ToolTipCaption = "";
            this.btnEnableFill.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEnableFill.ToolTipInitialDelay = 200;
            this.btnEnableFill.ToolTipIsBalloon = false;
            this.btnEnableFill.ToolTipReshowDelay = 100;
            this.btnEnableFill.ToolTipShowAlways = true;
            this.btnEnableFill.ToolTipTitle = "";
            this.btnEnableFill.UseVisualStyleBackColor = true;
            this.btnEnableFill.Click += new System.EventHandler(this.btnEnableFill_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(122, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "color";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fill";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(231, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(433, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "pt";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(469, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2, 20);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dragMovePanel1
            // 
            this.dragMovePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dragMovePanel1.Location = new System.Drawing.Point(1278, 0);
            this.dragMovePanel1.Name = "dragMovePanel1";
            this.dragMovePanel1.Size = new System.Drawing.Size(300, 34);
            this.dragMovePanel1.TabIndex = 2;
            // 
            // tblpnlMidArea
            // 
            this.tblpnlMidArea.ColumnCount = 3;
            this.tblpnlMidArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlMidArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMidArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblpnlMidArea.Controls.Add(this.shapeLayers, 2, 0);
            this.tblpnlMidArea.Controls.Add(this.pnlToolbar, 0, 0);
            this.tblpnlMidArea.Controls.Add(this.psfMain, 1, 0);
            this.tblpnlMidArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblpnlMidArea.Location = new System.Drawing.Point(0, 72);
            this.tblpnlMidArea.Margin = new System.Windows.Forms.Padding(0);
            this.tblpnlMidArea.Name = "tblpnlMidArea";
            this.tblpnlMidArea.RowCount = 1;
            this.tblpnlMidArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblpnlMidArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 781F));
            this.tblpnlMidArea.Size = new System.Drawing.Size(1582, 781);
            this.tblpnlMidArea.TabIndex = 3;
            // 
            // pnlToolbar
            // 
            this.pnlToolbar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlToolbar.Controls.Add(this.btnForeColor);
            this.pnlToolbar.Controls.Add(this.btnBackColor);
            this.pnlToolbar.Controls.Add(this.btnRectangle);
            this.pnlToolbar.Controls.Add(this.btnEllipse);
            this.pnlToolbar.Controls.Add(this.btnCurve);
            this.pnlToolbar.Controls.Add(this.btnPencil);
            this.pnlToolbar.Controls.Add(this.btnDelete);
            this.pnlToolbar.Controls.Add(this.btnSelect);
            this.pnlToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolbar.Location = new System.Drawing.Point(2, 0);
            this.pnlToolbar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pnlToolbar.Name = "pnlToolbar";
            this.pnlToolbar.Size = new System.Drawing.Size(60, 781);
            this.pnlToolbar.TabIndex = 0;
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackColor = System.Drawing.Color.Black;
            this.btnForeColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForeColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnForeColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnForeColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnForeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForeColor.Location = new System.Drawing.Point(7, 122);
            this.btnForeColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(35, 35);
            this.btnForeColor.TabIndex = 0;
            this.btnForeColor.ToolTipActive = true;
            this.btnForeColor.ToolTipAutomaticDelay = 500;
            this.btnForeColor.ToolTipAutoPopDelay = 5000;
            this.btnForeColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnForeColor.ToolTipCaption = "Fore color or color outline of fill shape";
            this.btnForeColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnForeColor.ToolTipInitialDelay = 200;
            this.btnForeColor.ToolTipIsBalloon = false;
            this.btnForeColor.ToolTipReshowDelay = 100;
            this.btnForeColor.ToolTipShowAlways = true;
            this.btnForeColor.ToolTipTitle = "Fore color";
            this.btnForeColor.UseVisualStyleBackColor = false;
            this.btnForeColor.BackColorChanged += new System.EventHandler(this.btnForeColor_BackColorChanged);
            // 
            // btnBackColor
            // 
            this.btnBackColor.BackColor = System.Drawing.Color.White;
            this.btnBackColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackColor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBackColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBackColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Location = new System.Drawing.Point(7, 170);
            this.btnBackColor.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(35, 35);
            this.btnBackColor.TabIndex = 0;
            this.btnBackColor.ToolTipActive = true;
            this.btnBackColor.ToolTipAutomaticDelay = 500;
            this.btnBackColor.ToolTipAutoPopDelay = 5000;
            this.btnBackColor.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnBackColor.ToolTipCaption = "Back color";
            this.btnBackColor.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnBackColor.ToolTipInitialDelay = 200;
            this.btnBackColor.ToolTipIsBalloon = false;
            this.btnBackColor.ToolTipReshowDelay = 100;
            this.btnBackColor.ToolTipShowAlways = true;
            this.btnBackColor.ToolTipTitle = "Back color";
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.BackColorChanged += new System.EventHandler(this.btnBackColor_BackColorChanged);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::KDrawing.Properties.Resources.shape_rectangle_outline_white;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.Location = new System.Drawing.Point(0, 385);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(0);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(50, 40);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Tag = "Rectangle";
            this.btnRectangle.ToolTipActive = true;
            this.btnRectangle.ToolTipAutomaticDelay = 500;
            this.btnRectangle.ToolTipAutoPopDelay = 5000;
            this.btnRectangle.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnRectangle.ToolTipCaption = "Draw a rectangle, press \"Shift\" while drawing to draw square";
            this.btnRectangle.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnRectangle.ToolTipInitialDelay = 200;
            this.btnRectangle.ToolTipIsBalloon = false;
            this.btnRectangle.ToolTipReshowDelay = 100;
            this.btnRectangle.ToolTipShowAlways = true;
            this.btnRectangle.ToolTipTitle = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnShape_Click);
            this.btnRectangle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRectangle_MouseDown);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackgroundImage = global::KDrawing.Properties.Resources.shape_ellipse_outline_white;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEllipse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.Location = new System.Drawing.Point(0, 331);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(0);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(50, 40);
            this.btnEllipse.TabIndex = 0;
            this.btnEllipse.Tag = "Ellipse";
            this.btnEllipse.ToolTipActive = true;
            this.btnEllipse.ToolTipAutomaticDelay = 500;
            this.btnEllipse.ToolTipAutoPopDelay = 5000;
            this.btnEllipse.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnEllipse.ToolTipCaption = "Draw an ellipse, press \"Shift\" while drawing to draw circle";
            this.btnEllipse.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnEllipse.ToolTipInitialDelay = 200;
            this.btnEllipse.ToolTipIsBalloon = false;
            this.btnEllipse.ToolTipReshowDelay = 100;
            this.btnEllipse.ToolTipShowAlways = true;
            this.btnEllipse.ToolTipTitle = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnShape_Click);
            this.btnEllipse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEllipse_MouseDown);
            // 
            // btnCurve
            // 
            this.btnCurve.BackgroundImage = global::KDrawing.Properties.Resources.shape_curve_white;
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCurve.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnCurve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnCurve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnCurve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurve.Location = new System.Drawing.Point(2, 280);
            this.btnCurve.Margin = new System.Windows.Forms.Padding(0);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(50, 40);
            this.btnCurve.TabIndex = 0;
            this.btnCurve.Tag = "Curve";
            this.btnCurve.ToolTipActive = true;
            this.btnCurve.ToolTipAutomaticDelay = 500;
            this.btnCurve.ToolTipAutoPopDelay = 5000;
            this.btnCurve.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnCurve.ToolTipCaption = "Draw curve, stop by double click";
            this.btnCurve.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnCurve.ToolTipInitialDelay = 200;
            this.btnCurve.ToolTipIsBalloon = false;
            this.btnCurve.ToolTipReshowDelay = 100;
            this.btnCurve.ToolTipShowAlways = true;
            this.btnCurve.ToolTipTitle = "Curve";
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackgroundImage = global::KDrawing.Properties.Resources.lead_pencil_white;
            this.btnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPencil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.Location = new System.Drawing.Point(0, 219);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(50, 50);
            this.btnPencil.TabIndex = 0;
            this.btnPencil.Tag = "Freehand";
            this.btnPencil.ToolTipActive = true;
            this.btnPencil.ToolTipAutomaticDelay = 500;
            this.btnPencil.ToolTipAutoPopDelay = 5000;
            this.btnPencil.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnPencil.ToolTipCaption = "Draw like you are holding a pencil ";
            this.btnPencil.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnPencil.ToolTipInitialDelay = 200;
            this.btnPencil.ToolTipIsBalloon = false;
            this.btnPencil.ToolTipReshowDelay = 100;
            this.btnPencil.ToolTipShowAlways = true;
            this.btnPencil.ToolTipTitle = "Freehand";
            this.btnPencil.UseVisualStyleBackColor = true;
            this.btnPencil.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::KDrawing.Properties.Resources.trash_red;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(5, 55);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.ToolTipActive = true;
            this.btnDelete.ToolTipAutomaticDelay = 500;
            this.btnDelete.ToolTipAutoPopDelay = 5000;
            this.btnDelete.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.ToolTipCaption = "Delete selected shapes";
            this.btnDelete.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnDelete.ToolTipInitialDelay = 200;
            this.btnDelete.ToolTipIsBalloon = false;
            this.btnDelete.ToolTipReshowDelay = 100;
            this.btnDelete.ToolTipShowAlways = true;
            this.btnDelete.ToolTipTitle = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = global::KDrawing.Properties.Resources.arrow_all;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnSelect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Location = new System.Drawing.Point(5, 5);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(50, 50);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.ToolTipActive = true;
            this.btnSelect.ToolTipAutomaticDelay = 500;
            this.btnSelect.ToolTipAutoPopDelay = 5000;
            this.btnSelect.ToolTipBackColor = System.Drawing.SystemColors.Info;
            this.btnSelect.ToolTipCaption = "Select shape by click. Hold \"Ctrl\" to select multi shapes";
            this.btnSelect.ToolTipForeColor = System.Drawing.SystemColors.InfoText;
            this.btnSelect.ToolTipInitialDelay = 200;
            this.btnSelect.ToolTipIsBalloon = false;
            this.btnSelect.ToolTipReshowDelay = 100;
            this.btnSelect.ToolTipShowAlways = true;
            this.btnSelect.ToolTipTitle = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // psfMain
            // 
            this.psfMain.BackColor = System.Drawing.Color.White;
            this.psfMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.psfMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.psfMain.Location = new System.Drawing.Point(69, 5);
            this.psfMain.Margin = new System.Windows.Forms.Padding(5);
            this.psfMain.MyBitmap = ((System.Drawing.Bitmap)(resources.GetObject("psfMain.MyBitmap")));
            this.psfMain.Name = "psfMain";
            this.psfMain.Size = new System.Drawing.Size(1204, 771);
            this.psfMain.TabIndex = 14;
            this.psfMain.Paint += new System.Windows.Forms.PaintEventHandler(this.psfMain_Paint);
            this.psfMain.DoubleClick += new System.EventHandler(this.psfMain_DoubleClick);
            this.psfMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.psfMain_MouseDown);
            this.psfMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.psfMain_MouseMove);
            this.psfMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.psfMain_MouseUp);
            // 
            // imgCboDashStyle
            // 
            this.imgCboDashStyle.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgCboDashStyle.ImageStream")));
            this.imgCboDashStyle.TransparentColor = System.Drawing.Color.Transparent;
            this.imgCboDashStyle.Images.SetKeyName(0, "0_Solid.png");
            this.imgCboDashStyle.Images.SetKeyName(1, "1_Dash.png");
            this.imgCboDashStyle.Images.SetKeyName(2, "2_Dot.png");
            this.imgCboDashStyle.Images.SetKeyName(3, "3_DashDot.png");
            this.imgCboDashStyle.Images.SetKeyName(4, "4_DashDotDot.png");
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // shapeLayers
            // 
            this.shapeLayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.shapeLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shapeLayers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shapeLayers.Location = new System.Drawing.Point(1280, 0);
            this.shapeLayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeLayers.Name = "shapeLayers";
            this.shapeLayers.Size = new System.Drawing.Size(300, 781);
            this.shapeLayers.TabIndex = 13;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.tblpnlMain);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnu;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fMain_KeyUp);
            this.tblpnlMain.ResumeLayout(false);
            this.dragMovePnl.ResumeLayout(false);
            this.dragMovePnl.PerformLayout();
            this.mnu.ResumeLayout(false);
            this.mnu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLineWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tblpnlMidArea.ResumeLayout(false);
            this.pnlToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void BtnEllipse_DoubleClick1(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblpnlMain;
        private KControls.TitleBar titleBar;
        private KControls.DragMovePanel dragMovePnl;
        private System.Windows.Forms.TableLayoutPanel tblpnlMidArea;
        private System.Windows.Forms.Panel pnlToolbar;
        private MyUserControls.ShapeLayersManager shapeLayers;
        private KControls.PaintSurface psfMain;
        private System.Windows.Forms.MenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private KControls.DragMovePanel dragMovePanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.ComboBox cboDashStyle;
        public System.Windows.Forms.NumericUpDown nudLineWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private KDrawing.KControls.ToggleButton btnEnableFill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private KDrawing.KControls.FlatButton btnSelect;
        private System.Windows.Forms.ImageList imgCboDashStyle;
        private KDrawing.KControls.FlatButton btnDelete;
        private KDrawing.KControls.SelectColorButton btnForeColor;
        private KDrawing.KControls.SelectColorButton btnBackColor;
        private KDrawing.KControls.FlatButton btnRectangle;
        private KDrawing.KControls.FlatButton btnEllipse;
        private KDrawing.KControls.FlatButton btnCurve;
        private KDrawing.KControls.FlatButton btnPencil;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Open;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_New;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem mnuFile_Quit;
        private System.Windows.Forms.Timer tmrUpdate;
        private KControls.SelectColorButton btnFillColor;
        private System.Windows.Forms.Label label5;
    }
}