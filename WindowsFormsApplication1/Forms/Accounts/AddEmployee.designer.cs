namespace WindowsFormsApplication1.Forms.Accounts
{
    partial class AddEmployee
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
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtESal = new MetroFramework.Controls.MetroTextBox();
            this.txtEPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtEAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtEName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTitle = new MetroFramework.Controls.MetroTextBox();
            this.dtHireDate = new MetroFramework.Controls.MetroDateTime();
            this.lblSuccess = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(287, 421);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(96, 88);
            this.mtBack.TabIndex = 25;
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
            this.mtClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtClear.BackColor = System.Drawing.Color.Transparent;
            this.mtClear.Location = new System.Drawing.Point(169, 421);
            this.mtClear.Name = "mtClear";
            this.mtClear.Size = new System.Drawing.Size(96, 88);
            this.mtClear.TabIndex = 24;
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
            this.mtCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtCreate.BackColor = System.Drawing.Color.Transparent;
            this.mtCreate.Location = new System.Drawing.Point(61, 417);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(89, 92);
            this.mtCreate.TabIndex = 23;
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
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.ForeColor = System.Drawing.Color.White;
            this.metroLabel5.Location = new System.Drawing.Point(41, 172);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(95, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Hire Date :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.White;
            this.metroLabel4.Location = new System.Drawing.Point(41, 364);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(106, 25);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Salary/Day :";
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
            this.metroLabel3.Location = new System.Drawing.Point(41, 309);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 25);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Contact :";
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
            this.metroLabel2.Location = new System.Drawing.Point(41, 227);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 25);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Address :";
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
            this.metroLabel1.Location = new System.Drawing.Point(41, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 25);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Name : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtESal
            // 
            this.txtESal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtESal.CustomButton.Image = null;
            this.txtESal.CustomButton.Location = new System.Drawing.Point(211, 2);
            this.txtESal.CustomButton.Name = "";
            this.txtESal.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtESal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtESal.CustomButton.TabIndex = 1;
            this.txtESal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtESal.CustomButton.UseSelectable = true;
            this.txtESal.CustomButton.Visible = false;
            this.txtESal.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtESal.Lines = new string[0];
            this.txtESal.Location = new System.Drawing.Point(188, 364);
            this.txtESal.MaxLength = 32767;
            this.txtESal.Name = "txtESal";
            this.txtESal.PasswordChar = '\0';
            this.txtESal.PromptText = "Salary";
            this.txtESal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtESal.SelectedText = "";
            this.txtESal.SelectionLength = 0;
            this.txtESal.SelectionStart = 0;
            this.txtESal.ShortcutsEnabled = true;
            this.txtESal.Size = new System.Drawing.Size(239, 30);
            this.txtESal.TabIndex = 16;
            this.txtESal.UseSelectable = true;
            this.txtESal.WaterMark = "Salary";
            this.txtESal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtESal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEPhone
            // 
            this.txtEPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEPhone.CustomButton.Image = null;
            this.txtEPhone.CustomButton.Location = new System.Drawing.Point(211, 2);
            this.txtEPhone.CustomButton.Name = "";
            this.txtEPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtEPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEPhone.CustomButton.TabIndex = 1;
            this.txtEPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEPhone.CustomButton.UseSelectable = true;
            this.txtEPhone.CustomButton.Visible = false;
            this.txtEPhone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEPhone.Lines = new string[0];
            this.txtEPhone.Location = new System.Drawing.Point(188, 309);
            this.txtEPhone.MaxLength = 32767;
            this.txtEPhone.Name = "txtEPhone";
            this.txtEPhone.PasswordChar = '\0';
            this.txtEPhone.PromptText = "Contact";
            this.txtEPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEPhone.SelectedText = "";
            this.txtEPhone.SelectionLength = 0;
            this.txtEPhone.SelectionStart = 0;
            this.txtEPhone.ShortcutsEnabled = true;
            this.txtEPhone.Size = new System.Drawing.Size(239, 30);
            this.txtEPhone.TabIndex = 15;
            this.txtEPhone.UseSelectable = true;
            this.txtEPhone.WaterMark = "Contact";
            this.txtEPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEAddress
            // 
            this.txtEAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEAddress.CustomButton.Image = null;
            this.txtEAddress.CustomButton.Location = new System.Drawing.Point(185, 2);
            this.txtEAddress.CustomButton.Name = "";
            this.txtEAddress.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtEAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEAddress.CustomButton.TabIndex = 1;
            this.txtEAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEAddress.CustomButton.UseSelectable = true;
            this.txtEAddress.CustomButton.Visible = false;
            this.txtEAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEAddress.Lines = new string[0];
            this.txtEAddress.Location = new System.Drawing.Point(188, 227);
            this.txtEAddress.MaxLength = 32767;
            this.txtEAddress.Multiline = true;
            this.txtEAddress.Name = "txtEAddress";
            this.txtEAddress.PasswordChar = '\0';
            this.txtEAddress.PromptText = "Address";
            this.txtEAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEAddress.SelectedText = "";
            this.txtEAddress.SelectionLength = 0;
            this.txtEAddress.SelectionStart = 0;
            this.txtEAddress.ShortcutsEnabled = true;
            this.txtEAddress.Size = new System.Drawing.Size(239, 56);
            this.txtEAddress.TabIndex = 14;
            this.txtEAddress.UseSelectable = true;
            this.txtEAddress.WaterMark = "Address";
            this.txtEAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEName
            // 
            this.txtEName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEName.CustomButton.Image = null;
            this.txtEName.CustomButton.Location = new System.Drawing.Point(211, 2);
            this.txtEName.CustomButton.Name = "";
            this.txtEName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtEName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEName.CustomButton.TabIndex = 1;
            this.txtEName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEName.CustomButton.UseSelectable = true;
            this.txtEName.CustomButton.Visible = false;
            this.txtEName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEName.Lines = new string[0];
            this.txtEName.Location = new System.Drawing.Point(188, 74);
            this.txtEName.MaxLength = 32767;
            this.txtEName.Name = "txtEName";
            this.txtEName.PasswordChar = '\0';
            this.txtEName.PromptText = "Full Name";
            this.txtEName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEName.SelectedText = "";
            this.txtEName.SelectionLength = 0;
            this.txtEName.SelectionStart = 0;
            this.txtEName.ShortcutsEnabled = true;
            this.txtEName.Size = new System.Drawing.Size(239, 30);
            this.txtEName.TabIndex = 13;
            this.txtEName.UseSelectable = true;
            this.txtEName.WaterMark = "Full Name";
            this.txtEName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.ForeColor = System.Drawing.Color.White;
            this.metroLabel6.Location = new System.Drawing.Point(41, 125);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 25);
            this.metroLabel6.TabIndex = 27;
            this.metroLabel6.Text = "Title :";
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtTitle.CustomButton.Image = null;
            this.txtTitle.CustomButton.Location = new System.Drawing.Point(211, 2);
            this.txtTitle.CustomButton.Name = "";
            this.txtTitle.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTitle.CustomButton.TabIndex = 1;
            this.txtTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTitle.CustomButton.UseSelectable = true;
            this.txtTitle.CustomButton.Visible = false;
            this.txtTitle.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTitle.Lines = new string[0];
            this.txtTitle.Location = new System.Drawing.Point(188, 125);
            this.txtTitle.MaxLength = 32767;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PromptText = "Title";
            this.txtTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTitle.SelectedText = "";
            this.txtTitle.SelectionLength = 0;
            this.txtTitle.SelectionStart = 0;
            this.txtTitle.ShortcutsEnabled = true;
            this.txtTitle.Size = new System.Drawing.Size(239, 30);
            this.txtTitle.TabIndex = 26;
            this.txtTitle.UseSelectable = true;
            this.txtTitle.WaterMark = "Title";
            this.txtTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dtHireDate
            // 
            this.dtHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtHireDate.Location = new System.Drawing.Point(188, 176);
            this.dtHireDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtHireDate.Name = "dtHireDate";
            this.dtHireDate.Size = new System.Drawing.Size(239, 29);
            this.dtHireDate.TabIndex = 28;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSuccess.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSuccess.Location = new System.Drawing.Point(234, 35);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 0);
            this.lblSuccess.TabIndex = 48;
            this.lblSuccess.UseCustomBackColor = true;
            this.lblSuccess.UseCustomForeColor = true;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 534);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.dtHireDate);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtESal);
            this.Controls.Add(this.txtEPhone);
            this.Controls.Add(this.txtEAddress);
            this.Controls.Add(this.txtEName);
            this.Name = "AddEmployee";
            this.Text = "Add Employee";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtESal;
        private MetroFramework.Controls.MetroTextBox txtEPhone;
        private MetroFramework.Controls.MetroTextBox txtEAddress;
        private MetroFramework.Controls.MetroTextBox txtEName;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTitle;
        private MetroFramework.Controls.MetroDateTime dtHireDate;
        private MetroFramework.Controls.MetroLabel lblSuccess;
    }
}