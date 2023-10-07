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
    public partial class EditRoom : Form
    {
        public EditRoom()
        {
            InitializeComponent();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
          
            
                string Query = "UPDATE Tbl_addroom SET Catagories='" + txt_catagories.Text + "', Location='" + txt_location.Text + "', RoomCost='" + txt_cost.Text + "', Status='"+cmb_status.Text+ "' WHERE RoomName='" + cmb_rname.Text + "' ";
                SqlConnection con = new SqlConnection(MyConnection2.ConString);
                con.Open();
                SqlCommand cmd = new SqlCommand(Query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.tbl_addroomTableAdapter1.Fill(this.fIVESTARDBDataSet2.Tbl_addroom);



        }

        private void EditRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fIVESTARDBDataSet2.Tbl_addroom' table. You can move, or remove it, as needed.
            this.tbl_addroomTableAdapter1.Fill(this.fIVESTARDBDataSet2.Tbl_addroom);

        }

        private void cmb_rname_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Query = "SELECT * From Tbl_addroom WHERE RoomName='" + cmb_rname.Text + "'";
            SqlConnection con = new SqlConnection(MyConnection2.ConString);
            con.Open();
            SqlCommand cmd = new SqlCommand(Query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_id.Text = dr["Id"].ToString();
                txt_catagories.Text = dr["Catagories"].ToString();
                txt_cost.Text = dr["RoomCost"].ToString();
                txt_location.Text = dr["Location"].ToString();
                cmb_status.Text = dr["Status"].ToString();
                this.tbl_addroomTableAdapter1.Fill(this.fIVESTARDBDataSet2.Tbl_addroom);
            }

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
