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
using System.Data.SqlClient;
using System.Data.Sql;
using PremierServiceSolutions.Data_Layer;
using MetroFramework.Forms;
using System.Threading;

namespace PremierServiceSolutions.Presentation_Layer
{
    public partial class Call_Centre : MetroForm
    {
        private Call call = new Call();
        private ClientDetail details = new ClientDetail();
        Agreement contract = new Agreement();
        WorkRequest submitRequest = new WorkRequest();
        Action<Control.ControlCollection> func = null;
        event Display.myDelegate Message;
        string ename;
        string esurname;
        string clientIdentifier;
        string clientType;
        int counter;
        public delegate void ClickButton();

        private HelpProvider hlpProvider;

        private void CreateHelpProvider()
        {
            hlpProvider = new System.Windows.Forms.HelpProvider();
            hlpProvider.SetShowHelp(txtClientCode, true);
            hlpProvider.SetHelpString(txtClientCode, "Enter a valid text here.");

            hlpProvider.SetShowHelp(btnFind, true);
            hlpProvider.SetHelpString(btnFind, "Click this button.");

            // Help file
            hlpProvider.HelpNamespace = "helpFile.chm";

            hlpProvider.SetHelpNavigator(cmbClientType, HelpNavigator.TableOfContents);

        }

        public Call_Centre(string name, string surname, string clientIdentifier, string clientType)
        {
            ename = name;
            esurname = surname;
            this.clientIdentifier = clientIdentifier;
            this.clientType = clientType;
            counter = 1;         
            
            InitializeComponent();
            

        }
        public Call_Centre(string name, string surname)
        {
            ename = name;
            esurname = surname;
            InitializeComponent();
        }

