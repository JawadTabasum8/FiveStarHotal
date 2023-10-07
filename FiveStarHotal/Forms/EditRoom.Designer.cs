namespace FiveStarHotal
{
    partial class EditRoom
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
            this.components = new System.ComponentModel.Container();
            this.tbl_addroomTableAdapter = new FiveStarHotal.FIVESTARDBDataSetTableAdapters.Tbl_addroomTableAdapter();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.fIVESTARDBDataSet = new FiveStarHotal.FIVESTARDBDataSet();
            this.tbladdroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_catagories = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_rname = new System.Windows.Forms.ComboBox();
            this.tbladdroomBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet2 = new FiveStarHotal.FIVESTARDBDataSet2();
            this.tbl_addroomTableAdapter1 = new FiveStarHotal.FIVESTARDBDataSet2TableAdapters.Tbl_addroomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_addroomTableAdapter
            // 
            this.tbl_addroomTableAdapter.ClearBeforeFill = true;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(133, 99);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(211, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.TabStop = false;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // fIVESTARDBDataSet
            // 
            this.fIVESTARDBDataSet.DataSetName = "FIVESTARDBDataSet";
            this.fIVESTARDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbladdroomBindingSource
            // 
            this.tbladdroomBindingSource.DataMember = "Tbl_addroom";
            this.tbladdroomBindingSource.DataSource = this.fIVESTARDBDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Id:";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(133, 332);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(133, 45);
            this.btn_edit.TabIndex = 7;
            this.btn_edit.Text = "Update";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Avaiable",
            "Booked"});
            this.cmb_status.Location = new System.Drawing.Point(133, 293);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(211, 21);
            this.cmb_status.TabIndex = 6;
            this.cmb_status.TabStop = false;
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(133, 252);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(211, 20);
            this.txt_cost.TabIndex = 5;
            this.txt_cost.TabStop = false;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(133, 215);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(211, 20);
            this.txt_location.TabIndex = 4;
            this.txt_location.TabStop = false;
            // 
            // txt_catagories
            // 
            this.txt_catagories.Location = new System.Drawing.Point(133, 176);
            this.txt_catagories.Name = "txt_catagories";
            this.txt_catagories.Size = new System.Drawing.Size(211, 20);
            this.txt_catagories.TabIndex = 3;
            this.txt_catagories.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Room Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Catagories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Room Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 39);
            this.panel2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(267, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Five Star Hotel";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(115, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 33);
            this.label.TabIndex = 5;
            this.label.Text = "Edit Room";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(406, 71);
            this.panel1.TabIndex = 21;
            // 
            // cmb_rname
            // 
            this.cmb_rname.DataSource = this.tbladdroomBindingSource1;
            this.cmb_rname.DisplayMember = "RoomName";
            this.cmb_rname.FormattingEnabled = true;
            this.cmb_rname.Location = new System.Drawing.Point(133, 138);
            this.cmb_rname.Name = "cmb_rname";
            this.cmb_rname.Size = new System.Drawing.Size(211, 21);
            this.cmb_rname.TabIndex = 2;
            this.cmb_rname.TabStop = false;
            this.cmb_rname.ValueMember = "RoomName";
            this.cmb_rname.SelectedIndexChanged += new System.EventHandler(this.cmb_rname_SelectedIndexChanged);
            // 
            // tbladdroomBindingSource1
            // 
            this.tbladdroomBindingSource1.DataMember = "Tbl_addroom";
            this.tbladdroomBindingSource1.DataSource = this.fIVESTARDBDataSet2;
            // 
            // fIVESTARDBDataSet2
            // 
            this.fIVESTARDBDataSet2.DataSetName = "FIVESTARDBDataSet2";
            this.fIVESTARDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_addroomTableAdapter1
            // 
            this.tbl_addroomTableAdapter1.ClearBeforeFill = true;
            // 
            // EditRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.cmb_rname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_catagories);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EditRoom";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRoom";
            this.Load += new System.EventHandler(this.EditRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FIVESTARDBDataSetTableAdapters.Tbl_addroomTableAdapter tbl_addroomTableAdapter;
        private System.Windows.Forms.TextBox txt_id;
        private FIVESTARDBDataSet fIVESTARDBDataSet;
        private System.Windows.Forms.BindingSource tbladdroomBindingSource;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_catagories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_rname;
        private FIVESTARDBDataSet2 fIVESTARDBDataSet2;
        private System.Windows.Forms.BindingSource tbladdroomBindingSource1;
        private FIVESTARDBDataSet2TableAdapters.Tbl_addroomTableAdapter tbl_addroomTableAdapter1;
    }
}