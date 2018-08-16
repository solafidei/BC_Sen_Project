namespace PremierServiceSolutions.Presentation_Layer
{
    partial class ClientMaintenanceUpdateContract
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbicEquipmentModel = new MetroFramework.Controls.MetroComboBox();
            this.cmbicEquipmentName = new MetroFramework.Controls.MetroComboBox();
            this.cmbicEquipmentType = new MetroFramework.Controls.MetroComboBox();
            this.txticServiceAvailable = new MetroFramework.Controls.MetroTextBox();
            this.txticServiceName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtEquipmentModel = new MetroFramework.Controls.MetroTextBox();
            this.txticContractType = new MetroFramework.Controls.MetroTextBox();
            this.txtEquipmentName = new MetroFramework.Controls.MetroTextBox();
            this.txtEquipmentType = new MetroFramework.Controls.MetroTextBox();
            this.cmbContractType = new MetroFramework.Controls.MetroComboBox();
            this.txticServiceLevel = new MetroFramework.Controls.MetroTextBox();
            this.dmServiceLevel = new System.Windows.Forms.DomainUpDown();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtucContractCode = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.premierServicedbDataSet = new PremierServiceSolutions.PremierServicedbDataSet();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new PremierServiceSolutions.PremierServicedbDataSetTableAdapters.ServiceTableAdapter();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(141, 252);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "Update";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbicEquipmentModel
            // 
            this.cmbicEquipmentModel.FormattingEnabled = true;
            this.cmbicEquipmentModel.ItemHeight = 23;
            this.cmbicEquipmentModel.Location = new System.Drawing.Point(155, 207);
            this.cmbicEquipmentModel.Name = "cmbicEquipmentModel";
            this.cmbicEquipmentModel.Size = new System.Drawing.Size(121, 29);
            this.cmbicEquipmentModel.TabIndex = 32;
            this.cmbicEquipmentModel.UseSelectable = true;
            this.cmbicEquipmentModel.Visible = false;
            // 
            // cmbicEquipmentName
            // 
            this.cmbicEquipmentName.FormattingEnabled = true;
            this.cmbicEquipmentName.ItemHeight = 23;
            this.cmbicEquipmentName.Location = new System.Drawing.Point(155, 172);
            this.cmbicEquipmentName.Name = "cmbicEquipmentName";
            this.cmbicEquipmentName.Size = new System.Drawing.Size(121, 29);
            this.cmbicEquipmentName.TabIndex = 31;
            this.cmbicEquipmentName.UseSelectable = true;
            this.cmbicEquipmentName.Visible = false;
            this.cmbicEquipmentName.SelectedIndexChanged += new System.EventHandler(this.cmbicEquipmentName_SelectedIndexChanged);
            // 
            // cmbicEquipmentType
            // 
            this.cmbicEquipmentType.FormattingEnabled = true;
            this.cmbicEquipmentType.ItemHeight = 23;
            this.cmbicEquipmentType.Location = new System.Drawing.Point(155, 137);
            this.cmbicEquipmentType.Name = "cmbicEquipmentType";
            this.cmbicEquipmentType.Size = new System.Drawing.Size(121, 29);
            this.cmbicEquipmentType.TabIndex = 30;
            this.cmbicEquipmentType.UseSelectable = true;
            this.cmbicEquipmentType.Visible = false;
            this.cmbicEquipmentType.SelectedIndexChanged += new System.EventHandler(this.cmbicEquipmentType_SelectedIndexChanged);
            // 
            // txticServiceAvailable
            // 
            // 
            // 
            // 
            this.txticServiceAvailable.CustomButton.Image = null;
            this.txticServiceAvailable.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txticServiceAvailable.CustomButton.Name = "";
            this.txticServiceAvailable.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txticServiceAvailable.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txticServiceAvailable.CustomButton.TabIndex = 1;
            this.txticServiceAvailable.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txticServiceAvailable.CustomButton.UseSelectable = true;
            this.txticServiceAvailable.CustomButton.Visible = false;
            this.txticServiceAvailable.Lines = new string[0];
            this.txticServiceAvailable.Location = new System.Drawing.Point(155, 95);
            this.txticServiceAvailable.MaxLength = 32767;
            this.txticServiceAvailable.Name = "txticServiceAvailable";
            this.txticServiceAvailable.PasswordChar = '\0';
            this.txticServiceAvailable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txticServiceAvailable.SelectedText = "";
            this.txticServiceAvailable.SelectionLength = 0;
            this.txticServiceAvailable.SelectionStart = 0;
            this.txticServiceAvailable.Size = new System.Drawing.Size(121, 23);
            this.txticServiceAvailable.TabIndex = 29;
            this.txticServiceAvailable.UseSelectable = true;
            this.txticServiceAvailable.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txticServiceAvailable.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txticServiceName
            // 
            // 
            // 
            // 
            this.txticServiceName.CustomButton.Image = null;
            this.txticServiceName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txticServiceName.CustomButton.Name = "";
            this.txticServiceName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txticServiceName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txticServiceName.CustomButton.TabIndex = 1;
            this.txticServiceName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txticServiceName.CustomButton.UseSelectable = true;
            this.txticServiceName.CustomButton.Visible = false;
            this.txticServiceName.Lines = new string[0];
            this.txticServiceName.Location = new System.Drawing.Point(155, 35);
            this.txticServiceName.MaxLength = 32767;
            this.txticServiceName.Name = "txticServiceName";
            this.txticServiceName.PasswordChar = '\0';
            this.txticServiceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txticServiceName.SelectedText = "";
            this.txticServiceName.SelectionLength = 0;
            this.txticServiceName.SelectionStart = 0;
            this.txticServiceName.Size = new System.Drawing.Size(121, 23);
            this.txticServiceName.TabIndex = 27;
            this.txticServiceName.UseSelectable = true;
            this.txticServiceName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txticServiceName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(30, 209);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(114, 19);
            this.metroLabel11.TabIndex = 25;
            this.metroLabel11.Text = "Equipment Model";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(30, 178);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(112, 19);
            this.metroLabel9.TabIndex = 24;
            this.metroLabel9.Text = "Equipment Name";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(30, 147);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(103, 19);
            this.metroLabel7.TabIndex = 23;
            this.metroLabel7.Text = "Equipment Type";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(30, 95);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(108, 19);
            this.metroLabel6.TabIndex = 22;
            this.metroLabel6.Text = "Service Available";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 63);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(84, 19);
            this.metroLabel4.TabIndex = 21;
            this.metroLabel4.Text = "Service Level";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Service Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 19;
            this.metroLabel1.Text = "Contract Type";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtEquipmentModel);
            this.metroPanel1.Controls.Add(this.txticContractType);
            this.metroPanel1.Controls.Add(this.txtEquipmentName);
            this.metroPanel1.Controls.Add(this.txtEquipmentType);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.cmbicEquipmentModel);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.cmbicEquipmentName);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.cmbicEquipmentType);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txticServiceAvailable);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.txticServiceName);
            this.metroPanel1.Controls.Add(this.cmbContractType);
            this.metroPanel1.Controls.Add(this.txticServiceLevel);
            this.metroPanel1.Controls.Add(this.dmServiceLevel);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(93, 107);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(331, 278);
            this.metroPanel1.TabIndex = 69;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.Visible = false;
            // 
            // txtEquipmentModel
            // 
            // 
            // 
            // 
            this.txtEquipmentModel.CustomButton.Image = null;
            this.txtEquipmentModel.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtEquipmentModel.CustomButton.Name = "";
            this.txtEquipmentModel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEquipmentModel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEquipmentModel.CustomButton.TabIndex = 1;
            this.txtEquipmentModel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEquipmentModel.CustomButton.UseSelectable = true;
            this.txtEquipmentModel.CustomButton.Visible = false;
            this.txtEquipmentModel.Lines = new string[0];
            this.txtEquipmentModel.Location = new System.Drawing.Point(155, 207);
            this.txtEquipmentModel.MaxLength = 32767;
            this.txtEquipmentModel.Name = "txtEquipmentModel";
            this.txtEquipmentModel.PasswordChar = '\0';
            this.txtEquipmentModel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquipmentModel.SelectedText = "";
            this.txtEquipmentModel.SelectionLength = 0;
            this.txtEquipmentModel.SelectionStart = 0;
            this.txtEquipmentModel.Size = new System.Drawing.Size(121, 23);
            this.txtEquipmentModel.TabIndex = 72;
            this.txtEquipmentModel.UseSelectable = true;
            this.txtEquipmentModel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEquipmentModel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txticContractType
            // 
            // 
            // 
            // 
            this.txticContractType.CustomButton.Image = null;
            this.txticContractType.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txticContractType.CustomButton.Name = "";
            this.txticContractType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txticContractType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txticContractType.CustomButton.TabIndex = 1;
            this.txticContractType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txticContractType.CustomButton.UseSelectable = true;
            this.txticContractType.CustomButton.Visible = false;
            this.txticContractType.Lines = new string[0];
            this.txticContractType.Location = new System.Drawing.Point(155, 3);
            this.txticContractType.MaxLength = 32767;
            this.txticContractType.Name = "txticContractType";
            this.txticContractType.PasswordChar = '\0';
            this.txticContractType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txticContractType.SelectedText = "";
            this.txticContractType.SelectionLength = 0;
            this.txticContractType.SelectionStart = 0;
            this.txticContractType.Size = new System.Drawing.Size(121, 23);
            this.txticContractType.TabIndex = 33;
            this.txticContractType.UseSelectable = true;
            this.txticContractType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txticContractType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txticContractType.Enter += new System.EventHandler(this.txticContractType_Enter);
            // 
            // txtEquipmentName
            // 
            // 
            // 
            // 
            this.txtEquipmentName.CustomButton.Image = null;
            this.txtEquipmentName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtEquipmentName.CustomButton.Name = "";
            this.txtEquipmentName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEquipmentName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEquipmentName.CustomButton.TabIndex = 1;
            this.txtEquipmentName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEquipmentName.CustomButton.UseSelectable = true;
            this.txtEquipmentName.CustomButton.Visible = false;
            this.txtEquipmentName.Lines = new string[0];
            this.txtEquipmentName.Location = new System.Drawing.Point(155, 172);
            this.txtEquipmentName.MaxLength = 32767;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.PasswordChar = '\0';
            this.txtEquipmentName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquipmentName.SelectedText = "";
            this.txtEquipmentName.SelectionLength = 0;
            this.txtEquipmentName.SelectionStart = 0;
            this.txtEquipmentName.Size = new System.Drawing.Size(121, 23);
            this.txtEquipmentName.TabIndex = 71;
            this.txtEquipmentName.UseSelectable = true;
            this.txtEquipmentName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEquipmentName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEquipmentType
            // 
            // 
            // 
            // 
            this.txtEquipmentType.CustomButton.Image = null;
            this.txtEquipmentType.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtEquipmentType.CustomButton.Name = "";
            this.txtEquipmentType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEquipmentType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEquipmentType.CustomButton.TabIndex = 1;
            this.txtEquipmentType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEquipmentType.CustomButton.UseSelectable = true;
            this.txtEquipmentType.CustomButton.Visible = false;
            this.txtEquipmentType.Lines = new string[0];
            this.txtEquipmentType.Location = new System.Drawing.Point(155, 137);
            this.txtEquipmentType.MaxLength = 32767;
            this.txtEquipmentType.Name = "txtEquipmentType";
            this.txtEquipmentType.PasswordChar = '\0';
            this.txtEquipmentType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEquipmentType.SelectedText = "";
            this.txtEquipmentType.SelectionLength = 0;
            this.txtEquipmentType.SelectionStart = 0;
            this.txtEquipmentType.Size = new System.Drawing.Size(121, 23);
            this.txtEquipmentType.TabIndex = 70;
            this.txtEquipmentType.UseSelectable = true;
            this.txtEquipmentType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEquipmentType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEquipmentType.Enter += new System.EventHandler(this.txtEquipmentType_Enter);
            // 
            // cmbContractType
            // 
            this.cmbContractType.FormattingEnabled = true;
            this.cmbContractType.ItemHeight = 23;
            this.cmbContractType.Location = new System.Drawing.Point(155, 3);
            this.cmbContractType.Name = "cmbContractType";
            this.cmbContractType.Size = new System.Drawing.Size(121, 29);
            this.cmbContractType.TabIndex = 75;
            this.cmbContractType.UseSelectable = true;
            this.cmbContractType.Visible = false;
            // 
            // txticServiceLevel
            // 
            // 
            // 
            // 
            this.txticServiceLevel.CustomButton.Image = null;
            this.txticServiceLevel.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.txticServiceLevel.CustomButton.Name = "";
            this.txticServiceLevel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txticServiceLevel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txticServiceLevel.CustomButton.TabIndex = 1;
            this.txticServiceLevel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txticServiceLevel.CustomButton.UseSelectable = true;
            this.txticServiceLevel.CustomButton.Visible = false;
            this.txticServiceLevel.Lines = new string[0];
            this.txticServiceLevel.Location = new System.Drawing.Point(155, 63);
            this.txticServiceLevel.MaxLength = 32767;
            this.txticServiceLevel.Name = "txticServiceLevel";
            this.txticServiceLevel.PasswordChar = '\0';
            this.txticServiceLevel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txticServiceLevel.SelectedText = "";
            this.txticServiceLevel.SelectionLength = 0;
            this.txticServiceLevel.SelectionStart = 0;
            this.txticServiceLevel.Size = new System.Drawing.Size(120, 23);
            this.txticServiceLevel.TabIndex = 74;
            this.txticServiceLevel.UseSelectable = true;
            this.txticServiceLevel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txticServiceLevel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txticServiceLevel.Enter += new System.EventHandler(this.txticServiceLevel_Enter);
            // 
            // dmServiceLevel
            // 
            this.dmServiceLevel.Location = new System.Drawing.Point(155, 65);
            this.dmServiceLevel.Name = "dmServiceLevel";
            this.dmServiceLevel.Size = new System.Drawing.Size(120, 20);
            this.dmServiceLevel.TabIndex = 73;
            this.dmServiceLevel.Visible = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(103, 63);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "Contract Code";
            // 
            // txtucContractCode
            // 
            // 
            // 
            // 
            this.txtucContractCode.CustomButton.Image = null;
            this.txtucContractCode.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.txtucContractCode.CustomButton.Name = "";
            this.txtucContractCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtucContractCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtucContractCode.CustomButton.TabIndex = 1;
            this.txtucContractCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtucContractCode.CustomButton.UseSelectable = true;
            this.txtucContractCode.CustomButton.Visible = false;
            this.txtucContractCode.Lines = new string[0];
            this.txtucContractCode.Location = new System.Drawing.Point(234, 64);
            this.txtucContractCode.MaxLength = 32767;
            this.txtucContractCode.Name = "txtucContractCode";
            this.txtucContractCode.PasswordChar = '\0';
            this.txtucContractCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtucContractCode.SelectedText = "";
            this.txtucContractCode.SelectionLength = 0;
            this.txtucContractCode.SelectionStart = 0;
            this.txtucContractCode.Size = new System.Drawing.Size(75, 23);
            this.txtucContractCode.TabIndex = 71;
            this.txtucContractCode.UseSelectable = true;
            this.txtucContractCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtucContractCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(339, 64);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 72;
            this.metroButton2.Text = "Find";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // premierServicedbDataSet
            // 
            this.premierServicedbDataSet.DataSetName = "PremierServicedbDataSet";
            this.premierServicedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            this.serviceBindingSource.DataSource = this.premierServicedbDataSet;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // ClientMaintenanceUpdateContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 521);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.txtucContractCode);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel1);
            this.Name = "ClientMaintenanceUpdateContract";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Update Contract";
            this.Load += new System.EventHandler(this.ClientMaintenanceUpdateContract_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbicEquipmentModel;
        private MetroFramework.Controls.MetroComboBox cmbicEquipmentName;
        private MetroFramework.Controls.MetroComboBox cmbicEquipmentType;
        private MetroFramework.Controls.MetroTextBox txticServiceAvailable;
        private MetroFramework.Controls.MetroTextBox txticServiceName;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txticContractType;
        private MetroFramework.Controls.MetroTextBox txtEquipmentType;
        private MetroFramework.Controls.MetroTextBox txtEquipmentName;
        private MetroFramework.Controls.MetroTextBox txtEquipmentModel;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTextBox txtucContractCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DomainUpDown dmServiceLevel;
        private PremierServicedbDataSet premierServicedbDataSet;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private PremierServicedbDataSetTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private MetroFramework.Controls.MetroTextBox txticServiceLevel;
        private MetroFramework.Controls.MetroComboBox cmbContractType;
    }
}