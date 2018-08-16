using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PremierServiceSolutions.Data_Layer;

namespace PremierServiceSolutions.Business_Layer
{
    public class ClientDetail
    {
[Flags]
        public enum eClientStatus
        {
            Important = 1,
            Dissatisfied = 2,
            Deteriorating = 4,
            Satisfied = 8,
            Monitored = 16,
            New = 32
        }

        #region fields
        DataHandler data = new DataHandler();
        private int clientID;
        private string clientStatus;
        private string clientReport;
        private string clientFollowup;
        private string clientType;
        private string contractType;
        private string clientIdentifier;
        private eClientStatus status;
        #endregion

        #region properties
        public int ClientID
        {
            get
            {
                return clientID;
            }

            set
            {
                clientID = value;
            }
        }

        public string ClientStatus
        {
            get
            {
                return null ?? clientStatus;
            }

            set
            {
                clientStatus = null ?? value;
            }
        }

        public string ClientReport
        {
            get
            {
                return null ?? clientReport;
            }

            set
            {
                clientReport = null ?? value;
            }
        }

        public string ClientFollowup
        {
            get
            {
                return null ?? clientFollowup;
            }

            set
            {
                clientFollowup = null ?? value;
            }
        }

        public string ClientType
        {
            get
            {
                return null ?? clientType;
            }

            set
            {
                clientType = null ?? value;
            }
        }

        public string ContractType
        {
            get
            {
                return null ?? contractType;
            }

            set
            {
                contractType = null ?? value;
            }
        }

        public string ClientIdentifier
        {
            get
            {
                return null ?? clientIdentifier;
            }

            set
            {
                clientIdentifier = value;
            }
        }

        public eClientStatus Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        #endregion

        #region methods
        public ClientDetail()
        {

        }
        public ClientDetail(string clientIdentifier, string clientFollowup, string clientStatus)
        {
            this.clientIdentifier = clientIdentifier;
            this.clientFollowup = clientFollowup;
            this.clientStatus = clientStatus;
        }

        public string GenerateClientCode()
        {
            try
            {
            char[] letter = { 'A', 'B', 'C', 'D', 'E' };
            Random charRandom = new Random();
            int charNext = charRandom.Next(0, 4);
            Random intRandom = new Random();
            var intNext = intRandom.Next(1, 99999999).ToString(); ;
            return clientIdentifier = (letter[charNext]).ToString() + intNext.PadLeft(8, '0');

            }
            catch (MyException ex)
            {

                throw new MyException("Client Code could not be generated");
            }
            
        }

        public void CaptureClientManagementInfo()
        {

        }

        public List<string> FindClient(string clientType, string clientIdentifier)
        {
            List<string> findClient = data.FindClient(clientType, clientIdentifier);

            return findClient;
        }
        public List<string> FindClientWithContract(string clientType,string clientIdentifier)
        {
            List<string> findClientWithContract = data.FindClientWithContract(clientType, clientIdentifier);

            return findClientWithContract;
        }

        public virtual bool UpdateClientDetails()
        {
            return true;
        }
        public virtual bool CaptureClientDetails()
        {
            return true;
        }

        public void ViewPastCalls()
        {

        }

        public List<string> ReceiveSatisfactionReport()
        {
            List<string> FindReport = data.FindReport();
            return FindReport;
        }

        public List<ClientDetail> CheckFollowup(string clientType)
        {
            List<ClientDetail> FindFollowup = data.FindFollowup(clientType);
            return FindFollowup;
        }

        public eClientStatus GetStatus(string clientIdentifier)
        {
            return data.GetClientStatus(clientIdentifier);
        }
        #endregion
    }
}