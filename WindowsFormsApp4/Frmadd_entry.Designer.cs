﻿
namespace WindowsFormsApp4
{
    partial class Frmadd_entry
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(277, 92);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 56;
            this.btnclose.Text = "&CLOSE";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(140, 92);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 55;
            this.btnok.Text = "&SAVE";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(17, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(49, 17);
            this.lblSearch.TabIndex = 54;
            this.lblSearch.Text = "ENTRY";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(94, 35);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(267, 25);
            this.txt1.TabIndex = 53;
            // 
            // Frmadd_entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 144);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txt1);
            this.Name = "Frmadd_entry";
            this.Text = "Frmadd_entry";
            this.Load += new System.EventHandler(this.Frmadd_entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txt1;
    }
}