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
            this.dataGridView_Product = new System.Windows.Forms.DataGridView();
            this.pictureBox_Illu = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Decription = new System.Windows.Forms.Label();
            this.label_NameText = new System.Windows.Forms.Label();
            this.label_DecripText = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.button_Reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Build = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Product
            // 
            this.dataGridView_Product.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_Product.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_Product.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Product.Location = new System.Drawing.Point(12, 121);
            this.dataGridView_Product.Name = "dataGridView_Product";
            this.dataGridView_Product.RowTemplate.Height = 25;
            this.dataGridView_Product.Size = new System.Drawing.Size(522, 509);
            this.dataGridView_Product.TabIndex = 0;
            // 
            // pictureBox_Illu
            // 
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
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(286, 83);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(152, 23);
            this.comboBox_Category.TabIndex = 7;
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
            this.label2.Text = "Welcome to PC Building";
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
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search:";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1056, 642);
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
            this.Controls.Add(this.dataGridView_Product);
            this.Name = "MainForm";
            this.Text = "PC Building";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Illu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_Product;
        private PictureBox pictureBox_Illu;
        private Label label_Name;
        private Label label_Decription;
        private Label label_NameText;
        private Label label_DecripText;
        private TextBox textBox_Search;
        private ComboBox comboBox_Category;
        private Button button_Reset;
        private Label label2;
        private Button button_Build;
        private Label label3;
        private Label label4;
    }
}