using System;
using System.Collections;
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
    public partial class EditAttend : MetroFramework.Forms.MetroForm
    {
        DataTable gdt;
        public EditAttend(DataTable data)
        {
           
                gdt = data;
                InitializeComponent();

            MaximizeBox = false;
            Movable = false;


        }

        private void EditAttend_Load(object sender, EventArgs e)
        {
            lblEditAtt.Text = "Attendance for Today ! ";
            lblEditAtt.Visible = true;

            try
            {
                gvEditAtt.DataSource = gdt;
                fillcombo();

                //for (int i = 0; i <= gvEditAtt.RowCount - 1; i++)
                //{
                //    gvEditAtt.Rows[i].Cells["combo"].Value = "Present";
                  
                //}
            }
            catch (Exception )
            {
               

            }
           
        }
        public void fillcombo()
        {
            try
            {
               
                DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
                combo.HeaderText = "Edit-Attendance";
                combo.Name = "combo";
                combo.DataSource = new DAO().ComboType();
                combo.DisplayMember = "Attendance";
                combo.ValueMember = "AttTypeID";
               
                gvEditAtt.Columns.Add(combo);
               


            }
            catch (Exception e)
            {
               

            }
           

        }

        private void mtCreate_Click(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList();
            int count = new DAO().TotalEmployees();
            while (count != 0)
            {
                string a = gvEditAtt.Rows[count - 1].Cells[0].Value.ToString();
                string b = gvEditAtt.Rows[count - 1].Cells[2].Value.ToString();
                string empid = new DAO().getEmpByID(b);
                string d;
                try
                {
                    d = gvEditAtt.Rows[count - 1].Cells[4].Value.ToString();

                }
                catch (Exception)
                {

                    d = 4.ToString();
                }
                

                
                try
                {
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Update Attendance SET EmployeeID=@c,AttDate=@b,AttTypeId=@d where AttID = @a", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@a", a);
                    dad.SelectCommand.Parameters.AddWithValue("@b", DateTime.Today.ToShortDateString());
                    dad.SelectCommand.Parameters.AddWithValue("@c", empid);
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
