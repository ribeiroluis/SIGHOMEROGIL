using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SISHOMEROGIL.Controles
{
    class FUNCIONARIO
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public OCUPACAO IdCargo { get; set; }
        public FUNCIONARIO()
        {
            IdCargo = new OCUPACAO();
        }

    }
}
