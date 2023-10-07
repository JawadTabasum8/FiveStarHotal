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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (show_pass.Checked)
            {
                txt_password.UseSystemPasswordChar = false;

            }
            else if (show_pass.CheckState == CheckState.Unchecked)
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            String Query = "SELECT * FROM Tbl_manageUser WHERE UserName='" + txt_uname.Text + "'AND Password='" + txt_password.Text + "'";
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username And Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_uname.Clear();
                txt_password.Clear();
                txt_password.Focus();
            }
        }
    }
}
