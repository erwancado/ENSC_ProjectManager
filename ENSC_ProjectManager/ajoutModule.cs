using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    public partial class AjoutModule : Form
    {
        public AjoutModule()
        {
            InitializeComponent();
           Valider.Enabled = false;

        }

        private void CodeModule_StyleChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {

           Module Mod = new Module(codeModule.Text, libelleModule.Text,promo.SelectedItem.ToString());
        }


    }
}
