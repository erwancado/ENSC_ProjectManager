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
    public partial class CreationProjet : Form
    {
        public Repertoire repertoire;
        List<Livrable> liste_livrables;
        Type typeProjet;
        public CreationProjet(Repertoire repertoire)
        {
            InitializeComponent();
            this.repertoire = repertoire;
            liste_livrables = new List<Livrable>();
            dateDebutProjet.Enabled = false;
            dateFinProjet.Enabled = false;
            listeMatiere.Enabled = false;
            listePromotion.Enabled = false;
            listeEtudiants.Enabled = false;
            listeProfesseurs.Enabled = false;
            listeExtes.Enabled = false;
            valider.Enabled = false;
            insertExte.Hide();
            insertProfesseur.Hide();
            insertEtudiant.Hide();
            retirerEtudiant.Hide();
            retirerProfesseur.Hide();
            retirerExte.Hide();
            retirerLivrable.Hide();
            ajouterLivrable.Enabled = false;
            ajouterEtudiant.Enabled = false;

            RemplirTypesProjet();
            this.CenterToScreen();
        }
        private void RemplirTypesProjet()
        {
            listeTypeProjet.BeginUpdate();
            listeTypeProjet.Items.Clear();
            foreach (Type type in repertoire.typesProjet)
            {
                listeTypeProjet.Items.Add("Projet " + type.TypePromotion.ToUpper() + " de " + type.NbMinEtudiants + " à " + type.NbMaxEtudiants + " étudiants");
            }
            listeTypeProjet.EndUpdate();
        }
        private void AjouterTypeProjet(Type type)
        {
            repertoire.typesProjet.Add(type);
            listeTypeProjet.BeginUpdate();
            listeTypeProjet.Items.Add("Projet " + type.TypePromotion.ToUpper() + " de " + type.NbMinEtudiants + " à " + type.NbMaxEtudiants + " étudiants");
            listeTypeProjet.EndUpdate();
        }
        private void AjouterLivrable(Livrable livrable)
        {
            if (affichageLivrables.Items.Count == 0)
            {
                dateDebutProjet.Enabled = false;
                dateFinProjet.Enabled = false;
                MessageBox.Show("Maintenant que vous avez ajouté un livrable, la modification des dates n'est plus possible." +
                    " Retirez le livrable si vous souhaitez modifier les dates du projet.", "Ajout d'un livrable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            liste_livrables.Add(livrable);
            affichageLivrables.BeginUpdate();
            affichageLivrables.Items.Add(livrable.Libelle + " (" + livrable.TypeFichier.ToUpper() + ") - " + livrable.DateRendu.ToShortDateString() + (livrable.Rendu ? " - Rendu" : " - Non rendu"));
            affichageLivrables.EndUpdate();
        }
        private void RemplirEtudiants(int[] anneePromos)
        {
            listeEtudiants.BeginUpdate();
            listeEtudiants.Items.Clear();
            foreach (int annee in anneePromos)
            {
                Promotion promotion = repertoire.GetPromotion(annee);
                if (promotion != null)
                {
                    foreach (Etudiant etudiant in promotion.Etudiants)
                    {
                        listeEtudiants.Items.Add(etudiant.Nom + " " + etudiant.Prenom + " _ promotion " + etudiant.AnneePromotion);
                    }
                }
            }
            listeEtudiants.EndUpdate();
        }
        private void AjouterEtudiant(Etudiant etudiant, int anneePromo)
        {
            Promotion promotion = repertoire.GetPromotion(anneePromo);
            bool promoVide = promotion == null;
            if (promoVide)
            {
                promotion = new Promotion(anneePromo);
            }
            promotion.AjouterEtudiant(etudiant);
            if (promoVide)
                repertoire.AddPromotion(promotion);
            else
                repertoire.AddEtudiant(etudiant);
            listeEtudiants.BeginUpdate();
            listeEtudiants.Items.Add(etudiant.Nom + " " + etudiant.Prenom + " _ promotion " + etudiant.AnneePromotion);
            listeEtudiants.EndUpdate();

        }
        private void RemplirPromos(string[] promotions)
        {
            listePromotion.BeginUpdate();
            listePromotion.Items.Clear();
            foreach (string promotion in promotions)
            {
                listePromotion.Items.Add(promotion);
            }
            listePromotion.EndUpdate();
        }
        private void RemplirMatieres(string[] promotion)
        {
            listeMatiere.BeginUpdate();
            listeMatiere.Items.Clear();
            foreach (Matiere matiere in repertoire.matieres)
            {
                if (promotion.Contains(matiere.Promo))
                {
                    listeMatiere.Items.Add(matiere.Code + "-" + matiere.Libelle);
                }
            }
            listeMatiere.EndUpdate();
        }

        private void AjouterMatiere(Matiere matiere, Module module)
        {
            repertoire.AddMatiere(matiere, module);
            listeMatiere.BeginUpdate();
            listeMatiere.Items.Add(matiere.Code + "-" + matiere.Libelle);
            listeMatiere.EndUpdate();
        }
        private void RemplirProfesseurs(Matiere[] matieres)
        {
            listeProfesseurs.BeginUpdate();
            listeProfesseurs.Items.Clear();
            foreach (Matiere matiere in matieres)
            {
                foreach (Professeur professeur in matiere.ListeProfesseurs)
                {
                    listeProfesseurs.Items.Add(professeur.Nom + " " + professeur.Prenom);
                }
            }
            listeProfesseurs.EndUpdate();
        }

        private void AjouterProfesseur(Professeur professeur, List<Matiere> matieresEnseignees)
        {
            repertoire.AddProfesseur(professeur, matieresEnseignees);
            listeProfesseurs.BeginUpdate();
            listeProfesseurs.Items.Add(professeur.Nom + " " + professeur.Prenom);
            listeProfesseurs.EndUpdate();
        }
        private void RemplirExtes()
        {
            listeExtes.BeginUpdate();
            listeExtes.Items.Clear();
            foreach (Exterieur exterieur in repertoire.intervenantsExte)
            {
                listeExtes.Items.Add(exterieur.Nom + " " + exterieur.Prenom + " - " + exterieur.Organisation);
            }
            listeExtes.EndUpdate();
        }

        private void AjouterExte(Exterieur intervenant)
        {
            repertoire.intervenantsExte.Add(intervenant);
            listeExtes.BeginUpdate();
            listeExtes.Items.Add(intervenant.Nom + " " + intervenant.Prenom + " - " + intervenant.Organisation);
            listeExtes.EndUpdate();
        }
        private int AnneePromo(string promotion)
        {
            int result = -1;
            if (promotion.Equals("1A"))
            {
                result = dateDebutProjet.Value.Month > 8 ? dateDebutProjet.Value.Year + 3 : dateDebutProjet.Value.Year + 2;
            }
            else if (promotion.Equals("2A"))
            {
                result = dateDebutProjet.Value.Month > 8 ? dateDebutProjet.Value.Year + 2 : dateDebutProjet.Value.Year + 1;
            }
            else
            {
                result = dateDebutProjet.Value.Month > 8 ? dateDebutProjet.Value.Year + 1 : dateDebutProjet.Value.Year;
            }
            return result;
        }

        private void DateDebutProjet_Validating(object sender, CancelEventArgs e)
        {
            DatesValidation();
            ajouterLivrable.Enabled = true;
            ajouterEtudiant.Enabled = true;
        }
        private void DateFinProjet_Validating(object sender, CancelEventArgs e)
        {
            DatesValidation();
            ajouterLivrable.Enabled = true;
            ajouterEtudiant.Enabled = true;
        }

        private void ListeTypeProjet_SelectedValueChanged(object sender, EventArgs e)
        {
            dateDebutProjet.Enabled = true;
            dateFinProjet.Enabled = true;
            listePromotion.Enabled = true;
            listeMatiere.Enabled = true;
            string libPromo = listeTypeProjet.SelectedItem.ToString().Split(' ')[1];
            string[] promotions = GetPromotions(libPromo);
            RemplirPromos(promotions);
            RemplirMatieres(promotions);
            typeProjet = repertoire.typesProjet[listeTypeProjet.SelectedIndex];
        }

        private string[] GetPromotions(string libPromo)
        {
            if (libPromo.Equals("TRANSPROMO") || libPromo.Equals("TRANSPROMOTION"))
            {
                return new string[] { "1A", "2A" };
            }
            else if (libPromo.Equals("1A") || libPromo.Equals("2A") || libPromo.Equals("3A"))
            {
                return new string[] { libPromo };
            }
            else
            {
                return new string[] { "1A", "2A", "3A" };
            }
        }

        private void ListePromotion_SelectedValueChanged(object sender, EventArgs e)
        {
            List<string> promotions = new List<string>();
            List<int> anneesPromos = new List<int>();
            for (int i = 0; i < listePromotion.CheckedItems.Count; i++)
            {
                string promo = listePromotion.CheckedItems[i].ToString();
                promotions.Add(promo);
                anneesPromos.Add(AnneePromo(promo));
            }
            RemplirMatieres(promotions.ToArray());
            listeEtudiants.Enabled = true;
            RemplirEtudiants(anneesPromos.ToArray());
        }

        private void ListeMatiere_SelectedValueChanged(object sender, EventArgs e)
        {
            List<Matiere> matieres = new List<Matiere>();
            for (int i = 0; i < listeMatiere.CheckedItems.Count; i++)
            {
                string code = listeMatiere.CheckedItems[i].ToString().Split('-')[0];
                Matiere matiere = repertoire.GetMatiere(code);
                if (matiere != null)
                    matieres.Add(matiere);
            }
            listeProfesseurs.Enabled = true;
            listeExtes.Enabled = true;
            RemplirProfesseurs(matieres.ToArray());
            RemplirExtes();
        }


        private void DatesValidation()
        {
            if (dateDebutProjet.Value > dateFinProjet.Value)
            {
                dateFinProjet.Value = dateDebutProjet.Value.AddDays(1);
            }
            else if (dateDebutProjet.Value.Month > 8)
            {
                if (DateTimeSpan.CompareDates(dateDebutProjet.Value, dateFinProjet.Value).Months > (18 - dateDebutProjet.Value.Month))
                {
                    dateFinProjet.Value = dateDebutProjet.Value.AddMonths(18 - dateDebutProjet.Value.Month);
                }
            }
            else if (dateDebutProjet.Value.Month < 7)
            {
                if (DateTimeSpan.CompareDates(dateDebutProjet.Value, dateFinProjet.Value).Months > (7 - dateDebutProjet.Value.Month))
                {
                    dateFinProjet.Value = dateDebutProjet.Value.AddMonths(7 - dateDebutProjet.Value.Month);
                }
            }
        }

        private void insertEtudiant_Click(object sender, EventArgs e)
        {
            if (affichageEtudiants.Items.Count < typeProjet.NbMaxEtudiants)
            {
                affichageEtudiants.BeginUpdate();
                if (listeEtudiants.SelectedItem != null)
                    affichageEtudiants.Items.Add(listeEtudiants.SelectedItem);
                affichageEtudiants.EndUpdate();
                if (affichageEtudiants.Items.Count >= typeProjet.NbMinEtudiants)
                {
                    valider.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Nombre maximum d'étudiants atteint", "Le type de projet choisi indique un maximum de ."+typeProjet.NbMaxEtudiants+" étudiants.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void retirerEtudiant_Click(object sender, EventArgs e)
        {
            if (affichageEtudiants.SelectedItem != null)
            {
                affichageEtudiants.BeginUpdate();
                affichageEtudiants.Items.RemoveAt(affichageEtudiants.SelectedIndex);
                affichageEtudiants.EndUpdate();
                if(affichageEtudiants.Items.Count < typeProjet.NbMinEtudiants)
                {
                    valider.Enabled = false;
                }
            }
        }

        private void insertProfesseur_Click(object sender, EventArgs e)
        {
            affichageProfesseurs.BeginUpdate();
            if (listeProfesseurs.SelectedItem != null)
                affichageProfesseurs.Items.Add(listeProfesseurs.SelectedItem);
            affichageProfesseurs.EndUpdate();
        }

        private void listeEtudiants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeEtudiants.SelectedItem == null)
                insertEtudiant.Hide();
            else
            {
                insertEtudiant.Show();
                affichageEtudiants.ClearSelected();
            }
        }

        private void affichageEtudiants_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageEtudiants.SelectedItem == null)
                retirerEtudiant.Hide();
            else
            {
                retirerEtudiant.Show();
                listeEtudiants.ClearSelected();
            }

        }

        private void listeProfesseurs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeProfesseurs.SelectedItem == null)
                insertProfesseur.Hide();
            else
            {
                insertProfesseur.Show();
                affichageProfesseurs.ClearSelected();
            }
        }

        private void affichageProfesseurs_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageProfesseurs.SelectedItem == null)
                retirerProfesseur.Hide();
            else
            {
                retirerProfesseur.Show();
                listeProfesseurs.ClearSelected();
            }

        }

        private void listeExtes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listeExtes.SelectedItem == null)
                insertExte.Hide();
            else
            {
                insertExte.Show();
                affichageExtes.ClearSelected();
            }

        }

        private void affichageExtes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageExtes.SelectedItem == null)
                retirerExte.Hide();
            else
            {
                retirerExte.Show();
                listeExtes.ClearSelected();
            }

        }

        private void affichageLivrables_SelectedValueChanged(object sender, EventArgs e)
        {
            if (affichageLivrables.SelectedItem == null)
                retirerLivrable.Hide();
            else
                retirerLivrable.Show();
        }

        private void retirerProfesseur_Click(object sender, EventArgs e)
        {
            if (affichageProfesseurs.SelectedItem != null)
            {
                affichageProfesseurs.BeginUpdate();
                affichageProfesseurs.Items.RemoveAt(affichageProfesseurs.SelectedIndex);
                affichageProfesseurs.EndUpdate();
            }
        }

        private void retirerExte_Click(object sender, EventArgs e)
        {
            if (affichageExtes.SelectedItem != null)
            {
                affichageExtes.BeginUpdate();
                affichageExtes.Items.RemoveAt(affichageEtudiants.SelectedIndex);
                affichageExtes.EndUpdate();
            }
        }

        private void retirerLivrable_Click(object sender, EventArgs e)
        {
            if (affichageLivrables.SelectedItem != null)
            {
                affichageLivrables.BeginUpdate();
                affichageLivrables.Items.RemoveAt(affichageEtudiants.SelectedIndex);
                affichageLivrables.EndUpdate();
                liste_livrables.RemoveAt(affichageEtudiants.SelectedIndex);
                if (affichageLivrables.Items.Count == 0)
                {
                    dateDebutProjet.Enabled = true;
                    dateFinProjet.Enabled = false;
                }
            }
        }

        private void insertExte_Click(object sender, EventArgs e)
        {
            affichageExtes.BeginUpdate();
            if (listeExtes.SelectedItem != null)
                affichageExtes.Items.Add(listeProfesseurs.SelectedItem);
            affichageExtes.EndUpdate();
        }

        private void ajouterType_Click(object sender, EventArgs e)
        {
            AjoutType formAjoutType = new AjoutType();
            formAjoutType.Show();
            formAjoutType.VisibleChanged += formVisibleChangedAjouterType;

        }
        private void formVisibleChangedAjouterType(object sender, EventArgs e)
        {
            AjoutType form = (AjoutType)sender;
            if (!form.Visible)
            {
                this.AjouterTypeProjet(form.ReturnType);
                form.Dispose();
            }


        }

        private void ajouterLivrable_Click(object sender, EventArgs e)
        {
            AjoutLivrable formAjoutLivrable = new AjoutLivrable(dateDebutProjet.Value, dateFinProjet.Value);
            formAjoutLivrable.Show();
            formAjoutLivrable.VisibleChanged += formVisibleChangedAjouterLivrable;
        }
        private void formVisibleChangedAjouterLivrable(object sender, EventArgs e)
        {
            AjoutLivrable form = (AjoutLivrable)sender;
            if (!form.Visible)
            {
                this.AjouterLivrable(form.ReturnLivrable);
                form.Dispose();
            }
        }

        private void ajouterEtudiant_Click(object sender, EventArgs e)
        {
            AjoutEtudiant formAjoutEtudiant = new AjoutEtudiant(AnneePromo("1A"));
            formAjoutEtudiant.Show();
            formAjoutEtudiant.VisibleChanged += formVisibleChangedAjouterEtudiant;
        }
        private void formVisibleChangedAjouterEtudiant(object sender, EventArgs e)
        {
            AjoutEtudiant form = (AjoutEtudiant)sender;
            if (!form.Visible)
            {
                AjouterEtudiant(form.ReturnEtudiant, form.ReturnAnneePromo);
                form.Dispose();
            }
        }

        private void ajouterProfesseur_Click(object sender, EventArgs e)
        {
            AjoutProf formAjoutProf = new AjoutProf(repertoire);
            formAjoutProf.Show();
            formAjoutProf.VisibleChanged += formVisibleChangedAjouterProfesseur;
        }
        private void formVisibleChangedAjouterProfesseur(object sender, EventArgs e)
        {
            AjoutProf form = (AjoutProf)sender;
            if (!form.Visible)
            {
                AjouterProfesseur(form.ReturnProfesseur, form.ReturnMatieresEnseignees);
                form.Dispose();
            }
        }

        private void ajoutMatiere_Click(object sender, EventArgs e)
        {
            AjoutMatiere formAjoutMatiere = new AjoutMatiere(repertoire);
            formAjoutMatiere.Show();
            formAjoutMatiere.VisibleChanged += formVisibleChangedAjouterMatiere;
        }

        private void formVisibleChangedAjouterMatiere(object sender, EventArgs e)
        {
            AjoutMatiere form = (AjoutMatiere)sender;
            if (!form.Visible)
            {
                AjouterMatiere(form.ReturnMatiere, form.ReturnModule);
                form.Dispose();
            }
        }

        private void ajouterExte_Click(object sender, EventArgs e)
        {
            AjoutExterieur formAjoutExterieur = new AjoutExterieur();
            formAjoutExterieur.Show();
        }

        private void formVisibleChangedAjouterExterieur(object sender, EventArgs e)
        {
            AjoutExterieur form = (AjoutExterieur)sender;
            if (!form.Visible)
            {
                AjouterExte(form.ReturnIntervenant);
                form.Dispose();
            }
        }

        private List<Etudiant> EtudiantsProjet()
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            for(int i=0; i < affichageEtudiants.Items.Count;i++)
            {
                string strEtudiant = affichageEtudiants.Items[i].ToString();
                string nomEtPrenom = strEtudiant.Split('_')[0];
                string promotion = strEtudiant.Split('_')[1];
                Etudiant etudiant = repertoire.GetEtudiant(int.Parse(promotion.Split(' ')[2]), nomEtPrenom.Split(' ')[0], nomEtPrenom.Split(' ')[1]);
                if (etudiant != null)
                    etudiants.Add(etudiant);
            }
            return etudiants;
        }

        private List<Professeur> ProfesseursProjet()
        {
            List<Professeur> professeurs = new List<Professeur>();
            for(int i=0; i < affichageProfesseurs.Items.Count; i++)
            {
                string strProf = affichageProfesseurs.Items[i].ToString();
                Professeur professeur = repertoire.GetProfesseur(strProf.Split(' ')[0], strProf.Split(' ')[1]);
                if (professeur != null)
                    professeurs.Add(professeur);
            }
            return professeurs;
        }

        private List<Exterieur> IntervenantsExteProjet()
        {
            List<Exterieur> intervenantsExte = new List<Exterieur>();
            for(int i = 0; i < affichageExtes.Items.Count; i++)
            {
                string strExte = affichageExtes.Items[i].ToString();
                Exterieur exterieur = repertoire.GetExterieur(strExte.Split(' ')[0], strExte.Split(' ')[1], strExte.Split(' ')[2]);
                if (exterieur != null)
                {
                    intervenantsExte.Add(exterieur);
                }
            }
            return intervenantsExte;
        }

        private List<Matiere> MatieresProjet()
        {
            List<Matiere> matieres = new List<Matiere>();
            for(int i=0; i < listeMatiere.CheckedItems.Count; i++)
            {
                Matiere matiere = repertoire.GetMatiere(listeMatiere.CheckedItems[i].ToString().Split('-')[0]);
                if (matiere != null)
                    matieres.Add(matiere);
            }
            return matieres;
        }
        private void valider_Click(object sender, EventArgs e)
        {
            List<Intervenant> intervenants = new List<Intervenant>();
            List<Etudiant> etudiantsProjet = EtudiantsProjet();
            foreach (Etudiant etudiant in etudiantsProjet)
                intervenants.Add(etudiant);
            foreach (Professeur professeur in ProfesseursProjet())
                intervenants.Add(professeur);
            foreach (Exterieur exterieur in IntervenantsExteProjet())
                intervenants.Add(exterieur);
            if (nomProjet.TextLength > 0)
            {
                if (listeMatiere.CheckedItems.Count > 0)
                {
                    if(etudiantsProjet.Count>=typeProjet.NbMinEtudiants && etudiantsProjet.Count <= typeProjet.NbMaxEtudiants)
                    {
                        if (liste_livrables.Count > 0)
                        {
                            AjoutRoles formAjoutRoles = new AjoutRoles(intervenants, repertoire);
                            formAjoutRoles.Show();
                            formAjoutRoles.VisibleChanged += formVisibleChangedAjouterRoles;
                        }
                        else
                            MessageBox.Show("Livrable manquant", "Veuillez ajouter un livrable au projet.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Nombre d'étudiants incorrect", "Le groupe de projet doit être composé de "
                            +typeProjet.NbMinEtudiants+" à "+typeProjet.NbMaxEtudiants+" étudiants.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Matière manquante", "Veuillez sélectionner la ou les matières dont fait parti le projet.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Nom de projet manquant", "Veuillez renseigner le nom du projet.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void formVisibleChangedAjouterRoles(object sender, EventArgs e)
        {
            AjoutRoles form = (AjoutRoles)sender;
            if (!form.Visible)
            {
                repertoire.roles.AddRange(form.ReturnRoles);
                Projet projet = new Projet(nomProjet.Text, descriptionProjet.Text, dateDebutProjet.Value, dateFinProjet.Value, typeProjet);
                projet.ListeLivrables = liste_livrables;
                projet.ListeRoles = form.ReturnRoles;
                projet.ListeMatieres = MatieresProjet();
                repertoire.projets.Add(projet);
                repertoire.SaveData();
                form.Dispose();
                this.Visible = false;
            }
        }

        
    }
}