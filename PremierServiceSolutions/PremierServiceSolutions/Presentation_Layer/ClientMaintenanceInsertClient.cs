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
    public partial class ClientMaintenanceInsertClient : MetroForm
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
        string val = null;
        event Display.myDelegate Message;

        public ClientMaintenanceInsertClient(string theme)
        {
            InitializeComponent();
            val = theme;

        }
        public ClientMaintenanceInsertClient()
        {
            InitializeComponent();
        }
        Action<Control.ControlCollection> func = null;
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


        private void button1_Click(object sender, EventArgs e)
        {

            if (cmbClientType.Text != string.Empty || txtFirstName.Text != string.Empty || txtLastName_Business.Text != string.Empty || txtTelNum.Text != string.Empty || txtFollowup.Text != string.Empty ||
                txtReport.Text != string.Empty || txtStatus.Text != string.Empty || cmbicContractType.Text != string.Empty || txtAddress.Text != string.Empty || txtAdhocNote.Text != string.Empty)
            {

                if (cmbClientType.Text == "Business")
                {
                    lblSurname_Business.Text = "Business";
                    business.BusinessName = txtLastName_Business.Text;
                    business.TelNumber = int.Parse(txtTelNum.Text);
                    business.BusinessAddress = txtAddress.Text;
                    business.AdhocNote = txtAdhocNote.Text;
                    business.ClientType = cmbClientType.Text;
                    business.ContractType = cmbicContractType.Text;
                    business.ClientFollowup = txtFollowup.Text;
                    business.ClientReport = txtReport.Text;
                    business.ClientStatus = txtStatus.Text;

                    if (business.CaptureClientDetails() == true)
                    {
                        Message += new Display.myDelegate(Display.Success);
                        Message.Invoke();
                        MessageBoxManager.OK = "Copy";
                        MessageBoxManager.Register();
                        //MessageBox.Show(individual.ClientIdentifier, "Client Identifier", MessageBoxButtons.OK);
                        if (DialogResult.OK == MessageBox.Show(business.ClientIdentifier, "Client Identifier", MessageBoxButtons.OK))
                        {
                            Clipboard.SetText(business.ClientIdentifier);
                            MessageBox.Show("Copied to Clipboard");
                            ClearTextBoxes();
                        }
                         
                    }
                    else
                    {
                        Message += new Display.myDelegate(Display.Failure);
                        Message.Invoke();
                    }

                }
                else
                {
                    lblSurname_Business.Text = "Individual";
                    individual.FirstName = txtFirstName.Text;
                    individual.LastName = txtLastName_Business.Text;
                    individual.TelNumber = int.Parse(txtTelNum.Text);
                    individual.ClientFollowup = txtFollowup.Text;
                    individual.ClientReport = txtReport.Text;
                    individual.ClientStatus = txtStatus.Text;
                    individual.ClientType = cmbClientType.Text;
                    individual.ContractType = cmbicContractType.Text;
                    individual.Address = txtAddress.Text;
                    individual.AdhocNote = txtAdhocNote.Text;
                    if (individual.CaptureClientDetails() == true)
                    {
                        Message += new Display.myDelegate(Display.Success);
                        Message.Invoke();
                        MessageBoxManager.OK = "Copy";
                        MessageBoxManager.Register();                       
                        if (DialogResult.OK == MessageBox.Show(individual.ClientIdentifier, "Client Identifier", MessageBoxButtons.OK))
                        {
                            Clipboard.SetText(individual.ClientIdentifier);
                            MessageBox.Show("Copied to Clipboard");
                            ClearTextBoxes();

                        }                       

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

        private void ClientMaintenanceInsertClient_Load(object sender, EventArgs e)
        {
            contractType = contract.ViewContract();
            cmbicContractType.DataSource = contractType;
            this.StyleManager = metroStyleManager1;
            if (val == "dark")
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
        }

        private void cmbClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClientType.Text == "Business")
            {
                lblicFirstName.Enabled = false;
                txtFirstName.Enabled = false;
                lblSurname_Business.Text = "Business";
            }
            else
            {
                lblicFirstName.Enabled = true;
                txtFirstName.Enabled = true;
                lblSurname_Business.Text = "Last Name";
            }
        }
        
    }
}


    


