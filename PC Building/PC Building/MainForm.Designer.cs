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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Processors", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Motherboard", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("CPU Cooler", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Case", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Graphic Card", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Memory", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Storage", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("Case Cooler", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("Power Supply", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("970 EVO", "970 EVO.jpg");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "AER RGB"}, "AER RGB.jpg", System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("BarraCuda", "BarraCuda.jpg");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Fury Renegade RGB", "Fury Renegade RGB.jpg");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("GeForce RTX 3080 Ti Gaming OC 12G", "GeForce RTX 3080 Ti Gaming OC 12G.jpg");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("H510B-B1", "H510B-B1.jpg");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("H510B-W1", "H510B-W1.jpg");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Hyper 212 EVO", "Hyper 212 EVO.jpg");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Hyper 212 RGB", "Hyper 212 RGB.jpg");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("MasterFan MF120R", "MasterFan MF120R.jpg");
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("RM750", "RM750.jpg");
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("RM850", "RM850.jpg");
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Ryzen 9 7950X", "Ryzen 9 7950X.jpg");
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ryzen Threadripper 3990X"}, "Ryzen Threadripper 3990X.jpg", System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Trident Z5 RGB", "Trident Z5 RGB.jpg");
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("TRX40 Aorus Pro WiFi", "TRX40 Aorus Pro WiFi.jpg");
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("TRX40 CREATOR", "TRX40 CREATOR.jpg");
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("TUF Gaming GeForce RTX 3080 Ti OC Edition", "TUF Gaming GeForce RTX 3080 Ti OC Edition.jpg");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox_Illu = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Decription = new System.Windows.Forms.Label();
            this.label_NameText = new System.Windows.Forms.Label();
            this.label_DecripText = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Build = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView_Main = new System.Windows.Forms.ListView();
            this.imageList_Group = new System.Windows.Forms.ImageList(this.components);
            this.imageList_MainListView = new System.Windows.Forms.ImageList(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illu)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Illu
            // 
            this.pictureBox_Illu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Illu.Location = new System.Drawing.Point(729, 81);
            this.pictureBox_Illu.Name = "pictureBox_Illu";
            this.pictureBox_Illu.Size = new System.Drawing.Size(178, 176);
            this.pictureBox_Illu.TabIndex = 1;
            this.pictureBox_Illu.TabStop = false;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Name.Location = new System.Drawing.Point(641, 292);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(63, 25);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Name:";
            // 
            // label_Decription
            // 
            this.label_Decription.AutoSize = true;
            this.label_Decription.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Decription.Location = new System.Drawing.Point(606, 336);
            this.label_Decription.Name = "label_Decription";
            this.label_Decription.Size = new System.Drawing.Size(98, 25);
            this.label_Decription.TabIndex = 3;
            this.label_Decription.Text = "Decription:";
            // 
            // label_NameText
            // 
            this.label_NameText.AutoSize = true;
            this.label_NameText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NameText.Location = new System.Drawing.Point(710, 292);
            this.label_NameText.Name = "label_NameText";
            this.label_NameText.Size = new System.Drawing.Size(91, 25);
            this.label_NameText.TabIndex = 4;
            this.label_NameText.Text = "(Text here)";
            // 
            // label_DecripText
            // 
            this.label_DecripText.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DecripText.Location = new System.Drawing.Point(710, 336);
            this.label_DecripText.Name = "label_DecripText";
            this.label_DecripText.Size = new System.Drawing.Size(273, 222);
            this.label_DecripText.TabIndex = 5;
            this.label_DecripText.Text = "(Text here)";
            // 
            // textBox_Search
            // 
            this.textBox_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Search.Location = new System.Drawing.Point(12, 83);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(268, 23);
            this.textBox_Search.TabIndex = 6;
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(453, 81);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(81, 23);
            this.button_Reset.TabIndex = 8;
            this.button_Reset.Text = "Reset Filter";
            this.button_Reset.UseVisualStyleBackColor = true;
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
            this.button_Build.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Build.Location = new System.Drawing.Point(799, 12);
            this.button_Build.Name = "button_Build";
            this.button_Build.Size = new System.Drawing.Size(245, 52);
            this.button_Build.TabIndex = 10;
            this.button_Build.Text = "Start building you own PC";
            this.button_Build.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search by model name:";
            // 
            // listView_Main
            // 
            this.listView_Main.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView_Main.BackColor = System.Drawing.SystemColors.Window;
            this.listView_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_Main.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView_Main.GroupImageList = this.imageList_Group;
            listViewGroup1.CollapsedState = System.Windows.Forms.ListViewGroupCollapsedState.Expanded;
            listViewGroup1.Header = "Processors";
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
            listViewGroup6.Header = "Memory";
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
            listViewItem2.Group = listViewGroup8;
            listViewItem4.Group = listViewGroup6;
            listViewItem5.Group = listViewGroup5;
            listViewItem6.Group = listViewGroup4;
            listViewItem7.Group = listViewGroup4;
            listViewItem8.Group = listViewGroup3;
            listViewItem9.Group = listViewGroup3;
            listViewItem10.Group = listViewGroup8;
            listViewItem11.Group = listViewGroup9;
            listViewItem12.Group = listViewGroup9;
            listViewItem13.Group = listViewGroup1;
            listViewItem14.Group = listViewGroup1;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.Group = listViewGroup6;
            listViewItem16.Group = listViewGroup2;
            listViewItem17.Group = listViewGroup2;
            listViewItem18.Group = listViewGroup5;
            this.listView_Main.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18});
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Category:";
            // 
            // comboBox_Category
            // 
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
            "Power Supply"});
            this.comboBox_Category.Location = new System.Drawing.Point(286, 83);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(152, 23);
            this.comboBox_Category.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1056, 642);
            this.Controls.Add(this.listView_Main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Build);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.label_DecripText);
            this.Controls.Add(this.label_NameText);
            this.Controls.Add(this.label_Decription);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.pictureBox_Illu);
            this.Name = "MainForm";
            this.Text = "PC Builder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PictureBox pictureBox_Illu;
        private Label label_Name;
        private Label label_Decription;
        private Label label_NameText;
        private Label label_DecripText;
        private TextBox textBox_Search;
        private Button button_Reset;
        private Label label2;
        private Button button_Build;
        private Label label3;
        private ListView listView_Main;
        private ImageList imageList_MainListView;
        private ImageList imageList_Group;
        private Label label4;
        private ComboBox comboBox_Category;
    }
}