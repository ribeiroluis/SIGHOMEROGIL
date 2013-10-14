using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.BancoDados.ExemploDataSetTableAdapters;
using System.Data;

namespace SISHOMEROGIL.Controles
{
    class MICROAREA
    {
        public FUNCIONARIO ACS { get; set; }
        public int idMicroarea { get; set; }
        public AREA _AREA { get; set; }

        TB_MICROAREATableAdapter BDMicroarea;

        
        
        public MICROAREA()
        {
            ACS = new FUNCIONARIO();
            _AREA = new AREA();
            BDMicroarea = new TB_MICROAREATableAdapter();
        }

        public bool PreencheMicroarea()
        {
            try
            {
                DataTable TB = BDMicroarea.PesquisaMicroareaPorID(idMicroarea);
                if (TB.Rows.Count < 1)
                    return false;
                else
                {
                    DataRow Linha = TB.Rows[0];
                    ACS.IdFuncionario = (int)Linha["IDACS_FUNCIONARIO"];
                    _AREA.IdArea = (int)Linha["IDAREA_AREA"];
                    return true;
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
