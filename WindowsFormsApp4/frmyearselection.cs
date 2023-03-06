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
    public partial class frmyearselection : Form
    {
        public frmyearselection()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void cleartxt()
        {
            cmboyear.Text = "";
            cmboname.Text = "";
        }
        public void DROP()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = " SELECT FY_YEAR_ID, COMPANY FROM M_FY_YEAR WHERE ACTIVE =1 ";
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand comm = new SqlCommand(SQLQuery, conn);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = comm;
                    conn.Open();
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DOWN");

                    //SqlDataReader dr = comm.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    string item = dr[0].ToString();
                    //      txtquotation.Items.Add(item);

                    //dr.Close();
                    //DataTable dt = ds.Tables[0];
                    cmboname.DataSource = ds.Tables["DOWN"].DefaultView;
                    cmboname.DisplayMember = "COMPANY";
                    //cmboname.ValueMember = "COMPANY_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void DOWN()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT FY_YEAR_ID, FY_YEAR FROM M_FY_YEAR WHERE ACTIVE =1 ";

            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand comm = new SqlCommand(SQLQuery, conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = comm;
                conn.Open();
                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                da.Fill(ds, "drop");

                //SqlDataReader dr = comm.ExecuteReader();
                //while (dr.Read())
                //{
                //    string item = dr[0].ToString();
                //      txtquotation.Items.Add(item);

                //dr.Close();
                //DataTable dt = ds.Tables[0];
                cmboyear.DataSource = ds.Tables["drop"].DefaultView;
                cmboyear.DisplayMember = "FY_YEAR";
                cmboyear.ValueMember = "FY_YEAR_ID";
            }

        }
        public static string setcompanyname = "";
        public static string company_year = "";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (int nTop,
           int nLeft,
           int nRight,
           int nBottum,
           int nWidthEllipse,
           int nHeightEllipse
          );
        private void frmyearselection_Load(object sender, EventArgs e)
        {
            btnsubmit.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnsubmit.Width, btnsubmit.Height, 20, 20));
            btnclose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnclose.Width, btnclose.Height, 20, 20));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(3, 3, this.Width, this.Height, 20, 20));
            DROP();
            DOWN();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String Query;

            using (SqlConnection conn = new SqlConnection(ConnString))
            {

                //comm.Connection = conn;

                Query = @"INSERT INTO [F_YEAR] ([YEAR], [COMPANY], [ACTIVE], [CREATED_BY], [CREATED_ON]) VALUES ("

                             + "'" + cmboname.Text + "',"
                             + "'" + cmboyear.Text + "',"
                             + "" + "1" + ","
                            + "" + "1" + ","
                            + "" + "GETDATE()" + " )";

                //comm.CommandText = StrQuery;
                //"INSERT INTO [T_QUOTATION](QUOTATION_NO,QUOTATION_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME,ACTIVE) VALUES ("
                //+ "'" + txtquotation.Text + "',"
                //+ "'" + txt_datetime.Value.Date + "',"
                //+ "'" + txt_sum_discount.Text + "',"
                //+ "'" + txt_total_sum.Text + "',"
                //+ "'" + txtcustomer.Text + "',"
                //+ "'" + txtaddress.Text + "',"
                //+ "'" + user_box.Text + "',"
                //+ "'" + "1" + "')";


                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                comm.ExecuteNonQuery();
            }
            //frm_mid mdi = new frm_mid();
            //setcompanyname = cmboname.Text;
            //company_year = cmboyear.Text;
            ////mdi.ShowDialog();
            //mdi.Show();
            //this.Hide();

            cleartxt();
        }
    }
}
