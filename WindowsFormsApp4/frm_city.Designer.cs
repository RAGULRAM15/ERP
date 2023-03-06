
namespace WindowsFormsApp4
{
    partial class frm_city
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
            this.txtcity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgF4)).BeginInit();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(484, 454);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(10, 20);
            this.txt3.TabIndex = 15;
            this.txt3.Visible = false;
            // 
            // txt_refresh
            // 
            this.txt_refresh.Location = new System.Drawing.Point(393, 11);
            this.txt_refresh.Name = "txt_refresh";
            this.txt_refresh.Size = new System.Drawing.Size(75, 23);
            this.txt_refresh.TabIndex = 14;
            this.txt_refresh.Text = "&REFRESH";
            this.txt_refresh.UseVisualStyleBackColor = true;
            this.txt_refresh.Click += new System.EventHandler(this.txt_refresh_Click);
            // 
            // txt_delete
            // 
            this.txt_delete.Location = new System.Drawing.Point(246, 11);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(75, 23);
            this.txt_delete.TabIndex = 13;
            this.txt_delete.Text = "&DELETE";
            this.txt_delete.UseVisualStyleBackColor = true;
            this.txt_delete.Click += new System.EventHandler(this.txt_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(110, 11);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 12;
            this.btn_edit.Text = "&EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(3, 11);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(75, 23);
            this.txt_add.TabIndex = 11;
            this.txt_add.Text = "&add";
            this.txt_add.UseVisualStyleBackColor = true;
            this.txt_add.Click += new System.EventHandler(this.txt_add_Click);
            // 
            // dtgF4
            // 
            this.dtgF4.AllowUserToAddRows = false;
            this.dtgF4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgF4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(235)))), ((int)(((byte)(242)))));
            this.dtgF4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgF4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgF4.Location = new System.Drawing.Point(27, 120);
            this.dtgF4.Name = "dtgF4";
            this.dtgF4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgF4.Size = new System.Drawing.Size(427, 333);
            this.dtgF4.TabIndex = 10;
            this.dtgF4.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgF4_CellDoubleClick);
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(110, 76);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(268, 24);
            this.txtcity.TabIndex = 9;
            this.txtcity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcity_KeyDown);
            // 
            // frm_city
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 486);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt_refresh);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.dtgF4);
            this.Controls.Add(this.txtcity);
            this.Name = "frm_city";
            this.Text = "frm_city";
            this.Load += new System.EventHandler(this.frm_city_Load);
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
        private System.Windows.Forms.TextBox txtcity;
    }
}