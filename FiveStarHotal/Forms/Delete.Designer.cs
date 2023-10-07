namespace FiveStarHotal
{
    partial class Delete
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
            this.label = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_Sdelete = new System.Windows.Forms.ComboBox();
            this.tbladdroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet1 = new FiveStarHotal.FIVESTARDBDataSet1();
            this.tbl_addroomTableAdapter = new FiveStarHotal.FIVESTARDBDataSet1TableAdapters.Tbl_addroomTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(103, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(185, 33);
            this.label.TabIndex = 5;
            this.label.Text = "Delete Room";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(138, 156);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 64;
            this.btn_clear.Text = "Delete";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Select to Delete:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 71);
            this.panel1.TabIndex = 54;
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
            this.panel2.Location = new System.Drawing.Point(0, 223);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 26);
            this.panel2.TabIndex = 55;
            // 
            // cmb_Sdelete
            // 
            this.cmb_Sdelete.DataSource = this.tbladdroomBindingSource;
            this.cmb_Sdelete.DisplayMember = "RoomName";
            this.cmb_Sdelete.FormattingEnabled = true;
            this.cmb_Sdelete.Location = new System.Drawing.Point(138, 109);
            this.cmb_Sdelete.Name = "cmb_Sdelete";
            this.cmb_Sdelete.Size = new System.Drawing.Size(191, 21);
            this.cmb_Sdelete.TabIndex = 65;
            this.cmb_Sdelete.ValueMember = "RoomName";
            // 
            // tbladdroomBindingSource
            // 
            this.tbladdroomBindingSource.DataMember = "Tbl_addroom";
            this.tbladdroomBindingSource.DataSource = this.fIVESTARDBDataSet1;
            // 
            // fIVESTARDBDataSet1
            // 
            this.fIVESTARDBDataSet1.DataSetName = "FIVESTARDBDataSet1";
            this.fIVESTARDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_addroomTableAdapter
            // 
            this.tbl_addroomTableAdapter.ClearBeforeFill = true;
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 249);
            this.Controls.Add(this.cmb_Sdelete);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "Delete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmb_Sdelete;
        private FIVESTARDBDataSet1 fIVESTARDBDataSet1;
        private System.Windows.Forms.BindingSource tbladdroomBindingSource;
        private FIVESTARDBDataSet1TableAdapters.Tbl_addroomTableAdapter tbl_addroomTableAdapter;
    }
}