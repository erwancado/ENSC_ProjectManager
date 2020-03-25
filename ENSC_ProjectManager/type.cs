using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class Type
    {
        private bool _groupe;
        private string _typePromotion;
        private int _nbMaxEtudiants;
        public int NbMaxEtudiants { get { return _nbMaxEtudiants; } set { _nbMaxEtudiants = value; } }
        private int _nbMinEtudiants;
        public int NbMinEtudiants { get { return _nbMinEtudiants; } set { _nbMinEtudiants = value; } }

        internal string TypePromotion { get => _typePromotion; set => _typePromotion = value; }

        public Type(int NbrMinEtudiants, int NbrMaxEtudiants, string typePromo)
        {
            _groupe = NbMaxEtudiants==1;
            _nbMaxEtudiants = NbrMaxEtudiants;
            _nbMinEtudiants = NbrMinEtudiants;
            TypePromotion = typePromo;
        }
    }
}
