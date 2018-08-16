namespace PremierServiceSolutions.Presentation_Layer
{
    partial class Client_Satisfaction
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
            this.clientDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premierServicedbDataSet = new PremierServiceSolutions.PremierServicedbDataSet();
            this.clientTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTypeTableAdapter = new PremierServiceSolutions.PremierServicedbDataSetTableAdapters.ClientTypeTableAdapter();
            this.clientDetailTableAdapter = new PremierServiceSolutions.PremierServicedbDataSetTableAdapters.ClientDetailTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbClientType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDetailBindingSource
            // 
            this.clientDetailBindingSource.DataMember = "ClientDetail";
            this.clientDetailBindingSource.DataSource = this.premierServicedbDataSet;
            // 
            // premierServicedbDataSet
            // 
            this.premierServicedbDataSet.DataSetName = "PremierServicedbDataSet";
            this.premierServicedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientTypeBindingSource
            // 
            this.clientTypeBindingSource.DataMember = "ClientType";
            this.clientTypeBindingSource.DataSource = this.premierServicedbDataSet;
            // 
            // clientTypeTableAdapter
            // 
            this.clientTypeTableAdapter.ClearBeforeFill = true;
            // 
            // clientDetailTableAdapter
            // 
            this.clientDetailTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(23, 117);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(492, 302);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(565, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 38);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Please Select the Client\r\nyou would like to call";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(593, 128);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Call Client";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbClientType
            // 
            this.cmbClientType.FormattingEnabled = true;
            this.cmbClientType.ItemHeight = 23;
            this.cmbClientType.Items.AddRange(new object[] {
            "Individual",
            "Business"});
            this.cmbClientType.Location = new System.Drawing.Point(145, 74);
            this.cmbClientType.Name = "cmbClientType";
            this.cmbClientType.Size = new System.Drawing.Size(121, 29);
            this.cmbClientType.TabIndex = 15;
            this.cmbClientType.UseSelectable = true;
            this.cmbClientType.SelectedIndexChanged += new System.EventHandler(this.cmbClientType_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Client Type";
            // 
            // Client_Satisfaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 493);
            this.Controls.Add(this.cmbClientType);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Client_Satisfaction";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Client_Satisfaction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_Satisfaction_FormClosed);
            this.Load += new System.EventHandler(this.Client_Satisfaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PremierServicedbDataSet premierServicedbDataSet;
        private System.Windows.Forms.BindingSource clientTypeBindingSource;
        private PremierServicedbDataSetTableAdapters.ClientTypeTableAdapter clientTypeTableAdapter;
        private System.Windows.Forms.BindingSource clientDetailBindingSource;
        private PremierServicedbDataSetTableAdapters.ClientDetailTableAdapter clientDetailTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbClientType;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}