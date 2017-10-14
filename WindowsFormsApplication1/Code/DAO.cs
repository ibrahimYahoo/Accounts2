using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms.Accounts;
namespace WindowsFormsApplication1.Code
{
    class DAO
    {
        SqlDataAdapter dad;
        SqlConnection conn = DBConn.GetInstance();
        public string getSellingTotal(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("select SUM(TotalCost) as Total from Orders where ODate like '%" + month + "%' AND (DATEPART(yy,PDate)=" + year + "  ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }
        public string getSellingTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(TotalCost) as Total from Orders where ODate like '%" + DateTime.Today.Month + "%' ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }
        public string getExpensesTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(ExpCost) as Total from Expenses where ExpDate like '%" + DateTime.Today.Month + "%' ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

        public DataTable GetExpensesforMonth()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID WHERE e.ExpDate like '%" + DateTime.Today.Month + "%' order by e.ExpId", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public string getExpensesTotal(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("select SUM(ExpCost) as Total from Expenses where ExpDate like '%" + month + "%'  AND (DATEPART(yy,PDate)=" + year + " ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = (0.00).ToString();
                return total;

            }
        }
        public string getPurchaseTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(Total) as Total from Purchase where PDate like '%" + DateTime.Today.Month + "' ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

        public string getPurchaseTotal(int month, int year)
        {
            SqlCommand cmd = new SqlCommand("select SUM(Total) as Total from Purchase where PDate like '%" + month + "%' AND (DATEPART(yy,PDate)=" + year + ") ", conn);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 0.ToString();
                return total;

            }
        }

        public string getsaldate(string d1, string d2)
        {

            SqlCommand cmd = new SqlCommand("select SalDate from Salaries where SalDate BETWEEN @d1 AND @d2 ", conn);
            cmd.Parameters.AddWithValue("@d1", d1);
            cmd.Parameters.AddWithValue("@d2", d2);
            string total;
            try
            {
                total = cmd.ExecuteScalar().ToString();
                return total;
            }
            catch (Exception)
            {
                total = 1.ToString();
                return total;

            }






        }
        //   public void UpdateSalFromAtt()
        //   {

        //       dad = new SqlDataAdapter("select count(a.atttypeid) as 'Days',e.EmployeeID,e.ESalary from Attendance a right outer join Employees e on e.EmployeeID = a.EmployeeID where attdate like '%" + DateTime.Today.Month + "%' and AtttypeId = 1 or AtttypeId = 3 group by e.EName,e.EmployeeID,e.ESalary order by e.EmployeeID;", conn);
        //       DataTable dt = new DataTable();
        //       dad.Fill(dt);

        //       foreach (DataRow row in dt.Rows)
        //       {
        //           int eid = int.Parse(row["EmployeeID"].ToString());

        ////           int bamount = getBonusEmp(eid);

        //           int total = 0;
        //           int days = int.Parse(row["Days"].ToString());
        //           int salaryday = int.Parse(row["ESalary"].ToString());

        //           total = salaryday * days;
        //         //  total = total + bamount;

        //           DataTable dts = new DataTable();


        //           SqlDataAdapter dad = new SqlDataAdapter("Update Salaries SET TotalSalary=@t where EmployeeID = @a", conn);


        //           dad.SelectCommand.Parameters.AddWithValue("@t", total);
        //           dad.SelectCommand.Parameters.AddWithValue("@a", eid);


        //           dad.Fill(dt);
        //           conn.Close();


        //       }

        //   }
        public int GetSalfromEMP(int eid)
        {
            SqlCommand cmd = new SqlCommand("select ISNULL(TotalSalary,0) from Salaries where EmployeeID=@eid AND SalDate like '%" + DateTime.Today.Month + "%'", conn);
            cmd.Parameters.AddWithValue("@eid", eid);
            int total = int.Parse(cmd.ExecuteScalar().ToString());

            return total;
        }



        public void UpdateSalFromBonus(int eid, int bamount)
        {
            try
            {
                if (eid != 0)
                {


                    int total = GetSalfromEMP(eid);

                    total = total + bamount;
                    DataTable dt = new DataTable();


                    SqlDataAdapter dad = new SqlDataAdapter("Update Salaries SET SalDate=@date,TotalSalary=@t where EmployeeID = @a", conn);
                    dad.SelectCommand.Parameters.AddWithValue("@date", DateTime.Today.ToShortDateString());

                    dad.SelectCommand.Parameters.AddWithValue("@t", total);
                    dad.SelectCommand.Parameters.AddWithValue("@a", eid);


                    dad.Fill(dt);
                    conn.Close();

                }
                else
                {
                    MessageBox.Show("Please fill the textboxes!", "ERROR!", MessageBoxButtons.OKCancel);
                }
            }
            catch (Exception ex)
            {
                //   MessageBox.Show( "Error, Please try Again!", "Stopped!", MessageBoxButtons.OKCancel);
                MessageBox.Show(ex.Message);
            }
        }

