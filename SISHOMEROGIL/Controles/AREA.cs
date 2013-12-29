using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using SISHOMEROGIL.BancoDados.SenhasAcolhimentoTableAdapters;

namespace SISHOMEROGIL.Controles
{
    class AREA
    {
        public int IdArea { get; set; }
        public FUNCIONARIO  Enfermeiro { get; set; }
        public FUNCIONARIO Medico { get; set; }
        public string Equipe { get; set; }

        TB_AREATableAdapter BDArea;

        
        public AREA()
        {
            Enfermeiro = new FUNCIONARIO();
            Medico = new FUNCIONARIO();
            BDArea = new TB_AREATableAdapter();
        }

        public bool PreencheArea()
        {
            try
            {
                DataTable TB = BDArea.PesquisaAreaPorID(IdArea);
                if (TB.Rows.Count < 1)
                    return false;
                else
                {
                    DataRow Linha = TB.Rows[0];
                    Enfermeiro.IdFuncionario = (int)Linha["IDENFERMEIRO_FUNCIONARIO"];
                    var x = Linha["IDMEDICO_FUNCIONARIO"].ToString();
                    if (!x.Equals(string.Empty))
                        Medico.IdFuncionario = (int)Linha["IDMEDICO_FUNCIONARIO"];
                    Equipe = Linha["EQUIPE_AREA"].ToString();
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
