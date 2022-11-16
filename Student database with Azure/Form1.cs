using System;
using Student_database_with_Azure;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_database_with_Azure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CRUD passedalc= new CRUD();
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            int a = passedalc.Delete(id);
            if (a == 0)
            {
                MessageBox.Show("Delete has successfully");
            }
            else
                MessageBox.Show("Delete has not successfully");
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            int a = passedalc.Insert(txtname.Text, txtsurname.Text, txtpatry.Text, txtbirth.Text, txtaddress.Text, txtemail.Text, cmbgender.Text, cmbstatus.Text);
            if (a == 1)
            {
                MessageBox.Show("Insert has successfully");
            }
            else
                MessageBox.Show("Insert has nor successfully");

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtid.Text);
            int a = passedalc.Update(id, txtname.Text, txtsurname.Text, txtpatry.Text, txtbirth.Text, txtaddress.Text, txtemail.Text, cmbgender.Text, cmbstatus.Text);
            if (a == 1)
            {
                MessageBox.Show("Update has successfully");
            }
            else
                MessageBox.Show("Update has not successfully");
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = passedalc.Select();
        }
    }
}
