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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete this record", "Alert Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string Query = "DELETE FROM Tbl_addroom WHERE RoomName='" + cmb_Sdelete.Text+ "' ";
                SqlConnection con = new SqlConnection(MyConnection2.ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.tbl_addroomTableAdapter.Fill(this.fIVESTARDBDataSet1.Tbl_addroom);
            }
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet1.Tbl_addroom' table. You can move, or remove it, as needed.
            this.tbl_addroomTableAdapter.Fill(this.fIVESTARDBDataSet1.Tbl_addroom);

        }
    }
}
