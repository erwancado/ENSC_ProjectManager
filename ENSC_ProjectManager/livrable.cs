using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class livrable
    {
        private FileStyleUriParser _type;
        public FileStyleUriParser Type { get { return _type; } set { _type = value; } }

        private DateTime _dateRendu;
        public DateTime DateRendu { get { return _dateRendu; } set { _dateRendu = value; } }

        private bool _rendu;
        public bool Rendu { get { return _rendu; } set { _rendu = value; } }

        private String _libelle;
        public String Libelle { get { return _libelle; } set { _libelle = value; } }

        public livrable(FileStyleUriParser Type, DateTime DateRendu, bool Rendu , String Libelle)
        {
            _type = Type;
            _dateRendu = DateRendu;
            _rendu = Rendu;
            _libelle = Libelle;
        }
    }
}
