namespace PremierServiceSolutions.Presentation_Layer
{
    partial class ClientMaintenanceInsertClient
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
            this.cmbClientType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblicFirstName = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MetroFramework.Controls.MetroTextBox();
            this.lblSurname_Business = new MetroFramework.Controls.MetroLabel();
            this.txtLastName_Business = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtTelNum = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtFollowup = new MetroFramework.Controls.MetroTextBox();
            this.txtReport = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtStatus = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.txtAdhocNote = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cmbicContractType = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClientType
            // 
            this.cmbClientType.FormattingEnabled = true;
            this.cmbClientType.ItemHeight = 23;
            this.cmbClientType.Items.AddRange(new object[] {
            "Individual",
            "Business"});
            this.cmbClientType.Location = new System.Drawing.Point(107, 60);
            this.cmbClientType.Name = "cmbClientType";
            this.cmbClientType.Size = new System.Drawing.Size(121, 29);
            this.cmbClientType.TabIndex = 59;
            this.cmbClientType.UseSelectable = true;
            this.cmbClientType.SelectedIndexChanged += new System.EventHandler(this.cmbClientType_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 19);
            this.metroLabel1.TabIndex = 60;
            this.metroLabel1.Text = "Client Type";
            // 
            // lblicFirstName
            // 
            this.lblicFirstName.AutoSize = true;
            this.lblicFirstName.Location = new System.Drawing.Point(24, 103);
            this.lblicFirstName.Name = "lblicFirstName";
            this.lblicFirstName.Size = new System.Drawing.Size(73, 19);
            this.lblicFirstName.TabIndex = 61;
            this.lblicFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            // 
            // 
            // 
            this.txtFirstName.CustomButton.Image = null;
            this.txtFirstName.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtFirstName.CustomButton.Name = "";
            this.txtFirstName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstName.CustomButton.TabIndex = 1;
            this.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstName.CustomButton.UseSelectable = true;
            this.txtFirstName.CustomButton.Visible = false;
            this.txtFirstName.Lines = new string[0];
            this.txtFirstName.Location = new System.Drawing.Point(120, 99);
            this.txtFirstName.MaxLength = 32767;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(108, 23);
            this.txtFirstName.TabIndex = 62;
            this.txtFirstName.UseSelectable = true;
            this.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblSurname_Business
            // 
            this.lblSurname_Business.AutoSize = true;
            this.lblSurname_Business.Location = new System.Drawing.Point(24, 125);
            this.lblSurname_Business.Name = "lblSurname_Business";
            this.lblSurname_Business.Size = new System.Drawing.Size(127, 19);
            this.lblSurname_Business.TabIndex = 63;
            this.lblSurname_Business.Text = "Last Name/ Business";
            // 
            // txtLastName_Business
            // 
            // 
            // 
            // 
            this.txtLastName_Business.CustomButton.Image = null;
            this.txtLastName_Business.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtLastName_Business.CustomButton.Name = "";
            this.txtLastName_Business.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastName_Business.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastName_Business.CustomButton.TabIndex = 1;
            this.txtLastName_Business.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastName_Business.CustomButton.UseSelectable = true;
            this.txtLastName_Business.CustomButton.Visible = false;
            this.txtLastName_Business.Lines = new string[0];
            this.txtLastName_Business.Location = new System.Drawing.Point(120, 125);
            this.txtLastName_Business.MaxLength = 32767;
            this.txtLastName_Business.Name = "txtLastName_Business";
            this.txtLastName_Business.PasswordChar = '\0';
            this.txtLastName_Business.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastName_Business.SelectedText = "";
            this.txtLastName_Business.SelectionLength = 0;
            this.txtLastName_Business.SelectionStart = 0;
            this.txtLastName_Business.Size = new System.Drawing.Size(108, 23);
            this.txtLastName_Business.TabIndex = 64;
            this.txtLastName_Business.UseSelectable = true;
            this.txtLastName_Business.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastName_Business.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(24, 148);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 65;
            this.metroLabel4.Text = "Tel Number";
            // 
            // txtTelNum
            // 
            // 
            // 
            // 
            this.txtTelNum.CustomButton.Image = null;
            this.txtTelNum.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtTelNum.CustomButton.Name = "";
            this.txtTelNum.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelNum.CustomButton.TabIndex = 1;
            this.txtTelNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelNum.CustomButton.UseSelectable = true;
            this.txtTelNum.CustomButton.Visible = false;
            this.txtTelNum.Lines = new string[0];
            this.txtTelNum.Location = new System.Drawing.Point(120, 151);
            this.txtTelNum.MaxLength = 32767;
            this.txtTelNum.Name = "txtTelNum";
            this.txtTelNum.PasswordChar = '\0';
            this.txtTelNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelNum.SelectedText = "";
            this.txtTelNum.SelectionLength = 0;
            this.txtTelNum.SelectionStart = 0;
            this.txtTelNum.Size = new System.Drawing.Size(108, 23);
            this.txtTelNum.TabIndex = 66;
            this.txtTelNum.UseSelectable = true;
            this.txtTelNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 171);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 67;
            this.metroLabel5.Text = "Followup";
            // 
            // txtFollowup
            // 
            // 
            // 
            // 
            this.txtFollowup.CustomButton.Image = null;
            this.txtFollowup.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.txtFollowup.CustomButton.Name = "";
            this.txtFollowup.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFollowup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFollowup.CustomButton.TabIndex = 1;
            this.txtFollowup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFollowup.CustomButton.UseSelectable = true;
            this.txtFollowup.CustomButton.Visible = false;
            this.txtFollowup.Lines = new string[0];
            this.txtFollowup.Location = new System.Drawing.Point(120, 171);
            this.txtFollowup.MaxLength = 32767;
            this.txtFollowup.Name = "txtFollowup";
            this.txtFollowup.PasswordChar = '\0';
            this.txtFollowup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFollowup.SelectedText = "";
            this.txtFollowup.SelectionLength = 0;
            this.txtFollowup.SelectionStart = 0;
            this.txtFollowup.Size = new System.Drawing.Size(108, 23);
            this.txtFollowup.TabIndex = 68;
            this.txtFollowup.UseSelectable = true;
            this.txtFollowup.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFollowup.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReport
            // 
            // 
            // 
            // 
            this.txtReport.CustomButton.Image = null;
            this.txtReport.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtReport.CustomButton.Name = "";
            this.txtReport.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReport.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReport.CustomButton.TabIndex = 1;
            this.txtReport.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReport.CustomButton.UseSelectable = true;
            this.txtReport.CustomButton.Visible = false;
            this.txtReport.Lines = new string[0];
            this.txtReport.Location = new System.Drawing.Point(407, 99);
            this.txtReport.MaxLength = 32767;
            this.txtReport.Name = "txtReport";
            this.txtReport.PasswordChar = '\0';
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReport.SelectedText = "";
            this.txtReport.SelectionLength = 0;
            this.txtReport.SelectionStart = 0;
            this.txtReport.Size = new System.Drawing.Size(100, 23);
            this.txtReport.TabIndex = 69;
            this.txtReport.UseSelectable = true;
            this.txtReport.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReport.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(313, 103);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(50, 19);
            this.metroLabel6.TabIndex = 70;
            this.metroLabel6.Text = "Report";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(313, 124);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(43, 19);
            this.metroLabel7.TabIndex = 71;
            this.metroLabel7.Text = "Status";
            // 
            // txtStatus
            // 
            // 
            // 
            // 
            this.txtStatus.CustomButton.Image = null;
            this.txtStatus.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.txtStatus.CustomButton.Name = "";
            this.txtStatus.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatus.CustomButton.TabIndex = 1;
            this.txtStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatus.CustomButton.UseSelectable = true;
            this.txtStatus.CustomButton.Visible = false;
            this.txtStatus.Lines = new string[0];
            this.txtStatus.Location = new System.Drawing.Point(407, 129);
            this.txtStatus.MaxLength = 32767;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatus.SelectedText = "";
            this.txtStatus.SelectionLength = 0;
            this.txtStatus.SelectionStart = 0;
            this.txtStatus.Size = new System.Drawing.Size(100, 23);
            this.txtStatus.TabIndex = 72;
            this.txtStatus.UseSelectable = true;
            this.txtStatus.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatus.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(290, 171);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(90, 19);
            this.metroLabel8.TabIndex = 73;
            this.metroLabel8.Text = "Contract Type";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(26, 214);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(56, 19);
            this.metroLabel9.TabIndex = 74;
            this.metroLabel9.Text = "Address";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(346, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(59, 59);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(120, 201);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.Size = new System.Drawing.Size(408, 64);
            this.txtAddress.TabIndex = 75;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(26, 271);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(80, 19);
            this.metroLabel10.TabIndex = 76;
            this.metroLabel10.Text = "Adhoc Note";
            // 
            // txtAdhocNote
            // 
            // 
            // 
            // 
            this.txtAdhocNote.CustomButton.Image = null;
            this.txtAdhocNote.CustomButton.Location = new System.Drawing.Point(344, 1);
            this.txtAdhocNote.CustomButton.Name = "";
            this.txtAdhocNote.CustomButton.Size = new System.Drawing.Size(63, 63);
            this.txtAdhocNote.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdhocNote.CustomButton.TabIndex = 1;
            this.txtAdhocNote.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdhocNote.CustomButton.UseSelectable = true;
            this.txtAdhocNote.CustomButton.Visible = false;
            this.txtAdhocNote.Lines = new string[0];
            this.txtAdhocNote.Location = new System.Drawing.Point(120, 271);
            this.txtAdhocNote.MaxLength = 32767;
            this.txtAdhocNote.Multiline = true;
            this.txtAdhocNote.Name = "txtAdhocNote";
            this.txtAdhocNote.PasswordChar = '\0';
            this.txtAdhocNote.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdhocNote.SelectedText = "";
            this.txtAdhocNote.SelectionLength = 0;
            this.txtAdhocNote.SelectionStart = 0;
            this.txtAdhocNote.Size = new System.Drawing.Size(408, 65);
            this.txtAdhocNote.TabIndex = 77;
            this.txtAdhocNote.UseSelectable = true;
            this.txtAdhocNote.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdhocNote.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(225, 358);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 78;
            this.metroButton1.Text = "Insert";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // cmbicContractType
            // 
            this.cmbicContractType.FormattingEnabled = true;
            this.cmbicContractType.ItemHeight = 23;
            this.cmbicContractType.Location = new System.Drawing.Point(407, 161);
            this.cmbicContractType.Name = "cmbicContractType";
            this.cmbicContractType.Size = new System.Drawing.Size(121, 29);
            this.cmbicContractType.TabIndex = 79;
            this.cmbicContractType.UseSelectable = true;
            // 
            // ClientMaintenanceInsertClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 444);
            this.Controls.Add(this.cmbicContractType);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtAdhocNote);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.txtFollowup);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtTelNum);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtLastName_Business);
            this.Controls.Add(this.lblSurname_Business);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblicFirstName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cmbClientType);
            this.Name = "ClientMaintenanceInsertClient";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Insert Client";
            this.Load += new System.EventHandler(this.ClientMaintenanceInsertClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox cmbClientType;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lblicFirstName;
        private MetroFramework.Controls.MetroTextBox txtFirstName;
        private MetroFramework.Controls.MetroLabel lblSurname_Business;
        private MetroFramework.Controls.MetroTextBox txtLastName_Business;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtTelNum;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtFollowup;
        private MetroFramework.Controls.MetroTextBox txtReport;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtStatus;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox txtAdhocNote;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox cmbicContractType;
    }
}