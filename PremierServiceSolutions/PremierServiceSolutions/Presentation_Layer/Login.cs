using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PremierServiceSolutions.Data_Layer;
using PremierServiceSolutions.Business_Layer;
using MetroFramework.Forms;
using PremierServiceSolutions.Presentation_Layer.Panel;

namespace PremierServiceSolutions.Presentation_Layer
{
    public partial class Login : MetroForm
    {
        
        DataHandler con = new DataHandler();
        Crypto crpto = new Crypto();
        Business_Layer.Login log = new Business_Layer.Login();
        string val;
        pnlSlider slid = new pnlSlider();

        public Login()
        {

            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
            

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.Theme == MetroFramework.MetroThemeStyle.Dark)
            {
                val = "dark";

            }
            else
            {
                val = "light";
            }
            log.Username = txtUsername.Text;
            
            log.Password = crpto.Encrypt(txtPassword.Text);
            log.Log();
            if (txtUsername.Text == string.Empty || txtPassword.Text == string.Empty)
            {

                MessageBox.Show("Please fill in all the boxes");
            }
            else if (log.Log() != string.Empty)
            {

                switch (log.Log())
                {
                    case "Call_Centre":
                        this.Hide();
                        Call_Centre call = new Call_Centre(txtUsername.Text,txtPassword.Text);
                        call.Show();
                        break;
                    case "Client_Maintenance":
                        this.Hide();
                        Client_Maintenance maintenance = new Client_Maintenance(val);
                        maintenance.Show();
                        break;
                    case "Client_Satisfaction":
                        this.Hide();
                        Client_Satisfaction satisfaction = new Client_Satisfaction(txtUsername.Text, txtPassword.Text);
                        satisfaction.Show();
                        break;
                    case "Service_Department":
                        this.Hide();
                        Service_Department service = new Service_Department();
                        service.Show();
                        break;
                    case "Administrator":
                        this.Hide();
                        Home home = new Home(txtUsername.Text,txtPassword.Text,val);
                        home.Show();
                        break;
                    case "Contract_Maintenance":
                        this.Hide();
                        Contract_Maintenance contract = new Contract_Maintenance();
                        contract.Show();
                        break;
                    default:
                        MessageBox.Show("This user has not been assigned a department");
                        break;
                }

                


            }
            else
            {
                MessageBox.Show("incorrect username/password");
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Form_Closed(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);

        }

        private void btnLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {


                EventArgs arg = new EventArgs();
                btnLogin_Click(sender, arg);
                //MessageBox.Show("key pressed");
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
           pnlSetting _pnlSetting = new pnlSetting(this);
            _pnlSetting.Closed += _pnlone_Closed;
            
            _pnlSetting.swipe(true);
            metroTile1.Enabled = false;
           
        }
        void _pnlone_Closed(object sender, EventArgs e)
        {
            metroTile1.Enabled = true;
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                
                metroStyleManager1.Style = (MetroFramework.MetroColorStyle)12;
                //val = "Light";
            }
            else
            {
                metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                metroStyleManager1.Style = (MetroFramework.MetroColorStyle)13;
                //val = "dark";
                
            }
           // val = metroStyleManager1.Theme.ToString();
            //MessageBox.Show(val);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = crpto.Encrypt(txtPassword.Text);
            

        }
    }
}
