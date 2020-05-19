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
        public Repertoire _repertoire;
        public List<Projet> _projets;

        public Accueil(Repertoire repertoire)
        {
            InitializeComponent();
            this._repertoire = repertoire;
            niveaux.Items.Add("1A");
            niveaux.Items.Add("2A");
            niveaux.Items.Add("3A");
            _projets = _repertoire.projets;
            rechercherMatiere.Enabled = false;
            rechercherModule.Enabled = false;
            RemplirAnneePromo();
            RemplirMatiere();
            RemplirModule();

        }

        private void BoutonNouveauProjet_Click(object sender, EventArgs e)
        {
            Application.Run(new CreationProjet(_repertoire));
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
            List<Projet> projetsFiltreAnneeDePromo = new List<Projet>();
            foreach (Projet projet in _projets)
            {
                List<int> annee = RecupererAnneesDePromo();
                int anneePromo = projet.AnneesPromos()[0];
                int anneeTranspromo = projet.AnneesPromos()[1];
                for(int i=0; i<annee.Count;i++)
                {
                    if (annee[i]== anneePromo || annee[i] == anneeTranspromo-1)
                    {
                        projetsFiltreAnneeDePromo.Add(projet);
                    }
                }
            }
            _projets = projetsFiltreAnneeDePromo;
        }
        public void FiltrerParNiveaux()
        {
            List<Projet> projetsFiltreNiveaux = new List<Projet>();
            List<String> niveauxSelectionnes = RecupererNiveaux();
            
            foreach(String niveau in niveauxSelectionnes)
            {
                if (niveau == "1A")
                {
                    foreach (Projet projet in _projets)
                    {
                        if (projet.Type.TypePromotion.Equals("1A") || projet.Type.TypePromotion.Equals("Transpromo"))
                        {
                            projetsFiltreNiveaux.Add(projet);
                        }
                    }

                }
                else if (niveau == "2A")
                {
                    foreach (Projet projet in _projets)
                    {
                        if (projet.Type.TypePromotion.Equals("2A")|| projet.Type.TypePromotion.Equals("Transpromo"))
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
                _projets = projetsFiltreNiveaux;
            }
        }
        public void FiltrerParMatieres()
        {
            List<Projet> projetsFiltreMatieres = new List<Projet>();
            foreach (Projet projet in _projets)
            {
                if (projet.ContenirMatiere(RecupererMatieres()))
                    projetsFiltreMatieres.Add(projet);
            }
            _projets = projetsFiltreMatieres;
        }
        public void FiltrerParModules()
        {
            List<Projet> projetsFiltreModules = new List<Projet>();
            foreach (Projet projet in _projets)
            {
                if (projet.ContenirModule(RecupererModules()))
                    projetsFiltreModules.Add(projet);
            }
            _projets = projetsFiltreModules;
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
    }
}
