using System.Collections.Generic;

namespace ENSC_ProjectManager
{
    /// <summary>
    /// Représente une matière de l'ENSC, identifiable par son code et enseignée par des professeurs
    /// </summary>
    public class Matiere
    {
        public string Promo; // Niveau auquel est enseignée la matière
        public string Code;
        public string CodeModule; // Code du module auquel la matière appartient

        public string Libelle;

        public List<Professeur> ListeProfesseurs; // Liste des professeurs qui enseignent cette matière

        public Matiere(string code, string libelle, string promo)
        {
            Code = code;
            Libelle = libelle;
            ListeProfesseurs = new List<Professeur>();
            Promo = promo;
        }
        public Matiere()
        {

        }
        public void AjouterProfesseur(params Professeur[] professeurs)
        {
            foreach (Professeur p in professeurs)
            {
                ListeProfesseurs.Add(p);
            }
        }
    }
}
