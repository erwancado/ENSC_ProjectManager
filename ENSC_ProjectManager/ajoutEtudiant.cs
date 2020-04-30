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
    public partial class ajoutEtudiant : Form
    {
        public ajoutEtudiant()
        {
            InitializeComponent();
            Valider.Enabled = false;
            if (nomEtudiant.Text.Length != 0 && prenomEtudiant.Text.Length != 0 && email.Text.Length != 0)
                Valider.Enabled = true;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            bool redoublement = false;
            if (redoublant.Checked)
            {
                redoublement = true;
            }
            Etudiant E = new Etudiant(nomEtudiant.Text, prenomEtudiant.Text, email.Text, redoublement);
        }
    }
}
