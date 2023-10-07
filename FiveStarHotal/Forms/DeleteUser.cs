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
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet15.Tbl_manageUser' table. You can move, or remove it, as needed.
            this.tbl_manageUserTableAdapter.Fill(this.fIVESTARDBDataSet15.Tbl_manageUser);
          
            

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this record", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string Query = "DELETE FROM Tbl_manageUser WHERE UserName='" + cmb_sdelete.Text + "' ";
                SqlConnection con = new SqlConnection(MyConnection2.ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
        }

        private void cmb_sdelete_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
