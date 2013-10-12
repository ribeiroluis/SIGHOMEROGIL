using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISHOMEROGIL.Controles
{
    class NUMEROS_MICROAREA
    {
        private int ID_NumMicroarea { get; set; }
        public int Microarea { get; set; }
        public CEP _CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }

        public NUMEROS_MICROAREA()
        {
            _CEP = new CEP();
        }


    }
}
