using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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

            Repertoire repertoire = new Repertoire();
            String[] typesPromos = { "1A", "2A", "3A", "transpromo" };
            repertoire.typesPromos = typesPromos;
            repertoire.saveData(Path.GetDirectoryName(Application.ExecutablePath) + Path.DirectorySeparatorChar + "repertoire.xml");

        }
    }
}
