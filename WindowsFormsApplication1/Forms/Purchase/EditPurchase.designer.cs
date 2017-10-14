namespace WindowsFormsApplication1.Forms
{
    partial class EditPurchase
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
            this.lblqty = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbpaydate = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnadditem = new MetroFramework.Controls.MetroTile();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txttotal = new MetroFramework.Controls.MetroTextBox();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.btnclr = new MetroFramework.Controls.MetroTile();
            this.cmbItemName = new System.Windows.Forms.ComboBox();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtpurchaseprice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtitemPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.BackColor = System.Drawing.Color.Transparent;
            this.lblqty.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblqty.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblqty.ForeColor = System.Drawing.Color.White;
            this.lblqty.Location = new System.Drawing.Point(140, 390);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(0, 0);
            this.lblqty.TabIndex = 97;
            this.lblqty.UseCustomBackColor = true;
            this.lblqty.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(45, 133);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(143, 25);
            this.metroLabel3.TabIndex = 96;
            this.metroLabel3.Text = "Supplier Name : ";
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
            this.metroLabel4.Location = new System.Drawing.Point(45, 88);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(131, 25);
            this.metroLabel4.TabIndex = 95;
            this.metroLabel4.Text = "Payment Date :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // cmbpaydate
            // 
            this.cmbpaydate.Location = new System.Drawing.Point(228, 84);
            this.cmbpaydate.MinimumSize = new System.Drawing.Size(0, 29);
            this.cmbpaydate.Name = "cmbpaydate";
            this.cmbpaydate.Size = new System.Drawing.Size(253, 29);
            this.cmbpaydate.TabIndex = 93;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(45, 175);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(114, 25);
            this.metroLabel5.TabIndex = 85;
            this.metroLabel5.Text = "Item Name : ";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // btnadditem
            // 
            this.btnadditem.ActiveControl = null;
            this.btnadditem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadditem.BackColor = System.Drawing.Color.Transparent;
            this.btnadditem.Location = new System.Drawing.Point(77, 430);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(131, 92);
            this.btnadditem.TabIndex = 100;
            this.btnadditem.Text = "Edit Purchase";
            this.btnadditem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnadditem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnadditem.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.btnadditem.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnadditem.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnadditem.UseCustomBackColor = true;
            this.btnadditem.UseSelectable = true;
            this.btnadditem.UseTileImage = true;
            this.btnadditem.Click += new System.EventHandler(this.btnadditem_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(136, 381);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 103;
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
            this.metroLabel8.Location = new System.Drawing.Point(75, 395);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 25);
            this.metroLabel8.TabIndex = 102;
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
            this.txttotal.CustomButton.Location = new System.Drawing.Point(208, 2);
            this.txttotal.CustomButton.Name = "";
            this.txttotal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txttotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txttotal.CustomButton.TabIndex = 1;
            this.txttotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txttotal.CustomButton.UseSelectable = true;
            this.txttotal.CustomButton.Visible = false;
            this.txttotal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txttotal.Lines = new string[0];
            this.txttotal.Location = new System.Drawing.Point(200, 390);
            this.txttotal.MaxLength = 32767;
            this.txttotal.Name = "txttotal";
            this.txttotal.PasswordChar = '\0';
            this.txttotal.PromptText = "Total";
            this.txttotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txttotal.SelectedText = "";
            this.txttotal.SelectionLength = 0;
            this.txttotal.SelectionStart = 0;
            this.txttotal.ShortcutsEnabled = true;
            this.txttotal.Size = new System.Drawing.Size(236, 30);
            this.txttotal.TabIndex = 101;
            this.txttotal.UseSelectable = true;
            this.txttotal.WaterMark = "Total";
            this.txttotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txttotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnback
            // 
            this.btnback.ActiveControl = null;
            this.btnback.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnback.BackColor = System.Drawing.Color.Transparent;
            this.btnback.Location = new System.Drawing.Point(311, 430);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 92);
            this.btnback.TabIndex = 99;
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
            this.btnclr.Location = new System.Drawing.Point(214, 430);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(91, 92);
            this.btnclr.TabIndex = 98;
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
            // cmbItemName
            // 
            this.cmbItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemName.FormattingEnabled = true;
            this.cmbItemName.Location = new System.Drawing.Point(228, 175);
            this.cmbItemName.Name = "cmbItemName";
            this.cmbItemName.Size = new System.Drawing.Size(253, 28);
            this.cmbItemName.TabIndex = 104;
            this.cmbItemName.SelectedIndexChanged += new System.EventHandler(this.cmbItemName_SelectedIndexChanged_1);
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(228, 133);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(253, 28);
            this.cmbSupplierName.TabIndex = 105;
            this.cmbSupplierName.Click += new System.EventHandler(this.cmbSupplierName_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(45, 269);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(133, 25);
            this.metroLabel6.TabIndex = 111;
            this.metroLabel6.Text = "Purchase Price: ";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtpurchaseprice
            // 
            this.txtpurchaseprice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtpurchaseprice.CustomButton.Image = null;
            this.txtpurchaseprice.CustomButton.Location = new System.Drawing.Point(225, 2);
            this.txtpurchaseprice.CustomButton.Name = "";
            this.txtpurchaseprice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtpurchaseprice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpurchaseprice.CustomButton.TabIndex = 1;
            this.txtpurchaseprice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpurchaseprice.CustomButton.UseSelectable = true;
            this.txtpurchaseprice.CustomButton.Visible = false;
            this.txtpurchaseprice.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtpurchaseprice.Lines = new string[0];
            this.txtpurchaseprice.Location = new System.Drawing.Point(228, 264);
            this.txtpurchaseprice.MaxLength = 32767;
            this.txtpurchaseprice.Name = "txtpurchaseprice";
            this.txtpurchaseprice.PasswordChar = '\0';
            this.txtpurchaseprice.PromptText = "Purchase Price";
            this.txtpurchaseprice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpurchaseprice.SelectedText = "";
            this.txtpurchaseprice.SelectionLength = 0;
            this.txtpurchaseprice.SelectionStart = 0;
            this.txtpurchaseprice.ShortcutsEnabled = true;
            this.txtpurchaseprice.Size = new System.Drawing.Size(253, 30);
            this.txtpurchaseprice.TabIndex = 110;
            this.txtpurchaseprice.UseSelectable = true;
            this.txtpurchaseprice.WaterMark = "Purchase Price";
            this.txtpurchaseprice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpurchaseprice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(45, 319);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(115, 25);
            this.metroLabel1.TabIndex = 109;
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
            this.TxtitemPrice.Location = new System.Drawing.Point(228, 314);
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
            this.TxtitemPrice.TabIndex = 108;
            this.TxtitemPrice.UseSelectable = true;
            this.TxtitemPrice.WaterMark = "Enter Amount";
            this.TxtitemPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtitemPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(45, 220);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 25);
            this.metroLabel2.TabIndex = 107;
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
            this.txtItemQuantity.Location = new System.Drawing.Point(228, 215);
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
            this.txtItemQuantity.TabIndex = 106;
            this.txtItemQuantity.UseSelectable = true;
            this.txtItemQuantity.WaterMark = "Enter Quantity";
            this.txtItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQuantity_KeyPress_1);
            this.txtItemQuantity.Leave += new System.EventHandler(this.txtItemQuantity_Leave);
            // 
            // EditPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(519, 545);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtpurchaseprice);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtitemPrice);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtItemQuantity);
            this.Controls.Add(this.cmbSupplierName);
            this.Controls.Add(this.cmbItemName);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cmbpaydate);
            this.Controls.Add(this.metroLabel5);
            this.Name = "EditPurchase";
            this.Text = "EditPurchase";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditPurchase_FormClosing);
            this.Load += new System.EventHandler(this.EditPurchase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblqty;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroDateTime cmbpaydate;
        private MetroFramework.Controls.MetroTile btnadditem;
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnclr;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        public System.Windows.Forms.ComboBox cmbItemName;
        public System.Windows.Forms.ComboBox cmbSupplierName;
        public MetroFramework.Controls.MetroTextBox txttotal;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox txtpurchaseprice;
        public MetroFramework.Controls.MetroTextBox TxtitemPrice;
        public MetroFramework.Controls.MetroTextBox txtItemQuantity;
    }
}