namespace WindowsFormsApplication1.Forms.Search
{
    partial class frmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtOrderID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.dtFromOrder = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.dtToORder = new MetroFramework.Controls.MetroDateTime();
            this.btSearchOrderByDate = new MetroFramework.Controls.MetroButton();
            this.gvOrders = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtCusID = new MetroFramework.Controls.MetroTextBox();
            this.txtCusName = new MetroFramework.Controls.MetroTextBox();
            this.gvCustomer = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnBack.Location = new System.Drawing.Point(1069, 32);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(175, 38);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back to MainMenu";
            this.btnBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroPanel3);
            this.metroTabPage3.Controls.Add(this.gvOrders);
            this.metroTabPage3.Controls.Add(this.btSearchOrderByDate);
            this.metroTabPage3.Controls.Add(this.dtToORder);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.dtFromOrder);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.txtOrderID);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1220, 500);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Orders";
            this.metroTabPage3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 22);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(70, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Order No:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtOrderID
            // 
            // 
            // 
            // 
            this.txtOrderID.CustomButton.Image = null;
            this.txtOrderID.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtOrderID.CustomButton.Name = "";
            this.txtOrderID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOrderID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOrderID.CustomButton.TabIndex = 1;
            this.txtOrderID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOrderID.CustomButton.UseSelectable = true;
            this.txtOrderID.CustomButton.Visible = false;
            this.txtOrderID.Lines = new string[0];
            this.txtOrderID.Location = new System.Drawing.Point(128, 22);
            this.txtOrderID.MaxLength = 32767;
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.PromptText = "Enter No";
            this.txtOrderID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.SelectionLength = 0;
            this.txtOrderID.SelectionStart = 0;
            this.txtOrderID.ShortcutsEnabled = true;
            this.txtOrderID.Size = new System.Drawing.Size(112, 23);
            this.txtOrderID.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtOrderID.TabIndex = 7;
            this.txtOrderID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtOrderID.UseSelectable = true;
            this.txtOrderID.WaterMark = "Enter No";
            this.txtOrderID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOrderID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtOrderID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtOrderID_KeyUp);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel12.Location = new System.Drawing.Point(311, 24);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(44, 19);
            this.metroLabel12.TabIndex = 19;
            this.metroLabel12.Text = "From:";
            this.metroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel12.UseCustomBackColor = true;
            // 
            // dtFromOrder
            // 
            this.dtFromOrder.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtFromOrder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromOrder.Location = new System.Drawing.Point(361, 20);
            this.dtFromOrder.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtFromOrder.Name = "dtFromOrder";
            this.dtFromOrder.Size = new System.Drawing.Size(110, 25);
            this.dtFromOrder.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtFromOrder.TabIndex = 8;
            this.dtFromOrder.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel13.Location = new System.Drawing.Point(486, 24);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(25, 19);
            this.metroLabel13.TabIndex = 21;
            this.metroLabel13.Text = "To:";
            this.metroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel13.UseCustomBackColor = true;
            // 
            // dtToORder
            // 
            this.dtToORder.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtToORder.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToORder.Location = new System.Drawing.Point(517, 20);
            this.dtToORder.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtToORder.Name = "dtToORder";
            this.dtToORder.Size = new System.Drawing.Size(110, 25);
            this.dtToORder.Style = MetroFramework.MetroColorStyle.Purple;
            this.dtToORder.TabIndex = 9;
            this.dtToORder.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btSearchOrderByDate
            // 
            this.btSearchOrderByDate.Location = new System.Drawing.Point(646, 20);
            this.btSearchOrderByDate.Name = "btSearchOrderByDate";
            this.btSearchOrderByDate.Size = new System.Drawing.Size(75, 25);
            this.btSearchOrderByDate.Style = MetroFramework.MetroColorStyle.Purple;
            this.btSearchOrderByDate.TabIndex = 10;
            this.btSearchOrderByDate.Text = "Search";
            this.btSearchOrderByDate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btSearchOrderByDate.UseSelectable = true;
            this.btSearchOrderByDate.Click += new System.EventHandler(this.btSearchOrderByDate_Click);
            // 
            // gvOrders
            // 
            this.gvOrders.AllowUserToAddRows = false;
            this.gvOrders.AllowUserToOrderColumns = true;
            this.gvOrders.AllowUserToResizeRows = false;
            this.gvOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            this.gvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrders.DefaultCellStyle = dataGridViewCellStyle18;
            this.gvOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvOrders.EnableHeadersVisualStyles = false;
            this.gvOrders.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvOrders.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvOrders.Location = new System.Drawing.Point(3, 99);
            this.gvOrders.MultiSelect = false;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.ReadOnly = true;
            this.gvOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.gvOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            this.gvOrders.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.gvOrders.RowTemplate.Height = 35;
            this.gvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrders.Size = new System.Drawing.Size(1214, 313);
            this.gvOrders.TabIndex = 110;
            this.gvOrders.UseCustomBackColor = true;
            this.gvOrders.UseCustomForeColor = true;
            this.gvOrders.UseStyleColors = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.AutoSize = true;
            this.metroPanel3.BackColor = System.Drawing.Color.Transparent;
            this.metroPanel3.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.umbra_logo;
            this.metroPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(1158, 453);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(66, 57);
            this.metroPanel3.TabIndex = 111;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.gvCustomer);
            this.metroTabPage1.Controls.Add(this.txtCusName);
            this.metroTabPage1.Controls.Add(this.txtCusID);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 47);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1220, 500);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Party";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Search By ID :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 64);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(113, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Search By Name: ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtCusID
            // 
            // 
            // 
            // 
            this.txtCusID.CustomButton.Image = null;
            this.txtCusID.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtCusID.CustomButton.Name = "";
            this.txtCusID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCusID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCusID.CustomButton.TabIndex = 1;
            this.txtCusID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCusID.CustomButton.UseSelectable = true;
            this.txtCusID.CustomButton.Visible = false;
            this.txtCusID.Lines = new string[0];
            this.txtCusID.Location = new System.Drawing.Point(128, 22);
            this.txtCusID.MaxLength = 32767;
            this.txtCusID.Name = "txtCusID";
            this.txtCusID.PasswordChar = '\0';
            this.txtCusID.PromptText = "Enter ID";
            this.txtCusID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCusID.SelectedText = "";
            this.txtCusID.SelectionLength = 0;
            this.txtCusID.SelectionStart = 0;
            this.txtCusID.ShortcutsEnabled = true;
            this.txtCusID.Size = new System.Drawing.Size(112, 23);
            this.txtCusID.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCusID.TabIndex = 1;
            this.txtCusID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCusID.UseSelectable = true;
            this.txtCusID.WaterMark = "Enter ID";
            this.txtCusID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCusID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCusID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCusID_KeyPress);
            this.txtCusID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusID_KeyUp);
            // 
            // txtCusName
            // 
            // 
            // 
            // 
            this.txtCusName.CustomButton.Image = null;
            this.txtCusName.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.txtCusName.CustomButton.Name = "";
            this.txtCusName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCusName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCusName.CustomButton.TabIndex = 1;
            this.txtCusName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCusName.CustomButton.UseSelectable = true;
            this.txtCusName.CustomButton.Visible = false;
            this.txtCusName.Lines = new string[0];
            this.txtCusName.Location = new System.Drawing.Point(128, 60);
            this.txtCusName.MaxLength = 32767;
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PromptText = "Enter Name";
            this.txtCusName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCusName.SelectedText = "";
            this.txtCusName.SelectionLength = 0;
            this.txtCusName.SelectionStart = 0;
            this.txtCusName.ShortcutsEnabled = true;
            this.txtCusName.Size = new System.Drawing.Size(112, 23);
            this.txtCusName.Style = MetroFramework.MetroColorStyle.Purple;
            this.txtCusName.TabIndex = 2;
            this.txtCusName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtCusName.UseSelectable = true;
            this.txtCusName.WaterMark = "Enter Name";
            this.txtCusName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCusName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCusName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCusName_KeyUp);
            // 
            // gvCustomer
            // 
            this.gvCustomer.AllowUserToAddRows = false;
            this.gvCustomer.AllowUserToOrderColumns = true;
            this.gvCustomer.AllowUserToResizeRows = false;
            this.gvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.gvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.gvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCustomer.DefaultCellStyle = dataGridViewCellStyle22;
            this.gvCustomer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvCustomer.EnableHeadersVisualStyles = false;
            this.gvCustomer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvCustomer.Location = new System.Drawing.Point(3, 99);
            this.gvCustomer.MultiSelect = false;
            this.gvCustomer.Name = "gvCustomer";
            this.gvCustomer.ReadOnly = true;
            this.gvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCustomer.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.gvCustomer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(5);
            this.gvCustomer.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.gvCustomer.RowTemplate.Height = 35;
            this.gvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCustomer.Size = new System.Drawing.Size(1214, 287);
            this.gvCustomer.TabIndex = 109;
            this.gvCustomer.UseCustomBackColor = true;
            this.gvCustomer.UseCustomForeColor = true;
            this.gvCustomer.UseStyleColors = true;
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
            this.metroPanel1.Location = new System.Drawing.Point(1158, 453);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(66, 57);
            this.metroPanel1.TabIndex = 110;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1228, 551);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTabControl1.TabIndex = 6;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1274, 637);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Search";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomer)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        public MetroFramework.Controls.MetroGrid gvOrders;
        private MetroFramework.Controls.MetroButton btSearchOrderByDate;
        private MetroFramework.Controls.MetroDateTime dtToORder;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroDateTime dtFromOrder;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTextBox txtOrderID;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        public MetroFramework.Controls.MetroGrid gvCustomer;
        private MetroFramework.Controls.MetroTextBox txtCusName;
        private MetroFramework.Controls.MetroTextBox txtCusID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
    }
}