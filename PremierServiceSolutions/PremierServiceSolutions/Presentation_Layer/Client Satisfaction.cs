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
    public partial class Client_Satisfaction : MetroForm
    {
        ClientDetail client = new ClientDetail();
        private string username;
        private string surname;
        private string clientid;
        event Display.myDelegate Message;
        public Client_Satisfaction(string eusername, string esurname)
        {
            this.username = eusername;
            this.surname = esurname;
            InitializeComponent();

        }
        public Client_Satisfaction()
        {
            InitializeComponent();
        }

        private void Client_Satisfaction_Load(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = false;
            DataGridViewColumn myColumn1 = new DataGridViewTextBoxColumn();

            myColumn1.DataPropertyName = "ClientIdentifier";
            myColumn1.HeaderText = "Client Identifier";

            DataGridViewColumn myColumn2 = new DataGridViewTextBoxColumn();
            myColumn2.DataPropertyName = "ClientFollowup";
            myColumn2.HeaderText = "Followup";

            DataGridViewColumn myColumn3 = new DataGridViewTextBoxColumn();
            myColumn3.DataPropertyName = "ClientStatus";
            myColumn3.HeaderText = "Status";
            dataGridView2.Columns.Add(myColumn1);
            dataGridView2.Columns.Add(myColumn2);
            dataGridView2.Columns.Add(myColumn3);


        }

        private void Client_Satisfaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView2.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView2.Rows[selectedrowindex];

                clientid = Convert.ToString(selectedRow.Cells[0].Value);               


            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (clientid != string.Empty && cmbClientType.Text != string.Empty)
            {


                Call_Centre call = new Call_Centre(username, surname, clientid, cmbClientType.Text);
                this.Close();
                call.Show();
            }
            else
            {
                Message += new Display.myDelegate(Display.Error);
                Message.Invoke();

            }
        }

        private void cmbClientType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.Rows.Clear();
            BindingSource source = new BindingSource();
            source.DataSource = client.CheckFollowup(cmbClientType.Text);            
            dataGridView2.DataSource = source;

        }
    }
}
