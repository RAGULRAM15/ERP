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
    public partial class Frmadd_entry : Form
    {
        public Frmadd_entry()
        {
            InitializeComponent();
        }

        private void Frmadd_entry_Load(object sender, EventArgs e)
        {
            txt1.Text = frm_entry.value;
        }

        private void btnok_Click(object sender, EventArgs e)
        {

            if (txt1.Text != "")
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                string qurey = "INSERT INTO [M_ENTRY](ENTRY_NAME,ACTIVE) VALUES('" + txt1.Text + "'," + "1" + ")";
                SqlConnection CONN = new SqlConnection(ConnString);
                CONN.Open();
                SqlCommand COMM = new SqlCommand(qurey, CONN);
                COMM.ExecuteNonQuery();
                CONN.Close();


                MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                txt1.Text = "";

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
