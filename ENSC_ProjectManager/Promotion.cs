using System.Collections.Generic;

namespace ENSC_ProjectManager
{
    public class Promotion
    {
        public int Annee { get; set; }
        public List<Etudiant> Etudiants { get; }
        public Promotion(int annee)
        {
            Annee = annee;
            Etudiants = new List<Etudiant>();
        }
        public Promotion()
        {
            Etudiants = new List<Etudiant>();
        }
        public void AjouterEtudiant(Etudiant etudiant)
        {
            Etudiants.Add(etudiant);
            etudiant.AnneePromotion = Annee;
        }
    }
}
