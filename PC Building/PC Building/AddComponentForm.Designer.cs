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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adding:";
            // 
            // label_component
            // 
            this.label_component.AutoSize = true;
            this.label_component.Location = new System.Drawing.Point(138, 44);
            this.label_component.Name = "label_component";
            this.label_component.Size = new System.Drawing.Size(55, 15);
            this.label_component.TabIndex = 1;
            this.label_component.Text = "Category";
            // 
            // comboBox_component
            // 
            this.comboBox_component.FormattingEnabled = true;
            this.comboBox_component.Location = new System.Drawing.Point(51, 72);
            this.comboBox_component.Name = "comboBox_component";
            this.comboBox_component.Size = new System.Drawing.Size(173, 23);
            this.comboBox_component.TabIndex = 2;
            this.comboBox_component.TextChanged += new System.EventHandler(this.comboBox_component_TextChanged);
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(100, 113);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 3;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            // 
            // AddComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 179);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.comboBox_component);
            this.Controls.Add(this.label_component);
            this.Controls.Add(this.label1);
            this.Name = "AddComponentForm";
            this.Text = "Add Component";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label_component;
        private ComboBox comboBox_component;
        private Button button_confirm;
    }
}