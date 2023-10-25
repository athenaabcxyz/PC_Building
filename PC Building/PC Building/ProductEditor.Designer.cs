namespace PC_Building
{
    partial class ProductEditor
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "asd", "asdas" }, -1);
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button_delete = new Button();
            button_edit = new Button();
            button_add = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(-1, -1);
            listView1.Name = "listView1";
            listView1.Size = new Size(452, 463);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Product name";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Product category";
            columnHeader2.Width = 225;
            // 
            // button_delete
            // 
            button_delete.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.Location = new Point(290, 468);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(98, 35);
            button_delete.TabIndex = 5;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = true;
            button_delete.Click += button_delete_Click;
            // 
            // button_edit
            // 
            button_edit.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_edit.Location = new Point(186, 468);
            button_edit.Name = "button_edit";
            button_edit.Size = new Size(98, 35);
            button_edit.TabIndex = 4;
            button_edit.Text = "Edit";
            button_edit.UseVisualStyleBackColor = true;
            button_edit.Click += button_edit_Click;
            // 
            // button_add
            // 
            button_add.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_add.Location = new Point(82, 468);
            button_add.Name = "button_add";
            button_add.Size = new Size(98, 35);
            button_add.TabIndex = 7;
            button_add.Text = "Add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // ProductEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 518);
            Controls.Add(button_add);
            Controls.Add(listView1);
            Controls.Add(button_delete);
            Controls.Add(button_edit);
            Name = "ProductEditor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit Products";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Button button_delete;
        private Button button_edit;
        private Button button_add;
    }
}