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
            if (codeModule.ToString().Length > 0 && libelleModule.ToString().Length > 0)
                Valider.Enabled = true;

        }

        private void CodeModule_StyleChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
           //Module Mod = new Module(codeModule.Text, libelleModule.Text);
        }
    }
}
