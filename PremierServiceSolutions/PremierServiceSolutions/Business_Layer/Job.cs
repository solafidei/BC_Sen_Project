using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class Job:WorkRequest
    {
        private string jobSpecification;

        public string JobSpecification
        {
            get
            {
                return null ?? jobSpecification;
            }

            set
            {
                jobSpecification = null ?? value;
            }
        }

        public Job()
        {

        }

        public void TrackJob()
        {

        }

        public void EscalateJob()
        {

        }

        public void ReassignJob()
        {

        }

        public void AssignJob()
        {

        }
    }
}