        public DataTable GetEmpName()
        {
            DataTable dtEmpl = new DataTable();

            dad = new SqlDataAdapter("Select EmployeeID , EName as Name,ESalary as 'Salary/Day'  from [Employees] ", conn);
            dad.Fill(dtEmpl);
            conn.Close();
            return dtEmpl;

        }
        public DataTable PayDetails()
        {
            DataTable dtBonus = new DataTable();

            dad = new SqlDataAdapter("Select e.EName , b.BAmount,b.BDate from Bonus b INNER JOIN Employees e ON b.EmployeeID=e.EmployeeID ORDER BY b.EmployeeId", conn);
            dad.Fill(dtBonus);
            conn.Close();
            return dtBonus;
        }
        public DataTable getItemsFromPurchase(int sid)
        {
            DataTable dtItems = new DataTable();

            dad = new SqlDataAdapter("select p.*,i.IName from Purchase p, Items i where p.IId = i.IId and SId = @sid", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sid", sid);
            dad.Fill(dtItems);
            conn.Close();
            return dtItems;
        }

        public DataTable BonusDetails()
        {
            DataTable dtBonus = new DataTable();

            dad = new SqlDataAdapter("Select b.BId,e.EName , b.BAmount,b.BDate from Bonus b INNER JOIN Employees e ON b.EmployeeID=e.EmployeeID ORDER BY b.EmployeeId", conn);
            dad.Fill(dtBonus);
            conn.Close();
            return dtBonus;
        }
        public DataTable GetEmpForCMB()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select EmployeeID,EName as 'Display'  from [Employees] ", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public void InsertSupplierPayment(string spdate, int sid, decimal cbalance, decimal cpamount)
        {
            SqlCommand cmd = new SqlCommand("Insert into SupplierPayment (SpDate,SId,SBalance,SpAmount) values (@cpdate,@cid,@cbalance,@cpamount)", conn);
            cmd.Parameters.AddWithValue("@cpdate", spdate);
            cmd.Parameters.AddWithValue("@cid", sid);
            cmd.Parameters.AddWithValue("@cbalance", cbalance);
            cmd.Parameters.AddWithValue("@cpamount", cpamount);
            cmd.ExecuteNonQuery();
        }
        public int TotalEmployees()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(EmployeeID) from [Employees]", conn);

            dad.Fill(dtProduct);

            int totalEmp = (Convert.ToInt32(dtProduct.Rows[0][0]));

            conn.Close();

            return totalEmp;
        }

