using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PC_Building
{
    public partial class AddProduct : Form
    {
        bool IsEditing = false;
        string oldModelName = "";
        string strCon = ConfigurationManager.ConnectionStrings["CaseBuilder"].ConnectionString;
        SqlConnection sqlCon = null;
        public AddProduct()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void pictureBox_motherboard_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter for image files.
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.bmp)|*.jpg;*.jpeg;*.bmp";

            // Show the OpenFileDialog control.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Load the image file.
                Image image = Image.FromFile(openFileDialog.FileName);

                // Display the image in a PictureBox control.
                pictureBox_motherboard.Image = image;
            }
        }

        public void LoadEditItem(string model, string category)
        {
            comboBox_component.Text = category;
            IsEditing = true;
            oldModelName = model;
            sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            SqlCommand sqlCmd;
            SqlDataAdapter Adapter = new SqlDataAdapter();
            sqlCmd = sqlCon.CreateCommand();
            DataTable Table = new DataTable();
            sqlCmd.CommandText = "Select * from [" + category + "] where Model = '" + model + "'";
            Adapter.SelectCommand = sqlCmd;
            Adapter.Fill(Table);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                listView1.Items[i].SubItems[1].Text = Table.Rows[0][i].ToString();
            }
            pictureBox_motherboard.Image = Image.FromFile(@"PC_Builder_Image\" + category + @"\" + model + ".jpg");
        }

        public void LoadInfo(string category)
        {
            listView1.Items.Clear();
            ListViewItem Item;
            switch (category)
            {
                case "Processor":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Core";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Thread";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Socket Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory Speed";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Base Speed";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Turbo Speed";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Max Power Consumption";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "Motherboard":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Chipset";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Form Factor";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Socket Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory Slots";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory Speed";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Storage Expansion";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Multi-GPU Support";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price ($)";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "CPU Cooler":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Fan RPM";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Noise Level";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Color";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "Graphic Card":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Memory Interface";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Length";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Interface";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Chipset";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Max Power Consumption";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "Power Suppy":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Power";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Efficiency";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Color";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "RAM":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "RAM Size";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Quantity";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "RAM Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "RAM Speed";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "Storage":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Capacity";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "RPM";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Interface";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Cache Memory";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Form Factor";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "Case":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Side Panel";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Carbinet Type";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Color";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Motherboard Support";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Max GPU Length";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "CPU Cooler Height";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Supported PSU Size";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    break;
                case "Case Cooler":
                    Item = new ListViewItem();
                    Item.Text = "Model";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Brand";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Fan RPM";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Air Flow";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Price";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    Item.Text = "Amazon URL";
                    Item.SubItems.Add("");
                    listView1.Items.Add(Item);
                    Item = new ListViewItem();
                    break;
            }
        }
        public event EventHandler updateForm;
        private void comboBox_component_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInfo(comboBox_component.Text);
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (String.IsNullOrEmpty(listView1.Items[i].SubItems[1].Text))
                {
                    DialogResult result = MessageBox.Show("Your product info is missing something. Do you still want to save this product?", "Notification", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        return;
                    }
                    break;
                }
            }
            if (IsEditing)
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                SqlCommand sqlCmd;
                sqlCmd = sqlCon.CreateCommand();
                sqlCmd.CommandText = "Update [" + comboBox_component.Text + "] set ";
                for (int i = 0; i < listView1.Items.Count; i++)
                {
                    sqlCmd.CommandText += "[" + listView1.Items[i].Text + "] = '" + listView1.Items[i].SubItems[1].Text + "'";
                    if (i != listView1.Items.Count - 1)
                    {
                        sqlCmd.CommandText += ", ";
                    }
                    else
                    {
                        sqlCmd.CommandText += " ";
                    }
                }
                sqlCmd.CommandText += "where Model = '" + oldModelName + "'";
                sqlCmd.ExecuteNonQuery();
                updateForm(this, new EventArgs());
                this.Close();
            }
            else
            {
                sqlCon = new SqlConnection(strCon);
                sqlCon.Open();
                SqlCommand sqlCmd;
                SqlDataAdapter Adapter = new SqlDataAdapter();
                sqlCmd = sqlCon.CreateCommand();
                DataTable Table = new DataTable();
                sqlCmd.CommandText = "Select Model from [" + comboBox_component.Text + "]";
                Adapter.SelectCommand = sqlCmd;
                Adapter.Fill(Table);
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    if (listView1.Items[0].SubItems[1].Text == Table.Rows[i][0].ToString())
                    {
                        DialogResult result = MessageBox.Show("This model is already existed in the database. Do you want to overwrite its property?", "Notification", MessageBoxButtons.YesNo);
                        if (result == DialogResult.No)
                        {
                            return;
                        }
                        else
                        {
                            sqlCmd.CommandText = "Update [" + comboBox_component.Text + "] set ";
                            for (int k = 1; k < listView1.Items.Count; k++)
                            {
                                sqlCmd.CommandText += "[" + listView1.Items[k].Text + "] = '" + listView1.Items[k].SubItems[1].Text + "'";
                                if (k != listView1.Items.Count - 1)
                                {
                                    sqlCmd.CommandText += ", ";
                                }
                                else
                                {
                                    sqlCmd.CommandText += " ";
                                }
                            }
                            sqlCmd.CommandText += "where Model = '" + listView1.Items[0].Text + "'";
                            sqlCmd.ExecuteNonQuery();
                            updateForm(this, new EventArgs());
                            this.Close();
                        }
                        break;
                    }

                }
                sqlCmd.CommandText = "insert into [" + comboBox_component.Text + "] values(";
                for (int k = 0; k < listView1.Items.Count; k++)
                {
                    sqlCmd.CommandText += "'" + listView1.Items[k].SubItems[1].Text + "'";
                    if (k != listView1.Items.Count - 1)
                    {
                        sqlCmd.CommandText += ", ";
                    }
                    else
                    {
                        sqlCmd.CommandText += ") ";
                    }
                }
                sqlCmd.ExecuteNonQuery();
                if (pictureBox_motherboard.Image != null)
                {
                    pictureBox_motherboard.Image.Save(@"\PC_Builder_Image\" + comboBox_component.Text + @"\" + listView1.Items[0].Text + ".jpg");
                }
                updateForm(this, new EventArgs());
                this.Close();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            var listViewItem = listView1.SelectedItems[0];

            // Display a dialog box to allow the user to edit the subitem
            Form dialog = new Form();
            dialog.FormBorderStyle = FormBorderStyle.FixedSingle;
            dialog.MaximizeBox = false;

            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();

            textBox.Text = listViewItem.SubItems[1].Text;
            textBox.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            dialog.Width = textBox.Width + 10;
            dialog.Height = textBox.Height * 3 + 6;
            dialog.Controls.Add(textBox);
            dialog.StartPosition = FormStartPosition.Manual;
            dialog.Location = Cursor.Position;
            dialog.ShowDialog();

            // Save the changes to the underlying data source
            listViewItem.SubItems[1].Text = textBox.Text;
        }
    }
}
