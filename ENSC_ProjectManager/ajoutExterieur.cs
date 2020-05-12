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
    public partial class ajoutExterieur : Form
    {
        public ajoutExterieur()
        {
            InitializeComponent();
            Valider.Enabled = false;
            if (nomExte.Text.Length > 1 && prenomExte.Text.Length > 0 && mailExte.Text.Length > 7 && organisationExte.Text.Length > 1)
                Valider.Enabled = true;
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Exterieur Exte = new Exterieur(nomExte.Text, prenomExte.Text, mailExte.Text, organisationExte.Text);
        }
    }
}
