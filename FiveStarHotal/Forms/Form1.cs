using FiveStarHotal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FiveStarHotal.Classes.MyConnection;

namespace FiveStarHotal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_addroom VALUES('"+txt_id.Text+"','" + txt_rname.Text + "','" + txt_catagories.Text + "','" + txt_location.Text + "','" + txt_cost.Text + "','" + cmb_status.Text + "') ", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_addroomTableAdapter.Fill(this.fIVESTARDBDataSet.Tbl_addroom);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet.Tbl_addroom' table. You can move, or remove it, as needed.
            this.tbl_addroomTableAdapter.Fill(this.fIVESTARDBDataSet.Tbl_addroom);

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete dell = new Delete();
            dell.ShowDialog();
            this.tbl_addroomTableAdapter.Fill(this.fIVESTARDBDataSet.Tbl_addroom);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditRoom er = new EditRoom();
            er.ShowDialog();
        }
    }
}
