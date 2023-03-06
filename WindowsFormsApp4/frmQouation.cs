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
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;



//       }        using System;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Windows.Forms;
//using System.Collections.Generic;
//+
//using System.ComponentModel;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Drawing.Drawing2D;
//using System.Runtime.InteropServices;

namespace WindowsFormsApp4
{
    public partial class frmQouation : Form
    {
        // private int borderradius = 40;
        private int bordersize = 0;
        private Color bordercolor = Color.White;
        //private int borderradius1 = 30;
        //private int bordersize1 = 0;
        private Color bordercolor1 = Color.White;
        public frmQouation()
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(bordersize);
        }


        int indexRow;
        //double multi;


        double deletedRowValue;
        double deletedRowValue1;
        // private object Session;

        void selecttxt(TextBox txt)
        {
            txt.BackColor = Color.FromArgb(139, 199, 255);
        }
        void leavetxt(TextBox txt)
        {
            txt.BackColor = Color.White;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pnlclose.Width == 266)
            {
                pnlclose.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    pnlclose.Width = pnlclose.Width - 30;

                }

            }
            else
            {
                pnlclose.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    pnlclose.Width = pnlclose.Width + 30;

                }

            }
            Timer.Stop();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnlright.Visible = true;
            pnlclose.Visible = true;

            //pnlTop.Enabled = true;


        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            pnlright.Visible = false;
            pnlclose.Visible = false;
            btn_update.Visible = false;
            txt_clear();


        }
        //private GraphicsPath GetFigurePath(RectangleF rect, float radius,float Width)
        //{
        //    radius = (int)Math.Max((Math.Min(radius, Math.Min(rect.Width, rect.Height)) - Width), 1);
        //    float r2 = radius / 2f;
        //    float  w2  = Width/ 2f;
        //    GraphicsPath path = new GraphicsPath();
        //   // float curvesize = radius + 2F;
        //    path.AddArc(rect.X+w2, rect.Y+w2, radius, radius, 180, 90);
        //    path.AddArc(rect.X ,rect.Width- radius-w2, rect.Y+w2, radius, 270, 90);
        //    path.AddArc(rect.X +rect.Width - w2- radius,rect.Y + rect.Height-w2 - radius, radius, radius, 0, 90);
        //    path.AddArc(rect.X+w2, rect.Y,rect.Height- radius, radius, 90, 90);
        //    path.AddLine(rect.X + w2, rect.Y + rect.Height - r2 - w2, rect.X + w2, rect.Y + r2 + w2);
        //    path.CloseFigure();
        //    return path;
        //}


        private void btnok_Click(object sender, EventArgs e)
        {
            String Connn = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String qry = " SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM  WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            if (txtquotation.Text != "")
            //if (txtquotation.focus)
            {



                using (SqlConnection conn = new SqlConnection(Connn))
                {
                    SqlCommand comm = new SqlCommand(qry, conn);

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(comm);

                    //da.(ds);
                    //da.Fill(dt);|| txt_quantity_sum.Text != ""
                    da.Fill(ds);


                    DataTable dt = ds.Tables[0];
                    //{
                    //int i;

                    //for (i = 0; i <= dgvitemform.Rows.Count; i++)
                    //{

                    //foreach (DataRow row in dt.Rows)
                    //{
                    //    
                    //DataGridViewRow row = new DataGridViewRow();
                    ////row.CreateCells(dgvitemform);
                    //while (i< dgvitemform.Rows.Count-i)
                    //{
                    DataRow row = dt.NewRow();



                    row["ITEM_NAME"] = txt_item.Text;
                    row["SIZE"] = txt_size.Text;
                    row["STYLE_NAME"] = txt_style.Text;
                    row["QUANTITY"] = txt_quantity.Text;
                    row["RATE"] = txt_rate.Text;
                    row["DISCOUNT"] = txt_discount.Text;
                    row["TOTAL"] = txt_total.Text;
                    dt.Rows.Add(row);

                    //i++;

                    //}

                    //}

                    // dt.Rows.Add(row);
                    //
                    dgvitemform.DataSource = dt;
                    //}
                    ///////    



                    //object Session = null;
                    //dgvitemform.DataBindings();
                    //Session["data_table"] = dt;

                    // }'/txtquotation.Text==@"SELECT*FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text+"'"
                    dgvitemform.Refresh();
                    sum_total();
                    //total_sum();
                    quantity_sum();
                }






                //
                //    string[] row = { item_name, size, style_name, quantity, rate, discount, total };
                //    dgvitemform.Rows.Add(row);


            }
            else
            {



                add_data(txt_no.Text, txt_item.Text, txt_size.Text, txt_style.Text, txt_quantity.Text, txt_rate.Text, txt_discount.Text, txt_total.Text);

                sum_total();


            }


            pnlright.Visible = false;
            txt_clear();
            btn_update.Visible = false;

            quantity_sum();
            // row_add();
            sum_dicount();



        }
        public void total_sum()
        {
            Double sum = 0;
            if (txt_total_sum.Text == "")
            {



                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Double.Parse(dgvitemform.Rows[i].Cells["total"].Value.ToString());

                }

                txt_total_sum.Text = sum.ToString();
            }


            else
            {
                if (txt_total_sum.Text != "" && txt_total_sum.Text == "")
                {

                    for (int j = 0; j < dgvitemform.Rows.Count; j++)
                    {
                        sum = ((Convert.ToDouble(txt_total_sum.Text)) + (Double.Parse(dgvitemform.Rows[j].Cells["total"].Value.ToString())));
                    }
                    txt_total_sum.Text = sum.ToString();
                }
            }
        }
        public void sum_dicount()
        {
            //Double sum = 0;
            //for (int i = 0; i < dgvitemform.Rows.Count; i++)
            //{
            //    sum += Double.Parse(dgvitemform.Rows[i].Cells[6].Value.ToString());
            //}
            //txt_sum_discount.Text = sum.ToString();
            //if (txt_total_sum.Text != "" && txt_sum_discount.Text != "")
            //{
            //    txt_total_sum.Text = Convert.ToString((1 - (Convert.ToDouble(txt_sum_discount.Text)) / 100.00) * (Convert.ToDouble(txt_total_sum)));
            //}
        }
        public void sum_total()
        {
            Double sum = 0;
            int i;


            for (i = 0; i < dgvitemform.Rows.Count; i++)
            {
                sum += Double.Parse(dgvitemform.Rows[i].Cells["total"].Value.ToString());

            }

            txt_total_sum.Text = sum.ToString();
            dgvitemform.Refresh();

            //else
            //{
            //    for (int j = 0; j > dgvitemform.Rows.Count; j--)

            //        {
            //            sum -= Double.Parse(dgvitemform.Rows[i].Cells[7].Value.ToString());
            //        }
            //    txt_total_sum.Text = sum.ToString();
            //    dgvitemform.Refresh();
            //}
        }
        public void quantity_sum()
        {
            Double sum = 0;
            if (txt_total_sum.Text != "")
            {
                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Double.Parse(dgvitemform.Rows[i].Cells["quantity"].Value.ToString());
                }
                txt_quantity_sum.Text = sum.ToString();
            }
        }
        //public void quotation_no()
        //{
        //    int i = 1;
        //    for (int x = 0; x < dgvitemform.Rows.Count; x++)
        //    {
        //        if (txtquotation.Text == string.Empty)
        //        {
        //            txtquotation.Text = i.ToString();
        //        }
        //        else
        //        {
        //            i = i + 1;
        //            txtquotation.Text = i.ToString();
        //        }
        //    }
        //}

        public void row_add()
        {

            int i = 1;
            for (int x = 0; x < dgvitemform.Rows.Count; x++)
            {
                if (txt_no.Text == string.Empty)
                {
                    txt_no.Text = i.ToString();
                }
                else
                {
                    i = i + 1;
                    txt_no.Text = i.ToString();
                }
            }

        }


        public void add_data(string row_id, string item_name, string size, string style_name, string quantity, string rate, string discount, string total)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(dgvitemform);

            newRow.Cells[0].Value = row_id;
            newRow.Cells[1].Value = item_name;
            newRow.Cells[2].Value = size;
            newRow.Cells[3].Value = style_name;
            newRow.Cells[4].Value = quantity;
            newRow.Cells[5].Value = rate;
            newRow.Cells[6].Value = discount;
            newRow.Cells[7].Value = total;

            dgvitemform.Rows.Add(newRow);







        }
        public void btnok__Click()
        {
            int rowIndex = dgvitemform.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dgvitemform.Rows[rowIndex];
            edit_row.Cells["row_id"].Value = txt_no.Text;
            edit_row.Cells["item_name"].Value = txt_item.Text;
            edit_row.Cells["size"].Value = txt_size.Text;
            edit_row.Cells["style_name"].Value = txt_style.Text;
            edit_row.Cells["quantity"].Value = txt_quantity.Text;
            edit_row.Cells["rate"].Value = txt_rate.Text;
            edit_row.Cells["discount"].Value = txt_discount.Text;
            edit_row.Cells["total"].Value = txt_total.Text;
        }
        public void txt_clear()
        {

            txt_item.Text = "";
            txt_size.Text = "";
            txt_style.Text = "";
            txt_quantity.Text = "";
            txt_rate.Text = "";
            txt_discount.Text = "";
            txt_total.Text = "";
        }
        public void clear()
        {
            txtcustomer.Text = "";
            txtaddress.Text = "";
            txtquotation.Text = "";
            user_box.Text = "";
            dgvitemform.DataSource = null;
            dgvitemform.Rows.Clear();
            //txt_no.Text = "1";
            txt_total_sum.Text = "";
            txt_quantity_sum.Text = "";


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";

            quotation_no();
            last_no();

            string StrQuery;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    using (SqlCommand comm = new SqlCommand())
                    {

                        comm.Connection = conn;
                        conn.Open();
                        //foreach (DataGridViewRow row in dgvitemform.Rows)
                        for (int i = 0; i < dgvitemform.Rows.Count; i++)
                        {
                            StrQuery = @"INSERT INTO [T_QUOTATION_ITEM](QUOTATION_NO,ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL,ACTIVE) VALUES ("
                              + "'" + txtquotation.Text + "',"
                              + "'" + dgvitemform.Rows[i].Cells["row_id"].Value + "', "
                              + "'" + dgvitemform.Rows[i].Cells["item_name"].Value + "' ,"
                              + "'" + dgvitemform.Rows[i].Cells["size"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["style_name"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["quantity"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["rate"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["discount"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["total"].Value + "',"
                              + "'" + "1" + "')";
                            comm.CommandText = StrQuery;
                            comm.ExecuteNonQuery();


                        }
                        // MessageBox.Show("UPLOADED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                        conn.Close();
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            String Query;
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                {

                    //comm.Connection = conn;

                    Query = @"INSERT INTO [T_QUOTATION](QUOTATION_NO,QUOTATION_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME,ACTIVE) VALUES ("
                                + "'" + txtquotation.Text + "',"
                                + "'" + txt_datetime.Value.Date + "',"
                                + "'" + txt_sum_discount.Text + "',"
                                + "'" + txt_quantity_sum.Text + "',"
                                + "'" + txt_total_sum.Text + "',"
                                + "'" + txtcustomer.Text + "',"
                                + "'" + txtaddress.Text + "',"
                                + "'" + user_box.Text + "',"
                                + "'" + "1" + "')";


                    //comm.CommandText = StrQuery;

                    SqlCommand comm = new SqlCommand(Query, conn);
                    conn.Open();
                    comm.ExecuteNonQuery();
                }



                MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                // conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear();
        }



        private void txt_datetime_ValueChanged(object sender, EventArgs e)
        {
            //txt_datetime. = false;
        }


        private void txt_rate_TextChanged(object sender, EventArgs e)
        {
            // double multi = 0;

            if (txt_rate.Text != "" && txt_quantity.Text != "")
            {
                txt_total.Text = (Convert.ToString(Convert.ToDouble(txt_rate.Text) * Convert.ToDouble(txt_quantity.Text)));
                //txt_total.Text = (double.Parse(txt_rate.Text) * (double.Parse(txt_quantity.Text))).ToString();
                // = multi.ToString();
            }
            //if (txt_quantity_sum.Text != "" && txt_quantity_sum.Text == "")
            //{
            //    txt_quantity.Text = double.Parse(txt_quantity.Text).ToString();
            //    txt_rate.Text = double.Parse(txt_rate.Text).ToString();
            //    txt_total.Text = double.Parse(txt_total.Text).ToString();
            //}
            // txt_total.Text = multi.ToString();

        }

        private void txt_discount_TextChanged_1(object sender, EventArgs e)
        {
            //if (txt_rate.Text != "" && txt_discount.Text != "")
            //{
            //    txt_total.Text = Convert.ToString((1 - (Convert.ToDouble(txt_discount.Text)) / 100.00) * (Convert.ToDouble(txt_rate.Text)));
            //}
        }

        [DllImport("user07.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user07.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {

            GraphicsPath path = new GraphicsPath();
            float curvesize = radius + 2F;
            path.AddArc(rect.X, rect.Y, curvesize, curvesize, 180, 90);
            path.AddArc(rect.Right - curvesize, rect.Y, curvesize, curvesize, 270, 90);
            path.AddArc(rect.Right - curvesize, rect.Bottom - curvesize, curvesize, curvesize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curvesize, curvesize, curvesize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private GraphicsPath GetRoundedPath1(Rectangle rect, float radius)
        {

            GraphicsPath path1 = new GraphicsPath();
            float curvesize1 = radius + 2F;
            path1.AddArc(rect.X, rect.Y, curvesize1, curvesize1, 180, 90);
            path1.AddArc(rect.Right - curvesize1, rect.Y, curvesize1, curvesize1, 270, 90);
            path1.AddArc(rect.Right - curvesize1, rect.Bottom - curvesize1, curvesize1, curvesize1, 0, 90);
            path1.AddArc(rect.X, rect.Bottom - curvesize1, curvesize1, curvesize1, 90, 90);
            path1.CloseFigure();
            return path1;
        }

        //private void FormRegionAndBorder(Frm_Quotation  Form, float radius, Graphics graph, Color borderColor, float bordersize)
        //{
        //    if (this.WindowState != FormWindowState.Minimized)
        //    {
        //        using (GraphicsPath roundpath = GetRoundedPath(Form.ClientRectangle, radius))
        //        using (Pen penborder = new Pen(borderColor, bordersize))
        //        using (Matrix transform = new Matrix())
        //        {
        //            graph.SmoothingMode = SmoothingMode.AntiAlias;
        //            Form.Region = new Region(roundpath);
        //            if (bordersize >= 1)
        //            {
        //                Rectangle rect = Form.ClientRectangle;
        //                float scaleX = 1.0f - (bordersize + 1) / rect.Width;
        //                float scaleY = 1.0f - (bordersize + 1) / rect.Height;

        //                transform.Scale(scaleX, scaleY);
        //                transform.Translate(bordersize / 1.6f, bordersize / 1.6f);
        //                graph.Transform = transform;
        //                graph.DrawPath(penborder, roundpath);
        //            }
        //        }
        //    }
        //}

        private void Frm_Quotation_Paint(object sender, PaintEventArgs e)
        {
            //FormRegionAndBorder(this, borderradius, e.Graphics, bordercolor, bordersize);
        }


        private void FormRegionAndBorder1(Panel pnlright, float radius, Graphics graph, Color bordercolor1, float bordersize1)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundpath = GetRoundedPath1(pnlright.ClientRectangle, radius))
                using (Pen penborder = new Pen(bordercolor1, bordersize1))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    pnlright.Region = new Region(roundpath);
                    if (bordersize1 >= 1)
                    {
                        Rectangle rect = pnlright.ClientRectangle;
                        float scaleX = 1.0f - (bordersize1 + 1) / rect.Width;
                        float scaleY = 1.0f - (bordersize1 + 1) / rect.Height;

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(bordersize1 / 1.6f, bordersize1 / 1.6f);
                        graph.Transform = transform;
                        graph.DrawPath(penborder, roundpath);
                    }
                }
            }
        }


        private void pnlright_Paint(object sender, PaintEventArgs e)
        {
            int borderradius1 = 30;
            int bordersize1 = 0;
            Color bordercolor1 = Color.Black;
            FormRegionAndBorder1(this.pnlright, borderradius1, e.Graphics, bordercolor1, bordersize1);
        }


        private void dgvitemform_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 

            if (dgvitemform.Columns[e.ColumnIndex].HeaderText == "EDIT")
            {

                DialogResult done = (MessageBox.Show("Are you sure want to Edit this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (done == DialogResult.Yes)
                {
                    indexRow = e.RowIndex;
                    DataGridViewRow row = this.dgvitemform.Rows[indexRow];
                    //int row = dgvitemform.SelectedCells[0].RowIndex;
                    //DataGridViewRow selectedRow = dgvitemform.Rows[row];


                    // txt_no.Text = row.Cells[0].Value.ToString();
                    txt_item.Text = row.Cells["item_name"].Value.ToString();
                    txt_size.Text = row.Cells["size"].Value.ToString();
                    txt_style.Text = row.Cells["style_name"].Value.ToString();
                    txt_quantity.Text = row.Cells["quantity"].Value.ToString();
                    txt_rate.Text = row.Cells["rate"].Value.ToString();
                    txt_discount.Text = row.Cells["discount"].Value.ToString();
                    txt_total.Text = row.Cells["total"].Value.ToString();



                    //btnok.Text = "";
                    //dgvitemform.Rows.RemoveAt(row);
                    //dgvitemform.Rows.Insert(row, selectedRow);






                    btn_update.Visible = true;
                    pnlright.Visible = true;
                    pnlright.Enabled = true;
                    pnlclose.Visible = true;
                    //dgvitemform.Refresh();




                }
                //txt_clear();

            }


            else
            {
                if (dgvitemform.Columns[e.ColumnIndex].HeaderText == "DELETE")
                {
                    int s_no;

                    DataGridViewRow selectedRow = dgvitemform.Rows[e.RowIndex];
                    s_no = Convert.ToInt32(selectedRow.Cells["row_id"].Value);
                    //MessageBox.Show(s_no.ToString());
                    DialogResult done = (MessageBox.Show("Are you sure want to Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    if (done == DialogResult.Yes)
                    {
                        if (s_no > 0)
                        {
                            int selectedRowIndex = dgvitemform.SelectedRows[0].Index;
                            dgvitemform.Rows.RemoveAt(selectedRowIndex);


                            MessageBox.Show("DELETED SUCCESSFULLY");
                            deletedRowValue = Convert.ToDouble(selectedRow.Cells[7].Value);
                            deletedRowValue1 = Convert.ToDouble(selectedRow.Cells[4].Value);
                            UpdateTotalValue();
                            sum_quantity_update();

                            if (txtquotation.Text != "")
                            {
                                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                                SqlConnection conn = new SqlConnection(ConnString);

                                string query = "DELETE  FROM T_QUOTATION_ITEM WHERE ROW_ID = selectedRowIndex";

                                SqlCommand command = new SqlCommand(query, conn);
                                command.ExecuteNonQuery();
                            }
                        }

                        //txt_total_sum.Text -= selectedRowIndex.ToString();

                        //
                        //SqlConnection conn = new SqlConnection(ConnString);



                        //    SqlCommand command = new SqlCommand("DELETE  FROM T_QUOTATION_ITEM WHERE ROW_ID= @row_id", conn);

                        //        command.CommandType = CommandType.Text;
                        //        command.Parameters.AddWithValue("@row_id", s_no);
                        //        conn.Open();
                        //        
                        //int rowIndex = dgvitemform.CurrentCell.RowIndex;
                        //dgvitemform.Rows.RemoveAt(rowIndex);
                        //
                        //            }

                        //    String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                        //    using (SqlConnection conn = new SqlConnection(ConnString))
                        //    {
                        //        try
                        //        {
                        //            using (SqlCommand command = new SqlCommand("DELETE  FROM T_QUOTATION_ITEM WHERE ROW_ID= @row_id", conn))
                        //            {
                        //                command.CommandType = CommandType.Text;
                        //                command.Parameters.AddWithValue("@row_id", ROW_ID);
                        //                conn.Open();
                        //                int result = command.ExecuteNonQuery();
                        //                if (result > 0)
                        //                {
                        //                    MessageBox.Show("DELETED SUCCESSFULLY");
                        //                }
                        //                else
                        //                {
                        //                    MessageBox.Show("DELETED FAILLED");
                        //                }
                        //                conn.Close();


                        //            }

                        //            dgvitemform.Refresh();

                        //        }
                        //        catch (Exception ex)
                        //        {
                        //            MessageBox.Show(ex.Message);
                        //        }
                        //    }
                        //    // this.dgvitemform.Rows.Delete(this.dgvitemform.CurrentRow);




                    }
                    dgvitemform.Refresh();


                }

            }




        }

        //public void total_update()
        //{
        //    int totalvalue1 = 0;

        //    foreach (DataGridViewRow row in dgvitemform.Rows)
        //    {
        //        //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
        //        totalvalue1 += Convert.ToInt32(row.Cells["total"].Value);
        //    }
        //    if (txt_quantity_sum.Text == "" && txt_quantity_sum.Text != "")
        //    {
        //        double updatedValue1 = Convert.ToInt32(txt_total_sum.Text) - deletedRowValue1 - totalvalue1;
        //        txt_total_sum.Text = updatedValue1.ToString();
        //    }

        //}
        private void UpdateTotalValue()
        {
            int totalvalue1 = 0;
            if (txtquotation.Text == "")
            {
                foreach (DataGridViewRow row in dgvitemform.Rows)
                {
                    //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                    totalvalue1 += Convert.ToInt32(row.Cells["total"].Value);
                }
                if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                {
                    double updatedValue1 = Convert.ToInt32(txt_total_sum.Text) - deletedRowValue /*+ totalvalue1*/;
                    txt_total_sum.Text = updatedValue1.ToString();
                }
            }
            else
            {
                if (txtquotation.Text != "")
                {
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                        //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                        totalvalue1 += Convert.ToInt32(row.Cells["total"].Value);
                    }
                    if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                    {
                        double updatedValue1 = /*Convert.ToInt32(txt_total_sum.Text)*/ -deletedRowValue + totalvalue1;
                        txt_total_sum.Text = updatedValue1.ToString();
                    }
                }
            }

        }
        public void sum_quantity_update()
        {
            int totalvalue1 = 0;
            if (txtquotation.Text == "")
            {
                foreach (DataGridViewRow row in dgvitemform.Rows)
                {
                    //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                    totalvalue1 += Convert.ToInt32(row.Cells["quantity"].Value);
                }
                if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                {
                    double updatedValue1 = Convert.ToInt32(txt_quantity_sum.Text) - deletedRowValue1 /*+ totalvalue1*/;
                    txt_quantity_sum.Text = updatedValue1.ToString();
                }
            }
            else
            {
                if (txtquotation.Text != "")
                {
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                        //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                        totalvalue1 += Convert.ToInt32(row.Cells["quantity"].Value);
                    }
                    if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                    {
                        double updatedValue1 = /*Convert.ToInt32(txt_total_sum.Text)*/ -deletedRowValue + totalvalue1;
                        txt_quantity_sum.Text = updatedValue1.ToString();
                    }
                }
            }
        }
        private void sum_edit_total()
        {
            int totalvalue1 = 0;
            //for(j = s_no; j >= dgvitemform.Rows.Count; j--)
            //{ 

            //for (i = 0; i < dgvitemform.Rows.Count; i++)
            //{
            foreach (DataGridViewRow row in dgvitemform.Rows)
            {
                //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                totalvalue1 += Convert.ToInt32(row.Cells["total"].Value);
            }
            //    double updatedValue = Convert.ToInt32(txt_total_sum.Text) - deletedRowValue - totalValue;
            if (txt_total_sum.Text == "" && txt_total_sum.Text != "")
            {
                double updatedValue1 = /*Convert.ToInt32(txt_quantity_sum.Text) */-deletedRowValue1 + totalvalue1;

                //    txt_total_sum.Text = updatedValue.ToString();
                txt_total_sum.Text = updatedValue1.ToString();
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {

            try
            {
                btnok__Click();
                total_sum();
                quantity_sum();
                pnlright.Visible = false;
                txt_clear();
                quantity_sum();
                sum_total();
                btn_update.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void in_update()
        {

        }

        private void Frm_Quotation_MouseDown(object sender, MouseEventArgs e)
        {
            //Releasecapture();
            //SendMessage(this.Handle, 0x112, 0x20000, 0);
        }
        public void connection()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            String sqlquery = "SELECT QUOTATION_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quation");
            dgvitemform.DataSource = ds.Tables["Quation"].DefaultView;
        }
        public void last_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // int s = Convert.ToInt32(textBox1.Text);
            int N = 1000000;
            for (int s = Convert.ToInt32(textBox1.Text); s <= N; s++)
            {
                s += 1;
                textBox1.Text = s.ToString();
                if (btn_save.Focused)
                {
                    break;
                }

            }

            {
                //

                SqlConnection conn = new SqlConnection(ConnString);


                //comm.Connection = conn;

                String Query = @"UPDATE  [M_ENTRY_SETUP] SET LAST_NO ="
                             + "'" + textBox1.Text + "' WHERE ENTRY_SETUP_ID =1";


                //comm.CommandText = StrQuery;

                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                comm.ExecuteNonQuery();



            }
        }
        public void quotation_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String Query = " SELECT CONCAT([PREFIIX],'-',[SUFFIX],'',[LAST_NO]) AS[QUOTATION_NO] FROM[M_ENTRY_SETUP] WHERE ENTRY_SETUP_ID = 1";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtquotation.Text = dr["QUOTATION_NO"].ToString();

                }
                dr.Close();
                conn.Close();
            }
        }

        private void QuationDataload_KeyDown(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
                String sqlquery = "SELECT QUOTATION_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "Quation");
                dgvitemform.DataSource = ds.Tables["Quation"].DefaultView;

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

                            txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                            txtaddress.Text = dr1["CUSTOMER_ADDRESS"].ToString();
                            txt_datetime.Value = Convert.ToDateTime(dr1["QUOTATION_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                            txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                            txt_total_sum.Text = dr1["TOTAL"].ToString();
                            user_box.Text = dr1["USER_NAME"].ToString();
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

        }
        public void edit_form()
        {
            txtquotation.Text = frm_qut.value1;
            txtcustomer.Text = frm_qut.value2;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            String sqlquery = "SELECT QUOTATION_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quation");
            dgvitemform.DataSource = ds.Tables["Quation"].DefaultView;

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

                        txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                        txtaddress.Text = dr1["CUSTOMER_ADDRESS"].ToString();
                        txt_datetime.Value = Convert.ToDateTime(dr1["QUOTATION_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_quantity_sum.Text = dr1["quantity"].ToString();
                        txt_total_sum.Text = dr1["TOTAL"].ToString();
                        user_box.Text = dr1["USER_NAME"].ToString();
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
        public void view_form()
        {
            txtquotation.Text = frm_qut.value1;
            txtcustomer.Text = frm_qut.value2;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            String sqlquery = "SELECT QUOTATION_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "Quation");
            dgvitemform.DataSource = ds.Tables["Quation"].DefaultView;

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

                        txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                        txtaddress.Text = dr1["CUSTOMER_ADDRESS"].ToString();
                        txt_datetime.Value = Convert.ToDateTime(dr1["QUOTATION_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_sum_discount.Text = dr1["quantity"].ToString();
                        txt_total_sum.Text = dr1["TOTAL"].ToString();
                        user_box.Text = dr1["USER_NAME"].ToString();
                    }
                    dr1.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtcustomer.ReadOnly = true;
            txtaddress.ReadOnly = true;
            txtquotation.Enabled = false;
            user_box.Enabled = false;
            dgvitemform.Enabled = false;
            btnadd.Enabled = false;
            btn_save.Enabled = false;

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




        public void drop_down()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT QUOTATION_ID, QUOTATION_NO FROM T_QUOTATION WHERE CUSTOMER_NAME  = '" + txtcustomer.Text + "'";
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
                    da.Fill(ds, "drop");

                    //SqlDataReader dr = comm.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    string item = dr[0].ToString();
                    //      txtquotation.Items.Add(item);

                    //dr.Close();
                    //DataTable dt = ds.Tables[0];
                    txtquotation.DataSource = ds.Tables["drop"].DefaultView;
                    txtquotation.DisplayMember = "QUOTATION_NO";
                    txtquotation.ValueMember = "QUOTATION_ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            //for (int i = 0; i < ds.Tables[0].Rows.Count;i++)
            //{
            //    txtquotation.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            //    conn.Close();
            //}
            ////txtquotation.DisplayMember = "QUOTATION_NO";



        }
        private void Frm_Quotation_Load(object sender, EventArgs e)
        {
            pnlclose.Width = 0;
            btnclose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnclose.Width, btnclose.Height, 70, 70));
            btnok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnok.Width, btnok.Height, 70, 70));
            btn_update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 70, 70));
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 30, 30));
            btnadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnadd.Width, btnadd.Height, 30, 30));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(3, 3, this.Width, this.Height, 20, 20));

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

            //if (/*txt_rate.Text != "" && txt_quantity.Text != ""*/ txt_total.Text !="")
            //{

            //    txt_total.Text = (double.Parse(txt_rate.Text) * (double.Parse(txt_quantity.Text))).ToString();
            //    // = multi.ToString();
            //}
        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {

            //txtcustomer.Text = txtcustomer.Tag.ToString();
        }

        private void txtquotation_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.F2)
            //{
            //    Frmf2 popup = new Frmf2();
            //    //string _query = "SELECT QUOTATIOAN_NO AS [ID], COUNTRY, COUNTRY_CODE FROM M_COUNTRY WHERE ACTIVE = 1";
            //    string _query = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            //    string _query1 = "SELECT QUOTATION_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
            //    popup.ShowF2(_query, "Quation", ((TextBox)sender).Text, "Quation", sender);
            //}
        }

        private void txtcustomer_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //frmf5 popup = new frmf5();
                string _query = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME, CUSTOMER_TITLE FROM M_CUSTOMER WHERE ACTIVE = 1";
                //popup.ShowF2(_query, "CUSTOMER_NAME", ((TextBox)sender).Text, "CUSTOMER_NAME", sender);


            }
        }

        private void txtquotation_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            //txtaddress.Text = txtaddress.Tag.ToString();
        }

        private void txtaddress_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //frmf5 popup = new frmf5();
                string _query = "SELECT CUSTOMER_ID AS [ID],CONCAT(ADDRESS_1,'   '," +
                    "S.CITY,'   ',K.DISTRICT,'   '," +
                    "L.STATE,'  ',CY.COUNTRY,'  '," +
                    "POSTAL_CODE," +
                    "'   PH:'," +
                    "PHONE_NO " +
                    ") AS[ADDRESS] FROM[M_CUSTOMER] AS D " +
                    "INNER JOIN[dbo].[M_CITY] AS S ON D.ACTIVE = S.ACTIVE  " +
                    "INNER JOIN[dbo].[M_DISTRICT] AS K ON D.ACTIVE = K.ACTIVE  " +
                    "INNER JOIN[dbo].[M_STATE] AS L ON D.ACTIVE = L.ACTIVE  " +
                    "INNER JOIN[dbo].[M_COUNTRY] AS CY ON D.ACTIVE = CY.ACTIVE " +
                    "WHERE S.CITY_ID = D.CITY_ID AND" +
                    " K.DISTRICT_ID = D.DISTRICT_ID AND" +
                    " L.STATE_ID = D.STATE_ID AND " +
                    "CY.COUNTRY_ID = D.COUNTRY_ID ";


              ///  popup.ShowF2(_query, "ADDRESS", ((TextBox)sender).Text, "ADDRESS", sender);
            }
        }
        public void concat_address(object sender, EventArgs e)
        {



        }

        private void txtcustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    btn_load.Visible = true;
            //   // drop_down();
            //}
        }

        private void btn_load_Click(object sender, EventArgs e)
        {

        }

        private void txtcustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                drop_down();
                // btn_load.Visible = true;
                // drop_down();
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void Frm_Quotation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
                String sqlquery = "SELECT QUOTATION_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_QUOTATION WHERE QUOTATION_NO = '" + txtquotation.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "Quation");
                dgvitemform.DataSource = ds.Tables["Quation"].DefaultView;

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

                            txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                            txtaddress.Text = dr1["CUSTOMER_ADDRESS"].ToString();
                            txt_datetime.Value = Convert.ToDateTime(dr1["QUOTATION_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                            txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                            txt_total_sum.Text = dr1["TOTAL"].ToString();
                            user_box.Text = dr1["USER_NAME"].ToString();
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
        }

        private void txtquotation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_item_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                //frmf5 popup = new frmf5();
                string _query = "SELECT ITEM_ID AS [ID], ITEM_NAME, HSN_CODE FROM M_ITEM WHERE ACTIVE = 1";
               // popup.ShowF2(_query, "ITEM_NAME", ((TextBox)sender).Text, "ITEM_NAME", sender);


            }
        }

        private void txt_size_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
               // frmf5 popup = new frmf5();
                string _query = "SELECT SIZE_ID AS [ID], SIZE_NAME FROM M_SIZE WHERE ACTIVE = 1";
               // popup.ShowF2(_query, "SIZE_NAME", ((TextBox)sender).Text, "SIZE_NAME", sender);


            }
        }
        private void dgvitemform_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvitemform.Rows[e.RowIndex].Cells["row_id"].Value = (e.RowIndex + 1).ToString();
        }
        // DataTable table;
        private void frmQouation_Load(object sender, EventArgs e)
        {
            //table = new DataTable();

            //table.Columns.Add("ID", typeof(int));
            //table.Columns.Add("FirstName", typeof(string));
            //table.Columns.Add("LastName", typeof(string));
            //table.Columns.Add("City", typeof(string));

            //table.Rows.Add(1, "Leon", "Ardon", "Paris");
            //table.Rows.Add(2, "Ben", "Jamir", "London");
            //table.Rows.Add(3, "Samuel", "Toe", "Berlin");
            //table.Rows.Add(4, "Lila", "Foe", "Madrid");

            //dgvItemList.DataSource = table;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataView dv = table.DefaultView;
            //dv.RowFilter = "FirstName LIKE '" + txtSearch.Text + "%'";
            //dgvItemList.DataSource = dv;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //DataView dv = table.DefaultView;
            //dv.RowFilter = "FirstName LIKE '" + txtSearch.Text + "%'";
            //dgvItemList.DataSource = dv;
        }

        private void dgvItemList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int ri = dgvItemList.CurrentRow.Index;
            //ri.ToString();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick1(object sender, EventArgs e)
        {

        }

        private void pnlright_Paint1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvitemform_CellContentClick1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_total_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_sum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sum_discount_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click1(object sender, EventArgs e)
        {

        }

        private void btn_save_Click1(object sender, EventArgs e)
        {

        }

        private void txt_datetime_ValueChanged1(object sender, EventArgs e)
        {

        }

        private void txtcustomer_TextChanged1(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged1(object sender, EventArgs e)
        {

        }

        private void user_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

       

        private void pnlclose_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txt_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_item_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_size_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_style_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void pnladd_page_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtcustomer_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
    }



    //string _query = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME, CUSTOMER_TITLE FROM M_CUSTOMER WHERE ACTIVE = 1";
    //string _query = "SELECT CUSTOMER_ID AS [ID],COALESCE('' +[ADDRESS_1], '' +[ADDRESS_2], '' +[ADDRESS_3], '') " +
    //    "+ COALESCE('' +[ADDRESS_4], '' +[CITY], '' +[DISTRICT_ID], '') +COALESCE('' +[STATE_ID], '' +[COUNTRY_ID], '') " +
    //    "+COALESCE('' +[POSTAL_CODE], '') " +
    //    "+ COALESCE('' +[PHONE_NO], '')" +
    //    "AS ADDRESS FROM M_CUSTOMER WHERE ACTIVE = 1";
    //string _query = "SELECT CUSTOMER_ID AS[ID],COALESCE('' +[ADDRESS_1], '' +[ADDRESS_2], '' +[ADDRESS_3], '') " +
    //    "+COALESCE('' +[ADDRESS_4], '' +[CITY_ID], '' +[DISTRICT_ID], '') +" +
    //    " COALESCE('' +[STATE_ID], '' +[COUNTRY_ID], '') +COALESCE('' +[POSTAL_CODE], '') +" +
    //    " COALESCE('' +[PHONE_NO], '')" +
    //    "AS ADDRESS FROM M_CUSTOMER WHERE ACTIVE = 1 ";



