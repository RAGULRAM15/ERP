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
    public partial class frmtax_add : Form
    {
        public frmtax_add()
        {
            InitializeComponent();
        }

        private void frmtax_add_Load(object sender, EventArgs e)
        {
            txt1.Text = frmtax.value;
            txt2.Text = frmtax.value1;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (txt1.Text != "" && txt2.Text != "")
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                string qurey = "INSERT INTO [M_TAX](TAX,PERCENTAGE,ACTIVE,CREATED_ON) VALUES('" + txt1.Text + "'," + txt2.Text + "," + "1" + "," + "GETDATE()" + ")";
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
    }
}
