namespace PC_Building
{
    partial class AddComponentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_component = new System.Windows.Forms.Label();
            this.comboBox_component = new System.Windows.Forms.ComboBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox_Detail = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding:";
            // 
            // label_component
            // 
            this.label_component.AutoSize = true;
            this.label_component.Location = new System.Drawing.Point(279, 28);
            this.label_component.Name = "label_component";
            this.label_component.Size = new System.Drawing.Size(55, 15);
            this.label_component.TabIndex = 1;
            this.label_component.Text = "Category";
            // 
            // comboBox_component
            // 
            this.comboBox_component.FormattingEnabled = true;
            this.comboBox_component.Location = new System.Drawing.Point(180, 243);
            this.comboBox_component.Name = "comboBox_component";
            this.comboBox_component.Size = new System.Drawing.Size(196, 23);
            this.comboBox_component.TabIndex = 2;
            this.comboBox_component.SelectedValueChanged += new System.EventHandler(this.comboBox_component_SelectedValueChanged);
            this.comboBox_component.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_component_KeyPress);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(212, 544);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(138, 52);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(180, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox_Detail
            // 
            this.richTextBox_Detail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_Detail.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox_Detail.Location = new System.Drawing.Point(100, 287);
            this.richTextBox_Detail.Name = "richTextBox_Detail";
            this.richTextBox_Detail.Size = new System.Drawing.Size(355, 233);
            this.richTextBox_Detail.TabIndex = 16;
            this.richTextBox_Detail.Text = "";
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 639);
            this.Controls.Add(this.richTextBox_Detail);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.comboBox_component);
            this.Controls.Add(this.label_component);
            this.Controls.Add(this.label1);
            this.Name = "AddComponentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Component";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label_component;
        private ComboBox comboBox_component;
        private Button button_confirm;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox_Detail;
    }
}