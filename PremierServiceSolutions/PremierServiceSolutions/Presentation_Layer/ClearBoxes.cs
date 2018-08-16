using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremierServiceSolutions.Presentation_Layer
{
    class ClearBoxes
    {
        Action<Control.ControlCollection> func = null;
        private void ClearTextBoxes()
        {
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

           // func(Controls);
        }
    }
}
