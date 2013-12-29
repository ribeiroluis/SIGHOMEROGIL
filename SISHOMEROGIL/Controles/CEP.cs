using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.BancoDados.BDCEPDataSetTableAdapters;
//using SISHOMEROGIL.BancoDados.SenhasAcolhimentoTableAdapters;
using System.Data;

namespace SISHOMEROGIL.Controles
{
    class CEP
    {
        public int _CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }        
        public List<CEP> ListaCEPCadastrados { get; set; }

       viewBuscaCEPTableAdapter BDCep { get; set; }

        public CEP()
        {
            ListaCEPCadastrados = new List<CEP>();
            BDCep = new viewBuscaCEPTableAdapter();            

        }

        
        /// <summary>
        /// Execute à sempre que chamar o objeto CEP
        /// </summary>
        public void PreencheListaCEP()
        {
            try
            {

                DataTable x = BDCep.GetData();
                CEP c;
                foreach ( DataRow Linha in x.Rows)
                {
                    c = new CEP();
                    c._CEP = (int)Linha["CEP"];
                    c.Bairro = Linha["BAIRRO"].ToString();
                    c.Logradouro = Linha["ENDERECO"].ToString();
                    c.UF = Linha["UF"].ToString();
                    c.Cidade = Linha["CIDADE"].ToString();
                    ListaCEPCadastrados.Add(c);
                    c = null;

                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool PesquisaLogradouro()
        {

            try
            {
                DataTable x = BDCep.PesquisaLogradouro(Logradouro);
                if (x.Rows.Count == 1)
                {
                    DataRow Linha = x.Rows[0];
                    _CEP = (int)Linha["CEP"];
                    Bairro = Linha["BAIRRO"].ToString();
                    Logradouro = Linha["ENDERECO"].ToString();
                    UF = Linha["UF"].ToString();
                    Cidade = Linha["CIDADE"].ToString();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        /// <summary>
        /// Será preenchido o objeto CEP
        /// Instancie o objetoCEP com o atributo cep para executar este metodo
        /// </summary>
        public bool PesquisaCEP()
        {

            try
            {
                DataTable x = BDCep.PesquisaCEP(_CEP);
                if (x.Rows.Count == 1)
                {
                    DataRow Linha = x.Rows[0];
                    _CEP = (int)Linha["CEP"];
                    Bairro = Linha["BAIRRO"].ToString();
                    Logradouro = Linha["ENDERECO"].ToString();
                    UF = Linha["UF"].ToString();
                    Cidade = Linha["CIDADE"].ToString();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        
        
    }
}
