using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.Presentation_Layer;
using MetroFramework.Forms;

namespace PremierServiceSolutions.Presentation_Layer
{
    public partial class Home : MetroForm
    {
        string val = null;
        string ename;
        string esurname;

        

        public Home(string name, string surname,string Theme)
        {
            ename = name;
            esurname = surname;
            val = Theme;
            InitializeComponent();

        }
        public Home()
        {
            InitializeComponent();
        }

        private void btnCallCentre_Click(object sender, EventArgs e)
        {
            Call_Centre callCentre = new Call_Centre(ename,esurname);
            callCentre.Show();
        }

        private void btnClientMaintenance_Click(object sender, EventArgs e)
        {
           Client_Maintenance clientMaintenance = new Client_Maintenance(val);
           clientMaintenance.StyleManager = this.StyleManager;
           clientMaintenance.Show();
        }

        private void btnClientSatisfaction_Click(object sender, EventArgs e)
        {
            Client_Satisfaction clientSatisfaction = new Client_Satisfaction();
            clientSatisfaction.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnServiceDept_Click(object sender, EventArgs e)
        {
            Service_Department serviceDept = new Service_Department();
            serviceDept.Show();
        }

        private void btnContractMaintenance_Click(object sender, EventArgs e)
        {
            Contract_Maintenance contractMaintenance = new Contract_Maintenance();
            contractMaintenance.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            this.StyleManager = metroStyleManager1;
            if (val =="dark")
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;

            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
