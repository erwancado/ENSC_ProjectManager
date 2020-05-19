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
        public List<Promotion> promotions;
        public List<Matiere> matieres;
        public List<Module> modules;
        public List<Role> roles;
        public List<Professeur> professeurs;
        public List<Exterieur> intervenantsExte;
        public List<Projet> projets;
        public String[] typesPromos;
        public string saveFile;
        public Repertoire()
        {
            typesProjet = new List<Type>();
            promotions = new List<Promotion>();
            modules = new List<Module>();
            matieres = new List<Matiere>();
            roles = new List<Role>();
            professeurs = new List<Professeur>();
            intervenantsExte = new List<Exterieur>();
            projets = new List<Projet>();
        }

        public void AddPromotion(Promotion promotion)
        {
            promotions.Add(promotion);
        }
        public void AddModule(Module mod)
        {
            modules.Add(mod);
            foreach (Matiere matiere in mod.ListeMatiere)
            { 
                matieres.Add(matiere);
            }

        }
        public Promotion GetPromotion(int annee)
        {
            return promotions.Find(p => p.Annee == annee);
        }
        public void AddEtudiant(Etudiant etudiant)
        {
            GetPromotion(etudiant.AnneePromotion).AjouterEtudiant(etudiant);
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

        public Exterieur GetExterieur(string nom, string prenom, string organisation)
        {
            foreach(Exterieur exterieur in intervenantsExte)
            {
                if (exterieur.Nom.Equals(nom) && exterieur.Prenom.Equals(prenom) && exterieur.Organisation.Equals(organisation))
                    return exterieur;
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
            Promotion promotion = GetPromotion(anneePromo);
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

        public List<string> GetLibellesRoles()
        {
            List<string> libelles = new List<string>();
            foreach(Role role in roles)
            {
                if (!libelles.Contains(role.Libelle))
                    libelles.Add(role.Libelle);
            }
            return libelles;
        }

        public void SaveData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Repertoire));
            TextWriter writer = new StreamWriter(saveFile);
            serializer.Serialize(writer, this);
            writer.Close();
        }

        public static Repertoire LoadData(string SaveFile)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Repertoire));
            serializer.UnknownNode += new
            XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new XmlAttributeEventHandler(serializer_UnknownAttribute);
            FileStream fs = new FileStream(SaveFile, FileMode.Open);
            // Declare an object variable of the type to be deserialized.
            Repertoire repertoire;
            repertoire = (Repertoire)serializer.Deserialize(fs);
            return repertoire;
        }
        private static void serializer_UnknownNode (object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private static void serializer_UnknownAttribute (object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }
    }
}
