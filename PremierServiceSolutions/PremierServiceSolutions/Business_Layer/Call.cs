using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class Call
    {
        private DateTime receiveTime;
        private DateTime endTime;
        private string empName;
        private string empSurname;
        private string reason;
        private string clientType;
        private string customerName;
        private string customerSurname;
        private string businessName;

        public DateTime ReceiveTime
        {
            get
            {
                return  receiveTime;
            }

            set
            {
                receiveTime =  value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }

            set
            {
                endTime = value;
            }
        }

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

        public string CustomerSurname
        {
            get
            {
                return null ?? customerSurname;
            }

            set
            {
                customerSurname = null ?? value;
            }
        }

        public string CustomerName
        {
            get
            {
                return null ?? customerName;
            }

            set
            {
                customerName = null ?? value;
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

        public string Reason
        {
            get
            {
                return null ?? reason;
            }

            set
            {
                reason = null ?? value;
            }
        }

        public string EmpSurname
        {
            get
            {
                return null ?? empSurname;
            }

            set
            {
                empSurname = null ?? value;
            }
        }

        public string EmpName
        {
            get
            {
                return null ?? empName;
            }

            set
            {
                empName = null ?? value;
            }
        }

        public Call(DateTime receiveTime, DateTime endTime, string empName
            ,string empSurname, string reason, string clientType, 
            string customerName, string customerSurname, string businessName)
        {
            this.receiveTime = receiveTime;
            this.endTime = endTime;
            this.empName = empName;
            this.empSurname = empSurname;
            this.reason = reason;
            this.clientType = clientType;
            this.customerName = customerName;
            this.customerSurname = customerSurname;
            this.businessName = businessName;
            
        }
        public Call()
        {

        }

        public void AnswerCall()
        {
            Data_Layer.DataHandler findClient = new Data_Layer.DataHandler();
           
            
        }

        public void EndCall()
        {
            
        }

        public bool InitiateCall()
        {
            bool check;
            Data_Layer.DataHandler newCall = new Data_Layer.DataHandler();
           return check = newCall.InsertCall(ReceiveTime, EndTime, EmpName, EmpSurname, Reason, ClientType, CustomerName, CustomerSurname, BusinessName);
            
            
        }
    }
}