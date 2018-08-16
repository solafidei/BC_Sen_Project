using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class Individual:ClientDetail
    {
        private string firstName;
        private string lastName;
        private int telNumber;
        private string adhocNote;
        private string address;
        bool check;
        Data_Layer.DataHandler data = new Data_Layer.DataHandler();

        public string FirstName
        {
            get
            {
                return null ?? firstName;
            }

            set
            {
                firstName = null ?? value;
            }
        }

        public string LastName
        {
            get
            {
                return null ?? lastName;
            }

            set
            {
                lastName = null ?? value;
            }
        }

        public int TelNumber
        {
            get
            {
                return telNumber;
            }

            set
            {
                telNumber = value;
            }
        }

        public string AdhocNote
        {
            get
            {
                return null ?? adhocNote;
            }

            set
            {
                adhocNote = null ?? value;
            }
        }

        public string Address
        {
            get
            {
                return null ?? address;
            }

            set
            {
                address = null ?? value;
            }
        }

        public Individual()
        {

        }

        public override bool CaptureClientDetails()
        {
            return check = data.InsertClient(FirstName, LastName, TelNumber, Address, AdhocNote, LastName, ClientType, ContractType, ClientFollowup, ClientReport, ClientStatus,GenerateClientCode());
        }
        public override bool UpdateClientDetails()
        {
            return check = data.UpdateClient(TelNumber, Address, AdhocNote, ClientType, ContractType, ClientFollowup, ClientReport, ClientStatus,ClientIdentifier);
        }
    }
}