        public DataTable GetOrderDetails(int OrderNo)
        {
            DataTable dt = new DataTable();
            dad = new SqlDataAdapter("select Top 1 o.OrderNo,o.ODate,o.CId from orders o where o.OrderNo = @orderno order by OrderNo desc;", conn);
            dad.SelectCommand.Parameters.AddWithValue("@orderno", OrderNo);
            dad.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable ComboType()
        {
            DataTable dtType = new DataTable();

            dad = new SqlDataAdapter("Select AttTypeID, AttType as 'Attendance' from [AttendType]", conn);
            dad.Fill(dtType);
            conn.Close();
            return dtType;
        }

        public DataTable CreateAttendanceGV()
        {
            DataTable dtAttend = new DataTable();
            string date = DateTime.Today.ToShortDateString();
            dad = new SqlDataAdapter("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID WHERE a.AttDate =@date order by a.EmployeeID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtAttend);


            conn.Close();

            return dtAttend;

        }

        public string getEmpByID(string b)
        {
            SqlCommand cmd = new SqlCommand("Select EmployeeID from Employees WHERE EName = '" + b + "' ", conn);
            string name = cmd.ExecuteScalar().ToString();
            return name;
        }

        public DataTable GetAttendance()
        {
            DataTable dtAttend = new DataTable();
            string date = DateTime.Today.ToShortDateString();
            dad = new SqlDataAdapter("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId WHERE a.AttDate =@date order by a.EmployeeID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtAttend);


            conn.Close();

            return dtAttend;

        }

        internal object getAttDateLike(string date)
        {
            SqlCommand cmd = new SqlCommand("Select count(AttID) as 'Attendance-ID' from Attendance WHERE AttDate = '" + date + "' ", conn);
            int present = int.Parse(cmd.ExecuteScalar().ToString());
            return present;

        }

        internal object getAttByDate(string date)
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId   WHERE a.AttDate = @date order by e.EmployeeID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public DataTable GetCustomers()
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'ContactNumber', CBalance as Balance  from [Customer]", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }


        public DataTable GetParties()
        {
            DataTable dtparties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'ContactNumber', PBalance as Balance, POwnerBal as OwnersBalance  from [Party]", conn);
            dad.Fill(dtparties);
            conn.Close();
            return dtparties;

        }
        public AutoCompleteStringCollection GetPartyNames()
        {
            //DataTable dtparties = new DataTable();


            //dad = new SqlDataAdapter("Select  [PName] as Name FROM [Party]", conn);


            //dad.Fill(dtparties);
            //conn.Close();
            //return dtparties;
            //conn.Open();
            AutoCompleteStringCollection namesCollection = new AutoCompleteStringCollection();
            string querry = @"Select  [PName] from [Party]";
            SqlCommand cmd = new SqlCommand(querry, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    namesCollection.Add(dr["PName"].ToString());

            }

            dr.Close();
            conn.Close();

            return namesCollection;




        }



        public DataTable GetCustomers(int cusid)
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'Contact-Number', CBalance as Balance  from [Customer] where CId = @cid", conn);
            dad.SelectCommand.Parameters.AddWithValue("@cid", cusid);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }


        public DataTable GetParties(int PId)
        {
            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'Contact-Number', PBalance as Balance, POwnerBal as OwnersBalance  from [Party] where PId = @PId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PId", PId);
            dad.Fill(dtParties);
            conn.Close();
            return dtParties;

        }

        public DataTable GetParties(string name)
        {
            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select PId as 'Party-ID', PName as Name, PAddress as Address, PEmail as Email, PContact as 'Contact-Number', PBalance as Balance, POwnerBal as OwnersBalance  from [Party] where PName like '" + name + "%'", conn);
            dad.Fill(dtParties);
            conn.Close();
            return dtParties;

        }
        public decimal GetPartyBalance(int PId)
        {
            DataTable dtParties = new DataTable();
            decimal balance=0;
            dad = new SqlDataAdapter("Select PBalance from [Party] where PId = @PId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@PId", PId);
            dad.Fill(dtParties);
            
            conn.Close();
            
              balance  = decimal.Parse(dtParties.Rows[0]["PBalance"].ToString());
            


            return balance;

        }



        public DataTable GetCustomers(string name)
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'Contact-Number', CBalance as Balance  from [Customer] where CName like '" + name + "%'", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }

        public DataTable GetCustomersBalance()
        {
            DataTable dtCustomers = new DataTable();
            dad = new SqlDataAdapter("select o.CId as 'Customer-ID',c.CName as 'Name', o.ODate as 'Date',i.IName as 'Item-Name',o.Qty as Qty,o.Cost as Cost,o.TotalCost as TotalCost from Orders o,Customer c,Items i where o.CId = c.CId and o.IId = i.IId order by ODate desc;", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }

        public DataTable GetCustomersBalance(string name, string from, string to)
        {
            DataTable dtCustomers = new DataTable();
            dad = new SqlDataAdapter("select o.CId as 'Customer-ID',c.CName 'Name', o.ODate as 'Date',i.IName as 'Item-Name',o.Qty as Qty,o.Cost as Cost,o.TotalCost as TotalCost from Orders o,Customer c,Items i where o.CId = c.CId and o.IId = i.IId and c.cName like '" + name + "%' and o.ODate between '" + from + "' and '" + to + "';", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }

        public DataTable GetCustomersBalance(string name)
        {
            DataTable dtCustomers = new DataTable();

            dad = new SqlDataAdapter("select o.CId as 'Customer-ID',c.CName as 'Name', o.ODate as 'Date',i.IName as 'Item-Name',o.Qty as Qty,o.Cost as Cost,o.TotalCost as TotalCost from Orders o,Customer c,Items i where o.CId = c.CId and o.IId = i.IId and c.cName like '" + name + "%'", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;
        }
        public decimal NetTotal(int cid)
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o where o.CId = @cid", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            decimal nettotal = decimal.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public decimal NetTotal(int cid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o where o.CId = @cid and o.ODate between '" + from + "' and '" + to + "' ", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            decimal nettotal = decimal.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public decimal NetTotal(string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o where o.ODate between '" + from + "' and '" + to + "' ", conn);
            decimal nettotal = decimal.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public decimal NetTotal()
        {
            SqlCommand cmd = new SqlCommand("select SUM(o.TotalCost) as NetTotal from Orders o", conn);
            decimal nettotal = decimal.Parse(cmd.ExecuteScalar().ToString());
            return nettotal;
        }

        public decimal PaidAmount(int cid)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment where CId = @cid;", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            decimal paidamount = decimal.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }

        public decimal PaidAmount(int cid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment where CId = @cid and CpDate between '" + from + "' and '" + to + "'", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            decimal paidamount = decimal.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }
        public decimal PaidAmount(string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment where CpDate between '" + from + "' and '" + to + "'", conn);
            decimal paidamount = decimal.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }
        public decimal PaidAmount()
        {
            SqlCommand cmd = new SqlCommand("select SUM(CpAmount-CBalance) as PaidAmount from CustomerPayment;", conn);
            decimal paidamount = decimal.Parse(cmd.ExecuteScalar().ToString());
            return paidamount;
        }

        public decimal Balance(int cid)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CBalance) from Customer where CId = @cid;", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            decimal balance = decimal.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }

        public decimal Balance(int cid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select SUM(CBalance) from CustomerPayment where CId = @cid;", conn);
            cmd.Parameters.AddWithValue("@cid", cid);
            decimal balance = decimal.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }
        public decimal Balance()
        {
            SqlCommand cmd = new SqlCommand("select SUM(CBalance) from Customer;", conn);
            decimal balance = decimal.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }

        public DataTable GetEmp()
        {
            DataTable dtEmpl = new DataTable();

            dad = new SqlDataAdapter("Select EmployeeID as 'Employee-ID', EName as Name, EJobTitle as Title, EHireDate as 'Date of Hire', EAddress as 'Address', EContact as Contact, ESalary as 'Salary/Day'  from [Employees] ", conn);
            dad.Fill(dtEmpl);
            conn.Close();
            return dtEmpl;

        }

        public DataTable GetSupplier()
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] ", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplier(int sid)
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] where SId = @sid ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sid", sid);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplier(string sname)
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] where SName like '" + sname + "%' ", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplierBalanceSheet()
        {
            DataTable dtSupplier = new DataTable();

            dad = new SqlDataAdapter("select sp.SId as 'Supplier-ID',s.SName as 'Name', sp.SpDate as 'Payment Date', sp.SpAmount as 'Total Amount',(sp.SpAmount - sp.SBalance) as Paid,sp.SBalance as 'Balance' from SupplierPayment sp, Supplier s where sp.SId = s.SId order by SpId desc;", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }


        public decimal getSupplierBalance()
        {
            SqlCommand cmd = new SqlCommand("Select SUM(SBalance) from supplier", conn);
            decimal balance = decimal.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }

        public decimal getSupplierBalance(int sid)
        {
            SqlCommand cmd = new SqlCommand("Select SBalance from supplier where sid = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", sid);
            decimal balance = decimal.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }



        public decimal getSupplierBalance(int sid, string from, string to)
        {
            SqlCommand cmd = new SqlCommand("select top 1 SBalance from SupplierPayment where SpDate between '" + from + "' and '" + to + "' and SId = @sid order by SpId desc;", conn);
            cmd.Parameters.AddWithValue("@sid", sid);
            decimal balance = decimal.Parse(cmd.ExecuteScalar().ToString());
            return balance;
        }


        public DataTable GetSupplierBalanceSheet(string name)
        {
            DataTable dtSupplier = new DataTable();
            dad = new SqlDataAdapter("select sp.SId as 'Supplier-ID',s.SName as 'Name', sp.SpDate as 'Payment Date', sp.SpAmount as 'Total Amount',(sp.SpAmount - sp.SBalance) as Paid,sp.SBalance as 'Balance' from SupplierPayment sp, Supplier s where sp.SId = s.SId and s.SName like '" + name + "%' order by SpId desc;", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }

        public DataTable GetSupplierBalanceSheet(string name, string from, string to)
        {
            DataTable dtSupplier = new DataTable();
            dad = new SqlDataAdapter("select sp.SId as 'Supplier-ID',s.SName as 'Name', sp.SpDate as 'Payment Date', sp.SpAmount as 'Total Amount',(sp.SpAmount - sp.SBalance) as Paid,sp.SBalance as 'Balance' from SupplierPayment sp, Supplier s where sp.SId = s.SId and s.SName like '" + name + "%' and sp.SpDate between '" + from + "' and '" + to + "' order by SpId desc;", conn);
            dad.Fill(dtSupplier);
            conn.Close();
            return dtSupplier;

        }


        public DataTable GetTypes()
        {
            DataTable dtType = new DataTable();

            dad = new SqlDataAdapter("Select TypeId as 'Type-ID', Type  from [Type] ", conn);
            dad.Fill(dtType);
            conn.Close();
            return dtType;

        }


        public DataTable GetTypeforCMB()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select TypeId,Type as 'Display'  from [Type] ", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public DataTable GetExpenses()
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID order by e.ExpId", conn);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        public DataTable getExpByDate(string date)
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID  WHERE e.ExpDate = @date order by e.ExpId", conn);
            dad.SelectCommand.Parameters.AddWithValue("@date", date);
            dad.Fill(dtype);
            conn.Close();

            return dtype;
        }

        internal DataTable getExpByDate(string text1, string text2)
        {
            DataTable dtype = new DataTable();
            dad = new SqlDataAdapter("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID  WHERE e.ExpDate Between '" + text1 + "' AND '" + text2 + "'", conn);

            dad.Fill(dtype);
            conn.Close();

            return dtype;

        }

        public DataTable getItems()
        {
            DataTable dtItems = new DataTable();

            dad = new SqlDataAdapter("Select IId,IName as 'Item Name',CatId as 'Category-ID', IPrice as 'Selling Price',IQty as 'Qty', IReorder as 'Reorder' from Items", conn);
            dad.Fill(dtItems);
            conn.Close();
            return dtItems;
        }

        public int getMaxOrderOderNo()
        {
            SqlCommand cmd = new SqlCommand("select ISNULL(max(OrderNo),0) from Orders", conn);
            int orderno = int.Parse(cmd.ExecuteScalar().ToString());
            return orderno;
        }

        public decimal getCost(int itemid)
        {
            SqlCommand cmd = new SqlCommand("select IPrice from Items where IId = @itemid", conn);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            decimal cost = decimal.Parse(cmd.ExecuteScalar().ToString());
            return cost;
        }

        public decimal getTotal(int orderno)
        {
            SqlCommand cmd = new SqlCommand("select ISNULL(sum(TotalCost),0) from Orders where OrderNo = @orderno;", conn);
            cmd.Parameters.AddWithValue("@orderno", orderno);
            decimal total = decimal.Parse(cmd.ExecuteScalar().ToString());
            return total;
        }

        public void RemoveQty(decimal iqty, int itemid)
        {
            SqlCommand cmd = new SqlCommand("Update Items set IQty = @nqty where IId = @itemid", conn);
            cmd.Parameters.AddWithValue("@nqty", iqty);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            cmd.ExecuteNonQuery();
        }

        public decimal getQty(int itemid)
        {
            SqlCommand cmd = new SqlCommand("select IQty from Items where IId = @itemid;", conn);
            cmd.Parameters.AddWithValue("@itemid", itemid);
            decimal qty = decimal.Parse(cmd.ExecuteScalar().ToString());
            return qty;
        }

        public DataTable Get_Cart(int orderno)
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select o.OrderId as 'ID',o.OrderNo as 'OrderNo',o.ODate as 'Date', o.PId as 'PartyID', o.IId as ItemID, i.IName as ItemName,o.Qty,o.Cost,o.TotalCost from orders o join items i on i.IId = o.IId where OrderNo = @orderno", conn);
            dad.SelectCommand.Parameters.AddWithValue("@orderno", orderno);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }

        public DataTable GetOrders(int orderno)
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select o.OrderNo as OrderNo,o.ODate as Date, o.PId as 'Party-ID',p.PName as 'Name', o.IId as 'Item-ID', i.IName as 'Item Name',o.Qty,o.Cost,o.TotalCost from orders o,Party p,Items i where OrderNo = @orderno and o.PId = p.PId and o.IId = i.IId;", conn);
            dad.SelectCommand.Parameters.AddWithValue("@orderno", orderno);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }
        public DataTable GetOrdersByDate(string from, string to)
        {
            DataTable dtOrders = new DataTable();

            dad = new SqlDataAdapter("select o.OrderNo as OrderNo,o.ODate as Date, o.PId as 'Party-ID',p.PName as 'Name', o.IId as 'Item-ID', i.IName as 'Item Name',o.Qty,o.Cost,o.TotalCost from orders o,Party p,Items i where o.ODate between '" + from + "' and '" + to + "' and o.PId = p.PId and o.IId = i.IId;", conn);
            dad.Fill(dtOrders);
            conn.Close();
            return dtOrders;
        }
        public void UpdateCart(decimal qty, decimal cost, decimal totalcost, int orderno)
        {
            SqlCommand cmd = new SqlCommand("Update Orders set qty = @qty, cost = @cost, totalcost = @totalcost where orderno = @orderno", conn);
            cmd.Parameters.AddWithValue("@qty", qty);
            cmd.Parameters.AddWithValue("@cost", cost);
            cmd.Parameters.AddWithValue("@totalcost", totalcost);
            cmd.Parameters.AddWithValue("@orderno", orderno);
            cmd.ExecuteNonQuery();
        }

        public void RemoveOrder(int orderid)
        {
            SqlCommand cmd = new SqlCommand("delete from Orders where orderid = @orderid", conn);
            cmd.Parameters.AddWithValue("@orderid", orderid);
            cmd.ExecuteNonQuery();
        }

        public void AddCustomerPayment(string cpdate, int cid,decimal cbalance, decimal cpamount)
        {
            SqlCommand cmd = new SqlCommand("Insert into CustomerPayment (CpDate,CId,CBalance,CpAmount) values (@cpdate,@cid,@cbalance,@cpamount)", conn);
            cmd.Parameters.AddWithValue("@cpdate", cpdate);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.Parameters.AddWithValue("@cbalance", cbalance);
            cmd.Parameters.AddWithValue("@cpamount", cpamount);
            cmd.ExecuteNonQuery();
        }

        public void AddOrderTransaction(int PId, decimal debit, decimal credit ,int IId,int itemQuantity,string description,DateTime date ,int itemBought, decimal balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Ledger (PId,Debit,Credit,IId,itemQuantity,date,itemBought,Balance) values (@PId,@debit,@credit,@IId,@itemQuantity,@date,@itemBought,@balance)", conn);
                cmd.Parameters.AddWithValue("@PId", PId);
                cmd.Parameters.AddWithValue("@debit", debit);
                cmd.Parameters.AddWithValue("@credit", credit);
                cmd.Parameters.AddWithValue("@IId", IId);
                cmd.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@itemBought", itemBought);
                cmd.Parameters.AddWithValue("@balance", balance);
            
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                int i = 0;
            }
        }

        public void AddPurchaseTransaction(int PId, decimal debit, decimal credit, int IId, int itemQuantity, string description, DateTime date, int itemBought, decimal balance)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Ledger (PId,Debit,Credit,IId,itemQuantity,date,itemBought,Balance) values (@PId,@debit,@credit,@IId,@itemQuantity,@date,@itemBought,@balance)", conn);
                cmd.Parameters.AddWithValue("@PId", PId);
                cmd.Parameters.AddWithValue("@debit", debit);
                cmd.Parameters.AddWithValue("@credit", credit);
                cmd.Parameters.AddWithValue("@IId", IId);
                cmd.Parameters.AddWithValue("@itemQuantity", itemQuantity);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@itemBought", itemBought);
                cmd.Parameters.AddWithValue("@balance", balance);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                int i = 0;
            }
        }

        internal int PresentDayCount(string eid, string dt, string dt1)
        {

            SqlCommand cmd = new SqlCommand("select count(AttTypeId) from Attendance where EmployeeID=@emp AND (AttDate BETWEEN @date1 AND @date) AND AttTypeId = 1 OR AttTypeId =3", conn);
            cmd.Parameters.AddWithValue("@emp", eid);
            cmd.Parameters.AddWithValue("@date1", dt);
            cmd.Parameters.AddWithValue("@date", dt1);
            int total = int.Parse(cmd.ExecuteScalar().ToString());
            return total;
        }

        internal int getBonusEmp(int eid, string dt1, string dt2)
        {

            DataTable dtPay = new DataTable();



            dad = new SqlDataAdapter("select SUM(BAmount) from Bonus where EmployeeID=@eid AND BDate Between @dt1 AND @dt2", conn);
            dad.SelectCommand.Parameters.AddWithValue("@eid", eid);
            dad.SelectCommand.Parameters.AddWithValue("@dt1", dt1);
            dad.SelectCommand.Parameters.AddWithValue("@dt2", dt2);
            dad.Fill(dtPay);
            conn.Close();

            int bonus = 0;
            try
            {
                bonus = int.Parse(dtPay.Rows[0][0].ToString());
            }
            catch (Exception)
            {

                bonus = 0;
            }



            return bonus;

        }

        //internal object getSalary()
        //{
        //   // UpdateSalFromAtt();
        //    DataTable dtPay = new DataTable();
        //    conn = DBConn.GetInstance();


        //    dad = new SqlDataAdapter("select e.EName as 'Name', e.ESalary as 'Salary/Day', ISNULL(SUM(b.BAmount),0) as 'Bonus', s.SalDate as 'Salary-Date', s.TotalSalary as 'TotalSalary' from Employees e left outer join Bonus b ON b.EmployeeID = e.EmployeeID  left outer join Salaries s ON s.EmployeeID= e.EmployeeID WHERE s.SalDate  like '%' GROUP BY e.EmployeeID,e.EName, e.ESalary,s.SalDate,s.TotalSalary ORDER  BY e.EmployeeID;", conn);
        //  //  dad.SelectCommand.Parameters.AddWithValue("@date", DateTime.Today.Month);
        //    dad.Fill(dtPay);


        //    dad = new SqlDataAdapter("select count(ISNULL(a.atttypeid,0)) as 'Days',e.eName from Attendance a right outer join Employees e on e.EmployeeID = a.EmployeeID where attdate like '%"+DateTime.Today.Month+"%' and AtttypeId = 1 or AtttypeId = 3 group by e.EName,e.EmployeeID order by e.EmployeeID;", conn);
        //    DataTable dt = new DataTable();
        //    dad.Fill(dt);

        //    dtPay.Columns.Add("WorkingDays");

        //    try
        //    {

        //        for (int i = 0; i < dtPay.Rows.Count; i++)
        //        {

        //            dtPay.Rows[i]["WorkingDays"] = dt.Rows[i]["Days"];


        //        }

        //    }
        //    catch (IndexOutOfRangeException e)
        //    {


        //    }

        //    conn.Close();
        //    return dtPay;
        //}

        public DataTable GetCustomersss()
        {
            DataTable dtCustomers = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CId , CName  as'Display' from [Customer] ", conn);
            dad.Fill(dtCustomers);
            conn.Close();
            return dtCustomers;

        }

        public void UpdateCustomerBalance(int cid, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("Update Customer set CBalance = CBalance + @balance where CId = @cid", conn);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@cid", cid);
            cmd.ExecuteNonQuery();
        }

        public void UpdatePartyBalance(int pid, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("Update Party set PBalance = PBalance + @balance where PId = @pid", conn);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.ExecuteNonQuery();
        }


        public void UpdateOwnerBalance(int pid, decimal balance)
        {
            SqlCommand cmd = new SqlCommand("Update Party set POwnerBal = POwnerBal + @balance where PId = @pid", conn);
            cmd.Parameters.AddWithValue("@balance", balance);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.ExecuteNonQuery();
        }


        public DataTable ShowCatList1()
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();

            SqlDataAdapter dad = new SqlDataAdapter("Select CatId, CatDesc as'Display' from Category ", conn);

            dad.Fill(dt);
            conn.Close();
            return dt;
        }
        public int GetCatIdfromDesc(string desc)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CatId  from Category where CatDesc = '" + desc + "'", conn);
            dad.Fill(dtProduct);
            int catid = (Convert.ToInt32(dtProduct.Rows[0][0]));
            conn.Close();
            return catid;
        }

        public string GetCatDescfromCatId(int catid)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select catdesc from Category where catid = " + catid + "", conn);
            dad.Fill(dtProduct);
            string catdesc = dtProduct.Rows[0][0].ToString();
            conn.Close();
            return catdesc;
        }
        public int GetCatId()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(CatId) from [Category] ", conn);

            dad.Fill(dtProduct);

            int orderId = (Convert.ToInt32(dtProduct.Rows[0][0]) + 1);

            conn.Close();

            return orderId;
        }

        public DataTable GetItems()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Items] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public DataTable GetCategory()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Category] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public int getItemIdFromName(string itemname)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select IID  from Items where IName = '" + itemname + "'", conn);
            dad.Fill(dtProduct);
            int itemid = (Convert.ToInt32(dtProduct.Rows[0][0]));
            conn.Close();
            return itemid;
        }
        public DataTable GetSuppliers()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Supplier] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public int getSupplierIdFromName(string sName)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select SId  from Supplier where SName = @sname", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sname", sName);
            dad.Fill(dtProduct);
            int SId = (Convert.ToInt32(dtProduct.Rows[0][0]));
            conn.Close();
            return SId;
        }
        public DataTable getusers()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Login] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public void SubSuppBalance(int Sid, decimal total)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("update Supplier set SBalance=SBalance-@total from [Supplier] where SId = @sid", conn);
            dad.SelectCommand.Parameters.AddWithValue("@sid", Sid);
            dad.SelectCommand.Parameters.AddWithValue("@total", total);


            dad.Fill(dtProduct);



            conn.Close();
        }

        public DataTable GetInvestors()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select *  from [Customer] ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }

        public int GetSuppBalance(int id)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select SBalance from [Supplier] WHERE SId = '" + id + "' ", conn);

            dad.Fill(dtProduct);

            int orderId = (Convert.ToInt32(dtProduct.Rows[0][0]));

            conn.Close();

            return orderId;
        }

        public void SubInvestorBalance(int CId, int total)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("update Customer set CBalance=CBalance-@Qty from [Customer] where CId = '" + CId + "' ", conn);
            dad.SelectCommand.Parameters.AddWithValue("@Qty", total);


            dad.Fill(dtProduct);



            conn.Close();
        }

        public DataTable GetSupp()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select SId,SName as'Display' FROM [Supplier] order by  SId", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;
        }

        public DataTable GetParticularCustomer()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CId, (CName) as'Display' FROM [Customer] where CName not in (select cname from Customer where cname like 'Walk In') order by  CId ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }



        public int GetCustomerBalance(int CId)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select CBalance from [Customer] WHERE CId = '" + CId + "' ", conn);

            dad.Fill(dtProduct);

            int orderId = (Convert.ToInt32(dtProduct.Rows[0][0]));

            conn.Close();

            return orderId;
        }

        public int GetCustomerId()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(CId) from [Customer] ", conn);

            dad.Fill(dtProduct);

            int CId = (Convert.ToInt32(dtProduct.Rows[0][0]) + 1);

            conn.Close();

            return CId;
        }
        public DataTable GetPurchases()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter(" SELECT Purchase.PurId, Purchase.PurDate as 'Purchase Date', Items.IName as 'Item Name',Party.PName as 'Party Name', Purchase.IPrice as 'Selling Price',Purchase.PurPrice as 'Purchase Price', Purchase.ItemQty, Purchase.Total FROM Purchase INNER JOIN Items ON Items.IId = Purchase.IId INNER JOIN Party ON Purchase.PId = Party.PId", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;
        }


        public DataTable GetTransactions(string name)
        {

            //DataTable dtLedger = new DataTable();
            //conn = DBConn.GetInstance();

            //dad = new SqlDataAdapter("select o.OrderNo as OrderNo,o.ODate as Date, o.PId as 'Party-ID',p.PName as 'Name', o.IId as 'Item-ID', i.IName as 'Item Name',o.Qty,o.Cost,o.TotalCost from orders o,Party p,Items i where OrderNo = @orderno and o.PId = p.PId and o.IId = i.IId;", conn);

            //dad = new SqlDataAdapter(" SELECT ledger.PId, ledger.Debit as 'Debit',ledger.Credit as 'Credit',  Ledger.IId.IName as 'ItemName', ledger.Balance from ledger where ledger.PId.PName like '" + name + "%'", conn);
            //dad.Fill(dtLedger);
            //conn.Close();
            //return dtLedger;


            DataTable dtParties = new DataTable();

            dad = new SqlDataAdapter("Select l.TransId, p.PName as Name, p.PEmail as Email, l.Debit,l.Credit,i.IId,i.IName as 'ItemName', l.Balance from  ledger l,Party p,Items i where l.PId = p.PId and l.IId = i.IId and PName like '" + name + "%'", conn);
            dad.Fill(dtParties);
            conn.Close();
            return dtParties;



        }

        public DataTable GetItemsDesc()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();
            dad = new SqlDataAdapter("Select i.IId,c.CatDesc,i.IName,(c.CatDesc+' : '+i.IName) as'Display' FROM [Category] c INNER JOIN [Items] i ON i.CatId=c.CatId order by c.CatDesc, i.IName", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public DataTable ShowItemsByID(float IID)
        {
            DataTable dt = new DataTable();
            conn = DBConn.GetInstance();
            SqlDataAdapter dad = new SqlDataAdapter("Select * from Items where IId=@IID", conn);
            dad.SelectCommand.Parameters.AddWithValue("@IId", IID);
            dad.Fill(dt);
            conn.Close();
            return dt;
        }
        public DataTable GetParticularItem(string IName)
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();

            dad = new SqlDataAdapter("Select i.IId,c.CatDesc,i.IName,(c.CatDesc+' : '+i.IName) as'Display' FROM [Category] c INNER JOIN [Items] i ON c.CatId=i.CatId  WHERE IName = '" + IName + "' ", conn);
            dad.Fill(dtProduct);
            conn.Close();
            return dtProduct;

        }
        public int GetPurchaseId()
        {
            DataTable dtProduct = new DataTable();
            conn = DBConn.GetInstance();


            dad = new SqlDataAdapter("Select count(PId) from [Purchase] ", conn);

            dad.Fill(dtProduct);

            int pid = (Convert.ToInt32(dtProduct.Rows[0][0]) + 1);

            conn.Close();

            return pid;
        }
        public void UpdateQtyAdd(int IId, float qty)
        {
            SqlCommand cmd = new SqlCommand("update Items set IQty=IQty+@Qty from [Items] where IId = @iid", conn);
            cmd.Parameters.AddWithValue("@iid", IId);
            cmd.Parameters.AddWithValue("@Qty", qty);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteQty(int IId, float qty)
        {
            SqlCommand cmd = new SqlCommand("update Items set IQty=IQty-@Qty from [Items] where IId = @iid", conn);
            cmd.Parameters.AddWithValue("@iid", IId);
            cmd.Parameters.AddWithValue("@Qty", qty);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void AddSuppBalance(int SId, decimal total)
        {
            SqlCommand cmd = new SqlCommand("update Supplier set SBalance=SBalance+@bal from [Supplier] where SId = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", SId);
            cmd.Parameters.AddWithValue("@bal", total);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DelSuppBalance(int SId, decimal total)
        {
            SqlCommand cmd = new SqlCommand("update Supplier set SBalance=SBalance-@bal from [Supplier] where SId = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", SId);
            cmd.Parameters.AddWithValue("@bal", total);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataSet getatt()
        {
            SqlCommand command = new SqlCommand("Select a.AttID as 'Attendance-ID',a.AttDate as 'DATE',e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID=e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId   WHERE a.AttDate like '%2017%' order by a.AttId", conn);
            command.Parameters.AddWithValue("@date", DateTime.Today.Year);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "bb");

            conn.Close();
            return ds;
        }

        public DataSet GetCust()
        {
            SqlCommand command = new SqlCommand("Select CId as 'Customer-ID', CName as Name, CAddress as Address, CEmail as Email, CContact as 'Contact-Number', CBalance as Balance  from [Customer]", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Customers");

            conn.Close();
            return ds;
        }

        public DataSet GetSuppDataset()
        {
            SqlCommand command = new SqlCommand("Select SId as 'Supplier-ID', SName as Name, SAddress as Address, SContact as 'Contact-Number', SBalance as Balance  from [Supplier] ", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Suppliers");

            conn.Close();
            return ds;
        }

        public DataSet GetStock()
        {
            SqlCommand command = new SqlCommand("SELECT i.IId as 'Item-ID', c.CatDesc as 'Category', i.IName as 'Name', i.IPrice as 'Price' ,i.IQty as 'Quantity' FROM Items i INNER JOIN Category c ON i.CatId = c.CatId;", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Stock");

            conn.Close();
            return ds;
        }
        public DataSet getEmployeesDataset()
        {
            SqlCommand command = new SqlCommand("Select EmployeeID as 'Employee-ID', EName as Name, EJobTitle as Title, EHireDate as 'Date of Hire', EAddress as 'Address', EContact as Contact, ESalary as 'Salary/Day'  from[Employees]", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            conn.Close();
            return ds;
        }

        public DataSet getExpDataset()
        {
            SqlCommand command = new SqlCommand("Select e.ExpId as 'Expense-ID',t.Type as Type,e.ExpDescription as Description, e.ExpCost as Cost, e.ExpDate as Date FROM [Expenses] e INNER JOIN [Type] t ON e.TypeId=t.TypeID order by e.ExpId", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Expenses");

            conn.Close();
            return ds;
        }
        public DataSet getattDataset()
        {
            SqlCommand command = new SqlCommand(" Select a.AttID as 'Attendance-ID', a.AttDate as 'DATE', e.EName as 'Employee-Name', b.AttType as 'Attendance' FROM Attendance a INNER JOIN Employees e ON a.EmployeeID= e.EmployeeID INNER JOIN AttendType b ON a.AttTypeId = b.AttTypeId   WHERE a.AttDate like '%" + DateTime.Today.Year + "%' order by a.AttId", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Attendance");

            conn.Close();
            return ds;
        }


        public DataSet GetSalary()
        {
            SqlCommand command = new SqlCommand("select e.EName as 'Name', e.ESalary as 'Salary/Day', ISNULL(SUM(b.BAmount),0) as 'Bonus',b.BDate as 'Bonus-Date', s.SalDate as 'Salary-Date', s.TotalSalary as 'TotalSalary' from Employees e left outer join Bonus b ON b.EmployeeID = e.EmployeeID  left outer join Salaries s ON s.EmployeeID= e.EmployeeID WHERE s.SalDate  like '%" + DateTime.Today.Year + "%' GROUP BY e.EmployeeID,e.EName, e.ESalary,s.SalDate,s.TotalSalary,b.BDate ORDER  BY e.EmployeeID;", conn);

            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds, "Salary");

            conn.Close();
            return ds;
        }
        public int getTotalBalanceSupplier(int Sid)
        {
            SqlCommand cmd = new SqlCommand("select sum(SBalance) from SupplierPayment Where SId = @sid", conn);
            cmd.Parameters.AddWithValue("@sid", Sid);
            int total = int.Parse(cmd.ExecuteScalar().ToString());
            return total;
        }
    }
}
