using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class matiere
    {
        private String _code;
        public String Code{get{return _code;} set{ _code=value;}}

        private String _libelle;
        public String Libelle{get{return _;} set{ _code=value;}}

        public matiere (String Code,String Libelle)
        {
            _code = Code;
            _libelle = Libelle;
        }
    }
}
