namespace PC_Building
{
    partial class AddProduct
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "asd", "ssss" }, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProduct));
            button_confirm = new Button();
            comboBox_component = new ComboBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            label1 = new Label();
            pictureBox_motherboard = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_motherboard).BeginInit();
            SuspendLayout();
            // 
            // button_confirm
            // 
            button_confirm.Font = new Font("Bahnschrift", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_confirm.Location = new Point(211, 555);
            button_confirm.Name = "button_confirm";
            button_confirm.Size = new Size(138, 52);
            button_confirm.TabIndex = 19;
            button_confirm.Text = "Confirm";
            button_confirm.UseVisualStyleBackColor = true;
            button_confirm.Click += button_confirm_Click;
            // 
            // comboBox_component
            // 
            comboBox_component.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox_component.FormattingEnabled = true;
            comboBox_component.Items.AddRange(new object[] { "Processor", "Motherboard", "CPU Cooler", "Case Cooler", "Graphic Card", "RAM", "Storage", "Case", "Power Supply" });
            comboBox_component.Location = new Point(179, 242);
            comboBox_component.Name = "comboBox_component";
            comboBox_component.Size = new Size(196, 22);
            comboBox_component.TabIndex = 18;
            comboBox_component.SelectedIndexChanged += comboBox_component_SelectedIndexChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(50, 298);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(452, 253);
            listView1.TabIndex = 21;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Properties";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Value";
            columnHeader2.Width = 225;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 12.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(239, 203);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 22;
            label1.Text = "Category";
            // 
            // pictureBox_motherboard
            // 
            pictureBox_motherboard.BackgroundImage = (Image)resources.GetObject("pictureBox_motherboard.BackgroundImage");
            pictureBox_motherboard.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox_motherboard.BorderStyle = BorderStyle.FixedSingle;
            pictureBox_motherboard.Location = new Point(198, 23);
            pictureBox_motherboard.Name = "pictureBox_motherboard";
            pictureBox_motherboard.Size = new Size(160, 160);
            pictureBox_motherboard.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_motherboard.TabIndex = 35;
            pictureBox_motherboard.TabStop = false;
            pictureBox_motherboard.Click += pictureBox_motherboard_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 639);
            Controls.Add(pictureBox_motherboard);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(button_confirm);
            Controls.Add(comboBox_component);
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add and Edit";
            ((System.ComponentModel.ISupportInitialize)pictureBox_motherboard).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_confirm;
        private ComboBox comboBox_component;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private Label label1;
        private PictureBox pictureBox_motherboard;
        public ColumnHeader columnHeader2;
    }
}