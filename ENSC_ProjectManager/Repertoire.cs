using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ENSC_ProjectManager
{
    [XmlRoot("Repertoire", IsNullable = false)]
    public class Repertoire
    {
        public List<Type> typesProjet;
        public List<Promotion> promotions;
        public List<Matiere> matieres;
        public List<Module> modules;
        public List<Role> roles;
        public List<Professeur> professeurs;
        public List<Exterieur> intervenantsExte;
        public List<Projet> projets;
        public String[] typesPromos;
        public Repertoire()
        {

        }
        
        public void saveData(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Repertoire));
            TextWriter writer = new StreamWriter(filename);
            serializer.Serialize(writer, this);
            writer.Close();
        }
    }
}
