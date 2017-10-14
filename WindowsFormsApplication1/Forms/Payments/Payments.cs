using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

using WindowsFormsApplication1.Forms;
namespace WindowsFormsApplication1.Forms
{
    public partial class Payments : MetroFramework.Forms.MetroForm
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void Payments_Load(object sender, EventArgs e)
        {

            try
            {
                gvBalanceCustomer.DataSource = new DAO().GetCustomersBalance();
                lblNetTotal.Text = new DAO().NetTotal().ToString();
                lblPaidAmount.Text = new DAO().PaidAmount().ToString();


                lblBalance.Text = new DAO().Balance().ToString();
                gvBalanceSupplier.DataSource = new DAO().GetSupplierBalanceSheet();
                if (gvBalanceSupplier.Rows.Count == 0)
                {
                    lblBalanceSupp.Text = 0.ToString();
                }
                else
                {
                    lblBalanceSupp.Text = new DAO().getSupplierBalance().ToString();
                }
                cmbcusname.DataSource = new DAO().GetCustomers();
                cmbcusname.DisplayMember = "Name";
                cmbcusname.ValueMember = "Customer-ID";
                cmbcusname.SelectedIndex = -1;
                txtcusAmount.Text = 0.ToString();

                //cmbsuppname.DataSource = new DAO().GetSupp();
                //cmbsuppname.DisplayMember = "Display";
                //cmbsuppname.ValueMember = "SId";

                //cmbsuppname.SelectedIndex = -1;
                //txtAmount.Text = 0.ToString();
            }
            catch (Exception)
            {
            }

        }



