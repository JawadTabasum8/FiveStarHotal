namespace FiveStarHotal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCatagoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookRoomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRoomToolStripMenuItem,
            this.manageCatagoriesToolStripMenuItem,
            this.bookRoomToolStripMenuItem,
            this.bookRoomToolStripMenuItem1,
            this.aboutUssToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageRoomToolStripMenuItem
            // 
            this.manageRoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteUserToolStripMenuItem});
            this.manageRoomToolStripMenuItem.Name = "manageRoomToolStripMenuItem";
            this.manageRoomToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.manageRoomToolStripMenuItem.Text = "Manage User";
            this.manageRoomToolStripMenuItem.Click += new System.EventHandler(this.manageRoomToolStripMenuItem_Click);
            // 
            // deleteUserToolStripMenuItem
            // 
            this.deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            this.deleteUserToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteUserToolStripMenuItem.Text = "Delete User";
            // 
            // manageCatagoriesToolStripMenuItem
            // 
            this.manageCatagoriesToolStripMenuItem.Name = "manageCatagoriesToolStripMenuItem";
            this.manageCatagoriesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.manageCatagoriesToolStripMenuItem.Text = "Manage Catagories";
            this.manageCatagoriesToolStripMenuItem.Click += new System.EventHandler(this.manageCatagoriesToolStripMenuItem_Click);
            // 
            // bookRoomToolStripMenuItem
            // 
            this.bookRoomToolStripMenuItem.Name = "bookRoomToolStripMenuItem";
            this.bookRoomToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.bookRoomToolStripMenuItem.Text = "Manage Room";
            this.bookRoomToolStripMenuItem.Click += new System.EventHandler(this.bookRoomToolStripMenuItem_Click);
            // 
            // bookRoomToolStripMenuItem1
            // 
            this.bookRoomToolStripMenuItem1.Name = "bookRoomToolStripMenuItem1";
            this.bookRoomToolStripMenuItem1.Size = new System.Drawing.Size(81, 20);
            this.bookRoomToolStripMenuItem1.Text = "Book Room";
            this.bookRoomToolStripMenuItem1.Click += new System.EventHandler(this.bookRoomToolStripMenuItem1_Click);
            // 
            // aboutUssToolStripMenuItem
            // 
            this.aboutUssToolStripMenuItem.Name = "aboutUssToolStripMenuItem";
            this.aboutUssToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.aboutUssToolStripMenuItem.Text = "Logout";
            this.aboutUssToolStripMenuItem.Click += new System.EventHandler(this.aboutUssToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCatagoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookRoomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutUssToolStripMenuItem;
    }
}