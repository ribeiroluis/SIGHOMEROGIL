using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISHOMEROGIL.Controles
{
    class MICROAREA
    {
        public FUNCIONARIO ACS { get; set; }
        public int idMicroarea { get; set; }
        public AREA _AREA { get; set; }
        public MICROAREA()
        {
            ACS = new FUNCIONARIO();
            _AREA = new AREA();
        }
    }
}
