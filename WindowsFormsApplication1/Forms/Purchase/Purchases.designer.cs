namespace WindowsFormsApplication1.Forms
{
    partial class Purchases
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndelete = new MetroFramework.Controls.MetroTile();
            this.btnedit = new MetroFramework.Controls.MetroTile();
            this.btnadditem = new MetroFramework.Controls.MetroTile();
            this.btnback = new MetroFramework.Controls.MetroTile();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            this.gvPurchase = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).BeginInit();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.ActiveControl = null;
            this.btndelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btndelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btndelete.BackColor = System.Drawing.Color.Transparent;
            this.btndelete.Location = new System.Drawing.Point(501, 606);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(98, 97);
            this.btndelete.TabIndex = 2;
            this.btndelete.Text = "Delete";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btndelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btndelete.TileImage = global::WindowsFormsApplication1.Properties.Resources.Delete_32px;
            this.btndelete.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btndelete.UseCustomBackColor = true;
            this.btndelete.UseSelectable = true;
            this.btndelete.UseTileImage = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.ActiveControl = null;
            this.btnedit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnedit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnedit.BackColor = System.Drawing.Color.Transparent;
            this.btnedit.Location = new System.Drawing.Point(397, 606);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(98, 97);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Edit";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnedit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnedit.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.btnedit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.btnedit.UseCustomBackColor = true;
            this.btnedit.UseSelectable = true;
            this.btnedit.UseTileImage = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadditem
            // 
            this.btnadditem.ActiveControl = null;
            this.btnadditem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnadditem.BackColor = System.Drawing.Color.Transparent;
            this.btnadditem.Location = new System.Drawing.Point(293, 606);
            this.btnadditem.Name = "btnadditem";
            this.btnadditem.Size = new System.Drawing.Size(98, 97);
            this.btnadditem.TabIndex = 0;
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
            this.btnback.Location = new System.Drawing.Point(605, 606);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(98, 97);
            this.btnback.TabIndex = 3;
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
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(484, 35);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 107;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // gvPurchase
            // 
            this.gvPurchase.AllowUserToAddRows = false;
            this.gvPurchase.AllowUserToOrderColumns = true;
            this.gvPurchase.AllowUserToResizeRows = false;
            this.gvPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPurchase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvPurchase.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvPurchase.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvPurchase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvPurchase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvPurchase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.gvPurchase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvPurchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPurchase.DefaultCellStyle = dataGridViewCellStyle6;
            this.gvPurchase.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvPurchase.EnableHeadersVisualStyles = false;
            this.gvPurchase.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvPurchase.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvPurchase.Location = new System.Drawing.Point(23, 68);
            this.gvPurchase.MultiSelect = false;
            this.gvPurchase.Name = "gvPurchase";
            this.gvPurchase.ReadOnly = true;
            this.gvPurchase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPurchase.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gvPurchase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            this.gvPurchase.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.gvPurchase.RowTemplate.Height = 35;
            this.gvPurchase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPurchase.Size = new System.Drawing.Size(962, 521);
            this.gvPurchase.TabIndex = 108;
            this.gvPurchase.UseCustomBackColor = true;
            this.gvPurchase.UseCustomForeColor = true;
            this.gvPurchase.UseStyleColors = true;
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
            this.metroPanel1.Location = new System.Drawing.Point(919, 649);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(66, 57);
            this.metroPanel1.TabIndex = 109;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Purchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.gvPurchase);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadditem);
            this.Controls.Add(this.btnback);
            this.Name = "Purchases";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Purchases";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Purchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPurchase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile btnback;
        private MetroFramework.Controls.MetroTile btnadditem;
        private MetroFramework.Controls.MetroTile btndelete;
        private MetroFramework.Controls.MetroTile btnedit;
        private MetroFramework.Controls.MetroLabel lblmsg;
        public MetroFramework.Controls.MetroGrid gvPurchase;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}