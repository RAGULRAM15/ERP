
namespace WindowsFormsApp4
{
    partial class frmQouation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQouation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sum_discount = new System.Windows.Forms.TextBox();
            this.txt_quantity_sum = new System.Windows.Forms.TextBox();
            this.txt_total_sum = new System.Windows.Forms.TextBox();
            this.dgvitemform = new System.Windows.Forms.DataGridView();
            this.row_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_datetime = new System.Windows.Forms.DateTimePicker();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.user_box = new System.Windows.Forms.ComboBox();
            this.txtquotation = new System.Windows.Forms.ComboBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnladd_page = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_rate = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.txt_size = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_no = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlclose = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemform)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlright.SuspendLayout();
            this.pnladd_page.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlclose.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txt_sum_discount);
            this.panel1.Controls.Add(this.txt_quantity_sum);
            this.panel1.Controls.Add(this.txt_total_sum);
            this.panel1.Controls.Add(this.dgvitemform);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(665, 330);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_sum_discount
            // 
            this.txt_sum_discount.Location = new System.Drawing.Point(409, 303);
            this.txt_sum_discount.Name = "txt_sum_discount";
            this.txt_sum_discount.ReadOnly = true;
            this.txt_sum_discount.Size = new System.Drawing.Size(72, 20);
            this.txt_sum_discount.TabIndex = 5;
            this.txt_sum_discount.Visible = false;
            this.txt_sum_discount.TextChanged += new System.EventHandler(this.txt_sum_discount_TextChanged);
            // 
            // txt_quantity_sum
            // 
            this.txt_quantity_sum.Location = new System.Drawing.Point(281, 303);
            this.txt_quantity_sum.Name = "txt_quantity_sum";
            this.txt_quantity_sum.ReadOnly = true;
            this.txt_quantity_sum.Size = new System.Drawing.Size(65, 20);
            this.txt_quantity_sum.TabIndex = 2;
            this.txt_quantity_sum.TextChanged += new System.EventHandler(this.txt_quantity_sum_TextChanged);
            // 
            // txt_total_sum
            // 
            this.txt_total_sum.Location = new System.Drawing.Point(487, 303);
            this.txt_total_sum.Name = "txt_total_sum";
            this.txt_total_sum.ReadOnly = true;
            this.txt_total_sum.Size = new System.Drawing.Size(64, 20);
            this.txt_total_sum.TabIndex = 1;
            this.txt_total_sum.TextChanged += new System.EventHandler(this.txt_total_sum_TextChanged);
            // 
            // dgvitemform
            // 
            this.dgvitemform.AllowUserToAddRows = false;
            this.dgvitemform.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvitemform.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvitemform.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvitemform.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvitemform.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.row_id,
            this.item_name,
            this.size,
            this.style_name,
            this.quantity,
            this.rate,
            this.discount,
            this.total,
            this.edit,
            this.delete});
            this.dgvitemform.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvitemform.Location = new System.Drawing.Point(0, 0);
            this.dgvitemform.Name = "dgvitemform";
            this.dgvitemform.ReadOnly = true;
            this.dgvitemform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitemform.Size = new System.Drawing.Size(665, 297);
            this.dgvitemform.TabIndex = 0;
            this.dgvitemform.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitemform_CellContentClick);
            this.dgvitemform.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvitemform_RowPostPaint_1);
            // 
            // row_id
            // 
            this.row_id.DataPropertyName = "row_id";
            this.row_id.HeaderText = "S.NO";
            this.row_id.Name = "row_id";
            this.row_id.ReadOnly = true;
            // 
            // item_name
            // 
            this.item_name.DataPropertyName = "item_name";
            this.item_name.HeaderText = "ITEM NAME";
            this.item_name.Name = "item_name";
            this.item_name.ReadOnly = true;
            // 
            // size
            // 
            this.size.DataPropertyName = "size";
            this.size.HeaderText = "SIZE";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // style_name
            // 
            this.style_name.DataPropertyName = "style_name";
            this.style_name.HeaderText = "STYLE NAME";
            this.style_name.Name = "style_name";
            this.style_name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.DataPropertyName = "quantity";
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "rate";
            this.rate.HeaderText = "RATE";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // discount
            // 
            this.discount.DataPropertyName = "discount";
            this.discount.HeaderText = "DISCOUNT";
            this.discount.Name = "discount";
            this.discount.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "TOTAL";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.edit.HeaderText = "EDIT";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "EDIT";
            this.edit.UseColumnTextForButtonValue = true;
            // 
            // delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delete.HeaderText = "DELETE";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Text = "DELETE";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "    ADDRESS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(706, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "DATE";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUOTATION.NO";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(437, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "   QUOTATION";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(703, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "USER";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(513, 127);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(38, 31);
            this.btnadd.TabIndex = 15;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(580, 123);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(37, 34);
            this.btn_save.TabIndex = 16;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_datetime
            // 
            this.txt_datetime.CustomFormat = "dd/MM/yyyy";
            this.txt_datetime.Enabled = false;
            this.txt_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_datetime.Location = new System.Drawing.Point(789, 49);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(111, 22);
            this.txt_datetime.TabIndex = 18;
            this.txt_datetime.ValueChanged += new System.EventHandler(this.txt_datetime_ValueChanged);
            // 
            // txtcustomer
            // 
            this.txtcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcustomer.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(114, 46);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(254, 25);
            this.txtcustomer.TabIndex = 19;
            this.txtcustomer.TextChanged += new System.EventHandler(this.txtcustomer_TextChanged);
            this.txtcustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustomer_KeyDown_1);
            // 
            // txtaddress
            // 
            this.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(114, 88);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtaddress.Size = new System.Drawing.Size(254, 69);
            this.txtaddress.TabIndex = 20;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyDown_1);
            // 
            // user_box
            // 
            this.user_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.user_box.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_box.FormattingEnabled = true;
            this.user_box.Location = new System.Drawing.Point(789, 128);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(121, 25);
            this.user_box.TabIndex = 22;
            this.user_box.SelectedIndexChanged += new System.EventHandler(this.user_box_SelectedIndexChanged);
            // 
            // txtquotation
            // 
            this.txtquotation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtquotation.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquotation.FormattingEnabled = true;
            this.txtquotation.Location = new System.Drawing.Point(789, 88);
            this.txtquotation.Name = "txtquotation";
            this.txtquotation.Size = new System.Drawing.Size(121, 25);
            this.txtquotation.TabIndex = 23;
            this.txtquotation.SelectedIndexChanged += new System.EventHandler(this.txtquotation_SelectedIndexChanged);
            this.txtquotation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Quotation_KeyDown);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.txtquotation);
            this.pnlTop.Controls.Add(this.user_box);
            this.pnlTop.Controls.Add(this.txtaddress);
            this.pnlTop.Controls.Add(this.txtcustomer);
            this.pnlTop.Controls.Add(this.txt_datetime);
            this.pnlTop.Controls.Add(this.btn_save);
            this.pnlTop.Controls.Add(this.btnadd);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Controls.Add(this.label5);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(931, 171);
            this.pnlTop.TabIndex = 35;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.Color.DarkGray;
            this.pnlright.Controls.Add(this.pnladd_page);
            this.pnlright.Controls.Add(this.pnlclose);
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(665, 171);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(266, 330);
            this.pnlright.TabIndex = 36;
            this.pnlright.Visible = false;
            this.pnlright.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlright_Paint);
            // 
            // pnladd_page
            // 
            this.pnladd_page.BackColor = System.Drawing.Color.DarkGray;
            this.pnladd_page.Controls.Add(this.tableLayoutPanel1);
            this.pnladd_page.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnladd_page.ForeColor = System.Drawing.Color.White;
            this.pnladd_page.Location = new System.Drawing.Point(0, 57);
            this.pnladd_page.Margin = new System.Windows.Forms.Padding(0);
            this.pnladd_page.Name = "pnladd_page";
            this.pnladd_page.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.pnladd_page.Size = new System.Drawing.Size(266, 273);
            this.pnladd_page.TabIndex = 1;
            this.pnladd_page.Paint += new System.Windows.Forms.PaintEventHandler(this.pnladd_page_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.10997F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.89003F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.txt_total, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txt_discount, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txt_rate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_quantity, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_style, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_size, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_item, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_no, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 17;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(246, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txt_total
            // 
            this.txt_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_total.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(121, 212);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(122, 25);
            this.txt_total.TabIndex = 49;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(121, 183);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(122, 25);
            this.txt_discount.TabIndex = 48;
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            // 
            // txt_rate
            // 
            this.txt_rate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_rate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.Location = new System.Drawing.Point(121, 154);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(122, 25);
            this.txt_rate.TabIndex = 47;
            this.txt_rate.TextChanged += new System.EventHandler(this.txt_rate_TextChanged);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(121, 121);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(122, 25);
            this.txt_quantity.TabIndex = 46;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // txt_style
            // 
            this.txt_style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_style.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_style.Location = new System.Drawing.Point(121, 93);
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(122, 25);
            this.txt_style.TabIndex = 45;
            this.txt_style.TextChanged += new System.EventHandler(this.txt_style_TextChanged);
            // 
            // txt_size
            // 
            this.txt_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_size.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.Location = new System.Drawing.Point(121, 63);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(122, 25);
            this.txt_size.TabIndex = 44;
            this.txt_size.TextChanged += new System.EventHandler(this.txt_size_TextChanged);
            this.txt_size.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_size_KeyDown_1);
            // 
            // txt_item
            // 
            this.txt_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_item.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item.Location = new System.Drawing.Point(121, 35);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(122, 25);
            this.txt_item.TabIndex = 43;
            this.txt_item.TextChanged += new System.EventHandler(this.txt_item_TextChanged);
            this.txt_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_KeyDown_1);
            // 
            // txt_no
            // 
            this.txt_no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_no.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_no.Location = new System.Drawing.Point(121, 3);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(122, 25);
            this.txt_no.TabIndex = 42;
            this.txt_no.Visible = false;
            this.txt_no.TextChanged += new System.EventHandler(this.txt_no_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 28);
            this.label14.TabIndex = 33;
            this.label14.Text = "TOTAL";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "DISCOUNT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "RATE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 33);
            this.label10.TabIndex = 30;
            this.label10.Text = "QUANTITY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "STYLE NAME";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "SIZE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "ITEM NAME";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(121, 455);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 22);
            this.textBox4.TabIndex = 25;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(3, 455);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(96, 22);
            this.textBox3.TabIndex = 24;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(121, 453);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(96, 22);
            this.textBox2.TabIndex = 13;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(98, 22);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "0";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 32);
            this.label13.TabIndex = 26;
            this.label13.Text = "S.NO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Visible = false;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // pnlclose
            // 
            this.pnlclose.BackColor = System.Drawing.Color.DarkGray;
            this.pnlclose.Controls.Add(this.btn_update);
            this.pnlclose.Controls.Add(this.btnok);
            this.pnlclose.Controls.Add(this.btnclose);
            this.pnlclose.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlclose.Location = new System.Drawing.Point(0, 0);
            this.pnlclose.Name = "pnlclose";
            this.pnlclose.Size = new System.Drawing.Size(266, 57);
            this.pnlclose.TabIndex = 0;
            this.pnlclose.Visible = false;
            this.pnlclose.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlclose_Paint);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.White;
            this.btn_update.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.Location = new System.Drawing.Point(114, 0);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(57, 57);
            this.btn_update.TabIndex = 18;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnok.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnok.FlatAppearance.BorderSize = 0;
            this.btnok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnok.Image = ((System.Drawing.Image)(resources.GetObject("btnok.Image")));
            this.btnok.Location = new System.Drawing.Point(57, 0);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(57, 57);
            this.btnok.TabIndex = 17;
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.White;
            this.btnclose.CausesValidation = false;
            this.btnclose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(0, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(57, 57);
            this.btnclose.TabIndex = 16;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // frmQouation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 501);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlTop);
            this.Name = "frmQouation";
            this.Text = "frmQouation";
            this.Load += new System.EventHandler(this.Frm_Quotation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemform)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlright.ResumeLayout(false);
            this.pnladd_page.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlclose.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sum_discount;
        private System.Windows.Forms.TextBox txt_quantity_sum;
        private System.Windows.Forms.TextBox txt_total_sum;
        private System.Windows.Forms.DataGridView dgvitemform;
        private System.Windows.Forms.DataGridViewTextBoxColumn row_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn style_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DateTimePicker txt_datetime;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.ComboBox user_box;
        private System.Windows.Forms.ComboBox txtquotation;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnladd_page;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_rate;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.TextBox txt_size;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_no;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlclose;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnclose;
    }
}