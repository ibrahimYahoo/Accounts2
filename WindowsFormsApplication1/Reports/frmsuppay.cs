using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Reports
{
    public partial class frmsuppay : MetroFramework.Forms.MetroForm
    {
        int supid = 0;
        string date;
        public frmsuppay(int id, string date)
        {
            supid = id;
            this.date = date;

            InitializeComponent();
        }

        private void frmsuppay_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'supplierpayment.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.supplierpayment.DataTable1, supid, date);

            this.reportViewer1.RefreshReport();
        }
    }
}
