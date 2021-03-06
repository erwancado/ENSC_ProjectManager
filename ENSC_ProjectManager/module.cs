﻿using System;
using System.Collections.Generic;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Représente un module d'enseignement de l'ENSC, identifiable par son code
    /// </summary>
    public class Module
    {
        private string _code;
        public string Code { get { return _code; } set { _code = value; } }

        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }

        private string _promo;
        public string Promo { get { return _promo; } set { _promo = value; } } // Niveau auquel sont enseignées les matières du module

        private List<Matiere> _listeMatieres;
        public List<Matiere> ListeMatiere // Liste des matières contenues dans le module
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
            foreach (Matiere matiere in matieres)
            {
                _listeMatieres.Add(matiere);
                matiere.CodeModule = Code;
            }
        }
        public String RetournerNomModule(String code)
        {
            if (_code == code)
                return _libelle;
            else return "erreur";
        }
    }
}
