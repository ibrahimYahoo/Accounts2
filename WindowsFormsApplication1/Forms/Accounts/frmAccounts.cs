using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using WindowsFormsApplication1.Code;
using System.Data.SqlClient;
using System.Collections;
using System.Globalization;
using System.IO;

namespace WindowsFormsApplication1.Forms.Accounts
{
    public partial class frmAccounts : MetroFramework.Forms.MetroForm
    {

        SqlConnection conn = DBConn.GetInstance();
        DataTable dt = new DataTable();
        DataTable dtsal = new DataTable("Salary");
        DateTime globaldt1 = new DateTime();
        DateTime globaldt2 = new DateTime();
        public frmAccounts()
        {
            InitializeComponent();
            this.StyleManager = msmAccounts;
            msmAccounts.Theme = MetroFramework.MetroThemeStyle.Dark;
            msmAccounts.Style = MetroFramework.MetroColorStyle.Teal;
            this.WindowState = FormWindowState.Maximized;
            MaximizeBox = false;
            Movable = false;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private DataTable loadData()
        {
            SqlDataAdapter adpater = new SqlDataAdapter();
            SqlCommand cmd;
            DataSet ds = new DataSet();

            string sql = "Select AttType from AttendType";
            cmd = new SqlCommand(sql, conn);
            adpater.SelectCommand = cmd;
            adpater.Fill(ds);

            dt = ds.Tables[0];
            return dt;
        }


        public void PerformRefresh()
        {
            gvExpense.DataSource = new DAO().GetExpensesforMonth();
            gvExpense.Show();

            dt = new DAO().GetExpensesforMonth();
            decimal total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += decimal.Parse(dt.Rows[i][3].ToString());
            }
            lbltotal.Text = total.ToString();
            lblheadingtotal.Text = "Total Expenses for this month";

            
        }

        private void frmAccounts_Load(object sender, EventArgs e)
        {
            gvExpense.DataSource = new DAO().GetExpensesforMonth();
            gvExpense.Show();

            dt = new DAO().GetExpensesforMonth();
            decimal total = 0;
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                total += decimal.Parse(dt.Rows[i][3].ToString());
            }
            lbltotal.Text = total.ToString();
            lblheadingtotal.Text = "Total Expenses for this month";

            gvEmp.DataSource = new DAO().GetEmp();
            gvEmp.Show();

            // gvPayRoll.DataSource = new DAO().getSalary();

            gvatt.DataSource = new DAO().GetAttendance();

            lblAtt.Visible = true;

            lblHeadingProfit.Text = "Profit calculation for month : " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Today.Month);
            lblHeadingProfit.Visible = true;

            txttotalpurchase.Text = new DAO().getPurchaseTotal(DateTime.Today.Month, DateTime.Today.Year);
            txttotalExpenses.Text = new DAO().getExpensesTotal(DateTime.Today.Month, DateTime.Today.Year);
            txttotalSelling.Text = new DAO().getSellingTotal(DateTime.Today.Month, DateTime.Today.Year);

            if (txttotalSelling.Text == "")
            {
                txttotalSelling.Text = 0.ToString();

            }

            if (txttotalExpenses.Text == "")
            {
                txttotalExpenses.Text = 0.ToString();
            }

            if (txttotalpurchase.Text == "")
            {
                txttotalpurchase.Text = 0.ToString();
            }

            lbltotalinvested.Text = (decimal.Parse(txttotalpurchase.Text) + decimal.Parse(txttotalExpenses.Text)).ToString();
            lbltotalinvested.Visible = true;

            lblProft.Text = (decimal.Parse(txttotalSelling.Text) - decimal.Parse(lbltotalinvested.Text)).ToString();
            decimal a = decimal.Parse(lblProft.Text);

            if (a == 0 || a < 0)
            {
                lblProft.ForeColor = Color.Red;
                lblProft.Visible = true;
            }
            else
            {
                lblProft.ForeColor = Color.GreenYellow;
                lblProft.Visible = true;



            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            AddExpense ae = new AddExpense(this);
            ae.ShowDialog();
        }

        private void mtpExpenses_Click(object sender, EventArgs e)
        {

        }

