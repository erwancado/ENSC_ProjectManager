﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    public class Projet
    {
        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public string Description { get => _description; set => _description = value; }
        internal Type Type { get => _type; set => _type = value; }

        private DateTime _dateFin;
        private DateTime _dateDebut;
        private string _description;
        private Type _type;
        private List<Livrable> _listeLivrables;
        private List<Role> _listeRoles;
        private List<Matiere> _listeMatieres;

        public Projet(string libelle, string description, DateTime dateDebut, DateTime dateFin, Type type)
        {
            _libelle = libelle;
            _description = description;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _listeLivrables = new List<Livrable>();
            _type = type;
        }
        public Projet()
        {

        }
        public DateTimeSpan DureeProjet()
        {
            return DateTimeSpan.CompareDates(_dateDebut, _dateFin);
        }
        public void AjouterLivrable(params Livrable[] livrables)
        {
            foreach(Livrable livrable in livrables)
            {
                _listeLivrables.Add(livrable);
            }
        }

        public void AjouterRole(params Role[] roles)
        {
            foreach(Role role in roles)
            {
                _listeRoles.Add(role);
            }
        }

        public void AjouterRole(string libelleRole, Intervenant intervenant)
        {
            _listeRoles.Add(new Role(intervenant, libelleRole));
        }

        private int[] AnneesPromos()
        {
            switch (_type.TypePromotion)
            {
                case "1A":
                    if (DateFin.Month >= 9)
                    {
                        return new int[] { DateFin.Year + 3 };
                    }
                    else
                    {
                        return new int[] { DateFin.Year + 2 };
                    }
                case "2A":
                    if (DateFin.Month >= 9)
                    {
                        return new int[] { DateFin.Year + 2 };
                    }
                    else
                    {
                        return new int[] { DateFin.Year + 1 };
                    }
                    
                case "3A":
                    if (DateFin.Month >= 9)
                    {
                        return new int[] { DateFin.Year + 1 };
                    }
                    else
                    {
                        return new int[] { DateFin.Year };
                    }
                case "transpromo":
                    if (DateFin.Month >= 9)
                    {
                        return new int[] { DateFin.Year + 3, DateFin.Year + 2 };
                    }
                    else
                    {
                        return new int[] { DateFin.Year + 1, DateFin.Year + 2 };
                    }
                default:
                    return new int[] { -1 };

            }
        }
    }
}