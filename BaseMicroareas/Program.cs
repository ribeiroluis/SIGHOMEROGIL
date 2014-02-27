using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseMicroareas.mICROAREASTableAdapters;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace BaseMicroareas
{
    class Program
    {
        static void Main(string[] args)
        {
            viewNumerosMicroareaTableAdapter microdb = new viewNumerosMicroareaTableAdapter();
            DataTable tbmicros = microdb.RetornaMicroareasCadastradas();

            Console.WriteLine("Gerando Numeros...");
            StreamWriter escreve2 = new StreamWriter(@"Microareas.doc", false);
            escreve2.Close();
            escreve2 = new StreamWriter(@"Microareas.doc", true);
            var _auxmicroarea = tbmicros.Rows[0]["MICROAREA"].ToString();
            var _auxbairro = tbmicros.Rows[0]["BAIRRO"].ToString();
            var _auxrua = tbmicros.Rows[0]["LOGRADOURO"].ToString();
            var _auxArea = tbmicros.Rows[0]["IDAREA"].ToString();
            escreve2.WriteLine("AREA: " + _auxArea.PadLeft(3, '0')  + tbmicros.Rows[0]["NOMEAREA"].ToString());           
            escreve2.WriteLine("MICROAREA: " + _auxmicroarea.PadLeft(3, '0'));           
            escreve2.WriteLine("BAIRRO: " + _auxbairro);
            escreve2.WriteLine("\nLOGRADOURO: " + _auxrua);
            Debug.WriteLine("MICROAREA: 0" + _auxmicroarea);
            Debug.WriteLine("BAIRRO: " + _auxbairro);
            Debug.WriteLine("LOGRADOURO: " + _auxrua);
            Console.WriteLine("MICROAREA: 0" + _auxmicroarea);
            Console.WriteLine("BAIRRO: " + _auxbairro);
            Console.WriteLine("LOGRADOURO: " + _auxrua);

            foreach (DataRow linha in tbmicros.Rows)
            {
                var microarea = linha["MICROAREA"].ToString();
                if (_auxmicroarea == microarea)
                {
                    var bairro = linha["BAIRRO"].ToString();
                    if (_auxbairro == bairro)
                    {
                        var rua = linha["LOGRADOURO"].ToString();
                        if (_auxrua == rua)
                        {
                            escreve2.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ",");
                            Debug.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ",");
                        }
                        else
                        {
                            _auxrua = linha["LOGRADOURO"].ToString();
                            escreve2.WriteLine("\n\nLOGRADOURO: " + _auxrua);
                            escreve2.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ",");
                            Debug.WriteLine("\nLOGRADOURO: " + _auxrua);
                            Console.WriteLine("\nLOGRADOURO: " + _auxrua);
                            Debug.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ",");
                        }
                    }
                    else
                    {
                        _auxbairro = linha["BAIRRO"].ToString();
                        _auxrua = linha["LOGRADOURO"].ToString();
                        escreve2.WriteLine("\nBAIRRO: " + _auxbairro);
                        escreve2.WriteLine("\nLOGRADOURO: " + _auxrua);
                        escreve2.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ",");
                        Debug.WriteLine("BAIRRO: " + _auxbairro);
                        Debug.WriteLine("LOGRADOURO: " + _auxrua);
                        Console.WriteLine("BAIRRO: " + _auxbairro);
                        Console.WriteLine("LOGRADOURO: " + _auxrua);
                        Debug.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ",");
                    }

                }
                else
                {
                    _auxArea = linha["IDAREA"].ToString();
                    _auxmicroarea = linha["MICROAREA"].ToString();
                    _auxbairro = linha["BAIRRO"].ToString();
                    _auxrua = linha["LOGRADOURO"].ToString();
                    escreve2.WriteLine("\n\nAREA: " + _auxArea.PadLeft(3, '0') + linha["NOMEAREA"].ToString() );   
                    escreve2.WriteLine("\nMICROAREA: " + _auxmicroarea.PadLeft(3, '0'));
                    escreve2.WriteLine("BAIRRO: " + _auxbairro);
                    escreve2.WriteLine("\nLOGRADOURO: " + _auxrua);                    
                    Debug.WriteLine("\nMICROAREA: 0" + _auxmicroarea);
                    Debug.WriteLine("\nBAIRRO: " + _auxbairro);
                    Debug.WriteLine("\nLOGRADOURO: " + _auxrua);
                    Console.WriteLine("\nMICROAREA: 0" + _auxmicroarea);
                    Console.WriteLine("BAIRRO: " + _auxbairro);
                    Console.WriteLine("LOGRADOURO: " + _auxrua);
                    Debug.Write(linha["NUMERO"].ToString() + linha["COMPLEMENTO"].ToString() + ","); 
                }                
            }
            escreve2.Close();
            Console.WriteLine("......100%...");
            
            //string Microarea = 



        }
    }
}
