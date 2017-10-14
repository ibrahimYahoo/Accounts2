namespace WindowsFormsApplication1.Forms.Order
{
    partial class frmCart
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.mtEdit = new MetroFramework.Controls.MetroTile();
            this.mtRemove = new MetroFramework.Controls.MetroTile();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.msmCart = new MetroFramework.Components.MetroStyleManager(this.components);
            this.lblTotal = new MetroFramework.Controls.MetroLabel();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            this.gvCart = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.msmCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.ForeColor = System.Drawing.Color.White;
            this.metroLabel7.Location = new System.Drawing.Point(795, 330);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 25);
            this.metroLabel7.TabIndex = 36;
            this.metroLabel7.Text = "Total :";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // mtEdit
            // 
            this.mtEdit.ActiveControl = null;
            this.mtEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtEdit.BackColor = System.Drawing.Color.Transparent;
            this.mtEdit.Location = new System.Drawing.Point(335, 374);
            this.mtEdit.Name = "mtEdit";
            this.mtEdit.Size = new System.Drawing.Size(122, 99);
            this.mtEdit.TabIndex = 4;
            this.mtEdit.Text = "Edit";
            this.mtEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtEdit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtEdit.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.mtEdit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtEdit.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtEdit.UseCustomBackColor = true;
            this.mtEdit.UseSelectable = true;
            this.mtEdit.UseTileImage = true;
            this.mtEdit.Click += new System.EventHandler(this.mtEdit_Click);
            // 
            // mtRemove
            // 
            this.mtRemove.ActiveControl = null;
            this.mtRemove.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mtRemove.BackColor = System.Drawing.Color.Transparent;
            this.mtRemove.Location = new System.Drawing.Point(463, 374);
            this.mtRemove.Name = "mtRemove";
            this.mtRemove.Size = new System.Drawing.Size(122, 99);
            this.mtRemove.TabIndex = 5;
            this.mtRemove.Text = "Remove";
            this.mtRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtRemove.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtRemove.TileImage = global::WindowsFormsApplication1.Properties.Resources.Delete_32px;
            this.mtRemove.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRemove.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtRemove.UseCustomBackColor = true;
            this.mtRemove.UseSelectable = true;
            this.mtRemove.UseTileImage = true;
            this.mtRemove.Click += new System.EventHandler(this.mtRemove_Click);
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(591, 374);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(122, 99);
            this.mtBack.TabIndex = 26;
            this.mtBack.Text = "Back";
            this.mtBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtBack.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtBack.TileImage = global::WindowsFormsApplication1.Properties.Resources.Back_32px;
            this.mtBack.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBack.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtBack.UseCustomBackColor = true;
            this.mtBack.UseSelectable = true;
            this.mtBack.UseTileImage = true;
            this.mtBack.Click += new System.EventHandler(this.mtBack_Click);
            // 
            // msmCart
            // 
            this.msmCart.Owner = null;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(863, 330);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(21, 25);
            this.lblTotal.TabIndex = 37;
            this.lblTotal.Text = "0";
            this.lblTotal.UseCustomBackColor = true;
            this.lblTotal.UseCustomForeColor = true;
            // 
            // lblmsg
            // 
            this.lblmsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(608, 43);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 37;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // gvCart
            // 
            this.gvCart.AllowUserToAddRows = false;
            this.gvCart.AllowUserToOrderColumns = true;
            this.gvCart.AllowUserToResizeRows = false;
            this.gvCart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvCart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvCart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.gvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvCart.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvCart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvCart.EnableHeadersVisualStyles = false;
            this.gvCart.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvCart.Location = new System.Drawing.Point(23, 63);
            this.gvCart.MultiSelect = false;
            this.gvCart.Name = "gvCart";
            this.gvCart.ReadOnly = true;
            this.gvCart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvCart.RowTemplate.Height = 35;
            this.gvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvCart.Size = new System.Drawing.Size(941, 253);
            this.gvCart.TabIndex = 109;
            this.gvCart.UseCustomBackColor = true;
            this.gvCart.UseCustomForeColor = true;
            this.gvCart.UseStyleColors = true;
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(987, 502);
            this.Controls.Add(this.gvCart);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtRemove);
            this.Controls.Add(this.mtEdit);
            this.Name = "frmCart";
            this.Text = "Cart";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.msmCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile mtEdit;
        private MetroFramework.Controls.MetroTile mtRemove;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Components.MetroStyleManager msmCart;
        public MetroFramework.Controls.MetroLabel lblTotal;
        private MetroFramework.Controls.MetroLabel lblmsg;
        public MetroFramework.Controls.MetroGrid gvCart;
    }
}