namespace PC_Building
{
    partial class LiveChat
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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            richTextBox_chatlist = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 866);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(310, 103);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(66, 830);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 830);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // button1
            // 
            button1.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(223, 830);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 4;
            button1.Text = "Send";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(richTextBox_chatlist);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 809);
            panel1.TabIndex = 5;
            // 
            // richTextBox_chatlist
            // 
            richTextBox_chatlist.BackColor = SystemColors.Window;
            richTextBox_chatlist.BorderStyle = BorderStyle.None;
            richTextBox_chatlist.Location = new Point(12, 10);
            richTextBox_chatlist.Name = "richTextBox_chatlist";
            richTextBox_chatlist.ReadOnly = true;
            richTextBox_chatlist.Size = new Size(310, 789);
            richTextBox_chatlist.TabIndex = 6;
            richTextBox_chatlist.Text = "";
            richTextBox_chatlist.TextChanged += richTextBox_chatlist_TextChanged;
            // 
            // LiveChat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 981);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Location = new Point(1580, 0);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LiveChat";
            StartPosition = FormStartPosition.Manual;
            Text = "LiveChat";
            FormClosing += LiveChat_FormClosing;
            FormClosed += LiveChat_FormClosed;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Panel panel1;
        private RichTextBox richTextBox_chatlist;
    }
}