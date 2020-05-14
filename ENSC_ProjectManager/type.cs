﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Type
    {
        public bool Groupe { get { return NbMaxEtudiants != 1; } }
        private string _typePromotion;
        private int _nbMaxEtudiants;
        public int NbMaxEtudiants { get { return _nbMaxEtudiants; } set { _nbMaxEtudiants = value; } }
        private int _nbMinEtudiants;
        public int NbMinEtudiants { get { return _nbMinEtudiants; } set { _nbMinEtudiants = value; } }

        public string TypePromotion { get => _typePromotion; set => _typePromotion = value; }

        public Type(int NbrMinEtudiants, int NbrMaxEtudiants, string typePromo)
        {
            _nbMaxEtudiants = NbrMaxEtudiants;
            _nbMinEtudiants = NbrMinEtudiants;
            TypePromotion = typePromo;
        }
        public Type()
        {

        }
    }
}
