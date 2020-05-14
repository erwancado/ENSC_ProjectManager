using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Matiere
    {
        public string Promo;
        public string Code;
        public string CodeModule;

        public string Libelle;

        public List<Professeur> ListeProfesseurs;

        public Matiere (string code,string libelle, string promo)
        {
            Code = code;
            Libelle = libelle;
            ListeProfesseurs = new List<Professeur>();
            Promo = promo;
        }
        public Matiere()
        {

        }
        public void AjouterProfesseur(params Professeur[] professeurs)
        {
            foreach(Professeur p in professeurs)
            {
                ListeProfesseurs.Add(p);
            }
        }
    }
}