        private void mtcPayroll_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            gvExpense.DataSource = new DAO().GetExpenses();
            gvExpense.Show();
            dt = new DAO().GetExpensesforMonth();
            decimal total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += decimal.Parse(dt.Rows[i][3].ToString());
            }
            lbltotal.Text = total.ToString();
            lblheadingtotal.Text = "Total Expenses for this month";
            lblexSuccess.Text = "";

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            int eid = 0;
            try
            {
                eid = int.Parse(this.gvExpense.CurrentRow.Cells[0].Value.ToString());
                if (eid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Expenses where ExpId=@CID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", eid);
                        dad.Fill(dt);
                        conn.Close();

                        lblexSuccess.Text = "Record Deleted Successfully!";
                        lblexSuccess.Visible = true;
                        gvExpense.DataSource = new DAO().GetExpenses();
                    }
                }
                else if (eid == 0)
                {
                    MessageBox.Show("Please select record to Delete!", "Error");
                }
                else
                { }

            }
            catch (Exception)
            {


            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            gvExpense.DataSource = new DAO().getExpByDate(dtExpense.Text);
            gvExpense.Show();
            lblexSuccess.Text = "Expenses for : " + dtExpense.Text;
            lblexSuccess.Visible = true;
            dt = new DAO().getExpByDate(dtExpense.Text);
            decimal total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += decimal.Parse(dt.Rows[i][3].ToString());
            }
            lblheadingtotal.Text = "Total Expense for this date";
            lbltotal.Text = total.ToString();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Forms.Accounts.EditExpense ec = new Forms.Accounts.EditExpense(this);
            ec.cmbType.DataSource = new DAO().GetTypeforCMB();
            ec.cmbType.DisplayMember = "Display";
            ec.cmbType.ValueMember = "TypeId";
            ec.expid = int.Parse(this.gvExpense.CurrentRow.Cells[0].Value.ToString());
            ec.txtECost.Text = this.gvExpense.CurrentRow.Cells[3].Value.ToString();
            ec.txtEDesc.Text = this.gvExpense.CurrentRow.Cells[2].Value.ToString();
            //    ec.cmbType.Text = this.gvExpense.CurrentRow.Cells[1].Value.ToString();
            ec.dtEDate.Text = this.gvExpense.CurrentRow.Cells[4].Value.ToString();
            string ex = this.gvExpense.CurrentRow.Cells[1].Value.ToString();
            ec.cmbType.Text = ex;
            ec.cmbType.Show();
            ec.ShowDialog();
        }

        private void mtpEmployees_Click(object sender, EventArgs e)
        {

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            gvEmp.DataSource = new DAO().GetEmp();
            gvEmp.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            AddEmployee ae = new AddEmployee();
            ae.ShowDialog();
        }

        private void mtcPayroll_Selected(object sender, TabControlEventArgs e)
        {

            gvExpense.DataSource = new DAO().GetExpenses();
            gvExpense.Show();

            gvEmp.DataSource = new DAO().GetEmp();
            gvEmp.Show();

        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Forms.Accounts.EditEmployee ee = new Forms.Accounts.EditEmployee();
            ee.empid = int.Parse(this.gvEmp.CurrentRow.Cells[0].Value.ToString());

            ee.txtEName.Text = this.gvEmp.CurrentRow.Cells[1].Value.ToString();
            ee.txtTitle.Text = this.gvEmp.CurrentRow.Cells[2].Value.ToString();
            ee.dtHireDate.Text = this.gvEmp.CurrentRow.Cells[3].Value.ToString();

            ee.txtEAddress.Text = this.gvEmp.CurrentRow.Cells[4].Value.ToString();
            ee.txtEPhone.Text = this.gvEmp.CurrentRow.Cells[5].Value.ToString();
            ee.txtESal.Text = this.gvEmp.CurrentRow.Cells[6].Value.ToString();

            ee.ShowDialog();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            int empid = 0;
            try
            {
                empid = int.Parse(this.gvEmp.CurrentRow.Cells[0].Value.ToString());
                if (empid != 0 && MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (MessageBox.Show("Do you really want to delete it because if you do it, then all the data related with it will also be deleted", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        DataTable dt = new DataTable();
                        SqlConnection conn = DBConn.GetInstance();

                        SqlDataAdapter dad = new SqlDataAdapter("Delete from Employees where EmployeeID=@CID", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@CID", empid);
                        dad.Fill(dt);
                        conn.Close();

                        lblempSucc.Text = "Record Deleted Successfully!";
                        lblempSucc.Visible = true;
                        gvEmp.DataSource = new DAO().GetEmp();
                    }
                }
                else if (empid == 0)
                {
                    lblempSucc.Text = "Please Select a record to delete";
                    lblempSucc.Visible = true;
                }
                else
                { }

            }
            catch (Exception)
            {


            }
        }

        private void btnAttDate_Click(object sender, EventArgs e)
        {

            if (dtAtt.Text == DateTime.Today.ToShortDateString())
            {
                lblAtt.Text = "Today's Attendance";
                mtNewAtt.Enabled = true;
                mtEditAtt.Enabled = true;
            }
            else if (dtAtt.Value > DateTime.Today || dtAtt.Value < DateTime.Today)
            {
                mtNewAtt.Enabled = false;
                mtEditAtt.Enabled = false;
            }
            else
            {
                lblAtt.Text = "Attendance for date : " + dtAtt.Text;
                lblAtt.Visible = true;
            }
            lblErrorCreate.Visible = false;
            gvatt.DataSource = new DAO().getAttByDate(dtAtt.Text);
            gvatt.Show();
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            gvatt.DataSource = new DAO().GetAttendance();
            mtNewAtt.Enabled = true;
            mtEditAtt.Enabled = true;
            lblAtt.Text = "Today's Attendance";
            lblAtt.Visible = true;
            lblErrorCreate.Visible = false;
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {
           
            if(dtAtt.Text == DateTime.Today.ToShortDateString())
            {
                int present = int.Parse(new DAO().getAttDateLike(dtAtt.Text).ToString());
                if (present == 0)
                {
                    DataTable dt = new DataTable();
                    SqlConnection conn = DBConn.GetInstance();

                    SqlDataAdapter dad = new SqlDataAdapter("Select e.EmployeeID as 'EmployeeID', e.EName as 'Name', @date as 'Date' from Employees e ", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@date", DateTime.Today);



                    dad.Fill(dt);
                    conn.Close();

                    AddAttendance ad = new AddAttendance(dt);
                    ad.ShowDialog();
                }
                else
                {
                    lblErrorCreate.Text = "Attendance has already been created for this date!";
                    lblErrorCreate.Visible = true;
                }
            }else
            {
                lblErrorCreate.Text = "Attendance has already been created for this date!";
                lblErrorCreate.Visible = true;
            }
           



        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            int present = int.Parse(new DAO().getAttDateLike(dtAtt.Text).ToString());
            if (present != 0)
            {
                EditAttend ea = new EditAttend(new DAO().GetAttendance());
                ea.ShowDialog();
            }
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            Bonus b = new Bonus();
            b.ShowDialog();
        }

        private void mtpPayroll_Click(object sender, EventArgs e)
        {

        }

        private void metroTile14_Click_1(object sender, EventArgs e)
        {
           
            if(globaldt1 != dtFromPay.Value || globaldt2 != dtTillPay.Value)
            {

                DataTable emp = new DAO().GetEmpName();
                dtsal.Clear();
            DateTime ab = dtTillPay.Value;
            if (dtsal.Columns.Count == 0)
            {
                dtsal.Columns.Add(new DataColumn("Employee Name", typeof(string)));
                dtsal.Columns.Add(new DataColumn("Salary/Day", typeof(int)));
                dtsal.Columns.Add(new DataColumn("Month", typeof(int)));
                dtsal.Columns.Add(new DataColumn("Presents", typeof(int)));
                dtsal.Columns.Add(new DataColumn("Bonus", typeof(int)));
                dtsal.Columns.Add(new DataColumn("Total Salary", typeof(int)));
            }

            globaldt1 = dtFromPay.Value;
            globaldt2 = ab;



            foreach (DataRow row in emp.Rows)
            {
                
                string eid = row["EmployeeID"].ToString();
                string ename = row["Name"].ToString();
                int salary = int.Parse(row["Salary/Day"].ToString());


                int bonus= new DAO().getBonusEmp(int.Parse(eid), dtFromPay.Text, dtTillPay.Text);
               

                int present = new DAO().PresentDayCount(eid, dtFromPay.Text, dtTillPay.Text);
              
                int Total = salary * present;
                Total = Total + bonus;

                    
                DataRow dr = dtsal.NewRow();
                dr["Employee Name"] = ename;
                dr["Salary/Day"] = salary;
                dr["Month"] = ab.Month;
                dr["Presents"] = present;
                dr["Bonus"] = bonus;
                dr["Total Salary"] = Total;

                dtsal.Rows.Add(dr);

                   
             
            }
               
                gvPayRoll.DataSource = dtsal;
              
            lblSuccess.Text = "Salaries for month " + ab.Month;

            }



        }

        private void metroTile13_Click_1(object sender, EventArgs e)
        {
            try
            {

                string success = new DAO().getsaldate(dtFromPay.Text, dtTillPay.Text);

                if (dtFromPay.Value <= dtTillPay.Value && success == "1")
                {
                    SqlConnection conn = DBConn.GetInstance();

                    for (int i = 0; i<dtsal.Rows.Count; i++)
                    {
                        int eid = int.Parse(new DAO().getEmpByID(dtsal.Rows[i]["Employee Name"].ToString()));
                        SqlDataAdapter dad = new SqlDataAdapter("Insert into Salaries(EmployeeID,SalDate,TotalSalary) values(@id, @date,@t)", conn);
                        dad.SelectCommand.Parameters.AddWithValue("@id", eid);
                        dad.SelectCommand.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());
                        dad.SelectCommand.Parameters.AddWithValue("@t", dtsal.Rows[i]["Total Salary"]);



                        dad.Fill(dt);
                    }
              
                    

                  
                    conn.Close();
                    //  new DAO().UpdateSalFromBonus(int.Parse(cmbEmp.SelectedValue.ToString()), int.Parse(txtBonusAmount.Text));
                    lblSuccess.Text = "Salary Saved Successfully";
                    lblSuccess.Visible = true;
                    



                }
                else
                {
                    lblSuccess.Text = "Salary for these dates have been already saved!";
                    lblSuccess.Visible = true;
                }
            }
            catch (Exception ex)
            {
             //   lblSuccess.Text = "Error, Please try Again!";
               // lblSuccess.Visible = true;
               
                MessageBox.Show(ex.Message);
            }

        }

        private void mtpProfit_Click(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Main frm = new Main();
            frm.Show();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().getEmployeesDataset();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Employees.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Employees"].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                       
                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                            {
                                if (dset.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MetroMessageBox.Show(this, v1.PrintExceptionDetails(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().getExpDataset();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Expenses.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Expenses"].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                            {
                                if (dset.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MetroMessageBox.Show(this, v1.PrintExceptionDetails(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().getattDataset();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Attendance.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Attendance"].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                            {
                                if (dset.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MetroMessageBox.Show(this, v1.PrintExceptionDetails(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            try
            {

                DataSet dset = new DAO().GetSalary();
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Salaries.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                savefile.InitialDirectory = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

                if (dset.Tables["Salary"].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {

                        StreamWriter wr = new StreamWriter(savefile.FileName);
                        for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
                            {
                                if (dset.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Data saved in Excel format at location " + savefile.FileName, "Successfully Saved", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // MetroMessageBox.Show(this, v1.PrintExceptionDetails(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            lblHeadingProfit.Text = "Profit calculation for month : " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(dtproft.Value.Month);
            lblHeadingProfit.Visible = true;

            txttotalpurchase.Text = new DAO().getPurchaseTotal(dtproft.Value.Month, dtproft.Value.Year);
            txttotalExpenses.Text = new DAO().getExpensesTotal(dtproft.Value.Month, dtproft.Value.Year);
            txttotalSelling.Text = new DAO().getSellingTotal(dtproft.Value.Month, dtproft.Value.Year);

            if (txttotalSelling.Text == "")
            {
                txttotalSelling.Text = 0.ToString();
                
            }

            if (txttotalExpenses.Text == ""){
                txttotalExpenses.Text = 0.ToString();
            }

            if (txttotalpurchase.Text == "")
            {
                txttotalpurchase.Text = 0.ToString();
            }

            lbltotalinvested.Text = (decimal.Parse(txttotalpurchase.Text) + decimal.Parse(txttotalExpenses.Text)).ToString();
            lbltotalinvested.Visible = true;

            lblProft.Text = (decimal.Parse(txttotalSelling.Text) - decimal.Parse(lbltotalinvested.Text)).ToString();
            decimal a = decimal.Parse(lblProft.Text);

            if (a == 0 || a < 0)
            {
                lblProft.ForeColor = Color.Red;
                lblProft.Visible = true;
            }
            else
            {
                lblProft.ForeColor = Color.GreenYellow;
                lblProft.Visible = true;
            }
        }

        private void gvatt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            gvExpense.DataSource = new DAO().getExpByDate(dtFromExp.Text, dtToExp.Text);
            gvExpense.Show();
            lblexSuccess.Text = "Expenses from " +dtFromExp.Text+ " to "+dtToExp.Text;
            lblexSuccess.Visible = true;
            dt = new DAO().getExpByDate(dtFromExp.Text, dtToExp.Text);
            decimal total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                total += decimal.Parse(dt.Rows[i][3].ToString());
            }
            lblheadingtotal.Text = "Total Expense from " + dtFromExp.Text + " to " + dtToExp.Text;
            lbltotal.Text = total.ToString();
        }
    }
    }

