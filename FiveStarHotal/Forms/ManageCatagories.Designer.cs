namespace FiveStarHotal
{
    partial class ManageCatagories
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmanageCataforiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet16 = new FiveStarHotal.FIVESTARDBDataSet16();
            this.label = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_remarks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbl_manageCataforiesTableAdapter = new FiveStarHotal.FIVESTARDBDataSet16TableAdapters.Tbl_manageCataforiesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageCataforiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet16)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNameDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
            this.dg.DataSource = this.tblmanageCataforiesBindingSource;
            this.dg.Location = new System.Drawing.Point(78, 203);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(344, 226);
            this.dg.TabIndex = 52;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "CName";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // remarksDataGridViewTextBoxColumn
            // 
            this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
            this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
            this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
            // 
            // tblmanageCataforiesBindingSource
            // 
            this.tblmanageCataforiesBindingSource.DataMember = "Tbl_manageCatafories";
            this.tblmanageCataforiesBindingSource.DataSource = this.fIVESTARDBDataSet16;
            // 
            // fIVESTARDBDataSet16
            // 
            this.fIVESTARDBDataSet16.DataSetName = "FIVESTARDBDataSet16";
            this.fIVESTARDBDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(135, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(268, 33);
            this.label.TabIndex = 5;
            this.label.Text = "Manage Catagories";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(255, 152);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 34);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(109, 152);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 34);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_remarks
            // 
            this.txt_remarks.Location = new System.Drawing.Point(352, 109);
            this.txt_remarks.Name = "txt_remarks";
            this.txt_remarks.Size = new System.Drawing.Size(154, 20);
            this.txt_remarks.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Remarks:";
            // 
            // txt_cname
            // 
            this.txt_cname.Location = new System.Drawing.Point(123, 109);
            this.txt_cname.Name = "txt_cname";
            this.txt_cname.Size = new System.Drawing.Size(154, 20);
            this.txt_cname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Catagories Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 71);
            this.panel1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(389, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Five Star Hotel";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 39);
            this.panel2.TabIndex = 38;
            // 
            // tbl_manageCataforiesTableAdapter
            // 
            this.tbl_manageCataforiesTableAdapter.ClearBeforeFill = true;
            // 
            // ManageCatagories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 493);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_remarks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "ManageCatagories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCatagories";
            this.Load += new System.EventHandler(this.ManageCatagories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmanageCataforiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet16)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_remarks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private FIVESTARDBDataSet16 fIVESTARDBDataSet16;
        private System.Windows.Forms.BindingSource tblmanageCataforiesBindingSource;
        private FIVESTARDBDataSet16TableAdapters.Tbl_manageCataforiesTableAdapter tbl_manageCataforiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
    }
}