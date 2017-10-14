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
    public partial class rpt : MetroFramework.Forms.MetroForm
    {
        int orderno;
        public rpt(int ono)
        {
            orderno = ono;
            InitializeComponent();
        }

        private void rpt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'orderrecieptds.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.orderrecieptds.DataTable1,orderno);

            this.reportViewer1.RefreshReport();
        }
    }
}
