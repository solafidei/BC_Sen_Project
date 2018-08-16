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
    public partial class ClientMaintenanceUpdateContract : MetroForm
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
        private Service service = new Service();
        List<string> serviceLevel = new List<string>();

        public ClientMaintenanceUpdateContract(string theme)
        {
            InitializeComponent();
            val = theme;
        }
        public ClientMaintenanceUpdateContract()
        {
            InitializeComponent();
        }

        private void ClientMaintenanceUpdateContract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierServicedbDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.premierServicedbDataSet.Service);
            contractType = contract.ViewContract();
            serviceLevel = service.ViewServiceLevel();
            foreach (string item in serviceLevel)
            {
                dmServiceLevel.Items.Add(item);
            }
            
            
            cmbContractType.DataSource = contractType;

            this.StyleManager = metroStyleManager1;
            if (val == "dark")
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }

            equip = equipment.ViewEquipmentWithType();
            foreach (Equipment item in equip)
            {
                if (!cmbicEquipmentType.Items.Contains(item.EquipmentType.ToString()))
                {
                    cmbicEquipmentType.Items.Add(item.EquipmentType.ToString());
                }
                cmbicEquipmentType.SelectedIndex = 0;
            }
        }

        private void cmbicEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameSource.Clear();
            foreach (Equipment item in equip)
            {
                if (item.EquipmentType == cmbicEquipmentType.Text)
                {
                    nameSource.Add(item.EquipmentName);

                }

            }
            nameSource.DataSource = null;
            nameSource.DataSource = equipmentName;
            cmbicEquipmentName.DataSource = nameSource;
            cmbicEquipmentName.Update();
            cmbicEquipmentName.Refresh();
        }

        private void cmbicEquipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameSource2.Clear();
            foreach (Equipment item in equip)
            {
                if (item.EquipmentName == cmbicEquipmentName.Text)
                {
                    nameSource2.Add(item.EquipmentModel);

                }
            }

            nameSource2.DataSource = null;

            nameSource2.DataSource = equipmentModel;

            cmbicEquipmentModel.DataSource = nameSource2;
            cmbicEquipmentModel.Update();
            cmbicEquipmentModel.Refresh();


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (txtucContractCode.Text != string.Empty)
            {

                List<string> list = new List<string>();
                string identifier = txtucContractCode.Text;
                list = contract.ViewAgreementWithIdentifier(identifier);
                if (txtucContractCode.Text != string.Empty)
                {

                    txticContractType.Text = list[0];
                    txticServiceName.Text = list[1];
                    txticServiceLevel.Text = list[2];
                    txticServiceAvailable.Text = list[3];
                    txtEquipmentType.Text = list[4];
                    txtEquipmentName.Text = list[5];
                    txtEquipmentModel.Text = list[6];
                }
                metroPanel1.Visible = true;
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
            }

        }

        private void txtEquipmentType_Enter(object sender, EventArgs e)
        {
            txtEquipmentType.Visible = false;
            txtEquipmentName.Visible = false;
            txtEquipmentModel.Visible = false;
            cmbicEquipmentType.Visible = true;
            cmbicEquipmentName.Visible = true;
            cmbicEquipmentModel.Visible = true;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txticContractType.Text != string.Empty && txticServiceName.Text != string.Empty && dmServiceLevel.Text != string.Empty && txticServiceAvailable.Text != string.Empty)
            {

                contract.ContractType = cmbContractType.Text;
                contract.ServiceName = txticServiceName.Text;
                contract.ServiceLevel = dmServiceLevel.Text;
                contract.ServiceAvailability = txticServiceAvailable.Text;
                contract.EquipmentName = cmbicEquipmentName.Text;
                contract.EquipmentModel = cmbicEquipmentModel.Text;
                contract.ContractIdentifier = txtucContractCode.Text;
                if (contract.ManageContractTypeAvailable() == true)
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

        private void txticServiceLevel_Enter(object sender, EventArgs e)
        {
            txticServiceLevel.Visible = false;
            dmServiceLevel.Visible = true;
        }

        private void txticContractType_Enter(object sender, EventArgs e)
        {
            txticContractType.Visible = false;
            cmbContractType.Visible = true;
        }
    }
}
