namespace WindowsFormsApplication1.Forms
{
    partial class AddPurchase
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.cmbItemname = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtoldpurprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtitemPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txttotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbsuppname = new MetroFramework.Controls.MetroComboBox();
            this.cmbpaydate = new MetroFramework.Controls.MetroDateTime();
            this.btnadditem = new MetroFramework.Controls.MetroTile();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.btnclr = new MetroFramework.Controls.MetroTile();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAmountPaid = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(23, 60);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(130, 19);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel7.TabIndex = 69;
            this.metroLabel7.Text = "Add Items To Invoice";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cmbItemname
            // 
            this.cmbItemname.FormattingEnabled = true;
            this.cmbItemname.ItemHeight = 23;
            this.cmbItemname.Location = new System.Drawing.Point(221, 184);
            this.cmbItemname.Name = "cmbItemname";
            this.cmbItemname.Size = new System.Drawing.Size(251, 29);
            this.cmbItemname.TabIndex = 77;
            this.cmbItemname.UseSelectable = true;
            this.cmbItemname.SelectedIndexChanged += new System.EventHandler(this.cmbItemname_SelectedIndexChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(38, 284);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 25);
            this.metroLabel6.TabIndex = 76;
            this.metroLabel6.Text = "Purchase Price: ";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtoldpurprice
            // 
            this.txtoldpurprice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtoldpurprice.CustomButton.Image = null;
            this.txtoldpurprice.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txtoldpurprice.CustomButton.Name = "";
            this.txtoldpurprice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtoldpurprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtoldpurprice.CustomButton.TabIndex = 1;
            this.txtoldpurprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtoldpurprice.CustomButton.UseSelectable = true;
            this.txtoldpurprice.CustomButton.Visible = false;
            this.txtoldpurprice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtoldpurprice.Lines = new string[0];
            this.txtoldpurprice.Location = new System.Drawing.Point(221, 279);
            this.txtoldpurprice.MaxLength = 32767;
            this.txtoldpurprice.Name = "txtoldpurprice";
            this.txtoldpurprice.PasswordChar = '\0';
            this.txtoldpurprice.PromptText = "Purchase Price";
            this.txtoldpurprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtoldpurprice.SelectedText = "";
            this.txtoldpurprice.SelectionLength = 0;
            this.txtoldpurprice.SelectionStart = 0;
            this.txtoldpurprice.ShortcutsEnabled = true;
            this.txtoldpurprice.Size = new System.Drawing.Size(253, 30);
            this.txtoldpurprice.TabIndex = 75;
            this.txtoldpurprice.UseSelectable = true;
            this.txtoldpurprice.WaterMark = "Purchase Price";
            this.txtoldpurprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtoldpurprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtoldpurprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtoldpurprice_KeyPress);
            this.txtoldpurprice.Leave += new System.EventHandler(this.txtoldpurprice_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(38, 334);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 25);
            this.metroLabel1.TabIndex = 74;
            this.metroLabel1.Text = "Selling Price: ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // TxtitemPrice
            // 
            this.TxtitemPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TxtitemPrice.CustomButton.Image = null;
            this.TxtitemPrice.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.TxtitemPrice.CustomButton.Name = "";
            this.TxtitemPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TxtitemPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtitemPrice.CustomButton.TabIndex = 1;
            this.TxtitemPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtitemPrice.CustomButton.UseSelectable = true;
            this.TxtitemPrice.CustomButton.Visible = false;
            this.TxtitemPrice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.TxtitemPrice.Lines = new string[0];
            this.TxtitemPrice.Location = new System.Drawing.Point(221, 329);
            this.TxtitemPrice.MaxLength = 32767;
            this.TxtitemPrice.Name = "TxtitemPrice";
            this.TxtitemPrice.PasswordChar = '\0';
            this.TxtitemPrice.PromptText = "Enter Amount";
            this.TxtitemPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtitemPrice.SelectedText = "";
            this.TxtitemPrice.SelectionLength = 0;
            this.TxtitemPrice.SelectionStart = 0;
            this.TxtitemPrice.ShortcutsEnabled = true;
            this.TxtitemPrice.Size = new System.Drawing.Size(253, 30);
            this.TxtitemPrice.TabIndex = 73;
            this.TxtitemPrice.UseSelectable = true;
            this.TxtitemPrice.WaterMark = "Enter Amount";
            this.TxtitemPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtitemPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtitemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtitemPrice_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(38, 235);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 25);
            this.metroLabel2.TabIndex = 72;
            this.metroLabel2.Text = "Item Quantity: ";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtItemQuantity.CustomButton.Image = null;
            this.txtItemQuantity.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txtItemQuantity.CustomButton.Name = "";
            this.txtItemQuantity.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtItemQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemQuantity.CustomButton.TabIndex = 1;
            this.txtItemQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemQuantity.CustomButton.UseSelectable = true;
            this.txtItemQuantity.CustomButton.Visible = false;
            this.txtItemQuantity.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtItemQuantity.Lines = new string[0];
            this.txtItemQuantity.Location = new System.Drawing.Point(221, 230);
            this.txtItemQuantity.MaxLength = 32767;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.PasswordChar = '\0';
            this.txtItemQuantity.PromptText = "Enter Quantity";
            this.txtItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemQuantity.SelectedText = "";
            this.txtItemQuantity.SelectionLength = 0;
            this.txtItemQuantity.SelectionStart = 0;
            this.txtItemQuantity.ShortcutsEnabled = true;
            this.txtItemQuantity.Size = new System.Drawing.Size(253, 30);
            this.txtItemQuantity.TabIndex = 71;
            this.txtItemQuantity.UseSelectable = true;
            this.txtItemQuantity.WaterMark = "Enter Quantity";
            this.txtItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQuantity_KeyPress);
            this.txtItemQuantity.Leave += new System.EventHandler(this.txtItemQuantity_Leave);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(38, 188);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(114, 25);
            this.metroLabel5.TabIndex = 70;
            this.metroLabel5.Text = "Item Name : ";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(38, 382);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 25);
            this.metroLabel8.TabIndex = 79;
            this.metroLabel8.Text = "Invoice Total :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txttotal.CustomButton.Image = null;
            this.txttotal.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txttotal.CustomButton.Name = "";
            this.txttotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txttotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttotal.CustomButton.TabIndex = 1;
            this.txttotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttotal.CustomButton.UseSelectable = true;
            this.txttotal.CustomButton.Visible = false;
            this.txttotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txttotal.Lines = new string[0];
            this.txttotal.Location = new System.Drawing.Point(221, 377);
            this.txttotal.MaxLength = 32767;
            this.txttotal.Name = "txttotal";
            this.txttotal.PasswordChar = '\0';
            this.txttotal.PromptText = "Total";
            this.txttotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttotal.SelectedText = "";
            this.txttotal.SelectionLength = 0;
            this.txttotal.SelectionStart = 0;
            this.txttotal.ShortcutsEnabled = true;
            this.txttotal.Size = new System.Drawing.Size(253, 30);
            this.txttotal.TabIndex = 78;
            this.txttotal.UseSelectable = true;
            this.txttotal.WaterMark = "Total";
            this.txttotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(38, 146);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(117, 25);
            this.metroLabel3.TabIndex = 83;
            this.metroLabel3.Text = "Party Name : ";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(38, 101);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 25);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Payment Date :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // cmbsuppname
            // 
            this.cmbsuppname.FormattingEnabled = true;
            this.cmbsuppname.ItemHeight = 23;
            this.cmbsuppname.Location = new System.Drawing.Point(221, 141);
            this.cmbsuppname.Name = "cmbsuppname";
            this.cmbsuppname.PromptText = "Select Party Name";
            this.cmbsuppname.Size = new System.Drawing.Size(251, 29);
            this.cmbsuppname.TabIndex = 81;
            this.cmbsuppname.UseSelectable = true;
            this.cmbsuppname.SelectedIndexChanged += new System.EventHandler(this.cmbsuppname_SelectedIndexChanged);
            // 
            // cmbpaydate
            // 
            this.cmbpaydate.Location = new System.Drawing.Point(221, 97);
            this.cmbpaydate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbpaydate.Name = "cmbpaydate";
            this.cmbpaydate.Size = new System.Drawing.Size(251, 29);
            this.cmbpaydate.TabIndex = 80;
            // 
            // btnadditem
            // 
            this.btnadditem.ActiveControl = null;
            this.btnadditem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadditem.BackColor = System.Drawing.Color.Transparent;
            this.btnadditem.Location = new System.Drawing.Point(126, 448);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(98, 92);
            this.btnadditem.TabIndex = 87;
            this.btnadditem.Text = "Add Item";
            this.btnadditem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadditem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnadditem.TileImage = global::WindowsFormsApplication1.Properties.Resources.Add_32px;
            this.btnadditem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadditem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnadditem.UseCustomBackColor = true;
            this.btnadditem.UseSelectable = true;
            this.btnadditem.UseTileImage = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.Location = new System.Drawing.Point(327, 448);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 92);
            this.btnback.TabIndex = 86;
            this.btnback.Text = "Back";
            this.btnback.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnback.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnback.TileImage = global::WindowsFormsApplication1.Properties.Resources.Back_32px;
            this.btnback.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnback.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnback.UseCustomBackColor = true;
            this.btnback.UseSelectable = true;
            this.btnback.UseTileImage = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnclr
            // 
            this.btnclr.ActiveControl = null;
            this.btnclr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnclr.BackColor = System.Drawing.Color.Transparent;
            this.btnclr.Location = new System.Drawing.Point(230, 448);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(91, 92);
            this.btnclr.TabIndex = 85;
            this.btnclr.Text = "Clear";
            this.btnclr.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnclr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnclr.TileImage = global::WindowsFormsApplication1.Properties.Resources.Eraser;
            this.btnclr.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnclr.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnclr.UseCustomBackColor = true;
            this.btnclr.UseSelectable = true;
            this.btnclr.UseTileImage = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(38, 420);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(115, 25);
            this.metroLabel9.TabIndex = 88;
            this.metroLabel9.Text = "Amount Paid";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtAmountPaid.CustomButton.Image = null;
            this.txtAmountPaid.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txtAmountPaid.CustomButton.Name = "";
            this.txtAmountPaid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtAmountPaid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAmountPaid.CustomButton.TabIndex = 1;
            this.txtAmountPaid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAmountPaid.CustomButton.UseSelectable = true;
            this.txtAmountPaid.CustomButton.Visible = false;
            this.txtAmountPaid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtAmountPaid.Lines = new string[0];
            this.txtAmountPaid.Location = new System.Drawing.Point(219, 420);
            this.txtAmountPaid.MaxLength = 32767;
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.PasswordChar = '\0';
            this.txtAmountPaid.PromptText = "Amount Paid";
            this.txtAmountPaid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAmountPaid.SelectedText = "";
            this.txtAmountPaid.SelectionLength = 0;
            this.txtAmountPaid.SelectionStart = 0;
            this.txtAmountPaid.ShortcutsEnabled = true;
            this.txtAmountPaid.Size = new System.Drawing.Size(253, 30);
            this.txtAmountPaid.TabIndex = 89;
            this.txtAmountPaid.UseSelectable = true;
            this.txtAmountPaid.WaterMark = "Amount Paid";
            this.txtAmountPaid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAmountPaid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(526, 549);
            this.Controls.Add(this.txtAmountPaid);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbsuppname);
            this.Controls.Add(this.cmbpaydate);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.cmbItemname);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtoldpurprice);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtitemPrice);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel7);
            this.Name = "AddPurchase";
            this.Text = "AddPurchase";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddPurchase_FormClosing);
            this.Load += new System.EventHandler(this.AddPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroComboBox cmbItemname;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txttotal;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cmbsuppname;
        private MetroFramework.Controls.MetroDateTime cmbpaydate;
        private MetroFramework.Controls.MetroTile btnadditem;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnclr;
        public MetroFramework.Controls.MetroTextBox txtoldpurprice;
        public MetroFramework.Controls.MetroTextBox TxtitemPrice;
        public MetroFramework.Controls.MetroTextBox txtItemQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAmountPaid;
    }
}