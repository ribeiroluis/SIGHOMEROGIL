using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SISHOMEROGIL.atendimentoMedico
{
    class Paciente
    {
        public int prontuario { get; set; }
        public string nome { get; set; }
        public DateTime  dataNascimento { get; set; }
        public int idade { get; set; }
        public string nomeMae { get; set; }
        public string telefone { get; set; }       
        public string  logradouro { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        private List<Paciente> listaPacientes { get; set; }

        public void AtualizaPacientes(string path)
        {
            string[] Pacientes = File.ReadAllLines(path);

            Paciente p;
            foreach (var nomes in Pacientes)
            {
                string [] aux = nomes.Split(';');
                p = new Paciente();
                p.prontuario = int.Parse(aux[0]);
                p.nome = aux[1];
                p.dataNascimento = DateTime.Parse(aux[2]);
                DateTime hoje = DateTime.Now;
                TimeSpan _idade = hoje - DateTime.Parse(aux[3]);
                p.idade = (int)(_idade.TotalDays / 365);
                p.nomeMae = aux[4];
                p.telefone = aux[5];
                p.logradouro = aux[6];
                p.numero = int.Parse(aux[7]);
                p.complemento = aux[8];
                listaPacientes.Add(p);
            }
        }
        
    }
}
