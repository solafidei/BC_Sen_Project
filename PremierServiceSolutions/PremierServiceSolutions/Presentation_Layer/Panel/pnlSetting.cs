using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace PremierServiceSolutions.Presentation_Layer.Panel
{
    public partial class pnlSetting : pnlSlider
    {
        public pnlSetting(Form owner):base(owner)
        {
            InitializeComponent();
            //this.StyleManager.Update();
        }

        private void pnlSetting_Load(object sender, EventArgs e)
        {
            this.StyleManager = metroStyleManager1;
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggle1.Checked == true)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
            }
            else
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            
        }
    }
}
