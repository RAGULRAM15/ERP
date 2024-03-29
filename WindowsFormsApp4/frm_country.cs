﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace IMS
{
    public partial class frm_country : Form
    {
        public frm_country()
        {
            InitializeComponent();
        }
        public static string value { get; set; }
        public static string value1 { get; set; }
        public static string value2 { get; set; }
        private void txt_add_Click(object sender, EventArgs e)
        {
            frm_addcountry f4 = new frm_addcountry();
            f4.MdiParent = frm_mid.ActiveForm;
            f4.MODE = "ADD COUNTRY";
            f4.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_addcountry f4 = new frm_addcountry();
             f4.MdiParent = frm_mid.ActiveForm;
            f4.MODE = "EDIT COUNTRY";
            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];
            value2 = edit_row.Cells[0].Value.ToString();
            value = edit_row.Cells[1].Value.ToString();
            value1 = edit_row.Cells[2].Value.ToString();
            f4.Show();
            this.Hide();
        }

        private void txt_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            txt3.Text = edit_row.Cells[0].Value.ToString();

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String sqlquery = "DELETE FROM M_COUNTRY WHERE COUNTRY_ID = '" + txt3.Text + "'";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sqlquery, conn))
                {
                    comm.ExecuteNonQuery();
                }
                conn.Close();

            }
            refresh();
        }
        public void refresh()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT COUNTRY_ID AS [ID], COUNTRY, COUNTRY_CODE FROM M_COUNTRY WHERE ACTIVE = 1";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                //SqlCommand comm = new SqlCommand(str, conn);
                //comm.Connection = conn;
                //comm.CommandText = str;
                SqlDataAdapter DA = new SqlDataAdapter(str, conn);
                DataSet DT = new DataSet();
                DA.Fill(DT);
                dtgF4.DataSource = DT.Tables[0];
                conn.Close();
            }
        }
        private void txt_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtcountry_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT COUNTRY_ID AS [ID], COUNTRY, COUNTRY_CODE FROM M_COUNTRY WHERE ACTIVE = 1";
                popup.ShowF2(_query, "Country", ((TextBox)sender).Text, "Country", sender);
            }
        }

        private void dtgF4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_addcountry f4 = new frm_addcountry();
             f4.MdiParent = frm_mid.ActiveForm;
            f4.MODE = "EDIT COUNTRY";
            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];
            value2 = edit_row.Cells[0].Value.ToString();
            value = edit_row.Cells[1].Value.ToString();
            value1 = edit_row.Cells[2].Value.ToString();
            f4.Show();
            this.Hide();
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (int nTop,
        int nLeft,
        int nRight,
        int nBottum,
        int nWidthEllipse,
        int nHeightEllipse
       );
        private void frm_country_Load(object sender, EventArgs e)
        {
            //dtgF4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtgF4.Width, dtgF4.Height, 20, 20));
            refresh();
        }

        private void txtcountry_TextChanged(object sender, EventArgs e)
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT COUNTRY_ID AS [ID], COUNTRY, COUNTRY_CODE FROM M_COUNTRY WHERE ACTIVE = 1";

            SqlConnection conn = new SqlConnection(ConnString);
            
                conn.Open();
                //SqlCommand comm = new SqlCommand(str, conn);
                //comm.Connection = conn;
                //comm.CommandText = str;
                SqlDataAdapter DA = new SqlDataAdapter(str, conn);
                DataSet DT = new DataSet();
                DA.Fill(DT);
                dtgF4.DataSource = DT.Tables[0];
                conn.Close();
            DataView dv = DT.Tables[0].DefaultView;
            dv.RowFilter ="COUNTRY LIKE '"+txtcountry.Text+"%'";
            dtgF4.DataSource = dv;
            
        }

        private void frm_country_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Alt)
            {
                this.Close();
            }
        }
    }
}
