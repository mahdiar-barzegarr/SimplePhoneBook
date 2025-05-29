using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Phones' table. You can move, or remove it, as needed.
            this.phonesTableAdapter.Fill(this.database1DataSet.Phones);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(name.Text != "" && phone.Text != "")
            {
                phonesTableAdapter.InsertQuery1(name.Text, phone.Text);
                this.phonesTableAdapter.Fill(this.database1DataSet.Phones);
                MessageBox.Show("New Information Appended Succesfull :)");
                name.Text = "";
                phone.Text = "";
            }
            else
            {
                MessageBox.Show("At First Please Fill Inputs !!");
            }

        }

        private void search_Click(object sender, EventArgs e)
        {
            if(search_input.Text == "")
            {
                this.phonesTableAdapter.Fill(this.database1DataSet.Phones);
            }
            else
            {
                this.phonesTableAdapter.FillBy(this.database1DataSet.Phones, search_input.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(delete_input.Text != "")
            {
                phonesTableAdapter.DeleteQuery(Convert.ToInt32(delete_input.Text));
                this.phonesTableAdapter.Fill(this.database1DataSet.Phones);
                MessageBox.Show("Row Deleted Succesfull :)");
                delete_input.Text = "";
            }
            else
            {
                MessageBox.Show("At First Please Select A Row For Delete !");
            }

        }

        private void delete_input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Just Number (ID) !!!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                var id = row.Cells["IdCol"].Value;
                var name = row.Cells["NameCol"].Value;
                var phone = row.Cells["PhoneCol"].Value;
                delete_input.Text = id.ToString();
                Id_Update.Text = id.ToString();
                Name_Update.Text = name.ToString();
                Phone_Update.Text = phone.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(Name_Update.Text != "" && Phone_Update.Text != "")
            {
                this.phonesTableAdapter.UpdateQuery(Name_Update.Text, Phone_Update.Text, Convert.ToInt32(Id_Update.Text));
                this.phonesTableAdapter.Fill(this.database1DataSet.Phones);
                Id_Update.Text = "";
                Name_Update.Text = "";
                Phone_Update.Text = "";
                MessageBox.Show("Row Updated Successfull :)");
            }
            else
            {
                MessageBox.Show("Please Enter New Value For Fields !!");
            }
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Just Number (ID) !!!");
            }
        }

        private void Phone_Update_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Just Number (ID) !!!");
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Phone_Label_Click(object sender, EventArgs e)
        {

        }

        private void Name_Label_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
