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

namespace WindowsFormsApp4
{
    public partial class frm_city : Form
    {
        public frm_city()
        {
            InitializeComponent();
        }

        private void dtgF4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmcity_add f4 = new frmcity_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            // value = edit_row.Cells[0].Value.ToString();
            value = edit_row.Cells[1].Value.ToString();
            value = edit_row.Cells[0].Value.ToString();
            //f4.Show();
            this.Hide();
        }

        private void txtcity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //Frmf2 popup = new Frmf2();
                //string _query = "SELECT CITY_ID AS [ID], CITY, CITY_CODE FROM M_CITY WHERE ACTIVE = 1";
                string _query = "SELECT CITY_ID AS [ID], CITY, S.DISTRICT FROM [M_CITY] D INNER JOIN[dbo].[M_DISTRICT] S ON D.DISTRICT_ID = S.DISTRICT_ID  WHERE D.ACTIVE = 1 ORDER BY[CITY_ID]";
                //string _query=" SELECT DISTRICT_ID AS[ID], DISTRICT, S.STATE FROM[M_DISTRICT] DINNER JOIN[dbo].[M_STATE] S ON D.STATE_ID = S.STATE_ID WHERE D.ACTIVE = 1";
                //popup.ShowF2(_query, "City", ((TextBox)sender).Text, "City", sender);
            }
        }
        public static string value { get; set; }
        public static string value1 { get; set; }


        private void txt_add_Click(object sender, EventArgs e)
        {
            //frmcity_add f4 = new frmcity_add();
            //f4.MdiParent = frm_mid.ActiveForm;

           // f4.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
           // frmcity_add f4 = new frmcity_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            // value = edit_row.Cells[0].Value.ToString();
            value = edit_row.Cells[1].Value.ToString();
            value = edit_row.Cells[0].Value.ToString();
          //  f4.Show();
            this.Hide();
        }

        private void txt_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            txt3.Text = edit_row.Cells[0].Value.ToString();

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String sqlquery = "DELETE FROM M_CITY WHERE CITY_ID = '" + txt3.Text + "'";
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

        private void txt_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void frm_city_Load(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT CITY_ID AS [ID], CITY, CITY_CODE FROM M_CITY WHERE ACTIVE = 1";

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
    }
}
