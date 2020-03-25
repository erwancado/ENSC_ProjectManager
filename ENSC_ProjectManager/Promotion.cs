using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class Promotion
    {
        public int Annee { get; set; }
        private List<Etudiant> etudiants;
        public Promotion(int annee)
        {
            Annee = annee;
            etudiants = new List<Etudiant>();
        }
        public void AjouterEtudiant(Etudiant etudiant)
        {
            etudiants.Add(etudiant);
            etudiant.Promotion = this;
        }
    }
}
