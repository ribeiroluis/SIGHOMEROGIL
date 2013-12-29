using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.BancoDados.SenhasAcolhimentoTableAdapters;
using System.Data;

namespace SISHOMEROGIL.Controles
{
    class FUNCIONARIO
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public OCUPACAO Cargo { get; set; }
        public string Apelido { get; set; }
        FUNCIONARIOTableAdapter BDFuncionario;

        public FUNCIONARIO()
        {
            Cargo = new OCUPACAO();
            BDFuncionario = new FUNCIONARIOTableAdapter();
        }

        public bool PreencheFuncionario()
        {
            try
            {
                DataTable TB = BDFuncionario.PesquisaFuncionario(IdFuncionario);
                if (TB.Rows.Count < 1)
                    return false;
                else
                {
                    DataRow Linha = TB.Rows[0];
                    Nome = Linha["NOME"].ToString();
                    Matricula = Linha["MATRICULA"].ToString();
                    Apelido = Linha["APELIDO"].ToString();
                    Cargo.idCargo = (int)Linha["IDCARGO"];
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
