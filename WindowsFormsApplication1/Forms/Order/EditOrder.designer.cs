namespace WindowsFormsApplication1.Forms.Order
{
    partial class EditOrder
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
            this.lblTotalQty = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblSubtotal = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lblCost = new MetroFramework.Controls.MetroLabel();
            this.nmQty = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile3 = new MetroFramework.Controls.MetroLabel();
            this.lblItemName = new MetroFramework.Controls.MetroLabel();
            this.mtSave = new MetroFramework.Controls.MetroTile();
            this.mtCancel = new MetroFramework.Controls.MetroTile();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalQty
            // 
            this.lblTotalQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotalQty.AutoSize = true;
            this.lblTotalQty.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalQty.ForeColor = System.Drawing.Color.White;
            this.lblTotalQty.Location = new System.Drawing.Point(412, 78);
            this.lblTotalQty.Name = "lblTotalQty";
            this.lblTotalQty.Size = new System.Drawing.Size(16, 19);
            this.lblTotalQty.TabIndex = 51;
            this.lblTotalQty.Text = "0";
            this.lblTotalQty.UseCustomBackColor = true;
            this.lblTotalQty.UseCustomForeColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.ForeColor = System.Drawing.Color.White;
            this.metroLabel9.Location = new System.Drawing.Point(299, 78);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(107, 19);
            this.metroLabel9.TabIndex = 50;
            this.metroLabel9.Text = "Remaining Qty :";
            this.metroLabel9.UseCustomBackColor = true;
            this.metroLabel9.UseCustomForeColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(123, 207);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(16, 19);
            this.lblSubtotal.TabIndex = 49;
            this.lblSubtotal.Text = "0";
            this.lblSubtotal.UseCustomBackColor = true;
            this.lblSubtotal.UseCustomForeColor = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.ForeColor = System.Drawing.Color.White;
            this.metroLabel8.Location = new System.Drawing.Point(23, 201);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 25);
            this.metroLabel8.TabIndex = 48;
            this.metroLabel8.Text = "Sub Total :";
            this.metroLabel8.UseCustomBackColor = true;
            this.metroLabel8.UseCustomForeColor = true;
            // 
            // lblCost
            // 
            this.lblCost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.ForeColor = System.Drawing.Color.White;
            this.lblCost.Location = new System.Drawing.Point(123, 177);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(16, 19);
            this.lblCost.TabIndex = 47;
            this.lblCost.Text = "0";
            this.lblCost.UseCustomBackColor = true;
            this.lblCost.UseCustomForeColor = true;
            // 
            // nmQty
            // 
            this.nmQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmQty.Location = new System.Drawing.Point(149, 125);
            this.nmQty.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nmQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQty.Name = "nmQty";
            this.nmQty.Size = new System.Drawing.Size(104, 26);
            this.nmQty.TabIndex = 43;
            this.nmQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmQty.ValueChanged += new System.EventHandler(this.nmQty_ValueChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(23, 126);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(89, 25);
            this.metroLabel5.TabIndex = 42;
            this.metroLabel5.Text = "Quantity :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(23, 171);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 25);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Cost :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroTile3
            // 
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroTile3.AutoSize = true;
            this.metroTile3.BackColor = System.Drawing.Color.Transparent;
            this.metroTile3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroTile3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroTile3.ForeColor = System.Drawing.Color.White;
            this.metroTile3.Location = new System.Drawing.Point(23, 72);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(109, 25);
            this.metroTile3.TabIndex = 40;
            this.metroTile3.Text = "Item Name :";
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(149, 78);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(73, 19);
            this.lblItemName.TabIndex = 52;
            this.lblItemName.Text = "ItemName";
            this.lblItemName.UseCustomBackColor = true;
            this.lblItemName.UseCustomForeColor = true;
            // 
            // mtSave
            // 
            this.mtSave.ActiveControl = null;
            this.mtSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtSave.BackColor = System.Drawing.Color.Transparent;
            this.mtSave.Location = new System.Drawing.Point(123, 240);
            this.mtSave.Name = "mtSave";
            this.mtSave.Size = new System.Drawing.Size(122, 99);
            this.mtSave.TabIndex = 53;
            this.mtSave.Text = "Save";
            this.mtSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtSave.TileImage = global::WindowsFormsApplication1.Properties.Resources.File_32px;
            this.mtSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSave.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtSave.UseCustomBackColor = true;
            this.mtSave.UseSelectable = true;
            this.mtSave.UseTileImage = true;
            this.mtSave.Click += new System.EventHandler(this.mtSave_Click);
            // 
            // mtCancel
            // 
            this.mtCancel.ActiveControl = null;
            this.mtCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtCancel.BackColor = System.Drawing.Color.Transparent;
            this.mtCancel.Location = new System.Drawing.Point(251, 240);
            this.mtCancel.Name = "mtCancel";
            this.mtCancel.Size = new System.Drawing.Size(122, 99);
            this.mtCancel.TabIndex = 54;
            this.mtCancel.Text = "Cancel";
            this.mtCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCancel.TileImage = global::WindowsFormsApplication1.Properties.Resources.Delete_32px;
            this.mtCancel.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCancel.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCancel.UseCustomBackColor = true;
            this.mtCancel.UseSelectable = true;
            this.mtCancel.UseTileImage = true;
            this.mtCancel.Click += new System.EventHandler(this.mtCancel_Click);
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(38, 349);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 55;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // EditOrder
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(486, 394);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.mtCancel);
            this.Controls.Add(this.mtSave);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.lblTotalQty);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.nmQty);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTile3);
            this.Name = "EditOrder";
            this.Text = "Edit Order";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditOrder_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nmQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroTile3;
        private MetroFramework.Controls.MetroTile mtSave;
        private MetroFramework.Controls.MetroTile mtCancel;
        public MetroFramework.Controls.MetroLabel lblTotalQty;
        public MetroFramework.Controls.MetroLabel lblSubtotal;
        public MetroFramework.Controls.MetroLabel lblCost;
        public System.Windows.Forms.NumericUpDown nmQty;
        public MetroFramework.Controls.MetroLabel lblItemName;
        private MetroFramework.Controls.MetroLabel lblmsg;
    }
}