namespace WindowsFormsApplication1.Forms.Accounts
{
    partial class AddType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.msmType = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtBack = new MetroFramework.Controls.MetroTile();
            this.mtCreate = new MetroFramework.Controls.MetroTile();
            this.txtType = new MetroFramework.Controls.MetroTextBox();
            this.gvType = new MetroFramework.Controls.MetroGrid();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.lblSuccess = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.msmType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvType)).BeginInit();
            this.SuspendLayout();
            // 
            // msmType
            // 
            this.msmType.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(380, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 25);
            this.metroLabel1.TabIndex = 22;
            this.metroLabel1.Text = "Type : ";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // mtBack
            // 
            this.mtBack.ActiveControl = null;
            this.mtBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtBack.BackColor = System.Drawing.Color.Transparent;
            this.mtBack.Location = new System.Drawing.Point(555, 294);
            this.mtBack.Name = "mtBack";
            this.mtBack.Size = new System.Drawing.Size(89, 91);
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
            // mtCreate
            // 
            this.mtCreate.ActiveControl = null;
            this.mtCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.mtCreate.BackColor = System.Drawing.Color.Transparent;
            this.mtCreate.Location = new System.Drawing.Point(412, 170);
            this.mtCreate.Name = "mtCreate";
            this.mtCreate.Size = new System.Drawing.Size(89, 95);
            this.mtCreate.TabIndex = 24;
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
            // txtType
            // 
            // 
            // 
            // 
            this.txtType.CustomButton.Image = null;
            this.txtType.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtType.CustomButton.Name = "";
            this.txtType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtType.CustomButton.TabIndex = 1;
            this.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtType.CustomButton.UseSelectable = true;
            this.txtType.CustomButton.Visible = false;
            this.txtType.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtType.Lines = new string[0];
            this.txtType.Location = new System.Drawing.Point(458, 129);
            this.txtType.MaxLength = 32767;
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PromptText = "Add new type";
            this.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtType.SelectedText = "";
            this.txtType.SelectionLength = 0;
            this.txtType.SelectionStart = 0;
            this.txtType.ShortcutsEnabled = true;
            this.txtType.Size = new System.Drawing.Size(186, 23);
            this.txtType.TabIndex = 27;
            this.txtType.UseSelectable = true;
            this.txtType.WaterMark = "Add new type";
            this.txtType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gvType
            // 
            this.gvType.AllowUserToAddRows = false;
            this.gvType.AllowUserToOrderColumns = true;
            this.gvType.AllowUserToResizeRows = false;
            this.gvType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvType.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvType.BackgroundColor = System.Drawing.Color.White;
            this.gvType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvType.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.gvType.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gvType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvType.DefaultCellStyle = dataGridViewCellStyle2;
            this.gvType.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvType.EnableHeadersVisualStyles = false;
            this.gvType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gvType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gvType.Location = new System.Drawing.Point(23, 75);
            this.gvType.MultiSelect = false;
            this.gvType.Name = "gvType";
            this.gvType.ReadOnly = true;
            this.gvType.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvType.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gvType.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.gvType.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gvType.RowTemplate.Height = 35;
            this.gvType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvType.Size = new System.Drawing.Size(334, 310);
            this.gvType.TabIndex = 28;
            this.gvType.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvType_CellContentClick);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile2.BackColor = System.Drawing.Color.Transparent;
            this.metroTile2.Location = new System.Drawing.Point(537, 166);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(122, 99);
            this.metroTile2.TabIndex = 29;
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
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroTile3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroTile3.BackColor = System.Drawing.Color.Transparent;
            this.metroTile3.Location = new System.Drawing.Point(397, 286);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(122, 99);
            this.metroTile3.TabIndex = 30;
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
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Transparent;
            this.lblSuccess.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSuccess.ForeColor = System.Drawing.Color.GreenYellow;
            this.lblSuccess.Location = new System.Drawing.Point(434, 65);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(0, 0);
            this.lblSuccess.TabIndex = 51;
            this.lblSuccess.UseCustomBackColor = true;
            this.lblSuccess.UseCustomForeColor = true;
            // 
            // AddType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 421);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.gvType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.mtBack);
            this.Controls.Add(this.mtCreate);
            this.Controls.Add(this.metroLabel1);
            this.Name = "AddType";
            this.Text = "New Type";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AddType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmType;
        private MetroFramework.Controls.MetroTile mtBack;
        private MetroFramework.Controls.MetroTile mtCreate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtType;
        private MetroFramework.Controls.MetroGrid gvType;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroLabel lblSuccess;
    }
}