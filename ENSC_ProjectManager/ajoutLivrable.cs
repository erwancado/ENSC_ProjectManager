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
    public partial class ajoutLivrable : Form
    {
        private DateTime _dateDebutProjet;
        private DateTime _dateFinProjet;

        public ajoutLivrable(DateTime dateDebutProjet, DateTime dateFinProjet)
        {
            _dateDebutProjet = dateDebutProjet;
            _dateFinProjet = dateFinProjet;

            InitializeComponent();
            valider.Enabled = false;
            dateRenduLivrable.Value = DateTime.Now;
            listeTypeFichier.Items.Add("pdf");
            listeTypeFichier.Items.Add("video");
            listeTypeFichier.Items.Add("map");
            listeTypeFichier.Items.Add("code");
        }

        private void Valider_Click(object sender, EventArgs e)
        {
            
             Livrable aRendre = new Livrable(listeTypeFichier.SelectedItem.ToString(), dateRenduLivrable.Value, false, nomDuLivrable.Text);
        }

        private void DateRenduLivrable_ValueChanged(object sender, EventArgs e)
        {
            if (nomDuLivrable.Text.Length!=0)
            {
                valider.Enabled = true;
            }
            int testValiditeDebut = DateTime.Compare(_dateDebutProjet, dateRenduLivrable.Value);
            int testValiditeFin = DateTime.Compare(dateRenduLivrable.Value, _dateFinProjet);
            if(testValiditeDebut > 0 || testValiditeFin > 0)
            {
                MessageBox.Show("La date de rendu du livrable doit être comprise entre la date de début et de fin du projet", "Erreur de concordance des dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valider.Enabled = false;
            }
        }

        private void NomDuLivrable_TextChanged(object sender, EventArgs e)
        {
            if(listeTypeFichier.SelectedIndex!=0)
            {
                valider.Enabled = true;
            }
        }
    }
}
