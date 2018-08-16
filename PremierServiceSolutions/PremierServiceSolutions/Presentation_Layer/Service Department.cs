using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.Business_Layer;
using MetroFramework.Forms;

namespace PremierServiceSolutions.Presentation_Layer
{
    public partial class Service_Department : MetroForm
    {
        WorkRequest request = new WorkRequest();
        List<WorkRequest> work = new List<WorkRequest>();
        event Display.myDelegate Message;
        string workDuration;
        string workRequest;
        string workRequirement;
        public Service_Department()
        {
            InitializeComponent();
        }

        private void tpReassignJob_Click(object sender, EventArgs e)
        {

        }

        private void Service_Department_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierServicedbDataSet.WorkRequest' table. You can move, or remove it, as needed.
            this.workRequestTableAdapter.Fill(this.premierServicedbDataSet.WorkRequest);
            // TODO: This line of code loads data into the 'premierServicedbDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.premierServicedbDataSet.Employee);
            // TODO: This line of code loads data into the 'premierServicedbDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.premierServicedbDataSet.Service);

            work = request.ReceiveRequest();
           // metroGrid1.AutoGenerateColumns = false;
            metroGrid1.DataSource = work;
            metroGrid2.DataSource = request.UnassignedWork();
            foreach (DataGridViewColumn item in metroGrid1.Columns)
            {
                item.Visible = false;
            }
            metroGrid1.Columns["WorkRequirement"].Visible = true;
            metroGrid1.Columns["WorkDuration"].Visible = true;

            foreach (DataGridViewColumn item in metroGrid2.Columns)
            {
                item.Visible = false;
            }

            metroGrid2.Columns["WorkRequirement"].Visible = true;
            metroGrid2.Columns["WorkDuration"].Visible = true;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtajEmpName.TextLength != 0 && txtajEmpSurname.TextLength != 0)
            {
                WorkRequest submitRequest = new WorkRequest();
               
                submitRequest.Name = txtajEmpName.Text;
                submitRequest.Surname = txtajEmpSurname.Text;
                submitRequest.WorkDuration = workDuration;
                submitRequest.WorkRequirement = workRequest;
                if (submitRequest.SubmitRequest() == true)
                {
                    Message += new Display.myDelegate(Display.Success);
                    Message.Invoke();
                }
                else
                {
                    Message += new Display.myDelegate(Display.Failure);
                    Message.Invoke();
                }
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();
            }
        }

        private void tpViewJobs_Click(object sender, EventArgs e)
        {

        }

        private void btnrjReassignJob_Click(object sender, EventArgs e)
        {
            if (txtrjName.TextLength != 0 && txtrjSurname.TextLength != 0 )
            {
                
                request.WorkRequirement = workRequest;
                request.WorkDuration = workDuration;
                request.Name = txtrjName.Text;
                request.Surname = txtrjSurname.Text;
                if (request.AssignRequest() == true)
                {
                    Message += new Display.myDelegate(Display.Success);
                    Message.Invoke();
                }
                else
                {
                    Message += new Display.myDelegate(Display.Failure);
                    Message.Invoke();
                }
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (txtWorkRequestID.TextLength != 0)
            {
                request.WorkID = int.Parse(txtWorkRequestID.Text);
                if (request.CloseRequest() == true)
                {
                    Message += new Display.myDelegate(Display.Success);
                    Message.Invoke();
                }
                else
                {
                    Message += new Display.myDelegate(Display.Failure);
                    Message.Invoke();
                }
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();
            }
        }

        private void Service_Department_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void metroGrid2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid2.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid2.Rows[selectedrowindex];

                workDuration = Convert.ToString(selectedRow.Cells[1].Value);
                workRequest = Convert.ToString(selectedRow.Cells[2].Value);

            }
            txtWorkDuration.Text = workDuration;
            
        }

        private void tpAssignJob_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.SelectedCells.Count > 0)
            {
                int selectedrowindex = metroGrid1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = metroGrid1.Rows[selectedrowindex];

                workDuration = Convert.ToString(selectedRow.Cells[1].Value);
                workRequest = Convert.ToString(selectedRow.Cells[2].Value);

            }

        }
    }
}
