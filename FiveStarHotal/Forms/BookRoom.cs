using FiveStarHotal.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FiveStarHotal.Classes.MyConnection;

namespace FiveStarHotal
{
    public partial class BookRoom : Form
    {
        public BookRoom()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void btn_broom_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Tbl_broom VALUES ('" + txt_roon.Text + "','" + dateTime_in.Text + "','" + dateTime_out.Text + "','" + txt_amount.Text +"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_broomTableAdapter.Fill(this.fIVESTARDBDataSet4.Tbl_broom);

        }

        private void BookRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet4.Tbl_broom' table. You can move, or remove it, as needed.
            this.tbl_broomTableAdapter.Fill(this.fIVESTARDBDataSet4.Tbl_broom);

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
             clear();
          
        }
        private void clear()
        {
            txt_amount.Clear();
            txt_roon.Clear();   
           
        }
    }
}
