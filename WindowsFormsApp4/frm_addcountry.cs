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
    public partial class frm_addcountry : Form
    {
        public frm_addcountry()
        {
            InitializeComponent();
        }

        private void frm_addcountry_Load(object sender, EventArgs e)
        {
            //txtcountry.Text = Frmcountry.value;
            //txtcode.Text = Frmcountry.value1;
        }

        private void btnok_Click(object sender, EventArgs e)
        {

            if (txtcode.Text != "" && txtcountry.Text != "")
            {
                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                string qurey = "INSERT INTO [dbo].[M_COUNTRY](COUNTRY,COUNTRY_CODE,ACTIVE) VALUES('" + txtcountry.Text + "','" + txtcode.Text + "'," + "1" + ")";
                SqlConnection CONN = new SqlConnection(ConnString);
                CONN.Open();
                SqlCommand COMM = new SqlCommand(qurey, CONN);
                COMM.ExecuteNonQuery();
                CONN.Close();
                MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);

                txtcode.Text = "";
                txtcountry.Text = "";
            }
            else
            {
                MessageBox.Show("PLEASE ENTER THE VALUE", "MESSAGE", MessageBoxButtons.OK);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
