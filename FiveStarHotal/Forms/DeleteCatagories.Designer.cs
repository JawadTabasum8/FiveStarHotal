namespace FiveStarHotal
{
    partial class DeleteCatagories
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
            this.tbl_manageUserTableAdapter = new FiveStarHotal.FIVESTARDBDataSet15TableAdapters.Tbl_manageUserTableAdapter();
            this.tbl_manageUserTableAdapter1 = new FiveStarHotal.FIVESTARDBDataSet10TableAdapters.Tbl_manageUserTableAdapter();
            this.tblmanageUserBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet15 = new FiveStarHotal.FIVESTARDBDataSet15();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_cdelete = new System.Windows.Forms.ComboBox();
            this.tblmanageCataforiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet17 = new FiveStarHotal.FIVESTARDBDataSet17();
            this.tblmanageUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_manageCataforiesTableAdapter = new FiveStarHotal.FIVESTARDBDataSet17TableAdapters.Tbl_manageCataforiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet15)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageCataforiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_manageUserTableAdapter
            // 
            this.tbl_manageUserTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_manageUserTableAdapter1
            // 
            this.tbl_manageUserTableAdapter1.ClearBeforeFill = true;
            // 
            // fIVESTARDBDataSet15
            // 
            this.fIVESTARDBDataSet15.DataSetName = "FIVESTARDBDataSet15";
            this.fIVESTARDBDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(138, 156);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 74;
            this.btn_clear.Text = "Delete";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(252, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Five Star Hotel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 26);
            this.panel2.TabIndex = 72;
            // 
            // cmb_cdelete
            // 
            this.cmb_cdelete.DataSource = this.tblmanageCataforiesBindingSource;
            this.cmb_cdelete.DisplayMember = "CName";
            this.cmb_cdelete.FormattingEnabled = true;
            this.cmb_cdelete.Location = new System.Drawing.Point(138, 103);
            this.cmb_cdelete.Name = "cmb_cdelete";
            this.cmb_cdelete.Size = new System.Drawing.Size(161, 21);
            this.cmb_cdelete.TabIndex = 75;
            this.cmb_cdelete.ValueMember = "CName";
            this.cmb_cdelete.SelectedIndexChanged += new System.EventHandler(this.cmb_cdelete_SelectedIndexChanged);
            // 
            // tblmanageCataforiesBindingSource
            // 
            this.tblmanageCataforiesBindingSource.DataMember = "Tbl_manageCatafories";
            this.tblmanageCataforiesBindingSource.DataSource = this.fIVESTARDBDataSet17;
            // 
            // fIVESTARDBDataSet17
            // 
            this.fIVESTARDBDataSet17.DataSetName = "FIVESTARDBDataSet17";
            this.fIVESTARDBDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblmanageUserBindingSource
            // 
            this.tblmanageUserBindingSource.DataMember = "Tbl_manageUser";
            this.tblmanageUserBindingSource.DataSource = this.fIVESTARDBDataSet15;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(32, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(256, 33);
            this.label.TabIndex = 5;
            this.label.Text = " Delete Catagoreis";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 71);
            this.panel1.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Select to Delete:";
            // 
            // tbl_manageCataforiesTableAdapter
            // 
            this.tbl_manageCataforiesTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 245);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_cdelete);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "DeleteCatagories";
            this.Text = "DeleteCatagories";
            this.Load += new System.EventHandler(this.DeleteCatagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet15)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageCataforiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageUserBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FIVESTARDBDataSet15TableAdapters.Tbl_manageUserTableAdapter tbl_manageUserTableAdapter;
        private FIVESTARDBDataSet10TableAdapters.Tbl_manageUserTableAdapter tbl_manageUserTableAdapter1;
        private System.Windows.Forms.BindingSource tblmanageUserBindingSource1;
        private FIVESTARDBDataSet15 fIVESTARDBDataSet15;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_cdelete;
        private System.Windows.Forms.BindingSource tblmanageUserBindingSource;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FIVESTARDBDataSet17 fIVESTARDBDataSet17;
        private System.Windows.Forms.BindingSource tblmanageCataforiesBindingSource;
        private FIVESTARDBDataSet17TableAdapters.Tbl_manageCataforiesTableAdapter tbl_manageCataforiesTableAdapter;
    }
}