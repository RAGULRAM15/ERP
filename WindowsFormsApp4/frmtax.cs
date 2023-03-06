using System;
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
    public partial class frmtax : Form
    {
        public frmtax()
        {
            InitializeComponent();
        }

        private void txt_add_Click(object sender, EventArgs e)
        {
            frmtax_add f4 = new frmtax_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            f4.Show();
            this.Hide();
        }
        public static string value { get; set; }
        public static string value1 { get; set; }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            frmtax_add f4 = new frmtax_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

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
            String sqlquery = "DELETE FROM M_TAX WHERE TAX_ID = '" + txt3.Text + "'";
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
            String str = "SELECT TAX_ID AS [ID], TAX, PERCENTAGE FROM M_TAX WHERE ACTIVE = 1";

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

        private void txttax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT TAX_ID AS [ID], TAX, PERCENTAGE FROM M_TAX WHERE ACTIVE = 1";
                //string _query=" SELECT DISTRICT_ID AS[ID], DISTRICT, S.STATE FROM[M_DISTRICT] DINNER JOIN[dbo].[M_STATE] S ON D.STATE_ID = S.STATE_ID WHERE D.ACTIVE = 1";
                popup.ShowF2(_query, "Tax", ((TextBox)sender).Text, "Tax", sender);
            }
        }

        private void dtgF4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmtax_add f4 = new frmtax_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            value = edit_row.Cells[1].Value.ToString();
            value1 = edit_row.Cells[2].Value.ToString();
            f4.Show();
            this.Hide();
        }

        private void frmtax_Load(object sender, EventArgs e)
        {
            refresh();

        }
    }
}
