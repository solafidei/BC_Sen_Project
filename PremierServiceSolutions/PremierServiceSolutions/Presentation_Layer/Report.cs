using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using PremierServiceSolutions.Data_Layer;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using System.Threading;

namespace PremierServiceSolutions.Presentation_Layer
{
    public partial class Report : MetroForm
    {
        
        DataHandler data = new DataHandler();
        string clientid = null;
        string clientType = null;
        BackgroundWorker bWorker;

        public Report(string pclientType,string clientIdentifier)
        {
            clientid = clientIdentifier;
            clientType = pclientType;
            InitializeComponent();
            
        }
        public Report()
        {
            InitializeComponent();
        }

        delegate void UpdateReportCallback(ReportDataSource rds);
        private void UpdateReport(ReportDataSource rds)
        {
            if (this.reportViewer1.InvokeRequired)
            {
                UpdateReportCallback d = new UpdateReportCallback(UpdateReport);
                this.Invoke(d, new object[] { rds });
            }
            else
            {
                reportViewer1.LocalReport.DataSources.Add(rds);
                reportViewer1.RefreshReport();
                reportViewer1.Visible = true;
            }
        }

        private void Report_Load(object sender, EventArgs e)
        {
            bWorker = new BackgroundWorker();
            bWorker.DoWork += new DoWorkEventHandler(Bworker_DoWork);


            reportViewer1.LocalReport.DataSources.Clear();
            new Thread(new ThreadStart(GetReportData)).Start();
            this.reportViewer1.RefreshReport();
        }

        private void Bworker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                    
                bWorker.ReportProgress(i);
                
                if (bWorker.CancellationPending)
                {                    
                    e.Cancel = true;
                    bWorker.ReportProgress(0);
                    return;
                }
            }
        }


        private void GetReportData()
        {
            
            ReportDataSource rds = new ReportDataSource("reportDataSet", data.GetReport(clientType,clientid));
            UpdateReport(rds);
        }
    }
}
