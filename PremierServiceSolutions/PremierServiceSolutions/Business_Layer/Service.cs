using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PremierServiceSolutions.Business_Layer
{
    
    public class Service
    {
        private Data_Layer.DataHandler data = new Data_Layer.DataHandler();
        bool check;
        
        
        
        private string serviceName;
        private string serviceLevel;

        public string ServiceName
        {
            get
            {
                return null ?? serviceName;
            }

            set
            {
                serviceName = null ?? value;
            }
        }

        public string ServiceLevel
        {
            get
            {
                return null ?? serviceLevel;
            }

            set
            {
                serviceLevel = null ?? value;
            }
        }

        public Service()
        {
            
        }

        public bool ManageServices()
        {
           return check = data.UpdateService(ServiceName, ServiceLevel);
            
        }

        public void WithdrawPackage()
        {
            
        }

        public bool IntroducePackage()
        {
           return check = data.InsertService(ServiceName, ServiceLevel);
            
            
        }

        public void PromotePackage()
        {
            
        }
        public List<string> ViewServiceLevel()
        {
            List<string> list = data.ViewServiceLevel();
            return list;
        }
    }
}