        private void txtcusBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                //  lblmsg.Text = "Wrong Input! Error";
            }
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabcontrol_Click(object sender, EventArgs e)
        {

        }

        private void txtcusAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                //  lblmsg.Text = "Wrong Input! Error";
            }
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
                //  lblmsg.Text = "Wrong Input! Error";
            }
        }

        //private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    lblError2.Text = "";
        //    if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == 32)
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //        System.Media.SystemSounds.Beep.Play();
        //        // lblmsg.Text = "Wrong Input!  Error";
        //    }
        //}

        //private void metroTile4_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbsuppname.SelectedIndex != -1)
        //        {
        //            if(int.Parse(txtAmount.Text) == 0)
        //            {
        //                lblError2.ForeColor = System.Drawing.Color.Red;
        //                lblError2.Text = "Payment Cannot be Zero";
        //            }
        //            if(int.Parse(txtBalance.Text) == 0)
        //            {
        //                lblError2.ForeColor = System.Drawing.Color.Red;
        //                lblError2.Text = "Zero Balance!";
        //            }
        //            else
        //            {
        //                int SID = int.Parse(cmbsuppname.SelectedValue.ToString());
        //                decimal amount = decimal.Parse(txtBalance.Text);
        //                decimal balance = amount - int.Parse(txtAmount.Text);
        //                new DAO().InsertSupplierPayment(dtPaydate.Text, SID, balance, amount);
        //                lblError2.ForeColor = System.Drawing.Color.Green;
        //                lblError2.Text = "Successful!";
        //                new DAO().SubSuppBalance(SID, int.Parse(txtAmount.Text));
        //                txtBalance.Text = new DAO().GetSuppBalance(int.Parse(cmbsuppname.SelectedValue.ToString())).ToString();
        //                txtAmount.Text = "";
        //                gvBalanceSupplier.DataSource = new DAO().GetSupplierBalanceSheet();
        //                if (gvBalanceSupplier.Rows.Count == 0)
        //                {
        //                    lblBalanceSupp.Text = 0.ToString();
        //                }
        //                else
        //                {
        //                    lblBalanceSupp.Text = new DAO().getSupplierBalance().ToString();
        //                }
        //            }
                   
        //        }
        //        else
        //        {
        //            lblError2.ForeColor = System.Drawing.Color.Red;
        //            lblError2.Text = "Please Select a Supplier Name!";
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbcusname.SelectedIndex != -1)
                {
                    if (int.Parse(txtcusAmount.Text) == 0)
                    {
                        lblError.ForeColor = System.Drawing.Color.Red;
                        lblError.Text = "Payment Cannot be Zero";
                    }
                    if(int.Parse(txtcusBalance.Text) == 0){
                        lblError.ForeColor = System.Drawing.Color.Red;
                        lblError.Text = "Zero Balance!";
                    }
                    else
                    {
                        int cid = int.Parse(cmbcusname.SelectedValue.ToString());
                        decimal amount = decimal.Parse(txtcusBalance.Text);
                        decimal balance = amount - int.Parse(txtcusAmount.Text);
                        new DAO().AddCustomerPayment(cmbcusspaydate.Text, cid, balance, amount);
                        lblError.ForeColor = System.Drawing.Color.Green;
                        lblError.Text = "Successful!";
                        new DAO().SubInvestorBalance(int.Parse(cmbcusname.SelectedValue.ToString()), int.Parse(txtcusAmount.Text));
                        txtcusBalance.Text = new DAO().GetCustomerBalance(int.Parse(cmbcusname.SelectedValue.ToString())).ToString();
                        txtcusAmount.Text = "";
                        try
                        {
                            gvBalanceCustomer.DataSource = new DAO().GetCustomersBalance();
                            lblNetTotal.Text = new DAO().NetTotal().ToString();
                            lblPaidAmount.Text = new DAO().PaidAmount().ToString();
                            lblBalance.Text = new DAO().Balance().ToString();
                        }
                        catch (Exception ex)
                        {

                        }
                    }


                }
                else
                {
                    lblError.ForeColor = System.Drawing.Color.Red;
                    lblError.Text = "Please select a Customer first!";
                }

            }
            catch (Exception ex)
            {
                // lblmsg.Text = (ex.Message);
            }
        }

        private void tabcontrol_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {


        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void cmbsuppname_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (cmbsuppname.SelectedIndex != -1)
        //        {
        //            lblError2.Text = "";
        //            int a = new DAO().GetSuppBalance(int.Parse(cmbsuppname.SelectedValue.ToString()));
        //            txtBalance.Text = a.ToString();
        //        }
        //        else
        //        {
        //            txtBalance.Text = 0.ToString();
        //        }

        //    }
        //    catch (Exception)
        //    {

        //    }
        //}

        private void cmbcusname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbcusname.SelectedIndex != -1)
                {
                    lblError.Text = "";
                    int a = new DAO().GetCustomerBalance(int.Parse(cmbcusname.SelectedValue.ToString()));
                    txtcusBalance.Text = a.ToString();
                }
                else
                {
                    txtcusBalance.Text = 0.ToString();
                }

            }
            catch (Exception)
            {

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void gvBalanceCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                gvBalanceCustomer.DataSource = new DAO().GetCustomersBalance(txtCusName.Text);
                if (gvBalanceCustomer.Rows.Count == 0)
                {
                    lblNetTotal.Text = 0.ToString();
                    lblPaidAmount.Text = 0.ToString();
                    lblBalance.Text = 0.ToString();
                }
                else
                {
                    lblNetTotal.Text = new DAO().NetTotal(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString())).ToString();
                    lblPaidAmount.Text = new DAO().PaidAmount(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString())).ToString();
                    lblBalance.Text = new DAO().Balance(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString())).ToString();
                }

            }
            catch (Exception ex)
            {

            }

        }

        private void btSearchCustomerByDate_Click(object sender, EventArgs e)
        {
            gvBalanceCustomer.DataSource = new DAO().GetCustomersBalance(txtCusName.Text, dtFromCustomer.Text, dtToCustomer.Text);

            if (gvBalanceCustomer.Rows.Count == 0)
            {
                lblNetTotal.Text = 0.ToString();
                lblPaidAmount.Text = 0.ToString();
                lblBalance.Text = 0.ToString();
            }
            else
            {
                if (txtCusName.Text.Equals(""))
                {
                    lblNetTotal.Text = new DAO().NetTotal(dtFromCustomer.Text, dtToCustomer.Text).ToString();
                    lblPaidAmount.Text = new DAO().PaidAmount(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString()), dtFromCustomer.Text, dtToCustomer.Text).ToString();
                    decimal nettotal = decimal.Parse(lblNetTotal.Text);
                    decimal paidamount = decimal.Parse(lblPaidAmount.Text);
                    lblBalance.Text = (nettotal - paidamount).ToString();
                }
                else
                {
                    lblNetTotal.Text = new DAO().NetTotal(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString()), dtFromCustomer.Text, dtToCustomer.Text).ToString();
                    lblPaidAmount.Text = new DAO().PaidAmount(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString()), dtFromCustomer.Text, dtToCustomer.Text).ToString();
                    decimal nettotal = decimal.Parse(lblNetTotal.Text);
                    decimal paidamount = decimal.Parse(lblPaidAmount.Text);
                    lblBalance.Text = (nettotal - paidamount).ToString();
                }

            }

        }

        private void btnShowAllCusBalance_Click(object sender, EventArgs e)
        {
            try
            {
                gvBalanceCustomer.DataSource = new DAO().GetCustomersBalance();
                lblNetTotal.Text = new DAO().NetTotal().ToString();
                lblPaidAmount.Text = new DAO().PaidAmount().ToString();
                lblBalance.Text = new DAO().Balance().ToString();
            }
            catch (Exception ex)
            {

            }


        }

        private void btnShowAllSuppBalance_Click(object sender, EventArgs e)
        {
            try
            {
                gvBalanceSupplier.DataSource = new DAO().GetSupplierBalanceSheet();
                if (gvBalanceSupplier.Rows.Count == 0)
                {
                    lblBalanceSupp.Text = 0.ToString();
                }
                else
                {
                    lblBalanceSupp.Text = new DAO().getSupplierBalance().ToString();
                }
            }
            catch (Exception ex)
            {

            }

        }

        private void btnSearchByNameSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                gvBalanceSupplier.DataSource = new DAO().GetSupplierBalanceSheet(txtSupplierName.Text);
                if (gvBalanceSupplier.Rows.Count == 0)
                {
                    lblBalanceSupp.Text = 0.ToString();
                }
                else
                {
                    lblBalanceSupp.Text = new DAO().getSupplierBalance(int.Parse(gvBalanceSupplier.CurrentRow.Cells[0].Value.ToString())).ToString();
                }
            }
            catch (Exception ex)
            {

            }


        }

        private void btSearchSupplier_Click(object sender, EventArgs e)
        {
            try
            {
                gvBalanceSupplier.DataSource = new DAO().GetSupplierBalanceSheet(txtSupplierName.Text, dtFromSupplier.Text, dtToSupplier.Text);
                if (gvBalanceSupplier.Rows.Count == 0)
                {
                    lblBalanceSupp.Text = 0.ToString();
                }
                else
                {
                    lblBalanceSupp.Text = new DAO().getSupplierBalance(int.Parse(gvBalanceSupplier.CurrentRow.Cells[0].Value.ToString()), dtFromSupplier.Text, dtToSupplier.Text).ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            lblError.Text = "";
        }

        private void txtcusAmount_KeyUp(object sender, KeyEventArgs e)
        {
            lblError.Text = "";
        }

        private void txtCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    gvBalanceCustomer.DataSource = new DAO().GetCustomersBalance(txtCusName.Text);
                    if (gvBalanceCustomer.Rows.Count == 0)
                    {
                        lblNetTotal.Text = 0.ToString();
                        lblPaidAmount.Text = 0.ToString();
                        lblBalance.Text = 0.ToString();
                    }
                    else
                    {
                        lblNetTotal.Text = new DAO().NetTotal(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString())).ToString();
                        lblPaidAmount.Text = new DAO().PaidAmount(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString())).ToString();
                        lblBalance.Text = new DAO().Balance(int.Parse(gvBalanceCustomer.CurrentRow.Cells[0].Value.ToString())).ToString();
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                try
                {
                    gvBalanceSupplier.DataSource = new DAO().GetSupplierBalanceSheet(txtSupplierName.Text);
                    if (gvBalanceSupplier.Rows.Count == 0)
                    {
                        lblBalanceSupp.Text = 0.ToString();
                    }
                    else
                    {
                        lblBalanceSupp.Text = new DAO().getSupplierBalance(int.Parse(gvBalanceSupplier.CurrentRow.Cells[0].Value.ToString())).ToString();
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void gvBalanceCustomer_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
