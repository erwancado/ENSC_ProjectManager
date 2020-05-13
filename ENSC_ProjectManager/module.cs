using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Module
    {
        private string _code;
        public string Code { get { return _code; } set { _code = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private string _promo;
        public string Promo { get { return _promo; } set { _promo = value; } }

        private List<Matiere> _listeMatieres;
        public List<Matiere> ListeMatiere
        { get { return _listeMatieres; } set { _listeMatieres = value; } }

        public Module(string Code, string Libelle, string Promo)
        {
            _code = Code;
            _libelle = Libelle;
            _promo = Promo;
            _listeMatieres = new List<Matiere>();
        }
        public Module()
        {

        }
        public void AjouterMatiere(params Matiere[] matieres)
        {
            foreach(Matiere matiere in matieres)
            {
                _listeMatieres.Add(matiere);
                matiere.Module = this;
            }
        }
    }
}
