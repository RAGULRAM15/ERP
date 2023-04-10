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

namespace IMS
{
    public partial class frmadd_item : Form
    {
        public frmadd_item()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }

        private void btnok_Click(object sender, EventArgs e)
        {

            if (txt1.Text != ""&& txt2.Text=="")
            {
                {
                    String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                    string qurey = "INSERT INTO [M_ITEM](ITEM_NAME,HSN_CODE,CGST,SGST,IGST,SIZE,ACTIVE) VALUES('" + txt1.Text + "','" + txthsn.Text + "'," +

                        " '" + txtcgst.Text + "','" 
                        + txtsgst.Text + "','"
                         + txtigst.Text + "'," +
                           "'"+txt_right.Text + "'," +
                         "'" + "1" + "')";
                    SqlConnection CONN = new SqlConnection(ConnString);
                    CONN.Open();
                    SqlCommand COMM = new SqlCommand(qurey, CONN);
                    COMM.ExecuteNonQuery();
                    CONN.Close();
                }
                MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);
            }
            else if (txt2.Text != "")
            {
                txt2.Text = frm_item.value1;
                String Query;
                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    //INSERT (  ) VALUES ("
                    //comm.Connection = conn;

                    Query = @"UPDATE [dbo].[M_ITEM] SET 
                           [ITEM_NAME] =   '" + txt1.Text + "'," +
                        " [HSN_CODE] = '" + txthsn.Text + "', " +

                        "[CGST]=" + "'" + txtcgst.Text + "'" +
                        ",[SGST]=" + "'" + txtsgst.Text + "'" +
                         ",[IGST]=" + "'" + txtigst.Text + "'" +
                        ",[ACTIVE]=" + "" + "1" + "  " +
                        "WHERE ITEM_ID =  '" + txt2.Text + "'";





                    //comm.CommandText = StrQuery;

                    SqlCommand comm = new SqlCommand(Query, conn);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }
                MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);

            }

            else
            {
                MessageBox.Show("PLEASE ENTER THE VALUE", "MESSAGE", MessageBoxButtons.OK);
            }
            clear();
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {

        }
        public void edit_frm()
        {
            txt2.Text = frm_item.value1;
            txt1.Text = frm_item.value;
            // [M_CUSTOMER] (  [,[ACTIVE

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            //String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            String sqlquery = "SELECT ITEM_NAME,HSN_CODE,CGST,SGST,IGST FROM M_ITEM WHERE ITEM_NAME = '" + txt1.Text + "'";
            try
            {

                using (SqlConnection conn = new SqlConnection(ConnString))
                {

                    SqlCommand comm = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    SqlDataReader dr1 = comm.ExecuteReader();
                    SqlDataAdapter dr = new SqlDataAdapter(comm);
                    while (dr1.Read())
                    {

                        txt1.Text = dr1["ITEM_NAME"].ToString();
                        txthsn.Text = dr1["HSN_CODE"].ToString();
                        txtcgst.Text = dr1["CGST"].ToString(); /*(DateTime)dr.GetValue(2);*/
                        txtsgst.Text = dr1["SGST"].ToString();
                        txtigst.Text = dr1["IGST"].ToString();
                        


                    }
                    dr1.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void txt2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            txt1.Text = "";
            txtigst.Text = "";
            txtsgst.Text = "";
            txthsn.Text = "";
            txtcgst.Text = "";
            txt_right.Text = "";
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
        private void frmadd_item_Load(object sender, EventArgs e)
        {
            this.Text = MODE;
            drop();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            btnclose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnclose.Width, btnclose.Height, 20, 20));
            btnok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnok.Width, btnok.Height, 20, 20));
        }
        public void drop()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            string query = "select size_name from m_size";
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            StringBuilder sb = new StringBuilder();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               sb.AppendLine( dr["size_name"].ToString());
            }
            txt_left.Text = sb.ToString();
            dr.Close();
            conn.Close();
            //string data = (string)cmd.ExecuteScalar();
            //txt_left.Text = data;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //while (dt.Rows.Count > 0)
            //{
            //    txt_left.Text = dt.Rows[0]["size_name"].ToString();
            //}
            //txt_left.Datasource = dt;
            //txt_left.DataBindings = dt;


        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            //if (txt_left.SelectionLength > 0)
            //{
            //    string[] selectedline = txt_left.SelectedText.Split('\n');
            //    txt_right.Lines = selectedline;
            //}

            string[] selectedline = txt_left.SelectedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);

            StringBuilder sb = new StringBuilder(txt_right.Text);
            foreach(string line in selectedline)
            {
                sb.AppendLine(line);
               // sb.AppendLine("" + line);
            }
            txt_right.Text = sb.ToString();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            //if (txt_right.SelectionLength > 0)
            //{
            //    //string[] selectedline = txt_right.SelectedText.Split('\n');
            //    txt_right.SelectedText = "";

            //} string[] selectedline = txt_left.SelectedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            string[] selectedline = txt_right.SelectedText.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            StringBuilder sb = new StringBuilder(txt_left.Text);
            foreach (string line in selectedline)
            {
                sb.AppendLine(line);
                // sb.AppendLine("" + line);
            }
            txt_left.Text = sb.ToString();
            txt_right.SelectedText = string.Empty;
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            //int selectionstart = 0;

            //if (selectionstart > 0)
            //{
            //    selectionstart--;
            //    txt_right.Text = txt_right.Text.Substring(1);
            //}
            string selectedText = txt_right.SelectedText;
            int selectionStart = txt_right.SelectionStart;

            if (selectionStart > 0)
            {
                // Find the index of the previous character
                int previousCharIndex = selectionStart - 1;

                // Swap the selected text with the previous character
                string previousChar = txt_right.Text.Substring(previousCharIndex, 1);
                txt_right.Text = txt_right.Text.Remove(previousCharIndex, 1);
                txt_right.Text = txt_right.Text.Insert(previousCharIndex + selectedText.Length, previousChar);

                // Update the selection
                txt_right.Select(previousCharIndex, selectedText.Length);
            }



            txt_right.Focus();
        }

        private void DOWN_Click(object sender, EventArgs e)
        {


            //int selectionstart = 0;

            //if(selectionstart < txt_right.Text.Length)
            //{
            //    selectionstart++;
            //    txt_right.Text = "" + txt_right.Text;
            //}

            string selectedText = txt_right.SelectedText;
            int selectionStart = txt_right.SelectionStart;


            int lineIndex = txt_right.GetLineFromCharIndex(selectionStart);


            if (lineIndex == txt_right.Lines.Length - 1) return;


            int selectionLength = txt_right.SelectionLength;


            int prevLineIndex = txt_right.GetFirstCharIndexFromLine(lineIndex + 1);
            int prevLineLength = txt_right.Lines[lineIndex + 1].Length;





            txt_right.Text = txt_right.Text.Insert(prevLineIndex, txt_right.SelectedText);
            txt_right.Text = txt_right.Text.Remove(selectionStart, selectionLength);
            txt_right.SelectionStart = prevLineIndex;
            txt_right.SelectionLength = selectionLength;


            txt_right.Focus();
        }

        private void txt_right_MouseUp(object sender, MouseEventArgs e)
        {
            //int selectionstart = 0;

            //if (txt_right. SelectedText !="")
            //{
            //    txt_right.Text = txt_right.SelectedText;
            //    selectionstart = 0;
               
            //}
        }
        public string MODE { get; set; }
        private void frmadd_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Alt)
            {
                this.Close();
            }
        }
    }
}
//int selectionEnd = txt_right.SelectionEnd;

