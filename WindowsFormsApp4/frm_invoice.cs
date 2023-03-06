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

namespace WindowsFormsApp4
{
    public partial class frm_invoice : Form
    {
        //private int borderradius = 40;
        private int bordersize = 0;
        private Color bordercolor = Color.White;
        //private int borderradius1 = 30;
        //private int bordersize1 = 0;
        private Color bordercolor1 = Color.White;
        public frm_invoice()
        {
            InitializeComponent();
            this.Padding = new Padding(bordersize);
        }
        int indexRow;
        //double multi;


        double deletedRowValue;
        double deletedRowValue1;
        private void txtcustomer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                //frmf5 popup = new frmf5();
                string _query = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME, CUSTOMER_TITLE FROM M_CUSTOMER WHERE ACTIVE = 1";
              //  popup.ShowF2(_query, "CUSTOMER_NAME", ((TextBox)sender).Text, "CUSTOMER_NAME", sender);
            }
        }
        private void Frm_invoice_Load(object sender, EventArgs e)
        {
            pnl_close.Width = 0;
            btnclose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnclose.Width, btnclose.Height, 70, 70));
            btnok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnok.Width, btnok.Height, 70, 70));
            btn_update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 70, 70));
            btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 30, 30));
            btnadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnadd.Width, btnadd.Height, 30, 30));
            this.Region = Region.FromHrgn(CreateRoundRectRgn(3, 3, this.Width, this.Height, 20, 20));

         
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            if (pnl_close.Width == 266)
            {
                pnl_close.Visible = true;
                for (int i = 0; i < 10; i++)
                {
                    pnl_close.Width = pnl_close.Width - 30;

                }

            }
            else
            {
                pnl_close.Visible = false;
                for (int i = 0; i < 10; i++)
                {
                    pnl_close.Width = pnl_close.Width + 30;

                }

            }
            Timer.Stop();
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            Timer.Start();
            pnl_right.Visible = true;
            pnl_close.Visible = true;
        }


        private void btnclose_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            pnl_right.Visible = false;
            pnl_close.Visible = false;
            btn_update.Visible = false;
            txt_clear();
        }


        private void btnok_Click(object sender, EventArgs e)
        {
            String Connn = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String qry = " SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_INVOICE_ITEM  WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
            if (txtinvoice.Text != "")
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



                    row[1] = txt_item.Text;
                    row[2] = txt_size.Text;
                    row[3] = txt_style.Text;
                    row[4] = txt_quantity.Text;
                    row[5] = txt_rate.Text;
                    row[6] = txt_discount.Text;
                    row[7] = txt_total.Text;
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

                    total_sum();
                    //total_sum();
                    quantity_sum();
                    sum_dicount();
                    subtotal();
                }






                //
                //    string[] row = { item_name, size, style_name, quantity, rate, discount, total };
                //    dgvitemform.Rows.Add(row);


            }
            else
            {



                add_data(txt_no.Text, txt_item.Text, txt_size.Text, txt_style.Text, txt_quantity.Text, txt_rate.Text, txt_discount.Text, txt_total.Text);

                sum_total();
                subtotal();


            }


            pnl_right.Visible = false;

            btn_update.Visible = false;

            quantity_sum();
            // row_add();
            sum_dicount();
            txt_clear();

        }
        //public void total_sum()
        //{
        //    Double sum = 0;
        //    if (txt_total_sum.Text == "")
        //    {



        //        for (int i = 0; i < dgvitemform.Rows.Count; i++)
        //        {
        //            sum += Double.Parse(dgvitemform.Rows[i].Cells["total"].Value.ToString());

        //        }

        //        txt_total_sum.Text = sum.ToString();

        //    }


        //    else
        //    {
        //        if (txt_total_sum.Text != "" && txt_total_sum.Text == "")
        //        {

        //            for (int j = 0; j < dgvitemform.Rows.Count; j++)
        //            {
        //                sum = ((Convert.ToDouble(txt_total_sum.Text)) + (Double.Parse(dgvitemform.Rows[j].Cells["total"].Value.ToString())));
        //            }
        //            txt_total_sum.Text = sum.ToString();

        //        }
        //    }

        //}
        public void total_sum()
        {
            double sum = 0;
            if (txt_total_sum.Text == "")
            {



                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

                }


                txt_total_sum.Text = sum.ToString();
            }


            else
            {
                if (txt_total_sum.Text != "" && txt_total_sum.Text == "")
                {

                    for (int j = 0; j < dgvitemform.Rows.Count; j++)
                    {
                        sum = ((Convert.ToDouble(txt_total_sum.Text)) + (Double.Parse(dgvitemform.Rows[j].Cells["netamount"].Value.ToString())));
                    }

                    txt_total_sum.Text = sum.ToString();
                }
            }





            //for (int i = 0; i < dgvitemform.Rows.Count; i++)
            //{
            //    sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

            //}




            //txt_total_sum.Text = sum.ToString();
        }
        public void subtotal()
        {
            double sum = 0;
            if (txt_total_sum.Text == "")
            {



                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

                }


                txtsubtotal.Text = sum.ToString();
            }


            else
            {
                if (txt_total_sum.Text != "" && txt_total_sum.Text == "")
                {

                    for (int j = 0; j < dgvitemform.Rows.Count; j++)
                    {
                        sum = ((Convert.ToDouble(txt_total_sum.Text)) + (Double.Parse(dgvitemform.Rows[j].Cells["total"].Value.ToString())));
                    }

                    txtsubtotal.Text = sum.ToString();
                }
            }





            for (int i = 0; i < dgvitemform.Rows.Count; i++)
            {
                sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

            }




            txtsubtotal.Text = sum.ToString();
        }
        public void sum_dicount()
        {
            Double sum = 0;
            if (txt_total_sum.Text != "")
            {
                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Double.Parse(dgvitemform.Rows[i].Cells[6].Value.ToString());
                }
                txt_sum_discount.Text = sum.ToString();
            }
            if (txt_total_sum.Text != "" && txt_sum_discount.Text != "")
            {
                txt_total_sum.Text = Convert.ToString((1 - (Convert.ToDouble(txt_sum_discount.Text)) / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));
            }
        }
        public void edit_form1()
        {
            txtinvoice.Text = frm_invoice_main.value1;
            txtcustomer.Text = frm_invoice_main.value2;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_INVOICE_ITEM WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
            String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_INVOICE WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "INVOICE");
            dgvitemform.DataSource = ds.Tables["INVOICE"].DefaultView;

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
                        txt_datetime.Value = Convert.ToDateTime(dr1["INVOICE_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_quantity_sum.Text = dr1["QUANTITY"].ToString();
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


        public void view_form1()
        {
            txtinvoice.Text = frm_invoice_main.value1;
            txtcustomer.Text = frm_invoice_main.value2;

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_INVOICE_ITEM WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
            String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_INVOICE WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "INVOICE");
            dgvitemform.DataSource = ds.Tables["INVOICE"].DefaultView;

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
                        txt_datetime.Value = Convert.ToDateTime(dr1["INVOICE_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_quantity_sum.Text = dr1["QUANTITY"].ToString();
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

        public void sum_total()
        {
            Double sum = 0;
            int i;


            for (i = 0; i < dgvitemform.Rows.Count; i++)
            {
                sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

            }

            txt_total_sum.Text = sum.ToString();
            txtsubtotal.Text = sum.ToString();
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
                    sum += Double.Parse(dgvitemform.Rows[i].Cells["quantity_item"].Value.ToString());
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
            edit_row.Cells["name"].Value = txt_item.Text;
            edit_row.Cells["size_item"].Value = txt_size.Text;
            edit_row.Cells["style"].Value = txt_style.Text;
            edit_row.Cells["quantity_item"].Value = txt_quantity.Text;
            edit_row.Cells["rate_item"].Value = txt_rate.Text;
            edit_row.Cells["discount_item"].Value = txt_discount.Text;
            edit_row.Cells["netamount"].Value = txt_total.Text;
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
            txtinvoice.Text = "";
            user_box.Text = "";
            dgvitemform.DataSource = null;
            dgvitemform.Rows.Clear();
            //txt_no.Text = "1";
            txt_total_sum.Text = "";
            txt_quantity_sum.Text = "";
            txtnet_amount.Text = "0";
            txtnet_amountB.Text = "0";
            txtl_charge.Text = "0";
            txtroundoff.Text = "0";
            txtsubtotal.Text = "0";
            txtsgst.Text = "0";
            txtcgst.Text = "0";
            txtigst.Text = "0";
            txtgst_value.Text = "0";


        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";

            invoice_no();
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
                            StrQuery = @"INSERT INTO [T_INVOICE_ITEM](INVOICE_NO,ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL,ACTIVE) VALUES ("
                              + "'" + txtinvoice.Text + "',"
                              + "'" + dgvitemform.Rows[i].Cells["row_id"].Value + "', "
                              + "'" + dgvitemform.Rows[i].Cells["name"].Value + "' ,"
                              + "'" + dgvitemform.Rows[i].Cells["size_item"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["style"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["quantity_item"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["rate_item"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["discount_item"].Value + "',"
                              + "'" + dgvitemform.Rows[i].Cells["netamount"].Value + "',"
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

                    Query = @"INSERT INTO [T_INVOICE](INVOICE_NO,INVOICE_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME,CGST,SGST,IGST,NET_AMOUNT,ACTIVE) VALUES ("
                                + "'" + txtinvoice.Text + "',"
                                + "'" + txt_datetime.Value.Date + "',"
                                + "'" + txt_sum_discount.Text + "',"
                                 + "'" + txt_quantity_sum.Text + "',"
                                + "'" + txt_total_sum.Text + "',"
                                + "'" + txtcustomer.Text + "',"
                                + "'" + txtaddress.Text + "',"
                                + "'" + user_box.Text + "',"
                                + "'" + txtcgst.Text + "',"
                                + "'" + txtsgst.Text + "',"
                                + "'" + txtigst.Text + "',"
                                + "'" + txtnet_amount.Text + "',"
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
        private void txt_rate_TextChanged_1(object sender, EventArgs e)
        {

            if (txt_rate.Text != "" && txt_quantity.Text != "")
            {
                txt_total.Text = (Convert.ToString(Convert.ToDouble(txt_rate.Text) * Convert.ToDouble(txt_quantity.Text)));
                //txt_total.Text = (double.Parse(txt_rate.Text) * (double.Parse(txt_quantity.Text))).ToString();
                // = multi.ToString();
            }
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
        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }
        private void pnl_right_Paint_1(object sender, PaintEventArgs e)
        {
            int borderradius1 = 30;
            int bordersize1 = 0;
            Color bordercolor1 = Color.Black;
            FormRegionAndBorder1(this.pnl_right, borderradius1, e.Graphics, bordercolor1, bordersize1);
        }
        private void dgvitemform_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
                    txt_item.Text = row.Cells["name"].Value.ToString();
                    txt_size.Text = row.Cells["size_item"].Value.ToString();
                    txt_style.Text = row.Cells["style"].Value.ToString();
                    txt_quantity.Text = row.Cells["quantity_item"].Value.ToString();
                    txt_rate.Text = row.Cells["rate_item"].Value.ToString();
                    txt_discount.Text = row.Cells["discount_item"].Value.ToString();
                    txt_total.Text = row.Cells["netamount"].Value.ToString();



                    //btnok.Text = "";
                    //dgvitemform.Rows.RemoveAt(row);
                    //dgvitemform.Rows.Insert(row, selectedRow);






                    btn_update.Visible = true;
                    pnl_right.Visible = true;
                    pnl_right.Enabled = true;
                    pnl_close.Visible = true;
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
                            if (txtinvoice.Text != "")
                            {
                                textBox16.Text = s_no.ToString();
                                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                                SqlConnection conn = new SqlConnection(ConnString);
                                conn.Open();
                                string query = "DELETE  FROM T_INVOICE_ITEM WHERE ROW_ID =   '" + textBox16.Text + "'";

                                SqlCommand command = new SqlCommand(query, conn);
                                command.ExecuteNonQuery();
                                conn.Close();
                            }

                            int selectedRowIndex = dgvitemform.SelectedRows[0].Index;
                            dgvitemform.Rows.RemoveAt(selectedRowIndex);


                            MessageBox.Show("DELETED SUCCESSFULLY");
                            deletedRowValue = Convert.ToDouble(selectedRow.Cells[7].Value);
                            deletedRowValue1 = Convert.ToDouble(selectedRow.Cells[4].Value);
                            UpdateTotalValue();
                            sum_quantity_update();
                            //total_update();
                            subup();
                         
                        }

                        //txt_total_sum.Text -= selectedRowIndex.ToString();

                        //String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                        //SqlConnection conn = new SqlConnection(ConnString);



                        //    SqlCommand command = new SqlCommand("DELETE  FROM T_QUOTATION_ITEM WHERE ROW_ID= @row_id", conn);

                        //        command.CommandType = CommandType.Text;
                        //        command.Parameters.AddWithValue("@row_id", s_no);
                        //        conn.Open();
                        //        command.ExecuteNonQuery();
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

        private void UpdateTotalValue()
        {
            int totalvalue1 = 0;
            if (txtinvoice.Text == "")
            {
                foreach (DataGridViewRow row in dgvitemform.Rows)
                {
                    //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                    totalvalue1 += Convert.ToInt32(row.Cells["netamount"].Value);
                }
                if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                {
                    double updatedValue1 = Convert.ToInt32(txt_total_sum.Text) - deletedRowValue /*+ totalvalue1*/;
                    txt_total_sum.Text = updatedValue1.ToString();
                }
            }
            else
            {
                if (txtinvoice.Text != "")
                {
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                        //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                        totalvalue1 += Convert.ToInt32(row.Cells["netamount"].Value);
                    }
                    if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                    {
                        double updatedValue1 = /*Convert.ToInt32(txt_total_sum.Text)*/ -deletedRowValue + totalvalue1;
                        txt_total_sum.Text = updatedValue1.ToString();
                    }
                }
            }

        }
        private void subup()
        {
            int totalvalue1 = 0;
            if (txtinvoice.Text == "")
            {
                foreach (DataGridViewRow row in dgvitemform.Rows)
                {
                    //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                    totalvalue1 += Convert.ToInt32(row.Cells["netamount"].Value);
                }
                if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                {
                    double updatedValue1 = Convert.ToInt32(txt_total_sum.Text) - deletedRowValue + totalvalue1;
                    txtsubtotal.Text = updatedValue1.ToString();
                }
            }
            else
            {
                if (txtinvoice.Text != "")
                {
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                        //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                        totalvalue1 += Convert.ToInt32(row.Cells["netamount"].Value);
                    }
                    if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                    {
                        double updatedValue1 = /*Convert.ToInt32(txt_total_sum.Text)*/ -deletedRowValue + totalvalue1;
                        txtsubtotal.Text = updatedValue1.ToString();
                    }
                }
            }

        }
        public void sum_quantity_update()
        {
            int totalvalue1 = 0;
            if (txtinvoice.Text == "")
            {
                foreach (DataGridViewRow row in dgvitemform.Rows)
                {
                    //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                    totalvalue1 += Convert.ToInt32(row.Cells["quantity_item"].Value);
                }
                if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                {
                    double updatedValue1 = Convert.ToInt32(txt_quantity_sum.Text) - deletedRowValue1 /*+ totalvalue1*/;
                    txt_quantity_sum.Text = updatedValue1.ToString();
                }
            }
            else
            {
                if (txtinvoice.Text != "")
                {
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                        //totalValue += Convert.ToInt32(dgvitemform.Rows[i].Cells[7].Value);
                        totalvalue1 += Convert.ToInt32(row.Cells["quantity_item"].Value);
                    }
                    if (txt_quantity_sum.Text == "" || txt_quantity_sum.Text != "")
                    {
                        double updatedValue1 = /*Convert.ToInt32(txt_total_sum.Text)*/ -deletedRowValue + totalvalue1;
                        txt_quantity_sum.Text = updatedValue1.ToString();
                    }
                }
            }
        }
        private void dgvitemform_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvitemform.Rows[e.RowIndex].Cells["row_id"].Value = (e.RowIndex + 1).ToString();
        }
        private void btn_update_Click_1(object sender, EventArgs e)
        {
            try
            {
                btnok__Click();
                total_sum();

                quantity_sum();
                pnl_right.Visible = false;
                txt_clear();
                quantity_sum();
                sum_total();
                subtotal();
                inv_update();
                btn_update.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void inv_update()
        {
            if (txtinvoice.Text != "")
            {
                int rowIndex = dgvitemform.CurrentCell.RowIndex;
                DataGridViewRow edit_row = dgvitemform.Rows[rowIndex];
                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                string qurey = @"UPDATE T_INVOICE_ITEM SET 
            ROW_ID =" + "'" + txt_no.Text + "' ," +
                " ITEM_NAME = " + "'" + txt_item.Text + "' ," +
                 " SIZE = " + "'" + txt_size.Text + "' ," +
                  " STYLE_NAME = " + "'" + txt_style.Text + "' ," +
                   " QUANTITY = " + "'" + txt_quantity.Text + "' ," +
                    " RATE = " + "'" + txt_rate.Text + "' ," +
                     " DISCOUNT = " + "'" + txt_discount.Text + "' ," +
                      " TOTAL = " + "'" + txt_total.Text + "' WHERE ROW_ID = " + "'" + txt_no.Text + "'";



                SqlConnection conn = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(qurey, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void last_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //int s = Convert.ToInt32(textBox1.Text);
            txt_item.Text = "0";
            int N = 1000000;
            for (int s = Convert.ToInt32(txt_item.Text); s <= N; s++)
            {
                s += 1;
                txt_item.Text = s.ToString();
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
                             + "'" + txt_item.Text + "' WHERE ENTRY_SETUP_ID =3";


                //comm.CommandText = StrQuery;

                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                comm.ExecuteNonQuery();



            }
        }
        public void invoice_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String Query = " SELECT CONCAT([PREFIIX],'-',[SUFFIX],'',[LAST_NO]) AS[INVOICE_NO] FROM[M_ENTRY_SETUP] WHERE ENTRY_SETUP_ID = 3";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txtinvoice.Text = dr["INVOICE_NO"].ToString();

                }
                dr.Close();
                conn.Close();
            }
        }


        public void drop_down()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT INVOICE_ID, INVOICE_NO FROM T_INVOICE WHERE CUSTOMER_NAME  = '" + txtcustomer.Text + "'";
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
                    txtinvoice.DataSource = ds.Tables["drop"].DefaultView;
                    txtinvoice.DisplayMember = "INVOICE_NO";
                    txtinvoice.ValueMember = "INVOICE_ID";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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


      
        private void txtinvoice_KeyDown_2(object sender, KeyEventArgs e)
        {

        }

        private void txtinvoice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_INVOICE_ITEM WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
                String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_INVOICE WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "INVOICE");
                dgvitemform.DataSource = ds.Tables["INVOICE"].DefaultView;

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
                            txt_datetime.Value = Convert.ToDateTime(dr1["INVOICE_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                            txt_sum_discount.Text = dr1["DISCOUNT"].ToString();
                            txt_quantity_sum.Text = dr1["QUANTITY"].ToString();
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
        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //frmf5 popup = new frmf5();
                string _query = "SELECT CUSTOMER_ID AS [ID],CONCAT(ADDRESS_1,'  ',ADDRESS_2,'  ',ADDRESS_3,'   ',ADDRESS_4,'  '," +
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


               // popup.ShowF2(_query, "ADDRESS", ((TextBox)sender).Text, "ADDRESS", sender);
            }
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

        private void txt_total_sum_TextChanged(object sender, EventArgs e)
        {
            double gst = 2.50;
            double igst = 12.00;
            if (txt_total_sum.Text != "")
            {
                txtsgst.Text = Convert.ToString((gst / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));
                txtcgst.Text = Convert.ToString((gst / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));


                txtigst.Text = Convert.ToString((igst / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));

                txtgst_value.Text = Convert.ToString(Convert.ToDouble(txtcgst.Text) + Convert.ToDouble(txtsgst.Text) + Convert.ToDouble(txtigst.Text));
            }
            if (txt_total_sum.Text != "")
            {
                double input = Convert.ToDouble(txtgst_value.Text) + Convert.ToDouble(txttrans.Text) + Convert.ToDouble(txtl_charge.Text) + Convert.ToDouble(txt_total_sum.Text);
                double result = Math.Round(input, 0);
                txtnet_amount.Text = result.ToString();
                txtnet_amountB.Text = result.ToString();
                // txtnet_amount.Text = Convert.ToString(Convert.ToDouble(txtgst_value.Text) + Convert.ToDouble(txttrans.Text) + Convert.ToDouble(txtl_charge.Text + Convert.ToDouble(txt_total_sum.Text)+Convert.ToDouble(txtroundoff.Text)));


            }
        }

        private void txtinvoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_top_Paint(object sender, PaintEventArgs e)
        {

        }
    }




}
