﻿
namespace IMS
{
    partial class frm_credit_list
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_credit_list));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INVOICE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_to = new System.Windows.Forms.DateTimePicker();
            this.txt_from = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_fillter = new System.Windows.Forms.TextBox();
            this.txt_refresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_add = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.dtg_qut = new System.Windows.Forms.DataGridView();
            this.txtquotation = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_qut)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "STATUS";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.status.DefaultCellStyle = dataGridViewCellStyle1;
            this.status.FillWeight = 79.46688F;
            this.status.HeaderText = "STATUS";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // customer_name
            // 
            this.customer_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_name.DataPropertyName = "CUSTOMER_NAME";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.customer_name.FillWeight = 177.665F;
            this.customer_name.HeaderText = "CUSTOMER NAME";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            // 
            // INVOICE_DATE
            // 
            this.INVOICE_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INVOICE_DATE.DataPropertyName = "INVOICE_DATE";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INVOICE_DATE.DefaultCellStyle = dataGridViewCellStyle3;
            this.INVOICE_DATE.FillWeight = 80.86465F;
            this.INVOICE_DATE.HeaderText = "INVOICE DATE";
            this.INVOICE_DATE.Name = "INVOICE_DATE";
            this.INVOICE_DATE.ReadOnly = true;
            // 
            // INVOICE_NO
            // 
            this.INVOICE_NO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INVOICE_NO.DataPropertyName = "INVOICE_NO";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INVOICE_NO.DefaultCellStyle = dataGridViewCellStyle4;
            this.INVOICE_NO.FillWeight = 83.03933F;
            this.INVOICE_NO.HeaderText = "INVOICE NO";
            this.INVOICE_NO.Name = "INVOICE_NO";
            this.INVOICE_NO.ReadOnly = true;
            // 
            // INVOICE_ID
            // 
            this.INVOICE_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.INVOICE_ID.DataPropertyName = "INVOICE_ID";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INVOICE_ID.DefaultCellStyle = dataGridViewCellStyle5;
            this.INVOICE_ID.HeaderText = "INVOICE_ID";
            this.INVOICE_ID.Name = "INVOICE_ID";
            this.INVOICE_ID.ReadOnly = true;
            this.INVOICE_ID.Visible = false;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total.DataPropertyName = "TOTAL";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.DefaultCellStyle = dataGridViewCellStyle6;
            this.total.FillWeight = 78.9642F;
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(1060, 504);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(10, 20);
            this.txt_name.TabIndex = 130;
            this.txt_name.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1085, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 129;
            this.label9.Text = "LOAD";
            this.label9.Visible = false;
            // 
            // btn_load
            // 
            this.btn_load.FlatAppearance.BorderSize = 0;
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Image = ((System.Drawing.Image)(resources.GetObject("btn_load.Image")));
            this.btn_load.Location = new System.Drawing.Point(1076, 32);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(30, 30);
            this.btn_load.TabIndex = 128;
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_to
            // 
            this.txt_to.CustomFormat = "dd/MM/yyyy";
            this.txt_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_to.Location = new System.Drawing.Point(518, 57);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(147, 20);
            this.txt_to.TabIndex = 127;
            this.txt_to.Value = new System.DateTime(2023, 3, 20, 0, 0, 0, 0);
            // 
            // txt_from
            // 
            this.txt_from.CustomFormat = "dd/MM/yyyy";
            this.txt_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_from.Location = new System.Drawing.Point(518, 16);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(147, 20);
            this.txt_from.TabIndex = 126;
            this.txt_from.Value = new System.DateTime(2023, 3, 20, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 125;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 124;
            this.label7.Text = "PRINT";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(424, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 50);
            this.button1.TabIndex = 123;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.print_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 122;
            this.label6.Text = "TO";
            // 
            // txt_fillter
            // 
            this.txt_fillter.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fillter.Location = new System.Drawing.Point(684, 35);
            this.txt_fillter.Name = "txt_fillter";
            this.txt_fillter.Size = new System.Drawing.Size(386, 25);
            this.txt_fillter.TabIndex = 121;
            // 
            // txt_refresh
            // 
            this.txt_refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_refresh.BackgroundImage")));
            this.txt_refresh.FlatAppearance.BorderSize = 0;
            this.txt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_refresh.Location = new System.Drawing.Point(328, 3);
            this.txt_refresh.Name = "txt_refresh";
            this.txt_refresh.Size = new System.Drawing.Size(49, 50);
            this.txt_refresh.TabIndex = 115;
            this.txt_refresh.UseVisualStyleBackColor = true;
            this.txt_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 120;
            this.label5.Text = "VIEW";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 119;
            this.label4.Text = "EDIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 118;
            this.label3.Text = "DELETE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(325, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 117;
            this.label2.Text = "REFRESH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 116;
            this.label1.Text = "  ADD";
            // 
            // txt_delete
            // 
            this.txt_delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_delete.BackgroundImage")));
            this.txt_delete.FlatAppearance.BorderSize = 0;
            this.txt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_delete.Location = new System.Drawing.Point(161, 7);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(45, 46);
            this.txt_delete.TabIndex = 114;
            this.txt_delete.UseVisualStyleBackColor = true;
            this.txt_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(86, 5);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(46, 48);
            this.btn_edit.TabIndex = 113;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_add
            // 
            this.txt_add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_add.BackgroundImage")));
            this.txt_add.FlatAppearance.BorderSize = 0;
            this.txt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_add.ImageKey = "(none)";
            this.txt_add.Location = new System.Drawing.Point(16, 11);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(43, 47);
            this.txt_add.TabIndex = 112;
            this.txt_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txt_add.UseVisualStyleBackColor = true;
            this.txt_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_view
            // 
            this.btn_view.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_view.BackgroundImage")));
            this.btn_view.FlatAppearance.BorderSize = 0;
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Location = new System.Drawing.Point(246, 3);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(48, 49);
            this.btn_view.TabIndex = 111;
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dtg_qut
            // 
            this.dtg_qut.AllowUserToAddRows = false;
            this.dtg_qut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_qut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(194)))));
            this.dtg_qut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_qut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtg_qut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_qut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.INVOICE_ID,
            this.INVOICE_NO,
            this.INVOICE_DATE,
            this.customer_name,
            this.total,
            this.status});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(245)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_qut.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtg_qut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtg_qut.Location = new System.Drawing.Point(0, 98);
            this.dtg_qut.Name = "dtg_qut";
            this.dtg_qut.ReadOnly = true;
            this.dtg_qut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_qut.ShowCellErrors = false;
            this.dtg_qut.ShowCellToolTips = false;
            this.dtg_qut.ShowEditingIcon = false;
            this.dtg_qut.ShowRowErrors = false;
            this.dtg_qut.Size = new System.Drawing.Size(1164, 426);
            this.dtg_qut.TabIndex = 109;
            this.dtg_qut.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_qut_CellEnter);
            this.dtg_qut.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtg_qut_DataBindingComplete);
            // 
            // txtquotation
            // 
            this.txtquotation.Location = new System.Drawing.Point(1037, 504);
            this.txtquotation.Name = "txtquotation";
            this.txtquotation.Size = new System.Drawing.Size(11, 20);
            this.txtquotation.TabIndex = 110;
            this.txtquotation.Visible = false;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Text = "";
            this.printPreviewDialog.Visible = false;
            // 
            // frm_credit_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(184)))), ((int)(((byte)(194)))));
            this.ClientSize = new System.Drawing.Size(1164, 524);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_fillter);
            this.Controls.Add(this.txt_refresh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dtg_qut);
            this.Controls.Add(this.txtquotation);
            this.Name = "frm_credit_list";
            this.Text = "Credit List";
            this.Load += new System.EventHandler(this.frm_credit_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_qut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INVOICE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.DateTimePicker txt_to;
        private System.Windows.Forms.DateTimePicker txt_from;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_fillter;
        private System.Windows.Forms.Button txt_refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button txt_add;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.DataGridView dtg_qut;
        private System.Windows.Forms.TextBox txtquotation;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}