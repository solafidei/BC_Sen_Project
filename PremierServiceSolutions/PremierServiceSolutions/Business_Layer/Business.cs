using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class Business:ClientDetail
    {
        #region fields
        private string businessName;
        private string businessAddress;
        private int telNumber;
        private string adhocNote;
        bool check;
        Data_Layer.DataHandler data = new Data_Layer.DataHandler();
        #endregion

        #region properties
        public string BusinessName
        {
            get
            {
                return null ?? businessName;
            }

            set
            {
                businessName = null ?? value;
            }
        }

        public string BusinessAddress
        {
            get
            {
                return null ?? businessAddress;
            }

            set
            {
                businessAddress = null ?? value;
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

        #endregion

        #region methods
        public Business()
        {

        }

        public override bool CaptureClientDetails()
        {
            return check = data.InsertClient(businessName,businessName , TelNumber, BusinessAddress, AdhocNote, BusinessName, ClientType, ContractType, ClientFollowup, ClientReport, ClientStatus,GenerateClientCode());
        }

        public override bool UpdateClientDetails()
        {
            return check = data.UpdateClient(TelNumber, BusinessAddress, AdhocNote, ClientType, ContractType, ClientFollowup, ClientReport, ClientStatus,ClientIdentifier);
        }
        #endregion

    }
}