//if (selectionEnd < txt_right.Text.Length)
//{

//    int nextCharIndex = selectionEnd;

//    // Swap the selected text with the next character
//    string nextChar = txt_right.Text.Substring(nextCharIndex, 1);
//    txt_right.Text = txt_right.Text.Remove(nextCharIndex, 1);
//    txt_right.Text = txt_right.Text.Insert(nextCharIndex - selectedText.Length, nextChar);

//    // Update the selection
//    txt_right.Select(nextCharIndex - selectedText.Length, selectedText.Length);
//}
//string txtbefore = txt_right.Text.Substring(0, selectionStart);
//string txtafter = txt_right.Text.Substring(lineIndex);
//txt_right.Text = txtbefore + txtafter + selectedText;
//txt_right.Select(lineIndex, 0);




// string value1 = txt_right.Text.Trim();
//// string value2 = TextBox2.Text.Trim();


// string[] parts = value1.split(Environment.NewLine);
// string last_line = parts[parts.length - 1];


// value2 += (Environment.NewLine + last_line);


// parts[parts.Length - 1] = String.Empty;


// TextBox1.Text = String.Join(Environment.NewLine, parts).Trim();
// //TextBox2.Text = value2;

//int selectionStart = txt_right.SelectionStart;


//int lineIndex = txt_right.GetLineFromCharIndex(selectionStart);


//if (lineIndex == txt_right.Lines.Length+1) return;


//int selectionLength = txt_right.SelectionLength;


//int prevLineIndex = txt_right.GetFirstCharIndexFromLine(lineIndex - 1);
//int prevLineLength = txt_right.Lines[lineIndex - 1].Length;




//txt_right.Text = txt_right.Text.Insert(prevLineIndex, txt_right.SelectedText);
//txt_right.Text = txt_right.Text.Remove(selectionStart, selectionLength);

//txt_right.SelectionStart = prevLineIndex;
//txt_right.SelectionLength = selectionLength;
