using System;
using System.Collections.Generic;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Représente un projet de l'ENSC
    /// </summary>
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
        public List<Livrable> ListeLivrables; // Liste des livrables du projet
        public List<Role> ListeRoles; // Liste des intervenants et du rôle qu'ils jouent
        public List<Matiere> ListeMatieres; // Liste des matières associées au projet

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
        /// <summary>
        /// Calcule l'écart entre la date de début et la date de fin du projet
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Vérifie si le projet est associé à au moins une des matières spécifiées
        /// </summary>
        /// <param name="matieres">liste des matières</param>
        /// <returns></returns>
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
        /// <summary>
        /// Vérifie si le projet est associé à au moins un des modules spécifiés
        /// </summary>
        /// <param name="modules">liste des codes de module</param>
        /// <returns></returns>
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
        /// <summary>
        /// Vérifie si un des participants du projet correspond à l'intervenant spécifié
        /// </summary>
        /// <param name="intervenant"></param>
        /// <returns></returns>
        public bool ContientIntervenant(Intervenant intervenant)
        {
            foreach (Role role in ListeRoles)
            {
                if (role.Intervenant.Equals(intervenant))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Calcule les années de promotion concernées par le projet
        /// </summary>
        /// <returns>années de promotion du projet</returns>
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
