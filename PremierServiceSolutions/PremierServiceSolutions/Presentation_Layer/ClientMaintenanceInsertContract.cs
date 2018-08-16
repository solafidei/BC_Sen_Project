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
    public partial class ClientMaintenanceInsertContract : MetroForm
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

        public ClientMaintenanceInsertContract(string theme)
        {
            val = theme;
            InitializeComponent();
        }
        public ClientMaintenanceInsertContract()
        {
            InitializeComponent();
        }

        private void ClientMaintenanceInsertContract_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            if (val == "dark")
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            contractType = contract.ViewContract();
            cmbcoContractType.DataSource = contractType;
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

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (cmbcoContractType.Text != string.Empty && txticServiceName.Text != string.Empty && txticServiceLevel.Text != string.Empty && txticServiceAvailable.Text != string.Empty)
            {
                contract.ContractType = cmbcoContractType.Text;
                contract.ServiceName = txticServiceName.Text;
                contract.ServiceLevel = txticServiceLevel.Text;
                contract.ServiceAvailability = txticServiceAvailable.Text;
                contract.EquipmentName = cmbicEquipmentName.Text;
                contract.EquipmentModel = cmbicEquipmentModel.Text;
                if (contract.CaptureAgreementDetails() == true)
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
    }
}
