using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PremierServiceSolutions.Data_Layer;
namespace PremierServiceSolutions.Business_Layer
{
    class Login
    {
        private string username;
        private string password;
        DataHandler data = new DataHandler();

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Log()
        {
            string department;
            return department = data.Login(Username, Password);
        }
    }
}
