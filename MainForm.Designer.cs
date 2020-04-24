namespace nForce2XT
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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                ols.Dispose();
                utils.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.trayMenuItemApp = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.AdvancedGroup = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.DRAMTab = new System.Windows.Forms.TabPage();
            this.ChipsetTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.TREF = new nForce2XTLibrary.TrefTimingItem();
            this.TRTW = new nForce2XTLibrary.TimingItem();
            this.TRTP = new nForce2XTLibrary.TimingItem();
            this.TREXT = new nForce2XTLibrary.TimingItem();
            this.TWTR = new nForce2XTLibrary.TimingItem();
            this.TWTP = new nForce2XTLibrary.TimingItem();
            this.TRRD = new nForce2XTLibrary.TimingItem();
            this.TDOE = new nForce2XTLibrary.TimingItem();
            this.CAS = new nForce2XTLibrary.TimingItem();
            this.TRCDR = new nForce2XTLibrary.TimingItem();
            this.TRCDW = new nForce2XTLibrary.TimingItem();
            this.TRP = new nForce2XTLibrary.TimingItem();
            this.TRAS = new nForce2XTLibrary.TimingItem();
            this.TRC = new nForce2XTLibrary.TimingItem();
            this.TRFC = new nForce2XTLibrary.TimingItem();
            this.CR = new nForce2XTLibrary.TimingItem();
            this.advancedTextBox1 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox2 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox3 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox4 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox5 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox6 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox7 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox8 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox9 = new nForce2XTLibrary.AdvancedTextBox();
            this.advancedTextBox10 = new nForce2XTLibrary.AdvancedTextBox();
            this.ROMSIPPreset = new nForce2XTLibrary.BooleanTimingItem();
            this.DIMM0DrvStrA = new nForce2XTLibrary.TimingItem();
            this.DIMM0DrvStrB = new nForce2XTLibrary.TimingItem();
            this.DIMM0SlewRate = new nForce2XTLibrary.TimingItem();
            this.DIMM1DrvStrA = new nForce2XTLibrary.TimingItem();
            this.DIMM1DrvStrB = new nForce2XTLibrary.TimingItem();
            this.DIMM1SlewRate = new nForce2XTLibrary.TimingItem();
            this.DIMM2DrvStrA = new nForce2XTLibrary.TimingItem();
            this.DIMM2DrvStrB = new nForce2XTLibrary.TimingItem();
            this.DIMM2SlewRate = new nForce2XTLibrary.TimingItem();
            this.AutoPrecharge = new nForce2XTLibrary.BooleanTimingItem();
            this.SuperBypass = new nForce2XTLibrary.BooleanTimingItem();
            this.DataScavengedRate = new nForce2XTLibrary.BooleanTimingItem();
            this.DriveStrengthMode = new nForce2XTLibrary.BooleanTimingItem();
            this.BurstMode = new nForce2XTLibrary.BooleanTimingItem();
            this.CPUDisconnect = new nForce2XTLibrary.BooleanTimingItem();
            this.AGPFastWrite = new nForce2XTLibrary.BooleanTimingItem();
            this.AGPSBA = new nForce2XTLibrary.BooleanTimingItem();
            this.AGPControllerLatency = new nForce2XTLibrary.LatencyTimingItem();
            this.AGPBusLatency = new nForce2XTLibrary.LatencyTimingItem();
            this.PCILatency = new nForce2XTLibrary.LatencyTimingItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.trayIconMenu.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.AdvancedGroup.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.DRAMTab.SuspendLayout();
            this.ChipsetTab.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.TREF, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.TRTW, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.TRTP, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.TREXT, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.TWTR, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.TWTP, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.TRRD, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.TDOE, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.CAS, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TRCDR, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TRCDW, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TRP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TRAS, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.TRC, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TRFC, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.CR, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(122, 389);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel2.Controls.Add(this.buttonApply, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonRefresh, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 484);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 39);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // buttonApply
            // 
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonApply.Location = new System.Drawing.Point(307, 8);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 0;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(226, 8);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayIconMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "nForce2XT";
            this.trayIcon.DoubleClick += new System.EventHandler(this.TrayIcon_DoubleClick);
            // 
            // trayIconMenu
            // 
            this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayMenuItemApp,
            this.trayMenuItemExit});
            this.trayIconMenu.Name = "trayIconMenu";
            this.trayIconMenu.Size = new System.Drawing.Size(94, 48);
            // 
            // trayMenuItemApp
            // 
            this.trayMenuItemApp.Name = "trayMenuItemApp";
            this.trayMenuItemApp.Size = new System.Drawing.Size(93, 22);
            // 
            // trayMenuItemExit
            // 
            this.trayMenuItemExit.Name = "trayMenuItemExit";
            this.trayMenuItemExit.Size = new System.Drawing.Size(93, 22);
            this.trayMenuItemExit.Text = "Exit";
            this.trayMenuItemExit.Click += new System.EventHandler(this.TrayMenuItemExit_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(134, 421);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 410);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DRAM Timings";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.AdvancedGroup, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(143, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(229, 421);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // AdvancedGroup
            // 
            this.AdvancedGroup.AutoSize = true;
            this.AdvancedGroup.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AdvancedGroup.Controls.Add(this.tableLayoutPanel10);
            this.AdvancedGroup.Controls.Add(this.tableLayoutPanel6);
            this.AdvancedGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdvancedGroup.Location = new System.Drawing.Point(3, 8);
            this.AdvancedGroup.Name = "AdvancedGroup";
            this.AdvancedGroup.Size = new System.Drawing.Size(223, 410);
            this.AdvancedGroup.TabIndex = 0;
            this.AdvancedGroup.TabStop = false;
            this.AdvancedGroup.Text = "Advanced";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 7;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel10.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel10.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel10.Controls.Add(this.label4, 5, 0);
            this.tableLayoutPanel10.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox1, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox2, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox3, 3, 1);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox4, 4, 1);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox5, 5, 1);
            this.tableLayoutPanel10.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.label6, 2, 2);
            this.tableLayoutPanel10.Controls.Add(this.label7, 3, 2);
            this.tableLayoutPanel10.Controls.Add(this.label8, 4, 2);
            this.tableLayoutPanel10.Controls.Add(this.label9, 5, 2);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox6, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox7, 2, 3);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox8, 3, 3);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox9, 4, 3);
            this.tableLayoutPanel10.Controls.Add(this.advancedTextBox10, 5, 3);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 304);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 5;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(217, 103);
            this.tableLayoutPanel10.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(73, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "65";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(131, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "67";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(160, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "68";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(189, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "69";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(102, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 23);
            this.label10.TabIndex = 13;
            this.label10.Text = "66";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(73, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "6A";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(102, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "6B";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(131, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "6C";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(160, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "6D";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(189, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "6F";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel6.Controls.Add(this.ROMSIPPreset, 0, 11);
            this.tableLayoutPanel6.Controls.Add(this.DIMM0DrvStrA, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.DIMM0DrvStrB, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.DIMM0SlewRate, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.DIMM1DrvStrA, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.DIMM1DrvStrB, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.DIMM1SlewRate, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.DIMM2DrvStrA, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.DIMM2DrvStrB, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.DIMM2SlewRate, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.AutoPrecharge, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.SuperBypass, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.DataScavengedRate, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.DriveStrengthMode, 0, 9);
            this.tableLayoutPanel6.Controls.Add(this.BurstMode, 0, 10);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 12;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(217, 288);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(375, 427);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Window;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(389, 24);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "MainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveAsToolStripMenuItem,
            this.LoadProfileMenuItem,
            this.OptionsMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.SaveAsToolStripMenuItem.Text = "Save Profile &As";
            // 
            // LoadProfileMenuItem
            // 
            this.LoadProfileMenuItem.Name = "LoadProfileMenuItem";
            this.LoadProfileMenuItem.Size = new System.Drawing.Size(151, 22);
            this.LoadProfileMenuItem.Text = "&Load Profile";
            // 
            // OptionsMenuItem
            // 
            this.OptionsMenuItem.Name = "OptionsMenuItem";
            this.OptionsMenuItem.Size = new System.Drawing.Size(151, 22);
            this.OptionsMenuItem.Text = "&Options";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.DRAMTab);
            this.tabControlSettings.Controls.Add(this.ChipsetTab);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 24);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(389, 460);
            this.tabControlSettings.TabIndex = 9;
            // 
            // DRAMTab
            // 
            this.DRAMTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DRAMTab.Controls.Add(this.tableLayoutPanel4);
            this.DRAMTab.Location = new System.Drawing.Point(4, 22);
            this.DRAMTab.Name = "DRAMTab";
            this.DRAMTab.Padding = new System.Windows.Forms.Padding(3);
            this.DRAMTab.Size = new System.Drawing.Size(381, 434);
            this.DRAMTab.TabIndex = 0;
            this.DRAMTab.Text = "DRAM";
            // 
            // ChipsetTab
            // 
            this.ChipsetTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChipsetTab.Controls.Add(this.tableLayoutPanel7);
            this.ChipsetTab.Location = new System.Drawing.Point(4, 22);
            this.ChipsetTab.Name = "ChipsetTab";
            this.ChipsetTab.Padding = new System.Windows.Forms.Padding(3);
            this.ChipsetTab.Size = new System.Drawing.Size(381, 434);
            this.ChipsetTab.TabIndex = 1;
            this.ChipsetTab.Text = "Chipset";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.AutoSize = true;
            this.tableLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 600F));
            this.tableLayoutPanel7.Controls.Add(this.CPUDisconnect, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.AGPFastWrite, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.AGPSBA, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.AGPControllerLatency, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.AGPBusLatency, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.PCILatency, 1, 6);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 8;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(375, 428);
            this.tableLayoutPanel7.TabIndex = 2;
            // 
            // TREF
            // 
            this.TREF.DropdownWidth = 0;
            this.TREF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TREF.Format = "{0:0000}";
            this.TREF.Label = "TREF";
            this.TREF.Location = new System.Drawing.Point(0, 360);
            this.TREF.Margin = new System.Windows.Forms.Padding(0);
            this.TREF.Max = 4708;
            this.TREF.Min = 16;
            this.TREF.MinDisplay = 16D;
            this.TREF.Name = "TREF";
            this.TREF.Readonly = false;
            this.TREF.Size = new System.Drawing.Size(120, 24);
            this.TREF.Step = 1D;
            this.TREF.TabIndex = 7;
            this.TREF.Value = 16;
            // 
            // TRTW
            // 
            this.TRTW.DropdownWidth = 0;
            this.TRTW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRTW.Format = "{0}";
            this.TRTW.Label = "TRTW";
            this.TRTW.Location = new System.Drawing.Point(0, 336);
            this.TRTW.Margin = new System.Windows.Forms.Padding(0);
            this.TRTW.Max = 7;
            this.TRTW.Min = 0;
            this.TRTW.MinDisplay = 0D;
            this.TRTW.Name = "TRTW";
            this.TRTW.Readonly = false;
            this.TRTW.Size = new System.Drawing.Size(120, 24);
            this.TRTW.Step = 1D;
            this.TRTW.TabIndex = 15;
            this.TRTW.Value = 0;
            // 
            // TRTP
            // 
            this.TRTP.DropdownWidth = 0;
            this.TRTP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRTP.Format = "{0}";
            this.TRTP.Label = "TRTP";
            this.TRTP.Location = new System.Drawing.Point(0, 312);
            this.TRTP.Margin = new System.Windows.Forms.Padding(0);
            this.TRTP.Max = 7;
            this.TRTP.Min = 0;
            this.TRTP.MinDisplay = 0D;
            this.TRTP.Name = "TRTP";
            this.TRTP.Readonly = false;
            this.TRTP.Size = new System.Drawing.Size(120, 24);
            this.TRTP.Step = 1D;
            this.TRTP.TabIndex = 14;
            this.TRTP.Value = 0;
            // 
            // TREXT
            // 
            this.TREXT.DropdownWidth = 0;
            this.TREXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TREXT.Format = "{0}";
            this.TREXT.Label = "TREXT";
            this.TREXT.Location = new System.Drawing.Point(0, 288);
            this.TREXT.Margin = new System.Windows.Forms.Padding(0);
            this.TREXT.Max = 3;
            this.TREXT.Min = 0;
            this.TREXT.MinDisplay = 0D;
            this.TREXT.Name = "TREXT";
            this.TREXT.Readonly = false;
            this.TREXT.Size = new System.Drawing.Size(120, 24);
            this.TREXT.Step = 1D;
            this.TREXT.TabIndex = 13;
            this.TREXT.Value = 0;
            // 
            // TWTR
            // 
            this.TWTR.DropdownWidth = 0;
            this.TWTR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TWTR.Format = "{0}";
            this.TWTR.Label = "TWTR";
            this.TWTR.Location = new System.Drawing.Point(0, 264);
            this.TWTR.Margin = new System.Windows.Forms.Padding(0);
            this.TWTR.Max = 7;
            this.TWTR.Min = 0;
            this.TWTR.MinDisplay = 0D;
            this.TWTR.Name = "TWTR";
            this.TWTR.Readonly = false;
            this.TWTR.Size = new System.Drawing.Size(120, 24);
            this.TWTR.Step = 1D;
            this.TWTR.TabIndex = 12;
            this.TWTR.Value = 0;
            // 
            // TWTP
            // 
            this.TWTP.DropdownWidth = 0;
            this.TWTP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TWTP.Format = "{0}";
            this.TWTP.Label = "TWTP";
            this.TWTP.Location = new System.Drawing.Point(0, 240);
            this.TWTP.Margin = new System.Windows.Forms.Padding(0);
            this.TWTP.Max = 7;
            this.TWTP.Min = 0;
            this.TWTP.MinDisplay = 0D;
            this.TWTP.Name = "TWTP";
            this.TWTP.Readonly = false;
            this.TWTP.Size = new System.Drawing.Size(120, 24);
            this.TWTP.Step = 1D;
            this.TWTP.TabIndex = 11;
            this.TWTP.Value = 0;
            // 
            // TRRD
            // 
            this.TRRD.DropdownWidth = 0;
            this.TRRD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRRD.Format = "{0}";
            this.TRRD.Label = "TRRD";
            this.TRRD.Location = new System.Drawing.Point(0, 216);
            this.TRRD.Margin = new System.Windows.Forms.Padding(0);
            this.TRRD.Max = 7;
            this.TRRD.Min = 0;
            this.TRRD.MinDisplay = 0D;
            this.TRRD.Name = "TRRD";
            this.TRRD.Readonly = false;
            this.TRRD.Size = new System.Drawing.Size(120, 24);
            this.TRRD.Step = 1D;
            this.TRRD.TabIndex = 10;
            this.TRRD.Value = 0;
            // 
            // TDOE
            // 
            this.TDOE.DropdownWidth = 0;
            this.TDOE.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TDOE.Format = "{0}";
            this.TDOE.Label = "TDOE";
            this.TDOE.Location = new System.Drawing.Point(0, 192);
            this.TDOE.Margin = new System.Windows.Forms.Padding(0);
            this.TDOE.Max = 7;
            this.TDOE.Min = 0;
            this.TDOE.MinDisplay = 0D;
            this.TDOE.Name = "TDOE";
            this.TDOE.Readonly = false;
            this.TDOE.Size = new System.Drawing.Size(120, 24);
            this.TDOE.Step = 1D;
            this.TDOE.TabIndex = 9;
            this.TDOE.Value = 0;
            // 
            // CAS
            // 
            this.CAS.DropdownWidth = 0;
            this.CAS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CAS.Format = "{0:0.0}";
            this.CAS.Label = "TCL";
            this.CAS.Location = new System.Drawing.Point(0, 0);
            this.CAS.Margin = new System.Windows.Forms.Padding(0);
            this.CAS.Max = 3;
            this.CAS.Min = 1;
            this.CAS.MinDisplay = 2D;
            this.CAS.Name = "CAS";
            this.CAS.Readonly = true;
            this.CAS.Size = new System.Drawing.Size(120, 24);
            this.CAS.Step = 0.5D;
            this.CAS.TabIndex = 0;
            this.CAS.Value = 1;
            // 
            // TRCDR
            // 
            this.TRCDR.DropdownWidth = 0;
            this.TRCDR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRCDR.Format = "{0}";
            this.TRCDR.Label = "TRCDR";
            this.TRCDR.Location = new System.Drawing.Point(0, 24);
            this.TRCDR.Margin = new System.Windows.Forms.Padding(0);
            this.TRCDR.Max = 15;
            this.TRCDR.Min = 0;
            this.TRCDR.MinDisplay = 0D;
            this.TRCDR.Name = "TRCDR";
            this.TRCDR.Readonly = false;
            this.TRCDR.Size = new System.Drawing.Size(120, 24);
            this.TRCDR.Step = 1D;
            this.TRCDR.TabIndex = 1;
            this.TRCDR.Value = 0;
            // 
            // TRCDW
            // 
            this.TRCDW.DropdownWidth = 0;
            this.TRCDW.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRCDW.Format = "{0}";
            this.TRCDW.Label = "TRCDW";
            this.TRCDW.Location = new System.Drawing.Point(0, 48);
            this.TRCDW.Margin = new System.Windows.Forms.Padding(0);
            this.TRCDW.Max = 15;
            this.TRCDW.Min = 0;
            this.TRCDW.MinDisplay = 0D;
            this.TRCDW.Name = "TRCDW";
            this.TRCDW.Readonly = false;
            this.TRCDW.Size = new System.Drawing.Size(120, 24);
            this.TRCDW.Step = 1D;
            this.TRCDW.TabIndex = 2;
            this.TRCDW.Value = 0;
            // 
            // TRP
            // 
            this.TRP.DropdownWidth = 0;
            this.TRP.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRP.Format = "{0}";
            this.TRP.Label = "TRP";
            this.TRP.Location = new System.Drawing.Point(0, 72);
            this.TRP.Margin = new System.Windows.Forms.Padding(0);
            this.TRP.Max = 15;
            this.TRP.Min = 0;
            this.TRP.MinDisplay = 0D;
            this.TRP.Name = "TRP";
            this.TRP.Readonly = false;
            this.TRP.Size = new System.Drawing.Size(120, 24);
            this.TRP.Step = 1D;
            this.TRP.TabIndex = 3;
            this.TRP.Value = 0;
            // 
            // TRAS
            // 
            this.TRAS.DropdownWidth = 0;
            this.TRAS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRAS.Format = "{0}";
            this.TRAS.Label = "TRAS";
            this.TRAS.Location = new System.Drawing.Point(0, 96);
            this.TRAS.Margin = new System.Windows.Forms.Padding(0);
            this.TRAS.Max = 15;
            this.TRAS.Min = 0;
            this.TRAS.MinDisplay = 0D;
            this.TRAS.Name = "TRAS";
            this.TRAS.Readonly = false;
            this.TRAS.Size = new System.Drawing.Size(120, 24);
            this.TRAS.Step = 1D;
            this.TRAS.TabIndex = 4;
            this.TRAS.Value = 0;
            // 
            // TRC
            // 
            this.TRC.DropdownWidth = 0;
            this.TRC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRC.Format = "{0}";
            this.TRC.Label = "TRC";
            this.TRC.Location = new System.Drawing.Point(0, 120);
            this.TRC.Margin = new System.Windows.Forms.Padding(0);
            this.TRC.Max = 31;
            this.TRC.Min = 0;
            this.TRC.MinDisplay = 0D;
            this.TRC.Name = "TRC";
            this.TRC.Readonly = false;
            this.TRC.Size = new System.Drawing.Size(120, 24);
            this.TRC.Step = 1D;
            this.TRC.TabIndex = 5;
            this.TRC.Value = 0;
            // 
            // TRFC
            // 
            this.TRFC.DropdownWidth = 0;
            this.TRFC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TRFC.Format = "{0}";
            this.TRFC.Label = "TRFC";
            this.TRFC.Location = new System.Drawing.Point(0, 144);
            this.TRFC.Margin = new System.Windows.Forms.Padding(0);
            this.TRFC.Max = 31;
            this.TRFC.Min = 0;
            this.TRFC.MinDisplay = 0D;
            this.TRFC.Name = "TRFC";
            this.TRFC.Readonly = false;
            this.TRFC.Size = new System.Drawing.Size(120, 24);
            this.TRFC.Step = 1D;
            this.TRFC.TabIndex = 6;
            this.TRFC.Value = 0;
            // 
            // CR
            // 
            this.CR.DropdownWidth = 0;
            this.CR.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CR.Format = "{0}T";
            this.CR.Label = "CR";
            this.CR.Location = new System.Drawing.Point(0, 168);
            this.CR.Margin = new System.Windows.Forms.Padding(0);
            this.CR.Max = 1;
            this.CR.Min = 0;
            this.CR.MinDisplay = 1D;
            this.CR.Name = "CR";
            this.CR.Readonly = true;
            this.CR.Size = new System.Drawing.Size(120, 24);
            this.CR.Step = 1D;
            this.CR.TabIndex = 8;
            this.CR.Value = 0;
            // 
            // advancedTextBox1
            // 
            this.advancedTextBox1.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox1.Location = new System.Drawing.Point(73, 26);
            this.advancedTextBox1.Max = 255;
            this.advancedTextBox1.Min = 0;
            this.advancedTextBox1.Name = "advancedTextBox1";
            this.advancedTextBox1.Readonly = false;
            this.advancedTextBox1.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox1.TabIndex = 14;
            this.advancedTextBox1.Value = ((byte)(0));
            // 
            // advancedTextBox2
            // 
            this.advancedTextBox2.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox2.Location = new System.Drawing.Point(102, 26);
            this.advancedTextBox2.Max = 255;
            this.advancedTextBox2.Min = 0;
            this.advancedTextBox2.Name = "advancedTextBox2";
            this.advancedTextBox2.Readonly = false;
            this.advancedTextBox2.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox2.TabIndex = 15;
            this.advancedTextBox2.Value = ((byte)(0));
            // 
            // advancedTextBox3
            // 
            this.advancedTextBox3.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox3.Location = new System.Drawing.Point(131, 26);
            this.advancedTextBox3.Max = 255;
            this.advancedTextBox3.Min = 0;
            this.advancedTextBox3.Name = "advancedTextBox3";
            this.advancedTextBox3.Readonly = false;
            this.advancedTextBox3.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox3.TabIndex = 16;
            this.advancedTextBox3.Value = ((byte)(0));
            // 
            // advancedTextBox4
            // 
            this.advancedTextBox4.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox4.Location = new System.Drawing.Point(160, 26);
            this.advancedTextBox4.Max = 255;
            this.advancedTextBox4.Min = 0;
            this.advancedTextBox4.Name = "advancedTextBox4";
            this.advancedTextBox4.Readonly = false;
            this.advancedTextBox4.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox4.TabIndex = 17;
            this.advancedTextBox4.Value = ((byte)(0));
            // 
            // advancedTextBox5
            // 
            this.advancedTextBox5.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox5.Location = new System.Drawing.Point(189, 26);
            this.advancedTextBox5.Max = 255;
            this.advancedTextBox5.Min = 0;
            this.advancedTextBox5.Name = "advancedTextBox5";
            this.advancedTextBox5.Readonly = false;
            this.advancedTextBox5.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox5.TabIndex = 18;
            this.advancedTextBox5.Value = ((byte)(0));
            // 
            // advancedTextBox6
            // 
            this.advancedTextBox6.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox6.Location = new System.Drawing.Point(73, 75);
            this.advancedTextBox6.Max = 255;
            this.advancedTextBox6.Min = 0;
            this.advancedTextBox6.Name = "advancedTextBox6";
            this.advancedTextBox6.Readonly = false;
            this.advancedTextBox6.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox6.TabIndex = 19;
            this.advancedTextBox6.Value = ((byte)(0));
            // 
            // advancedTextBox7
            // 
            this.advancedTextBox7.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox7.Location = new System.Drawing.Point(102, 75);
            this.advancedTextBox7.Max = 255;
            this.advancedTextBox7.Min = 0;
            this.advancedTextBox7.Name = "advancedTextBox7";
            this.advancedTextBox7.Readonly = false;
            this.advancedTextBox7.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox7.TabIndex = 20;
            this.advancedTextBox7.Value = ((byte)(0));
            // 
            // advancedTextBox8
            // 
            this.advancedTextBox8.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox8.Location = new System.Drawing.Point(131, 75);
            this.advancedTextBox8.Max = 255;
            this.advancedTextBox8.Min = 0;
            this.advancedTextBox8.Name = "advancedTextBox8";
            this.advancedTextBox8.Readonly = false;
            this.advancedTextBox8.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox8.TabIndex = 21;
            this.advancedTextBox8.Value = ((byte)(0));
            // 
            // advancedTextBox9
            // 
            this.advancedTextBox9.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox9.Location = new System.Drawing.Point(160, 75);
            this.advancedTextBox9.Max = 255;
            this.advancedTextBox9.Min = 0;
            this.advancedTextBox9.Name = "advancedTextBox9";
            this.advancedTextBox9.Readonly = false;
            this.advancedTextBox9.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox9.TabIndex = 22;
            this.advancedTextBox9.Value = ((byte)(0));
            // 
            // advancedTextBox10
            // 
            this.advancedTextBox10.ForeColor = System.Drawing.Color.Transparent;
            this.advancedTextBox10.Location = new System.Drawing.Point(189, 75);
            this.advancedTextBox10.Max = 255;
            this.advancedTextBox10.Min = 0;
            this.advancedTextBox10.Name = "advancedTextBox10";
            this.advancedTextBox10.Readonly = false;
            this.advancedTextBox10.Size = new System.Drawing.Size(23, 20);
            this.advancedTextBox10.TabIndex = 23;
            this.advancedTextBox10.Value = ((byte)(0));
            // 
            // ROMSIPPreset
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.ROMSIPPreset, 2);
            this.ROMSIPPreset.DropdownWidth = 140;
            this.ROMSIPPreset.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ROMSIPPreset.Format = "{0}";
            this.ROMSIPPreset.Items = new string[] {
        "Auto"};
            this.ROMSIPPreset.Label = "ROMSIP";
            this.ROMSIPPreset.Location = new System.Drawing.Point(0, 264);
            this.ROMSIPPreset.Margin = new System.Windows.Forms.Padding(0);
            this.ROMSIPPreset.Max = 15;
            this.ROMSIPPreset.Min = 0;
            this.ROMSIPPreset.MinDisplay = 0D;
            this.ROMSIPPreset.Name = "ROMSIPPreset";
            this.ROMSIPPreset.Readonly = false;
            this.ROMSIPPreset.Size = new System.Drawing.Size(215, 24);
            this.ROMSIPPreset.Step = 1D;
            this.ROMSIPPreset.TabIndex = 8;
            this.ROMSIPPreset.Value = 0;
            // 
            // DIMM0DrvStrA
            // 
            this.DIMM0DrvStrA.DropdownWidth = 40;
            this.DIMM0DrvStrA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM0DrvStrA.Format = "{0}";
            this.DIMM0DrvStrA.Label = "DIMM0 Drive Strengths";
            this.DIMM0DrvStrA.Location = new System.Drawing.Point(0, 0);
            this.DIMM0DrvStrA.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM0DrvStrA.Max = 15;
            this.DIMM0DrvStrA.Min = 0;
            this.DIMM0DrvStrA.MinDisplay = 0D;
            this.DIMM0DrvStrA.Name = "DIMM0DrvStrA";
            this.DIMM0DrvStrA.Readonly = false;
            this.DIMM0DrvStrA.Size = new System.Drawing.Size(170, 24);
            this.DIMM0DrvStrA.Step = 1D;
            this.DIMM0DrvStrA.TabIndex = 6;
            this.DIMM0DrvStrA.Value = 0;
            // 
            // DIMM0DrvStrB
            // 
            this.DIMM0DrvStrB.DropdownWidth = 40;
            this.DIMM0DrvStrB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM0DrvStrB.Format = "{0}";
            this.DIMM0DrvStrB.Label = "";
            this.DIMM0DrvStrB.Location = new System.Drawing.Point(170, 0);
            this.DIMM0DrvStrB.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM0DrvStrB.Max = 15;
            this.DIMM0DrvStrB.Min = 0;
            this.DIMM0DrvStrB.MinDisplay = 0D;
            this.DIMM0DrvStrB.Name = "DIMM0DrvStrB";
            this.DIMM0DrvStrB.Readonly = false;
            this.DIMM0DrvStrB.Size = new System.Drawing.Size(45, 24);
            this.DIMM0DrvStrB.Step = 1D;
            this.DIMM0DrvStrB.TabIndex = 7;
            this.DIMM0DrvStrB.Value = 0;
            // 
            // DIMM0SlewRate
            // 
            this.DIMM0SlewRate.DropdownWidth = 40;
            this.DIMM0SlewRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM0SlewRate.Format = "{0}";
            this.DIMM0SlewRate.Label = "DIMM0 Slew Rate";
            this.DIMM0SlewRate.Location = new System.Drawing.Point(0, 24);
            this.DIMM0SlewRate.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM0SlewRate.Max = 15;
            this.DIMM0SlewRate.Min = 0;
            this.DIMM0SlewRate.MinDisplay = 0D;
            this.DIMM0SlewRate.Name = "DIMM0SlewRate";
            this.DIMM0SlewRate.Readonly = false;
            this.DIMM0SlewRate.Size = new System.Drawing.Size(170, 24);
            this.DIMM0SlewRate.Step = 1D;
            this.DIMM0SlewRate.TabIndex = 7;
            this.DIMM0SlewRate.Value = 0;
            // 
            // DIMM1DrvStrA
            // 
            this.DIMM1DrvStrA.DropdownWidth = 40;
            this.DIMM1DrvStrA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM1DrvStrA.Format = "{0}";
            this.DIMM1DrvStrA.Label = "DIMM1 Drive Strengths";
            this.DIMM1DrvStrA.Location = new System.Drawing.Point(0, 48);
            this.DIMM1DrvStrA.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM1DrvStrA.Max = 15;
            this.DIMM1DrvStrA.Min = 0;
            this.DIMM1DrvStrA.MinDisplay = 0D;
            this.DIMM1DrvStrA.Name = "DIMM1DrvStrA";
            this.DIMM1DrvStrA.Readonly = false;
            this.DIMM1DrvStrA.Size = new System.Drawing.Size(170, 24);
            this.DIMM1DrvStrA.Step = 1D;
            this.DIMM1DrvStrA.TabIndex = 8;
            this.DIMM1DrvStrA.Value = 0;
            // 
            // DIMM1DrvStrB
            // 
            this.DIMM1DrvStrB.DropdownWidth = 40;
            this.DIMM1DrvStrB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM1DrvStrB.Format = "{0}";
            this.DIMM1DrvStrB.Label = "";
            this.DIMM1DrvStrB.Location = new System.Drawing.Point(170, 48);
            this.DIMM1DrvStrB.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM1DrvStrB.Max = 15;
            this.DIMM1DrvStrB.Min = 0;
            this.DIMM1DrvStrB.MinDisplay = 0D;
            this.DIMM1DrvStrB.Name = "DIMM1DrvStrB";
            this.DIMM1DrvStrB.Readonly = false;
            this.DIMM1DrvStrB.Size = new System.Drawing.Size(45, 24);
            this.DIMM1DrvStrB.Step = 1D;
            this.DIMM1DrvStrB.TabIndex = 9;
            this.DIMM1DrvStrB.Value = 0;
            // 
            // DIMM1SlewRate
            // 
            this.DIMM1SlewRate.DropdownWidth = 40;
            this.DIMM1SlewRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM1SlewRate.Format = "{0}";
            this.DIMM1SlewRate.Label = "DIMM1 Slew Rate";
            this.DIMM1SlewRate.Location = new System.Drawing.Point(0, 72);
            this.DIMM1SlewRate.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM1SlewRate.Max = 15;
            this.DIMM1SlewRate.Min = 0;
            this.DIMM1SlewRate.MinDisplay = 0D;
            this.DIMM1SlewRate.Name = "DIMM1SlewRate";
            this.DIMM1SlewRate.Readonly = false;
            this.DIMM1SlewRate.Size = new System.Drawing.Size(170, 24);
            this.DIMM1SlewRate.Step = 1D;
            this.DIMM1SlewRate.TabIndex = 10;
            this.DIMM1SlewRate.Value = 0;
            // 
            // DIMM2DrvStrA
            // 
            this.DIMM2DrvStrA.DropdownWidth = 40;
            this.DIMM2DrvStrA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM2DrvStrA.Format = "{0}";
            this.DIMM2DrvStrA.Label = "DIMM2 Drive Strengths";
            this.DIMM2DrvStrA.Location = new System.Drawing.Point(0, 96);
            this.DIMM2DrvStrA.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM2DrvStrA.Max = 15;
            this.DIMM2DrvStrA.Min = 0;
            this.DIMM2DrvStrA.MinDisplay = 0D;
            this.DIMM2DrvStrA.Name = "DIMM2DrvStrA";
            this.DIMM2DrvStrA.Readonly = false;
            this.DIMM2DrvStrA.Size = new System.Drawing.Size(170, 24);
            this.DIMM2DrvStrA.Step = 1D;
            this.DIMM2DrvStrA.TabIndex = 11;
            this.DIMM2DrvStrA.Value = 0;
            // 
            // DIMM2DrvStrB
            // 
            this.DIMM2DrvStrB.DropdownWidth = 40;
            this.DIMM2DrvStrB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM2DrvStrB.Format = "{0}";
            this.DIMM2DrvStrB.Label = "";
            this.DIMM2DrvStrB.Location = new System.Drawing.Point(170, 96);
            this.DIMM2DrvStrB.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM2DrvStrB.Max = 15;
            this.DIMM2DrvStrB.Min = 0;
            this.DIMM2DrvStrB.MinDisplay = 0D;
            this.DIMM2DrvStrB.Name = "DIMM2DrvStrB";
            this.DIMM2DrvStrB.Readonly = false;
            this.DIMM2DrvStrB.Size = new System.Drawing.Size(45, 24);
            this.DIMM2DrvStrB.Step = 1D;
            this.DIMM2DrvStrB.TabIndex = 12;
            this.DIMM2DrvStrB.Value = 0;
            // 
            // DIMM2SlewRate
            // 
            this.DIMM2SlewRate.DropdownWidth = 40;
            this.DIMM2SlewRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DIMM2SlewRate.Format = "{0}";
            this.DIMM2SlewRate.Label = "DIMM2 Slew Rate";
            this.DIMM2SlewRate.Location = new System.Drawing.Point(0, 120);
            this.DIMM2SlewRate.Margin = new System.Windows.Forms.Padding(0);
            this.DIMM2SlewRate.Max = 15;
            this.DIMM2SlewRate.Min = 0;
            this.DIMM2SlewRate.MinDisplay = 0D;
            this.DIMM2SlewRate.Name = "DIMM2SlewRate";
            this.DIMM2SlewRate.Readonly = false;
            this.DIMM2SlewRate.Size = new System.Drawing.Size(170, 24);
            this.DIMM2SlewRate.Step = 1D;
            this.DIMM2SlewRate.TabIndex = 13;
            this.DIMM2SlewRate.Value = 0;
            // 
            // AutoPrecharge
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.AutoPrecharge, 2);
            this.AutoPrecharge.DropdownWidth = 85;
            this.AutoPrecharge.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AutoPrecharge.Format = "{0}";
            this.AutoPrecharge.Items = new string[] {
        "Disabled",
        "Enabled"};
            this.AutoPrecharge.Label = "Auto Precharge";
            this.AutoPrecharge.Location = new System.Drawing.Point(0, 144);
            this.AutoPrecharge.Margin = new System.Windows.Forms.Padding(0);
            this.AutoPrecharge.Max = 1;
            this.AutoPrecharge.Min = 0;
            this.AutoPrecharge.MinDisplay = 0D;
            this.AutoPrecharge.Name = "AutoPrecharge";
            this.AutoPrecharge.Readonly = false;
            this.AutoPrecharge.Size = new System.Drawing.Size(215, 24);
            this.AutoPrecharge.Step = 1D;
            this.AutoPrecharge.TabIndex = 6;
            this.AutoPrecharge.Value = 0;
            // 
            // SuperBypass
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.SuperBypass, 2);
            this.SuperBypass.DropdownWidth = 85;
            this.SuperBypass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.SuperBypass.Format = "{0}";
            this.SuperBypass.Items = new string[] {
        "Disabled",
        "Enabled"};
            this.SuperBypass.Label = "Super Bypass";
            this.SuperBypass.Location = new System.Drawing.Point(0, 168);
            this.SuperBypass.Margin = new System.Windows.Forms.Padding(0);
            this.SuperBypass.Max = 1;
            this.SuperBypass.Min = 0;
            this.SuperBypass.MinDisplay = 0D;
            this.SuperBypass.Name = "SuperBypass";
            this.SuperBypass.Readonly = false;
            this.SuperBypass.Size = new System.Drawing.Size(215, 24);
            this.SuperBypass.Step = 1D;
            this.SuperBypass.TabIndex = 7;
            this.SuperBypass.Value = 0;
            // 
            // DataScavengedRate
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.DataScavengedRate, 2);
            this.DataScavengedRate.DropdownWidth = 85;
            this.DataScavengedRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DataScavengedRate.Format = "{0}";
            this.DataScavengedRate.Items = new string[] {
        "Fast",
        "Normal"};
            this.DataScavengedRate.Label = "Data Scavenged Rate";
            this.DataScavengedRate.Location = new System.Drawing.Point(0, 192);
            this.DataScavengedRate.Margin = new System.Windows.Forms.Padding(0);
            this.DataScavengedRate.Max = 1;
            this.DataScavengedRate.Min = 0;
            this.DataScavengedRate.MinDisplay = 0D;
            this.DataScavengedRate.Name = "DataScavengedRate";
            this.DataScavengedRate.Readonly = false;
            this.DataScavengedRate.Size = new System.Drawing.Size(215, 24);
            this.DataScavengedRate.Step = 1D;
            this.DataScavengedRate.TabIndex = 7;
            this.DataScavengedRate.Value = 0;
            // 
            // DriveStrengthMode
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.DriveStrengthMode, 2);
            this.DriveStrengthMode.DropdownWidth = 85;
            this.DriveStrengthMode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DriveStrengthMode.Format = "{0}";
            this.DriveStrengthMode.Items = new string[] {
        "Normal",
        "Weak"};
            this.DriveStrengthMode.Label = "Drive Strength Mode";
            this.DriveStrengthMode.Location = new System.Drawing.Point(0, 216);
            this.DriveStrengthMode.Margin = new System.Windows.Forms.Padding(0);
            this.DriveStrengthMode.Max = 1;
            this.DriveStrengthMode.Min = 0;
            this.DriveStrengthMode.MinDisplay = 0D;
            this.DriveStrengthMode.Name = "DriveStrengthMode";
            this.DriveStrengthMode.Readonly = false;
            this.DriveStrengthMode.Size = new System.Drawing.Size(215, 24);
            this.DriveStrengthMode.Step = 1D;
            this.DriveStrengthMode.TabIndex = 7;
            this.DriveStrengthMode.Value = 0;
            // 
            // BurstMode
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.BurstMode, 2);
            this.BurstMode.DropdownWidth = 85;
            this.BurstMode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BurstMode.Format = "{0}";
            this.BurstMode.Items = new string[] {
        "Sequential",
        "Interleave"};
            this.BurstMode.Label = "Burst Mode";
            this.BurstMode.Location = new System.Drawing.Point(0, 240);
            this.BurstMode.Margin = new System.Windows.Forms.Padding(0);
            this.BurstMode.Max = 1;
            this.BurstMode.Min = 0;
            this.BurstMode.MinDisplay = 0D;
            this.BurstMode.Name = "BurstMode";
            this.BurstMode.Readonly = false;
            this.BurstMode.Size = new System.Drawing.Size(215, 24);
            this.BurstMode.Step = 1D;
            this.BurstMode.TabIndex = 8;
            this.BurstMode.Value = 0;
            // 
            // CPUDisconnect
            // 
            this.CPUDisconnect.DropdownWidth = 85;
            this.CPUDisconnect.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CPUDisconnect.Format = "{0}";
            this.CPUDisconnect.Items = new string[] {
        "Disabled",
        "Enabled"};
            this.CPUDisconnect.Label = "CPU Disconnect";
            this.CPUDisconnect.Location = new System.Drawing.Point(10, 10);
            this.CPUDisconnect.Margin = new System.Windows.Forms.Padding(0);
            this.CPUDisconnect.Max = 1;
            this.CPUDisconnect.Min = 0;
            this.CPUDisconnect.MinDisplay = 0D;
            this.CPUDisconnect.Name = "CPUDisconnect";
            this.CPUDisconnect.Readonly = false;
            this.CPUDisconnect.Size = new System.Drawing.Size(237, 24);
            this.CPUDisconnect.Step = 1D;
            this.CPUDisconnect.TabIndex = 8;
            this.CPUDisconnect.Value = 0;
            // 
            // AGPFastWrite
            // 
            this.AGPFastWrite.DropdownWidth = 85;
            this.AGPFastWrite.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AGPFastWrite.Format = "{0}";
            this.AGPFastWrite.Items = new string[] {
        "Disabled",
        "Enabled"};
            this.AGPFastWrite.Label = "AGP Fast Write";
            this.AGPFastWrite.Location = new System.Drawing.Point(10, 34);
            this.AGPFastWrite.Margin = new System.Windows.Forms.Padding(0);
            this.AGPFastWrite.Max = 1;
            this.AGPFastWrite.Min = 0;
            this.AGPFastWrite.MinDisplay = 0D;
            this.AGPFastWrite.Name = "AGPFastWrite";
            this.AGPFastWrite.Readonly = false;
            this.AGPFastWrite.Size = new System.Drawing.Size(237, 24);
            this.AGPFastWrite.Step = 1D;
            this.AGPFastWrite.TabIndex = 7;
            this.AGPFastWrite.Value = 0;
            // 
            // AGPSBA
            // 
            this.AGPSBA.DropdownWidth = 85;
            this.AGPSBA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AGPSBA.Format = "{0}";
            this.AGPSBA.Items = new string[] {
        "Disabled",
        "Enabled"};
            this.AGPSBA.Label = "AGP Sideband Addressing";
            this.AGPSBA.Location = new System.Drawing.Point(10, 58);
            this.AGPSBA.Margin = new System.Windows.Forms.Padding(0);
            this.AGPSBA.Max = 3;
            this.AGPSBA.Min = 0;
            this.AGPSBA.MinDisplay = 0D;
            this.AGPSBA.Name = "AGPSBA";
            this.AGPSBA.Readonly = false;
            this.AGPSBA.Size = new System.Drawing.Size(237, 24);
            this.AGPSBA.Step = 3D;
            this.AGPSBA.TabIndex = 8;
            this.AGPSBA.Value = 0;
            // 
            // AGPControllerLatency
            // 
            this.AGPControllerLatency.DropdownWidth = 85;
            this.AGPControllerLatency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AGPControllerLatency.Format = "{0:000} clocks";
            this.AGPControllerLatency.Label = "AGP Controller Latency";
            this.AGPControllerLatency.Location = new System.Drawing.Point(10, 82);
            this.AGPControllerLatency.Margin = new System.Windows.Forms.Padding(0);
            this.AGPControllerLatency.Max = 256;
            this.AGPControllerLatency.Min = 16;
            this.AGPControllerLatency.MinDisplay = 16D;
            this.AGPControllerLatency.Name = "AGPControllerLatency";
            this.AGPControllerLatency.Readonly = false;
            this.AGPControllerLatency.Size = new System.Drawing.Size(237, 24);
            this.AGPControllerLatency.Step = 16D;
            this.AGPControllerLatency.TabIndex = 7;
            this.AGPControllerLatency.Value = -1;
            // 
            // AGPBusLatency
            // 
            this.AGPBusLatency.DropdownWidth = 85;
            this.AGPBusLatency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AGPBusLatency.Format = "{0:000} clocks";
            this.AGPBusLatency.Label = "AGP Bus Latency";
            this.AGPBusLatency.Location = new System.Drawing.Point(10, 106);
            this.AGPBusLatency.Margin = new System.Windows.Forms.Padding(0);
            this.AGPBusLatency.Max = 256;
            this.AGPBusLatency.Min = 16;
            this.AGPBusLatency.MinDisplay = 16D;
            this.AGPBusLatency.Name = "AGPBusLatency";
            this.AGPBusLatency.Readonly = false;
            this.AGPBusLatency.Size = new System.Drawing.Size(237, 24);
            this.AGPBusLatency.Step = 16D;
            this.AGPBusLatency.TabIndex = 7;
            this.AGPBusLatency.Value = -1;
            // 
            // PCILatency
            // 
            this.PCILatency.DropdownWidth = 85;
            this.PCILatency.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PCILatency.Format = "{0:000} clocks";
            this.PCILatency.Label = "PCI Latency Timer";
            this.PCILatency.Location = new System.Drawing.Point(10, 130);
            this.PCILatency.Margin = new System.Windows.Forms.Padding(0);
            this.PCILatency.Max = 256;
            this.PCILatency.Min = 16;
            this.PCILatency.MinDisplay = 16D;
            this.PCILatency.Name = "PCILatency";
            this.PCILatency.Readonly = false;
            this.PCILatency.Size = new System.Drawing.Size(237, 24);
            this.PCILatency.Step = 16D;
            this.PCILatency.TabIndex = 7;
            this.PCILatency.Value = -1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(389, 523);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.MainMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.trayIconMenu.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.AdvancedGroup.ResumeLayout(false);
            this.AdvancedGroup.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabControlSettings.ResumeLayout(false);
            this.DRAMTab.ResumeLayout(false);
            this.DRAMTab.PerformLayout();
            this.ChipsetTab.ResumeLayout(false);
            this.ChipsetTab.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Button buttonRefresh;
        private nForce2XTLibrary.TimingItem CAS;
        private nForce2XTLibrary.TimingItem TRCDR;
        private nForce2XTLibrary.TimingItem TRCDW;
        private nForce2XTLibrary.TimingItem TRP;
        private nForce2XTLibrary.TimingItem TRAS;
        private nForce2XTLibrary.TimingItem TRC;
        private nForce2XTLibrary.TimingItem TRFC;
        private nForce2XTLibrary.TrefTimingItem TREF;
        private nForce2XTLibrary.TimingItem CR;
        private nForce2XTLibrary.TimingItem TDOE;
        private nForce2XTLibrary.TimingItem TRRD;
        private nForce2XTLibrary.TimingItem TWTP;
        private nForce2XTLibrary.TimingItem TWTR;
        private nForce2XTLibrary.TimingItem TREXT;
        private nForce2XTLibrary.TimingItem TRTP;
        private nForce2XTLibrary.TimingItem TRTW;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconMenu;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemApp;
        private System.Windows.Forms.ToolStripMenuItem trayMenuItemExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox AdvancedGroup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private nForce2XTLibrary.TimingItem DIMM0DrvStrA;
        private nForce2XTLibrary.TimingItem DIMM0SlewRate;
        private nForce2XTLibrary.TimingItem DIMM0DrvStrB;
        private nForce2XTLibrary.TimingItem DIMM1SlewRate;
        private nForce2XTLibrary.TimingItem DIMM1DrvStrB;
        private nForce2XTLibrary.TimingItem DIMM1DrvStrA;
        private nForce2XTLibrary.TimingItem DIMM2SlewRate;
        private nForce2XTLibrary.TimingItem DIMM2DrvStrB;
        private nForce2XTLibrary.TimingItem DIMM2DrvStrA;
        private nForce2XTLibrary.BooleanTimingItem AutoPrecharge;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private nForce2XTLibrary.LatencyTimingItem AGPControllerLatency;
        private nForce2XTLibrary.LatencyTimingItem PCILatency;
        private nForce2XTLibrary.LatencyTimingItem AGPBusLatency;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private nForce2XTLibrary.BooleanTimingItem BurstMode;
        private nForce2XTLibrary.BooleanTimingItem DriveStrengthMode;
        private nForce2XTLibrary.BooleanTimingItem DataScavengedRate;
        private nForce2XTLibrary.BooleanTimingItem SuperBypass;
        private nForce2XTLibrary.BooleanTimingItem AGPFastWrite;
        private nForce2XTLibrary.BooleanTimingItem CPUDisconnect;
        private nForce2XTLibrary.BooleanTimingItem AGPSBA;
        private nForce2XTLibrary.BooleanTimingItem ROMSIPPreset;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenuItem;
        private System.Windows.Forms.Label label10;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox2;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox3;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox4;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox5;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox6;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox7;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox8;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox9;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox10;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage DRAMTab;
        private System.Windows.Forms.TabPage ChipsetTab;
        private System.Windows.Forms.Label label1;
        private nForce2XTLibrary.AdvancedTextBox advancedTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    }
}

