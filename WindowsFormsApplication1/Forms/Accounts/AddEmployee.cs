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
    public partial class AddEmployee : MetroFramework.Forms.MetroForm
    {
        public AddEmployee()
        {
            InitializeComponent();
            MaximizeBox = false;
            Movable = false;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEName.Text != "" && txtEPhone.Text != "" && txtESal.Text != "")
                {


                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Employees(EName,EJobTitle,EHireDate,EAddress,EContact,ESalary) values(@Name,@title,@date,@address,@phone,@sal)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@Name", txtEName.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@title", txtTitle.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@date", dtHireDate.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@address", txtEAddress.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@phone", txtEPhone.Text);
                    dad.SelectCommand.Parameters.AddWithValue("@sal", txtESal.Text);
                    dad.Fill(dt);
                    conn.Close();
                    lblSuccess.Text = "Employee Added Successfully!!";
                    lblSuccess.Visible = true;


                }
                else
                {
                    lblSuccess.Text = "Please fill the textboxes!";
                    lblSuccess.Visible = true;
                
                }
            }
            catch (Exception)
            {
                lblSuccess.Text = "Error, Please try Again!";
                lblSuccess.Visible = true;
            }
        }

        public void CLEAR_ALL()
        {
            txtEAddress.Text = "";
            txtEName.Text = "";
            txtESal.Text = "";
            txtEPhone.Text = "";
            txtTitle.Text = "";
            dtHireDate.Text = DateTime.Today.ToShortDateString().ToString();
            lblSuccess.Visible = false;
        }

        private void mtClear_Click(object sender, EventArgs e)
        {
            CLEAR_ALL();
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }
    }
}
