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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
             frmadd_customer newMDIChild = new frmadd_customer();
           // newMDIChild.MdiParent = frm_mid.ActiveForm;
            newMDIChild.Show();

            this.Hide();
        }
        public static string value1 { get; set; }
        public static string value2 { get; set; }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            frmadd_customer detialform = new frmadd_customer();
            // detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];
            value1 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            value2 = edit_row.Cells["ID"].Value.ToString();
            //value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.edit_form();
            detialform.Show();
            this.Hide();
        }
        public void refresh()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME FROM M_CUSTOMER WHERE ACTIVE = 1";

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
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];
            value1 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            txt1.Text = value1;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "DELETE FROM M_CUSTOMER WHERE CUSTOMER_NAME = '" + txt1.Text + "'";
            //String sqlquery = "DELETE FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(SQLQuery, conn))
                {
                    comm.ExecuteNonQuery();
                }
                conn.Close();
            }
            refresh();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            frmadd_customer detialform = new frmadd_customer();
            // detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];
            value1 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            //value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.view_form();
            detialform.Show();
            this.Hide();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void txtcustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME, CUSTOMER_TITLE FROM M_CUSTOMER WHERE ACTIVE = 1";
                popup.ShowF2(_query, "CUSTOMER_NAME", ((TextBox)sender).Text, "CUSTOMER_NAME", sender);
            }
        }

        private void dtgF4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmadd_customer detialform = new frmadd_customer();
            // detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtgF4.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtgF4.Rows[rowIndex];
            value1 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
           value2 = edit_row.Cells[0].Value.ToString();
            detialform.edit_form();
            detialform.Show();
            this.Hide();
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {

            refresh();
        }
    }
}
