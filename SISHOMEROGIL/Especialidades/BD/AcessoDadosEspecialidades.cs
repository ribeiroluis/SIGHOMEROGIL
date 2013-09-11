using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.Especialidades;
using System.Data;
using SISHOMEROGIL.Especialidades.Controles;
using SISHOMEROGIL.Especialidades.BD.EspecialidadesAutoCustoTableAdapters;

namespace SISHOMEROGIL.Especialidades.BD
{
    class AcessoDadosEspecialidades
    {
        public AcessoDadosEspecialidades()
        {

        }

        /// <summary>
        /// Retorna a tabela contendo as informacoes de usuario
        /// </summary>
        /// <param name="_cns">Cartao do Sus Usuario.CNS</param>
        /// <returns>DataTable</returns>
        public DataTable ConsultaCNS(string _cns)
        {
            DataTable pessoa;
            try
            {
                USUARIOTableAdapter user = new USUARIOTableAdapter();
                pessoa = user.PesquisaCartaoSus(_cns);
                return pessoa;
            }
            catch (Exception)
            {
                return pessoa = null;
                throw;
            }
        }

        /// <summary>
        /// Retorna a tabela contendo a informacao de cep
        /// </summary>
        /// <param name="_cep">cep solicitado</param>
        /// <returns>datatable</returns>
        public DataTable ConsultaCEP(string _cep)
        {
            DataTable CEP;
            try
            {
                ConsultaCEPTableAdapter cep = new ConsultaCEPTableAdapter();
                CEP = cep.ConsultaCEP(int.Parse(_cep));
                return CEP;
            }
            catch (Exception err)
            {                
                System.Windows.Forms.MessageBox.Show(err.Message);
                return null;
            }
        }
    }
}
