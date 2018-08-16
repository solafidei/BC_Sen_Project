namespace PremierServiceSolutions.Presentation_Layer
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.premierServicedbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.premierServicedbDataSet = new PremierServiceSolutions.PremierServicedbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // premierServicedbDataSetBindingSource
            // 
            this.premierServicedbDataSetBindingSource.DataSource = this.premierServicedbDataSet;
            this.premierServicedbDataSetBindingSource.Position = 0;
            // 
            // premierServicedbDataSet
            // 
            this.premierServicedbDataSet.DataSetName = "PremierServicedbDataSet";
            this.premierServicedbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "reportDataSet";
            reportDataSource2.Value = this.premierServicedbDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PremierServiceSolutions.Data_Layer.ClientReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(23, 63);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(817, 424);
            this.reportViewer1.TabIndex = 0;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 510);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.premierServicedbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource premierServicedbDataSetBindingSource;
        private PremierServicedbDataSet premierServicedbDataSet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}