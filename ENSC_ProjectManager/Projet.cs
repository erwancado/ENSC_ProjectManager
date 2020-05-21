using System;
using System.Collections.Generic;

namespace ENSC_ProjectManager
{
    public class Projet
    {
        private string _libelle;
        public string Libelle { get { return _libelle; } set { _libelle = value; } }
        public DateTime DateFin { get => _dateFin; set => _dateFin = value; }
        public DateTime DateDebut { get => _dateDebut; set => _dateDebut = value; }
        public string Description { get => _description; set => _description = value; }
        public Type Type { get => _type; set => _type = value; }

        private DateTime _dateFin;
        private DateTime _dateDebut;
        private string _description;
        private Type _type;
        public List<Livrable> ListeLivrables;
        public List<Role> ListeRoles;
        public List<Matiere> ListeMatieres;

        public Projet(string libelle, string description, DateTime dateDebut, DateTime dateFin, Type type)
        {
            _libelle = libelle;
            _description = description;
            _dateDebut = dateDebut;
            _dateFin = dateFin;
            _type = type;
        }
        public Projet()
        {
            ListeLivrables = new List<Livrable>();
            ListeRoles = new List<Role>();
            ListeMatieres = new List<Matiere>();
        }
        public DateTimeSpan DureeProjet()
        {
            return DateTimeSpan.CompareDates(_dateDebut, _dateFin);
        }
        public void AjouterLivrable(params Livrable[] livrables)
        {
            foreach (Livrable livrable in livrables)
            {
                ListeLivrables.Add(livrable);
            }
        }
        public bool ContenirMatiere(List<String> matieres)
        {
            foreach (String matiere in matieres)
            {
                for (int i = 0; i < this.ListeMatieres.Count; i++)
                {
                    if (this.ListeMatieres[i].Libelle.ToLower().Equals(matiere.ToLower()))
                        return true;
                }
            }
            return false;
        }
        public bool ContenirModule(List<String> modules)
        {
            foreach (String module in modules)
            {
                for (int i = 0; i < this.ListeMatieres.Count; i++)
                {
                    if (this.ListeMatieres[i].CodeModule.Equals(module))
                        return true;
                }
            }
            return false;
        }
        public void AjouterRole(params Role[] roles)
        {
            foreach (Role role in roles)
            {
                ListeRoles.Add(role);
            }
        }

        public void AjouterRole(string libelleRole, Intervenant intervenant)
        {
            ListeRoles.Add(new Role(intervenant, libelleRole));
        }
        public bool ContientIntervenant(Intervenant intervenant)
        {
            foreach (Role role in ListeRoles)
            {
                if (role.Intervenant.Equals(intervenant))
                    return true;
            }
            return false;
        }

        public int[] AnneesPromos()
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
