using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms.Search
{
    public partial class frmSearch : MetroFramework.Forms.MetroForm
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void txtCusID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == 13)
            //{
            //    try
            //    {
            //        if(txtCusID.Text.Equals(""))
            //        {
            //            gvCustomer.DataSource = null;
            //        }
            //        else
            //        {
            //            gvCustomer.DataSource = new DAO().GetCustomers(int.Parse(txtCusID.Text));
            //        }
                    
            //    }
            //    catch (Exception ex)
            //    {
                    
            //    }
                
            //}
        }

        private void txtCusID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtCusID.Text.Equals(""))
                {
                    gvCustomer.DataSource = null;
                }
                else
                {
                    gvCustomer.DataSource = new DAO().GetParties(int.Parse(txtCusID.Text));
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txtCusName_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtCusName.Text.Equals(""))
                {
                    gvCustomer.DataSource = null;
                }
                else
                {
                    gvCustomer.DataSource = new DAO().GetParties(txtCusName.Text);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void txtOrderID_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtOrderID.Text.Equals(""))
                {
                    gvOrders.DataSource = null;
                }
                else
                {
                    gvOrders.DataSource = new DAO().GetOrders(int.Parse(txtOrderID.Text));
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btSearchOrderByDate_Click(object sender, EventArgs e)
        {
            try
            {

              gvOrders.DataSource = new DAO().GetOrdersByDate(dtFromOrder.Text,dtToORder.Text);

            }
            catch (Exception ex)
            {

            }
        }

        //private void txtSupId_KeyUp(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (txtSupId.Text.Equals(""))
        //        {
        //            gvSupplier.DataSource = null;
        //        }
        //        else
        //        {
        //            gvSupplier.DataSource = new DAO().GetSupplier(int.Parse(txtSupId.Text));
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        //private void txtSupName_KeyUp(object sender, KeyEventArgs e)
        //{
        //    try
        //    {
        //        if (txtSupName.Text.Equals(""))
        //        {
        //            gvSupplier.DataSource = null;
        //        }
        //        else
        //        {
        //            gvSupplier.DataSource = new DAO().GetSupplier(txtSupName.Text);
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }
    }
}
