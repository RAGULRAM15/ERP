
namespace WindowsFormsApp4
{
    partial class frm_item
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
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.txt_item = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_item
            // 
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Location = new System.Drawing.Point(63, 127);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(317, 311);
            this.dgv_item.TabIndex = 3;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(110, 84);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(209, 20);
            this.txt_item.TabIndex = 2;
            this.txt_item.TextChanged += new System.EventHandler(this.txt_item_TextChanged);
            this.txt_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_item_KeyDown);
            // 
            // frm_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 450);
            this.Controls.Add(this.dgv_item);
            this.Controls.Add(this.txt_item);
            this.Name = "frm_item";
            this.Text = "frm_item";
            this.Load += new System.EventHandler(this.frm_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.TextBox txt_item;
    }
}