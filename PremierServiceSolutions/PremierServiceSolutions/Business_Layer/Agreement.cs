using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class Agreement:Service
    {
        private int contractID;
        private string  contractType;
        private string serviceAvailability;
        private string contractIdentifier;
        private string equipmentType;
        private string equipmentName;
        private string equipmentModel;
        Data_Layer.DataHandler data = new Data_Layer.DataHandler();
        
        bool check;

        public int ContractID
        {
            get
            {
                return contractID;
            }

            set
            {
                contractID = value;
            }
        }

        public string  ContractType
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

        public string ServiceAvailability
        {
            get
            {
                return null ?? serviceAvailability;
            }

            set
            {
                serviceAvailability = null ?? value;
            }
        }

        public string ContractIdentifier
        {
            get
            {
                return contractIdentifier;
            }

            set
            {
                contractIdentifier = value;
            }
        }

        public string EquipmentName
        {
            get
            {
                return equipmentName;
            }

            set
            {
                equipmentName = value;
            }
        }

        public string EquipmentModel
        {
            get
            {
                return equipmentModel;
            }

            set
            {
                equipmentModel = value;
            }
        }

        public string EquipmentType
        {
            get
            {
                return equipmentType;
            }

            set
            {
                equipmentType = value;
            }
        }

        public string GenerateContractCode()
        {
            int year = DateTime.Now.Year;
            char[] letter = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ").ToCharArray();
            Random charRandom = new Random();
            int charNext = charRandom.Next(0, 4);
            Random intRandom = new Random();
            var intNext = intRandom.Next(1, 999999).ToString(); ;
            return contractIdentifier = year.ToString() + (letter[charNext]).ToString() + intNext.PadLeft(6, '0');
        }


        public Agreement()
        {
            
        }

        public List<string> ViewAgreement(string firstName, string lastName, string businessName, string clientType)
        {
            List<string> findAgreement = data.FindAgreement(firstName, lastName, businessName, clientType);
            return findAgreement;
            
        }
        public List<string> ViewAgreementWithIdentifier(string contractIdentifier)
        {
            List<string> findAgreement = data.FindAgreementWithContract(contractIdentifier);
            return findAgreement;
        }

        public bool CaptureAgreementDetails()
        {                             
            
            return check = data.InsertContract(ContractType, ServiceName, ServiceLevel, ServiceAvailability,EquipmentName,EquipmentModel,GenerateContractCode());
        }

        public bool ManageContractTypeAvailable()
        {
            
            return check = data.UpdateContract(ContractType, ServiceAvailability, ServiceName,ContractIdentifier,equipmentName,EquipmentModel);
            
        }

        public void ManageContractTypePerformace()
        {
            
        }
        public List<string> ViewContract()
        {
            List<string> viewContract = data.ViewContract();

            return viewContract;

        }

    }
}