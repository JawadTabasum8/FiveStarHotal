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
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet14.Tbl_manageUser' table. You can move, or remove it, as needed.
            this.tbl_manageUserTableAdapter1.Fill(this.fIVESTARDBDataSet14.Tbl_manageUser);
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet13.Tbl_manageUser' table. You can move, or remove it, as needed.
            this.tbl_manageUserTableAdapter.Fill(this.fIVESTARDBDataSet13.Tbl_manageUser);



        }

       

        

        private void btn_update_Click(object sender, EventArgs e)
        {

            string Query = "UPDATE Tbl_manageUser SET Id='" + txt_id.Text + "', Phone='" + txt_phone.Text + "', Gender='" + cmb_gender.Text + "',Address='" + txt_address + "' WHERE UserName='" + cmb_uname.Text + "' ";
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Update Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_manageUserTableAdapter.Fill(this.fIVESTARDBDataSet13.Tbl_manageUser);
        }



        private void cmb_uname_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Query = "SELECT * From Tbl_manageUser WHERE UserName='" + cmb_uname.SelectedValue + "' ";
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_id.Text = dr["Id"].ToString();
                txt_phone.Text = dr["Phone"].ToString();
                cmb_gender.Text = dr["Gender"].ToString();
                txt_address.Text = dr["Address"].ToString();
                txt_password.Text = dr["Password"].ToString();

            }
        }
    }
}
