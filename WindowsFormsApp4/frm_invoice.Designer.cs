
namespace WindowsFormsApp4
{
    partial class frm_invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_invoice));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvitemform = new System.Windows.Forms.DataGridView();
            this.row_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.style = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discount_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.txtcgst = new System.Windows.Forms.TextBox();
            this.txtsgst = new System.Windows.Forms.TextBox();
            this.txtigst = new System.Windows.Forms.TextBox();
            this.txtgst_value = new System.Windows.Forms.TextBox();
            this.txtnet_amount = new System.Windows.Forms.TextBox();
            this.txtroundoff = new System.Windows.Forms.TextBox();
            this.txtl_charge = new System.Windows.Forms.TextBox();
            this.txttrans = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_quantity_sum = new System.Windows.Forms.TextBox();
            this.txt_total_sum = new System.Windows.Forms.TextBox();
            this.txt_sum_discount = new System.Windows.Forms.TextBox();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pnl_close = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.txtinvoice = new System.Windows.Forms.ComboBox();
            this.user_box = new System.Windows.Forms.ComboBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.txt_datetime = new System.Windows.Forms.DateTimePicker();
            this.btn_save = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnet_amountB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemform)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_right.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnl_close.SuspendLayout();
            this.pnl_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvitemform);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(255, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 304);
            this.panel3.TabIndex = 23;
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
            this.name,
            this.size_item,
            this.style,
            this.quantity_item,
            this.rate_item,
            this.discount_item,
            this.netamount,
            this.edit,
            this.delete});
            this.dgvitemform.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvitemform.Location = new System.Drawing.Point(0, 0);
            this.dgvitemform.Name = "dgvitemform";
            this.dgvitemform.ReadOnly = true;
            this.dgvitemform.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvitemform.Size = new System.Drawing.Size(373, 304);
            this.dgvitemform.TabIndex = 1;
            this.dgvitemform.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvitemform_CellContentClick);
            this.dgvitemform.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvitemform_RowPostPaint);
            // 
            // row_id
            // 
            this.row_id.DataPropertyName = "row_id";
            this.row_id.HeaderText = "S.NO";
            this.row_id.Name = "row_id";
            this.row_id.ReadOnly = true;
            // 
            // name
            // 
            this.name.DataPropertyName = "item_name";
            this.name.HeaderText = "ITEM NAME";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // size_item
            // 
            this.size_item.DataPropertyName = "size";
            this.size_item.HeaderText = "SIZE";
            this.size_item.Name = "size_item";
            this.size_item.ReadOnly = true;
            // 
            // style
            // 
            this.style.DataPropertyName = "style_name";
            this.style.HeaderText = "STYLE NAME";
            this.style.Name = "style";
            this.style.ReadOnly = true;
            // 
            // quantity_item
            // 
            this.quantity_item.DataPropertyName = "quantity";
            this.quantity_item.HeaderText = "QUANTITY";
            this.quantity_item.Name = "quantity_item";
            this.quantity_item.ReadOnly = true;
            // 
            // rate_item
            // 
            this.rate_item.DataPropertyName = "rate";
            this.rate_item.HeaderText = "RATE";
            this.rate_item.Name = "rate_item";
            this.rate_item.ReadOnly = true;
            // 
            // discount_item
            // 
            this.discount_item.DataPropertyName = "discount";
            this.discount_item.HeaderText = "DISCOUNT";
            this.discount_item.Name = "discount_item";
            this.discount_item.ReadOnly = true;
            // 
            // netamount
            // 
            this.netamount.DataPropertyName = "total";
            this.netamount.HeaderText = "TOTAL";
            this.netamount.Name = "netamount";
            this.netamount.ReadOnly = true;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(628, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 304);
            this.panel2.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.DarkGray;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.10997F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.89003F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label26, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtcgst, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtsgst, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtigst, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.txtgst_value, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.txtnet_amount, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.txtroundoff, 1, 8);
            this.tableLayoutPanel2.Controls.Add(this.txtl_charge, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.txttrans, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.txtsubtotal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label18, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.label19, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label20, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label21, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label22, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label23, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label24, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox13, 0, 16);
            this.tableLayoutPanel2.Controls.Add(this.textBox14, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.textBox15, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.textBox16, 0, 15);
            this.tableLayoutPanel2.Controls.Add(this.label25, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 17;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(263, 304);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(3, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 28);
            this.label26.TabIndex = 50;
            this.label26.Text = "SGST";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtcgst
            // 
            this.txtcgst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcgst.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcgst.Location = new System.Drawing.Point(129, 63);
            this.txtcgst.Name = "txtcgst";
            this.txtcgst.Size = new System.Drawing.Size(131, 25);
            this.txtcgst.TabIndex = 45;
            this.txtcgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsgst
            // 
            this.txtsgst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsgst.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsgst.Location = new System.Drawing.Point(129, 93);
            this.txtsgst.Name = "txtsgst";
            this.txtsgst.Size = new System.Drawing.Size(131, 25);
            this.txtsgst.TabIndex = 44;
            this.txtsgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtigst
            // 
            this.txtigst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtigst.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigst.Location = new System.Drawing.Point(129, 121);
            this.txtigst.Name = "txtigst";
            this.txtigst.Size = new System.Drawing.Size(131, 25);
            this.txtigst.TabIndex = 46;
            this.txtigst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtgst_value
            // 
            this.txtgst_value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtgst_value.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgst_value.Location = new System.Drawing.Point(129, 154);
            this.txtgst_value.Name = "txtgst_value";
            this.txtgst_value.Size = new System.Drawing.Size(131, 25);
            this.txtgst_value.TabIndex = 47;
            this.txtgst_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtnet_amount
            // 
            this.txtnet_amount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtnet_amount.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet_amount.Location = new System.Drawing.Point(129, 273);
            this.txtnet_amount.Name = "txtnet_amount";
            this.txtnet_amount.ReadOnly = true;
            this.txtnet_amount.Size = new System.Drawing.Size(131, 25);
            this.txtnet_amount.TabIndex = 49;
            this.txtnet_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtroundoff
            // 
            this.txtroundoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtroundoff.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtroundoff.Location = new System.Drawing.Point(129, 240);
            this.txtroundoff.Name = "txtroundoff";
            this.txtroundoff.Size = new System.Drawing.Size(131, 25);
            this.txtroundoff.TabIndex = 48;
            this.txtroundoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtl_charge
            // 
            this.txtl_charge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtl_charge.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtl_charge.Location = new System.Drawing.Point(129, 212);
            this.txtl_charge.Name = "txtl_charge";
            this.txtl_charge.Size = new System.Drawing.Size(131, 25);
            this.txtl_charge.TabIndex = 47;
            this.txtl_charge.Text = "0";
            this.txtl_charge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txttrans
            // 
            this.txttrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttrans.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrans.Location = new System.Drawing.Point(129, 183);
            this.txttrans.Name = "txttrans";
            this.txttrans.Size = new System.Drawing.Size(131, 25);
            this.txttrans.TabIndex = 46;
            this.txttrans.Text = "0";
            this.txttrans.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtsubtotal.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(129, 35);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.Size = new System.Drawing.Size(131, 25);
            this.txtsubtotal.TabIndex = 43;
            this.txtsubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(3, 270);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 30);
            this.label18.TabIndex = 33;
            this.label18.Text = "Net Amount";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 237);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 33);
            this.label19.TabIndex = 32;
            this.label19.Text = "Round Off";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(3, 209);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 28);
            this.label20.TabIndex = 31;
            this.label20.Text = "Loading Charge";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(3, 180);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 29);
            this.label21.TabIndex = 30;
            this.label21.Text = "Transports";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(3, 151);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 29);
            this.label22.TabIndex = 29;
            this.label22.Text = "GST VALUE";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(3, 118);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 33);
            this.label23.TabIndex = 28;
            this.label23.Text = "IGST";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(3, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 30);
            this.label24.TabIndex = 27;
            this.label24.Text = "CGST";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox13
            // 
            this.textBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.Location = new System.Drawing.Point(129, 455);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(96, 22);
            this.textBox13.TabIndex = 25;
            // 
            // textBox14
            // 
            this.textBox14.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox14.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.Location = new System.Drawing.Point(129, 453);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(96, 22);
            this.textBox14.TabIndex = 24;
            // 
            // textBox15
            // 
            this.textBox15.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox15.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.Location = new System.Drawing.Point(3, 455);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(96, 22);
            this.textBox15.TabIndex = 13;
            // 
            // textBox16
            // 
            this.textBox16.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox16.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.Location = new System.Drawing.Point(3, 453);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(98, 22);
            this.textBox16.TabIndex = 12;
            this.textBox16.Text = "0";
            this.textBox16.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(3, 32);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 28);
            this.label25.TabIndex = 26;
            this.label25.Text = "Sub Total";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_quantity_sum);
            this.panel1.Controls.Add(this.txt_total_sum);
            this.panel1.Controls.Add(this.txt_sum_discount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(255, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 57);
            this.panel1.TabIndex = 21;
            // 
            // txt_quantity_sum
            // 
            this.txt_quantity_sum.Location = new System.Drawing.Point(167, 6);
            this.txt_quantity_sum.Name = "txt_quantity_sum";
            this.txt_quantity_sum.ReadOnly = true;
            this.txt_quantity_sum.Size = new System.Drawing.Size(65, 20);
            this.txt_quantity_sum.TabIndex = 9;
            // 
            // txt_total_sum
            // 
            this.txt_total_sum.Location = new System.Drawing.Point(419, 6);
            this.txt_total_sum.Name = "txt_total_sum";
            this.txt_total_sum.ReadOnly = true;
            this.txt_total_sum.Size = new System.Drawing.Size(64, 20);
            this.txt_total_sum.TabIndex = 8;
            this.txt_total_sum.TextChanged += new System.EventHandler(this.txt_total_sum_TextChanged);
            // 
            // txt_sum_discount
            // 
            this.txt_sum_discount.Location = new System.Drawing.Point(318, 6);
            this.txt_sum_discount.Name = "txt_sum_discount";
            this.txt_sum_discount.ReadOnly = true;
            this.txt_sum_discount.Size = new System.Drawing.Size(72, 20);
            this.txt_sum_discount.TabIndex = 12;
            this.txt_sum_discount.Visible = false;
            // 
            // pnl_right
            // 
            this.pnl_right.Controls.Add(this.panel4);
            this.pnl_right.Controls.Add(this.pnl_close);
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_right.Location = new System.Drawing.Point(0, 181);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(255, 361);
            this.pnl_right.TabIndex = 20;
            this.pnl_right.Visible = false;
            this.pnl_right.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_right_Paint_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 302);
            this.panel4.TabIndex = 1;
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
            this.tableLayoutPanel1.Controls.Add(this.textBox5, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.textBox6, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 302);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // txt_total
            // 
            this.txt_total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_total.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(125, 212);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(127, 25);
            this.txt_total.TabIndex = 49;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // txt_discount
            // 
            this.txt_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_discount.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_discount.Location = new System.Drawing.Point(125, 183);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(127, 25);
            this.txt_discount.TabIndex = 48;
            // 
            // txt_rate
            // 
            this.txt_rate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_rate.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rate.Location = new System.Drawing.Point(125, 154);
            this.txt_rate.Name = "txt_rate";
            this.txt_rate.Size = new System.Drawing.Size(127, 25);
            this.txt_rate.TabIndex = 47;
            this.txt_rate.TextChanged += new System.EventHandler(this.txt_rate_TextChanged_1);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_quantity.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(125, 121);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(127, 25);
            this.txt_quantity.TabIndex = 46;
            // 
            // txt_style
            // 
            this.txt_style.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_style.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_style.Location = new System.Drawing.Point(125, 93);
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(127, 25);
            this.txt_style.TabIndex = 45;
            // 
            // txt_size
            // 
            this.txt_size.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_size.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_size.Location = new System.Drawing.Point(125, 63);
            this.txt_size.Name = "txt_size";
            this.txt_size.Size = new System.Drawing.Size(127, 25);
            this.txt_size.TabIndex = 44;
            // 
            // txt_item
            // 
            this.txt_item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_item.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_item.Location = new System.Drawing.Point(125, 35);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(127, 25);
            this.txt_item.TabIndex = 43;
            // 
            // txt_no
            // 
            this.txt_no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_no.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_no.Location = new System.Drawing.Point(125, 3);
            this.txt_no.Name = "txt_no";
            this.txt_no.Size = new System.Drawing.Size(127, 25);
            this.txt_no.TabIndex = 42;
            this.txt_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_no.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(3, 209);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 28);
            this.label14.TabIndex = 33;
            this.label14.Text = "TOTAL";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "DISCOUNT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(3, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 29);
            this.label11.TabIndex = 31;
            this.label11.Text = "RATE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(3, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 33);
            this.label10.TabIndex = 30;
            this.label10.Text = "QUANTITY";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 28);
            this.label9.TabIndex = 29;
            this.label9.Text = "STYLE NAME";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 30);
            this.label8.TabIndex = 28;
            this.label8.Text = "SIZE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(3, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "ITEM NAME";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(125, 455);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(96, 22);
            this.textBox4.TabIndex = 25;
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
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(125, 453);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(96, 22);
            this.textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(3, 453);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(98, 22);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "0";
            this.textBox6.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 32);
            this.label13.TabIndex = 26;
            this.label13.Text = "S.NO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Visible = false;
            // 
            // pnl_close
            // 
            this.pnl_close.Controls.Add(this.btn_update);
            this.pnl_close.Controls.Add(this.btnok);
            this.pnl_close.Controls.Add(this.btnclose);
            this.pnl_close.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_close.Location = new System.Drawing.Point(0, 0);
            this.pnl_close.Name = "pnl_close";
            this.pnl_close.Size = new System.Drawing.Size(255, 59);
            this.pnl_close.TabIndex = 0;
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
            this.btn_update.Size = new System.Drawing.Size(57, 59);
            this.btn_update.TabIndex = 21;
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Visible = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
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
            this.btnok.Size = new System.Drawing.Size(57, 59);
            this.btnok.TabIndex = 20;
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
            this.btnclose.Size = new System.Drawing.Size(57, 59);
            this.btnclose.TabIndex = 19;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // pnl_top
            // 
            this.pnl_top.Controls.Add(this.txtinvoice);
            this.pnl_top.Controls.Add(this.user_box);
            this.pnl_top.Controls.Add(this.txtaddress);
            this.pnl_top.Controls.Add(this.txtcustomer);
            this.pnl_top.Controls.Add(this.txt_datetime);
            this.pnl_top.Controls.Add(this.btn_save);
            this.pnl_top.Controls.Add(this.btnadd);
            this.pnl_top.Controls.Add(this.label6);
            this.pnl_top.Controls.Add(this.label5);
            this.pnl_top.Controls.Add(this.label4);
            this.pnl_top.Controls.Add(this.txtnet_amountB);
            this.pnl_top.Controls.Add(this.label3);
            this.pnl_top.Controls.Add(this.label2);
            this.pnl_top.Controls.Add(this.label1);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(891, 181);
            this.pnl_top.TabIndex = 19;
            this.pnl_top.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_top_Paint);
            // 
            // txtinvoice
            // 
            this.txtinvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtinvoice.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.FormattingEnabled = true;
            this.txtinvoice.Location = new System.Drawing.Point(746, 74);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.Size = new System.Drawing.Size(121, 25);
            this.txtinvoice.TabIndex = 36;
            this.txtinvoice.SelectedIndexChanged += new System.EventHandler(this.txtinvoice_SelectedIndexChanged);
            this.txtinvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyDown_2);
            this.txtinvoice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtinvoice_KeyUp);
            // 
            // user_box
            // 
            this.user_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.user_box.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_box.FormattingEnabled = true;
            this.user_box.Location = new System.Drawing.Point(746, 119);
            this.user_box.Name = "user_box";
            this.user_box.Size = new System.Drawing.Size(121, 25);
            this.user_box.TabIndex = 35;
            // 
            // txtaddress
            // 
            this.txtaddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtaddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(122, 94);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtaddress.Size = new System.Drawing.Size(254, 69);
            this.txtaddress.TabIndex = 33;
            this.txtaddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtaddress_KeyDown);
            // 
            // txtcustomer
            // 
            this.txtcustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtcustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcustomer.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(122, 46);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(254, 25);
            this.txtcustomer.TabIndex = 32;
            this.txtcustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcustomer_KeyDown);
            this.txtcustomer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcustomer_KeyUp);
            // 
            // txt_datetime
            // 
            this.txt_datetime.CustomFormat = "dd/MM/yyyy";
            this.txt_datetime.Enabled = false;
            this.txt_datetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_datetime.Location = new System.Drawing.Point(756, 31);
            this.txt_datetime.Name = "txt_datetime";
            this.txt_datetime.Size = new System.Drawing.Size(111, 22);
            this.txt_datetime.TabIndex = 31;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(532, 114);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(37, 34);
            this.btn_save.TabIndex = 30;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btnadd
            // 
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.Location = new System.Drawing.Point(465, 118);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(38, 31);
            this.btnadd.TabIndex = 29;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(671, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "USER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(461, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "    INVOICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "INVOICE.NO";
            // 
            // txtnet_amountB
            // 
            this.txtnet_amountB.BackColor = System.Drawing.SystemColors.Control;
            this.txtnet_amountB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnet_amountB.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet_amountB.Location = new System.Drawing.Point(628, 147);
            this.txtnet_amountB.Name = "txtnet_amountB";
            this.txtnet_amountB.Size = new System.Drawing.Size(256, 28);
            this.txtnet_amountB.TabIndex = 42;
            this.txtnet_amountB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(671, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "    ADDRESS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "CUSTOMER";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // frm_invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 542);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_top);
            this.Name = "frm_invoice";
            this.Text = "frm_invoice";
            this.Load += new System.EventHandler(this.Frm_invoice_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvitemform)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_right.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnl_close.ResumeLayout(false);
            this.pnl_top.ResumeLayout(false);
            this.pnl_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvitemform;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtcgst;
        private System.Windows.Forms.TextBox txtsgst;
        private System.Windows.Forms.TextBox txtigst;
        private System.Windows.Forms.TextBox txtgst_value;
        private System.Windows.Forms.TextBox txtnet_amount;
        private System.Windows.Forms.TextBox txtroundoff;
        private System.Windows.Forms.TextBox txtl_charge;
        private System.Windows.Forms.TextBox txttrans;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_quantity_sum;
        private System.Windows.Forms.TextBox txt_total_sum;
        private System.Windows.Forms.TextBox txt_sum_discount;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.Panel panel4;
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnl_close;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.ComboBox txtinvoice;
        private System.Windows.Forms.ComboBox user_box;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcustomer;
        private System.Windows.Forms.DateTimePicker txt_datetime;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnet_amountB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn row_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn size_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn style;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn discount_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn netamount;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}