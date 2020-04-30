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
        private string _code;
        public string Code{get{return _code;} set{ _code=value;}}

        private string _libelle;
        public Module Module { get; set; }

        private readonly List<Professeur> _listeProfesseurs;
        
        public string Libelle{get{return _libelle;} set{ _code=value;}}

        internal List<Professeur> ListeProfesseurs { get => _listeProfesseurs;}

        public Matiere (string Code,string Libelle, string promo)
        {
            _code = Code;
            _libelle = Libelle;
            _listeProfesseurs = new List<Professeur>();
            Promo = promo;
        }
        public Matiere()
        {

        }
        public void AjouterProfesseur(params Professeur[] professeurs)
        {
            foreach(Professeur p in professeurs)
            {
                _listeProfesseurs.Add(p);
            }
        }
    }
}
