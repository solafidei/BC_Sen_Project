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
    public partial class Client_Maintenance : MetroForm
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

        public Client_Maintenance(string theme)
        {
            InitializeComponent();
            val = theme;
            
        }
        public Client_Maintenance()
        {
            InitializeComponent();
            this.StyleManager = msmMain;
            
            // tabControl1.StyleManager = msmMain;
            
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

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tpClientManagement_Click(object sender, EventArgs e)
        {

        }

       
        //public void RetrieveID(string clientType, string id)
        //{
        //    individual.ClientType = clientType;
        //    individual.ClientIdentifier = id;
        //}

       

        private void btnInsertContract_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void Client_Maintenance_Load(object sender, EventArgs e)
        {

        }

        private void Client_Maintenance_Load_1(object sender, EventArgs e)
        {
            this.StyleManager = msmMain;
            
            if (val == "dark")
            {
                msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                msmMain.Theme = MetroFramework.MetroThemeStyle.Light;
            }




            // TODO: This line of code loads data into the 'premierServicedbDataSet.ClientDetail' table. You can move, or remove it, as needed.
            this.clientDetailTableAdapter.Fill(this.premierServicedbDataSet.ClientDetail);
                // TODO: This line of code loads data into the 'premierServicedbDataSet.ClientType' table. You can move, or remove it, as needed.
                this.clientTypeTableAdapter.Fill(this.premierServicedbDataSet.ClientType);
                contractType = contract.ViewContract();
               // cmbicContractType.DataSource = contractType;
             
                equip = equipment.ViewEquipmentWithType();
                List<string> arr = new List<string>();
            //cmbicEquipmentName.Items.Clear();
            //cmbicEquipmentModel.Items.Clear();
                 
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
           
        }

        private void cmbClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tpInsertClient_Click(object sender, EventArgs e)
        {

        }

        

        private void txtContractType_Enter(object sender, EventArgs e)
        {
            
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            
           
            




        }

        private void cmbicEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void cmbicEquipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbicEquipmentModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbucEquipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbucEquipmentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtucEquipmentType_Enter(object sender, EventArgs e)
        {
            

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ClientMaintenanceInsertClient insertClient = new ClientMaintenanceInsertClient(val);
            insertClient.Show();
        }

        private void mtUpdateClient_Click(object sender, EventArgs e)
        {
            ClientMaintenanceUpdateClient updateClient = new ClientMaintenanceUpdateClient(val);
            updateClient.Show();
        }

        private void mtInsertContract_Click(object sender, EventArgs e)
        {
            ClientMaintenanceInsertContract insertContract = new ClientMaintenanceInsertContract(val);
            insertContract.Show();
        }

        private void mtUpdateContract_Click(object sender, EventArgs e)
        {
            ClientMaintenanceUpdateContract updateContract = new ClientMaintenanceUpdateContract(val);
            updateContract.Show();
        }

        private void Client_Maintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
    