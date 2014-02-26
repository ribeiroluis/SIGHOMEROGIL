using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Json;

namespace BasePacientes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pacientes p = new Pacientes();
            p.GravaScriptPacientes();

            numerosMicroareas num = new numerosMicroareas();
            num.gravaScript();
            Console.WriteLine(".\n.\n.\n.Pressione <enter> para sair");
            Console.ReadLine();
            
        }
    }
}
