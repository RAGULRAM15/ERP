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
using System.Runtime.InteropServices;

namespace WindowsFormsApp4
{
    public partial class frm_invoice_main : Form
    {
        public frm_invoice_main()
        {
            InitializeComponent();
        }

        private void frm_invoice_main_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 60, 70));
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT INVOICE_NO,INVOICE_DATE,CUSTOMER_NAME,TOTAL FROM T_INVOICE";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                //SqlCommand comm = new SqlCommand(str, conn);
                //comm.Connection = conn;
                //comm.CommandText = str;
                SqlDataAdapter DA = new SqlDataAdapter(str, conn);
                DataSet DT = new DataSet();
                DA.Fill(DT);
                dtg_inv.DataSource = DT.Tables[0];
                conn.Close();
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            frm_invoice newMDIChild = new frm_invoice();
            //newMDIChild.MdiParent = frm_mid.ActiveForm;
            newMDIChild.Show();

            this.Hide();
        }
        public static string value1 { get; set; }
        public static string value2 { get; set; }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (int nTop,
          int nLeft,
          int nRight,
          int nBottum,
          int nWidthEllipse,
          int nHeightEllipse
         );

        private void dtg_inv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_invoice detialform = new frm_invoice();
          //  detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtg_inv.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_inv.Rows[rowIndex];
            value1 = edit_row.Cells["INVOICE_NO"].Value.ToString();
            //value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.edit_form1();
            detialform.Show();
            this.Hide();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frm_invoice detialform = new frm_invoice();
            //detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtg_inv.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_inv.Rows[rowIndex];
            value1 = edit_row.Cells["INVOICE_NO"].Value.ToString();
            //value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.edit_form1();
            detialform.Show();
            this.Hide();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            frm_invoice detialform = new frm_invoice();
           // detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtg_inv.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_inv.Rows[rowIndex];
            value1 = edit_row.Cells["INVOICE_NO"].Value.ToString();
            // value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.view_form1();
            detialform.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int rowIndex = dtg_inv.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_inv.Rows[rowIndex];
            value1 = edit_row.Cells["INVOICE_NO"].Value.ToString();
            txt_invoice.Text = value1;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "DELETE FROM T_INVOICE_ITEM WHERE INVOICE_NO = '" + txt_invoice.Text + "'";
            String sqlquery = "DELETE FROM T_INVOICE WHERE INVOICE_NO = '" + txt_invoice.Text + "'";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                using (SqlCommand comm = new SqlCommand(sqlquery, conn))
                {
                    comm.ExecuteNonQuery();
                }
                conn.Close();
            }



            try
            {

                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();
                    SqlCommand comm = new SqlCommand(sqlquery, conn);


                    comm.ExecuteNonQuery();

                    conn.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            refresh();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        public void refresh()
        {

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT INVOICE_NO,INVOICE_DATE,CUSTOMER_NAME,TOTAL FROM T_INVOICE";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                //SqlCommand comm = new SqlCommand(str, conn);
                //comm.Connection = conn;
                //comm.CommandText = str;
                SqlDataAdapter DA = new SqlDataAdapter(str, conn);
                DataSet DT = new DataSet();
                DA.Fill(DT);
                dtg_inv.DataSource = DT.Tables[0];
                conn.Close();
            }
        }
    }
}
