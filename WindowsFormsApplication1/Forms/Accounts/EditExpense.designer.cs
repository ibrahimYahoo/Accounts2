namespace WindowsFormsApplication1.Forms.Accounts
{
    partial class EditExpense
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
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtClear = new MetroFramework.Controls.MetroTile();
            this.dtEDate = new MetroFramework.Controls.MetroDateTime();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtECost = new MetroFramework.Controls.MetroTextBox();
            this.txtEDesc = new MetroFramework.Controls.MetroTextBox();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.lblSuccess = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(326, 305);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(96, 88);
            this.mtBack.TabIndex = 32;
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
            // mtClear
            // 
            this.mtClear.ActiveControl = null;
            this.mtClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mtClear.BackColor = System.Drawing.Color.Transparent;
            this.mtClear.Location = new System.Drawing.Point(199, 305);
            this.mtClear.Name = "mtClear";
            this.mtClear.Size = new System.Drawing.Size(96, 88);
            this.mtClear.TabIndex = 31;
            this.mtClear.Text = "Clear";
            this.mtClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtClear.TileImage = global::WindowsFormsApplication1.Properties.Resources.Eraser;
            this.mtClear.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtClear.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtClear.UseCustomBackColor = true;
            this.mtClear.UseSelectable = true;
            this.mtClear.UseTileImage = true;
            this.mtClear.Click += new System.EventHandler(this.mtClear_Click);
            // 
            // dtEDate
            // 
            this.dtEDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEDate.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dtEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEDate.Location = new System.Drawing.Point(189, 248);
            this.dtEDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtEDate.Name = "dtEDate";
            this.dtEDate.Size = new System.Drawing.Size(258, 35);
            this.dtEDate.TabIndex = 29;
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Location = new System.Drawing.Point(189, 77);
            this.cmbType.Name = "cmbType";
            this.cmbType.PromptText = "Select type";
            this.cmbType.Size = new System.Drawing.Size(258, 29);
            this.cmbType.TabIndex = 28;
            this.cmbType.UseCustomForeColor = true;
            this.cmbType.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(42, 248);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 25);
            this.metroLabel4.TabIndex = 27;
            this.metroLabel4.Text = "Date :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(42, 198);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 25);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Cost :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(42, 123);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 25);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Description :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(42, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Type : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtECost
            // 
            this.txtECost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtECost.CustomButton.Image = null;
            this.txtECost.CustomButton.Location = new System.Drawing.Point(231, 2);
            this.txtECost.CustomButton.Name = "";
            this.txtECost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtECost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtECost.CustomButton.TabIndex = 1;
            this.txtECost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtECost.CustomButton.UseSelectable = true;
            this.txtECost.CustomButton.Visible = false;
            this.txtECost.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtECost.Lines = new string[0];
            this.txtECost.Location = new System.Drawing.Point(189, 198);
            this.txtECost.MaxLength = 32767;
            this.txtECost.Name = "txtECost";
            this.txtECost.PasswordChar = '\0';
            this.txtECost.PromptText = "Cost";
            this.txtECost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtECost.SelectedText = "";
            this.txtECost.SelectionLength = 0;
            this.txtECost.SelectionStart = 0;
            this.txtECost.ShortcutsEnabled = true;
            this.txtECost.Size = new System.Drawing.Size(259, 30);
            this.txtECost.TabIndex = 23;
            this.txtECost.UseSelectable = true;
            this.txtECost.WaterMark = "Cost";
            this.txtECost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtECost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEDesc
            // 
            this.txtEDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEDesc.CustomButton.Image = null;
            this.txtEDesc.CustomButton.Location = new System.Drawing.Point(205, 2);
            this.txtEDesc.CustomButton.Name = "";
            this.txtEDesc.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtEDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEDesc.CustomButton.TabIndex = 1;
            this.txtEDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEDesc.CustomButton.UseSelectable = true;
            this.txtEDesc.CustomButton.Visible = false;
            this.txtEDesc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEDesc.Lines = new string[0];
            this.txtEDesc.Location = new System.Drawing.Point(189, 123);
            this.txtEDesc.MaxLength = 32767;
            this.txtEDesc.Multiline = true;
            this.txtEDesc.Name = "txtEDesc";
            this.txtEDesc.PasswordChar = '\0';
            this.txtEDesc.PromptText = "Describe";
            this.txtEDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEDesc.SelectedText = "";
            this.txtEDesc.SelectionLength = 0;
            this.txtEDesc.SelectionStart = 0;
            this.txtEDesc.ShortcutsEnabled = true;
            this.txtEDesc.Size = new System.Drawing.Size(259, 56);
            this.txtEDesc.TabIndex = 22;
            this.txtEDesc.UseSelectable = true;
            this.txtEDesc.WaterMark = "Describe";
            this.txtEDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtCreate
            // 
            this.mtCreate.ActiveControl = null;
            this.mtCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtCreate.BackColor = System.Drawing.Color.Transparent;
            this.mtCreate.Location = new System.Drawing.Point(85, 305);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(89, 92);
            this.mtCreate.TabIndex = 33;
            this.mtCreate.Text = "Edit";
            this.mtCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.mtCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mtCreate.TileImage = global::WindowsFormsApplication1.Properties.Resources.Edit_File_32px;
            this.mtCreate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCreate.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCreate.UseCustomBackColor = true;
            this.mtCreate.UseSelectable = true;
            this.mtCreate.UseTileImage = true;
            this.mtCreate.Click += new System.EventHandler(this.mtCreate_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSuccess.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSuccess.Location = new System.Drawing.Point(276, 34);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 0);
            this.lblSuccess.TabIndex = 50;
            this.lblSuccess.UseCustomBackColor = true;
            this.lblSuccess.UseCustomForeColor = true;
            // 
            // EditExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 420);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.dtEDate);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtECost);
            this.Controls.Add(this.txtEDesc);
            this.Name = "EditExpense";
            this.Text = "Edit Expense";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditExpense_FormClosing);
            this.Load += new System.EventHandler(this.EditExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroTile mtCreate;
        public MetroFramework.Controls.MetroDateTime dtEDate;
        public MetroFramework.Controls.MetroComboBox cmbType;
        public MetroFramework.Controls.MetroTextBox txtECost;
        public MetroFramework.Controls.MetroTextBox txtEDesc;
        private MetroFramework.Controls.MetroLabel lblSuccess;
    }
}