        public Call_Centre()
        {
            InitializeComponent();           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void Call_Centre_Load(object sender, EventArgs e)
        {
            if (clientIdentifier != null)
            {
                btnFind.PerformClick();
            }  
                btnEnd.Visible = false;
            toolTip1.SetToolTip(this.btnFind, "Finds a Client within the database");
        }

        

        private void tcCallCentre_Click(object sender, EventArgs e)
        {
            
        }

        private void tcCallCentre_Selected(object sender, TabControlEventArgs e)
        {
            
            if (tcCallCentre.SelectedTab == tcCallCentre.TabPages["tpViewAgreement"])
            {
                if (txtClientCode.Text != string.Empty)
                {
                    List<string> list = new List<string>();

                    list = contract.ViewAgreement(txtFirstName.Text,txtLastName_Business.Text,txtLastName_Business.Text,cmbClientType.Text);
                    contract.ContractType = list[0];
                    contract.ServiceName = list[1];
                    contract.ServiceLevel = list[2];
                    contract.ServiceAvailability = list[3];
                    contract.EquipmentName = list[4];
                    contract.EquipmentModel = list[5];

                    txtContractType.Text = contract.ContractType;
                    txtServiceName.Text = contract.ServiceName;
                    txtServiceLevel.Text = contract.ServiceLevel;
                    txtServiceAvailable.Text = contract.ServiceAvailability;
                    txtEquipmentName.Text = contract.EquipmentName;
                    txtEquipmentModel.Text = contract.EquipmentModel;
                }
                else
                {
                    Message += new Display.myDelegate(Display.Error);
                    Message.Invoke();
                    tcCallCentre.SelectedIndex = 0;

                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

        }
        private void ClearTextBoxes()
        {
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void cmbClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
           ClearTextBoxes();
            if (counter != 1)
            {
                clientType = null;
                clientIdentifier = null;

            }

            panel1.Visible = false;
            panel2.Visible = false;
            btnAccept.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            btnReport.Visible = false;
            if (clientType == null)
            {
                clientType = cmbClientType.Text;

            }
            
            if (clientType == "Business")
            {
               // txtName.Visible = false;
               // lblncname.Visible = false;
                lblfcName.Visible = false;
                txtFirstName.Visible = false;
                lblfcSurnameBusiness.Text = "Business Name";
               // lblsurname_business.Text = "Business Name";
            }
            else
            {
              //  txtName.Visible = true;
               // lblncname.Visible = true;
                lblfcName.Visible = true;
                txtFirstName.Visible = true;
               // lblsurname_business.Text = "Last Name";
                lblfcSurnameBusiness.Text = "Last Name";
            }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (clientType != string.Empty)
            {
                btnAccept.Visible = false;
                btnEnd.Visible = true;
                call.ReceiveTime = DateTime.Now;
                lblTimer.Visible = true;
                timer1.Enabled = true;
                timer1.Start();
                
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();
                
            }

        }
        private void btnEnd_Click(object sender, EventArgs e)
        {

            call.EndTime = DateTime.Now;
            call.EmpName = ename;
            call.EmpSurname = esurname;
            call.Reason = cmbReason.Text;
            
            call.ClientType = cmbClientType.Text;

            if (txtWorkRequirement.Text != string.Empty || cmbReason.Text != string.Empty)
            {
                
                submitRequest.WorkRequirement = txtWorkRequirement.Text;
                submitRequest.WorkDuration = "Pending";
                submitRequest.Name = ename;
                submitRequest.Surname = esurname;
            }
                if (cmbClientType.Text == "Individual")
            {
                call.CustomerName = txtFirstName.Text;
                call.CustomerSurname = txtLastName_Business.Text;
                call.BusinessName = txtLastName_Business.Text;

            }
            else
            {
                call.CustomerName = txtLastName_Business.Text;
                call.CustomerSurname = txtLastName_Business.Text;
                call.BusinessName = txtLastName_Business.Text;
                call.EmpName = ename;
                call.EmpSurname = esurname;
                call.BusinessName = txtLastName_Business.Text;

            }

            if (call.InitiateCall() == true && submitRequest.SubmitRequest() == true)
            {
                timer1.Stop();
                lblTimer.Visible = false;
                Message += new Display.myDelegate(Display.Success);
                Message.Invoke();
                ClearTextBoxes();
                btnEnd.Visible = false;
                panel1.Visible = false;
                panel2.Visible = false;
                btnReport.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;               
                
            }
            else
            {
                Message += new Display.myDelegate(Display.Failure);
                Message.Invoke();
            }
            
        }
        public static void AppendText(ref RichTextBox rtb,Color color)
        {
            string text = "★";
            rtb.SelectionStart = rtb.TextLength;
            rtb.SelectionLength = 0;
            rtb.SelectionColor = color;
            rtb.AppendText(text);
            rtb.SelectionColor = rtb.ForeColor;
        }
        public static void StatusColor(ref RichTextBox rtb, ClientDetail.eClientStatus status)
        {
            rtb.Text = "";
            if (status.HasFlag(ClientDetail.eClientStatus.Deteriorating))
            {
                AppendText(ref rtb, Color.Yellow);
            }
            if (status.HasFlag(ClientDetail.eClientStatus.Dissatisfied))
            {
                AppendText(ref rtb, Color.Red);
            }
            if (status.HasFlag(ClientDetail.eClientStatus.Important))
            {
                AppendText(ref rtb, Color.Blue);
            }
            if (status.HasFlag(ClientDetail.eClientStatus.Monitored))
            {
                AppendText(ref rtb, Color.Purple);
            }
            if (status.HasFlag(ClientDetail.eClientStatus.New))
            {
                AppendText(ref rtb, Color.Orange);
            }
            if (status.HasFlag(ClientDetail.eClientStatus.Satisfied))
            {
                AppendText(ref rtb, Color.Green);
            }

        }

        private void btnFind_Click(object sender, EventArgs e)
        {            
            cmbClientType.Text = clientType;
            if (clientIdentifier == null)
            {
                clientIdentifier = txtClientCode.Text;
            }
            else
            {
                txtClientCode.Text = clientIdentifier;
            }
            
            Thread.Sleep(1000);
            
            if (txtClientCode.Text != string.Empty)
            {
                ClientDetail.eClientStatus status = details.GetStatus(txtClientCode.Text);
                StatusColor(ref richTextBox1, status);
                if (cmbClientType.Text == "Individual")
                {
                    List<string> list = details.FindClient(cmbClientType.Text, txtClientCode.Text);
                   // MessageBox.Show("individual");
                    Individual clientDetail = new Individual();
                    clientDetail.FirstName = list[0];
                    clientDetail.LastName = list[1];
                    clientDetail.TelNumber = int.Parse(list[2]);
                    clientDetail.Address = list[3];
                    clientDetail.AdhocNote = list[4];
                    clientDetail.ClientReport = list[5];
                    clientDetail.ClientStatus = list[6];
                    clientDetail.ClientFollowup = list[7];

                    txtFirstName.Text = clientDetail.FirstName;
                    txtLastName_Business.Text = clientDetail.LastName;
                    txtTelNum.Text = clientDetail.TelNumber.ToString();
                    txtAddress.Text = clientDetail.Address;
                    txtAdhocNote.Text = clientDetail.AdhocNote;
                    txtReport.Text = clientDetail.ClientReport;
                    txtStatus.Text = clientDetail.ClientStatus;
                    txtFollowup.Text = clientDetail.ClientFollowup;
                }
                else
                {
                    List<string> list = details.FindClient(cmbClientType.Text, txtClientCode.Text);
                   // MessageBox.Show("business");
                    Business clientDetail = new Business();
                    clientDetail.BusinessName = list[0];
                    clientDetail.BusinessAddress = list[1];
                    clientDetail.TelNumber = int.Parse(list[2]);
                    clientDetail.AdhocNote = list[3];
                    clientDetail.ClientReport = list[4];
                    clientDetail.ClientStatus = list[5];
                    clientDetail.ClientFollowup = list[6];

                    txtLastName_Business.Text = clientDetail.BusinessName;
                    txtTelNum.Text = clientDetail.TelNumber.ToString();
                    txtAddress.Text = clientDetail.BusinessAddress;
                    txtAdhocNote.Text = clientDetail.AdhocNote;
                    txtReport.Text = clientDetail.ClientReport;
                    txtStatus.Text = clientDetail.ClientStatus;
                    txtFollowup.Text = clientDetail.ClientFollowup;
                }
                btnAccept.Visible = true;
                panel1.Visible = true;
                panel2.Visible = true;
                richTextBox2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                btnReport.Visible = true;
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtClientCode_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        int second = 0;
        int minute;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            
            if (second == 60)
            {
                minute++;
                second = second - 60;
                lblTimer.Text = minute.ToString() + " Minutes " + second.ToString() + " Seconds";               

            }
            lblTimer.Text = minute.ToString() + " Minutes " + second.ToString() + " Seconds";

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report(cmbClientType.Text,txtClientCode.Text);
            report.Show();
        }

        private void Call_Centre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void cmbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReason.Text == string.Empty)
            {
                MessageBox.Show("Please select a valid reason for call");
            }
        }
    }
}
