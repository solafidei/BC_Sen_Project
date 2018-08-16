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
    public partial class Contract_Maintenance : MetroForm
    {
        private Service service = new Service();
        private Agreement contract = new Agreement();
        event Display.myDelegate Message;
        
        public Contract_Maintenance()
        {
            InitializeComponent();
        }

        private void btnInsertService_Click(object sender, EventArgs e)
        {
            if (txtisServiceName.TextLength != 0 && txtisServiceLevel.TextLength != 0)
            {
                service.ServiceName = txtisServiceName.Text;
                service.ServiceLevel = txtisServiceLevel.Text;
                if (service.IntroducePackage() == true)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtuServiceName.TextLength != 0 && txtuServiceLevel.TextLength != 0)
            {
                service.ServiceName = txtuServiceName.Text;
                service.ServiceLevel = txtuServiceLevel.Text;
                if (service.ManageServices() == true)
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

        private void btnInsertContract_Click(object sender, EventArgs e)
        {
            

        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            

        }

        private void Contract_Maintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'premierServicedbDataSet.Contract' table. You can move, or remove it, as needed.
            this.contractTableAdapter.Fill(this.premierServicedbDataSet.Contract);
            // TODO: This line of code loads data into the 'premierServicedbDataSet.Service' table. You can move, or remove it, as needed.
            this.serviceTableAdapter.Fill(this.premierServicedbDataSet.Service);

        }

        private void Contract_Maintenance_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

            this.Close();
            ClientMaintenanceInsertContract insert = new ClientMaintenanceInsertContract();
            insert.Show();
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            ClientMaintenanceUpdateContract update = new ClientMaintenanceUpdateContract();
            update.Show();
        }
    }
}
