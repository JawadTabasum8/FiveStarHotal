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
    public partial class ManageCatagories : Form
    {
        public ManageCatagories()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ManageCatagories_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet16.Tbl_manageCatafories' table. You can move, or remove it, as needed.
            this.tbl_manageCataforiesTableAdapter.Fill(this.fIVESTARDBDataSet16.Tbl_manageCatafories);
           
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteCatagories dell = new DeleteCatagories();
            dell.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_manageCatafories VALUES ('" + txt_cname.Text + "','" + txt_remarks.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_manageCataforiesTableAdapter.Fill(this.fIVESTARDBDataSet16.Tbl_manageCatafories);
            txt_cname.Clear();
            txt_remarks.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {

        }
    }
}
