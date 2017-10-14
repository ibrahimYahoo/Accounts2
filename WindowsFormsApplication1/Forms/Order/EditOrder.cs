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

namespace WindowsFormsApplication1.Forms.Order
{
    public partial class EditOrder : MetroFramework.Forms.MetroForm
    {
        int ItemId;
        decimal currentQty;
        int OrderNo;

        frmCart _owner;
        public EditOrder(int itemid, decimal currentqty, int orderno, frmCart form1)
        {

            _owner = form1;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditOrder_FormClosing);
            InitializeComponent();
            ItemId = itemid;
            currentQty = currentqty;
            OrderNo = orderno;
        }

        void getSubtotal()
        {
            decimal qty = nmQty.Value;
            decimal cost = decimal.Parse(lblCost.Text);
            lblSubtotal.Text = (qty * cost).ToString();
        }

        void getRemainingQty()
        {
            decimal val = 0;
            decimal qty = 0;
            if (nmQty.Value > currentQty)
            {
                val = nmQty.Value - currentQty;
                qty = new DAO().getQty(ItemId) - val;
            }
            if(nmQty.Value < currentQty)
            {
                val = currentQty - nmQty.Value;
                qty = new DAO().getQty(ItemId) + val;
            }
            if(nmQty.Value == currentQty)
            {
                val = 0;
                qty = new DAO().getQty(ItemId);
            }
            lblTotalQty.Text = qty.ToString();
        }

        private void nmQty_ValueChanged(object sender, EventArgs e)
        {
            getSubtotal();
            getRemainingQty();
        }


        private void mtSave_Click(object sender, EventArgs e)
        {
            new DAO().UpdateCart(nmQty.Value, decimal.Parse(lblCost.Text), decimal.Parse(lblSubtotal.Text), OrderNo);
            new DAO().RemoveQty(decimal.Parse(lblTotalQty.Text), ItemId);
           lblmsg.Text = "Order Updated Successfully!! Success" ;
            this.Hide();
        }

        private void mtCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EditOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            _owner.PerformRefresh(OrderNo);
        }

        private void EditOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
