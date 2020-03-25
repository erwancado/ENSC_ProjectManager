using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class type
    {
        private bool _groupe;
        public bool Groupe { get { return _groupe; } set { _groupe = value; } }

        private int _nbMaxEtudiants;
        public int NbMaxEtudiants { get { return _nbMaxEtudiants; } set { _nbMaxEtudiants = value; } }

        private int _nbMinEtudiants;
        public int NbMinEtudiants { get { return _nbMinEtudiants; } set { _nbMinEtudiants = value; } }

        public type(bool Groupe, int NbrMinEtudiants, int NbrMaxEtudiants)
        {
            _groupe = Groupe;
            _nbMaxEtudiants = NbrMaxEtudiants;
            _nbMinEtudiants = NbrMinEtudiants;
        }
    }
}
