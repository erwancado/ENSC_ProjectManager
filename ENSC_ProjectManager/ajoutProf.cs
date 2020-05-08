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
    public partial class ajoutProf : Form
    {
        public ajoutProf()
        {
            InitializeComponent();
            Valider.Enabled = false;
            if (nomProf.Text.Length > 0 && prenomProf.Text.Length > 0 && mailProf.Text.Length > 0 && titreProf.Text.Length > 0)
                Valider.Enabled = true;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Professeur Prof = new Professeur(nomProf.Text, prenomProf.Text,mailProf.Text,titreProf.Text)
        }
    }
}
