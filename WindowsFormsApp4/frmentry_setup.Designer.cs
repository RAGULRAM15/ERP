
namespace WindowsFormsApp4
{
    partial class frmentry_setup
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
            this.dtg_entrysetup = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_entrysetup)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_entrysetup
            // 
            this.dtg_entrysetup.AllowUserToAddRows = false;
            this.dtg_entrysetup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtg_entrysetup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dtg_entrysetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_entrysetup.Location = new System.Drawing.Point(12, 74);
            this.dtg_entrysetup.Name = "dtg_entrysetup";
            this.dtg_entrysetup.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtg_entrysetup.Size = new System.Drawing.Size(657, 266);
            this.dtg_entrysetup.TabIndex = 1;
            // 
            // frmentry_setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.dtg_entrysetup);
            this.Name = "frmentry_setup";
            this.Text = "frmentry_setup";
            this.Load += new System.EventHandler(this.frmentry_setup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_entrysetup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_entrysetup;
    }
}