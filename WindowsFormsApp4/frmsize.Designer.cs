
namespace WindowsFormsApp4
{
    partial class frmsize
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
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.txt_item = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(373, -6);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(10, 20);
            this.txt3.TabIndex = 43;
            this.txt3.Visible = false;
            // 
            // txt_refresh
            // 
            this.txt_refresh.FlatAppearance.BorderSize = 0;
            this.txt_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_refresh.Location = new System.Drawing.Point(277, 12);
            this.txt_refresh.Name = "txt_refresh";
            this.txt_refresh.Size = new System.Drawing.Size(75, 23);
            this.txt_refresh.TabIndex = 42;
            this.txt_refresh.Text = "&REFRESH";
            this.txt_refresh.UseVisualStyleBackColor = true;
            this.txt_refresh.Click += new System.EventHandler(this.txt_refresh_Click);
            // 
            // txt_delete
            // 
            this.txt_delete.FlatAppearance.BorderSize = 0;
            this.txt_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_delete.Location = new System.Drawing.Point(182, 12);
            this.txt_delete.Name = "txt_delete";
            this.txt_delete.Size = new System.Drawing.Size(75, 23);
            this.txt_delete.TabIndex = 41;
            this.txt_delete.Text = "&DELETE";
            this.txt_delete.UseVisualStyleBackColor = true;
            this.txt_delete.Click += new System.EventHandler(this.txt_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(78, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 40;
            this.btn_edit.Text = "&EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_add
            // 
            this.txt_add.FlatAppearance.BorderSize = 0;
            this.txt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_add.Location = new System.Drawing.Point(-3, 12);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(75, 23);
            this.txt_add.TabIndex = 39;
            this.txt_add.Text = "&add";
            this.txt_add.UseVisualStyleBackColor = true;
            this.txt_add.Click += new System.EventHandler(this.txt_add_Click);
            // 
            // dgv_item
            // 
            this.dgv_item.AllowUserToAddRows = false;
            this.dgv_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(11, 111);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(317, 311);
            this.dgv_item.TabIndex = 38;
            this.dgv_item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellDoubleClick);
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(62, 68);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(209, 20);
            this.txt_item.TabIndex = 37;
            this.txt_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_KeyDown);
            // 
            // frmsize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 461);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt_refresh);
            this.Controls.Add(this.txt_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_add);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.txt_item);
            this.Name = "frmsize";
            this.Text = "frmsize";
            this.Load += new System.EventHandler(this.frmsize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button txt_refresh;
        private System.Windows.Forms.Button txt_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button txt_add;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.TextBox txt_item;
    }
}