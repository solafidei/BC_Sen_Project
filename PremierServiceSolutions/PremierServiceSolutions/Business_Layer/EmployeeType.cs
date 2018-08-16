using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class EmployeeType
    {
        private string empType;
        private string empSkill;

        public string EmpType
        {
            get
            {
                return null ?? empType;
            }

            set
            {
                empType = null ?? value;
            }
        }

        public string EmpSkill
        {
            get
            {
                return null ?? empSkill;
            }

            set
            {
                empSkill = null ?? value;
            }
        }

        public EmployeeType()
        {

        }
    }
}