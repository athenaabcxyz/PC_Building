namespace PC_Building
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Processor", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Motherboard", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CPU Cooler", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Case", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Graphic Card", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("RAM", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Storage", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Case Cooler", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Power Supply", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("970 EVO", "970 EVO.jpg");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_Illu = new System.Windows.Forms.PictureBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Build = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.imageList_Group = new System.Windows.Forms.ImageList(this.components);
            this.imageList_MainListView = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.richTextBox_Detail = new System.Windows.Forms.RichTextBox();
            this.button_openAmazon = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Illu
            // 
            this.pictureBox_Illu.Location = new System.Drawing.Point(717, 83);
            this.pictureBox_Illu.Name = "pictureBox_Illu";
            this.pictureBox_Illu.Size = new System.Drawing.Size(178, 176);
            this.pictureBox_Illu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Illu.TabIndex = 1;
            this.pictureBox_Illu.TabStop = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Search.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Search.Location = new System.Drawing.Point(12, 90);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(185, 28);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to PC Builder";
            // 
            // button_Build
            // 
            this.button_Build.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Build.Location = new System.Drawing.Point(799, 12);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(245, 52);
            this.button_Build.TabIndex = 10;
            this.button_Build.Text = "Start building you own PC";
            this.button_Build.UseVisualStyleBackColor = true;
            this.button_Build.Click += new System.EventHandler(this.button_Build_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search by model name:";
            // 
            // listView_Main
            // 
            this.listView_Main.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Main.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Main.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_Main.GroupImageList = this.imageList_Group;
            listViewGroup1.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup1.Header = "Processor";
            listViewGroup1.Name = "listViewGroup_Processor";
            listViewGroup2.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup2.Header = "Motherboard";
            listViewGroup2.Name = "listViewGroup_Motherboard";
            listViewGroup3.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup3.Header = "CPU Cooler";
            listViewGroup3.Name = "listViewGroup_CPUCooler";
            listViewGroup4.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup4.Header = "Case";
            listViewGroup4.Name = "listViewGroup_Case";
            listViewGroup5.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup5.Header = "Graphic Card";
            listViewGroup5.Name = "listViewGroup_GPU";
            listViewGroup6.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup6.Header = "RAM";
            listViewGroup6.Name = "listViewGroup_RAM";
            listViewGroup7.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup7.Header = "Storage";
            listViewGroup7.Name = "listViewGroup_Disk";
            listViewGroup8.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup8.Header = "Case Cooler";
            listViewGroup8.Name = "listViewGroup_CaseCooler";
            listViewGroup9.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup9.Header = "Power Supply";
            listViewGroup9.Name = "listViewGroup_PSU";
            this.listView_Main.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.listView_Main.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Main.HideSelection = true;
            listViewItem1.Group = listViewGroup7;
            this.listView_Main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_Main.LargeImageList = this.imageList_MainListView;
            this.listView_Main.Location = new System.Drawing.Point(12, 135);
            this.listView_Main.MultiSelect = false;
            this.listView_Main.Name = "listView_Main";
            this.listView_Main.Size = new System.Drawing.Size(522, 495);
            this.listView_Main.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView_Main.TabIndex = 13;
            this.listView_Main.TileSize = new System.Drawing.Size(500, 30);
            this.listView_Main.UseCompatibleStateImageBehavior = false;
            this.listView_Main.View = System.Windows.Forms.View.Tile;
            this.listView_Main.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Main_ItemSelectionChanged);
            // 
            // imageList_Group
            // 
            this.imageList_Group.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_Group.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Group.ImageStream")));
            this.imageList_Group.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Group.Images.SetKeyName(0, "Case Cooler.jpg");
            this.imageList_Group.Images.SetKeyName(1, "Case.jpg");
            this.imageList_Group.Images.SetKeyName(2, "CPU Cooler.jpg");
            this.imageList_Group.Images.SetKeyName(3, "GPU.jpg");
            this.imageList_Group.Images.SetKeyName(4, "Motherboard.jpg");
            this.imageList_Group.Images.SetKeyName(5, "PSU.jpg");
            this.imageList_Group.Images.SetKeyName(6, "RAM.jpg");
            this.imageList_Group.Images.SetKeyName(7, "Storage.jpg");
            this.imageList_Group.Images.SetKeyName(8, "CPU.jpg");
            // 
            // imageList_MainListView
            // 
            this.imageList_MainListView.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList_MainListView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_MainListView.ImageStream")));
            this.imageList_MainListView.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_MainListView.Images.SetKeyName(0, "RM850.jpg");
            this.imageList_MainListView.Images.SetKeyName(1, "RM750.jpg");
            this.imageList_MainListView.Images.SetKeyName(2, "MasterFan MF120R.jpg");
            this.imageList_MainListView.Images.SetKeyName(3, "AER RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(4, "BarraCuda.jpg");
            this.imageList_MainListView.Images.SetKeyName(5, "970 EVO.jpg");
            this.imageList_MainListView.Images.SetKeyName(6, "Trident Z5 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(7, "Fury Renegade RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(8, "TUF Gaming GeForce RTX 3080 Ti OC Edition.jpg");
            this.imageList_MainListView.Images.SetKeyName(9, "GeForce RTX 3080 Ti Gaming OC 12G.jpg");
            this.imageList_MainListView.Images.SetKeyName(10, "H510B-B1.jpg");
            this.imageList_MainListView.Images.SetKeyName(11, "H510B-W1.jpg");
            this.imageList_MainListView.Images.SetKeyName(12, "Hyper 212 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(13, "Hyper 212 EVO.jpg");
            this.imageList_MainListView.Images.SetKeyName(14, "TRX40 Aorus Pro WiFi.jpg");
            this.imageList_MainListView.Images.SetKeyName(15, "TRX40 CREATOR.jpg");
            this.imageList_MainListView.Images.SetKeyName(16, "Ryzen 9 7950X.jpg");
            this.imageList_MainListView.Images.SetKeyName(17, "Ryzen Threadripper 3990X.jpg");
            this.imageList_MainListView.Images.SetKeyName(18, "RM850.jpg");
            this.imageList_MainListView.Images.SetKeyName(19, "RM750.jpg");
            this.imageList_MainListView.Images.SetKeyName(20, "MasterFan MF120R.jpg");
            this.imageList_MainListView.Images.SetKeyName(21, "AER RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(22, "BarraCuda.jpg");
            this.imageList_MainListView.Images.SetKeyName(23, "970 EVO.jpg");
            this.imageList_MainListView.Images.SetKeyName(24, "Trident Z5 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(25, "Fury Renegade RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(26, "TUF Gaming GeForce RTX 3080 Ti OC Edition.jpg");
            this.imageList_MainListView.Images.SetKeyName(27, "GeForce RTX 3080 Ti Gaming OC 12G.jpg");
            this.imageList_MainListView.Images.SetKeyName(28, "H510B-B1.jpg");
            this.imageList_MainListView.Images.SetKeyName(29, "H510B-W1.jpg");
            this.imageList_MainListView.Images.SetKeyName(30, "Hyper 212 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(31, "Hyper 212 EVO.jpg");
            this.imageList_MainListView.Images.SetKeyName(32, "TRX40 Aorus Pro WiFi.jpg");
            this.imageList_MainListView.Images.SetKeyName(33, "TRX40 CREATOR.jpg");
            this.imageList_MainListView.Images.SetKeyName(34, "Ryzen 9 7950X.jpg");
            this.imageList_MainListView.Images.SetKeyName(35, "Ryzen Threadripper 3990X.jpg");
            this.imageList_MainListView.Images.SetKeyName(36, "i5-13600K.jpg");
            this.imageList_MainListView.Images.SetKeyName(37, "i7-13700KF.jpg");
            this.imageList_MainListView.Images.SetKeyName(38, "i9-12900K.jpg");
            this.imageList_MainListView.Images.SetKeyName(39, "i9-13900K.jpg");
            this.imageList_MainListView.Images.SetKeyName(40, "i9-13900KF.jpg");
            this.imageList_MainListView.Images.SetKeyName(41, "Ryzen 9 3950X.jpg");
            this.imageList_MainListView.Images.SetKeyName(42, "Ryzen 9 5950X.jpg");
            this.imageList_MainListView.Images.SetKeyName(43, "Ryzen 9 7900X.jpg");
            this.imageList_MainListView.Images.SetKeyName(44, "Ryzen Threadripper 3970X.jpg");
            this.imageList_MainListView.Images.SetKeyName(45, "4000D Airflow.jpg");
            this.imageList_MainListView.Images.SetKeyName(46, "CARBIDE SPEC-05.jpg");
            this.imageList_MainListView.Images.SetKeyName(47, "Carbide SPEC-Omega.jpg");
            this.imageList_MainListView.Images.SetKeyName(48, "CC-9011205-WW.jpg");
            this.imageList_MainListView.Images.SetKeyName(49, "H510B.jpg");
            this.imageList_MainListView.Images.SetKeyName(50, "H510i.jpg");
            this.imageList_MainListView.Images.SetKeyName(51, "MasterBox Q500L.jpg");
            this.imageList_MainListView.Images.SetKeyName(52, "MasterBox TD500.jpg");
            this.imageList_MainListView.Images.SetKeyName(53, "Q300L.jpg");
            this.imageList_MainListView.Images.SetKeyName(54, "ACFAN00118A.jpg");
            this.imageList_MainListView.Images.SetKeyName(55, "ACFAN00170A.jpg");
            this.imageList_MainListView.Images.SetKeyName(56, "CO-9050015-BLED.jpg");
            this.imageList_MainListView.Images.SetKeyName(57, "CO-9050015-RLED.jpg");
            this.imageList_MainListView.Images.SetKeyName(58, "HD140 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(59, "P12 PST RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(60, "P12 PST.jpg");
            this.imageList_MainListView.Images.SetKeyName(61, "P12 PWM.jpg");
            this.imageList_MainListView.Images.SetKeyName(62, "P12 Silent.jpg");
            this.imageList_MainListView.Images.SetKeyName(63, "SP120 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(64, "Hyper 212 Black Edition.jpg");
            this.imageList_MainListView.Images.SetKeyName(65, "Hyper H412R.jpg");
            this.imageList_MainListView.Images.SetKeyName(66, "Hyper T2.jpg");
            this.imageList_MainListView.Images.SetKeyName(67, "Kraken M22.jpg");
            this.imageList_MainListView.Images.SetKeyName(68, "Kraken X53 RGB 240mm.jpg");
            this.imageList_MainListView.Images.SetKeyName(69, "Kraken X53 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(70, "Kraken X53.jpg");
            this.imageList_MainListView.Images.SetKeyName(71, "Kraken X63 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(72, "Kraken Z73 RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(73, "Kraken Z73.jpg");
            this.imageList_MainListView.Images.SetKeyName(74, "Gaming GeForce RTX 4090 Trinity OC.jpg");
            this.imageList_MainListView.Images.SetKeyName(75, "GeForce RTX 3090 Ti AMP Extreme Holo.jpg");
            this.imageList_MainListView.Images.SetKeyName(76, "GeForce RTX 3090 Ti FTW3 Ultra Gaming.jpg");
            this.imageList_MainListView.Images.SetKeyName(77, "GeForce RTX 4090 Founders Edition.jpg");
            this.imageList_MainListView.Images.SetKeyName(78, "GeForce RTX 4090 SUPRIM LIQUID X 24G.jpg");
            this.imageList_MainListView.Images.SetKeyName(79, "GV-N4090WF3-24GD.jpg");
            this.imageList_MainListView.Images.SetKeyName(80, "RTX 3080 Ti FTW3 Ultra.jpg");
            this.imageList_MainListView.Images.SetKeyName(81, "RTX 3080 Ti Ventus 3X 12G OC.jpg");
            this.imageList_MainListView.Images.SetKeyName(82, "RTX 3080 Ti XC3 ULTRA.jpg");
            this.imageList_MainListView.Images.SetKeyName(83, "RTX 4090 Gaming Trio 24G.jpg");
            this.imageList_MainListView.Images.SetKeyName(84, "ROG CROSSHAIR VIII HERO (WI-FI).jpg");
            this.imageList_MainListView.Images.SetKeyName(85, "ROG ZENITH II EXTREME ALPHA.jpg");
            this.imageList_MainListView.Images.SetKeyName(86, "TUF GAMING X570-PLUS (WI-FI).jpg");
            this.imageList_MainListView.Images.SetKeyName(87, "TRX40 AORUS XTREME.jpg");
            this.imageList_MainListView.Images.SetKeyName(88, "TRX40 DESIGNARE.jpg");
            this.imageList_MainListView.Images.SetKeyName(89, "TRX40P.jpg");
            this.imageList_MainListView.Images.SetKeyName(90, "X570 AORUS ELITE.jpg");
            this.imageList_MainListView.Images.SetKeyName(91, "X570 I AORUS PRO WIFI.jpg");
            this.imageList_MainListView.Images.SetKeyName(92, "X570 PRO WIFI.jpg");
            this.imageList_MainListView.Images.SetKeyName(93, "X570S AORUS ELITE AX.jpg");
            this.imageList_MainListView.Images.SetKeyName(94, "220-G6-0850-X1.jpg");
            this.imageList_MainListView.Images.SetKeyName(95, "PS-SPD-0430NPCWUS-W.jpg");
            this.imageList_MainListView.Images.SetKeyName(96, "PS-SPD-0500NPCWUS-W.jpg");
            this.imageList_MainListView.Images.SetKeyName(97, "SMART 600.jpg");
            this.imageList_MainListView.Images.SetKeyName(98, "SPD-0700NP.jpg");
            this.imageList_MainListView.Images.SetKeyName(99, "SuperNOVA 750 G6.jpg");
            this.imageList_MainListView.Images.SetKeyName(100, "SuperNOVA 1000 G6.jpg");
            this.imageList_MainListView.Images.SetKeyName(101, "SuperNOVA.jpg");
            this.imageList_MainListView.Images.SetKeyName(102, "Toughpower GX1.jpg");
            this.imageList_MainListView.Images.SetKeyName(103, "Toughpower PF1.jpg");
            this.imageList_MainListView.Images.SetKeyName(104, "AX5U6000C4016G-DCLARBK.jpg");
            this.imageList_MainListView.Images.SetKeyName(105, "CMH32GX5M2D6000C36.jpg");
            this.imageList_MainListView.Images.SetKeyName(106, "CMK32GX5M2B5600C36.jpg");
            this.imageList_MainListView.Images.SetKeyName(107, "DOMINATOR PLATINUM.jpg");
            this.imageList_MainListView.Images.SetKeyName(108, "FF3D532G6000HC38ADC0.jpg");
            this.imageList_MainListView.Images.SetKeyName(109, "KF556C40BBAK2-64.jpg");
            this.imageList_MainListView.Images.SetKeyName(110, "RipJaws S5.jpg");
            this.imageList_MainListView.Images.SetKeyName(111, "Trident Z5.jpg");
            this.imageList_MainListView.Images.SetKeyName(112, "Viper Venom RGB.jpg");
            this.imageList_MainListView.Images.SetKeyName(113, "XLR8.jpg");
            this.imageList_MainListView.Images.SetKeyName(114, "A400.jpg");
            this.imageList_MainListView.Images.SetKeyName(115, "Blue 500.jpg");
            this.imageList_MainListView.Images.SetKeyName(116, "Blue SN 550.jpg");
            this.imageList_MainListView.Images.SetKeyName(117, "Blue.jpg");
            this.imageList_MainListView.Images.SetKeyName(118, "Caviar Blue.jpg");
            this.imageList_MainListView.Images.SetKeyName(119, "EVO 500.jpg");
            this.imageList_MainListView.Images.SetKeyName(120, "GX2.jpg");
            this.imageList_MainListView.Images.SetKeyName(121, "MX 500.jpg");
            this.imageList_MainListView.Images.SetKeyName(122, "P1.jpg");
            this.imageList_MainListView.Images.SetKeyName(123, "SN 750.jpg");
            this.imageList_MainListView.Images.SetKeyName(124, "H510 Elite.jpg");
            this.imageList_MainListView.Images.SetKeyName(125, "Ryzen 7 7700X.jpg");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(231, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category:";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Processor",
            "Motherboard",
            "CPU Cooler",
            "Case",
            "Graphic Card",
            "RAM",
            "Storage",
            "Case Cooler",
            "Power Supply",
            "All"});
            this.comboBox_Category.Location = new System.Drawing.Point(231, 90);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(152, 29);
            this.comboBox_Category.TabIndex = 7;
            this.comboBox_Category.TextChanged += new System.EventHandler(this.comboBox_Category_TextChanged);
            // 
            // richTextBox_Detail
            // 
            this.richTextBox_Detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Detail.Font = new System.Drawing.Font("Bahnschrift", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Detail.Location = new System.Drawing.Point(615, 280);
            this.richTextBox_Detail.Name = "richTextBox_Detail";
            this.richTextBox_Detail.Size = new System.Drawing.Size(382, 233);
            this.richTextBox_Detail.TabIndex = 15;
            this.richTextBox_Detail.Text = "";
            // 
            // button_openAmazon
            // 
            this.button_openAmazon.BackColor = System.Drawing.Color.Transparent;
            this.button_openAmazon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_openAmazon.BackgroundImage")));
            this.button_openAmazon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_openAmazon.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_openAmazon.ForeColor = System.Drawing.SystemColors.Window;
            this.button_openAmazon.Location = new System.Drawing.Point(733, 540);
            this.button_openAmazon.Name = "button_openAmazon";
            this.button_openAmazon.Size = new System.Drawing.Size(148, 49);
            this.button_openAmazon.TabIndex = 16;
            this.toolTip.SetToolTip(this.button_openAmazon, "View on Amazon");
            this.button_openAmazon.UseVisualStyleBackColor = false;
            this.button_openAmazon.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1056, 642);
            this.Controls.Add(this.button_openAmazon);
            this.Controls.Add(this.richTextBox_Detail);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Build);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.pictureBox_Illu);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PC Builder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox_Illu;
        private TextBox textBox_Search;
        private Label label2;
        private Button button_Build;
        private Label label3;
        private ListView listView_Main;
        private ImageList imageList_MainListView;
        private ImageList imageList_Group;
        private Label label4;
        private ComboBox comboBox_Category;
        private RichTextBox richTextBox_Detail;
        private Button button_openAmazon;
        private ToolTip toolTip;
    }
}