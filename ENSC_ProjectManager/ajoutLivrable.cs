using System;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Formulaire d'ajout d'un livrable
    /// </summary>
    public partial class AjoutLivrable : Form
    {
        private DateTime _dateDebutProjet;
        private DateTime _dateFinProjet;
        public Livrable ReturnLivrable;

        public AjoutLivrable(DateTime dateDebutProjet, DateTime dateFinProjet)
        {
            _dateDebutProjet = dateDebutProjet;
            _dateFinProjet = dateFinProjet;
            InitializeComponent();
            rendu.Checked = true;
            valider.Enabled = false;
            dateRenduLivrable.MinDate = dateDebutProjet;
            dateRenduLivrable.Value = dateFinProjet;
            listeTypeFichier.Items.Add("PDF");
            listeTypeFichier.Items.Add("Video");
            listeTypeFichier.Items.Add("MindMap");
            listeTypeFichier.Items.Add("Code");
            listeTypeFichier.Items.Add("Diaporama");
            listeTypeFichier.Items.Add("Maquette");
            listeTypeFichier.Items.Add("Tableur");
            listeTypeFichier.Items.Add("Site web");
            listeTypeFichier.Items.Add("Autre");
            this.CenterToParent();
        }

        private void Valider_Click(object sender, EventArgs e)
        {

            ReturnLivrable = new Livrable(listeTypeFichier.SelectedItem.ToString(), dateRenduLivrable.Value, rendu.Checked, nomDuLivrable.Text);
            this.Visible = false;
        }

        /// <summary>
        /// Vérifie que la date de rendu du livrable sélectionnée est valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateRenduLivrable_ValueChanged(object sender, EventArgs e)
        {
            if (nomDuLivrable.Text.Length != 0)
            {
                valider.Enabled = true;
            }
            if (!DateValide())
            {
                MessageBox.Show("La date de rendu du livrable doit être comprise entre la date de début et de fin du projet", "Erreur de concordance des dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                valider.Enabled = false;
            }
        }

        private void NomDuLivrable_TextChanged(object sender, EventArgs e)
        {
            if (listeTypeFichier.SelectedIndex != 0 && DateValide())
            {
                valider.Enabled = true;
            }
        }

        private bool DateValide()
        {
            int testValiditeDebut = DateTime.Compare(_dateDebutProjet, dateRenduLivrable.Value);
            int testValiditeFin = DateTime.Compare(dateRenduLivrable.Value, _dateFinProjet);
            return (dateRenduLivrable.Value == _dateDebutProjet || dateRenduLivrable.Value == _dateFinProjet || !(testValiditeDebut > 0 || testValiditeFin > 0));
        }
    }
}
