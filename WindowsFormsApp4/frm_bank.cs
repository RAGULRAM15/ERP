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
    public partial class frm_bank : Form
    {
        public frm_bank()
        {
            InitializeComponent();
        }

        private void txt_add_Click(object sender, EventArgs e)
        {
            frmbank_add f4 = new frmbank_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            f4.Show();
            this.Hide();
        }
        public static string value { get; set; }
        public static string value1 { get; set; }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            frmbank_add f4 = new frmbank_add();
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
            frmbank_add f4 = new    frmbank_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            value = edit_row.Cells[1].Value.ToString();
            value1 = edit_row.Cells[2].Value.ToString();
            f4.Show();
            this.Hide();
        }

        private void txt_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtbank_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                String Query = "SELECT BANK_ID AS [ID],BANK,ACCOUNT_NO FROM M_BANK";
                popup.ShowF2(Query, "BANK", ((TextBox)sender).Text, "BANK", sender);
            }
        }
        public void refresh()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT BANK,ACCOUNT_NO FROM M_BANK";

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
            private void dtgF4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmbank_add f4 = new frmbank_add();
            // f4.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];

            value = edit_row.Cells[1].Value.ToString();
            value1 = edit_row.Cells[2].Value.ToString();
            f4.Show();
            this.Hide();
        }

        private void frm_bank_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
