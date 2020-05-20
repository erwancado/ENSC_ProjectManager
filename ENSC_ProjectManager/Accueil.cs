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
    public partial class Accueil : Form
    {
        List<Projet> _projets;
        Repertoire _repertoire;
        public Accueil(Repertoire repertoire)
        {
            InitializeComponent();
            this.CenterToScreen();
            _repertoire = repertoire;
            InitialiserAccueil();
        }

        private void InitialiserAccueil()
        {
            _projets = _repertoire.projets;
            niveaux.BeginUpdate();
            niveaux.Items.Clear();
            niveaux.Items.Add("1A");
            niveaux.Items.Add("2A");
            niveaux.Items.Add("3A");
            niveaux.EndUpdate();
            RemplirEtudiants();
            RemplirProfesseurs();
            RemplirExtes();
            RemplirProjets(); 
            RemplirAnneePromo();
            RemplirMatiere();
            RemplirModule();
            rechercherMatiere.Enabled = false;
            rechercherModule.Enabled = false;
            resultatsRecherchePersonne.Hide();
        }
        private void BoutonNouveauProjet_Click(object sender, EventArgs e)
        {
            CreationProjet formCreationProjet = new CreationProjet(_repertoire);
            formCreationProjet.Show();
            formCreationProjet.VisibleChanged += formVisibleChangedCreationProjet;
        }

        private void formVisibleChangedCreationProjet(object sender, EventArgs e)
        {
            CreationProjet form = (CreationProjet)sender;
            if (!form.Visible)
            {
                this._repertoire = form.repertoire;
                InitialiserAccueil();
                form.Dispose();
            }
        }

        private void FiltrerParDates()
        {
            if (checkBoxDate.Checked)
            {
                List<Projet> projetsRecherche = new List<Projet>();
                foreach (Projet projet in _projets)
                {
                    if ((dateDebut.Value >= projet.DateDebut && dateDebut.Value <= projet.DateFin)
                        || (dateFin.Value >= projet.DateDebut && dateFin.Value <= projet.DateFin))
                    {
                        projetsRecherche.Add(projet);
                    }
                }
                _projets = projetsRecherche;
            }
        }
        private void FiltrerParIntervenant()
        {
            if(listeEleves.CheckedItems.Count!=0 || listeProfs.CheckedItems.Count!=0 || listeIntervenants.CheckedItems.Count!=0)
                _projets = RechercheParIntervenant(GetIntervenantsFiltre());
        }
        private List<Projet> RechercheParIntervenant(List<Intervenant> intervenants)
        {
            List<Projet> projetsRecherche = new List<Projet>();
            foreach (Projet projet in _projets)
            {
                bool intervenantsDansProjet = true;
                foreach (Intervenant intervenant in intervenants)
                {
                    if (!projet.ContientIntervenant(intervenant))
                        intervenantsDansProjet = false;
                }
                if (intervenantsDansProjet)
                    projetsRecherche.Add(projet);
            }
            return projetsRecherche;
        }

        private List<Intervenant> GetIntervenantsFiltre()
        {
            List<Intervenant> intervenantsFiltre = new List<Intervenant>();
            for(int i =0; i<listeEleves.CheckedItems.Count; i++)
            {
                string strEtudiant = listeEleves.CheckedItems[i].ToString();
                string nomEtPrenom = strEtudiant.Split('_')[0];
                string promotion = strEtudiant.Split('_')[1];
                Etudiant etudiant = _repertoire.GetEtudiant(int.Parse(promotion.Split(' ')[2]), nomEtPrenom.Split(' ')[0], nomEtPrenom.Split(' ')[1]);
                if (etudiant != null)
                    intervenantsFiltre.Add(etudiant);
            }
            for(int j=0; j<listeProfs.CheckedItems.Count; j++)
            {
                string strProf = listeProfs.CheckedItems[j].ToString();
                Professeur professeur = _repertoire.GetProfesseur(strProf.Split(' ')[0], strProf.Split(' ')[1]);
                if (professeur != null)
                    intervenantsFiltre.Add(professeur);
            }
            for(int k=0; k<listeIntervenants.CheckedItems.Count; k++)
            {
                string strExte = listeIntervenants.CheckedItems[k].ToString();
                Exterieur exterieur = _repertoire.GetExterieur(strExte.Split(' ')[0], strExte.Split(' ')[1], strExte.Split(' ')[2]);
                if (exterieur != null)
                {
                    intervenantsFiltre.Add(exterieur);
                }
            }
            return intervenantsFiltre;
        }


        private void RemplirEtudiants()
        {
            listeEleves.BeginUpdate();
            listeEleves.Items.Clear();
            foreach (Promotion promotion in _repertoire.promotions)
            {
                foreach (Etudiant etudiant in promotion.Etudiants)
                {
                    listeEleves.Items.Add(etudiant.Nom + " " + etudiant.Prenom + " _ promotion " + etudiant.AnneePromotion);
                }
            }
            listeEleves.EndUpdate();
        }
        private void RemplirProfesseurs()
        {
            listeProfs.BeginUpdate();
            listeProfs.Items.Clear();
            foreach (Professeur professeur in _repertoire.professeurs)
            {
                listeProfs.Items.Add(professeur.Nom + " " + professeur.Prenom);
            }
            listeProfs.EndUpdate();
        }

        private void RemplirExtes()
        {
            listeIntervenants.BeginUpdate();
            listeIntervenants.Items.Clear();
            foreach (Exterieur exterieur in _repertoire.intervenantsExte)
            {
                listeIntervenants.Items.Add(exterieur.Nom + " " + exterieur.Prenom + " - " + exterieur.Organisation);
            }
            listeIntervenants.EndUpdate();
        }

        private void RemplirProjets()
        {
            listeProjets.BeginUpdate();
            listeProjets.Items.Clear();
            foreach(Projet projet in _projets)
            {
                string itemProjet = projet.Libelle+" -- -- ";
                foreach (Role role in projet.ListeRoles)
                    itemProjet += " "+role.Intervenant.Nom + " ";
                itemProjet += " -- -- " + projet.DateDebut.Year + " " + projet.Type.TypePromotion + "\n";
                listeProjets.Items.Add(itemProjet);
            }
            listeProjets.EndUpdate();
        }

        private List<string> RechercherEtudiants(string nomRecherche, string prenomRecherche)
        {
            List<string> etudiantsRecherche = new List<string>();
            for (int i = 0; i < listeEleves.Items.Count; i++)
            {
                string strEtudiant = listeEleves.Items[i].ToString();
                string nomEtPrenom = strEtudiant.Split('_')[0];
                string nomEtu = nomEtPrenom.Split(' ')[0];
                string prenomEtu = nomEtPrenom.Split(' ')[1];
                if (nomEtu.ToLower().Contains(nomRecherche.ToLower()) && prenomEtu.ToLower().Contains(prenomRecherche.ToLower()))
                    etudiantsRecherche.Add(nomEtu + " " + prenomEtu + " E-" + i);
            }
            return etudiantsRecherche;
        }

        private List<string> RechercherProfesseurs(string nomRecherche, string prenomRecherche)
        {
            List<string> professeursRecherche = new List<string>();
            for (int i = 0; i < listeProfs.Items.Count; i++)
            {
                string strProfesseur = listeProfs.Items[i].ToString();
                string nomProf = strProfesseur.Split(' ')[0];
                string prenomProf = strProfesseur.Split(' ')[1];
                if (nomProf.ToLower().Contains(nomRecherche.ToLower()) && prenomProf.ToLower().Contains(prenomRecherche.ToLower()))
                    professeursRecherche.Add(nomProf + " " + prenomProf + " P-" + i);
            }
            return professeursRecherche;
        }

        private List<string> RechercherExterieurs(string nomRecherche, string prenomRecherche)
        {
            List<string> exterieursRecherche = new List<string>();
            for (int i = 0; i < listeIntervenants.Items.Count; i++)
            {
                string strExterieur = listeEleves.CheckedItems[i].ToString();
                string nomExte = strExterieur.Split(' ')[0];
                string prenomExte = strExterieur.Split(' ')[1];
                if (nomExte.ToLower().Contains(nomRecherche.ToLower()) && prenomExte.ToLower().Contains(prenomRecherche.ToLower()))
                    exterieursRecherche.Add(nomExte + " " + prenomExte + " I-" + i);
            }
            return exterieursRecherche;
        }

        

        private void RechercherPersonne_Click(object sender, EventArgs e)
        {
            resultatsRecherchePersonne.Show();
            resultatsRecherchePersonne.BeginUpdate();
            resultatsRecherchePersonne.Items.Clear();
            if(NomRecherche.TextLength!=0 || PrenomRecherche.TextLength != 0)
            {
                resultatsRecherchePersonne.Items.AddRange(RechercherEtudiants(NomRecherche.Text, PrenomRecherche.Text).ToArray());
                resultatsRecherchePersonne.Items.AddRange(RechercherProfesseurs(NomRecherche.Text, PrenomRecherche.Text).ToArray());
                resultatsRecherchePersonne.Items.AddRange(RechercherExterieurs(NomRecherche.Text, PrenomRecherche.Text).ToArray());
            }
            else
            {
                resultatsRecherchePersonne.Hide();
            }
            resultatsRecherchePersonne.EndUpdate();
            UpdateCheckedResultats();
        }

        private void resultatsRecherchePersonne_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listeEleves.BeginUpdate();
            listeProfs.BeginUpdate();
            listeIntervenants.BeginUpdate();
            for (int i=0; i < resultatsRecherchePersonne.Items.Count; i++)
            {
                string codeItem = resultatsRecherchePersonne.Items[i].ToString().Split(' ')[2];
                string typePersonne = codeItem.Split('-')[0];
                int indexPersonne = int.Parse(codeItem.Split('-')[1]);
                if (typePersonne.Equals("E"))
                {
                    if (!resultatsRecherchePersonne.CheckedIndices.Contains(i))
                        listeEleves.SetItemChecked(indexPersonne, true);
                    else
                        listeEleves.SetItemChecked(indexPersonne, false);
                }
                else if (typePersonne.Equals("P"))
                {
                    if (!resultatsRecherchePersonne.CheckedIndices.Contains(i))
                        listeProfs.SetItemChecked(indexPersonne, true);
                    else
                        listeProfs.SetItemChecked(indexPersonne, false);
                }
                else
                {
                    if (!resultatsRecherchePersonne.CheckedIndices.Contains(i))
                        listeIntervenants.SetItemChecked(indexPersonne, true);
                    else
                        listeIntervenants.SetItemChecked(indexPersonne, false);
                }
            }
            listeEleves.EndUpdate();
            listeProfs.EndUpdate();
            listeIntervenants.EndUpdate();
        }

        private void UpdateCheckedResultats()
        {
            resultatsRecherchePersonne.BeginUpdate();
            for (int i = 0; i < resultatsRecherchePersonne.Items.Count; i++)
            {
                string codeItem = resultatsRecherchePersonne.Items[i].ToString().Split(' ')[2];
                string typePersonne = codeItem.Split('-')[0];
                int indexPersonne = int.Parse(codeItem.Split('-')[1]);
                if (typePersonne.Equals("E"))
                {
                    if (listeEleves.CheckedIndices.Contains(indexPersonne))
                        resultatsRecherchePersonne.SetItemChecked(i, true);
                    else
                        resultatsRecherchePersonne.SetItemChecked(i, false);
                }
                else if (typePersonne.Equals("P"))
                {
                    if (listeProfs.CheckedIndices.Contains(indexPersonne))
                        resultatsRecherchePersonne.SetItemChecked(i, true);
                    else
                        resultatsRecherchePersonne.SetItemChecked(i, false);
                }
                else
                {
                    if (listeIntervenants.CheckedIndices.Contains(indexPersonne))
                        resultatsRecherchePersonne.SetItemChecked(i, true);
                    else
                        resultatsRecherchePersonne.SetItemChecked(i, false);
                }
            }
            resultatsRecherchePersonne.EndUpdate();
        }

        private void listeEleves_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //UpdateCheckedResultats();
        }

        private void listeProfs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //UpdateCheckedResultats();
        }

        private void listeIntervenants_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //UpdateCheckedResultats();
        }

        private void nomDeProjet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                List<Projet> projetsRecherche = new List<Projet>();
                foreach (Projet projet in _projets)
                {
                    if (projet.Libelle.ToLower().Contains(nomDeProjet.Text.ToLower()))
                        projetsRecherche.Add(projet);
                }
                List<Projet> projetsTmp = _projets;
                _projets = projetsRecherche;
                RemplirProjets();
                _projets = projetsTmp;
            }
        }

        private void AppliquerFiltres_Click(object sender, EventArgs e)
        {
            _projets = _repertoire.projets;
            FiltrerParNiveaux();
            FiltrerParAnneeDePromo();
            FiltrerParDates();
            FiltrerParModules();
            FiltrerParMatieres();
            FiltrerParIntervenant();
            RemplirProjets();
        }

        private void dateDebut_ValueChanged(object sender, EventArgs e)
        {
            dateFin.MinDate = dateDebut.Value;
        }

       public void RemplirAnneePromo()
        {
            listeAnneePromo.BeginUpdate();
            listeAnneePromo.Items.Clear();
            List<String> listeAnneesExistantes = new List<String>();
            foreach(Projet projet in _repertoire.projets)
            {
                foreach (int anneePromo in projet.AnneesPromos())
                {
                    if (!listeAnneesExistantes.Contains(anneePromo.ToString()))
                    {
                        listeAnneesExistantes.Add(anneePromo.ToString());
                    }
                }
            }
            listeAnneePromo.Items.AddRange(listeAnneesExistantes.ToArray());
            listeAnneePromo.EndUpdate();
        }
        public void RemplirModule()
        {
            listeModules.BeginUpdate();
            listeModules.Items.Clear();
            foreach (Module module in _repertoire.modules)
            {
                listeModules.Items.Add(module.Code + "-" + module.Libelle);
            }
            listeModules.EndUpdate();
        }
        public void RemplirMatiere()
        {
            listeMatieres.BeginUpdate();
            listeMatieres.Items.Clear();
            foreach (Matiere matiere in _repertoire.matieres)
            {
                listeMatieres.Items.Add(matiere.Libelle);
            }
            listeMatieres.EndUpdate();
        }
        public void FiltrerParAnneeDePromo()
        {
            if (listeAnneePromo.CheckedItems.Count != 0)
            {
                List<Projet> projetsFiltreAnneeDePromo = new List<Projet>();
                foreach (Projet projet in _projets)
                {
                    List<int> annee = RecupererAnneesDePromo();
                    bool anneeCorrespond = false;
                    foreach (int anneePromo in projet.AnneesPromos())
                    {
                        if (annee.Contains(anneePromo))
                            anneeCorrespond = true;
                    }
                    if (anneeCorrespond)
                        projetsFiltreAnneeDePromo.Add(projet);
                }
                _projets = projetsFiltreAnneeDePromo;
            }
            
        }
        public void FiltrerParNiveaux()
        {
            List<Projet> projetsFiltreNiveaux = new List<Projet>();
            List<String> niveauxSelectionnes = RecupererNiveaux();
            if (niveauxSelectionnes.Count != 0)
            {
                foreach (String niveau in niveauxSelectionnes)
                {
                    if (niveau.Equals("1A"))
                    {
                        foreach (Projet projet in _projets)
                        {
                            if (projet.Type.TypePromotion.Equals("1A") || projet.Type.TypePromotion.Equals("Transpromo"))
                            {
                                projetsFiltreNiveaux.Add(projet);
                            }
                        }

                    }
                    else if (niveau.Equals("2A"))
                    {
                        foreach (Projet projet in _projets)
                        {
                            if (projet.Type.TypePromotion.Equals("2A") || projet.Type.TypePromotion.Equals("Transpromo"))
                            {
                                projetsFiltreNiveaux.Add(projet);
                            }
                        }

                    }
                    else
                    {
                        foreach (Projet projet in _projets)
                        {
                            if (projet.Type.TypePromotion.Equals("3A"))
                            {
                                projetsFiltreNiveaux.Add(projet);
                            }
                        }
                    }
                }
                _projets = projetsFiltreNiveaux;
            }
        }
        public void FiltrerParMatieres()
        {
            if (listeMatieres.CheckedItems.Count != 0)
            {
                List<Projet> projetsFiltreMatieres = new List<Projet>();
                foreach (Projet projet in _projets)
                {
                    if (projet.ContenirMatiere(RecupererMatieres()))
                        projetsFiltreMatieres.Add(projet);
                }
                _projets = projetsFiltreMatieres;
            }
        }
        public void FiltrerParModules()
        {
            if (listeModules.CheckedItems.Count != 0)
            {
                List<Projet> projetsFiltreModules = new List<Projet>();
                foreach (Projet projet in _projets)
                {
                    if (projet.ContenirModule(RecupererModules()))
                        projetsFiltreModules.Add(projet);
                }
                _projets = projetsFiltreModules;
            }
        }
        public List<int> RecupererAnneesDePromo()
        {
            List<int> listeAnneesDePromo = new List<int>();
            for (int i = 0; i < listeAnneePromo.CheckedItems.Count; i++)
            {
                string annee = listeAnneePromo.CheckedItems[i].ToString();
                int anneePromo = Convert.ToInt32(annee);
                listeAnneesDePromo.Add(anneePromo);
            }
            return listeAnneesDePromo;
        }
        public List<String> RecupererModules()
        {
            List<String> listeDeModules = new List<String>();
            for (int i = 0; i < listeModules.CheckedItems.Count; i++)
            {
                listeDeModules.Add(listeModules.CheckedItems[i].ToString().Split('-')[0]);
            }
            return listeDeModules;
        }
        public List<String> RecupererNiveaux()
        {
            List<String> listeNiveaux = new List<String>();
            for (int i = 0;i<niveaux.CheckedItems.Count;i++)
            {
                listeNiveaux.Add(niveaux.CheckedItems[i].ToString());
            }
            return listeNiveaux;
        }
        public List<String> RecupererMatieres()
        {
            List<String> listeDeMatieres = new List<String>();
            for (int i = 0; i < listeMatieres.CheckedItems.Count; i++)
            {
                listeDeMatieres.Add(listeMatieres.CheckedItems[i].ToString());
            }
            return listeDeMatieres;
        }
        private void Matiere_KeyPress(object sender, KeyPressEventArgs e)
        {
            rechercherMatiere.Enabled = true;
        }
        private void Module_KeyPress(object sender, KeyPressEventArgs e)
        {
            rechercherModule.Enabled = true;
        }
        private void RechercherMatiere_Click(object sender, EventArgs e)
        {
            if (matiere.TextLength == 0)
            {
                listeMatieres.ClearSelected();
            }
            else
            {
                for (int i = 0; i < listeMatieres.Items.Count; i++)
                {
                    if (listeMatieres.Items[i].ToString().ToLower().Contains(matiere.Text.ToLower()))
                    {
                        listeMatieres.SetSelected(i, true);
                        return;
                    }
                }
                listeMatieres.ClearSelected();
            }
        }

        private void RechercherModule_Click(object sender, EventArgs e)
        {
            if (module.TextLength == 0)
            {
                listeModules.ClearSelected();
            }
            else
            {
                for (int i = 0; i < listeModules.Items.Count; i++)
                {
                    if (listeModules.Items[i].ToString().ToLower().Contains(module.Text.ToLower()))
                    {
                        listeModules.SetSelected(i, true);
                        return;
                    }
                    listeModules.ClearSelected();
                }
            }
        }

        private void listeProjets_DoubleClick(object sender, EventArgs e)
        {
            Projet selected = _projets[listeProjets.SelectedIndex];
            AffichageProjet affichageProjet = new AffichageProjet(_repertoire, selected);
            affichageProjet.Show();
        }
    }
}
