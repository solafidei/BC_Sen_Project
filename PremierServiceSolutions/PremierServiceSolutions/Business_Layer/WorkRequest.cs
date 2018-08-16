using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PremierServiceSolutions.Data_Layer;

namespace PremierServiceSolutions.Business_Layer
{
    public class WorkRequest
    {
        private int workID;
        private string workDuration;
        private string workRequirement;
        private string name;
        private string surname;
        private DataHandler data = new DataHandler();
        bool check;

        
        public int WorkID
        {
            get
            {
                return workID;
            }

            set
            {
                workID = value;
            }
        }

        public string WorkDuration
        {
            get
            {
                return null ?? workDuration;
            }

            set
            {
                workDuration = null ?? value;
            }
        }

        public string WorkRequirement
        {
            get
            {
                return null ?? workRequirement;
            }

            set
            {
                workRequirement = null ?? value;
            }
        }

        public string Name
        {
            get
            {
                return null ?? name;
            }

            set
            {
                name = null ?? value;
            }
        }

        public string Surname
        {
            get
            {
                return null ?? surname;
            }

            set
            {
                surname = null ?? value;
            }
        }

        public WorkRequest()
        {
            
        }

        public bool SubmitRequest()
        {
            return check = data.InsertWorkRequest(WorkRequirement, WorkDuration, Name, Surname);            
        }
        public WorkRequest(string workRequirement, string workDuration)
        {
            this.workRequirement = workRequirement;
            this.workDuration = workDuration;
        }
        public WorkRequest(int workID,string workRequirement, string workDuration)
        {
            this.workRequirement = workRequirement;
            this.workDuration = workDuration;
        }
        public void AddCall()
        {
            
        }

        public List<WorkRequest> ReceiveRequest()
        {
            List<WorkRequest> request = new List<WorkRequest>();
            return request = data.ViewWorkRequest();
            
            
        }
        public List<WorkRequest> UnassignedWork()
        {
            List<WorkRequest> request = new List<WorkRequest>();
            return request = data.ViewUnassignedRequest();
        }

        public bool AssignRequest()
        {
            return check = data.ReassignWorkRequest(WorkRequirement, Name, Surname);            
        }

        public bool CloseRequest()
        {
            return check = data.CloseWorkRequest(workID);
            
        }
    }
}