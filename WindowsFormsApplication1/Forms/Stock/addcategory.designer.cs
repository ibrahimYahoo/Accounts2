namespace WindowsFormsApplication1.Forms
{
    partial class addcategory
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
            this.gvcategory = new MetroFramework.Controls.MetroGrid();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtcatname = new MetroFramework.Controls.MetroTextBox();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            this.txtcatid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // gvcategory
            // 
            this.gvcategory.AllowUserToResizeRows = false;
            this.gvcategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvcategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvcategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gvcategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvcategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvcategory.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvcategory.EnableHeadersVisualStyles = false;
            this.gvcategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvcategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvcategory.Location = new System.Drawing.Point(23, 91);
            this.gvcategory.Name = "gvcategory";
            this.gvcategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvcategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvcategory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gvcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvcategory.Size = new System.Drawing.Size(266, 247);
            this.gvcategory.TabIndex = 0;
            this.gvcategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvcategory_CellClick);
            this.gvcategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvcategory_CellContentClick);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile3.BackColor = System.Drawing.Color.Transparent;
            this.metroTile3.Location = new System.Drawing.Point(349, 253);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(94, 99);
            this.metroTile3.TabIndex = 36;
            this.metroTile3.Text = "Delete";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile3.TileImage = global::WindowsFormsApplication1.Properties.Resources.Delete_32px;
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile2.BackColor = System.Drawing.Color.Transparent;
            this.metroTile2.Location = new System.Drawing.Point(440, 148);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(75, 99);
            this.metroTile2.TabIndex = 35;
            this.metroTile2.Text = "Edit";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(449, 253);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(66, 99);
            this.mtBack.TabIndex = 33;
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
            // mtCreate
            // 
            this.mtCreate.ActiveControl = null;
            this.mtCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtCreate.BackColor = System.Drawing.Color.Transparent;
            this.mtCreate.Location = new System.Drawing.Point(349, 148);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(85, 95);
            this.mtCreate.TabIndex = 32;
            this.mtCreate.Text = "Create";
            this.mtCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCreate.TileImage = global::WindowsFormsApplication1.Properties.Resources.icons8_Add_User_Male_32;
            this.mtCreate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCreate.UseCustomBackColor = true;
            this.mtCreate.UseSelectable = true;
            this.mtCreate.UseTileImage = true;
            this.mtCreate.Click += new System.EventHandler(this.mtCreate_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(305, 117);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "Category";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtcatname
            // 
            this.txtcatname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtcatname.CustomButton.Image = null;
            this.txtcatname.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.txtcatname.CustomButton.Name = "";
            this.txtcatname.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtcatname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcatname.CustomButton.TabIndex = 1;
            this.txtcatname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcatname.CustomButton.UseSelectable = true;
            this.txtcatname.CustomButton.Visible = false;
            this.txtcatname.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtcatname.Lines = new string[0];
            this.txtcatname.Location = new System.Drawing.Point(395, 112);
            this.txtcatname.MaxLength = 32767;
            this.txtcatname.Name = "txtcatname";
            this.txtcatname.PasswordChar = '\0';
            this.txtcatname.PromptText = "Enter Category Name";
            this.txtcatname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcatname.SelectedText = "";
            this.txtcatname.SelectionLength = 0;
            this.txtcatname.SelectionStart = 0;
            this.txtcatname.ShortcutsEnabled = true;
            this.txtcatname.Size = new System.Drawing.Size(157, 30);
            this.txtcatname.TabIndex = 42;
            this.txtcatname.UseSelectable = true;
            this.txtcatname.WaterMark = "Enter Category Name";
            this.txtcatname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcatname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.White;
            this.lblmsg.Location = new System.Drawing.Point(223, 31);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 43;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // txtcatid
            // 
            this.txtcatid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtcatid.CustomButton.Image = null;
            this.txtcatid.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.txtcatid.CustomButton.Name = "";
            this.txtcatid.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtcatid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtcatid.CustomButton.TabIndex = 1;
            this.txtcatid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtcatid.CustomButton.UseSelectable = true;
            this.txtcatid.CustomButton.Visible = false;
            this.txtcatid.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtcatid.Lines = new string[0];
            this.txtcatid.Location = new System.Drawing.Point(395, 63);
            this.txtcatid.MaxLength = 32767;
            this.txtcatid.Name = "txtcatid";
            this.txtcatid.PasswordChar = '\0';
            this.txtcatid.PromptText = "Category Id";
            this.txtcatid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcatid.SelectedText = "";
            this.txtcatid.SelectionLength = 0;
            this.txtcatid.SelectionStart = 0;
            this.txtcatid.ShortcutsEnabled = true;
            this.txtcatid.Size = new System.Drawing.Size(157, 30);
            this.txtcatid.TabIndex = 44;
            this.txtcatid.UseSelectable = true;
            this.txtcatid.Visible = false;
            this.txtcatid.WaterMark = "Category Id";
            this.txtcatid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtcatid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(305, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 25);
            this.metroLabel2.TabIndex = 45;
            this.metroLabel2.Text = "Cat id";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.Visible = false;
            // 
            // addcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(575, 375);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtcatid);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.txtcatname);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.gvcategory);
            this.Name = "addcategory";
            this.Text = "Add Category";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.addcategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gvcategory;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtcatname;
        private MetroFramework.Controls.MetroLabel lblmsg;
        private MetroFramework.Controls.MetroTextBox txtcatid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}