using System;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    public partial class AffichageProjet : Form
    {
        Repertoire _repertoire;
        Projet _projet;
        public AffichageProjet(Repertoire repertoire, Projet projet)
        {
            InitializeComponent();
            this.CenterToParent();
            _repertoire = repertoire;
            _projet = projet;
            RemplirNomProjet();
            RemplirDates();
            RemplirType();
            RemplirParticipants();
            RemplirRoles();
            RemplirDescription();
            RemplirLivrables();
            RemplirMatieres();
        }

        private void RemplirNomProjet()
        {
            NomProjet.Text = _projet.Libelle;
        }
        private void RemplirDates()
        {
            Dates.Text = "Du " + _projet.DateDebut.ToShortDateString() + " au " + _projet.DateFin.ToShortDateString() + " (" + _projet.DureeProjet().Months + " mois" + (_projet.DureeProjet().Days != 0 ? " et " + _projet.DureeProjet().Days + " jours)" : ")");
        }
        private void RemplirType()
        {
            string strType = "Projet " + _projet.Type.TypePromotion;
            if (_projet.Type.Groupe)
                strType += " - Groupe de " + _projet.Type.NbMinEtudiants + " à " + _projet.Type.NbMaxEtudiants + " étudiants";
            else
                strType += " - Individuel";
            TypeProjet.Text = strType;
        }
        private void RemplirParticipants()
        {
            foreach (Role role in _projet.ListeRoles)
            {
                Intervenant intervenant = role.Intervenant;
                Etudiant etudiant = _repertoire.GetEtudiant(_projet.AnneesPromos(), intervenant);
                Professeur professeur = _repertoire.GetProfesseur(intervenant);
                Exterieur exterieur = _repertoire.GetExterieur(intervenant);
                if (etudiant != null)
                    participantsTextBox.Text += etudiant.Nom + "  " + etudiant.Prenom + "  " + etudiant.Mail + "  - Promotion " + etudiant.AnneePromotion + "\n";
                else if (professeur != null)
                    participantsTextBox.Text += "(Professeur)  " + professeur.Nom + "  " + professeur.Prenom + "  " + professeur.Mail + "  " + professeur.Titre + "\n";
                else if (exterieur != null)
                    participantsTextBox.Text += "(Intervenant Extérieur)  " + exterieur.Nom + "  " + exterieur.Prenom + "  " + exterieur.Mail + "  " + exterieur.Organisation + "\n";
                else
                    participantsTextBox.Text += intervenant.Nom + "  " + intervenant.Prenom + "  " + intervenant.Mail + "\n";
            }
        }
        private void RemplirRoles()
        {
            foreach (Role role in _projet.ListeRoles)
            {
                rolesTextBox.Text += role.Libelle + "\n";
            }
        }

        private void RemplirDescription()
        {
            descriptionTextBox.Text = _projet.Description;
        }
        private void RemplirLivrables()
        {
            foreach (Livrable livrable in _projet.ListeLivrables)
            {
                livrablesTextBox.Text += livrable.Libelle + " (" + livrable.TypeFichier.ToUpper() + ") - " + livrable.DateRendu.ToShortDateString() + (livrable.Rendu ? " - Rendu" : " - Non rendu") + "\n";

            }
        }
        private void RemplirMatieres()
        {
            foreach (Matiere matiere in _projet.ListeMatieres)
            {
                Module module = _repertoire.GetModule(matiere.CodeModule);
                matieresTextBox.Text += matiere.Libelle + " (" + matiere.Code + ")" + "\n";
                if (module != null)
                    matieresTextBox.Text += "    Module : " + module.Libelle + " (" + module.Code + ")\n";
            }
        }

        private void RetourAccueil_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
