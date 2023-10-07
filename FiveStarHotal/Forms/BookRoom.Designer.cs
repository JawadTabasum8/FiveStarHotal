namespace FiveStarHotal
{
    partial class BookRoom
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
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblbroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fIVESTARDBDataSet4 = new FiveStarHotal.FIVESTARDBDataSet4();
            this.label = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_broom = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_roon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTime_in = new System.Windows.Forms.DateTimePicker();
            this.dateTime_out = new System.Windows.Forms.DateTimePicker();
            this.tbl_broomTableAdapter = new FiveStarHotal.FIVESTARDBDataSet4TableAdapters.Tbl_broomTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.AutoGenerateColumns = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomDataGridViewTextBoxColumn,
            this.dateInDataGridViewTextBoxColumn,
            this.dateOutDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dg.DataSource = this.tblbroomBindingSource;
            this.dg.Location = new System.Drawing.Point(12, 220);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(491, 208);
            this.dg.TabIndex = 52;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateInDataGridViewTextBoxColumn
            // 
            this.dateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn";
            this.dateInDataGridViewTextBoxColumn.HeaderText = "DateIn";
            this.dateInDataGridViewTextBoxColumn.Name = "dateInDataGridViewTextBoxColumn";
            // 
            // dateOutDataGridViewTextBoxColumn
            // 
            this.dateOutDataGridViewTextBoxColumn.DataPropertyName = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.HeaderText = "DateOut";
            this.dateOutDataGridViewTextBoxColumn.Name = "dateOutDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // tblbroomBindingSource
            // 
            this.tblbroomBindingSource.DataMember = "Tbl_broom";
            this.tblbroomBindingSource.DataSource = this.fIVESTARDBDataSet4;
            // 
            // fIVESTARDBDataSet4
            // 
            this.fIVESTARDBDataSet4.DataSetName = "FIVESTARDBDataSet4";
            this.fIVESTARDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(161, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(167, 33);
            this.label.TabIndex = 5;
            this.label.Text = "Book Room";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(279, 180);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 34);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.TabStop = false;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_broom
            // 
            this.btn_broom.Location = new System.Drawing.Point(169, 180);
            this.btn_broom.Name = "btn_broom";
            this.btn_broom.Size = new System.Drawing.Size(75, 34);
            this.btn_broom.TabIndex = 5;
            this.btn_broom.Text = "Book Room";
            this.btn_broom.UseVisualStyleBackColor = true;
            this.btn_broom.Click += new System.EventHandler(this.btn_broom_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(347, 145);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(156, 20);
            this.txt_amount.TabIndex = 4;
            this.txt_amount.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Date In:";
            // 
            // txt_roon
            // 
            this.txt_roon.Location = new System.Drawing.Point(105, 105);
            this.txt_roon.Name = "txt_roon";
            this.txt_roon.Size = new System.Drawing.Size(154, 20);
            this.txt_roon.TabIndex = 1;
            this.txt_roon.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Room:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 71);
            this.panel1.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(405, 12);
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
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 39);
            this.panel2.TabIndex = 38;
            // 
            // dateTime_in
            // 
            this.dateTime_in.CustomFormat = "DD/MMM/YYYY";
            this.dateTime_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_in.Location = new System.Drawing.Point(102, 142);
            this.dateTime_in.Name = "dateTime_in";
            this.dateTime_in.Size = new System.Drawing.Size(157, 20);
            this.dateTime_in.TabIndex = 2;
            this.dateTime_in.TabStop = false;
            // 
            // dateTime_out
            // 
            this.dateTime_out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime_out.Location = new System.Drawing.Point(346, 105);
            this.dateTime_out.Name = "dateTime_out";
            this.dateTime_out.Size = new System.Drawing.Size(157, 20);
            this.dateTime_out.TabIndex = 3;
            this.dateTime_out.TabStop = false;
            // 
            // tbl_broomTableAdapter
            // 
            this.tbl_broomTableAdapter.ClearBeforeFill = true;
            // 
            // BookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 489);
            this.Controls.Add(this.dateTime_out);
            this.Controls.Add(this.dateTime_in);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_broom);
            this.Controls.Add(this.txt_amount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_roon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "BookRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookRoom";
            this.Load += new System.EventHandler(this.BookRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fIVESTARDBDataSet4)).EndInit();
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
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_broom;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_roon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTime_in;
        private System.Windows.Forms.DateTimePicker dateTime_out;
        private FIVESTARDBDataSet4 fIVESTARDBDataSet4;
        private System.Windows.Forms.BindingSource tblbroomBindingSource;
        private FIVESTARDBDataSet4TableAdapters.Tbl_broomTableAdapter tbl_broomTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}