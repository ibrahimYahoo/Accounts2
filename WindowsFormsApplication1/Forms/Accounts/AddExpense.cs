using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Code;

namespace WindowsFormsApplication1.Forms.Accounts
{
    public partial class AddExpense : MetroFramework.Forms.MetroForm
    {
        frmAccounts acc = new frmAccounts();
        public AddExpense(frmAccounts ac)
        {
            acc = ac;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddExpense_FormClosing);
            InitializeComponent();
            MaximizeBox = false; Movable = false;
        }

        private void AddExpense_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = new DAO().GetTypeforCMB();
            cmbType.DisplayMember = "Display";
            cmbType.ValueMember = "TypeId";
            cmbType.Show();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            CLEAR_ALL();
        }

        public void CLEAR_ALL()
        {
            txtECost.Text = "" ;
            txtEDesc.Text = "";
            dtEDate.Text = DateTime.Today.ToString();
            cmbType.Text = "";
            lblSuccess.Text = "";
        }

        private void mlType_Click(object sender, EventArgs e)
        {
            
            AddType at = new AddType();
            at.ShowDialog();
           
        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtECost.Text != "" && dtEDate.Text != "" && cmbType.SelectedIndex != -1)
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Expenses(TypeId,ExpDescription,ExpCost,ExpDate) values(@id, @desc,@cost,@date)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@id", cmbType.SelectedValue);
                    dad.SelectCommand.Parameters.AddWithValue("@desc", txtEDesc.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@cost", txtECost.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@date", dtEDate.Text);
                  

                    dad.Fill(dt);
                    conn.Close();
                   
                    CLEAR_ALL();
                    lblSuccess.Text = "Expense Added Successfully!!";
                    lblSuccess.Visible = true;

                }
                else
                {
                    lblSuccess.Text = "Please fill the textboxes!";
                    lblSuccess.Visible = true;
                  
                }
            }
            catch (Exception ex)
            {
                lblSuccess.Text = "Error, Please try Again!";
                lblSuccess.Visible = true;
                
                //MessageBox.Show(ex.Message);
            }
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtECost_Click(object sender, EventArgs e)
        {

        }

        private void txtEDesc_Click(object sender, EventArgs e)
        {

        }

        private void dtEDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddExpense_FormClosing(object sender, FormClosingEventArgs e)
        {
            acc.PerformRefresh();
        }
    }
}
