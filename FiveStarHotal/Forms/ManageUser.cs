using FiveStarHotal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FiveStarHotal.Classes.MyConnection;

namespace FiveStarHotal
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet12.Tbl_manageUser' table. You can move, or remove it, as needed.
            this.tbl_manageUserTableAdapter.Fill(this.fIVESTARDBDataSet12.Tbl_manageUser);
          

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_manageUser VALUES('" + txt_id.Text + "','" + txt_uname.Text + "','" + txt_phone.Text + "','" + cmb_gender.Text + "','" + txt_address.Text + "','" + txt_password.Text + "') ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_manageUserTableAdapter.Fill(this.fIVESTARDBDataSet12.Tbl_manageUser);

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditUser eu = new EditUser();
            eu.ShowDialog();
        }

        private void dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            DeleteUser dell = new DeleteUser();
            dell.ShowDialog();
        }
    }
}
