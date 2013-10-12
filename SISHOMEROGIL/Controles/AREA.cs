using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISHOMEROGIL.Controles
{
    class AREA
    {
        public int IdArea { get; set; }
        public FUNCIONARIO  Enfermeiro { get; set; }
        public FUNCIONARIO Medico { get; set; }
        
        public AREA()
        {
            Enfermeiro = new FUNCIONARIO();
            Medico = new FUNCIONARIO();
        }
    }
}
