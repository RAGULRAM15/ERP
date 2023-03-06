using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp4
{
    public partial class frm_qut : Form
    {
        public frm_qut()
        {
            InitializeComponent();
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
        private void frm_qut_Load(object sender, EventArgs e)
        {
            btn_add.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_add.Width, btn_add.Height, 60, 70));
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT QUOTATION_NO,QUOTATION_DATE,CUSTOMER_NAME,TOTAL FROM T_QUOTATION";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                //SqlCommand comm = new SqlCommand(str, conn);
                //comm.Connection = conn;
                //comm.CommandText = str;
                SqlDataAdapter DA = new SqlDataAdapter(str, conn);
                DataSet DT = new DataSet();
                DA.Fill(DT);
                dtg_qut.DataSource = DT.Tables[0];
                conn.Close();

                //SqlDataReader dr = comm.ExecuteReader();
                //while (dr.Read())
                //{


                //    dtg_qut.Rows.Add(dr[1].ToString(),
                //       dr[2].ToString(), dr[5].ToString(), dr[4].ToString());

                //}
                //dr.Close();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            frmQouation newMDIChild = new frmQouation();
           // newMDIChild.MdiParent = frm_mid.ActiveForm;
            newMDIChild.Show();

            this.Hide();
        }
        public static string value1 { get; set; }
        public static string value2 { get; set; }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            frmQouation detialform = new frmQouation();
           // detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtg_qut.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_qut.Rows[rowIndex];
            value1 = edit_row.Cells["QUOTATION_NO"].Value.ToString();
            //value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.edit_form();
            detialform.Show();
            this.Hide();
        }

        private void dtg_qut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmQouation detialform = new frmQouation();
          //  detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtg_qut.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_qut.Rows[rowIndex];
            value1 = edit_row.Cells["QUOTATION_NO"].Value.ToString();
            //value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.edit_form();
            detialform.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int rowIndex = dtg_qut.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_qut.Rows[rowIndex];
            value1 = edit_row.Cells["QUOTATION_NO"].Value.ToString();
            txtquotation.Text = value1;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "DELETE FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            String sqlquery = "DELETE FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
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

        private void btn_view_Click(object sender, EventArgs e)
        {
            frmQouation detialform = new frmQouation();
            //detialform.MdiParent = frm_mid.ActiveForm;

            int rowIndex = dtg_qut.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dtg_qut.Rows[rowIndex];
            value1 = edit_row.Cells["QUOTATION_NO"].Value.ToString();
            // value2 = edit_row.Cells["CUSTOMER_NAME"].Value.ToString();
            detialform.view_form();
            detialform.Show();
            this.Hide();
        }
        public void refresh()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String str = "SELECT QUOTATION_NO,QUOTATION_DATE,CUSTOMER_NAME,TOTAL FROM T_QUOTATION";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                conn.Open();
                //SqlCommand comm = new SqlCommand(str, conn);
                //comm.Connection = conn;
                //comm.CommandText = str;
                SqlDataAdapter DA = new SqlDataAdapter(str, conn);
                DataSet DT = new DataSet();
                DA.Fill(DT);
                dtg_qut.DataSource = DT.Tables[0];
                conn.Close();
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
