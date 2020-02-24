using Contacts.contactClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }
        contactClass c = new contactClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get the value from the input fields
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.ContactNo = textBoxContactNo.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = comboBoxGender.Text;

            //inserting data into db using the created method
            bool success = c.Insert(c);
            if(success == true)
            {
                //successfully inserted
                MessageBox.Show("New contact has been inserted");
                //call the clear method
                Clear();
            }
            else
            {
                //failed to add contact
                MessageBox.Show("Failed to add new contact. Try again.");
            }
            //load data in the box
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            //load data in the box
            DataTable dt = c.Select();
            dgvContactList.DataSource = dt;
        }
        //clear all the fields
        public void Clear()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxContactNo.Text = "";
            textBoxAddress.Text = "";
            comboBoxGender.Text = "";
            textBoxContactID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            c.ContactID = int.Parse(textBoxContactID.Text);
            c.FirstName = textBoxFirstName.Text;
            c.LastName = textBoxLastName.Text;
            c.Address = textBoxAddress.Text;
            c.Gender = comboBoxGender.Text;
            //update data in db
            bool success = c.Update(c);
            if (success == true)
            {
                //updated successully
                MessageBox.Show("Contact has been succesfully updated!");
                //load data in the box
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //call the clear method
                Clear();
            }
            else
            {
                //failed to update
                MessageBox.Show("Failed to update contact.");
                //load data in the box
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
            }
        }

        private void dgvContactList_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get the data from data grid view and load it to the respective textboxes
            //identify the row on which mouse was clicked
            int rowIndex = e.RowIndex;
            textBoxContactID.Text = dgvContactList.Rows[rowIndex].Cells[0].Value.ToString();
            textBoxFirstName.Text = dgvContactList.Rows[rowIndex].Cells[1].Value.ToString();
            textBoxLastName.Text = dgvContactList.Rows[rowIndex].Cells[2].Value.ToString();
            textBoxContactNo.Text = dgvContactList.Rows[rowIndex].Cells[3].Value.ToString();
            textBoxAddress.Text = dgvContactList.Rows[rowIndex].Cells[4].Value.ToString();
            comboBoxGender.Text = dgvContactList.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call clear method
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //get data from the textboxes
            c.ContactID = Convert.ToInt32(textBoxContactID.Text);
            bool success = c.Delete(c);
            if (success == true)
            {
                //successfully deleted
                MessageBox.Show("Contact was successfully deleted!");
                //refresh data gridview
                //load data in the box
                DataTable dt = c.Select();
                dgvContactList.DataSource = dt;
                //call the clear method
                Clear();
            }
            else
            {
                //failed to delete
                MessageBox.Show("Failed to delete the contact.");
            }
        }
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from text box
            string keyword = textBoxSearch.Text;
            SqlConnection conn = new SqlConnection(myconnstring);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvContactList.DataSource = dt; 
        }
    }
}
