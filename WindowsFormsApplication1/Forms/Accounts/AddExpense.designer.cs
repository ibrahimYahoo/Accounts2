namespace WindowsFormsApplication1.Forms.Accounts
{
    partial class AddExpense
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
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtECost = new MetroFramework.Controls.MetroTextBox();
            this.txtEDesc = new MetroFramework.Controls.MetroTextBox();
            this.cmbType = new MetroFramework.Controls.MetroComboBox();
            this.dtEDate = new MetroFramework.Controls.MetroDateTime();
            this.mlType = new MetroFramework.Controls.MetroLink();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtClear = new MetroFramework.Controls.MetroTile();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.lblSuccess = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(37, 271);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 25);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Date :";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(37, 221);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 25);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Cost :";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.ForeColor = System.Drawing.Color.White;
            this.metroLabel2.Location = new System.Drawing.Point(37, 146);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(111, 25);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Description :";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(37, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Type : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // txtECost
            // 
            this.txtECost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtECost.CustomButton.Image = null;
            this.txtECost.CustomButton.Location = new System.Drawing.Point(218, 2);
            this.txtECost.CustomButton.Name = "";
            this.txtECost.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtECost.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtECost.CustomButton.TabIndex = 1;
            this.txtECost.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtECost.CustomButton.UseSelectable = true;
            this.txtECost.CustomButton.Visible = false;
            this.txtECost.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtECost.Lines = new string[0];
            this.txtECost.Location = new System.Drawing.Point(184, 221);
            this.txtECost.MaxLength = 32767;
            this.txtECost.Name = "txtECost";
            this.txtECost.PasswordChar = '\0';
            this.txtECost.PromptText = "Cost";
            this.txtECost.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtECost.SelectedText = "";
            this.txtECost.SelectionLength = 0;
            this.txtECost.SelectionStart = 0;
            this.txtECost.ShortcutsEnabled = true;
            this.txtECost.Size = new System.Drawing.Size(246, 30);
            this.txtECost.TabIndex = 11;
            this.txtECost.UseSelectable = true;
            this.txtECost.WaterMark = "Cost";
            this.txtECost.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtECost.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtECost.Click += new System.EventHandler(this.txtECost_Click);
            // 
            // txtEDesc
            // 
            this.txtEDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEDesc.CustomButton.Image = null;
            this.txtEDesc.CustomButton.Location = new System.Drawing.Point(192, 2);
            this.txtEDesc.CustomButton.Name = "";
            this.txtEDesc.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtEDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEDesc.CustomButton.TabIndex = 1;
            this.txtEDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEDesc.CustomButton.UseSelectable = true;
            this.txtEDesc.CustomButton.Visible = false;
            this.txtEDesc.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEDesc.Lines = new string[0];
            this.txtEDesc.Location = new System.Drawing.Point(184, 146);
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
            this.txtEDesc.Size = new System.Drawing.Size(246, 56);
            this.txtEDesc.TabIndex = 10;
            this.txtEDesc.UseSelectable = true;
            this.txtEDesc.WaterMark = "Describe";
            this.txtEDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEDesc.Click += new System.EventHandler(this.txtEDesc_Click);
            // 
            // cmbType
            // 
            this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbType.ForeColor = System.Drawing.Color.Black;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.ItemHeight = 23;
            this.cmbType.Location = new System.Drawing.Point(184, 100);
            this.cmbType.Name = "cmbType";
            this.cmbType.PromptText = "Select type";
            this.cmbType.Size = new System.Drawing.Size(245, 29);
            this.cmbType.TabIndex = 17;
            this.cmbType.UseCustomForeColor = true;
            this.cmbType.UseSelectable = true;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // dtEDate
            // 
            this.dtEDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtEDate.FontSize = MetroFramework.MetroDateTimeSize.Tall;
            this.dtEDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEDate.Location = new System.Drawing.Point(184, 271);
            this.dtEDate.MinimumSize = new System.Drawing.Size(0, 35);
            this.dtEDate.Name = "dtEDate";
            this.dtEDate.Size = new System.Drawing.Size(245, 35);
            this.dtEDate.TabIndex = 18;
            this.dtEDate.ValueChanged += new System.EventHandler(this.dtEDate_ValueChanged);
            // 
            // mlType
            // 
            this.mlType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlType.BackColor = System.Drawing.Color.Transparent;
            this.mlType.DisplayFocus = true;
            this.mlType.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mlType.ForeColor = System.Drawing.Color.Silver;
            this.mlType.Location = new System.Drawing.Point(456, 100);
            this.mlType.Name = "mlType";
            this.mlType.Size = new System.Drawing.Size(110, 29);
            this.mlType.TabIndex = 22;
            this.mlType.Text = "New Type?";
            this.mlType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mlType.UseCustomBackColor = true;
            this.mlType.UseCustomForeColor = true;
            this.mlType.UseSelectable = true;
            this.mlType.Click += new System.EventHandler(this.mlType_Click);
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(368, 323);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(96, 88);
            this.mtBack.TabIndex = 21;
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
            this.mtClear.Location = new System.Drawing.Point(250, 323);
            this.mtClear.Name = "mtClear";
            this.mtClear.Size = new System.Drawing.Size(96, 88);
            this.mtClear.TabIndex = 20;
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
            // mtCreate
            // 
            this.mtCreate.ActiveControl = null;
            this.mtCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.mtCreate.BackColor = System.Drawing.Color.Transparent;
            this.mtCreate.Location = new System.Drawing.Point(142, 319);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(89, 92);
            this.mtCreate.TabIndex = 19;
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
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSuccess.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSuccess.Location = new System.Drawing.Point(318, 50);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 0);
            this.lblSuccess.TabIndex = 49;
            this.lblSuccess.UseCustomBackColor = true;
            this.lblSuccess.UseCustomForeColor = true;
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 434);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.mlType);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.dtEDate);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtECost);
            this.Controls.Add(this.txtEDesc);
            this.Name = "AddExpense";
            this.Text = "New Expense";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddExpense_FormClosing);
            this.Load += new System.EventHandler(this.AddExpense_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtECost;
        private MetroFramework.Controls.MetroTextBox txtEDesc;
        private MetroFramework.Controls.MetroComboBox cmbType;
        private MetroFramework.Controls.MetroDateTime dtEDate;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLink mlType;
        private MetroFramework.Controls.MetroLabel lblSuccess;
    }
}