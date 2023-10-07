namespace FiveStarHotal
{
    partial class Form1
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
            this.label8 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.fIVESTARDBDataSet = new FiveStarHotal.FIVESTARDBDataSet();
            this.tbladdroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_location = new System.Windows.Forms.TextBox();
            this.txt_catagories = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_addroomTableAdapter
            // 
            this.tbl_addroomTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Id:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(108, 94);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(154, 20);
            this.txt_id.TabIndex = 1;
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
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // roomCostDataGridViewTextBoxColumn
            // 
            this.roomCostDataGridViewTextBoxColumn.DataPropertyName = "RoomCost";
            this.roomCostDataGridViewTextBoxColumn.HeaderText = "RoomCost";
            this.roomCostDataGridViewTextBoxColumn.Name = "roomCostDataGridViewTextBoxColumn";
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            // 
            // catagoriesDataGridViewTextBoxColumn
            // 
            this.catagoriesDataGridViewTextBoxColumn.DataPropertyName = "Catagories";
            this.catagoriesDataGridViewTextBoxColumn.HeaderText = "Catagories";
            this.catagoriesDataGridViewTextBoxColumn.Name = "catagoriesDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.catagoriesDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.roomCostDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dg.DataSource = this.tbladdroomBindingSource;
            this.dg.Location = new System.Drawing.Point(288, 99);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(444, 264);
            this.dg.TabIndex = 18;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(189, 344);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(108, 344);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 34);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(27, 344);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 34);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_status
            // 
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Items.AddRange(new object[] {
            "Avaiable",
            "Booked"});
            this.cmb_status.Location = new System.Drawing.Point(108, 295);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(154, 21);
            this.cmb_status.TabIndex = 6;
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(108, 253);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(154, 20);
            this.txt_cost.TabIndex = 5;
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(108, 212);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(154, 20);
            this.txt_location.TabIndex = 4;
            // 
            // txt_catagories
            // 
            this.txt_catagories.Location = new System.Drawing.Point(108, 176);
            this.txt_catagories.Name = "txt_catagories";
            this.txt_catagories.Size = new System.Drawing.Size(154, 20);
            this.txt_catagories.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Catagories:";
            // 
            // txt_rname
            // 
            this.txt_rname.Location = new System.Drawing.Point(108, 134);
            this.txt_rname.Name = "txt_rname";
            this.txt_rname.Size = new System.Drawing.Size(154, 20);
            this.txt_rname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 71);
            this.panel1.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(324, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(160, 33);
            this.label.TabIndex = 5;
            this.label.Text = "Add  Room";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 39);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(655, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Five Star Hotel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 446);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_location);
            this.Controls.Add(this.txt_catagories);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_rname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Room";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbladdroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FIVESTARDBDataSetTableAdapters.Tbl_addroomTableAdapter tbl_addroomTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_id;
        private FIVESTARDBDataSet fIVESTARDBDataSet;
        private System.Windows.Forms.BindingSource tbladdroomBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.TextBox txt_catagories;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_rname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

