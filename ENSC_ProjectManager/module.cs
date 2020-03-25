using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENSC_ProjectManager
{
    class module
    {
        private String _code;
        public String Code{get{return _code;} set{_code = value;}}

        private String _libelle;
        public String Libelle{get{return _libelle;} set{_libelle=value;}}

        public module(String Code, String Libelle)
        {
            _code = Code;
            _libelle = Libelle;
        }
    }
}
