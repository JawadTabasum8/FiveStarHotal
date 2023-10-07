namespace FiveStarHotal
{
    partial class EditUser
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
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.cmb_gender = new System.Windows.Forms.ComboBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_uname = new System.Windows.Forms.ComboBox();
            this.tblmanageUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet14 = new FiveStarHotal.FIVESTARDBDataSet14();
            this.tblmanageUserBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_manageUserTableAdapter2 = new FiveStarHotal.FIVESTARDBDataSet8TableAdapters.Tbl_manageUserTableAdapter();
            this.dg_eu = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmanageUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet13 = new FiveStarHotal.FIVESTARDBDataSet13();
            this.tbl_manageUserTableAdapter = new FiveStarHotal.FIVESTARDBDataSet13TableAdapters.Tbl_manageUserTableAdapter();
            this.tbl_manageUserTableAdapter1 = new FiveStarHotal.FIVESTARDBDataSet14TableAdapters.Tbl_manageUserTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet13)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(105, 140);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(156, 20);
            this.txt_id.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Id:";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(70, 323);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(135, 34);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cmb_gender
            // 
            this.cmb_gender.FormattingEnabled = true;
            this.cmb_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_gender.Location = new System.Drawing.Point(105, 211);
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(156, 21);
            this.cmb_gender.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(105, 279);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(156, 20);
            this.txt_password.TabIndex = 6;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(105, 247);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(156, 20);
            this.txt_address.TabIndex = 5;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(105, 176);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(154, 20);
            this.txt_phone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "User Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 39);
            this.panel2.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(671, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Five Star Hotel";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(328, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 33);
            this.label.TabIndex = 5;
            this.label.Text = "Edit User";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 71);
            this.panel1.TabIndex = 39;
            // 
            // cmb_uname
            // 
            this.cmb_uname.DataSource = this.tblmanageUserBindingSource1;
            this.cmb_uname.DisplayMember = "UserName";
            this.cmb_uname.FormattingEnabled = true;
            this.cmb_uname.Location = new System.Drawing.Point(101, 97);
            this.cmb_uname.Name = "cmb_uname";
            this.cmb_uname.Size = new System.Drawing.Size(156, 21);
            this.cmb_uname.TabIndex = 1;
            this.cmb_uname.ValueMember = "UserName";
            this.cmb_uname.SelectedIndexChanged += new System.EventHandler(this.cmb_uname_SelectedIndexChanged);
            // 
            // tblmanageUserBindingSource1
            // 
            this.tblmanageUserBindingSource1.DataMember = "Tbl_manageUser";
            this.tblmanageUserBindingSource1.DataSource = this.fIVESTARDBDataSet14;
            // 
            // fIVESTARDBDataSet14
            // 
            this.fIVESTARDBDataSet14.DataSetName = "FIVESTARDBDataSet14";
            this.fIVESTARDBDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_manageUserTableAdapter2
            // 
            this.tbl_manageUserTableAdapter2.ClearBeforeFill = true;
            // 
            // dg_eu
            // 
            this.dg_eu.AutoGenerateColumns = false;
            this.dg_eu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_eu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.dg_eu.DataSource = this.tblmanageUserBindingSource;
            this.dg_eu.Location = new System.Drawing.Point(289, 102);
            this.dg_eu.Name = "dg_eu";
            this.dg_eu.Size = new System.Drawing.Size(471, 270);
            this.dg_eu.TabIndex = 58;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "UserName";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // tblmanageUserBindingSource
            // 
            this.tblmanageUserBindingSource.DataMember = "Tbl_manageUser";
            this.tblmanageUserBindingSource.DataSource = this.fIVESTARDBDataSet13;
            // 
            // fIVESTARDBDataSet13
            // 
            this.fIVESTARDBDataSet13.DataSetName = "FIVESTARDBDataSet13";
            this.fIVESTARDBDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_manageUserTableAdapter
            // 
            this.tbl_manageUserTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_manageUserTableAdapter1
            // 
            this.tbl_manageUserTableAdapter1.ClearBeforeFill = true;
            // 
            // EditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dg_eu);
            this.Controls.Add(this.cmb_uname);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_gender);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EditUser";
            this.Text = "EditUser";
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_eu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cmb_gender;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_uname;
        private System.Windows.Forms.BindingSource tblmanageUserBindingSource2;
        private FIVESTARDBDataSet8TableAdapters.Tbl_manageUserTableAdapter tbl_manageUserTableAdapter2;
        private System.Windows.Forms.DataGridView dg_eu;
        private FIVESTARDBDataSet13 fIVESTARDBDataSet13;
        private System.Windows.Forms.BindingSource tblmanageUserBindingSource;
        private FIVESTARDBDataSet13TableAdapters.Tbl_manageUserTableAdapter tbl_manageUserTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private FIVESTARDBDataSet14 fIVESTARDBDataSet14;
        private System.Windows.Forms.BindingSource tblmanageUserBindingSource1;
        private FIVESTARDBDataSet14TableAdapters.Tbl_manageUserTableAdapter tbl_manageUserTableAdapter1;
    }
}