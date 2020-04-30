using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENSC_ProjectManager
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Repertoire repertoire = new Repertoire();
            String[] typesPromos = { "1A", "2A", "3A", "transpromo" };
            repertoire.typesPromos = typesPromos;
            Type projetProg = new Type(1, 2, typesPromos[0]);
            Type transpromo = new Type(4, 6, typesPromos[3]);
            repertoire.typesProjet.Add(projetProg);
            repertoire.typesProjet.Add(transpromo);
            Application.Run(new CreationProjet(repertoire));
        }
    }
}
