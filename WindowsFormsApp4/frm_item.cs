using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class frm_item : Form
    {
        public frm_item()
        {
            InitializeComponent();
        }

        private void frm_item_Load(object sender, EventArgs e)
        {

        }

        private void txt_item_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //frmf5 popup = new frmf5();
                string _query = "SELECT ITEM_ID AS [ID], ITEM_NAME, HSN_CODE FROM M_ITEM WHERE ACTIVE = 1";
                //popup.ShowF2(_query, "ITEM_NAME", ((TextBox)sender).Text, "ITEM_NAME", sender);


            }
        }
    }
}
