using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms.Accounts;
using WindowsFormsApplication1.Code;
using System.Data.SqlClient;
using System.Collections;

namespace WindowsFormsApplication1.Forms.Accounts
{
    public partial class AddAttendance : MetroFramework.Forms.MetroForm
    {
        DataTable gdt;
        public AddAttendance(DataTable data)
        {
            gdt = data;
            InitializeComponent();
            MaximizeBox = false;
            Movable = false;
        }
        public void fillcombo()
        {
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Attendance";
            combo.Name = "combo";
            combo.DataSource = new DAO().ComboType();
            combo.DisplayMember = "Attendance";
            combo.ValueMember = "AttTypeID";
            gvCreateAtt.Columns.Add(combo);
          

        }

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            lblcreateAtt.Text = "Attendance for Today ! ";
            lblcreateAtt.Visible = true;

            gvCreateAtt.DataSource = gdt;
            fillcombo();

        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            int count = new DAO().TotalEmployees();
            while(count != 0)
            {
                string a = gvCreateAtt.Rows[count-1].Cells[0].Value.ToString();
                string b = gvCreateAtt.Rows[count-1].Cells[2].Value.ToString();
                string d;
                try
                {
                     d = gvCreateAtt.Rows[count - 1].Cells[3].Value.ToString();

                }
                catch (Exception)
                {
                    d = 4.ToString(); 

                }
               
               
                

                
                try
                {



                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Insert into Attendance(EmployeeID,AttDate,AttTypeId) values(@a,@b,@d)", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@a", a);
                   
                    dad.SelectCommand.Parameters.AddWithValue("@b", b);
                    dad.SelectCommand.Parameters.AddWithValue("@d", d);


                    dad.Fill(dt);
                    conn.Close();


                    count--;
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "Error, Please try Again!", "Stopped!", MessageBoxButtons.OKCancel);
                    //MessageBox.Show(ex.Message);
                }
            }
            lblSuccess.Text = "Attendance Added Successfully!!";
        }

        private void mtBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }
    }
}
