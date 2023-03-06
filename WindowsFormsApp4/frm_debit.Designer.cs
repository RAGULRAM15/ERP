
namespace WindowsFormsApp4
{
    partial class frm_debit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_debit));
            this.btn_close = new System.Windows.Forms.Button();
            this.debit_note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoice_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_full = new System.Windows.Forms.Panel();
            this.txt_debit = new System.Windows.Forms.TextBox();
            this.dtg_debit = new System.Windows.Forms.DataGridView();
            this.invoice_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.cmbo_debit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_datetime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_full.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_debit)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(843, 487);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 44;
            this.btn_close.Text = "CLOSE";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // debit_note
            // 
            this.debit_note.DataPropertyName = "debit_note";
            this.debit_note.HeaderText = "DEBIT NOTE";
            this.debit_note.Name = "debit_note";
            this.debit_note.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.debit_note.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // active
            // 
            this.active.DataPropertyName = "active";
            this.active.HeaderText = "SELECT";
            this.active.Name = "active";
            // 
            // balance
            // 
            this.balance.DataPropertyName = "balance";
            this.balance.HeaderText = "BALANCE";
            this.balance.Name = "balance";
            // 
            // paid
            // 
            this.paid.DataPropertyName = "paid";
            this.paid.HeaderText = "PAID";
            this.paid.Name = "paid";
            // 
            // total
            // 
            this.total.DataPropertyName = "NET_AMOUNT";
            this.total.HeaderText = "AMOUNT";
            this.total.Name = "total";
            // 
            // invoice_no
            // 
            this.invoice_no.DataPropertyName = "invoice_no";
            this.invoice_no.HeaderText = "INVOICE NO";
            this.invoice_no.Name = "invoice_no";
            // 
            // pnl_full
            // 
            this.pnl_full.Controls.Add(this.txt_debit);
            this.pnl_full.Controls.Add(this.dtg_debit);
            this.pnl_full.Controls.Add(this.txt_amount);
            this.pnl_full.Controls.Add(this.txt_balance);
            this.pnl_full.Controls.Add(this.txt_paid);
            this.pnl_full.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_full.Location = new System.Drawing.Point(0, 210);
            this.pnl_full.Name = "pnl_full";
            this.pnl_full.Size = new System.Drawing.Size(987, 309);
            this.pnl_full.TabIndex = 40;
            // 
            // txt_debit
            // 
            this.txt_debit.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_debit.Location = new System.Drawing.Point(900, 282);
            this.txt_debit.Name = "txt_debit";
            this.txt_debit.Size = new System.Drawing.Size(120, 25);
            this.txt_debit.TabIndex = 5;
            // 
            // dtg_debit
            // 
            this.dtg_debit.AllowUserToAddRows = false;
            this.dtg_debit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_debit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_debit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_debit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoice_no,
            this.invoice_date,
            this.total,
            this.paid,
            this.balance,
            this.active,
            this.debit_note});
            this.dtg_debit.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtg_debit.Location = new System.Drawing.Point(0, 0);
            this.dtg_debit.Name = "dtg_debit";
            this.dtg_debit.Size = new System.Drawing.Size(987, 276);
            this.dtg_debit.TabIndex = 1;
            // 
            // invoice_date
            // 
            this.invoice_date.DataPropertyName = "invoice_date";
            this.invoice_date.HeaderText = "INVOICE DATE";
            this.invoice_date.Name = "invoice_date";
            // 
            // txt_amount
            // 
            this.txt_amount.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(328, 282);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(133, 25);
            this.txt_amount.TabIndex = 2;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_balance
            // 
            this.txt_balance.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_balance.Location = new System.Drawing.Point(612, 282);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(133, 25);
            this.txt_balance.TabIndex = 4;
            this.txt_balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_paid
            // 
            this.txt_paid.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paid.Location = new System.Drawing.Point(481, 282);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(125, 25);
            this.txt_paid.TabIndex = 3;
            this.txt_paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(973, 504);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 45;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.Green;
            this.btn_save.Location = new System.Drawing.Point(738, 487);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 43;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(657, 440);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(326, 39);
            this.textBox4.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(570, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 41;
            this.label2.Text = "TOTAL";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 119);
            this.panel1.TabIndex = 46;
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.cmbo_debit);
            this.pnl_top.Controls.Add(this.label4);
            this.pnl_top.Controls.Add(this.label5);
            this.pnl_top.Controls.Add(this.txt_datetime);
            this.pnl_top.Controls.Add(this.label3);
            this.pnl_top.Controls.Add(this.txtcustomer);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(987, 118);
            this.pnl_top.TabIndex = 1;
            // 
            // cmbo_debit
            // 
            this.cmbo_debit.BackColor = System.Drawing.Color.White;
            this.cmbo_debit.Location = new System.Drawing.Point(844, 21);
            this.cmbo_debit.Name = "cmbo_debit";
            this.cmbo_debit.ReadOnly = true;
            this.cmbo_debit.Size = new System.Drawing.Size(121, 20);
            this.cmbo_debit.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(733, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "ENTRY NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(466, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "   DEBIT NOTE";
            // 
            // txt_datetime
            // 
            this.txt_datetime.CustomFormat = "dd/MM/yyyy";
            this.txt_datetime.Enabled = false;
            this.txt_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_datetime.Location = new System.Drawing.Point(844, 56);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(121, 22);
            this.txt_datetime.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(772, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "DATE";
            // 
            // txtcustomer
            // 
            this.txtcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcustomer.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(123, 56);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(254, 25);
            this.txtcustomer.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "CUSTOMER";
            // 
            // frm_debit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pnl_full);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Name = "frm_debit";
            this.Text = "frm_debit";
            this.pnl_full.ResumeLayout(false);
            this.pnl_full.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_debit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn debit_note;
        private System.Windows.Forms.DataGridViewCheckBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_no;
        private System.Windows.Forms.Panel pnl_full;
        private System.Windows.Forms.TextBox txt_debit;
        private System.Windows.Forms.DataGridView dtg_debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoice_date;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.TextBox cmbo_debit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txt_datetime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.Label label1;
    }
}