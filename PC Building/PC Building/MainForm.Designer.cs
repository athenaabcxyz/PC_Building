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
            components = new System.ComponentModel.Container();
            ListViewGroup listViewGroup10 = new ListViewGroup("Processor", HorizontalAlignment.Left);
            ListViewGroup listViewGroup11 = new ListViewGroup("Motherboard", HorizontalAlignment.Left);
            ListViewGroup listViewGroup12 = new ListViewGroup("CPU Cooler", HorizontalAlignment.Left);
            ListViewGroup listViewGroup13 = new ListViewGroup("Case", HorizontalAlignment.Left);
            ListViewGroup listViewGroup14 = new ListViewGroup("Graphic Card", HorizontalAlignment.Left);
            ListViewGroup listViewGroup15 = new ListViewGroup("RAM", HorizontalAlignment.Left);
            ListViewGroup listViewGroup16 = new ListViewGroup("Storage", HorizontalAlignment.Left);
            ListViewGroup listViewGroup17 = new ListViewGroup("Case Cooler", HorizontalAlignment.Left);
            ListViewGroup listViewGroup18 = new ListViewGroup("Power Supply", HorizontalAlignment.Left);
            ListViewItem listViewItem3 = new ListViewItem("970 EVO", "970 EVO.jpg");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ListViewItem listViewItem1 = new ListViewItem("Bài 1");
            pictureBox_Illu = new PictureBox();
            textBox_Search = new TextBox();
            label2 = new Label();
            button_Build = new Button();
            label3 = new Label();
            listView_Main = new ListView();
            imageList_Group = new ImageList(components);
            imageList_MainListView = new ImageList(components);
            label4 = new Label();
            comboBox_Category = new ComboBox();
            richTextBox_Detail = new RichTextBox();
            button_openAmazon = new Button();
            toolTip = new ToolTip(components);
            button1 = new Button();
            button_rebuild = new Button();
            button_save = new Button();
            button_like = new Button();
            button_reload = new Button();
            button_edit = new Button();
            button_login = new Button();
            tabControl_main = new TabControl();
            tabPage_products = new TabPage();
            tabPage_forum = new TabPage();
            tabControl1 = new TabControl();
            tabPage_decription = new TabPage();
            richTextBox_decription = new RichTextBox();
            tabPage_comment = new TabPage();
            richTextBox_comments = new RichTextBox();
            label_creator = new Label();
            label_buildName = new Label();
            label7 = new Label();
            label5 = new Label();
            button_send = new Button();
            textBox_comments = new TextBox();
            textBox_sender = new TextBox();
            label_cpuCooler = new Label();
            label21 = new Label();
            label_psu = new Label();
            label19 = new Label();
            label_storage = new Label();
            label17 = new Label();
            label_graphicCard = new Label();
            label15 = new Label();
            label_case = new Label();
            label13 = new Label();
            label_ram = new Label();
            label10 = new Label();
            label_motherboard = new Label();
            label8 = new Label();
            label_processor = new Label();
            label6 = new Label();
            pictureBox_psu = new PictureBox();
            pictureBox_storage = new PictureBox();
            pictureBox_caseCooler = new PictureBox();
            pictureBox_cpuCooler = new PictureBox();
            pictureBox_graphicCard = new PictureBox();
            pictureBox_case = new PictureBox();
            pictureBox_ram = new PictureBox();
            pictureBox_motherboard = new PictureBox();
            label_caseCooler = new Label();
            label12 = new Label();
            textBox_like = new TextBox();
            label1 = new Label();
            pictureBox_processor = new PictureBox();
            listView_buildList = new ListView();
            columnHeader_name = new ColumnHeader();
            columnHeader_author = new ColumnHeader();
            columnHeader_like = new ColumnHeader();
            ColumnHeader_ID = new ColumnHeader();
            button_products = new Button();
            button_forum = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            openLiveChatToolStripMenuItem = new ToolStripMenuItem();
            label_state = new Label();
            label_user = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Illu).BeginInit();
            tabControl_main.SuspendLayout();
            tabPage_products.SuspendLayout();
            tabPage_forum.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage_decription.SuspendLayout();
            tabPage_comment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_psu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_storage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_caseCooler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cpuCooler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_graphicCard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_case).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_motherboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_processor).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox_Illu
            // 
            pictureBox_Illu.Location = new Point(706, 68);
            pictureBox_Illu.Name = "pictureBox_Illu";
            pictureBox_Illu.Size = new Size(178, 176);
            pictureBox_Illu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Illu.TabIndex = 1;
            pictureBox_Illu.TabStop = false;
            // 
            // textBox_Search
            // 
            textBox_Search.BorderStyle = BorderStyle.FixedSingle;
            textBox_Search.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Search.Location = new Point(36, 39);
            textBox_Search.Name = "textBox_Search";
            textBox_Search.Size = new Size(185, 28);
            textBox_Search.TabIndex = 6;
            textBox_Search.TextChanged += textBox_Search_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Showcard Gothic", 35F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(621, 82);
            label2.TabIndex = 9;
            label2.Text = "Welcome to PC Builder";
            // 
            // button_Build
            // 
            button_Build.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Build.Location = new Point(799, 12);
            button_Build.Name = "button_Build";
            button_Build.Size = new Size(245, 52);
            button_Build.TabIndex = 10;
            button_Build.Text = "Start building you own PC";
            button_Build.UseVisualStyleBackColor = true;
            button_Build.Click += button_Build_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(36, 14);
            label3.Name = "label3";
            label3.Size = new Size(151, 22);
            label3.TabIndex = 11;
            label3.Text = "Search by model name:";
            // 
            // listView_Main
            // 
            listView_Main.Activation = ItemActivation.OneClick;
            listView_Main.BackColor = SystemColors.Window;
            listView_Main.BorderStyle = BorderStyle.FixedSingle;
            listView_Main.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            listView_Main.GroupImageList = imageList_Group;
            listViewGroup10.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup10.Header = "Processor";
            listViewGroup10.Name = "listViewGroup_Processor";
            listViewGroup11.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup11.Header = "Motherboard";
            listViewGroup11.Name = "listViewGroup_Motherboard";
            listViewGroup12.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup12.Header = "CPU Cooler";
            listViewGroup12.Name = "listViewGroup_CPUCooler";
            listViewGroup13.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup13.Header = "Case";
            listViewGroup13.Name = "listViewGroup_Case";
            listViewGroup14.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup14.Header = "Graphic Card";
            listViewGroup14.Name = "listViewGroup_GPU";
            listViewGroup15.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup15.Header = "RAM";
            listViewGroup15.Name = "listViewGroup_RAM";
            listViewGroup16.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup16.Header = "Storage";
            listViewGroup16.Name = "listViewGroup_Disk";
            listViewGroup17.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup17.Header = "Case Cooler";
            listViewGroup17.Name = "listViewGroup_CaseCooler";
            listViewGroup18.CollapsedState = ListViewGroupCollapsedState.Expanded;
            listViewGroup18.Header = "Power Supply";
            listViewGroup18.Name = "listViewGroup_PSU";
            listView_Main.Groups.AddRange(new ListViewGroup[] { listViewGroup10, listViewGroup11, listViewGroup12, listViewGroup13, listViewGroup14, listViewGroup15, listViewGroup16, listViewGroup17, listViewGroup18 });
            listView_Main.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_Main.HideSelection = true;
            listViewItem3.Group = listViewGroup16;
            listView_Main.Items.AddRange(new ListViewItem[] { listViewItem3 });
            listView_Main.LargeImageList = imageList_MainListView;
            listView_Main.Location = new Point(22, 84);
            listView_Main.MultiSelect = false;
            listView_Main.Name = "listView_Main";
            listView_Main.Size = new Size(522, 495);
            listView_Main.Sorting = SortOrder.Ascending;
            listView_Main.TabIndex = 13;
            listView_Main.TileSize = new Size(500, 30);
            listView_Main.UseCompatibleStateImageBehavior = false;
            listView_Main.View = View.Tile;
            listView_Main.ItemSelectionChanged += listView_Main_ItemSelectionChanged;
            // 
            // imageList_Group
            // 
            imageList_Group.ColorDepth = ColorDepth.Depth8Bit;
            imageList_Group.ImageStream = (ImageListStreamer)resources.GetObject("imageList_Group.ImageStream");
            imageList_Group.TransparentColor = Color.Transparent;
            imageList_Group.Images.SetKeyName(0, "Case Cooler.jpg");
            imageList_Group.Images.SetKeyName(1, "Case.jpg");
            imageList_Group.Images.SetKeyName(2, "CPU Cooler.jpg");
            imageList_Group.Images.SetKeyName(3, "GPU.jpg");
            imageList_Group.Images.SetKeyName(4, "Motherboard.jpg");
            imageList_Group.Images.SetKeyName(5, "PSU.jpg");
            imageList_Group.Images.SetKeyName(6, "RAM.jpg");
            imageList_Group.Images.SetKeyName(7, "Storage.jpg");
            imageList_Group.Images.SetKeyName(8, "CPU.jpg");
            // 
            // imageList_MainListView
            // 
            imageList_MainListView.ColorDepth = ColorDepth.Depth8Bit;
            imageList_MainListView.ImageStream = (ImageListStreamer)resources.GetObject("imageList_MainListView.ImageStream");
            imageList_MainListView.TransparentColor = Color.Transparent;
            imageList_MainListView.Images.SetKeyName(0, "RM850.jpg");
            imageList_MainListView.Images.SetKeyName(1, "RM750.jpg");
            imageList_MainListView.Images.SetKeyName(2, "MasterFan MF120R.jpg");
            imageList_MainListView.Images.SetKeyName(3, "AER RGB.jpg");
            imageList_MainListView.Images.SetKeyName(4, "BarraCuda.jpg");
            imageList_MainListView.Images.SetKeyName(5, "970 EVO.jpg");
            imageList_MainListView.Images.SetKeyName(6, "Trident Z5 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(7, "Fury Renegade RGB.jpg");
            imageList_MainListView.Images.SetKeyName(8, "TUF Gaming GeForce RTX 3080 Ti OC Edition.jpg");
            imageList_MainListView.Images.SetKeyName(9, "GeForce RTX 3080 Ti Gaming OC 12G.jpg");
            imageList_MainListView.Images.SetKeyName(10, "H510B-B1.jpg");
            imageList_MainListView.Images.SetKeyName(11, "H510B-W1.jpg");
            imageList_MainListView.Images.SetKeyName(12, "Hyper 212 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(13, "Hyper 212 EVO.jpg");
            imageList_MainListView.Images.SetKeyName(14, "TRX40 Aorus Pro WiFi.jpg");
            imageList_MainListView.Images.SetKeyName(15, "TRX40 CREATOR.jpg");
            imageList_MainListView.Images.SetKeyName(16, "Ryzen 9 7950X.jpg");
            imageList_MainListView.Images.SetKeyName(17, "Ryzen Threadripper 3990X.jpg");
            imageList_MainListView.Images.SetKeyName(18, "RM850.jpg");
            imageList_MainListView.Images.SetKeyName(19, "RM750.jpg");
            imageList_MainListView.Images.SetKeyName(20, "MasterFan MF120R.jpg");
            imageList_MainListView.Images.SetKeyName(21, "AER RGB.jpg");
            imageList_MainListView.Images.SetKeyName(22, "BarraCuda.jpg");
            imageList_MainListView.Images.SetKeyName(23, "970 EVO.jpg");
            imageList_MainListView.Images.SetKeyName(24, "Trident Z5 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(25, "Fury Renegade RGB.jpg");
            imageList_MainListView.Images.SetKeyName(26, "TUF Gaming GeForce RTX 3080 Ti OC Edition.jpg");
            imageList_MainListView.Images.SetKeyName(27, "GeForce RTX 3080 Ti Gaming OC 12G.jpg");
            imageList_MainListView.Images.SetKeyName(28, "H510B-B1.jpg");
            imageList_MainListView.Images.SetKeyName(29, "H510B-W1.jpg");
            imageList_MainListView.Images.SetKeyName(30, "Hyper 212 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(31, "Hyper 212 EVO.jpg");
            imageList_MainListView.Images.SetKeyName(32, "TRX40 Aorus Pro WiFi.jpg");
            imageList_MainListView.Images.SetKeyName(33, "TRX40 CREATOR.jpg");
            imageList_MainListView.Images.SetKeyName(34, "Ryzen 9 7950X.jpg");
            imageList_MainListView.Images.SetKeyName(35, "Ryzen Threadripper 3990X.jpg");
            imageList_MainListView.Images.SetKeyName(36, "i5-13600K.jpg");
            imageList_MainListView.Images.SetKeyName(37, "i7-13700KF.jpg");
            imageList_MainListView.Images.SetKeyName(38, "i9-12900K.jpg");
            imageList_MainListView.Images.SetKeyName(39, "i9-13900K.jpg");
            imageList_MainListView.Images.SetKeyName(40, "i9-13900KF.jpg");
            imageList_MainListView.Images.SetKeyName(41, "Ryzen 9 3950X.jpg");
            imageList_MainListView.Images.SetKeyName(42, "Ryzen 9 5950X.jpg");
            imageList_MainListView.Images.SetKeyName(43, "Ryzen 9 7900X.jpg");
            imageList_MainListView.Images.SetKeyName(44, "Ryzen Threadripper 3970X.jpg");
            imageList_MainListView.Images.SetKeyName(45, "4000D Airflow.jpg");
            imageList_MainListView.Images.SetKeyName(46, "CARBIDE SPEC-05.jpg");
            imageList_MainListView.Images.SetKeyName(47, "Carbide SPEC-Omega.jpg");
            imageList_MainListView.Images.SetKeyName(48, "CC-9011205-WW.jpg");
            imageList_MainListView.Images.SetKeyName(49, "H510B.jpg");
            imageList_MainListView.Images.SetKeyName(50, "H510i.jpg");
            imageList_MainListView.Images.SetKeyName(51, "MasterBox Q500L.jpg");
            imageList_MainListView.Images.SetKeyName(52, "MasterBox TD500.jpg");
            imageList_MainListView.Images.SetKeyName(53, "Q300L.jpg");
            imageList_MainListView.Images.SetKeyName(54, "ACFAN00118A.jpg");
            imageList_MainListView.Images.SetKeyName(55, "ACFAN00170A.jpg");
            imageList_MainListView.Images.SetKeyName(56, "CO-9050015-BLED.jpg");
            imageList_MainListView.Images.SetKeyName(57, "CO-9050015-RLED.jpg");
            imageList_MainListView.Images.SetKeyName(58, "HD140 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(59, "P12 PST RGB.jpg");
            imageList_MainListView.Images.SetKeyName(60, "P12 PST.jpg");
            imageList_MainListView.Images.SetKeyName(61, "P12 PWM.jpg");
            imageList_MainListView.Images.SetKeyName(62, "P12 Silent.jpg");
            imageList_MainListView.Images.SetKeyName(63, "SP120 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(64, "Hyper 212 Black Edition.jpg");
            imageList_MainListView.Images.SetKeyName(65, "Hyper H412R.jpg");
            imageList_MainListView.Images.SetKeyName(66, "Hyper T2.jpg");
            imageList_MainListView.Images.SetKeyName(67, "Kraken M22.jpg");
            imageList_MainListView.Images.SetKeyName(68, "Kraken X53 RGB 240mm.jpg");
            imageList_MainListView.Images.SetKeyName(69, "Kraken X53 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(70, "Kraken X53.jpg");
            imageList_MainListView.Images.SetKeyName(71, "Kraken X63 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(72, "Kraken Z73 RGB.jpg");
            imageList_MainListView.Images.SetKeyName(73, "Kraken Z73.jpg");
            imageList_MainListView.Images.SetKeyName(74, "Gaming GeForce RTX 4090 Trinity OC.jpg");
            imageList_MainListView.Images.SetKeyName(75, "GeForce RTX 3090 Ti AMP Extreme Holo.jpg");
            imageList_MainListView.Images.SetKeyName(76, "GeForce RTX 3090 Ti FTW3 Ultra Gaming.jpg");
            imageList_MainListView.Images.SetKeyName(77, "GeForce RTX 4090 Founders Edition.jpg");
            imageList_MainListView.Images.SetKeyName(78, "GeForce RTX 4090 SUPRIM LIQUID X 24G.jpg");
            imageList_MainListView.Images.SetKeyName(79, "GV-N4090WF3-24GD.jpg");
            imageList_MainListView.Images.SetKeyName(80, "RTX 3080 Ti FTW3 Ultra.jpg");
            imageList_MainListView.Images.SetKeyName(81, "RTX 3080 Ti Ventus 3X 12G OC.jpg");
            imageList_MainListView.Images.SetKeyName(82, "RTX 3080 Ti XC3 ULTRA.jpg");
            imageList_MainListView.Images.SetKeyName(83, "RTX 4090 Gaming Trio 24G.jpg");
            imageList_MainListView.Images.SetKeyName(84, "ROG CROSSHAIR VIII HERO (WI-FI).jpg");
            imageList_MainListView.Images.SetKeyName(85, "ROG ZENITH II EXTREME ALPHA.jpg");
            imageList_MainListView.Images.SetKeyName(86, "TUF GAMING X570-PLUS (WI-FI).jpg");
            imageList_MainListView.Images.SetKeyName(87, "TRX40 AORUS XTREME.jpg");
            imageList_MainListView.Images.SetKeyName(88, "TRX40 DESIGNARE.jpg");
            imageList_MainListView.Images.SetKeyName(89, "TRX40P.jpg");
            imageList_MainListView.Images.SetKeyName(90, "X570 AORUS ELITE.jpg");
            imageList_MainListView.Images.SetKeyName(91, "X570 I AORUS PRO WIFI.jpg");
            imageList_MainListView.Images.SetKeyName(92, "X570 PRO WIFI.jpg");
            imageList_MainListView.Images.SetKeyName(93, "X570S AORUS ELITE AX.jpg");
            imageList_MainListView.Images.SetKeyName(94, "220-G6-0850-X1.jpg");
            imageList_MainListView.Images.SetKeyName(95, "PS-SPD-0430NPCWUS-W.jpg");
            imageList_MainListView.Images.SetKeyName(96, "PS-SPD-0500NPCWUS-W.jpg");
            imageList_MainListView.Images.SetKeyName(97, "SMART 600.jpg");
            imageList_MainListView.Images.SetKeyName(98, "SPD-0700NP.jpg");
            imageList_MainListView.Images.SetKeyName(99, "SuperNOVA 750 G6.jpg");
            imageList_MainListView.Images.SetKeyName(100, "SuperNOVA 1000 G6.jpg");
            imageList_MainListView.Images.SetKeyName(101, "SuperNOVA.jpg");
            imageList_MainListView.Images.SetKeyName(102, "Toughpower GX1.jpg");
            imageList_MainListView.Images.SetKeyName(103, "Toughpower PF1.jpg");
            imageList_MainListView.Images.SetKeyName(104, "AX5U6000C4016G-DCLARBK.jpg");
            imageList_MainListView.Images.SetKeyName(105, "CMH32GX5M2D6000C36.jpg");
            imageList_MainListView.Images.SetKeyName(106, "CMK32GX5M2B5600C36.jpg");
            imageList_MainListView.Images.SetKeyName(107, "DOMINATOR PLATINUM.jpg");
            imageList_MainListView.Images.SetKeyName(108, "FF3D532G6000HC38ADC0.jpg");
            imageList_MainListView.Images.SetKeyName(109, "KF556C40BBAK2-64.jpg");
            imageList_MainListView.Images.SetKeyName(110, "RipJaws S5.jpg");
            imageList_MainListView.Images.SetKeyName(111, "Trident Z5.jpg");
            imageList_MainListView.Images.SetKeyName(112, "Viper Venom RGB.jpg");
            imageList_MainListView.Images.SetKeyName(113, "XLR8.jpg");
            imageList_MainListView.Images.SetKeyName(114, "A400.jpg");
            imageList_MainListView.Images.SetKeyName(115, "Blue 500.jpg");
            imageList_MainListView.Images.SetKeyName(116, "Blue SN 550.jpg");
            imageList_MainListView.Images.SetKeyName(117, "Blue.jpg");
            imageList_MainListView.Images.SetKeyName(118, "Caviar Blue.jpg");
            imageList_MainListView.Images.SetKeyName(119, "EVO 500.jpg");
            imageList_MainListView.Images.SetKeyName(120, "GX2.jpg");
            imageList_MainListView.Images.SetKeyName(121, "MX 500.jpg");
            imageList_MainListView.Images.SetKeyName(122, "P1.jpg");
            imageList_MainListView.Images.SetKeyName(123, "SN 750.jpg");
            imageList_MainListView.Images.SetKeyName(124, "H510 Elite.jpg");
            imageList_MainListView.Images.SetKeyName(125, "Ryzen 7 7700X.jpg");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(255, 13);
            label4.Name = "label4";
            label4.Size = new Size(66, 22);
            label4.TabIndex = 12;
            label4.Text = "Category:";
            // 
            // comboBox_Category
            // 
            comboBox_Category.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_Category.FormattingEnabled = true;
            comboBox_Category.Items.AddRange(new object[] { "Processor", "Motherboard", "CPU Cooler", "Case", "Graphic Card", "RAM", "Storage", "Case Cooler", "Power Supply", "All" });
            comboBox_Category.Location = new Point(255, 39);
            comboBox_Category.Name = "comboBox_Category";
            comboBox_Category.Size = new Size(152, 29);
            comboBox_Category.TabIndex = 7;
            comboBox_Category.TextChanged += comboBox_Category_TextChanged;
            // 
            // richTextBox_Detail
            // 
            richTextBox_Detail.BorderStyle = BorderStyle.None;
            richTextBox_Detail.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_Detail.Location = new Point(604, 265);
            richTextBox_Detail.Name = "richTextBox_Detail";
            richTextBox_Detail.Size = new Size(382, 233);
            richTextBox_Detail.TabIndex = 15;
            richTextBox_Detail.Text = "";
            // 
            // button_openAmazon
            // 
            button_openAmazon.BackColor = Color.Transparent;
            button_openAmazon.BackgroundImage = (Image)resources.GetObject("button_openAmazon.BackgroundImage");
            button_openAmazon.BackgroundImageLayout = ImageLayout.Stretch;
            button_openAmazon.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_openAmazon.ForeColor = SystemColors.Window;
            button_openAmazon.Location = new Point(722, 525);
            button_openAmazon.Name = "button_openAmazon";
            button_openAmazon.Size = new Size(148, 49);
            button_openAmazon.TabIndex = 16;
            toolTip.SetToolTip(button_openAmazon, "View on Amazon");
            button_openAmazon.UseVisualStyleBackColor = false;
            button_openAmazon.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(658, 12);
            button1.Name = "button1";
            button1.Size = new Size(135, 52);
            button1.TabIndex = 17;
            button1.Text = "Auto Builder";
            toolTip.SetToolTip(button1, "Auto Builder is a wizard help user to build a PC Case in a easier way.");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button_rebuild
            // 
            button_rebuild.BackColor = SystemColors.Window;
            button_rebuild.BackgroundImage = (Image)resources.GetObject("button_rebuild.BackgroundImage");
            button_rebuild.BackgroundImageLayout = ImageLayout.Stretch;
            button_rebuild.FlatAppearance.BorderColor = Color.Black;
            button_rebuild.FlatAppearance.BorderSize = 0;
            button_rebuild.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button_rebuild.FlatStyle = FlatStyle.Flat;
            button_rebuild.Location = new Point(864, 263);
            button_rebuild.Name = "button_rebuild";
            button_rebuild.Size = new Size(20, 20);
            button_rebuild.TabIndex = 49;
            toolTip.SetToolTip(button_rebuild, "Rebuild");
            button_rebuild.UseVisualStyleBackColor = false;
            button_rebuild.Click += button_rebuild_Click;
            // 
            // button_save
            // 
            button_save.BackColor = SystemColors.Window;
            button_save.BackgroundImage = (Image)resources.GetObject("button_save.BackgroundImage");
            button_save.BackgroundImageLayout = ImageLayout.Stretch;
            button_save.FlatAppearance.BorderColor = Color.Black;
            button_save.FlatAppearance.BorderSize = 0;
            button_save.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.Location = new Point(828, 264);
            button_save.Name = "button_save";
            button_save.Size = new Size(20, 20);
            button_save.TabIndex = 43;
            toolTip.SetToolTip(button_save, "Save");
            button_save.UseVisualStyleBackColor = false;
            button_save.Click += button_save_Click;
            // 
            // button_like
            // 
            button_like.BackColor = SystemColors.Window;
            button_like.BackgroundImage = (Image)resources.GetObject("button_like.BackgroundImage");
            button_like.BackgroundImageLayout = ImageLayout.Stretch;
            button_like.FlatAppearance.BorderColor = Color.Black;
            button_like.FlatAppearance.BorderSize = 0;
            button_like.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            button_like.FlatStyle = FlatStyle.Flat;
            button_like.Location = new Point(791, 263);
            button_like.Name = "button_like";
            button_like.Size = new Size(20, 20);
            button_like.TabIndex = 33;
            toolTip.SetToolTip(button_like, "Like");
            button_like.UseVisualStyleBackColor = false;
            button_like.Click += button_like_Click;
            // 
            // button_reload
            // 
            button_reload.BackgroundImage = (Image)resources.GetObject("button_reload.BackgroundImage");
            button_reload.BackgroundImageLayout = ImageLayout.Stretch;
            button_reload.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_reload.Location = new Point(728, 92);
            button_reload.Name = "button_reload";
            button_reload.Size = new Size(52, 52);
            button_reload.TabIndex = 21;
            toolTip.SetToolTip(button_reload, "Reload");
            button_reload.UseVisualStyleBackColor = true;
            button_reload.Click += button_reload_Click;
            // 
            // button_edit
            // 
            button_edit.BackgroundImage = (Image)resources.GetObject("button_edit.BackgroundImage");
            button_edit.BackgroundImageLayout = ImageLayout.Stretch;
            button_edit.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_edit.Location = new Point(274, 97);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(52, 52);
            button_edit.TabIndex = 22;
            toolTip.SetToolTip(button_edit, "Reload");
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_login
            // 
            button_login.BackgroundImage = (Image)resources.GetObject("button_login.BackgroundImage");
            button_login.BackgroundImageLayout = ImageLayout.Stretch;
            button_login.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_login.Location = new Point(332, 97);
            button_login.Name = "button_login";
            button_login.Size = new Size(52, 52);
            button_login.TabIndex = 23;
            toolTip.SetToolTip(button_login, "Reload");
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button2_Click;
            // 
            // tabControl_main
            // 
            tabControl_main.Controls.Add(tabPage_products);
            tabControl_main.Controls.Add(tabPage_forum);
            tabControl_main.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl_main.ItemSize = new Size(0, 1);
            tabControl_main.Location = new Point(-3, 150);
            tabControl_main.Name = "tabControl_main";
            tabControl_main.SelectedIndex = 0;
            tabControl_main.Size = new Size(1064, 630);
            tabControl_main.SizeMode = TabSizeMode.Fixed;
            tabControl_main.TabIndex = 18;
            // 
            // tabPage_products
            // 
            tabPage_products.BackColor = Color.White;
            tabPage_products.Controls.Add(richTextBox_Detail);
            tabPage_products.Controls.Add(pictureBox_Illu);
            tabPage_products.Controls.Add(label4);
            tabPage_products.Controls.Add(listView_Main);
            tabPage_products.Controls.Add(label3);
            tabPage_products.Controls.Add(button_openAmazon);
            tabPage_products.Controls.Add(textBox_Search);
            tabPage_products.Controls.Add(comboBox_Category);
            tabPage_products.Location = new Point(4, 5);
            tabPage_products.Name = "tabPage_products";
            tabPage_products.Padding = new Padding(3);
            tabPage_products.Size = new Size(1056, 621);
            tabPage_products.TabIndex = 0;
            tabPage_products.Text = "Products";
            // 
            // tabPage_forum
            // 
            tabPage_forum.BackColor = Color.White;
            tabPage_forum.Controls.Add(tabControl1);
            tabPage_forum.Controls.Add(label_creator);
            tabPage_forum.Controls.Add(label_buildName);
            tabPage_forum.Controls.Add(label7);
            tabPage_forum.Controls.Add(label5);
            tabPage_forum.Controls.Add(button_send);
            tabPage_forum.Controls.Add(textBox_comments);
            tabPage_forum.Controls.Add(textBox_sender);
            tabPage_forum.Controls.Add(label_cpuCooler);
            tabPage_forum.Controls.Add(label21);
            tabPage_forum.Controls.Add(label_psu);
            tabPage_forum.Controls.Add(label19);
            tabPage_forum.Controls.Add(label_storage);
            tabPage_forum.Controls.Add(label17);
            tabPage_forum.Controls.Add(label_graphicCard);
            tabPage_forum.Controls.Add(label15);
            tabPage_forum.Controls.Add(label_case);
            tabPage_forum.Controls.Add(label13);
            tabPage_forum.Controls.Add(label_ram);
            tabPage_forum.Controls.Add(label10);
            tabPage_forum.Controls.Add(label_motherboard);
            tabPage_forum.Controls.Add(label8);
            tabPage_forum.Controls.Add(label_processor);
            tabPage_forum.Controls.Add(label6);
            tabPage_forum.Controls.Add(pictureBox_psu);
            tabPage_forum.Controls.Add(pictureBox_storage);
            tabPage_forum.Controls.Add(pictureBox_caseCooler);
            tabPage_forum.Controls.Add(pictureBox_cpuCooler);
            tabPage_forum.Controls.Add(pictureBox_graphicCard);
            tabPage_forum.Controls.Add(pictureBox_case);
            tabPage_forum.Controls.Add(pictureBox_ram);
            tabPage_forum.Controls.Add(pictureBox_motherboard);
            tabPage_forum.Controls.Add(label_caseCooler);
            tabPage_forum.Controls.Add(label12);
            tabPage_forum.Controls.Add(button_rebuild);
            tabPage_forum.Controls.Add(button_save);
            tabPage_forum.Controls.Add(textBox_like);
            tabPage_forum.Controls.Add(label1);
            tabPage_forum.Controls.Add(button_like);
            tabPage_forum.Controls.Add(pictureBox_processor);
            tabPage_forum.Controls.Add(listView_buildList);
            tabPage_forum.Location = new Point(4, 5);
            tabPage_forum.Name = "tabPage_forum";
            tabPage_forum.Padding = new Padding(3);
            tabPage_forum.Size = new Size(1056, 621);
            tabPage_forum.TabIndex = 1;
            tabPage_forum.Text = "Forum";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_decription);
            tabControl1.Controls.Add(tabPage_comment);
            tabControl1.Location = new Point(18, 302);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1016, 238);
            tabControl1.TabIndex = 88;
            // 
            // tabPage_decription
            // 
            tabPage_decription.Controls.Add(richTextBox_decription);
            tabPage_decription.Location = new Point(4, 28);
            tabPage_decription.Name = "tabPage_decription";
            tabPage_decription.Padding = new Padding(3);
            tabPage_decription.Size = new Size(1008, 206);
            tabPage_decription.TabIndex = 0;
            tabPage_decription.Text = "Decription";
            tabPage_decription.UseVisualStyleBackColor = true;
            // 
            // richTextBox_decription
            // 
            richTextBox_decription.BorderStyle = BorderStyle.None;
            richTextBox_decription.Location = new Point(6, 6);
            richTextBox_decription.Name = "richTextBox_decription";
            richTextBox_decription.Size = new Size(996, 194);
            richTextBox_decription.TabIndex = 80;
            richTextBox_decription.Text = "";
            // 
            // tabPage_comment
            // 
            tabPage_comment.BackColor = Color.White;
            tabPage_comment.Controls.Add(richTextBox_comments);
            tabPage_comment.Location = new Point(4, 24);
            tabPage_comment.Name = "tabPage_comment";
            tabPage_comment.Padding = new Padding(3);
            tabPage_comment.Size = new Size(1008, 210);
            tabPage_comment.TabIndex = 1;
            tabPage_comment.Text = "Comments";
            // 
            // richTextBox_comments
            // 
            richTextBox_comments.BorderStyle = BorderStyle.None;
            richTextBox_comments.Location = new Point(21, 6);
            richTextBox_comments.Name = "richTextBox_comments";
            richTextBox_comments.Size = new Size(981, 194);
            richTextBox_comments.TabIndex = 79;
            richTextBox_comments.Text = "";
            // 
            // label_creator
            // 
            label_creator.AutoSize = true;
            label_creator.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_creator.Location = new Point(953, 19);
            label_creator.Name = "label_creator";
            label_creator.RightToLeft = RightToLeft.Yes;
            label_creator.Size = new Size(0, 18);
            label_creator.TabIndex = 87;
            label_creator.TextAlign = ContentAlignment.TopRight;
            // 
            // label_buildName
            // 
            label_buildName.AutoSize = true;
            label_buildName.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label_buildName.Location = new Point(596, 19);
            label_buildName.Name = "label_buildName";
            label_buildName.Size = new Size(0, 18);
            label_buildName.TabIndex = 85;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(135, 543);
            label7.Name = "label7";
            label7.Size = new Size(83, 19);
            label7.TabIndex = 84;
            label7.Text = "Comment:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 543);
            label5.Name = "label5";
            label5.Size = new Size(56, 19);
            label5.TabIndex = 83;
            label5.Text = "Name:";
            // 
            // button_send
            // 
            button_send.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_send.Location = new Point(953, 574);
            button_send.Name = "button_send";
            button_send.Size = new Size(75, 27);
            button_send.TabIndex = 82;
            button_send.Text = "Send";
            button_send.UseVisualStyleBackColor = true;
            button_send.Click += button_send_Click;
            // 
            // textBox_comments
            // 
            textBox_comments.BorderStyle = BorderStyle.FixedSingle;
            textBox_comments.Location = new Point(135, 574);
            textBox_comments.Name = "textBox_comments";
            textBox_comments.Size = new Size(812, 27);
            textBox_comments.TabIndex = 81;
            // 
            // textBox_sender
            // 
            textBox_sender.BorderStyle = BorderStyle.FixedSingle;
            textBox_sender.Location = new Point(29, 574);
            textBox_sender.Name = "textBox_sender";
            textBox_sender.Size = new Size(100, 27);
            textBox_sender.TabIndex = 80;
            // 
            // label_cpuCooler
            // 
            label_cpuCooler.AutoSize = true;
            label_cpuCooler.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_cpuCooler.Location = new Point(839, 234);
            label_cpuCooler.Name = "label_cpuCooler";
            label_cpuCooler.Size = new Size(0, 18);
            label_cpuCooler.TabIndex = 78;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label21.Location = new Point(739, 234);
            label21.Name = "label21";
            label21.Size = new Size(85, 18);
            label21.TabIndex = 77;
            label21.Text = "CPU Cooler:";
            // 
            // label_psu
            // 
            label_psu.AutoSize = true;
            label_psu.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_psu.Location = new Point(839, 188);
            label_psu.Name = "label_psu";
            label_psu.Size = new Size(0, 18);
            label_psu.TabIndex = 76;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(739, 188);
            label19.Name = "label19";
            label19.Size = new Size(100, 18);
            label19.TabIndex = 75;
            label19.Text = "Power Supply:";
            // 
            // label_storage
            // 
            label_storage.AutoSize = true;
            label_storage.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_storage.Location = new Point(839, 165);
            label_storage.Name = "label_storage";
            label_storage.Size = new Size(0, 18);
            label_storage.TabIndex = 74;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(739, 165);
            label17.Name = "label17";
            label17.Size = new Size(63, 18);
            label17.TabIndex = 73;
            label17.Text = "Storage:";
            // 
            // label_graphicCard
            // 
            label_graphicCard.AutoSize = true;
            label_graphicCard.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_graphicCard.Location = new Point(839, 142);
            label_graphicCard.Name = "label_graphicCard";
            label_graphicCard.Size = new Size(0, 18);
            label_graphicCard.TabIndex = 72;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(739, 142);
            label15.Name = "label15";
            label15.Size = new Size(97, 18);
            label15.TabIndex = 71;
            label15.Text = "Graphic Card:";
            // 
            // label_case
            // 
            label_case.AutoSize = true;
            label_case.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_case.Location = new Point(839, 119);
            label_case.Name = "label_case";
            label_case.Size = new Size(0, 18);
            label_case.TabIndex = 70;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(739, 119);
            label13.Name = "label13";
            label13.Size = new Size(44, 18);
            label13.TabIndex = 69;
            label13.Text = "Case:";
            // 
            // label_ram
            // 
            label_ram.AutoSize = true;
            label_ram.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_ram.Location = new Point(839, 96);
            label_ram.Name = "label_ram";
            label_ram.Size = new Size(0, 18);
            label_ram.TabIndex = 68;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(739, 96);
            label10.Name = "label10";
            label10.Size = new Size(64, 18);
            label10.TabIndex = 67;
            label10.Text = "Memory:";
            // 
            // label_motherboard
            // 
            label_motherboard.AutoSize = true;
            label_motherboard.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_motherboard.Location = new Point(839, 73);
            label_motherboard.Name = "label_motherboard";
            label_motherboard.Size = new Size(0, 18);
            label_motherboard.TabIndex = 66;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(739, 73);
            label8.Name = "label8";
            label8.Size = new Size(96, 18);
            label8.TabIndex = 65;
            label8.Text = "Motherboard:";
            // 
            // label_processor
            // 
            label_processor.AutoSize = true;
            label_processor.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_processor.Location = new Point(839, 50);
            label_processor.Name = "label_processor";
            label_processor.Size = new Size(0, 18);
            label_processor.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(739, 50);
            label6.Name = "label6";
            label6.Size = new Size(78, 18);
            label6.TabIndex = 63;
            label6.Text = "Processor:";
            // 
            // pictureBox_psu
            // 
            pictureBox_psu.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_psu.Location = new Point(650, 203);
            pictureBox_psu.Name = "pictureBox_psu";
            pictureBox_psu.Size = new Size(60, 60);
            pictureBox_psu.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_psu.TabIndex = 62;
            pictureBox_psu.TabStop = false;
            // 
            // pictureBox_storage
            // 
            pictureBox_storage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_storage.Location = new Point(590, 203);
            pictureBox_storage.Name = "pictureBox_storage";
            pictureBox_storage.Size = new Size(60, 60);
            pictureBox_storage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_storage.TabIndex = 61;
            pictureBox_storage.TabStop = false;
            // 
            // pictureBox_caseCooler
            // 
            pictureBox_caseCooler.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_caseCooler.Location = new Point(530, 203);
            pictureBox_caseCooler.Name = "pictureBox_caseCooler";
            pictureBox_caseCooler.Size = new Size(60, 60);
            pictureBox_caseCooler.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_caseCooler.TabIndex = 60;
            pictureBox_caseCooler.TabStop = false;
            // 
            // pictureBox_cpuCooler
            // 
            pictureBox_cpuCooler.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_cpuCooler.Location = new Point(650, 143);
            pictureBox_cpuCooler.Name = "pictureBox_cpuCooler";
            pictureBox_cpuCooler.Size = new Size(60, 60);
            pictureBox_cpuCooler.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_cpuCooler.TabIndex = 59;
            pictureBox_cpuCooler.TabStop = false;
            // 
            // pictureBox_graphicCard
            // 
            pictureBox_graphicCard.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_graphicCard.Location = new Point(590, 143);
            pictureBox_graphicCard.Name = "pictureBox_graphicCard";
            pictureBox_graphicCard.Size = new Size(60, 60);
            pictureBox_graphicCard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_graphicCard.TabIndex = 58;
            pictureBox_graphicCard.TabStop = false;
            // 
            // pictureBox_case
            // 
            pictureBox_case.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_case.Location = new Point(530, 143);
            pictureBox_case.Name = "pictureBox_case";
            pictureBox_case.Size = new Size(60, 60);
            pictureBox_case.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_case.TabIndex = 57;
            pictureBox_case.TabStop = false;
            // 
            // pictureBox_ram
            // 
            pictureBox_ram.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_ram.Location = new Point(650, 83);
            pictureBox_ram.Name = "pictureBox_ram";
            pictureBox_ram.Size = new Size(60, 60);
            pictureBox_ram.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_ram.TabIndex = 56;
            pictureBox_ram.TabStop = false;
            // 
            // pictureBox_motherboard
            // 
            pictureBox_motherboard.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_motherboard.Location = new Point(590, 83);
            pictureBox_motherboard.Name = "pictureBox_motherboard";
            pictureBox_motherboard.Size = new Size(60, 60);
            pictureBox_motherboard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_motherboard.TabIndex = 55;
            pictureBox_motherboard.TabStop = false;
            // 
            // label_caseCooler
            // 
            label_caseCooler.AutoSize = true;
            label_caseCooler.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label_caseCooler.Location = new Point(839, 211);
            label_caseCooler.Name = "label_caseCooler";
            label_caseCooler.Size = new Size(0, 18);
            label_caseCooler.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bahnschrift", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(739, 211);
            label12.Name = "label12";
            label12.Size = new Size(90, 18);
            label12.TabIndex = 53;
            label12.Text = "Case Cooler:";
            // 
            // textBox_like
            // 
            textBox_like.BackColor = SystemColors.Window;
            textBox_like.BorderStyle = BorderStyle.FixedSingle;
            textBox_like.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_like.Location = new Point(739, 262);
            textBox_like.Multiline = true;
            textBox_like.Name = "textBox_like";
            textBox_like.ReadOnly = true;
            textBox_like.Size = new Size(43, 22);
            textBox_like.TabIndex = 42;
            textBox_like.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(501, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 18);
            label1.TabIndex = 34;
            label1.Text = "Build Name:";
            // 
            // pictureBox_processor
            // 
            pictureBox_processor.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_processor.Location = new Point(530, 83);
            pictureBox_processor.Name = "pictureBox_processor";
            pictureBox_processor.Size = new Size(60, 60);
            pictureBox_processor.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_processor.TabIndex = 32;
            pictureBox_processor.TabStop = false;
            // 
            // listView_buildList
            // 
            listView_buildList.Columns.AddRange(new ColumnHeader[] { columnHeader_name, columnHeader_author, columnHeader_like, ColumnHeader_ID });
            listView_buildList.Font = new Font("Bahnschrift", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            listView_buildList.FullRowSelect = true;
            listView_buildList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView_buildList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView_buildList.Location = new Point(32, 19);
            listView_buildList.MultiSelect = false;
            listView_buildList.Name = "listView_buildList";
            listView_buildList.Size = new Size(453, 265);
            listView_buildList.TabIndex = 31;
            listView_buildList.UseCompatibleStateImageBehavior = false;
            listView_buildList.View = View.Details;
            listView_buildList.SelectedIndexChanged += listView_buildList_SelectedIndexChanged;
            listView_buildList.DoubleClick += listView_buildList_DoubleClick;
            // 
            // columnHeader_name
            // 
            columnHeader_name.Text = "ID";
            columnHeader_name.Width = 50;
            // 
            // columnHeader_author
            // 
            columnHeader_author.Text = "Build Name";
            columnHeader_author.Width = 200;
            // 
            // columnHeader_like
            // 
            columnHeader_like.Text = "Creator";
            columnHeader_like.Width = 139;
            // 
            // ColumnHeader_ID
            // 
            ColumnHeader_ID.Text = "Like";
            // 
            // button_products
            // 
            button_products.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_products.Location = new Point(23, 97);
            button_products.Name = "button_products";
            button_products.Size = new Size(245, 52);
            button_products.TabIndex = 19;
            button_products.Text = "View Available Products";
            button_products.UseVisualStyleBackColor = true;
            button_products.Click += button_products_Click;
            // 
            // button_forum
            // 
            button_forum.Font = new Font("Bahnschrift", 12.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_forum.Location = new Point(790, 92);
            button_forum.Name = "button_forum";
            button_forum.Size = new Size(245, 52);
            button_forum.TabIndex = 20;
            button_forum.Text = "Go to Forum";
            button_forum.UseVisualStyleBackColor = true;
            button_forum.Click += button_forum_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { openLiveChatToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 26);
            // 
            // openLiveChatToolStripMenuItem
            // 
            openLiveChatToolStripMenuItem.Name = "openLiveChatToolStripMenuItem";
            openLiveChatToolStripMenuItem.Size = new Size(155, 22);
            openLiveChatToolStripMenuItem.Text = "Open Live Chat";
            openLiveChatToolStripMenuItem.Click += openLiveChatToolStripMenuItem_Click;
            // 
            // label_state
            // 
            label_state.AutoSize = true;
            label_state.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_state.Location = new Point(390, 127);
            label_state.Name = "label_state";
            label_state.Size = new Size(89, 22);
            label_state.TabIndex = 17;
            label_state.Text = "Not logged in";
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Font = new Font("Bahnschrift Condensed", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label_user.Location = new Point(390, 105);
            label_user.Name = "label_user";
            label_user.Size = new Size(43, 22);
            label_user.TabIndex = 24;
            label_user.Text = "Guest";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1056, 774);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(label_user);
            Controls.Add(label_state);
            Controls.Add(button_login);
            Controls.Add(button_edit);
            Controls.Add(button_reload);
            Controls.Add(button_forum);
            Controls.Add(button_products);
            Controls.Add(tabControl_main);
            Controls.Add(button1);
            Controls.Add(button_Build);
            Controls.Add(label2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PC Builder";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox_Illu).EndInit();
            tabControl_main.ResumeLayout(false);
            tabPage_products.ResumeLayout(false);
            tabPage_products.PerformLayout();
            tabPage_forum.ResumeLayout(false);
            tabPage_forum.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage_decription.ResumeLayout(false);
            tabPage_comment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox_psu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_storage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_caseCooler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_cpuCooler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_graphicCard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_case).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_ram).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_motherboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_processor).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button button1;
        private TabControl tabControl_main;
        private TabPage tabPage_products;
        private TabPage tabPage_forum;
        private Button button_products;
        private Button button_forum;
        private Label label_psu;
        private Label label19;
        private Label label_storage;
        private Label label17;
        private Label label_graphicCard;
        private Label label15;
        private Label label_case;
        private Label label13;
        private Label label_ram;
        private Label label10;
        private Label label_motherboard;
        private Label label8;
        private Label label_processor;
        private Label label6;
        private PictureBox pictureBox_psu;
        private PictureBox pictureBox_storage;
        private PictureBox pictureBox_caseCooler;
        private PictureBox pictureBox_cpuCooler;
        private PictureBox pictureBox_graphicCard;
        private PictureBox pictureBox_case;
        private PictureBox pictureBox_ram;
        private PictureBox pictureBox_motherboard;
        private Label label_caseCooler;
        private Label label12;
        private Button button_rebuild;
        private Button button_save;
        private TextBox textBox_like;
        private Label label1;
        private Button button_like;
        private PictureBox pictureBox_processor;
        private ListView listView_buildList;
        private ColumnHeader columnHeader_name;
        private ColumnHeader columnHeader_author;
        private ColumnHeader columnHeader_like;
        private Label label_cpuCooler;
        private Label label21;
        private Label label7;
        private Label label5;
        private Button button_send;
        private TextBox textBox_comments;
        private TextBox textBox_sender;
        private RichTextBox richTextBox_comments;
        private Label label_creator;
        private Label label_buildName;
        private TabControl tabControl1;
        private TabPage tabPage_decription;
        private RichTextBox richTextBox_decription;
        private TabPage tabPage_comment;
        private ColumnHeader ColumnHeader_ID;
        private Button button_reload;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openLiveChatToolStripMenuItem;
        private Button button_edit;
        private Button button_login;
        private Label label_state;
        private Label label_user;
    }
}