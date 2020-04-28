using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Livrable
    {
        private string _typeFichier;

        private DateTime _dateRendu;
        public DateTime DateRendu { get { return _dateRendu; } set { _dateRendu = value; } }

        private bool _rendu;
        public bool Rendu { get { return _rendu; } set { _rendu = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }
        public string TypeFichier { get => _typeFichier; set => _typeFichier = value; }

        public Livrable(string typeFichier, DateTime DateRendu, bool Rendu , string Libelle)
        {
            _typeFichier = typeFichier;
            _dateRendu = DateRendu;
            _rendu = Rendu;
            _libelle = Libelle;
        }
    }
}
