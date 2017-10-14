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

namespace WindowsFormsApplication1.Forms
{
    public partial class transactions : MetroFramework.Forms.MetroForm
    {
        public transactions()
        {
            InitializeComponent();
        }

        private void transactions_Load(object sender, EventArgs e)
        {
            // gvTransactions.DataSource = new DAO().GetTransactions(txtPartyName.Text);

            txtPartyName.AutoCompleteMode = AutoCompleteMode.Append;
            txtPartyName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtPartyName.AutoCompleteCustomSource = new DAO().GetPartyNames();

        }

        private void txtPartyName_KeyUp(object sender, KeyEventArgs e)
        {
            SqlDataAdapter dad;
            SqlConnection conn = DBConn.GetInstance();

            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'Contact-Number', PBalance as Balance, POwnerBal as OwnersBalance  from [Party] where PName like '" + txtPartyName.Text + "%'", conn);
            dad.Fill(dtParties);
            foreach (DataRow row in dtParties.Rows)
            {
                lblCompanyBalance.Text = row["OwnersBalance"].ToString();
                lblPartyBalance.Text = row["Balance"].ToString();
            }

            gvTransactions.DataSource = new DAO().GetTransactions(txtPartyName.Text);
            conn.Close();




        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Main frm = new Main();
            frm.Show();
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
