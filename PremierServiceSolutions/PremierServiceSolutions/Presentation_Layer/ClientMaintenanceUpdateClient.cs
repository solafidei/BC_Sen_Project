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
using PremierServiceSolutions.Business_Layer;

namespace PremierServiceSolutions.Presentation_Layer
{
    public partial class ClientMaintenanceUpdateClient : MetroForm
    {
        private Business_Layer.Business business = new Business_Layer.Business();
        private Business_Layer.Individual individual = new Business_Layer.Individual();
        private ClientDetail detail = new ClientDetail();
        List<Equipment> equip = new List<Equipment>();
        private Equipment equipment = new Equipment();
        List<string> contractType = new List<string>();
        List<string> equipmentName = new List<string>();
        List<string> equipmentModel = new List<string>();
        BindingSource nameSource = new BindingSource();
        BindingSource nameSource2 = new BindingSource();
        private Agreement contract = new Agreement();
        Action<Control.ControlCollection> func = null;
        event Display.myDelegate Message;
        string val = null;

        public ClientMaintenanceUpdateClient(string theme)
        {
            InitializeComponent();
            val = theme;

        }
        public ClientMaintenanceUpdateClient()
        {
            InitializeComponent();
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

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
             
            if (cmbucClientType.Text != string.Empty || txtuFirstName.Text != string.Empty || txtuLastName_Business.Text != string.Empty || txtuTelNum.Text != string.Empty || txtuFollowup.Text != string.Empty ||
                txtuReport.Text != string.Empty || txtuStatus.Text != string.Empty || txtuAddress.Text != string.Empty || txtuAdhocNote.Text != string.Empty)
            {
                if (cmbucClientType.Text == "Business")
                {
                    lblucSurnameBusiness.Text = "Business Name";
                    business.BusinessName = txtuLastName_Business.Text;
                    business.TelNumber = int.Parse(txtuTelNum.Text);
                    business.BusinessAddress = txtuAddress.Text;
                    business.AdhocNote = txtuAdhocNote.Text;
                    business.ClientType = cmbucClientType.Text;
                    business.ContractType = cmbucContractType.Text;
                    business.ClientFollowup = txtuFollowup.Text;
                    business.ClientReport = txtuReport.Text;
                    business.ClientStatus = txtuStatus.Text;
                    if (business.UpdateClientDetails() == true)
                    {

                        Message += new Display.myDelegate(Display.Success);
                        Message.Invoke();
                        ClearTextBoxes();
                        metroPanel1.Visible = false;




                    }
                    else
                    {
                        Message += new Display.myDelegate(Display.Failure);
                        Message.Invoke();
                    }
                }
                else
                {
                    
                    individual.FirstName = txtuFirstName.Text;
                    individual.LastName = txtuLastName_Business.Text;
                    individual.TelNumber = int.Parse(txtuTelNum.Text);
                    individual.ClientFollowup = txtuFollowup.Text;
                    individual.ClientReport = txtuReport.Text;
                    individual.ClientStatus = txtuStatus.Text;
                    individual.ContractType = txtContractType.Text;
                    individual.Address = txtuAddress.Text;
                    individual.AdhocNote = txtuAdhocNote.Text;
                    individual.ClientIdentifier = txtClientCode.Text;
                    individual.ClientType = cmbucClientType.Text;

                    if (individual.UpdateClientDetails() == true)
                    {
                        Message += new Display.myDelegate(Display.Success);
                        Message.Invoke();
                        ClearTextBoxes();
                        metroPanel1.Visible = false;

                    }
                    else
                    {
                        Message += new Display.myDelegate(Display.Failure);
                        Message.Invoke();
                    }
                }
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();

            }




        
    }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void ClientMaintenanceUpdateClient_Load(object sender, EventArgs e)
        {
            cmbucClientType.SelectedIndex = 0;
            this.StyleManager = metroStyleManager1;
            // metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            if (val == "dark")
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            contractType = contract.ViewContract();
            cmbucContractType.DataSource = contractType;
            
            if (txtClientCode.Text != string.Empty)
            {
                


                if (cmbucClientType.Text == "Individual")
                {
                    List<string> list = detail.FindClientWithContract(cmbucClientType.Text, txtClientCode.Text);
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
                    clientDetail.ContractType = list[8];

                    txtuFirstName.Text = clientDetail.FirstName;
                    txtuLastName_Business.Text = clientDetail.LastName;
                    txtuTelNum.Text = clientDetail.TelNumber.ToString();
                    txtuAddress.Text = clientDetail.Address;
                    txtuAdhocNote.Text = clientDetail.AdhocNote;
                    txtuReport.Text = clientDetail.ClientReport;
                    txtuStatus.Text = clientDetail.ClientStatus;
                    txtuFollowup.Text = clientDetail.ClientFollowup;
                    cmbucClientType.Text = clientDetail.ClientType;
                    txtContractType.Text = clientDetail.ContractType;
                }
                else
                {
                    List<string> list = detail.FindClientWithContract(cmbucClientType.Text, txtClientCode.Text);
                   // MessageBox.Show("business");
                    Business clientDetail = new Business();
                    clientDetail.BusinessName = list[0];
                    clientDetail.BusinessAddress = list[1];
                    clientDetail.TelNumber = int.Parse(list[2]);
                    clientDetail.AdhocNote = list[3];
                    clientDetail.ClientReport = list[4];
                    clientDetail.ClientStatus = list[5];
                    clientDetail.ClientFollowup = list[6];
                    clientDetail.ContractType = list[7];

                    txtuLastName_Business.Text = clientDetail.BusinessName;
                    txtuTelNum.Text = clientDetail.TelNumber.ToString();
                    txtuAddress.Text = clientDetail.BusinessAddress;
                    txtuAdhocNote.Text = clientDetail.AdhocNote;
                    txtuReport.Text = clientDetail.ClientReport;
                    txtuStatus.Text = clientDetail.ClientStatus;
                    txtuFollowup.Text = clientDetail.ClientFollowup;
                    txtContractType.Text = clientDetail.ContractType;

                }

                metroPanel1.Visible = true;
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();



            }
        
    }

        private void cmbucContractType_Enter(object sender, EventArgs e)
        {
            txtContractType.Visible = false;
            cmbucContractType.Visible = true;
        }

        private void cmbucClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            metroPanel1.Visible = false;
            if (cmbucClientType.Text == "Business")
            {
                metroLabel3.Enabled = false;
                txtuFirstName.Enabled = false;
                lblucSurnameBusiness.Text = "Business";
            }
            else
            {
                metroLabel3.Enabled = true;
                txtuFirstName.Enabled = true;
                lblucSurnameBusiness.Text = "Surname";

            }
        }

        private void txtContractType_Enter(object sender, EventArgs e)
        {
            txtContractType.Visible = false;
            cmbucContractType.Visible = true;
        }
    }
}
