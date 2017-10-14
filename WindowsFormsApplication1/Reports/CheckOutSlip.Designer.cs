namespace WindowsFormsApplication1.Reports
{
    partial class CheckOutSlip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.orderrecieptds = new WindowsFormsApplication1.Dataseets.Orderrecieptds();
            this.orderrecieptdsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new WindowsFormsApplication1.Dataseets.OrderrecieptdsTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderrecieptds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrecieptdsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApplication1.Reports.rptorderrecipet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(524, 331);
            this.reportViewer1.TabIndex = 0;
            // 
            // orderrecieptds
            // 
            this.orderrecieptds.DataSetName = "Orderrecieptds";
            this.orderrecieptds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderrecieptdsBindingSource
            // 
            this.orderrecieptdsBindingSource.DataSource = this.orderrecieptds;
            this.orderrecieptdsBindingSource.Position = 0;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.orderrecieptdsBindingSource;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // CheckOutSlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(564, 411);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CheckOutSlip";
            this.Text = "Check Out Slip";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.CheckOutSlip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderrecieptds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderrecieptdsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Dataseets.Orderrecieptds orderrecieptds;
        private System.Windows.Forms.BindingSource orderrecieptdsBindingSource;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private Dataseets.OrderrecieptdsTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
    }
}