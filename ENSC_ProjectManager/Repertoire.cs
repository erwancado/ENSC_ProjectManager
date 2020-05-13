using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ENSC_ProjectManager
{
    [XmlRoot("Repertoire", IsNullable = false)]
    public class Repertoire
    {
        public List<Type> typesProjet;
        public Dictionary<int,Promotion> promotions;
        public List<Matiere> matieres;
        public List<Module> modules;
        public List<Role> roles;
        public List<Professeur> professeurs;
        public List<Exterieur> intervenantsExte;
        public List<Projet> projets;
        public String[] typesPromos;
        public Repertoire()
        {
            typesProjet = new List<Type>();
            promotions = new Dictionary<int, Promotion>();
            modules = new List<Module>();
            matieres = new List<Matiere>();
            roles = new List<Role>();
            professeurs = new List<Professeur>();
            intervenantsExte = new List<Exterieur>();
            projets = new List<Projet>();
        }

        public void AddPromotion(Promotion promotion)
        {
            promotions.Add(promotion.Annee, promotion);
        }
        public void AddModule(Module mod)
        {
            modules.Add(mod);
            foreach (Matiere matiere in matieres)
            { matieres.Add(matiere); }

        }
        public Promotion GetPromotion(int annee)
        {
            Promotion promotion;
            promotions.TryGetValue(annee, out promotion);
            return promotion;
        }
        public void AddEtudiant(Etudiant etudiant)
        {
            promotions[etudiant.Promotion.Annee].AjouterEtudiant(etudiant);
        }

        public void AddProfesseur(Professeur professeur, List<Matiere> matieresEnseignees)
        {
            professeurs.Add(professeur);
            foreach(Matiere matiere in matieresEnseignees)
            {
                int index = matieres.FindIndex(m => m.Code.Equals(matiere.Code));
                matieres[index].AjouterProfesseur(professeur);
            }
        }
        public Professeur GetProfesseur(string nom, string prenom)
        {
            foreach(Professeur professeur in professeurs)
            {
                if (professeur.Nom.Equals(nom) && professeur.Prenom.Equals(prenom))
                    return professeur;
            }
            return null;
        }
        public Matiere GetMatiere(string code)
        {
            foreach(Matiere matiere in matieres)
            {
                if (matiere.Code.Equals(code))
                {
                    return matiere;
                }
            }
            return null;
        }

        public void AddMatiere(Matiere matiere,Module module)
        {
            matieres.Add(matiere);
            modules.Find(m => m.Code.Equals(module.Code)).AjouterMatiere(matiere);
        }
        
        public Module GetModule(string code)
        {
            foreach(Module module in modules)
            {
                if (module.Code.Equals(code))
                {
                    return module;
                }
            }
            return null;
        }

        public Etudiant GetEtudiant(int anneePromo, string nom, string prenom)
        {
            Promotion promotion;
            promotions.TryGetValue(anneePromo, out promotion);
            if (promotion == null)
                return null;
            else
            {
                foreach(Etudiant etudiant in promotion.Etudiants)
                {
                    if (etudiant.Nom.Equals(nom) && etudiant.Prenom.Equals(prenom))
                        return etudiant;
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Repertoire));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, this);
            writer.Close();
        }
    }
}
