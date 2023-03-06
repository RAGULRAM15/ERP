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
    public partial class frm_login : Form
    {
        public frm_login()
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
        private void frm_login_Load(object sender, EventArgs e)
        {
            btnlogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnlogin.Width, btnlogin.Height, 20, 20));
            btnclose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnclose.Width, btnclose.Height, 20, 20));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(3, 3, this.Width, this.Height, 20, 20));
            //.Region = Region.FromHrgn(CreateRoundRectRgn(3, 3, btnclose.Width, btnclose.Height, 20, 20));

        }

        String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
        private void btnlogin_Click(object sender, EventArgs e)
        {
            String Query;

            using (SqlConnection conn = new SqlConnection(ConnString))
            {

                //comm.Connection = conn;

                Query = @"INSERT INTO [F_LOGIN] ([USER_NAME], [PASSWORD], [ACTIVE], [CREATED_BY]) VALUES ("

                             + "'" + txtuser.Text + "',"
                             + "'" + txtpassword.Text + "',"
                             + "" + "1" + ","
                            + "" + "1" + " )";

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
            frmyearselection fys = new frmyearselection();
            fys.Show();
            this.Hide();


            //if (txtpassword.Text != string.Empty || txtuser.Text != string.Empty)
            //{
            //    try
            //    {


            //        String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //        using (SqlConnection conn = new SqlConnection(ConnString))
            //        {
            //            SqlCommand cmd = new SqlCommand("select * from F_LOGIN where USER_NAME='" + txtuser.Text + "' and PASSWORD='" + txtpassword.Text + "'");
            //            cmd.Connection = conn;
            //            SqlDataReader dr = cmd.ExecuteReader();
            //            if (dr.Read())
            //            {
            //                dr.Close();

            //                
            //            }

            //            else
            //            {
            //                dr.Close();
            //                MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //    }
            //    catch(Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if (txtuser.Text == "USER NAME" && txtpassword.Text == "USER PASSWORD")
            //{
            //    new Frmyearselection().Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Try Again...Check Your Username and Password");
            //    txtuser.Clear();
            //    txtpassword.Clear();
            //    txtuser.Focus();
            //}


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (txtpassword.PasswordChar == '*')
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '\0';

            }
            else
            {
                btnshow.BringToFront();
                txtpassword.PasswordChar = '*';
            }

            //btnshow.FlatStyle = FlatStyle.Flat;
            btnshow.FlatAppearance.BorderSize = 0;
        }
    }
}
