
namespace WindowsFormsApp4
{
    partial class frm_bank
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
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt_refresh = new System.Windows.Forms.Button();
            this.txt_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_add = new System.Windows.Forms.Button();
            this.dtgF4 = new System.Windows.Forms.DataGridView();
            this.txtbank = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgF4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(455, 29);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(10, 20);
            this.txt3.TabIndex = 43;
            this.txt3.Visible = false;
            // 
            // txt_refresh
            // 
            this.txt_refresh.Location = new System.Drawing.Point(374, 27);
            this.txt_refresh.Name = "txt_refresh";
            this.txt_refresh.Size = new System.Drawing.Size(75, 23);
            this.txt_refresh.TabIndex = 42;
            this.txt_refresh.Text = "&REFRESH";
            this.txt_refresh.UseVisualStyleBackColor = true;
            this.txt_refresh.Click += new System.EventHandler(this.txt_refresh_Click);
            // 
            // txt_delete
            // 
            this.txt_delete.Location = new System.Drawing.Point(273, 27);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(75, 23);
            this.txt_delete.TabIndex = 41;
            this.txt_delete.Text = "&DELETE";
            this.txt_delete.UseVisualStyleBackColor = true;
            this.txt_delete.Click += new System.EventHandler(this.txt_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(163, 27);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 40;
            this.btn_edit.Text = "&EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(57, 27);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(75, 23);
            this.txt_add.TabIndex = 39;
            this.txt_add.Text = "&add";
            this.txt_add.UseVisualStyleBackColor = true;
            this.txt_add.Click += new System.EventHandler(this.txt_add_Click);
            // 
            // dtgF4
            // 
            this.dtgF4.AllowUserToAddRows = false;
            this.dtgF4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgF4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(221)))), ((int)(((byte)(204)))));
            this.dtgF4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgF4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgF4.Location = new System.Drawing.Point(12, 107);
            this.dtgF4.Name = "dtgF4";
            this.dtgF4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgF4.Size = new System.Drawing.Size(490, 345);
            this.dtgF4.TabIndex = 38;
            this.dtgF4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgF4_CellDoubleClick);
            // 
            // txtbank
            // 
            this.txtbank.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbank.Location = new System.Drawing.Point(147, 77);
            this.txtbank.Name = "txtbank";
            this.txtbank.Size = new System.Drawing.Size(201, 24);
            this.txtbank.TabIndex = 37;
            this.txtbank.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbank_KeyDown);
            // 
            // frm_bank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 465);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt_refresh);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.dtgF4);
            this.Controls.Add(this.txtbank);
            this.Name = "frm_bank";
            this.Text = "frm_bank";
            this.Load += new System.EventHandler(this.frm_bank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgF4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button txt_refresh;
        private System.Windows.Forms.Button txt_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button txt_add;
        private System.Windows.Forms.DataGridView dtgF4;
        private System.Windows.Forms.TextBox txtbank;
    }
}