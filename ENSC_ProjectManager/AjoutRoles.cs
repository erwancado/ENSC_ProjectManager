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
    public partial class AjoutRoles : Form
    {
        List<Intervenant> Intervenants;
        public AjoutRoles(List<Intervenant> intervenants)
        {
            InitializeComponent();
            Intervenants = intervenants;
            descriptionCol2.Hide();
            libelle_role.Hide();
            ajouterRole.Hide();
            RemplirIntervenants();
        }

        private void RemplirIntervenants()
        {
            liste_intervenants.BeginUpdate();
            liste_intervenants.Items.Clear();
            foreach(Intervenant intervenant in Intervenants)
            {
                liste_intervenants.Items.Add(intervenant.Nom + " " + intervenant.Prenom+" "+intervenant.Mail);
            }
            liste_intervenants.EndUpdate();
        }
    }
}
