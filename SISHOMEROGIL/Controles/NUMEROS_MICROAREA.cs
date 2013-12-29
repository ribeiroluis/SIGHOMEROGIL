using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.BancoDados.SenhasAcolhimentoTableAdapters;
using System.Data;

namespace SISHOMEROGIL.Controles
{
    class NUMEROS_MICROAREA
    {
        private int ID_NumMicroarea { get; set; }
        public MICROAREA Microarea { get; set; }
        public CEP _CEP { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        TB_NUMEROSMICROAREATableAdapter BDNumeros;


        public NUMEROS_MICROAREA()
        {
            _CEP = new CEP();
            BDNumeros = new TB_NUMEROSMICROAREATableAdapter();
            Microarea = new MICROAREA();
        }

        public bool PreencheNumMicroarea()
        {
            try
            {
                DataTable TB;

                if (Complemento == null || Complemento.Equals(""))
                    TB = BDNumeros.PesquisaNumerosPorCEPNumero(_CEP._CEP, Numero);
                else
                    TB = BDNumeros.PesquisaNumerosPorCEPComplemento(_CEP._CEP, Numero, Complemento);
                
                if (TB.Rows.Count < 1)
                    return false;
                else
                {
                    DataRow Linha = TB.Rows[0];
                    ID_NumMicroarea = (int)Linha["IDNUMMICROAREA_TBNUMEROMICROAREA"];
                    Microarea.idMicroarea = (int)Linha["NUM_MICROAREA"];
                    Complemento = Linha["COMPLEMENTO"].ToString();
                    return true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool PesquisaMicroarea()
        {
            try
            {                
                
                return true;

            }
            catch (Exception)
            {

                throw;
            }
 
        }

        public List<string> RetornaComplementos()
        {
            try
            {
                List<string> Listacomplementos = new List<string>();
                DataTable TB = BDNumeros.PesquisaNumerosPorCEPNumero(_CEP._CEP, Numero);
                foreach (DataRow linha in TB.Rows)
                {
                    Listacomplementos.Add(linha["COMPLEMENTO"].ToString());
                }


                return Listacomplementos;
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        /// <summary>
        /// Retorna a lista de numeros cadastrados pelo cep selecionado
        /// </summary>
        /// <returns>Lista de strings</returns>
        public List<string> NumerosCadastrados()
        {
            try
            {
                List<string> ListaNumeros = new List<string>();
                DataTable tb = BDNumeros.RetornaNumerosPorCEP(_CEP._CEP);

                foreach (DataRow linha in tb.Rows)
                {
                    ListaNumeros.Add(linha["NUMERO"].ToString());
                }
                return ListaNumeros;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
