namespace WindowsFormsApplication1.Forms
{
    partial class Payments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabcontrol = new MetroFramework.Controls.MetroTabControl();
            this.metroTabBalance = new MetroFramework.Controls.MetroTabPage();
            this.gvBalanceSupplier = new MetroFramework.Controls.MetroGrid();
            this.gvBalanceCustomer = new MetroFramework.Controls.MetroGrid();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.lblBalanceSupp = new MetroFramework.Controls.MetroLabel();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.lblBalance = new MetroFramework.Controls.MetroLabel();
            this.lblPaidAmount = new MetroFramework.Controls.MetroLabel();
            this.lblNetTotal = new MetroFramework.Controls.MetroLabel();
            this.btnShowAllSuppBalance = new MetroFramework.Controls.MetroButton();
            this.btnShowAllCusBalance = new MetroFramework.Controls.MetroButton();
            this.btSearchSupplier = new MetroFramework.Controls.MetroButton();
            this.btSearchCustomerByDate = new MetroFramework.Controls.MetroButton();
            this.dtToSupplier = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.dtFromSupplier = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.txtSupplierName = new MetroFramework.Controls.MetroTextBox();
            this.dtToCustomer = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dtFromCustomer = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.txtCusName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtcusAmount = new MetroFramework.Controls.MetroTextBox();
            this.txtcusBalance = new MetroFramework.Controls.MetroTextBox();
            this.cmbcusname = new MetroFramework.Controls.MetroComboBox();
            this.cmbcusspaydate = new MetroFramework.Controls.MetroDateTime();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.tabcontrol.SuspendLayout();
            this.metroTabBalance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceCustomer)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabcontrol.Controls.Add(this.metroTabBalance);
            this.tabcontrol.Controls.Add(this.metroTabPage1);
            this.tabcontrol.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.tabcontrol.Location = new System.Drawing.Point(23, 77);
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 1;
            this.tabcontrol.Size = new System.Drawing.Size(1246, 680);
            this.tabcontrol.Style = MetroFramework.MetroColorStyle.Teal;
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tabcontrol.UseSelectable = true;
            this.tabcontrol.TabIndexChanged += new System.EventHandler(this.tabcontrol_TabIndexChanged);
            this.tabcontrol.Click += new System.EventHandler(this.tabcontrol_Click);
            // 
            // metroTabBalance
            // 
            this.metroTabBalance.Controls.Add(this.gvBalanceSupplier);
            this.metroTabBalance.Controls.Add(this.gvBalanceCustomer);
            this.metroTabBalance.Controls.Add(this.metroLabel20);
            this.metroTabBalance.Controls.Add(this.lblBalanceSupp);
            this.metroTabBalance.Controls.Add(this.metroLabel19);
            this.metroTabBalance.Controls.Add(this.metroLabel18);
            this.metroTabBalance.Controls.Add(this.metroLabel17);
            this.metroTabBalance.Controls.Add(this.lblBalance);
            this.metroTabBalance.Controls.Add(this.lblPaidAmount);
            this.metroTabBalance.Controls.Add(this.lblNetTotal);
            this.metroTabBalance.Controls.Add(this.btnShowAllSuppBalance);
            this.metroTabBalance.Controls.Add(this.btnShowAllCusBalance);
            this.metroTabBalance.Controls.Add(this.btSearchSupplier);
            this.metroTabBalance.Controls.Add(this.btSearchCustomerByDate);
            this.metroTabBalance.Controls.Add(this.dtToSupplier);
            this.metroTabBalance.Controls.Add(this.metroLabel14);
            this.metroTabBalance.Controls.Add(this.dtFromSupplier);
            this.metroTabBalance.Controls.Add(this.metroLabel15);
            this.metroTabBalance.Controls.Add(this.metroLabel16);
            this.metroTabBalance.Controls.Add(this.txtSupplierName);
            this.metroTabBalance.Controls.Add(this.dtToCustomer);
            this.metroTabBalance.Controls.Add(this.metroLabel13);
            this.metroTabBalance.Controls.Add(this.dtFromCustomer);
            this.metroTabBalance.Controls.Add(this.metroLabel12);
            this.metroTabBalance.Controls.Add(this.metroLabel11);
            this.metroTabBalance.Controls.Add(this.txtCusName);
            this.metroTabBalance.Controls.Add(this.metroLabel10);
            this.metroTabBalance.Controls.Add(this.metroLabel9);
            this.metroTabBalance.ForeColor = System.Drawing.Color.White;
            this.metroTabBalance.HorizontalScrollbarBarColor = true;
            this.metroTabBalance.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabBalance.HorizontalScrollbarSize = 10;
            this.metroTabBalance.Location = new System.Drawing.Point(4, 44);
            this.metroTabBalance.Name = "metroTabBalance";
            this.metroTabBalance.Size = new System.Drawing.Size(1238, 632);
            this.metroTabBalance.TabIndex = 2;
            this.metroTabBalance.Text = "Balance Sheet";
            this.metroTabBalance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabBalance.UseCustomForeColor = true;
            this.metroTabBalance.VerticalScrollbarBarColor = true;
            this.metroTabBalance.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabBalance.VerticalScrollbarSize = 10;
            // 
            // gvBalanceSupplier
            // 
            this.gvBalanceSupplier.AllowUserToAddRows = false;
            this.gvBalanceSupplier.AllowUserToOrderColumns = true;
            this.gvBalanceSupplier.AllowUserToResizeRows = false;
            this.gvBalanceSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBalanceSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBalanceSupplier.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvBalanceSupplier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvBalanceSupplier.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBalanceSupplier.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvBalanceSupplier.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvBalanceSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvBalanceSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBalanceSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvBalanceSupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvBalanceSupplier.EnableHeadersVisualStyles = false;
            this.gvBalanceSupplier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvBalanceSupplier.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvBalanceSupplier.Location = new System.Drawing.Point(5, 393);
            this.gvBalanceSupplier.MultiSelect = false;
            this.gvBalanceSupplier.Name = "gvBalanceSupplier";
            this.gvBalanceSupplier.ReadOnly = true;
            this.gvBalanceSupplier.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBalanceSupplier.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvBalanceSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.gvBalanceSupplier.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvBalanceSupplier.RowTemplate.Height = 35;
            this.gvBalanceSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBalanceSupplier.Size = new System.Drawing.Size(1232, 194);
            this.gvBalanceSupplier.TabIndex = 32;
            this.gvBalanceSupplier.UseCustomBackColor = true;
            this.gvBalanceSupplier.UseCustomForeColor = true;
            this.gvBalanceSupplier.UseStyleColors = true;
            // 
            // gvBalanceCustomer
            // 
            this.gvBalanceCustomer.AllowUserToAddRows = false;
            this.gvBalanceCustomer.AllowUserToOrderColumns = true;
            this.gvBalanceCustomer.AllowUserToResizeRows = false;
            this.gvBalanceCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvBalanceCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBalanceCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvBalanceCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvBalanceCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvBalanceCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvBalanceCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gvBalanceCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvBalanceCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBalanceCustomer.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvBalanceCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvBalanceCustomer.EnableHeadersVisualStyles = false;
            this.gvBalanceCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvBalanceCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvBalanceCustomer.Location = new System.Drawing.Point(5, 87);
            this.gvBalanceCustomer.MultiSelect = false;
            this.gvBalanceCustomer.Name = "gvBalanceCustomer";
            this.gvBalanceCustomer.ReadOnly = true;
            this.gvBalanceCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvBalanceCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvBalanceCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.gvBalanceCustomer.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gvBalanceCustomer.RowTemplate.Height = 35;
            this.gvBalanceCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBalanceCustomer.Size = new System.Drawing.Size(1232, 194);
            this.gvBalanceCustomer.TabIndex = 31;
            this.gvBalanceCustomer.UseCustomBackColor = true;
            this.gvBalanceCustomer.UseCustomForeColor = true;
            this.gvBalanceCustomer.UseStyleColors = true;
            this.gvBalanceCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvBalanceCustomer_CellContentClick_1);
            // 
            // metroLabel20
            // 
            this.metroLabel20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.ForeColor = System.Drawing.Color.White;
            this.metroLabel20.Location = new System.Drawing.Point(1078, 592);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(57, 19);
            this.metroLabel20.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel20.TabIndex = 29;
            this.metroLabel20.Text = "Balance:";
            this.metroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel20.UseCustomForeColor = true;
            // 
            // lblBalanceSupp
            // 
            this.lblBalanceSupp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalanceSupp.AutoSize = true;
            this.lblBalanceSupp.ForeColor = System.Drawing.Color.White;
            this.lblBalanceSupp.Location = new System.Drawing.Point(1141, 592);
            this.lblBalanceSupp.Name = "lblBalanceSupp";
            this.lblBalanceSupp.Size = new System.Drawing.Size(0, 0);
            this.lblBalanceSupp.Style = MetroFramework.MetroColorStyle.Red;
            this.lblBalanceSupp.TabIndex = 28;
            this.lblBalanceSupp.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblBalanceSupp.UseCustomForeColor = true;
            // 
            // metroLabel19
            // 
            this.metroLabel19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.ForeColor = System.Drawing.Color.White;
            this.metroLabel19.Location = new System.Drawing.Point(1078, 286);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(57, 19);
            this.metroLabel19.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel19.TabIndex = 26;
            this.metroLabel19.Text = "Balance:";
            this.metroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel19.UseCustomForeColor = true;
            // 
            // metroLabel18
            // 
            this.metroLabel18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.ForeColor = System.Drawing.Color.White;
            this.metroLabel18.Location = new System.Drawing.Point(934, 286);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(37, 19);
            this.metroLabel18.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel18.TabIndex = 25;
            this.metroLabel18.Text = "Paid:";
            this.metroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel18.UseCustomForeColor = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.ForeColor = System.Drawing.Color.White;
            this.metroLabel17.Location = new System.Drawing.Point(777, 286);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(64, 19);
            this.metroLabel17.Style = MetroFramework.MetroColorStyle.Red;
            this.metroLabel17.TabIndex = 24;
            this.metroLabel17.Text = "Net Total:";
            this.metroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel17.UseCustomForeColor = true;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBalance.AutoSize = true;
            this.lblBalance.ForeColor = System.Drawing.Color.White;
            this.lblBalance.Location = new System.Drawing.Point(1131, 286);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(0, 0);
            this.lblBalance.Style = MetroFramework.MetroColorStyle.Red;
            this.lblBalance.TabIndex = 23;
            this.lblBalance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblBalance.UseCustomForeColor = true;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.ForeColor = System.Drawing.Color.White;
            this.lblPaidAmount.Location = new System.Drawing.Point(977, 286);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(0, 0);
            this.lblPaidAmount.Style = MetroFramework.MetroColorStyle.Red;
            this.lblPaidAmount.TabIndex = 23;
            this.lblPaidAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblPaidAmount.UseCustomForeColor = true;
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.ForeColor = System.Drawing.Color.White;
            this.lblNetTotal.Location = new System.Drawing.Point(847, 286);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(0, 0);
            this.lblNetTotal.Style = MetroFramework.MetroColorStyle.Red;
            this.lblNetTotal.TabIndex = 23;
            this.lblNetTotal.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblNetTotal.UseCustomForeColor = true;
            // 
            // btnShowAllSuppBalance
            // 
            this.btnShowAllSuppBalance.Location = new System.Drawing.Point(1110, 332);
            this.btnShowAllSuppBalance.Name = "btnShowAllSuppBalance";
            this.btnShowAllSuppBalance.Size = new System.Drawing.Size(122, 25);
            this.btnShowAllSuppBalance.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnShowAllSuppBalance.TabIndex = 22;
            this.btnShowAllSuppBalance.Text = "Show All";
            this.btnShowAllSuppBalance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnShowAllSuppBalance.UseSelectable = true;
            this.btnShowAllSuppBalance.Click += new System.EventHandler(this.btnShowAllSuppBalance_Click);
            // 
            // btnShowAllCusBalance
            // 
            this.btnShowAllCusBalance.Location = new System.Drawing.Point(1100, 25);
            this.btnShowAllCusBalance.Name = "btnShowAllCusBalance";
            this.btnShowAllCusBalance.Size = new System.Drawing.Size(132, 25);
            this.btnShowAllCusBalance.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnShowAllCusBalance.TabIndex = 21;
            this.btnShowAllCusBalance.Text = "Show All";
            this.btnShowAllCusBalance.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnShowAllCusBalance.UseSelectable = true;
            this.btnShowAllCusBalance.Click += new System.EventHandler(this.btnShowAllCusBalance_Click);
            // 
            // btSearchSupplier
            // 
            this.btSearchSupplier.Location = new System.Drawing.Point(680, 332);
            this.btSearchSupplier.Name = "btSearchSupplier";
            this.btSearchSupplier.Size = new System.Drawing.Size(75, 25);
            this.btSearchSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.btSearchSupplier.TabIndex = 19;
            this.btSearchSupplier.Text = "Search";
            this.btSearchSupplier.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btSearchSupplier.UseSelectable = true;
            this.btSearchSupplier.Click += new System.EventHandler(this.btSearchSupplier_Click);
            // 
            // btSearchCustomerByDate
            // 
            this.btSearchCustomerByDate.Location = new System.Drawing.Point(680, 25);
            this.btSearchCustomerByDate.Name = "btSearchCustomerByDate";
            this.btSearchCustomerByDate.Size = new System.Drawing.Size(75, 25);
            this.btSearchCustomerByDate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btSearchCustomerByDate.TabIndex = 18;
            this.btSearchCustomerByDate.Text = "Search";
            this.btSearchCustomerByDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btSearchCustomerByDate.UseSelectable = true;
            this.btSearchCustomerByDate.Click += new System.EventHandler(this.btSearchCustomerByDate_Click);
            // 
            // dtToSupplier
            // 
            this.dtToSupplier.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtToSupplier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToSupplier.Location = new System.Drawing.Point(564, 332);
            this.dtToSupplier.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtToSupplier.Name = "dtToSupplier";
            this.dtToSupplier.Size = new System.Drawing.Size(110, 25);
            this.dtToSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtToSupplier.TabIndex = 17;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel14.ForeColor = System.Drawing.Color.White;
            this.metroLabel14.Location = new System.Drawing.Point(533, 336);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(25, 19);
            this.metroLabel14.TabIndex = 16;
            this.metroLabel14.Text = "To:";
            this.metroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // dtFromSupplier
            // 
            this.dtFromSupplier.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFromSupplier.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromSupplier.Location = new System.Drawing.Point(382, 332);
            this.dtFromSupplier.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFromSupplier.Name = "dtFromSupplier";
            this.dtFromSupplier.Size = new System.Drawing.Size(110, 25);
            this.dtFromSupplier.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtFromSupplier.TabIndex = 15;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel15.ForeColor = System.Drawing.Color.White;
            this.metroLabel15.Location = new System.Drawing.Point(332, 336);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(44, 19);
            this.metroLabel15.TabIndex = 14;
            this.metroLabel15.Text = "From:";
            this.metroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel15.UseCustomBackColor = true;
            this.metroLabel15.UseCustomForeColor = true;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel16.ForeColor = System.Drawing.Color.White;
            this.metroLabel16.Location = new System.Drawing.Point(0, 336);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(48, 19);
            this.metroLabel16.TabIndex = 13;
            this.metroLabel16.Text = "Name:";
            this.metroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel16.UseCustomBackColor = true;
            this.metroLabel16.UseCustomForeColor = true;
            // 
            // txtSupplierName
            // 
            // 
            // 
            // 
            this.txtSupplierName.CustomButton.Image = null;
            this.txtSupplierName.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtSupplierName.CustomButton.Name = "";
            this.txtSupplierName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtSupplierName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSupplierName.CustomButton.TabIndex = 1;
            this.txtSupplierName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSupplierName.CustomButton.UseSelectable = true;
            this.txtSupplierName.CustomButton.Visible = false;
            this.txtSupplierName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSupplierName.Lines = new string[0];
            this.txtSupplierName.Location = new System.Drawing.Point(54, 332);
            this.txtSupplierName.MaxLength = 32767;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.PasswordChar = '\0';
            this.txtSupplierName.PromptText = "Enter Supplier Name";
            this.txtSupplierName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSupplierName.SelectedText = "";
            this.txtSupplierName.SelectionLength = 0;
            this.txtSupplierName.SelectionStart = 0;
            this.txtSupplierName.ShortcutsEnabled = true;
            this.txtSupplierName.Size = new System.Drawing.Size(149, 25);
            this.txtSupplierName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtSupplierName.TabIndex = 12;
            this.txtSupplierName.UseSelectable = true;
            this.txtSupplierName.WaterMark = "Enter Supplier Name";
            this.txtSupplierName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSupplierName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSupplierName_KeyPress);
            // 
            // dtToCustomer
            // 
            this.dtToCustomer.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtToCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToCustomer.Location = new System.Drawing.Point(564, 25);
            this.dtToCustomer.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtToCustomer.Name = "dtToCustomer";
            this.dtToCustomer.Size = new System.Drawing.Size(110, 25);
            this.dtToCustomer.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtToCustomer.TabIndex = 11;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.ForeColor = System.Drawing.Color.White;
            this.metroLabel13.Location = new System.Drawing.Point(533, 29);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(25, 19);
            this.metroLabel13.TabIndex = 10;
            this.metroLabel13.Text = "To:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseCustomBackColor = true;
            this.metroLabel13.UseCustomForeColor = true;
            // 
            // dtFromCustomer
            // 
            this.dtFromCustomer.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFromCustomer.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromCustomer.Location = new System.Drawing.Point(382, 25);
            this.dtFromCustomer.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFromCustomer.Name = "dtFromCustomer";
            this.dtFromCustomer.Size = new System.Drawing.Size(110, 25);
            this.dtFromCustomer.Style = MetroFramework.MetroColorStyle.Teal;
            this.dtFromCustomer.TabIndex = 9;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.ForeColor = System.Drawing.Color.White;
            this.metroLabel12.Location = new System.Drawing.Point(332, 29);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(44, 19);
            this.metroLabel12.TabIndex = 8;
            this.metroLabel12.Text = "From:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseCustomBackColor = true;
            this.metroLabel12.UseCustomForeColor = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel11.ForeColor = System.Drawing.Color.White;
            this.metroLabel11.Location = new System.Drawing.Point(0, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(48, 19);
            this.metroLabel11.TabIndex = 7;
            this.metroLabel11.Text = "Name:";
            this.metroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // txtCusName
            // 
            // 
            // 
            // 
            this.txtCusName.CustomButton.Image = null;
            this.txtCusName.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.txtCusName.CustomButton.Name = "";
            this.txtCusName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtCusName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCusName.CustomButton.TabIndex = 1;
            this.txtCusName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCusName.CustomButton.UseSelectable = true;
            this.txtCusName.CustomButton.Visible = false;
            this.txtCusName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCusName.Lines = new string[0];
            this.txtCusName.Location = new System.Drawing.Point(54, 25);
            this.txtCusName.MaxLength = 32767;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PromptText = "Enter Customer Name";
            this.txtCusName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCusName.SelectedText = "";
            this.txtCusName.SelectionLength = 0;
            this.txtCusName.SelectionStart = 0;
            this.txtCusName.ShortcutsEnabled = true;
            this.txtCusName.Size = new System.Drawing.Size(149, 25);
            this.txtCusName.Style = MetroFramework.MetroColorStyle.Teal;
            this.txtCusName.TabIndex = 1;
            this.txtCusName.UseSelectable = true;
            this.txtCusName.WaterMark = "Enter Customer Name";
            this.txtCusName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCusName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusName_KeyPress);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel10.Location = new System.Drawing.Point(0, 365);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(142, 25);
            this.metroLabel10.TabIndex = 5;
            this.metroLabel10.Text = "Supplier Balance:";
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomBackColor = true;
            this.metroLabel10.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metroLabel9.Location = new System.Drawing.Point(0, 59);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(153, 25);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Customer Balance:";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroTabPage1.Controls.Add(this.lblError);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.mtCreate);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.txtcusAmount);
            this.metroTabPage1.Controls.Add(this.txtcusBalance);
            this.metroTabPage1.Controls.Add(this.cmbcusname);
            this.metroTabPage1.Controls.Add(this.cmbcusspaydate);
            this.metroTabPage1.ForeColor = System.Drawing.Color.White;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 44);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1238, 632);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Party Payment";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.UseCustomForeColor = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblError.Location = new System.Drawing.Point(580, 238);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 0);
            this.lblError.TabIndex = 67;
            this.lblError.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lblError.UseCustomForeColor = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.AutoSize = true;
            this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.umbra_logo;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1176, 579);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(66, 57);
            this.metroPanel1.TabIndex = 66;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.Transparent;
            this.metroTile1.Location = new System.Drawing.Point(580, 283);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(98, 92);
            this.metroTile1.TabIndex = 65;
            this.metroTile1.Text = "Pay Slip";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = global::WindowsFormsApplication1.Properties.Resources.Report_Card_32px;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtCreate
            // 
            this.mtCreate.ActiveControl = null;
            this.mtCreate.BackColor = System.Drawing.Color.Transparent;
            this.mtCreate.Location = new System.Drawing.Point(443, 283);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(131, 92);
            this.mtCreate.TabIndex = 63;
            this.mtCreate.Text = "Add Payment";
            this.mtCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCreate.TileImage = global::WindowsFormsApplication1.Properties.Resources.Add_32px;
            this.mtCreate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCreate.UseCustomBackColor = true;
            this.mtCreate.UseSelectable = true;
            this.mtCreate.UseTileImage = true;
            this.mtCreate.Click += new System.EventHandler(this.mtCreate_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(386, 212);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 25);
            this.metroLabel5.TabIndex = 62;
            this.metroLabel5.Text = "Amount :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(386, 173);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(80, 25);
            this.metroLabel6.TabIndex = 61;
            this.metroLabel6.Text = "Balance :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(386, 133);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(117, 25);
            this.metroLabel7.TabIndex = 60;
            this.metroLabel7.Text = "Party Name : ";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(386, 88);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(131, 25);
            this.metroLabel8.TabIndex = 59;
            this.metroLabel8.Text = "Payment Date :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // txtcusAmount
            // 
            // 
            // 
            // 
            this.txtcusAmount.CustomButton.Image = null;
            this.txtcusAmount.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtcusAmount.CustomButton.Name = "";
            this.txtcusAmount.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcusAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcusAmount.CustomButton.TabIndex = 1;
            this.txtcusAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcusAmount.CustomButton.UseSelectable = true;
            this.txtcusAmount.CustomButton.Visible = false;
            this.txtcusAmount.Lines = new string[0];
            this.txtcusAmount.Location = new System.Drawing.Point(580, 212);
            this.txtcusAmount.MaxLength = 32767;
            this.txtcusAmount.Name = "txtcusAmount";
            this.txtcusAmount.PasswordChar = '\0';
            this.txtcusAmount.PromptText = "Enter Party Amount";
            this.txtcusAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcusAmount.SelectedText = "";
            this.txtcusAmount.SelectionLength = 0;
            this.txtcusAmount.SelectionStart = 0;
            this.txtcusAmount.ShortcutsEnabled = true;
            this.txtcusAmount.Size = new System.Drawing.Size(200, 23);
            this.txtcusAmount.TabIndex = 58;
            this.txtcusAmount.UseSelectable = true;
            this.txtcusAmount.WaterMark = "Enter Party Amount";
            this.txtcusAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcusAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtcusAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcusAmount_KeyPress);
            this.txtcusAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcusAmount_KeyUp);
            // 
            // txtcusBalance
            // 
            // 
            // 
            // 
            this.txtcusBalance.CustomButton.Image = null;
            this.txtcusBalance.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.txtcusBalance.CustomButton.Name = "";
            this.txtcusBalance.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtcusBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcusBalance.CustomButton.TabIndex = 1;
            this.txtcusBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcusBalance.CustomButton.UseSelectable = true;
            this.txtcusBalance.CustomButton.Visible = false;
            this.txtcusBalance.Enabled = false;
            this.txtcusBalance.Lines = new string[0];
            this.txtcusBalance.Location = new System.Drawing.Point(580, 175);
            this.txtcusBalance.MaxLength = 32767;
            this.txtcusBalance.Name = "txtcusBalance";
            this.txtcusBalance.PasswordChar = '\0';
            this.txtcusBalance.PromptText = "Party Balance";
            this.txtcusBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcusBalance.SelectedText = "";
            this.txtcusBalance.SelectionLength = 0;
            this.txtcusBalance.SelectionStart = 0;
            this.txtcusBalance.ShortcutsEnabled = true;
            this.txtcusBalance.Size = new System.Drawing.Size(200, 23);
            this.txtcusBalance.TabIndex = 57;
            this.txtcusBalance.UseSelectable = true;
            this.txtcusBalance.WaterMark = "Party Balance";
            this.txtcusBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcusBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtcusBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcusBalance_KeyPress);
            // 
            // cmbcusname
            // 
            this.cmbcusname.FormattingEnabled = true;
            this.cmbcusname.ItemHeight = 23;
            this.cmbcusname.Location = new System.Drawing.Point(580, 133);
            this.cmbcusname.Name = "cmbcusname";
            this.cmbcusname.PromptText = "Select Party Name";
            this.cmbcusname.Size = new System.Drawing.Size(200, 29);
            this.cmbcusname.TabIndex = 56;
            this.cmbcusname.UseSelectable = true;
            this.cmbcusname.SelectedIndexChanged += new System.EventHandler(this.cmbcusname_SelectedIndexChanged);
            // 
            // cmbcusspaydate
            // 
            this.cmbcusspaydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.cmbcusspaydate.Location = new System.Drawing.Point(580, 88);
            this.cmbcusspaydate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbcusspaydate.Name = "cmbcusspaydate";
            this.cmbcusspaydate.Size = new System.Drawing.Size(200, 29);
            this.cmbcusspaydate.TabIndex = 55;
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.Location = new System.Drawing.Point(1084, 33);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 38);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back to MainMenu";
            this.btnBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 780);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.tabcontrol);
            this.Name = "Payments";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Payments";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payments_Load);
            this.tabcontrol.ResumeLayout(false);
            this.metroTabBalance.ResumeLayout(false);
            this.metroTabBalance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvBalanceCustomer)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabcontrol;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtcusAmount;
        private MetroFramework.Controls.MetroTextBox txtcusBalance;
        private MetroFramework.Controls.MetroComboBox cmbcusname;
        private MetroFramework.Controls.MetroDateTime cmbcusspaydate;
        private MetroFramework.Controls.MetroTabPage metroTabBalance;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox txtCusName;
        private MetroFramework.Controls.MetroDateTime dtFromCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroDateTime dtToCustomer;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime dtToSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroDateTime dtFromSupplier;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox txtSupplierName;
        private MetroFramework.Controls.MetroButton btSearchCustomerByDate;
        private MetroFramework.Controls.MetroButton btSearchSupplier;
        private MetroFramework.Controls.MetroButton btnShowAllSuppBalance;
        private MetroFramework.Controls.MetroButton btnShowAllCusBalance;
        private MetroFramework.Controls.MetroLabel lblBalance;
        private MetroFramework.Controls.MetroLabel lblPaidAmount;
        private MetroFramework.Controls.MetroLabel lblNetTotal;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroLabel lblBalanceSupp;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        public MetroFramework.Controls.MetroGrid gvBalanceCustomer;
        public MetroFramework.Controls.MetroGrid gvBalanceSupplier;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblError;
    }
}