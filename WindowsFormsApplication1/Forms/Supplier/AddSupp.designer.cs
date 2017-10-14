namespace WindowsFormsApplication1.Forms
{
    partial class AddSupp
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
            this.msmAddSupp = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtClear = new MetroFramework.Controls.MetroTile();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSBalance = new MetroFramework.Controls.MetroTextBox();
            this.txtSPhone = new MetroFramework.Controls.MetroTextBox();
            this.txtSAddress = new MetroFramework.Controls.MetroTextBox();
            this.txtSName = new MetroFramework.Controls.MetroTextBox();
            this.lblmsg = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmAddSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // msmAddSupp
            // 
            this.msmAddSupp.Owner = null;
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(277, 354);
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
            this.mtClear.Location = new System.Drawing.Point(175, 354);
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
            this.mtCreate.Location = new System.Drawing.Point(80, 350);
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
            this.metroLabel5.Location = new System.Drawing.Point(50, 266);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(80, 25);
            this.metroLabel5.TabIndex = 22;
            this.metroLabel5.Text = "Balance :";
            this.metroLabel5.UseCustomBackColor = true;
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.Color.White;
            this.metroLabel3.Location = new System.Drawing.Point(50, 213);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 25);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Phone :";
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
            this.metroLabel2.Location = new System.Drawing.Point(50, 138);
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
            this.metroLabel1.Location = new System.Drawing.Point(50, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 25);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Name : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtSBalance
            // 
            this.txtSBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSBalance.CustomButton.Image = null;
            this.txtSBalance.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtSBalance.CustomButton.Name = "";
            this.txtSBalance.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSBalance.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSBalance.CustomButton.TabIndex = 1;
            this.txtSBalance.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSBalance.CustomButton.UseSelectable = true;
            this.txtSBalance.CustomButton.Visible = false;
            this.txtSBalance.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSBalance.Lines = new string[0];
            this.txtSBalance.Location = new System.Drawing.Point(197, 266);
            this.txtSBalance.MaxLength = 32767;
            this.txtSBalance.Name = "txtSBalance";
            this.txtSBalance.PasswordChar = '\0';
            this.txtSBalance.PromptText = "Balance";
            this.txtSBalance.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSBalance.SelectedText = "";
            this.txtSBalance.SelectionLength = 0;
            this.txtSBalance.SelectionStart = 0;
            this.txtSBalance.ShortcutsEnabled = true;
            this.txtSBalance.Size = new System.Drawing.Size(232, 30);
            this.txtSBalance.TabIndex = 17;
            this.txtSBalance.UseSelectable = true;
            this.txtSBalance.WaterMark = "Balance";
            this.txtSBalance.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSBalance.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSBalance_KeyPress);
            // 
            // txtSPhone
            // 
            this.txtSPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSPhone.CustomButton.Image = null;
            this.txtSPhone.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtSPhone.CustomButton.Name = "";
            this.txtSPhone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSPhone.CustomButton.TabIndex = 1;
            this.txtSPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSPhone.CustomButton.UseSelectable = true;
            this.txtSPhone.CustomButton.Visible = false;
            this.txtSPhone.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSPhone.Lines = new string[0];
            this.txtSPhone.Location = new System.Drawing.Point(197, 213);
            this.txtSPhone.MaxLength = 32767;
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.PasswordChar = '\0';
            this.txtSPhone.PromptText = "Phone";
            this.txtSPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSPhone.SelectedText = "";
            this.txtSPhone.SelectionLength = 0;
            this.txtSPhone.SelectionStart = 0;
            this.txtSPhone.ShortcutsEnabled = true;
            this.txtSPhone.Size = new System.Drawing.Size(232, 30);
            this.txtSPhone.TabIndex = 15;
            this.txtSPhone.UseSelectable = true;
            this.txtSPhone.WaterMark = "Phone";
            this.txtSPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSPhone_KeyPress);
            // 
            // txtSAddress
            // 
            this.txtSAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSAddress.CustomButton.Image = null;
            this.txtSAddress.CustomButton.Location = new System.Drawing.Point(178, 2);
            this.txtSAddress.CustomButton.Name = "";
            this.txtSAddress.CustomButton.Size = new System.Drawing.Size(51, 51);
            this.txtSAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSAddress.CustomButton.TabIndex = 1;
            this.txtSAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSAddress.CustomButton.UseSelectable = true;
            this.txtSAddress.CustomButton.Visible = false;
            this.txtSAddress.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSAddress.Lines = new string[0];
            this.txtSAddress.Location = new System.Drawing.Point(197, 138);
            this.txtSAddress.MaxLength = 32767;
            this.txtSAddress.Multiline = true;
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.PasswordChar = '\0';
            this.txtSAddress.PromptText = "Address";
            this.txtSAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSAddress.SelectedText = "";
            this.txtSAddress.SelectionLength = 0;
            this.txtSAddress.SelectionStart = 0;
            this.txtSAddress.ShortcutsEnabled = true;
            this.txtSAddress.Size = new System.Drawing.Size(232, 56);
            this.txtSAddress.TabIndex = 14;
            this.txtSAddress.UseSelectable = true;
            this.txtSAddress.WaterMark = "Address";
            this.txtSAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSName
            // 
            this.txtSName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSName.CustomButton.Image = null;
            this.txtSName.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtSName.CustomButton.Name = "";
            this.txtSName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSName.CustomButton.TabIndex = 1;
            this.txtSName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSName.CustomButton.UseSelectable = true;
            this.txtSName.CustomButton.Visible = false;
            this.txtSName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSName.Lines = new string[0];
            this.txtSName.Location = new System.Drawing.Point(197, 89);
            this.txtSName.MaxLength = 32767;
            this.txtSName.Name = "txtSName";
            this.txtSName.PasswordChar = '\0';
            this.txtSName.PromptText = "Full Name";
            this.txtSName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSName.SelectedText = "";
            this.txtSName.SelectionLength = 0;
            this.txtSName.SelectionStart = 0;
            this.txtSName.ShortcutsEnabled = true;
            this.txtSName.Size = new System.Drawing.Size(232, 30);
            this.txtSName.TabIndex = 13;
            this.txtSName.UseSelectable = true;
            this.txtSName.WaterMark = "Full Name";
            this.txtSName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblmsg.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblmsg.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblmsg.ForeColor = System.Drawing.Color.Red;
            this.lblmsg.Location = new System.Drawing.Point(30, 314);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 0);
            this.lblmsg.TabIndex = 26;
            this.lblmsg.UseCustomBackColor = true;
            this.lblmsg.UseCustomForeColor = true;
            // 
            // AddSupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(465, 465);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtClear);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtSBalance);
            this.Controls.Add(this.txtSPhone);
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.txtSName);
            this.Name = "AddSupp";
            this.Text = "Add Supplier";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddSupp_FormClosing);
            this.Load += new System.EventHandler(this.AddSupp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmAddSupp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmAddSupp;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtClear;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSBalance;
        private MetroFramework.Controls.MetroTextBox txtSPhone;
        private MetroFramework.Controls.MetroTextBox txtSAddress;
        private MetroFramework.Controls.MetroTextBox txtSName;
        private MetroFramework.Controls.MetroLabel lblmsg;
    }
}