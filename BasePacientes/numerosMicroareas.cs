using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BasePacientes.Model.areasCadastradasTableAdapters;
using System.Data;
using System.IO;
using System.Diagnostics;
namespace BasePacientes
{
    class numerosMicroareas
    {
        public int IdArea { get; set; }
        public string NomeArea { get; set; }
        public string Medico { get; set; }
        public string Enfermeiro { get; set; }
        public string Tecnico { get; set; }
        public int IdMicroarea { get; set; }
        public string ACS { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }

        public numerosMicroareas()
        {

        }

        public int gravaScript()
        {
            try
            {
                viewNumerosMicroareaTableAdapter bd = new viewNumerosMicroareaTableAdapter();
                DataTable _tabela = bd.GetData();

                Console.WriteLine("Atualizando numeros cadastrados");
                StreamWriter escreve = new StreamWriter(@"\\10.5.124.101\Temp\Relatorios\Relatorios\models\NumerosCadastrados.js");
                escreve.WriteLine("var numerosCadastrados = [");
                escreve.Close();
                StreamWriter escreve2 = new StreamWriter(@"\\10.5.124.101\Temp\Relatorios\Relatorios\models\NumerosCadastrados.js", true);              
                var i = 0;
                var x = _tabela.Rows.Count;
                foreach (DataRow Linha in _tabela.Rows)
                {
                    IdArea = (int)Linha[0];
                    NomeArea = Linha[1].ToString();
                    Medico = Linha[2].ToString();
                    Enfermeiro = Linha[3].ToString();
                    Tecnico = Linha[4].ToString();
                    IdMicroarea = (int)Linha[5];
                    ACS = Linha[6].ToString();
                    CEP = Linha[7].ToString();
                    Logradouro = Linha[8].ToString();
                    Numero = (int)Linha[9];
                    Complemento = Linha[10].ToString();
                    Bairro = Linha[11].ToString();
                    i++;
                    escreve2.Write("{IDAREA: " + IdArea + 
                        ",NOMEAREA: '" + NomeArea + 
                        "',MEDICO: '"+ Medico + 
                        "',ENFERMEIRO: '" + Enfermeiro +
                        "',TECNICO: '" + Tecnico + 
                        "', IDMICROAREA: " + IdMicroarea +
                        ",ACS: '" + ACS+ 
                        "', CEP: '" + CEP+ 
                        "',LOGRADOURO: '" + Logradouro + 
                        "', NUMERO: " + Numero +                        
                        ", COMPLEMENTO: '" + Complemento +
                        "',BAIRRO: '" + Bairro+
                        "'}");

                    Debug.Write("{IDAREA: " + IdArea +
                        ",NOMEAREA: '" + NomeArea +
                        "',MEDICO: '" + Medico +
                        "',ENFERMEIRO: '" + Enfermeiro +
                        "',TECNICO: '" + Tecnico +
                        "', IDMICROAREA: " + IdMicroarea +
                        ",ACS: '" + ACS +
                        "', CEP: '" + CEP +
                        "',LOGRADOURO: '" + Logradouro +
                        "', NUMERO: " + Numero +
                        ", COMPLEMENTO: '" + Complemento +
                        "',BAIRRO: '" + Bairro +
                        "'}");
                    Console.WriteLine(IdArea + " - " + IdMicroarea  + " - " + Logradouro);

                    if (i < x)
                    {
                        escreve2.WriteLine(",");
                        Debug.WriteLine(",");
                    }
                    
                }
                escreve2.WriteLine("];");
                Debug.WriteLine("];");
                escreve2.Close();
                return 1;
            }
            catch (Exception)
            {                
                throw;
            }
        }
    }
}
