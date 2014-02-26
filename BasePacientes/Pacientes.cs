using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;



namespace BasePacientes
{
    class Pacientes
    {
        public int Prontuario { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string NomeMae { get; set; }

        public Pacientes()
        {
           
        }

        public Pacientes RetornaPacientePorProntuario() 
        {
            
            try
            {
                ConexaoFirebird banco = new ConexaoFirebird();                
                
                var _prontuario = Prontuario.ToString().PadLeft(7, '0');
                
                DataTable tbUsuario = banco.RetornaNomeUsuarioCadastradoPorProntuario(_prontuario);
                foreach (DataRow Linha in tbUsuario.Rows)
                {
                    this.Prontuario = int.Parse(Linha[0].ToString()); ;
                    this.Nome = Linha[2].ToString();
                    this.DataNascimento = DateTime.Parse(Linha[5].ToString());
                    this.Logradouro = Linha[19].ToString() + " " + Linha[20].ToString();
                    this.Numero = int.Parse(Linha[21].ToString());
                    this.Complemento = Linha[22].ToString();
                    this.Bairro = Linha[18].ToString();
                    this.NomeMae = Linha[13].ToString();
                    for (int i = 0; i < Linha.ItemArray.Length; i++)
                    {
                        Debug.WriteLine(i + " - " + Linha[i]);
                    }
                    return this;
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }


            return this;
        }

        /// <summary>
        /// Retorna Lista de Usuarios Cadastrados
        /// </summary>
        /// <returns>Prontuario, Nome, Logradouro, Numero, Comp, Bairro</returns>
        public List<Pacientes> RetornaListaPacientes()
        {
            var listPacientes = new List<Pacientes>();
            var x = new Pacientes();

            try
            {
                ConexaoFirebird banco = new ConexaoFirebird();
                DataTable tbUsuarios = banco.RetornaTabelaUsuariosCadastrados();
                foreach (DataRow Linha in tbUsuarios.Rows)
                {
                    x.Prontuario = int.Parse(Linha[0].ToString()); ;
                    x.Nome = Linha[2].ToString();
                    //x.DataNascimento = DateTime.Parse(Linha[5].ToString());
                    x.Logradouro = Linha[19].ToString() + " " + Linha[20].ToString();

                    var num = Linha[21].ToString();
                    bool invalid = false;
                    foreach (char c in num) { if (c < 48 || c > 57) { invalid = true; break; } }
                    if (!invalid && num != "")
                        x.Numero = int.Parse(Linha[21].ToString());
                    
                    x.Complemento = Linha[22].ToString();
                    x.Bairro = Linha[18].ToString();
                    x.NomeMae = Linha[13].ToString();
                    listPacientes.Add(x);
                    x = new Pacientes();                                                        
                }
                return listPacientes;
                
            }
            catch (Exception)
            {
                
                throw;
            }

            
            return listPacientes;
        }

        public int GravaPacientes()
        {

            var i = 0;
            

            return i; 
        }

        public int GravaScriptPacientes()
        {            
            try
            {
                Console.WriteLine("Atualizando listas de pacientes");
                var lista = RetornaListaPacientes();

                StreamWriter escreve = new StreamWriter(@"\\10.5.124.102\gerencia (c)\temp\Relatorios\models\Usuarios.js");
                escreve.WriteLine("var dadosUsuarios = [");
                escreve.Close();

                StreamWriter escreve2 = new StreamWriter(@"\\10.5.124.102\gerencia (c)\temp\Relatorios\models\Usuarios.js", true);
                var x = lista.Count;
                var i = 0;
                foreach (var item in lista)
                {                    
                    i++;
                    escreve2.Write("{prontuario: " + item.Prontuario + ",nome: \"" + item.Nome + "\",logradouro: \"" + item.Logradouro + "\",n: " + item.Numero + ",comp: \"" + item.Complemento + "\", bairro: \"" + item.Bairro + "\"}");
                    Debug.Write("{prontuario: " + item.Prontuario + ",nome: " + item.Nome + ",logradouro: " + item.Logradouro + ",n: " + item.Numero + ",comp: " + item.Complemento + ", bairro: " + item.Bairro + "}");
                    Console.WriteLine("Prontuario: " + item.Prontuario + ",nome: " + item.Nome + "==>" +((i/lista.Count)*100).ToString("p"));
                 
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
