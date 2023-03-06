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
    public partial class frmbank_add : Form
    {
        public frmbank_add()
        {
            InitializeComponent();
        }

        private void frmbank_add_Load(object sender, EventArgs e)
        {
            txt1.Text = frm_bank.value;
            txt2.Text = frm_bank.value1;
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "")
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                string qurey = "INSERT INTO [M_BANK](BANK,ACCOUNT_NO,ACTIVE) VALUES('" + txt1.Text + "'," + txt2.Text + "," + "1" + ")";
                SqlConnection CONN = new SqlConnection(ConnString);
                CONN.Open();
                SqlCommand COMM = new SqlCommand(qurey, CONN);
                COMM.ExecuteNonQuery();
                CONN.Close();


                MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                txt1.Text = "";
                txt2.Text = "";
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
