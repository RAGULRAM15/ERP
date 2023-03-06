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
    public partial class frmf5 : Form
    {
        public frmf5()
        {
            InitializeComponent(); 
            txtSearch.Focus();
        }
        private string _myText;
        public object _ct;

        //SQL Declarations
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True");
        DataSet ds = new DataSet();



        public string MyText
        {
            get
            {
                return _myText;
            }
            set
            {
                _myText = value;
                txtSearch.Text = value;
            }
        }
        public void ShowF2(string _sqlQuery, string _DispColName, string _txtValue, string _SearchName, object _Object)
        {
            txtSearch.Text = _txtValue; txtDataload.Text = _txtValue;
            this.Name = "Help " + _SearchName; lblSearch.Text = _DispColName;
            _ct = _Object;


            //Grid data load from SQL database
            con.Open(); //database connection open

            SqlDataAdapter da = new SqlDataAdapter(_sqlQuery, con);
            SqlCommandBuilder combuilder = new SqlCommandBuilder(da);

            da.Fill(ds);
            dgvHelp.DataSource = ds.Tables[0];

            con.Close(); //database connection close

            this.Show();
        }
        private void frmf5_Load(object sender, EventArgs e)
        {

        }

        private void dgvHelp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHelp.Rows.Count > 0)
            {
                try
                {
                    int selectedrowindex = dgvHelp.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvHelp.Rows[selectedrowindex];
                    txtDataload.Tag = Convert.ToString(selectedRow.Cells["ID"].Value);
                    txtDataload.Text = Convert.ToString(selectedRow.Cells[lblSearch.Text.ToUpper()].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = ds.Tables[0].DefaultView;
                dv.RowFilter = lblSearch.Text + " LIKE '" + txtSearch.Text.ToString() + "%'";
                dgvHelp.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnok_Click(object sender, EventArgs e)
        {

            _myText = txtSearch.Text;
            ((TextBox)_ct).Tag = txtDataload.Tag;
            ((TextBox)_ct).Text = txtDataload.Text;
            this.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
