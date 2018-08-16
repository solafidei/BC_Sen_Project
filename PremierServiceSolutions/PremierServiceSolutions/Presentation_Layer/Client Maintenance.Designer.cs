namespace PremierServiceSolutions.Presentation_Layer
{
    partial class Client_Maintenance
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
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mtUpdateClient = new MetroFramework.Controls.MetroTile();
            this.mtInsertContract = new MetroFramework.Controls.MetroTile();
            this.mtUpdateContract = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.clientDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
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
            // msmMain
            // 
            this.msmMain.Owner = this;
            this.msmMain.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(93, 144);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(90, 66);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Insert\r\nClient";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mtUpdateClient
            // 
            this.mtUpdateClient.ActiveControl = null;
            this.mtUpdateClient.Location = new System.Drawing.Point(189, 144);
            this.mtUpdateClient.Name = "mtUpdateClient";
            this.mtUpdateClient.Size = new System.Drawing.Size(85, 66);
            this.mtUpdateClient.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtUpdateClient.TabIndex = 3;
            this.mtUpdateClient.Text = "Update\r\nClient";
            this.mtUpdateClient.UseSelectable = true;
            this.mtUpdateClient.Click += new System.EventHandler(this.mtUpdateClient_Click);
            // 
            // mtInsertContract
            // 
            this.mtInsertContract.ActiveControl = null;
            this.mtInsertContract.Location = new System.Drawing.Point(93, 216);
            this.mtInsertContract.Name = "mtInsertContract";
            this.mtInsertContract.Size = new System.Drawing.Size(90, 65);
            this.mtInsertContract.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtInsertContract.TabIndex = 4;
            this.mtInsertContract.Text = "Insert\r\nContract";
            this.mtInsertContract.UseSelectable = true;
            this.mtInsertContract.Click += new System.EventHandler(this.mtInsertContract_Click);
            // 
            // mtUpdateContract
            // 
            this.mtUpdateContract.ActiveControl = null;
            this.mtUpdateContract.Location = new System.Drawing.Point(189, 216);
            this.mtUpdateContract.Name = "mtUpdateContract";
            this.mtUpdateContract.Size = new System.Drawing.Size(85, 65);
            this.mtUpdateContract.Style = MetroFramework.MetroColorStyle.Purple;
            this.mtUpdateContract.TabIndex = 5;
            this.mtUpdateContract.Text = "Update\r\nContract";
            this.mtUpdateContract.UseSelectable = true;
            this.mtUpdateContract.Click += new System.EventHandler(this.mtUpdateContract_Click);
            // 
            // Client_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 432);
            this.Controls.Add(this.mtUpdateContract);
            this.Controls.Add(this.mtInsertContract);
            this.Controls.Add(this.mtUpdateClient);
            this.Controls.Add(this.metroTile1);
            this.Name = "Client_Maintenance";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Client_Maintenance";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_Maintenance_FormClosed);
            this.Load += new System.EventHandler(this.Client_Maintenance_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.clientDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PremierServicedbDataSet premierServicedbDataSet;
        private System.Windows.Forms.BindingSource clientTypeBindingSource;
        private PremierServicedbDataSetTableAdapters.ClientTypeTableAdapter clientTypeTableAdapter;
        private System.Windows.Forms.BindingSource clientDetailBindingSource;
        private PremierServicedbDataSetTableAdapters.ClientDetailTableAdapter clientDetailTableAdapter;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTile mtUpdateContract;
        private MetroFramework.Controls.MetroTile mtInsertContract;
        private MetroFramework.Controls.MetroTile mtUpdateClient;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}