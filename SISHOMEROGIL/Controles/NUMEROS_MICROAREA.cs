using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.BancoDados.ExemploDataSetTableAdapters;
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
                DataTable TB = BDNumeros.PesquisaNumerosPorCEP(_CEP._CEP);
                if (TB.Rows.Count < 1)
                    return false;
                else
                {
                    DataRow Linha = TB.Rows[0];
                    ID_NumMicroarea = (int)Linha["IDNUMMICROAREA_TBNUMEROMICROAREA"];
                    Microarea.idMicroarea = (int)Linha["NUM_MICROAREA"];
                    Numero = (int)Linha["NUMERO"];
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


    }
}
