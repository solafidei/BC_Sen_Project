using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PremierServiceSolutions.Business_Layer
{
    public class Employee:EmployeeType
    {
        private string empName;
        private string empSurname;
        private string empAddress;
        private int empTelNum;
        private string jobDescription;
        Data_Layer.DataHandler data = new Data_Layer.DataHandler();
        bool check;
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

        public string EmpAddress
        {
            get
            {
                return null ?? empAddress;
            }

            set
            {
                empAddress = null ?? value;
            }
        }

        public int EmpTelNum
        {
            get
            {
                return empTelNum;
            }

            set
            {
                empTelNum = value;
            }
        }

        public string JobDescription
        {
            get
            {
                return null ?? jobDescription;
            }

            set
            {
                jobDescription = null ?? value;
            }
        }

        public Employee()
        {

        }

        public bool AddEmployee()
        {

           return check = data.InsertEmployee(EmpName, EmpSurname, EmpAddress, EmpTelNum, EmpType, JobDescription);
        }

        public bool UpdateEmployee()
        {
            return check = data.UpdateEmployee(EmpName, EmpSurname, EmpAddress, EmpTelNum, EmpType, JobDescription);
        }
    }
}