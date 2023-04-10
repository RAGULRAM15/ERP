﻿using System;
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

namespace IMS
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
        
        
        String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
        public string mode { get; set; }
        public string entry_name { get; set; }

       
        private void txtcustomer_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME, CUSTOMER_TITLE FROM M_CUSTOMER WHERE ACTIVE = 1";
                popup.ShowF2(_query, "CUSTOMER_NAME", ((TextBox)sender).Text, "CUSTOMER_NAME", sender);
            }

        }
        public void sales_order()
        {
           
        }
        public static string User_Name { get; set; }
        public void user()
        {
            String Query = "SELECT [USER] FROM  [M_USER_MANAGEMENT] WHERE USER_NAME = '" + lbluser.Text + "' ";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    user_box.Text = dr["USER"].ToString();

                }
                dr.Close();
                conn.Close();
            }
        }
        public void data_source()
        {
            String qry = "SELECT    QI.ROW_ID,MI.ITEM_NAME,MS.SIZE_NAME,STYLE_NAME,QI.QUANTITY,QI.RATE,QI.TOTAL,QI.ITEM_ID,QI.SIZE_ID FROM T_INVOICE_ITEM AS QI " +
              "INNER JOIN M_ITEM AS MI ON QI.ITEM_ID = MI.ITEM_ID" +
              " INNER JOIN M_SIZE AS MS ON QI.SIZE_ID = MS.SIZE_ID WHERE QI.INVOICE_NO = '" + txtinvoice.Text + "'";
            if (mode == "EDIT INVOICE")
            //if (txtquotation.focus)
            {



                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    SqlCommand comm = new SqlCommand(qry, conn);

                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(comm);

                    //da.(ds);
                    //da.Fill(dt);|| txt_quantity_sum.Text != ""
                    da.Fill(ds,"UPDATE");
                     dt = ds.Tables["UPDATE"];


                }
            }
        }
        DataTable dt = new DataTable();
        private void Frm_invoice_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            lbluser.Text = frm_invoice_list.user_name;
            lbl_comp.Tag = frm_invoice_list.comp_id;
            entry_name = frm_invoice_list.NAME_ID;
            

            data_source();
            //pnl_close.Width = 0;
            //drop_customer();
            user();
           



                    btn_close.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_close.Width, btn_close.Height, 70, 70));
                    //btnclose.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnclose.Width, btnclose.Height, 70, 70));
                    //btnok.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnok.Width, btnok.Height, 70, 70));
                    //btn_update.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_update.Width, btn_update.Height, 70, 70));
                    // btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 30, 30));
                    //btnadd.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnadd.Width, btnadd.Height, 30, 30));
                    //this.Region = Region.FromHrgn(CreateRoundRectRgn(3, 3, this.Width, this.Height, 20, 20));


        }



        //private void btnok_Click(object sender, EventArgs e)
        //{


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
        //DataRow row = dt.NewRow();



        //row[1] = txt_item.Text;
        //row[2] = txt_size.Text;
        //row[3] = txt_style.Text;
        //row[4] = txt_quantity.Text;
        //row[5] = txt_rate.Text;
        //row[6] = txt_discount.Text;
        //row[7] = txt_total.Text;
        //row[10] = txt_item.Tag;
        //row[11] = txt_size.Tag;
        //dt.Rows.Add(row);

        //i++;

        //}

        //}

        // dt.Rows.Add(row);
        //
        //dgvitemform.DataSource = dt;
        //}
        ///////    



        //object Session = null;
        //dgvitemform.DataBindings();
        //Session["data_table"] = dt;

        // }'/txtquotation.Text==@"SELECT*FROM T_QUOTATION_ITEM WHERE QUOTATION_NO = '" + txtquotation.Text+"'"

        //        }






        //        //
        //        //    string[] row = { item_name, size, style_name, quantity, rate, discount, total };
        //        //    dgvitemform.Rows.Add(row);


        //    }
        //    else
        //    {



        //        //add_data(txt_no.Text, txt_item.Text, txt_size.Text, txt_style.Text, txt_quantity.Text, txt_rate.Text, txt_discount.Text, txt_total.Text,txt_item.Tag,txt_size.Tag);

        //        sum_total1();
        //        subtotal();


        //    }


        //    //pnl_right.Visible = false;

        //    //btn_update.Visible = false;



        //}

        public void total_sum()
        {
            double sum = 0;




            if (txt_total_sum.Text == "") {

                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

                }


                txt_total_sum.Text = sum.ToString();

            }

            else
            {
                if (txt_total_sum.Text != "")
                {

                    for (int j = 0; j < dgvitemform.Rows.Count; j++)
                    {
                        sum = ((Convert.ToDouble(txt_total_sum.Text)) + (Double.Parse(dgvitemform.Rows[j].Cells["netamount"].Value.ToString())));
                    }

                    txt_total_sum.Text = sum.ToString();
                }
            }





            for (int i = 0; i < dgvitemform.Rows.Count; i++)
            {
                sum += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

            }




            txt_total_sum.Text = sum.ToString();
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

        }
        public void edit_form()
        {
            txtinvoice.Text = frm_invoice_list.value1;
            //// textBox3.Text = frm_invoice_list.value2;
            this.Text = mode;
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE_NAME,STYLE_NAME,QUANTITY,RATE,TOTAL,T_INVOICE_ITEM.ITEM_ID,T_INVOICE_ITEM.SIZE_ID FROM T_INVOICE_ITEM " +
             "INNER JOIN M_ITEM ON M_ITEM.ITEM_ID = T_INVOICE_ITEM.ITEM_ID " +
             "INNER JOIN  M_SIZE ON M_SIZE.SIZE_ID = T_INVOICE_ITEM.SIZE_ID " +
             "WHERE INVOICE_NO = '" + txtinvoice.Text + "' ";
            String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,QUANTITY,SUB_TOTAL,M_CUSTOMER.CUSTOMER_NAME,USER_NAME,CGST,SGST,IGST,NET_AMOUNT,T_INVOICE.CUSTOMER_ID,COMPANY_ID FROM T_INVOICE" +
                " INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_INVOICE.CUSTOMER_ID " +

                "WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
            //try
            //{
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "INVOICE");
                dgvitemform.DataSource = ds.Tables["INVOICE"].DefaultView;


                using (SqlConnection conn = new SqlConnection(ConnString))
                {

                    SqlCommand comm = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    SqlDataReader dr1 = comm.ExecuteReader();
                    SqlDataAdapter dr = new SqlDataAdapter(comm);
                    while (dr1.Read())
                {
                    lbl_comp.Tag = dr1["COMPANY_ID"].ToString();
                    txtcustomer.Tag = dr1["CUSTOMER_ID"].ToString();
                    txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                    
                    txt_datetime.Value = Convert.ToDateTime(dr1["INVOICE_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_quantity_sum.Text = dr1["QUANTITY"].ToString();
                        txt_total_sum.Text = dr1["SUB_TOTAL"].ToString();
                        user_box.Text = dr1["USER_NAME"].ToString();
                   
                    }
                    dr1.Close();
                    conn.Close();
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }


        public void view_form()
        {
            txtinvoice.Text = frm_invoice_list.value1;
            //txtcustomer.Text = frm_invoice_main.value2;
            this.Text = mode;
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE_NAME,STYLE_NAME,QUANTITY,RATE,TOTAL,T_INVOICE_ITEM.ITEM_ID,T_INVOICE_ITEM.SIZE_ID FROM T_INVOICE_ITEM " +
             "INNER JOIN M_ITEM ON M_ITEM.ITEM_ID = T_INVOICE_ITEM.ITEM_ID " +
             "INNER JOIN  M_SIZE ON M_SIZE.SIZE_ID = T_INVOICE_ITEM.SIZE_ID " +
             "WHERE INVOICE_NO = '" + txtinvoice.Text + "' ";
            String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,QUANTITY,SUB_TOTAL,M_CUSTOMER.CUSTOMER_NAME,USER_NAME,CGST,SGST,IGST,NET_AMOUNT,T_INVOICE.CUSTOMER_ID,COMPANY_ID FROM T_INVOICE" +
                " INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_INVOICE.CUSTOMER_ID " +

                "WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
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
                        lbl_comp.Tag = dr1["COMPANY_ID"].ToString();
                        txtcustomer.Tag = dr1["CUSTOMER_ID"].ToString();
                        txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                       
                        txt_datetime.Value = Convert.ToDateTime(dr1["INVOICE_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_quantity_sum.Text = dr1["QUANTITY"].ToString();
                        txt_total_sum.Text = dr1["SUB_TOTAL"].ToString();
                        user_box.Text = dr1["USER_NAME"].ToString();
                        txtcgst.Text = dr1["CGST"].ToString();
                        txtsgst.Text = dr1["SGST"].ToString();
                        txtigst.Text = dr1["IGST"].ToString();
                        txtnet_amount.Text = dr1["NET_AMOUNT"].ToString();

                    }
                    dr1.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtcustomer.Enabled = false;
            txtaddress.ReadOnly = true;
            txtinvoice.Enabled = false;
            user_box.Enabled = false;
            dgvitemform.Enabled = false;
            //btnadd.Enabled = false;
            btn_save.Enabled = false;
            btn_customer.Enabled = false;
        }
        public void DELETE_form()
        {

            // txtcustomer.Text = frm_qut.value2;
            //btn_clear.Visible = true;
            txtinvoice.Text = frm_invoice_list.value1;
            //txtcustomer.Text = frm_invoice_main.value2;
            this.Text = mode;
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            // String str = "Select * from T_QUOTATION_ITEM";
            String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE_NAME,STYLE_NAME,QUANTITY,RATE,TOTAL,T_INVOICE_ITEM.ITEM_ID,T_INVOICE_ITEM.SIZE_ID FROM T_INVOICE_ITEM " +
            "INNER JOIN M_ITEM ON M_ITEM.ITEM_ID = T_INVOICE_ITEM.ITEM_ID " +
            "INNER JOIN  M_SIZE ON M_SIZE.SIZE_ID = T_INVOICE_ITEM.SIZE_ID " +
            "WHERE INVOICE_NO = '" + txtinvoice.Text + "' ";
            String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,QUANTITY,SUB_TOTAL,M_CUSTOMER.CUSTOMER_NAME,USER_NAME,CGST,SGST,IGST,NET_AMOUNT,T_INVOICE.CUSTOMER_ID,COMPANY_ID FROM T_INVOICE" +
                " INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_INVOICE.CUSTOMER_ID " +

                "WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
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
                        lbl_comp.Tag = dr1["COMPANY_ID"].ToString();
                        txtcustomer.Tag = dr1["CUSTOMER_ID"].ToString();
                        txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();
                       
                        txt_datetime.Value = Convert.ToDateTime(dr1["INVOICE_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                        txt_discount.Text = dr1["DISCOUNT"].ToString();
                        txt_quantity_sum.Text = dr1["QUANTITY"].ToString();
                        txt_total_sum.Text = dr1["SUB_TOTAL"].ToString();
                        user_box.Text = dr1["USER_NAME"].ToString();
                        txtcgst.Text = dr1["CGST"].ToString();
                        txtsgst.Text = dr1["SGST"].ToString();
                        txtigst.Text = dr1["IGST"].ToString();
                        txtnet_amount.Text = dr1["NET_AMOUNT"].ToString();

                    }
                    dr1.Close();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtcustomer.Enabled = false;
            txtaddress.ReadOnly = true;
            txtinvoice.Enabled = false;
            user_box.Enabled = false;
            dgvitemform.Enabled = false;
            btn_customer.Enabled = false;
            //btnadd.Enabled = false;

        }
        public void print_form()
        {

            //if (printPreviewDialog.ShowDialog() != 0)
            //{

            //    System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            //    PrintDialog1.AllowSomePages = true;
            //    PrintDialog1.ShowHelp = true;
            //    PrintDialog1.Document = printDocument;
            //    DialogResult result = PrintDialog1.ShowDialog();
            //    if (result == DialogResult.OK)
            //    {
            //        printDocument.Print();
            //    }
            //    refresh();
            //}
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
       
      


        public void add_data(string row_id, string item_name, string size, string style_name, string quantity, string rate, string discount, string total, Object item_id, object size_id)
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
            newRow.Cells[10].Value = item_id;
            newRow.Cells[11].Value = size_id;

            dgvitemform.Rows.Add(newRow);







        }
        public void btnok__Click()
        {
            int rowIndex = dgvitemform.CurrentCell.RowIndex;
            DataGridViewRow edit_row = dgvitemform.Rows[rowIndex];
            //edit_row.Cells["row_id"].Value = txt_no.Text;
            //edit_row.Cells["name"].Value = txt_item.Text;
            //edit_row.Cells["size_item"].Value = txt_size.Text;
            //edit_row.Cells["style"].Value = txt_style.Text;
            //edit_row.Cells["quantity_item"].Value = txt_quantity.Text;
            //edit_row.Cells["rate_item"].Value = txt_rate.Text;
            //edit_row.Cells["discount_item"].Value = txt_discount.Text;
            //edit_row.Cells["netamount"].Value = txt_total.Text;
            //edit_row.Cells["item_id"].Value = txt_item.Tag;
            //edit_row.Cells["size_id"].Value = txt_item.Tag;
        }
        public void txt_clear()
        {

            //txt_item.Text = "";
            //txt_size.Text = "";
            //txt_style.Text = "";
            //txt_quantity.Text = "";
            //txt_rate.Text = "";
            //txt_discount.Text = "";
            //txt_total.Text = "";
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
            txt_discount.Text = "0";

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dgvitemform.Rows.Count != 0 && txtcustomer.Text != "" && txtnet_amount.Text != "" && txt_total_sum.Text != "")
            {
                if (mode == "ADD")
                {

                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        conn.Open();
                        SqlTransaction Transaction = conn.BeginTransaction();





                        String StrQuery;
                        String Query;
                        try
                        {

                            last_no();
                            invoice_no();
                            SqlCommand comm = new SqlCommand();
                            comm.Connection = conn;


                            StringBuilder sb = new StringBuilder();

                            String invoice_update = @"UPDATE  [M_ENTRY_SETUP] SET LAST_NO ="
                                + "'" + textBox15.Text + "'    WHERE COMPANY_ID=" + lbl_comp.Tag + " AND ENTRY_ID = " + entry_name + "";


                            Query = @"INSERT INTO [T_INVOICE](INVOICE_NO,INVOICE_DATE,DISCOUNT,QUANTITY,SUB_TOTAL,CUSTOMER_ID,USER_NAME,CGST,SGST,IGST,NET_AMOUNT,COMPANY_ID,STATUS,ACTIVE) VALUES ("
                                       + "'" + txtinvoice.Text + "',"
                                       + "'" + txt_datetime.Value.Date + "',"
                                       + "'" + txt_discount.Text + "',"
                                        + "'" + txt_quantity_sum.Text + "',"
                                       + "'" + txt_total_sum.Text + "',"
                                       + "'" + txtcustomer.Tag + "',"
                                     
                                       + "'" + user_box.Text + "',"
                                       + "'" + txtcgst.Text + "',"
                                       + "'" + txtsgst.Text + "',"
                                       + "'" + txtigst.Text + "',"
                                       + "'" + txtnet_amount.Text + "',"
                                        + "'" + lbl_comp.Tag + "',"
                                       + "'" + "ACTIVE" + "',"
                                       + "'" + "1" + "')";
                            sb.Append(Query);
                            //foreach (DataGridViewRow row in dgvitemform.Rows)
                            for (int i = 0; i < dgvitemform.Rows.Count; i++)
                            {
                                StrQuery = @"INSERT INTO [T_INVOICE_ITEM](INVOICE_NO,ROW_ID,ITEM_ID,SIZE_ID,STYLE_NAME,QUANTITY,RATE,TOTAL,ACTIVE) VALUES ("
                                  + "'" + txtinvoice.Text + "',"
                                  + "'" + dgvitemform.Rows[i].Cells["row_id"].Value + "', "
                                  + "'" + dgvitemform.Rows[i].Cells["item_id"].Value + "' ,"
                                  + "'" + dgvitemform.Rows[i].Cells["size_id"].Value + "',"
                                  + "'" + dgvitemform.Rows[i].Cells["style"].Value + "',"
                                  + "'" + dgvitemform.Rows[i].Cells["quantity_item"].Value + "',"
                                  + "'" + dgvitemform.Rows[i].Cells["rate_item"].Value + "',"
                                 
                                  + "'" + dgvitemform.Rows[i].Cells["netamount"].Value + "',"
                                  + "'" + "1" + "')";
                                sb.Append(StrQuery);


                            }
                            // MessageBox.Show("UPLOADED SUCESSFULLY", "Message", MessageBoxButtons.OK);





                            //comm.Connection = conn;

                            sb.Append(invoice_update);

                            //for (int i = 0; i < dgvitemform.Rows.Count; i++)
                            //{
                            //    String SalesQuery = @"UPDATE [T_SALES_ORDER_ITEM] SET
                            //              " +
                            //                "BALANCE_QUANTITY= '" + dgvitemform.Rows[i].Cells["SALES_ORDER_BALANCE_QUANTITY"].Value + "'," +

                            //                   "BALANCE_TOTAL = '" + dgvitemform.Rows[i].Cells["netamount"].Value + "'," +
                            //                    " WHERE SALES_ORDER_NO ='" + txt_salesorder.Text + "'";

                            //    sb.Append(SalesQuery);
                            //}


                            String orderQuery = @"UPDATE [T_SALES_ORDER]  SET
                                 " +
                       "BALANCE_QUANTITY = " + sales_order_balance_quantity + "," +
                        "BALANCE_AMOUNT = " + sales_order_balance_total + "" +

                     "WHERE SALES_ORDER_NO ='" + txt_salesorder.Text + "'";

                            sb.Append(orderQuery);

                            comm.CommandText = sb.ToString();
                            comm.Transaction = Transaction;
                            comm.ExecuteNonQuery();


                            Transaction.Commit();

                            StringBuilder builder = new StringBuilder();
                            builder.Append("SAVED SUCESSFULLY \n INVOICE_NO - ");
                            builder.Append(txtinvoice.Text);
                            MessageBox.Show(builder.ToString(), "INVENTORY MANAGEMENT", MessageBoxButtons.OK);
                            conn.Close();

                            clear();
                            this.Close();
                            frm_invoice_list frm_Invoice_ = new frm_invoice_list();
                            frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                            frm_Invoice_.Show();
                        }
                        catch (Exception ex)
                        {
                            Transaction.Rollback();
                            MessageBox.Show(ex.Message);
                            clear();
                            this.Close();
                            frm_invoice_list frm_Invoice_ = new frm_invoice_list();
                            frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                            frm_Invoice_.Show();
                        }
                    }
                }
                else if (mode == "EDIT INVOICE")
                {
                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {
                        conn.Open();
                        SqlTransaction transaction = conn.BeginTransaction();
                        try
                        {

                            string StrQuery;


                            SqlCommand comm = new SqlCommand();


                            comm.Connection = conn;
                            StringBuilder sb = new StringBuilder();
                            String Query;
                            //comm.Connection = conn;
                            Query = @"UPDATE [T_INVOICE]  SET
                                 INVOICE_NO ='" + txtinvoice.Text + "'," +
                          "INVOICE_DATE = '" + txt_datetime.Value.Date + "'," +
                           "DISCOUNT = '" + txt_discount.Text + "'," +
                           "QUANTITY ='" + txt_quantity_sum.Text + "'," +
                             "SUB_TOTAL = '" + txt_total_sum.Text + "'," +
                          "CUSTOMER_ID = '" + txtcustomer.Tag + "'," +
                         
                        "[USER_NAME] = '" + user_box.Text + "'," +
                        "CGST = '" + txtcgst.Text + "'," +
                        "SGST = '" + txtsgst.Text + "'," +
                       "IGST = '" + txtigst.Text + "'," +
                      "NET_AMOUNT = '" + txtnet_amount.Text + "'," +
                       "COMPANY_ID = '" + lbl_comp.Tag + "'," +
                        "STATUS = '" + "ACTIVE" + "'," +
                    " ACTIVE ='" + "1" + "'" +
                    "WHERE INVOICE_NO ='" + txtinvoice.Text + "'";

                            sb.Append(Query);
                            //foreach (DataGridViewRow row in dgvitemform.Rows)
                            for (int i = 0; i < dgvitemform.Rows.Count; i++)
                            {
                                StrQuery = @"UPDATE [T_INVOICE_ITEM] SET
                                          INVOICE_NO= '" + txtinvoice.Text + "'," +
                                          "ROW_ID = '" + dgvitemform.Rows[i].Cells["row_id"].Value + "', " +
                                          "ITEM_ID = '" + dgvitemform.Rows[i].Cells["item_id"].Value + "' ," +
                                          "SIZE_ID='" + dgvitemform.Rows[i].Cells["size_id"].Value + "'," +
                                           "STYLE_NAME='" + dgvitemform.Rows[i].Cells["style"].Value + "'," +
                                           "QUANTITY= '" + dgvitemform.Rows[i].Cells["quantity_item"].Value + "'," +
                                             "RATE='" + dgvitemform.Rows[i].Cells["rate_item"].Value + "'," +
                                              
                                              "TOTAL = '" + dgvitemform.Rows[i].Cells["netamount"].Value + "'," +
                                              "" + "ACTIVE =" + "1" + " WHERE INVOICE_NO ='" + txtinvoice.Text + "'";

                                sb.Append(StrQuery);
                            }






                            //for (int i = 0; i < dgvitemform.Rows.Count; i++)
                            //{
                            //    String SalesQuery = @"UPDATE [T_SALES_ORDER_ITEM] SET
                            //              " +
                            //                "BALANCE_QUANTITY= '" + dgvitemform.Rows[i].Cells["SALES_ORDER_BALANCE_QUANTITY"].Value + "'," +

                            //                   "BALANCE_TOTAL = '" + dgvitemform.Rows[i].Cells["netamount"].Value + "'," +
                            //                    " WHERE SALES_ORDER_NO ='" + txt_salesorder.Text + "'";

                            //    sb.Append(SalesQuery);
                            //}


                            String orderQuery = @"UPDATE [T_SALES_ORDER]  SET
                                 " +
                       "BALANCE_QUANTITY = '" + sales_order_balance_quantity + "'," +
                        "BALANCE_AMOUNT = '" + sales_order_balance_total + "'" +

                     "WHERE SALES_ORDER_NO ='" + txt_salesorder.Text + "'";

                            sb.Append(orderQuery);

                            comm.CommandText = sb.ToString(); ;


                            comm.Transaction = transaction;
                            comm.ExecuteNonQuery();
                            transaction.Commit();

                            StringBuilder builder = new StringBuilder();
                            builder.Append("SAVED SUCESSFULLY \n INVOICE_NO - ");
                            builder.Append(txtinvoice.Text);
                            MessageBox.Show(builder.ToString(), "INVENTORY MANAGEMENT", MessageBoxButtons.OK);
                            // conn.Close();

                            clear();
                            this.Close();
                            frm_invoice_list frm_Invoice_ = new frm_invoice_list();
                            frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                            frm_Invoice_.Show();



                            //MessageBox.Show("SAVED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                            // conn.Close();





                            // MessageBox.Show("UPLOADED SUCESSFULLY", "Message", MessageBoxButtons.OK);
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show(ex.Message);
                            clear();
                            this.Close();
                            frm_invoice_list frm_Invoice_ = new frm_invoice_list();
                            frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                            frm_Invoice_.Show();
                        }
                    }


                }

                else
                {
                    if (mode == "INVOICE DELETE")
                    {
                        using (SqlConnection conn = new SqlConnection(ConnString))
                        {
                            conn.Open();
                            SqlTransaction transaction = conn.BeginTransaction();


                            DialogResult done = (MessageBox.Show("Are you sure want to CANCEL this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                            if (done == DialogResult.Yes)
                            {


                                string StrQuery = "UPDATE [T_INVOICE] SET STATUS = '" + "CANCELED" + "'," +
                                    "  ACTIVE = " + "0" + " WHERE INVOICE_NO ='" + txtinvoice.Text + "'";
                                string Query = "UPDATE [T_INVOICE_ITEM] SET   ACTIVE = " + "0" + " WHERE INVOICE_NO ='" + txtinvoice.Text + "'";
                                try
                                {

                                    SqlCommand comm = new SqlCommand();


                                    comm.Connection = conn;

                                    //foreach (DataGridViewRow row in dgvitemform.Rows)
                                    StringBuilder sb = new StringBuilder();
                                    sb.Append(StrQuery);
                                    sb.Append(Query);

                                    comm.CommandText = sb.ToString();
                                    comm.Transaction = transaction;
                                    comm.ExecuteNonQuery();
                                    transaction.Commit();
                                    StringBuilder builder = new StringBuilder();
                                    builder.Append("CANCELED SUCESSFULLY \n INVOICE_NO - ");
                                    builder.Append(txtinvoice.Text);
                                    MessageBox.Show(builder.ToString(), "INVENTORY MANAGEMENT", MessageBoxButtons.OK);
                                    // conn.Close();

                                    clear();
                                    this.Close();
                                    frm_invoice_list frm_Invoice_ = new frm_invoice_list();
                                    frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                                    frm_Invoice_.Show();




                                }

                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show(ex.Message);
                                    clear();
                                    this.Close();
                                    frm_invoice_list frm_Invoice_ = new frm_invoice_list();
                                    frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                                    frm_Invoice_.Show();
                                }

                            }
                        }
                    }
                }
            }

            else
            {
                MessageBox.Show("Entry is Wrong \n Please Check Entry ", "INVENTORY MANAGEMENT", MessageBoxButtons.OK);
            }
        } 
    
        private void txt_rate_TextChanged(object sender, EventArgs e)
        {

            //if (txt_rate.Text != "" && txt_quantity.Text != "")
            //{
            //    txt_total.Text = (Convert.ToString(Convert.ToDouble(txt_rate.Text) * Convert.ToDouble(txt_quantity.Text)));
            //    //txt_total.Text = (double.Parse(txt_rate.Text) * (double.Parse(txt_quantity.Text))).ToString();
            //    // = multi.ToString();
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
            //int borderradius1 = 30;
            //int bordersize1 = 0;
            //Color bordercolor1 = Color.Black;
            //FormRegionAndBorder1(this.pnl_right, borderradius1, e.Graphics, bordercolor1, bordersize1);
        }
        private void dgvitemform_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvitemform.Columns[e.ColumnIndex].HeaderText == "DELETE")
            {
                int s_no;

                DataGridViewRow selectedRow = dgvitemform.Rows[e.RowIndex];
                s_no = Convert.ToInt32(selectedRow.Cells["row_id"].Value);
                //MessageBox.Show(s_no.ToString());
                textBox6.Text = s_no.ToString();
                DialogResult done = (MessageBox.Show("Are you sure want to Delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                if (done == DialogResult.Yes)
                {
                    if (s_no > 0)
                    {
                        if (mode == "ADD")
                        {
                            int rowIndex = Convert.ToInt32(textBox6.Text) - 1;
                            int selectedRowIndex = rowIndex;
                            //int selectedRowIndex = dgvitemform.SelectedRows[0].Index;
                            dgvitemform.Rows.RemoveAt(selectedRowIndex);


                            MessageBox.Show("DELETED SUCCESSFULLY");
                            //deletedRowValue = Convert.ToDouble(selectedRow.Cells[7].Value);
                            //deletedRowValue1 = Convert.ToDouble(selectedRow.Cells[4].Value);
                            //sum_total();
                            //total_sum();
                            //quantity_sum();
                            //sum_dicount();
                        }
                        if (mode == "EDIT INVOICE")
                        {

                            string delete = "UPDATE  [T_INVOICE_ITEM] SET DELETED ="
                            + "'" + 1 + "'  WHERE ROW_ID=" + textBox6.Text + " AND INVOICE_NO= '" + txtinvoice.Text + "'";
                            SqlConnection conn = new SqlConnection(ConnString);
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(delete, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();



                            //indexRow = indexRow + 1;
                            int rowIndex = Convert.ToInt32(textBox6.Text) - 1;
                            int selectedRowIndex = rowIndex;
                            //int selectedRowIndex = indexRow ;
                            DataRow row = dt.Rows[selectedRowIndex];
                            dt.Rows.Remove(row);
                            dgvitemform.Rows.RemoveAt(selectedRowIndex);


                            MessageBox.Show("DELETED SUCCESSFULLY");

                            //deletedRowValue = Convert.ToDouble(selectedRow.Cells[7].Value);
                            //deletedRowValue1 = Convert.ToDouble(selectedRow.Cells[4].Value);
                            //UpdateTotalValue();
                            //sum_quantity_update();
                            ////total_update();
                            //subup();

                        }
                        if (mode == "ADD")
                        {
                            double total1 = 0;
                            double total2 = 0;
                            foreach (DataGridViewRow row in dgvitemform.Rows)
                            {
                                if (row.Index != e.RowIndex && row.Cells["rate_item"].Value != null && row.Cells["netamount"].Value.ToString() != string.Empty)
                                {
                                    total1 += Convert.ToDouble(row.Cells["netamount"].Value);
                                }
                                if (row.Index != e.RowIndex && row.Cells["rate_item"].Value != null && row.Cells["QUANTITY_ITEM"].Value.ToString() != string.Empty)
                                {
                                    total2 += Convert.ToDouble(row.Cells["QUANTITY_ITEM"].Value);
                                }
                                //if (row.Index == e.RowIndex && e. != null && e.FormattedValue.ToString() != string.Empty)
                                //{
                                //    total += Convert.ToInt32(e.FormattedValue);
                                //}
                            }
                            // Update the total in a label or textbox
                            txt_quantity_sum.Text = total2.ToString();
                            txt_total_sum.Text = total1.ToString();

                        }
                        if (mode == "EDIT INVOICE")
                        {

                            double total1 = 0;
                            double total2 = 0;
                            Double priveous1 = Convert.ToDouble(txt_total_sum.Text);
                            Double priveous2 = Convert.ToDouble(txt_quantity_sum.Text);
                            foreach (DataGridViewRow row in dgvitemform.Rows)
                            {
                                if (row.Index != e.RowIndex && row.Cells["rate_item"].Value != null && row.Cells["netamount"].Value.ToString() != string.Empty)
                                {
                                    total1 += Convert.ToDouble(row.Cells["netamount"].Value);
                                }
                                if (row.Index != e.RowIndex && row.Cells["rate_item"].Value != null && row.Cells["QUANTITY_ITEM"].Value.ToString() != string.Empty)
                                {
                                    total2 += Convert.ToDouble(row.Cells["QUANTITY_ITEM"].Value);
                                }
                                //if (row.Index == e.RowIndex && e. != null && e.FormattedValue.ToString() != string.Empty)
                                //{
                                //    total += Convert.ToInt32(e.FormattedValue);
                                //}
                            }
                            // Update the total in a label or textbox
                            txt_quantity_sum.Text = (total2 + priveous2 - priveous2).ToString();
                            txt_total_sum.Text = (total1 + priveous1 - priveous1).ToString();

                        }



                    }



                }
                


                //else
                //{
                //    dgvitemform.Rows[i].Cells["rate_item"].Value = "";
                //}
            }
            if (e.RowIndex >= 0)
            {
               
            }


            //Double sum1 = 0;
            //Double sum2 = 0;
            //for (int i = 0; dgvitemform.Rows.Count > i; i++)
            //{
            //    if (dgvitemform.Rows[i].Cells["rate_item"].Value != null && dgvitemform.Rows[i].Cells["quantity_item"].Value != null)
            //    {


            //        sum1 += Double.Parse(dgvitemform.Rows[i].Cells["quantity_item"].Value.ToString());
            //        sum2 += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

            //        txt_quantity_sum.Text = sum1.ToString();
            //        txt_total_sum.Text = sum2.ToString();
            //    }



        }




       
      
        private void dgvitemform_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.dgvitemform.Rows[e.RowIndex].Cells["row_id"].Value = (e.RowIndex + 1).ToString();
        }
      
       
        public void last_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //int s = Convert.ToInt32(textBox1.Text);
           // String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            {
                string query = "select LAST_NO from M_ENTRY_SETUP  WHERE COMPANY_ID=" + lbl_comp.Tag + " AND ENTRY_ID = " + entry_name + "";
                SqlConnection con = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox15.Text = dr["LAST_NO"].ToString();
                    if (btn_save.Focused)
                    {
                        break;
                    }
                }
                dr.Close();
                con.Close();
            }
            int N = 1000000;
            for (int s = Convert.ToInt32(textBox15.Text); s <= N; s++)
            {
              int  sum = s+ 1;
                textBox15.Text = sum.ToString();
                if (btn_save.Focused)
                {
                    break;
                }

            }

            
        }
        public void invoice_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String Query = " SELECT CONCAT([PREFIIX],'-',[LAST_NO]+1) AS[INVOICE_NO] FROM[M_ENTRY_SETUP] WHERE COMPANY_ID=" + lbl_comp.Tag + " AND ENTRY_ID = " + entry_name + "";
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

        public void drop_customer()
        {
            //String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //// String str = "Select * from T_QUOTATION_ITEM";
            //String SQLQuery = "SELECT CUSTOMER_ID, CUSTOMER_NAME FROM M_CUSTOMER ";
            //try
            //{
            //    using (SqlConnection conn = new SqlConnection(ConnString))
            //    {
            //        SqlCommand comm = new SqlCommand(SQLQuery, conn);
            //        SqlDataAdapter da = new SqlDataAdapter();
            //        da.SelectCommand = comm;
            //        conn.Open();
            //        DataTable dt = new DataTable();
            //        DataSet ds = new DataSet();
            //        da.Fill(dt);
            //        DataRow row = dt.NewRow();
            //        row[1] = "";
            //        dt.Rows.InsertAt(row, 0);
            //        //SqlDataReader dr = comm.ExecuteReader();
            //        //while (dr.Read())
            //        //{
            //        //    string item = dr[0].ToString();
            //        //      txtquotation.Items.Add(item);

            //        //dr.Close();
            //        //DataTable dt = ds.Tables[0];
            //        txtcustomer.DataSource = dt;
            //        txtcustomer.DisplayMember = "CUSTOMER_NAME";
            //        txtcustomer.ValueMember = "CUSTOMER_ID";
            //    }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
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


      
        private void txtinvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                String SQLQuery = "SELECT ROW_ID,ITEM_NAME,SIZE_NAME,STYLE_NAME,QUANTITY,RATE,DISCOUNT,TOTAL FROM T_INVOICE_ITEM " +
                "INNER JOIN M_ITEM ON M_ITEM.ITEM_ID = T_INVOICE_ITEM.ITEM_ID " +
                "INNER JOIN  M_SIZE ON M_SIZE.SIZE_ID = T_INVOICE_ITEM.SIZE_ID " +
                "WHERE INVOICE_NO = '" + txtinvoice.Text + "'";
                String sqlquery = "SELECT INVOICE_DATE,DISCOUNT,QUANTITY,TOTAL,CUSTOMER_NAME,CUSTOMER_ADDRESS,USER_NAME FROM T_INVOICE" +
                    " INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_INVOICE.CUSTOMER_ID " +
                    "WHERE INVOICE_NO = '" + txtinvoice.Text + "'"; 
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
                            //txtcgst.Text = dr1["CGST"].ToString();
                            //txtsgst.Text = dr1["SGST"].ToString();
                            //txtigst.Text= dr1["IGST"].ToString();
                            //txtnet_amount.Text = dr1["NET_AMOUNT"].ToString();
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

        private void txtinvoice_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
        private void txtaddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf5 popup = new frmf5();
                string _query = "SELECT CUSTOMER_ID AS [ID],CONCAT(ADDRESS_1,',   '," +
                    "CITY,',   ',DISTRICT,',   '," +
                    "STATE,',  ',COUNTRY,',  '," +
                    "POSTAL_CODE,',   PH:',PHONE_NO) AS[ADDRESS] FROM[M_CUSTOMER] WHERE ACTIVE = 1";


                popup.ShowF2(_query, "ADDRESS", ((TextBox)sender).Text, "ADDRESS", sender);
            }
        }

        public void calculation()
        {
            if (mode == "EDIT INVOICE" || mode == "ADD")
            {
                txtsubtotal.Text = txt_total_sum.Text;
                foreach (DataGridViewRow gridViewRow in dgvitemform.Rows)
                {
                    if (gridViewRow.Cells["rate_item"].Value != null)
                    {
                        stxtitem.Text = gridViewRow.Cells["ITEM_ID"].Value.ToString();
                        String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                        String query = "select cgst,igst,sgst from m_item where ITEM_ID='" + stxtitem.Text + "'";
                        SqlConnection conn = new SqlConnection(ConnString);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            stxtcgst.Text = dr["CGST"].ToString();
                            stxtigst.Text = dr["IGST"].ToString();
                            stxtsgst.Text = dr["SGST"].ToString();
                        }
                        dr.Close();
                        conn.Close();

                        double Sgst = Convert.ToDouble(stxtsgst.Text);
                        double Cgst = Convert.ToDouble(stxtcgst.Text);
                        double Igst = Convert.ToDouble(stxtigst.Text);

                        txtsgst.Text = Convert.ToString((Sgst / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));
                        txtcgst.Text = Convert.ToString((Cgst / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));


                        txtigst.Text = Convert.ToString((Igst / 100.00) * (Convert.ToDouble(txt_total_sum.Text)));

                        txtgst_value.Text = Convert.ToString(Convert.ToDouble(txtcgst.Text) + Convert.ToDouble(txtsgst.Text) + Convert.ToDouble(txtigst.Text));
                        string txt_total = Convert.ToString(((Convert.ToDouble(txt_total_sum.Text)) * ((100 - Convert.ToDouble(txt_discount.Text)) / 100.00)));
                        double input = Convert.ToDouble(txtgst_value.Text) + Convert.ToDouble(txt_total);
                        double result = Math.Round(input, 0);
                        txtnet_amount.Text = result.ToString();
                        txtnet_amountB.Text = txtnet_amount.Text;
                        // txtnet_amount.Text = Convert.ToString(Convert.ToDouble(txtgst_value.Text) + Convert.ToDouble(txttrans.Text) + Convert.ToDouble(txtl_charge.Text + Convert.ToDouble(txt_total_sum.Text)+Convert.ToDouble(txtroundoff.Text)));



                        stxtitem.Text = "";
                    }
                }
            }
            else
            {
                txtsubtotal.Text = txt_total_sum.Text;
                txtnet_amountB.Text = txtnet_amount.Text;
                if (txtsgst.Text != "" || txtigst.Text != "" || txtcgst.Text != "")
                {
                    txtgst_value.Text = Convert.ToString(Convert.ToDouble(txtcgst.Text) + Convert.ToDouble(txtsgst.Text) + Convert.ToDouble(txtigst.Text));
                }
            }
        }
        private void txt_total_sum_TextChanged(object sender, EventArgs e)
        {

            calculation();



        }

        private void txtinvoice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT ITEM_ID AS [ID],  ITEM_NAME, HSN_CODE FROM M_ITEM WHERE ACTIVE = 1";
                popup.ShowF2(_query, "ITEM_NAME", ((TextBox)sender).Text, "ITEM_NAME", sender);


            }
        }

        private void txt_size_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT SIZE_ID AS [ID], SIZE_NAME FROM M_SIZE WHERE ACTIVE = 1";
                popup.ShowF2(_query, "SIZE_NAME", ((TextBox)sender).Text, "SIZE_NAME", sender);


            }
        }
        public void sum_total1()
        {
          /* for(int  i =0; dgvitemform.Rows.Count>0;i++ )*/
          foreach(DataGridViewRow viewRow in dgvitemform.Rows)
            {
                if (viewRow.Cells["rate_item"].Value != null)
                {
                //    if (viewRow.Cells["NETAMOUNT"].Value != null)
                //{
                    Double sum = 0;




                    sum += Double.Parse(viewRow.Cells["NETAMOUNT"].Value.ToString());



                    txt_total_sum.Text = sum.ToString();
                //}
                }
                else
                {
                    viewRow.Cells["NETAMOUNT"].Value = "";
                }
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
        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {
            //if (txt_rate.Text != "" && txt_discount.Text != "")
            //{
            //   
            //}

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            txt_clear();
            delete_cancel();
            clear();
            this.Close();
            frm_invoice_list frm_Invoice = new frm_invoice_list();
            frm_Invoice.MdiParent = frm_mid.ActiveForm;
            frm_Invoice.Show();
        }
        private void txttrans_TextChanged(object sender, EventArgs e)
        {
            if (txt_total_sum.Text != "" && txttrans.Text!="")
            {
                txtnet_amount.Text = Convert.ToString(Convert.ToDouble(txttrans.Text) + Convert.ToDouble(txtnet_amountB.Text));
            }
        }

        private void txtl_charge_TextChanged(object sender, EventArgs e)
        {
            if (txt_total_sum.Text != "" && txtl_charge.Text!="")
            {
                txtnet_amount.Text = Convert.ToString(Convert.ToDouble(txtl_charge.Text) + Convert.ToDouble(txttrans.Text) + Convert.ToDouble(txtnet_amountB.Text));
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
        }
        private void txtcustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int item = txtcustomer.SelectedIndex;
            //txtcustomer.Tag = item;
        }

       

        private void pnl_close_Paint(object sender, PaintEventArgs e)
        {

        }
        public  string valuetoadd { get; set; }
        public static string item_text { get; set; }
        private void frm_invoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (mode == "ADD" || mode == "EDIT INVOICE")
            {

                if (e.KeyCode == Keys.F5)
                {

                    //frmf3 popup = new frmf3();
                    //popup.ShowF3("RETURN OF GOODS", valuetoadd, sender);
                    ////popup.Show();
                          frmf5 popup = new frmf5();
                    popup.item_text = "INVOICE";
                            string _query = "SELECT ITEM_ID AS [ID],  ITEM_NAME, HSN_CODE FROM M_ITEM WHERE ACTIVE = 1";
                            popup.ShowF2(_query, "ITEM_NAME", (item_text), "ITEM_NAME", sender);

                        
                         //  ITEM_LOAD();
                       

                }
                
                
                

            }
            if (e.KeyCode == Keys.X && e.Alt )
            {
                txt_clear();
                delete_cancel();
                clear();
                this.Close();
                frm_invoice_list frm_Invoice = new frm_invoice_list();
                frm_Invoice.MdiParent = frm_mid.ActiveForm;
                frm_Invoice.Show();
            }
            //
        }

        private void txt_total_sum_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {
            string _query1 = "SELECT CONCAT(ADDRESS_1,' '," +
                "[M_CITY].CITY,'  ,',[M_DISTRICT] .DISTRICT,'  ,'," +
                "[M_STATE].STATE,' ,',[M_COUNTRY].COUNTRY,'  ,'," +
                "POSTAL_CODE,' ,',PHONE_NO ) AS [ADDRESS] FROM [M_CUSTOMER]" +
                " INNER JOIN[dbo].[M_CITY]  ON[M_CUSTOMER].CITY_ID = [M_CITY].CITY_ID" +
                " INNER JOIN[dbo].[M_DISTRICT]  ON[M_CUSTOMER].DISTRICT_ID = [M_DISTRICT].DISTRICT_ID" +
                " INNER JOIN[dbo].[M_STATE]  ON[M_CUSTOMER].STATE_ID = [M_STATE].STATE_ID " +
                " INNER JOIN[dbo].[M_COUNTRY] ON[M_CUSTOMER].COUNTRY_ID = [M_COUNTRY].COUNTRY_ID " +
                " WHERE [M_CUSTOMER]. CUSTOMER_NAME = '" + txtcustomer.Text + "'";

            SqlConnection conn = new SqlConnection(ConnString);
            SqlCommand cmd = new SqlCommand(_query1, conn);
            conn.Open();
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read())
            {
                txtaddress.Text = dataReader["ADDRESS"].ToString();
            }
            dataReader.Close();
            if (mode == "ADD")
            {
                String Query = "SELECT SALES_ORDER_ID,SALES_ORDER_NO FROM T_SALES_ORDER WHERE COMPANY_ID = '" + lbl_comp.Tag + "' AND CUSTOMER_ID =" + txtcustomer.Tag + "";

                SqlCommand comm = new SqlCommand(Query, conn);

                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txt_salesorder.Tag = dr["SALES_ORDER_ID"].ToString();
                    txt_salesorder.Text = dr["SALES_ORDER_NO"].ToString();

                }
                dr.Close();
            }
            else
            {

                String Query1 = "SELECT SALES_ORDER_ID,SALES_ORDER_NO FROM T_SALES_ORDER WHERE COMPANY_ID = '" + lbl_comp.Tag + "' AND CUSTOMER_ID =" + txtcustomer.Tag + "";

                SqlCommand comm1 = new SqlCommand(Query1, conn);

                SqlDataReader dr1 = comm1.ExecuteReader();
                while (dr1.Read())
                {
                    txt_salesorder.Tag = dr1["SALES_ORDER_ID"].ToString();
                    txt_salesorder.Text = dr1["SALES_ORDER_NO"].ToString();

                }
                dr1.Close();
                

            }
            conn.Close();
        }
       
        private void txt_itemadd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                //frmf3 popup = new frmf3();
                //popup.ShowF3("RETURN OF GOODS", valuetoadd, sender);
                ////popup.Show();
                frmf2 popup = new frmf2();
                string _query = "SELECT ITEM_ID AS [ID],  ITEM_NAME, HSN_CODE FROM M_ITEM WHERE ACTIVE = 1";
                popup.ShowF2(_query, "ITEM_NAME", ((TextBox)sender).Text, "ITEM_NAME", sender);
            }
        }
        public static string item_tag { get; set; }
        public   void ITEM_LOAD()
        {
            txt_itemadd.Tag = item_tag;
            //txt_itemadd.Text = item_text;
            if ( mode == "ADD" || mode == "EDIT INVOICE")
            {
                String Query = "SELECT ITEM_NAME, SIZE FROM  [M_ITEM] WHERE ITEM_ID = '" + item_text + "' ";
                SqlConnection conn = new SqlConnection(ConnString);

                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txt_itemadd.Text = dr["ITEM_NAME"].ToString();
                    txt_itemsize.Text = dr["size"].ToString();

                }
                dr.Close();
                conn.Close();


                string[] lines = txt_itemsize.Lines; // Get an array of all lines in the textbox
                foreach (string line in lines)
                {

                    if (mode == "ADD")
                    {
                        DataGridViewRow newRow = new DataGridViewRow();
                        newRow.CreateCells(dgvitemform);

                        //newRow.Cells["ROW_ID"].Value = txt_no.Text;
                        newRow.Cells[1].Value = txt_itemadd.Text;
                        newRow.Cells[2].Value = line;
                        // newRow.Cells[3].Value = txt_style.Text;

                        //newRow.Cells[7].Value = txt_total.Text;
                        newRow.Cells[8].Value = item_text;
                        //newRow.Cells[11].Value = txt_size.Tag;
                        dgvitemform.Rows.Add(newRow);
                    }
                    if (mode == "EDIT INVOICE")
                    {

                        DataRow row = dt.NewRow();



                        row["ITEM_NAME"] = txt_itemadd.Text;
                        row["SIZE_NAME"] = line;
                        row["ITEM_ID"] = item_text;
                        //row[4] = txt_quantity.Text; DR["QUANTITY"] = row.Cells["quantity_item"].Value;
                        //DR["RATE"] = row.Cells["rate_item"].Value;
                        //DR["TOTAL"] = row.Cells["netamount"].Value;
                        //row[5] = txt_rate.Text;
                        //row[6] = txt_discount.Text;
                        //row[7] = txt_total.Text;
                        //row[10] = txt_item.Tag;

                        foreach (DataGridViewRow viewRow in dgvitemform.Rows)
                        {

                            String StrQuery = "SELECT size_id FROM  [M_size] WHERE SIZE_NAME = '" + viewRow.Cells["size_item"].Value + "' ";
                            SqlCommand cmd = new SqlCommand(StrQuery, conn);
                            conn.Open();
                            SqlDataReader dr1 = cmd.ExecuteReader();
                            while (dr1.Read())
                            {

                                viewRow.Cells["SIZE_ID"].Value = dr1["size_id"].ToString();
                                row["SIZE_ID"] = viewRow.Cells["SIZE_ID"].Value;
                            }
                            dr1.Close();


                            conn.Close();

                        }


                        dt.Rows.Add(row);
                        dgvitemform.DataSource = dt;
                    }

                }
                txt_itemadd.Text = "";
                txt_itemadd.Tag = "";
                txt_itemsize.Text = "";
            }

        }
        private void txt_itemadd_TextChanged(object sender, EventArgs e)
        {
            //String Query = "SELECT size FROM  [M_ITEM] WHERE ITEM_ID = '" + txt_itemadd.Tag + "' ";
            //SqlConnection conn = new SqlConnection(ConnString);
            
            //    SqlCommand comm = new SqlCommand(Query, conn);
            //    conn.Open();
            //    SqlDataReader dr = comm.ExecuteReader();
            //    while (dr.Read())
            //    {
                    
            //        txt_itemsize.Text = dr["size"].ToString();

            //    }
            //    dr.Close();
            //    conn.Close();
            
            
            //string[] lines = txt_itemsize.Lines; // Get an array of all lines in the textbox
            //foreach (string line in lines)
            //{
            //    if (mode == "ADD")
            //    {
            //        DataGridViewRow newRow = new DataGridViewRow();
            //        newRow.CreateCells(dgvitemform);

            //        //newRow.Cells["ROW_ID"].Value = txt_no.Text;
            //        newRow.Cells[1].Value = txt_itemadd.Text;
            //        newRow.Cells[2].Value = line;
            //        // newRow.Cells[3].Value = txt_style.Text;

            //        //newRow.Cells[7].Value = txt_total.Text;
            //        newRow.Cells[8].Value = txt_itemadd.Tag;
            //        //newRow.Cells[11].Value = txt_size.Tag;
            //        dgvitemform.Rows.Add(newRow);
            //    }
            //   if(mode=="EDIT INVOICE")
            //    {
                   
            //        DataRow row = dt.NewRow();



            //        row["ITEM_NAME"] = txt_itemadd.Text;
            //        row["SIZE_NAME"] = line;
            //        row["ITEM_ID"] = txt_itemadd.Tag;
            //        //row[4] = txt_quantity.Text; DR["QUANTITY"] = row.Cells["quantity_item"].Value;
            //        //DR["RATE"] = row.Cells["rate_item"].Value;
            //        //DR["TOTAL"] = row.Cells["netamount"].Value;
            //        //row[5] = txt_rate.Text;
            //        //row[6] = txt_discount.Text;
            //        //row[7] = txt_total.Text;
            //        //row[10] = txt_item.Tag;

            //        foreach (DataGridViewRow viewRow in dgvitemform.Rows)
            //        {

            //            String StrQuery = "SELECT size_id FROM  [M_size] WHERE SIZE_NAME = '" + viewRow.Cells["size_item"].Value + "' ";
            //            SqlCommand cmd = new SqlCommand(StrQuery, conn);
            //            conn.Open();
            //            SqlDataReader dr1 = cmd.ExecuteReader();
            //            while (dr1.Read())
            //            {

            //                viewRow.Cells["SIZE_ID"].Value = dr1["size_id"].ToString();
            //                row["SIZE_ID"] = viewRow.Cells["SIZE_ID"].Value;
            //            }
            //            dr1.Close();


            //            conn.Close();

            //        }
                   

            //        dt.Rows.Add(row);
            //        dgvitemform.DataSource = dt;
            //    }
                
            //}



        }

        private void dgvitemform_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (mode == "ADD")
            {
               
                    double total1 = 0;
                    double total2 = 0;
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                           if ( row.Cells["rate_item"].Value != null && row.Cells["QUANTITY_ITEM"].Value != null && row.Cells["netamount"].Value != null && row.Cells["netamount"].Value.ToString() != string.Empty)
                            {

                                total1 += Convert.ToDouble(row.Cells["netamount"].Value);
                                txt_total_sum.Text = total1.ToString();
                            }
                            if ( row.Cells["rate_item"].Value != null && row.Cells["QUANTITY_ITEM"].Value != null && row.Cells["netamount"].Value != null && row.Cells["QUANTITY_ITEM"].Value.ToString() != string.Empty)
                            {
                                total2 += Convert.ToDouble(row.Cells["QUANTITY_ITEM"].Value);
                                txt_quantity_sum.Text = total2.ToString();
                            }
                            //if (row.Index == e.RowIndex && e. != null && e.FormattedValue.ToString() != string.Empty)
                            //{
                            //    total += Convert.ToInt32(e.FormattedValue);
                            //}
                        
                    }



                }
            if (mode == "EDIT INVOICE")
            {

                double total1 = 0;
                double total2 = 0;
                Double priveous1 = Convert.ToDouble(txt_total_sum.Text);
                Double priveous2 = Convert.ToDouble(txt_quantity_sum.Text);
                    foreach (DataGridViewRow row in dgvitemform.Rows)
                    {
                       
                            if ( row.Cells["rate_item"].Value != null && row.Cells["QUANTITY_ITEM"].Value != null && row.Cells["netamount"].Value != null && row.Cells["netamount"].Value.ToString() != string.Empty)
                            {
                                total1 += Convert.ToDouble(row.Cells["netamount"].Value);
                                txt_total_sum.Text = (total1 + priveous1 - priveous1).ToString();
                            }
                            if ( row.Cells["rate_item"].Value != null && row.Cells["QUANTITY_ITEM"].Value != null && row.Cells["netamount"].Value != null && row.Cells["QUANTITY_ITEM"].Value.ToString() != string.Empty)
                            {
                                total2 += Convert.ToDouble(row.Cells["QUANTITY_ITEM"].Value);
                                txt_quantity_sum.Text = (total2 + priveous2 - priveous2).ToString();
                            }
                            //if (row.Index == e.RowIndex && e.FormattedValue.ToString() != string.Empty)
                            //{
                            //    total1 += Convert.ToInt32(e.FormattedValue);
                            //    total1 += Convert.ToInt32(e.FormattedValue);
                            //}
                        
                        // Update the total in a label or textbox

                    }

            }
            if (mode == "ADD" || mode == "EDIT INVOICE")
            {
                foreach (DataGridViewRow row in dgvitemform.Rows)
                {
                    //if (dataGridView.Cells["rate_item"].Value != null)
                    //{
                        //if (txt_total_sum.Text != "" )
                        //{
                        //    sum3 = double.Parse(txtsalequantity.Text) - double.Parse(txt_quantity_sum.Text);
                        //    sales_order_balance_quantity = sum3.ToString();
                        //    sum4 = double.Parse(txt_saletotal.Text) - double.Parse(txt_total_sum.Text);
                        //    sales_order_balance_total = sum4.ToString();
                        //}
                    //}
                }
            }
                //Double sum1 = 0;
                //Double sum2 = 0;

                //for (int i = 0; dgvitemform.Rows.Count > i; i++)
                //{
                //    if (dgvitemform.Rows[i].Cells["rate_item"].Value != null)
                //    {

                //        sum1 += Double.Parse(dgvitemform.Rows[i].Cells["quantity_item"].Value.ToString());
                //        sum2 += Convert.ToDouble(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

                //        txt_quantity_sum.Text = sum1.ToString();
                //        txt_total_sum.Text = sum2.ToString();

                //        //sum1 += Double.Parse(dgvitemform.Rows[i].Cells["quantity_item"].Value.ToString());
                //        //sum2 += Double.Parse(dgvitemform.Rows[i].Cells["netamount"].Value.ToString());

                //        //txt_quantity_sum.Text = sum1.ToString();
                //        //txt_total_sum.Text = sum2.ToString();



                //    }

                //    else
                //    {
                //        dgvitemform.Rows[i].Cells["netamount"].Value = "";
                //    }

                //}

                if (mode == "EDIT INVOICE")
                {
                    foreach (DataGridViewRow viewRow in dgvitemform.Rows)
                    {

                        DataRow row = dt.NewRow();





                        row["QUANTITY"] = viewRow.Cells["quantity_item"].Value;
                        row["RATE"] = viewRow.Cells["rate_item"].Value;
                        row["TOTAL"] = viewRow.Cells["netamount"].Value;
                        dt.AcceptChanges();

                    }





                    //        quantity_sum();
                    //totalsum();



                }  
            }
            
        }
        public void quantity_sum()
        {
            Decimal sum = 0;
            if (txt_total_sum.Text != "")
            {
                for (int i = 0; i < dgvitemform.Rows.Count; i++)
                {
                    sum += Decimal.Parse(dgvitemform.Rows[i].Cells["quantity_item"].Value.ToString());
                }
                txt_quantity_sum.Text = sum.ToString();
            }
            else
            {
                if (txt_total_sum.Text == "")
                {
                    for (int i = 0; i < dgvitemform.Rows.Count; i++)
                    {
                        sum += Decimal.Parse(dgvitemform.Rows[i].Cells["quantity_item"].Value.ToString());
                    }
                    txt_quantity_sum.Text = sum.ToString();
                }
            }
        }
       
        private void dgvitemform_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void dgvitemform_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }
      
        public string sales_order_balance_quantity { get; set; }
        public string sales_order_balance_total { get; set; }

        private void dgvitemform_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double sum = 0;
            Double sum3 = 0;
            Double sum4 = 0;
            foreach (DataGridViewRow dataGridView in dgvitemform.Rows)
            {
               
            
                if (mode == "ADD") {
                    SqlConnection conn = new SqlConnection(ConnString);
                    String StrQuery = "SELECT size_id FROM  [M_size] WHERE SIZE_NAME = '" + dataGridView.Cells["size_item"].Value + "' ";
                    SqlCommand cmd = new SqlCommand(StrQuery, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        dataGridView.Cells[9].Value = dr["size_id"].ToString();

                    }
                    dr.Close();


                    conn.Close();
                }
                if (dataGridView.Cells["rate_item"].Value != DBNull.Value)
                {


                    if (dataGridView.Cells["rate_item"].Value != null)
                    {
                        double value1 = Convert.ToDouble(dataGridView.Cells["quantity_item"].Value);
                        double value2 = Convert.ToDouble(dataGridView.Cells["rate_item"].Value);
                        //double value3 = Convert.ToDouble(dataGridView.Cells["SALES_ORDER_QUANTITY"].Value);
                        //double value4 = Convert.ToDouble(dataGridView.Cells["SALES_ORDER_TOTAL"].Value);

                        sum = value1 * value2;
                        dataGridView.Cells["netamount"].Value = sum.ToString();







                    }
                  
                }
               
            }
           
        }
        
        private void txt_discount_TextChanged_1(object sender, EventArgs e)
        {
            if (mode == "EDIT INVOICE" )
            {
                if (txt_total_sum.Text != "" && txt_discount.Text != "")
                {
                    string txt_total = Convert.ToString(((Convert.ToDouble(txt_total_sum.Text)) * ((100 - Convert.ToDouble(txt_discount.Text)) / 100.00)));
                    double input = Convert.ToDouble(txtgst_value.Text) + Convert.ToDouble(txt_total);
                    double result = Math.Round(input, 0);
                    txtnet_amount.Text = result.ToString();
                    txtnet_amountB.Text = txtnet_amount.Text;
                }
            }
            else
            {
                if (txt_total_sum.Text != "" && txt_discount.Text != "")
                {
                    string txt_total = Convert.ToString(((Convert.ToDouble(txt_total_sum.Text)) * ((100 - Convert.ToDouble(txt_discount.Text)) / 100.00)));
                double input = Convert.ToDouble(txtgst_value.Text) + Convert.ToDouble(txt_total);
                double result = Math.Round(input, 0);
                txtnet_amount.Text = result.ToString();
                txtnet_amountB.Text = txtnet_amount.Text;
                }
            }
        }
        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

        }

        private void btm_customer_Click(object sender, EventArgs e)
        {
            frmadd_customer customer = new frmadd_customer();
            customer.mode = "invoice customer";
            customer.Show();
            this.Hide();
        }

        public void delete_cancel()
        {
            string cancel_query = "UPDATE [T_INVOICE_ITEM] SET DELETED =" + 0 + " WHERE DELETED =" + 1 + "";
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(cancel_query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void txt_salesorder_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();
            String Query = "SELECT QUANTITY,SUB_TOTAL FROM  [T_SALES_ORDER] WHERE SALES_ORDER_NO = '" + txt_salesorder.Text + "' ";
            SqlCommand comm = new SqlCommand(Query, conn);

            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {

                txtsalequantity.Text = reader["QUANTITY"].ToString();
                txt_saletotal.Text = reader["SUB_TOTAL"].ToString();

            }
            reader.Close();
            conn.Close();

        }

        private void txtsalequantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_invoice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_invoice_Validated(object sender, EventArgs e)
        {
            
        }

        private void frm_invoice_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void frm_invoice_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void frm_invoice_Leave(object sender, EventArgs e)
        {
            
        }

        private void frm_invoice_InputLanguageChanging(object sender, InputLanguageChangingEventArgs e)
        {

        }

        private void frm_invoice_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }




}
