using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveStarHotal
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bookRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj= new Form1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void manageRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser obj = new ManageUser();
            obj.MdiParent = this;
            obj.Show();
        }

        private void manageCatagoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCatagories obj = new ManageCatagories();
            obj.MdiParent = this;
            obj.Show();
        }

        private void bookRoomToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BookRoom obj = new BookRoom();
            obj.MdiParent = this;
            obj.Show();
        }

        private void aboutUssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();   
            this.Hide();    
        }
    }
}
