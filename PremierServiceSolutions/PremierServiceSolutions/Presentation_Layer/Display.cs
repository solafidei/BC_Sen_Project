using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Presentation_Layer
{
    static class Display
    {
        public delegate void myDelegate();

        public static void Success()
        {
            MessageBox.Show("transaction successful");
        }
        public static void Failure()
        {
            MessageBox.Show("transaction failed");
        }
        public static void Error()
        {
            MessageBox.Show("Please sure all data inputs are valid");

        }
    }
}
