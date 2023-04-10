using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IMS
{
    public partial class frm_payment : Form
    {
        public frm_payment()
        {
            InitializeComponent();
        }
        public string mode { get; set; }
        private void dtg_paymain_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //    for (int i = 0; i < dtg_paymain.Rows.Count; i++)
            //    {
            //        bool isclicked = Convert.ToBoolean(dtg_paymain.Columns["active"].ValueType);
            //        if (isclicked == true)
            //        {

            //            int indexRow = e.RowIndex;
            //            DataGridViewRow row = this.dtg_paymain.Rows[indexRow];
            //            object temp = row.Cells["Payment"].Value;
            //            //int row = dgvitemform.SelectedCells[0].RowIndex;
            //            //DataGridViewRow selectedRow = dgvitemform.Rows[row];


            //            // txt_no.Text = row.Cells[0].Value.ToString();
            //            row.Cells["Payment"].Value = row.Cells["balance"].Value.ToString();
            //            row.Cells["balance"].Value = temp;

            //        }
            //    }
        }

        private void dtg_paymain_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }
        public void last_no()
        {

            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            {
                string query = "select LAST_NO from M_ENTRY_SETUP  WHERE COMPANY_ID=" + lbl_comp.Tag + " AND ENTRY_ID = " + entry_name + "";
                SqlConnection con = new SqlConnection(ConnString);
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1.Text = dr["LAST_NO"].ToString();
                    if (btn_save.Focused)
                    {
                        break;
                    }
                }
                dr.Close();
                con.Close();
            }
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






        }
        public void payment_no()
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            String Query = " SELECT CONCAT([PREFIIX],'-',[LAST_NO]+1) AS[PAYMENT_NO] FROM[M_ENTRY_SETUP] WHERE ENTRY_SETUP_ID = 5";
            using (SqlConnection conn = new SqlConnection(ConnString))
            {
                SqlCommand comm = new SqlCommand(Query, conn);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                while (dr.Read())
                {
                    txt_pay_no.Text = dr["PAYMENT_NO"].ToString();

                }
                dr.Close();
                conn.Close();
            }
        }
        public void clear()
        {
            txtcustomer.Text = "";
            txt_amount.Text = "";
            txt_balance.Text = "";
            txt_paid.Text = "";
            dtg_paymain.DataSource = null;
            dtg_paymain.Rows.Clear();
            //txt_no.Text = "1";
            txt_payment.Text = "";
            //textBox1.Text = "";
            txt_refer.Text = "";
            txt_pay_no.Text = "";


        }
        public string entry_name { get; set; }
        private void btn_save_Click(object sender, EventArgs e)
        {


            if (dtg_paymain.Rows.Count != 0 && txtcustomer.Text != "" && txt_payment.Text != "" && txt_refer.Text != "")
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
                            payment_no();
                            SqlCommand comm = new SqlCommand();
                            comm.Connection = conn;


                            StringBuilder sb = new StringBuilder();

                            String invoice_update = @"UPDATE  [M_ENTRY_SETUP] SET LAST_NO ="
                                + "'" + textBox1.Text + "'    WHERE COMPANY_ID=" + lbl_comp.Tag + " AND ENTRY_ID = " + entry_name + "";


                            Query = @"INSERT INTO [T_PAYMENT_MAIN](PAYMENT_NO,PAYMENT_DATE,PAID,BALANCE,NET_AMOUNT,PAYMENT,
                                         RECEIVED_BY,CUSTOMER_ID,COMPANY_ID,STATUS,ACTIVE) VALUES ("
                                       + "'" + txt_pay_no.Text + "',"
                                       + "'" + txt_datetime.Value.Date + "',"
                                       + "" + txt_paid.Text + ","
                                        + "" + txt_balance.Text + ","
                                       + "" + txt_amount.Text + ","
                                       + "" + txt_payment.Text + ","


                                       + "'" + txt_refer.Text + "',"
                                         + "" + txtcustomer.Tag + ","
                                        + "'" + lbl_comp.Tag + "',"

                                       + "'" + "ACTIVE" + "',"
                                       + "" + "1" + ")";
                            sb.Append(Query);
                            //foreach (DataGridViewRow row in dgvitemform.Rows)
                            for (int i = 0; i < dtg_paymain.Rows.Count; i++)
                            {
                                StrQuery = @"INSERT INTO  T_PAYMENT_ITEM (PAYMENT_NO,INVOICE_NO,INVOICE_DATE,PAID,BALANCE,
                                  AMOUNT,PAYMENT,ACTIVE) VALUES ("
                                  + "'" + txt_pay_no.Text + "',"
                                  + "'" + dtg_paymain.Rows[i].Cells["INVOICE_NO"].Value + "', "
                                  + "'" + dtg_paymain.Rows[i].Cells["INVOICE_DATE"].Value + "' ,"
                                  + "" + dtg_paymain.Rows[i].Cells["PAID"].Value + ","
                                  + "" + dtg_paymain.Rows[i].Cells["BALANCE"].Value + ","
                                  + "" + dtg_paymain.Rows[i].Cells["TOTAL"].Value + ","
                                  + "" + dtg_paymain.Rows[i].Cells["PAYMENT"].Value + ","


                                  + "'" + "1" + "')";
                                sb.Append(StrQuery);


                            }
                            // MessageBox.Show("UPLOADED SUCESSFULLY", "Message", MessageBoxButtons.OK);



                            for (int i = 0; i < dtg_pay_bank.Rows.Count; i++)
                            {
                                if (dtg_pay_bank.Rows[i].Cells["amount"].Value != null)
                                {
                                    StrQuery = @"INSERT INTO T_PAID_ITEM (PAYMENT_NO,PAY_MODE,REF_NO,REF_DATE,BANK,
                                  AMOUNT,RECEIVED_BY,ACTIVE) VALUES ("
                                      + "'" + txt_pay_no.Text + "',"
                                      + "" + dtg_pay_bank.Rows[i].Cells["PAY_MODE"].Value + ", "
                                      + "'" + dtg_pay_bank.Rows[i].Cells["ref_no"].Value + "' ,"
                                      + "'" + dtg_pay_bank.Rows[i].Cells["ref_date"].Value + "',"
                                      + "" + dtg_pay_bank.Rows[i].Cells["BANK"].Value + ","
                                      + "" + dtg_pay_bank.Rows[i].Cells["amount"].Value + ","
                                     + "'" + txt_refer.Text + "',"


                                      + "" + "1" + ")";
                                    sb.Append(StrQuery);

                                }
                            }

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



                            comm.CommandText = sb.ToString();
                            comm.Transaction = Transaction;
                            comm.ExecuteNonQuery();


                            Transaction.Commit();

                            StringBuilder builder = new StringBuilder();
                            builder.Append("SAVED SUCESSFULLY \n PAYMENT_NO - ");
                            builder.Append(txt_pay_no.Text);
                            MessageBox.Show(builder.ToString(), "INVENTORY MANAGEMENT", MessageBoxButtons.OK);
                            conn.Close();

                            clear();
                            this.Close();
                            frm_payment_list frm_payment_list = new frm_payment_list();
                            frm_payment_list.MdiParent = frm_mid.ActiveForm;
                            frm_payment_list.Show();
                        }
                        catch (Exception ex)
                        {
                            Transaction.Rollback();
                            MessageBox.Show(ex.Message);
                            clear();
                            this.Close();
                            frm_payment_list frm_payment_list = new frm_payment_list();
                            frm_payment_list.MdiParent = frm_mid.ActiveForm;
                            frm_payment_list.Show();
                        }
                    }
                }
                else if (mode == "EDIT PAYMENT")
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

                            Query = @"UPDATE [T_PAYMENT_MAIN]  SET
                                 PAYMENT_NO ='" + txt_pay_no.Text + "'," +
                          "PAYMENT_DATE = '" + txt_datetime.Value.Date + "'," +
                           "PAID = '" + txt_paid.Text + "'," +
                           "BALANCE ='" + txt_balance.Text + "'," +
                             "AMOUNT = '" + txt_amount.Text + "'," +
                          "CUSTOMER_ID = '" + txtcustomer.Tag + "'," +

                        "[PAYMENT] = '" + txt_payment.Text + "'," +
                        "RECEIVED_BY = '" + txt_refer.Text + "'," +

                       "COMPANY_ID = '" + lbl_comp.Tag + "'," +
                        "STATUS = '" + "ACTIVE" + "'," +
                    " ACTIVE ='" + "1" + "'" +
                    "WHERE PAYMENT_NO ='" + txt_pay_no.Text + "'";

                            sb.Append(Query);

                            for (int i = 0; i < dtg_paymain.Rows.Count; i++)
                            {
                                StrQuery = @"UPDATE [T_PAYMENT_ITEM] SET
                                          PAYMENT_NO= '" + txt_pay_no.Text + "'," +
                                          "INVOICE_NO = '" + dtg_paymain.Rows[i].Cells["INVOICE_NO"].Value + "', " +
                                          "INVOICE_DATE = '" + dtg_paymain.Rows[i].Cells["INVOICE_DATE"].Value + "' ," +
                                          "PAID='" + dtg_paymain.Rows[i].Cells["PAID"].Value + "'," +
                                           "BALANCE='" + dtg_paymain.Rows[i].Cells["BALANCE"].Value + "'," +
                                           "NET_AMOUNT= '" + dtg_paymain.Rows[i].Cells["TOTAL"].Value + "'," +
                                             "PAYMENT='" + dtg_paymain.Rows[i].Cells["PAYMENT"].Value + "'," +


                                              "" + "ACTIVE =" + "1" + " WHERE PAYMENT_NO ='" + txt_pay_no.Text + "'";

                                sb.Append(StrQuery);

                                //StrQuery = @"INSERT INTO T_PAID_ITEM (PAYMENT_NO,PAY_MODE_ID,REF_NO,REF_DATE,BANK_ID,
                                //  AMOUNT,RECEIVED_BY,ACTIVE) VALUES ("
                                //     + "'" + txt_pay_no.Text + "',"
                                //     + "" + dtg_pay_bank.Rows[i].Cells["pay_mode"].Value + ", "
                                //     + "'" + dtg_pay_bank.Rows[i].Cells["ref_no"].Value + "' ,"
                                //     + "'" + dtg_pay_bank.Rows[i].Cells["ref_date"].Value + "',"
                                //     + "" + dtg_pay_bank.Rows[i].Cells["bank"].Value + ","
                                //     + "" + dtg_pay_bank.Rows[i].Cells["amount"].Value + ","
                                //    + "'" + txt_refer.Text + "',"
                            }
                            for (int i = 0; i < dtg_pay_bank.Rows.Count; i++)
                            {
                                if (dtg_pay_bank.Rows[i].Cells["amount"].Value != null)
                                {
                                    String PAY_Query = @"UPDATE [T_PAID_ITEM] SET
                                          PAYMENT_NO= '" + txt_pay_no.Text + "'," +
                                          "PAY_MODE = '" + dtg_pay_bank.Rows[i].Cells["PAY_MODE_ID"].Value + "', " +
                                          "REF_NO = '" + dtg_pay_bank.Rows[i].Cells["ref_no"].Value + "' ," +
                                          "REF_DATE='" + dtg_pay_bank.Rows[i].Cells["ref_date"].Value + "'," +
                                           "BANK ='" + dtg_pay_bank.Rows[i].Cells["BANK_ID"].Value + "'," +
                                           "AMOUNT= '" + dtg_pay_bank.Rows[i].Cells["amount"].Value + "'," +
                                             "RECEIVED_BY='" + txt_refer.Text + "'," +


                                               "" + "ACTIVE =" + "1" + " WHERE PAYMENT_NO ='" + txt_pay_no.Text + "'";

                                    sb.Append(PAY_Query);
                                }
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



                            comm.CommandText = sb.ToString(); ;


                            comm.Transaction = transaction;
                            comm.ExecuteNonQuery();
                            transaction.Commit();

                            StringBuilder builder = new StringBuilder();
                            builder.Append("SAVED SUCESSFULLY \n PAYMENT_NO - ");
                            builder.Append(txt_pay_no.Text);
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
                            frm_payment_list frm_Invoice_ = new frm_payment_list();
                            frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                            frm_Invoice_.Show();
                        }
                    }


                }

                else
                {
                    if (mode == "DELETE PAYMENT")
                    {
                        using (SqlConnection conn = new SqlConnection(ConnString))
                        {
                            conn.Open();
                            SqlTransaction transaction = conn.BeginTransaction();


                            DialogResult done = (MessageBox.Show("Are you sure want to CANCEL this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                            if (done == DialogResult.Yes)
                            {


                                string StrQuery = "UPDATE [T_PAYMENT_MAIN] SET STATUS = '" + "CANCELED" + "'," +
                                    "  ACTIVE = " + "0" + " WHERE INVOICE_NO ='" + txt_pay_no.Text + "'";
                                string Query = "UPDATE [T_PAYMENT_ITEM] SET   ACTIVE = " + "0" + " WHERE INVOICE_NO ='" + txt_pay_no.Text + "'";
                                string PAY_Query = "UPDATE [T_PAID_ITEM] SET   ACTIVE = " + "0" + " WHERE INVOICE_NO ='" + txt_pay_no.Text + "'";
                                try
                                {

                                    SqlCommand comm = new SqlCommand();


                                    comm.Connection = conn;

                                    //foreach (DataGridViewRow row in dgvitemform.Rows)
                                    StringBuilder sb = new StringBuilder();
                                    sb.Append(StrQuery);
                                    sb.Append(Query);
                                    sb.Append(PAY_Query);

                                    comm.CommandText = sb.ToString();
                                    comm.Transaction = transaction;
                                    comm.ExecuteNonQuery();
                                    transaction.Commit();
                                    StringBuilder builder = new StringBuilder();
                                    builder.Append("CANCELED SUCESSFULLY \n PAYMENT_NO - ");
                                    builder.Append(txt_pay_no.Text);
                                    MessageBox.Show(builder.ToString(), "INVENTORY MANAGEMENT", MessageBoxButtons.OK);
                                    // conn.Close();

                                    clear();
                                    this.Close();
                                    frm_payment_list frm_Invoice_ = new frm_payment_list();
                                    frm_Invoice_.MdiParent = frm_mid.ActiveForm;
                                    frm_Invoice_.Show();




                                }

                                catch (Exception ex)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show(ex.Message);
                                    clear();
                                    this.Close();
                                    frm_payment_list frm_Invoice_ = new frm_payment_list();
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
        public void amount_add()
        {
            Double sum = 0;
            int i;
            Double sum1 = 0;
            Double sum2 = 0;



            for (i = 0; i < dtg_paymain.Rows.Count; i++)
            {
                sum += Double.Parse(dtg_paymain.Rows[i].Cells["total"].Value.ToString());
                sum1 += Double.Parse(dtg_paymain.Rows[i].Cells["paid"].Value.ToString());
                sum2 += Double.Parse(dtg_paymain.Rows[i].Cells["balance"].Value.ToString());


            }

            txt_amount.Text = sum.ToString();
            txt_paid.Text = sum1.ToString();
            txt_balance.Text = sum2.ToString();


            dtg_paymain.Refresh(); ;

        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
            frm_payment_list payment_List = new frm_payment_list();
            payment_List.MdiParent = frm_mid.ActiveForm;
            payment_List.Show();
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
        public void edit_form()
        {
            if (mode == "EDIT PAYMENT")
            {
                txt_pay_no.Text = frm_payment_list.value1;
                //txtcustomer.Text = frm_payment_list.value2;
                this.Text = mode;
                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                string MAIN_QUERY = "SELECT PAYMENT_DATE,PAID,BALANCE,AMOUNT,PAYMENT,RECEIVED_BY,M_CUSTOMER.CUSTOMER_NAME,T_PAYMENT_MAIN.COMPANY_ID,T_PAYMENT_MAIN.CUSTOMER_ID FROM T_PAYMENT_MAIN " +
                     "INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_PAYMENT_MAIN.CUSTOMER_ID " +
                     "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                String SQLQuery = "SELECT M_PAY.PAY_MODE,REF_NO,REF_DATE,M_BANK.BANK,AMOUNT,T_PAID_ITEM.PAY_MODE AS [PAY_MODE_ID],T_PAID_ITEM.BANK AS [BANK_ID] FROM T_PAID_ITEM " +
                    "INNER JOIN M_PAY ON M_PAY.PAY_MODE_ID = T_PAID_ITEM.PAY_MODE " +
                    "INNER JOIN  M_BANK ON M_BANK.BANK_ID = T_PAID_ITEM.BANK " +
                    "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                String sqlquery = "SELECT INVOICE_NO, INVOICE_DATE,NET_AMOUNT,PAID,BALANCE,PAYMENT FROM T_PAYMENT_ITEM " +
                    "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "PAYMENT");
                dtg_pay_bank.DataSource = ds.Tables["PAYMENT"].DefaultView;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlquery, ConnString);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data, "PAYMENT_MAIN");
                dtg_paymain.DataSource = data.Tables["PAYMENT_MAIN"].DefaultView;

                try
                {

                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {

                        SqlCommand comm = new SqlCommand(MAIN_QUERY, conn);
                        conn.Open();
                        SqlDataReader dr1 = comm.ExecuteReader();
                        SqlDataAdapter dr = new SqlDataAdapter(comm);
                        while (dr1.Read())
                        {
                            lbl_comp.Tag = dr1["COMPANY_ID"].ToString();
                            txtcustomer.Tag = dr1["CUSTOMER_ID"].ToString();
                            txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();

                            txt_datetime.Value = Convert.ToDateTime(dr1["PAYMENT_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                            txt_amount.Text = dr1["AMOUNT"].ToString();
                            txt_paid.Text = dr1["paid"].ToString();
                            txt_balance.Text = dr1["BALANCE"].ToString();
                            txt_payment.Text = dr1["PAYMENT"].ToString();
                            txt_refer.Text = dr1["RECEIVED_BY"].ToString();


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
        public void view_form()
        {
            if (mode == "VIEW PAYMENT")
            {
                txt_pay_no.Text = frm_payment_list.value1;
                //txtcustomer.Text = frm_payment_list.value2;
                this.Text = mode;
                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                string MAIN_QUERY = "SELECT PAYMENT_DATE,PAID,BALANCE,AMOUNT,PAYMENT,RECEIVED_BY,M_CUSTOMER.CUSTOMER_NAME,T_PAYMENT_MAIN.COMPANY_ID,T_PAYMENT_MAIN.CUSTOMER_ID FROM T_PAYMENT_MAIN " +
                     "INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_PAYMENT_MAIN.CUSTOMER_ID " +
                     "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                String SQLQuery = "SELECT M_PAY.PAY_MODE,REF_NO,REF_DATE,M_BANK.BANK,AMOUNT FROM T_PAID_ITEM " +
                    "INNER JOIN M_PAY ON M_PAY.PAY_MODE_ID = T_PAID_ITEM.PAY_MODE " +
                    "INNER JOIN  M_BANK ON M_BANK.BANK_ID = T_PAID_ITEM.BANK  " +
                    "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                String sqlquery = "SELECT INVOICE_NO, INVOICE_DATE,NET_AMOUNT,PAID,BALANCE,PAYMENT FROM T_PAYMENT_ITEM " +
                    "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "PAYMENT");
                dtg_pay_bank.DataSource = ds.Tables["PAYMENT"].DefaultView;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlquery, ConnString);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data, "PAYMENT_MAIN");
                dtg_paymain.DataSource = data.Tables["PAYMENT_MAIN"].DefaultView;

                try
                {

                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {

                        SqlCommand comm = new SqlCommand(MAIN_QUERY, conn);
                        conn.Open();
                        SqlDataReader dr1 = comm.ExecuteReader();
                        SqlDataAdapter dr = new SqlDataAdapter(comm);
                        while (dr1.Read())
                        {
                            lbl_comp.Tag = dr1["COMPANY_ID"].ToString();
                            txtcustomer.Tag = dr1["CUSTOMER_ID"].ToString();
                            txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();

                            txt_datetime.Value = Convert.ToDateTime(dr1["PAYMENT_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                            txt_amount.Text = dr1["AMOUNT"].ToString();
                            txt_paid.Text = dr1["paid"].ToString();
                            txt_balance.Text = dr1["BALANCE"].ToString();
                            txt_payment.Text = dr1["PAYMENT"].ToString();
                            txt_refer.Text = dr1["RECEIVED_BY"].ToString();


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
                dtg_paymain.ReadOnly = true;
                dtg_paymain.Enabled = false;
                btn_close.Enabled = false;
                txt_pay_no.Enabled = false;
                dtg_pay_bank.ReadOnly = true;
                dtg_pay_bank.Enabled = false;
                clk_select_all.Enabled = false;
                txt_amount.ReadOnly = true;
                txt_amount.Enabled = false;
                txt_paid.Enabled = false;
                txt_balance.Enabled = false;
                txt_payment.Enabled = false;
                txt_refer.Enabled = false;
                ///*btnadd*/.Enabled = false;

            }
        }
        public void DELETE_form()
        {

            if (mode == "DELETE PAYMENT")
            {
                txt_pay_no.Text = frm_payment_list.value1;
                //txtcustomer.Text = frm_payment_list.value2;
                this.Text = mode;
                String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
                // String str = "Select * from T_QUOTATION_ITEM";
                string MAIN_QUERY = "SELECT PAYMENT_DATE,PAID,BALANCE,AMOUNT,PAYMENT,RECEIVED_BY,M_CUSTOMER.CUSTOMER_NAME,T_PAYMENT_MAIN.COMPANY_ID,T_PAYMENT_MAIN.CUSTOMER_ID FROM T_PAYMENT_MAIN " +
                     "INNER JOIN M_CUSTOMER ON M_CUSTOMER.CUSTOMER_ID = T_PAYMENT_MAIN.CUSTOMER_ID " +
                     "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                String SQLQuery = "SELECT M_PAY.PAY_MODE,REF_NO,REF_DATE,M_BANK.BANK,AMOUNT FROM T_PAID_ITEM " +
                    "INNER JOIN M_PAY ON M_PAY.PAY_MODE_ID = T_PAID_ITEM.PAY_MODE " +
                    "INNER JOIN  M_BANK ON M_BANK.BANK_ID = T_PAID_ITEM.BANK  " +
                    "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                String sqlquery = "SELECT INVOICE_NO, INVOICE_DATE,NET_AMOUNT,PAID,BALANCE,PAYMENT FROM T_PAYMENT_ITEM " +
                    "WHERE PAYMENT_NO = '" + txt_pay_no.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(SQLQuery, ConnString);
                DataSet ds = new DataSet();
                da.Fill(ds, "PAYMENT");
                dtg_pay_bank.DataSource = ds.Tables["PAYMENT"].DefaultView;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlquery, ConnString);
                DataSet data = new DataSet();
                sqlDataAdapter.Fill(data, "PAYMENT_MAIN");
                dtg_paymain.DataSource = data.Tables["PAYMENT_MAIN"].DefaultView;

                try
                {

                    using (SqlConnection conn = new SqlConnection(ConnString))
                    {

                        SqlCommand comm = new SqlCommand(MAIN_QUERY, conn);
                        conn.Open();
                        SqlDataReader dr1 = comm.ExecuteReader();
                        SqlDataAdapter dr = new SqlDataAdapter(comm);
                        while (dr1.Read())
                        {
                            lbl_comp.Tag = dr1["COMPANY_ID"].ToString();
                            txtcustomer.Tag = dr1["CUSTOMER_ID"].ToString();
                            txtcustomer.Text = dr1["CUSTOMER_NAME"].ToString();

                            txt_datetime.Value = Convert.ToDateTime(dr1["PAYMENT_DATE"].ToString()); /*(DateTime)dr.GetValue(2);*/
                            txt_amount.Text = dr1["AMOUNT"].ToString();
                            txt_paid.Text = dr1["paid"].ToString();
                            txt_balance.Text = dr1["BALANCE"].ToString();
                            txt_payment.Text = dr1["PAYMENT"].ToString();
                            txt_refer.Text = dr1["RECEIVED_BY"].ToString();


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
                dtg_paymain.ReadOnly = true;
                dtg_paymain.Enabled = false;
                btn_close.Enabled = false;
                txt_pay_no.Enabled = false;
                dtg_pay_bank.ReadOnly = true;
                dtg_pay_bank.Enabled = false;
                clk_select_all.Enabled = false;
                txt_amount.ReadOnly = true;
                txt_amount.Enabled = false;
                txt_paid.Enabled = false;
                txt_balance.Enabled = false;
                txt_payment.Enabled = false;
                txt_refer.Enabled = false;
                ///*btnadd*/.Enabled = false;

            }
        }
        //public void print_form()
        //{

        //    if (printPreviewDialog.ShowDialog() != 0)
        //    {

        //        System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
        //        PrintDialog1.AllowSomePages = true;
        //        PrintDialog1.ShowHelp = true;
        //        PrintDialog1.Document = printDocument;
        //        DialogResult result = PrintDialog1.ShowDialog();
        //        if (result == DialogResult.OK)
        //        {
        //            printDocument.Print();
        //        }
        //        refresh();
        //    }
        //}
        private void frm_payment_Load(object sender, EventArgs e)
        {
            lbl_comp.Tag = frm_payment_list.comp_id;
            entry_name = frm_payment_list.NAME_ID;
            //bank_ddown();
            // btn_close.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_close.Width, btn_close.Height, 70, 70));
            //btn_save.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_save.Width, btn_save.Height, 70, 70));
            //this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 70, 70));
        }

        private void txtcustomer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

            }
        }

        private void txtcustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmf2 popup = new frmf2();
                string _query = "SELECT CUSTOMER_ID AS [ID], CUSTOMER_NAME, CUSTOMER_TITLE FROM M_CUSTOMER WHERE ACTIVE = 1";
                popup.ShowF2(_query, "CUSTOMER_NAME", ((TextBox)sender).Text, "CUSTOMER_NAME", sender);
            }
        }

        private void dtg_paymain_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_paymain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {


                DataGridViewRow selectedRow = dtg_paymain.Rows[e.RowIndex];
                string s_no = Convert.ToString(selectedRow.Cells[0].Value);

                // if ((dtg_paymain.Rows[e.RowIndex].Cells["select"].ValueType) != null)
                bool clk = Convert.ToBoolean(selectedRow.Cells["SELECT"].EditedFormattedValue);
                int value_change = Convert.ToInt32(dtg_paymain.Rows[e.RowIndex].Cells["SELECT"].RowIndex);
                if (clk == true)
                {
                    if (selectedRow.Cells["SELECT"].ValueType != null)
                    {
                        while (value_change <= dtg_paymain.Rows.Count)
                        {
                            if (rbtn_credit_note.Checked == true)
                            {
                                foreach (DataGridViewRow viewRow in dtg_paymain.Rows)
                                {
                                    //string index = dtg_paymain.CurrentCell["select"].Value.ToString();
                                    int rowIndex = e.RowIndex;
                                    DataGridViewRow select_row = dtg_credit.Rows[rowIndex];
                                    int payindex = dtg_paymain.CurrentCell.RowIndex;
                                    DataGridViewRow pay_row = dtg_paymain.Rows[payindex];
                                    //int value_change = Convert.ToInt32(viewRow.Cells["SELECT"].RowIndex);
                                    //if (viewRow.Cells["SELECT"].Value != null)
                                    //{

                                    //    if (row.Cells["amount"].Value != null)
                                    //    {
                                    //bool clk = Convert.ToBoolean(viewRow.Cells["SELECT"].EditedFormattedValue);
                                    if (select_row.Cells["NET_AMOUNT"].Value != null)
                                    {
                                        if (clk == true)
                                        {
                                            //object Value1 = select_row.Cells["NET_AMOUNT"].Value;
                                            //paid_value = Value1;


                                            //txt_credit.Text = paid_value.ToString();
                                            decimal sum2 = decimal.Parse(txt_credit.Text);
                                            decimal sum7 = decimal.Parse(viewRow.Cells["balance"].Value.ToString());
                                            sum7 -= sum2;
                                            viewRow.Cells["balance"].Value = sum7.ToString();

                                            amount_add();
                                            break;

                                        }
                                        else
                                        {
                                            viewRow.Cells["paid"].Value = 0;
                                        }
                                        //    }
                                        //}

                                    }
                                }
                            }
                            else
                            {
                                foreach (DataGridViewRow viewRow in dtg_paymain.Rows)
                                {
                                    //string index = dtg_paymain.CurrentCell["select"].Value.ToString();
                                    int rowIndex = e.RowIndex;
                                    DataGridViewRow select_row = dtg_pay_bank.Rows[rowIndex];
                                    int payindex = dtg_paymain.CurrentCell.RowIndex;
                                    DataGridViewRow pay_row = dtg_paymain.Rows[payindex];
                                    //int value_change = Convert.ToInt32(viewRow.Cells["SELECT"].RowIndex);
                                    //if (viewRow.Cells["SELECT"].Value != null)
                                    //{

                                    //    if (row.Cells["amount"].Value != null)
                                    //    {
                                    //bool clk = Convert.ToBoolean(viewRow.Cells["SELECT"].EditedFormattedValue);
                                    if (select_row.Cells["amount"].Value != null)
                                    {
                                        if (clk == true)
                                        {
                                            object Value1 = select_row.Cells["amount"].Value;
                                            paid_value = Value1;



                                            pay_row.Cells["paid"].Value = paid_value.ToString();
                                            decimal sum2 = decimal.Parse(viewRow.Cells["paid"].Value.ToString());
                                            decimal sum7 = decimal.Parse(viewRow.Cells["total"].Value.ToString());
                                            sum7 -= sum2;
                                            viewRow.Cells["balance"].Value = sum7.ToString();

                                            amount_add();
                                            break;

                                        }
                                        else
                                        {
                                            viewRow.Cells["paid"].Value = 0;
                                        }
                                        //    }
                                        //}

                                    }
                                }
                            }

                            string sum3 = dtg_paymain.Rows[value_change].Cells["BALANCE"].Value.ToString();
                            dtg_paymain.Rows[value_change].Cells["PAYMENT"].Value = sum3.ToString();

                            break;

                        }
                    }



                    // txt_total.Text = sum4.ToString();

                }
                else
                {
                    if (clk == false)
                    //if ((dtg_debit.Rows[e.RowIndex].Cells["active"].ValueType) == null)
                    {
                        double sum = 0;
                        dtg_paymain.Rows[value_change].Cells["PAYMENT"].Value = sum.ToString();

                        //txt_payment.Text = "";

                        // txt_total.Text = sum4.ToString();
                    }
                }


                Double sum4 = 0;


                for (int i = 0; i < dtg_paymain.Rows.Count; i++)

                {
                    if (dtg_paymain.Rows[i].Cells["PAYMENT"].Value != null)
                    {
                        sum4 += Double.Parse(dtg_paymain.Rows[i].Cells["PAYMENT"].Value.ToString());
                        txt_payment.Text = sum4.ToString();


                    }

                    else
                    {
                        dtg_paymain.Rows[i].Cells["PAYMENT"].Value = 0;
                    }
                }

            }
        }

        private void clk_select_all_CheckedChanged(object sender, EventArgs e)
        {
            if (clk_select_all.Checked == true)
            {
                foreach (DataGridViewRow viewRow in dtg_paymain.Rows)
                {
                    DataGridViewCheckBoxCell selectall = (DataGridViewCheckBoxCell)viewRow.Cells["SELECT"];
                    selectall.Value = true;
                    select_all();
                }
            }
            else
            {
                if (clk_select_all.Checked == false)
                {
                    foreach (DataGridViewRow viewRow in dtg_paymain.Rows)
                    {
                        DataGridViewCheckBoxCell selectall = (DataGridViewCheckBoxCell)viewRow.Cells["SELECT"];
                        selectall.Value = false;
                        select_all();
                    }
                }
            }
        }
        public void select_all()
        {
            foreach (DataGridViewRow selectedRow in dtg_paymain.Rows)
            {
                string s_no = Convert.ToString(selectedRow.Cells[0].Value);

                // if ((dtg_paymain.Rows[e.RowIndex].Cells["select"].ValueType) != null)
                bool clk = Convert.ToBoolean(selectedRow.Cells["SELECT"].EditedFormattedValue);
                int value_change = Convert.ToInt32(selectedRow.Cells["SELECT"].RowIndex);
                if (clk == true)
                {
                    if (selectedRow.Cells["SELECT"].ValueType != null)
                    {
                        while (value_change <= dtg_paymain.Rows.Count)
                        {

                            string sum3 = dtg_paymain.Rows[value_change].Cells["BALANCE"].Value.ToString();
                            dtg_paymain.Rows[value_change].Cells["PAYMENT"].Value = sum3.ToString();

                            break;

                        }
                    }



                    // txt_total.Text = sum4.ToString();

                }
                else
                {
                    if (clk == false)
                    //if ((dtg_debit.Rows[e.RowIndex].Cells["active"].ValueType) == null)
                    {
                        double sum = 0;
                        dtg_paymain.Rows[value_change].Cells["PAYMENT"].Value = sum.ToString();

                        //txt_payment.Text = "";

                        // txt_total.Text = sum4.ToString();
                    }
                }


                Double sum4 = 0;


                for (int i = 0; i < dtg_paymain.Rows.Count; i++)

                {
                    if (dtg_paymain.Rows[i].Cells["PAYMENT"].Value != null)
                    {
                        sum4 += Double.Parse(dtg_paymain.Rows[i].Cells["PAYMENT"].Value.ToString());
                        txt_payment.Text = sum4.ToString();


                    }

                    else
                    {
                        dtg_paymain.Rows[i].Cells["PAYMENT"].Value = 0;
                    }
                }
            }
        }
        public void pay_method()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT PAY_MODE_ID, PAY_MODE FROM M_PAY", ConnString);
            dataAdapter.Fill(dataTable);
            DataRow row = dataTable.NewRow();
            row[1] = "";
            dataTable.Rows.InsertAt(row, 0);
            //dtg_pay_bank.DataSource = dataTable;
            DataGridViewComboBoxColumn comboBoxColumn = dtg_pay_bank.Columns["pay_mode"] as DataGridViewComboBoxColumn;
            comboBoxColumn.DataSource = dataTable;
            comboBoxColumn.DisplayMember = "PAY_MODE";
            comboBoxColumn.ValueMember = "PAY_MODE_ID";
            //foreach(DataRow list in dataTable.Rows)
            //{
            //    int l = dtg_pay_bank.Rows.Add();
            //    dtg_pay_bank.Rows[l].Cells["bank"].Value = list[0].ToString(); 
            //}

        }
        public void bank_ddown()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT BANK_ID, BANK FROM M_BANK", ConnString);
            dataAdapter.Fill(dataTable);
            DataRow row = dataTable.NewRow();
            row[1] = "";
            dataTable.Rows.InsertAt(row, 0);
            //dtg_pay_bank.DataSource = dataTable;
            DataGridViewComboBoxColumn comboBoxColumn = dtg_pay_bank.Columns["BANK"] as DataGridViewComboBoxColumn;
            comboBoxColumn.DataSource = dataTable;
            comboBoxColumn.DisplayMember = "BANK"; // Set the name of the column to display in the dropdown list
            comboBoxColumn.ValueMember = "BANK_ID";
            //foreach(DataRow list in dataTable.Rows)
            //{
            //    int l = dtg_pay_bank.Rows.Add();
            //    dtg_pay_bank.Rows[l].Cells["bank"].Value = list[0].ToString(); 
            //}

        }
        private void dtg_pay_bank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        public object paid_value { get; set; }
        public void amount_pay()
        {

        }

        private void dtg_pay_bank_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
                foreach (DataGridViewRow viewRow in dtg_paymain.Rows)
                {
                    DataGridViewCheckBoxCell selectall = (DataGridViewCheckBoxCell)viewRow.Cells["SELECT"];
                    selectall.Value = false;
                    select_all();
                }
            rbtn_credit_note.Checked = false;
            



        }

        private void dtg_paymain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_paymain_CellValidated(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcustomer_KeyDown_1(object sender, KeyEventArgs e)
        {

        }

        private void txtcustomer_KeyUp_1(object sender, KeyEventArgs e)
        {

        }

        private void clk_select_all_CheckedChanged_1(object sender, EventArgs e)
        {

        }
        String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
        private void dtg_pay_bank_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {


        }

        private void dtg_pay_bank_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //DataGridViewComboBoxEditingControl editingControl = e.Control as DataGridViewComboBoxEditingControl;
            //if (editingControl != null && dtg_pay_bank.CurrentCell.ColumnIndex == bank.Index)
            //{
            //    bank_ddown();
            //}
        }

        private void dtg_pay_bank_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == bank.Index && e.RowIndex >= 0)
            {
                bank_ddown();
            }
            if (e.ColumnIndex == pay_mode.Index && e.RowIndex >= 0)
            {
                pay_method();
            }
        }

        private void dtg_pay_bank_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        public static string item_tag { get; set; }
        public static string item_text { get; set; }
        public static string size_tag { get; set; }
        public static string size_text { get; set; }
        private void frm_payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                //if (mode == "ADD" || mode == "EDIT INVOICE")
                //{
                if (rbtn_credit_note.Checked == true)
                {
                    foreach (DataGridViewRow viewRow in dtg_paymain.SelectedRows)
                    {
                        //bool clk = Convert.ToBoolean(viewRow.Cells["SELECT"].EditedFormattedValue);
                        //if (clk == true)
                        //{
                        //frmf3 popup = new frmf3();
                        //popup.ShowF3("RETURN OF GOODS", valuetoadd, sender);
                        ////popup.Show();
                        frmf5 popup = new frmf5();
                        popup.item_text = "PAYMENT";
                        string _query = "SELECT T_INVOICE_ITEM.ITEM_ID AS [ID],T_INVOICE_ITEM.SIZE_ID AS [ID],  ITEM_NAME,SIZE_NAME FROM T_INVOICE_ITEM " +
                            "INNER JOIN M_ITEM ON T_INVOICE_ITEM.ITEM_ID = M_ITEM.ITEM_ID " +
                            "INNER JOIN M_SIZE ON T_INVOICE_ITEM.SIZE_ID = M_SIZE.SIZE_ID " +
                            "WHERE INVOICE_NO = '" + viewRow.Cells["invoice_no"].Value + "'";
                        popup.ShowF5(_query, "ITEM_NAME", "SIZE_NAME", (item_text), "ITEM_NAME", sender);
                        //}
                    }
                    //  ITEM_LOAD();
                }
            }


            if (e.KeyCode == Keys.X && e.Alt)
            {
                clear();
                this.Close();
                frm_payment_list payment_List = new frm_payment_list();
                payment_List.MdiParent = frm_mid.ActiveForm;
                payment_List.Show();
            }
        }

        private void txtcustomer_TextChanged(object sender, EventArgs e)
        {
            String ConnString = @"Data Source=DESKTOP-4DTMDPH;Initial Catalog=QUOTATION;Integrated Security=True";
            //String str = "Select * from T_QUOTATION_ITEM";

            String sqlquery = "SELECT INVOICE_NO,INVOICE_DATE,NET_AMOUNT  FROM T_INVOICE_APPROVAL WHERE CUSTOMER_ID = '" + txtcustomer.Tag + "' AND APPROVAL_CHECK =" + "1" + "";
            SqlDataAdapter da = new SqlDataAdapter(sqlquery, ConnString);
            DataSet ds = new DataSet();
            da.Fill(ds, "INVOICE");
            dtg_paymain.DataSource = ds.Tables["INVOICE"].DefaultView;

            for (int i = 0; i < dtg_paymain.Rows.Count; i++)
            {
                paid_value = "0";
                dtg_paymain.Rows[i].Cells["paid"].Value = paid_value;
                decimal sum2 = decimal.Parse(dtg_paymain.Rows[i].Cells["paid"].Value.ToString());
                decimal sum3 = decimal.Parse(dtg_paymain.Rows[i].Cells["total"].Value.ToString());
                sum3 -= sum2;
                dtg_paymain.Rows[i].Cells["balance"].Value = sum3.ToString();
            }
            amount_add();
        }
        public void ITEM_LOAD()
        {
            foreach (DataGridViewRow dataGrid in dtg_credit.SelectedRows)
            {
                dataGrid.Cells["ITEM"].Value = item_text;
                dataGrid.Cells["item_id"].Value = item_tag;
                dataGrid.Cells["SIZE"].Value = size_text;
                dataGrid.Cells["SIZE_ID"].Value = size_tag;

            }
        }








        public void GST_CALCULATION()
        {
            foreach (DataGridViewRow row in dtg_credit.SelectedRows)
            {
                string ITEM = row.Cells["ITEM_ID"].Value.ToString();

                String query = "select cgst,igst,sgst from m_item where ITEM_ID='" + ITEM + "'";
                SqlConnection conn = new SqlConnection(ConnString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cgst = dr["CGST"].ToString();
                    igst = dr["IGST"].ToString();
                    sgst = dr["SGST"].ToString();
                }
                dr.Close();
                conn.Close();
            }
        }
        public string sgst { get; set; }
        public string igst { get; set; }
        public string cgst { get; set; }
        private void dtg_credit_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dtg_credit.Rows)
            {
                if (row.Cells["ITEM"].Value != null)
                {
                    //row.Cells["paid"].Value = 0;



                    double Sgst = Convert.ToDouble(sgst);
                    double Cgst = Convert.ToDouble(cgst);
                    double Igst = Convert.ToDouble(igst);
                    if (row.Cells["RATE"].Value != null)
                    {
                        decimal sum2 = decimal.Parse(row.Cells["QUANTITY"].Value.ToString());
                        decimal sum3 = decimal.Parse(row.Cells["RATE"].Value.ToString());
                        decimal sum4 = sum3 * sum2;
                        row.Cells["SGST"].Value = Convert.ToString((Sgst / 100.00) * (Convert.ToDouble(sum4)));
                        row.Cells["CGST"].Value = Convert.ToString((Cgst / 100.00) * (Convert.ToDouble(sum4)));


                        row.Cells["IGST"].Value = Convert.ToString((Igst / 100.00) * (Convert.ToDouble(sum4)));

                        Decimal GST = Convert.ToDecimal(Convert.ToDouble(row.Cells["SGST"].Value) + Convert.ToDouble(row.Cells["CGST"].Value) + Convert.ToDouble(row.Cells["IGST"].Value));
                        Double TOTAL = Convert.ToDouble(GST + sum4);
                        row.Cells["NET_AMOUNT"].Value = TOTAL.ToString();
                        //sum_total();
                        double sum8 = 0;
                        foreach (DataGridViewRow dataGrid in dtg_credit.Rows)
                        {

                            if (dataGrid.Cells["RATE"].Value != null && dataGrid.Cells["QUANTITY"].Value != null && dataGrid.Cells["NET_AMOUNT"].Value != null && dataGrid.Cells["NET_AMOUNT"].Value.ToString() != string.Empty)
                            {

                                sum8 += Convert.ToDouble(dataGrid.Cells["NET_AMOUNT"].Value);
                                txt_credit.Text = sum8.ToString();
                            }
                        }


                        //}


                    }

                }

            }
        }
        public void sum_total()
        {
            Double sum = 0;
            //int i;
            Double sum1 = 0;
            Double sum2 = 0;

            foreach (DataGridViewRow viewRow in dtg_credit.Rows)
            {
                if (viewRow.Cells["total"].Value != null && viewRow.Cells["NET_AMOUNT"].Value.ToString() != string.Empty)
                {
                    //for (i = 0; i < dtg_debit.Rows.Count; i++)
                    //{
                    sum += Double.Parse(viewRow.Cells["total"].Value.ToString());
                    sum1 += Double.Parse(viewRow.Cells["paid"].Value.ToString());
                    sum2 += Double.Parse(viewRow.Cells["balance"].Value.ToString());


                    //}

                    txt_amount.Text = sum.ToString();
                    txt_paid.Text = sum1.ToString();
                    txt_balance.Text = sum2.ToString();

                }
                else
                {

                }
            }

        }

        private void dtg_credit_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }

        private void dtg_credit_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void rbtn_credit_note_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_credit_note.Checked == true)
            {
                if (clk_select_all.Checked == false)
                {
                    foreach (DataGridViewRow viewRow in dtg_paymain.Rows)
                    {
                        DataGridViewCheckBoxCell selectall = (DataGridViewCheckBoxCell)viewRow.Cells["SELECT"];
                        selectall.Value = false;
                        select_all();
                    }
                }
            }
        }
    }
}
