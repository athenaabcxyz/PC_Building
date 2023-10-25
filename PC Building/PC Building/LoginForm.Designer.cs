namespace PC_Building
{
    partial class LoginForm
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
            tabControl1 = new TabControl();
            tabPage_login = new TabPage();
            button_login = new Button();
            label3 = new Label();
            textBox_password = new TextBox();
            label2 = new Label();
            label1 = new Label();
            textBox_username = new TextBox();
            tabPage_register = new TabPage();
            label7 = new Label();
            textBox_re_repass = new TextBox();
            label8 = new Label();
            textBox_re_pass = new TextBox();
            button_register = new Button();
            label4 = new Label();
            textBox_re_username = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox_customName = new TextBox();
            tabControl1.SuspendLayout();
            tabPage_login.SuspendLayout();
            tabPage_register.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage_login);
            tabControl1.Controls.Add(tabPage_register);
            tabControl1.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(397, 517);
            tabControl1.TabIndex = 0;
            // 
            // tabPage_login
            // 
            tabPage_login.Controls.Add(button_login);
            tabPage_login.Controls.Add(label3);
            tabPage_login.Controls.Add(textBox_password);
            tabPage_login.Controls.Add(label2);
            tabPage_login.Controls.Add(label1);
            tabPage_login.Controls.Add(textBox_username);
            tabPage_login.Font = new Font("Bahnschrift Condensed", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage_login.Location = new Point(4, 27);
            tabPage_login.Name = "tabPage_login";
            tabPage_login.Padding = new Padding(3);
            tabPage_login.Size = new Size(389, 486);
            tabPage_login.TabIndex = 0;
            tabPage_login.Text = "Log in";
            tabPage_login.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            button_login.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_login.Location = new Point(136, 278);
            button_login.Name = "button_login";
            button_login.Size = new Size(116, 46);
            button_login.TabIndex = 5;
            button_login.Text = "Confirm";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(74, 180);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // textBox_password
            // 
            textBox_password.BorderStyle = BorderStyle.FixedSingle;
            textBox_password.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_password.Location = new Point(156, 178);
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(165, 30);
            textBox_password.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(74, 123);
            label2.Name = "label2";
            label2.Size = new Size(76, 23);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 53);
            label1.Name = "label1";
            label1.Size = new Size(72, 33);
            label1.TabIndex = 1;
            label1.Text = "Log-In";
            // 
            // textBox_username
            // 
            textBox_username.BorderStyle = BorderStyle.FixedSingle;
            textBox_username.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_username.Location = new Point(156, 121);
            textBox_username.Name = "textBox_username";
            textBox_username.Size = new Size(165, 30);
            textBox_username.TabIndex = 0;
            // 
            // tabPage_register
            // 
            tabPage_register.Controls.Add(label7);
            tabPage_register.Controls.Add(textBox_re_repass);
            tabPage_register.Controls.Add(label8);
            tabPage_register.Controls.Add(textBox_re_pass);
            tabPage_register.Controls.Add(button_register);
            tabPage_register.Controls.Add(label4);
            tabPage_register.Controls.Add(textBox_re_username);
            tabPage_register.Controls.Add(label5);
            tabPage_register.Controls.Add(label6);
            tabPage_register.Controls.Add(textBox_customName);
            tabPage_register.Location = new Point(4, 27);
            tabPage_register.Name = "tabPage_register";
            tabPage_register.Padding = new Padding(3);
            tabPage_register.Size = new Size(389, 486);
            tabPage_register.TabIndex = 1;
            tabPage_register.Text = "Register";
            tabPage_register.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(18, 318);
            label7.Name = "label7";
            label7.Size = new Size(129, 23);
            label7.TabIndex = 16;
            label7.Text = "Re-type Password:";
            // 
            // textBox_re_repass
            // 
            textBox_re_repass.BorderStyle = BorderStyle.FixedSingle;
            textBox_re_repass.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_re_repass.Location = new Point(153, 316);
            textBox_re_repass.Name = "textBox_re_repass";
            textBox_re_repass.Size = new Size(186, 30);
            textBox_re_repass.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(71, 261);
            label8.Name = "label8";
            label8.Size = new Size(75, 23);
            label8.TabIndex = 14;
            label8.Text = "Password:";
            // 
            // textBox_re_pass
            // 
            textBox_re_pass.BorderStyle = BorderStyle.FixedSingle;
            textBox_re_pass.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_re_pass.Location = new Point(153, 259);
            textBox_re_pass.Name = "textBox_re_pass";
            textBox_re_pass.Size = new Size(186, 30);
            textBox_re_pass.TabIndex = 13;
            // 
            // button_register
            // 
            button_register.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_register.Location = new Point(133, 374);
            button_register.Name = "button_register";
            button_register.Size = new Size(116, 46);
            button_register.TabIndex = 12;
            button_register.Text = "Confirm";
            button_register.UseVisualStyleBackColor = true;
            button_register.Click += button_register_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(71, 206);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 11;
            label4.Text = "Username:";
            // 
            // textBox_re_username
            // 
            textBox_re_username.BorderStyle = BorderStyle.FixedSingle;
            textBox_re_username.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_re_username.Location = new Point(153, 204);
            textBox_re_username.Name = "textBox_re_username";
            textBox_re_username.Size = new Size(186, 30);
            textBox_re_username.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(50, 149);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 9;
            label5.Text = "Appear Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift Condensed", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(153, 79);
            label6.Name = "label6";
            label6.Size = new Size(81, 33);
            label6.TabIndex = 8;
            label6.Text = "Sign Up";
            // 
            // textBox_customName
            // 
            textBox_customName.BorderStyle = BorderStyle.FixedSingle;
            textBox_customName.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox_customName.Location = new Point(153, 147);
            textBox_customName.Name = "textBox_customName";
            textBox_customName.Size = new Size(186, 30);
            textBox_customName.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 517);
            Controls.Add(tabControl1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login and Register";
            tabControl1.ResumeLayout(false);
            tabPage_login.ResumeLayout(false);
            tabPage_login.PerformLayout();
            tabPage_register.ResumeLayout(false);
            tabPage_register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage_login;
        private Label label2;
        private Label label1;
        private TextBox textBox_username;
        private TabPage tabPage_register;
        private Label label3;
        private TextBox textBox_password;
        private Button button_login;
        private Label label7;
        private TextBox textBox_re_repass;
        private Label label8;
        private TextBox textBox_re_pass;
        private Button button_register;
        private Label label4;
        private TextBox textBox_re_username;
        private Label label5;
        private Label label6;
        private TextBox textBox_customName;
    }
}