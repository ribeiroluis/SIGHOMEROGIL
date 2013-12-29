using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarumaFramework_DLL;
using System.IO.Ports;

namespace SISHOMEROGIL
{
    class Imprimir
    {
        string sPortaSelecionada;
        int iVelocidade;
        SerialPort Porta = new SerialPort();

        public Imprimir()
        {

        }


        public Boolean VerificaPorta()
        {
            
            
            sPortaSelecionada = "COM1";
            iVelocidade = Convert.ToInt32("9600");

            // configurações basicas
            Porta.PortName = sPortaSelecionada; //+ PortaCom;
            Porta.BaudRate = iVelocidade;
            Porta.Parity = Parity.None;
            Porta.DataBits = 8;
            Porta.StopBits = StopBits.One;

            try
            {
                //Se abriu e fechou, a porta está OK. 
                Porta.Open();
                Porta.Close();
                //MessageBox.Show("Impressora OK!");
                return true;
            }

            catch
            {
                //Ocorreu um erro ao tentar abrir a porta
                //MessageBox.Show("Erro na porta");
                return false;
            }
        }

        public bool AbrePorta()
        {
            sPortaSelecionada = "COM1";
            iVelocidade = Convert.ToInt32("9600");

            try
            {
                //Verificar configuracoes da impressora
                Porta.PortName = sPortaSelecionada;
                Porta.BaudRate = iVelocidade;
                Porta.DataBits = 8;
                Porta.Parity = Parity.None;
                Porta.StopBits = StopBits.One;

                //Determinando um tempo de Timeout tanto para escrita quanto para leitura em milisegundo.
                Porta.WriteTimeout = 1000;
                Porta.ReadTimeout = 1000;

                Porta.Encoding = Encoding.Default;
                //Definindo Handshake  para None.
                Porta.Handshake = Handshake.None;
                Porta.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Fecha_Porta()
        {
            Porta.Close();
        }

        public void imprimeTexto(string titulo, string senha)
        {
            AbrePorta();
            Porta.WriteLine("\t\t   UBS HOMERO GIL");
            Porta.WriteLine("\t\tRua Divinópolis, 153");
            Porta.WriteLine("\t\tTel.: 3595 - 7777");
            Porta.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Porta.WriteLine("\x0E" + titulo + "\x14");
            Porta.WriteLine("");
            Porta.WriteLine("\tSenha: " + "\x1B\x45\x0E" + senha + "\x1B\x46\x14");
            Porta.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Porta.WriteLine("Data: " + DateTime.Now.ToShortDateString() + "\t\tHora: " + DateTime.Now.ToLongTimeString());
            Porta.WriteLine("\t\tAguarde a sua vez!");
            Porta.WriteLine("\"UBS Homero Gil, INOVANDO POR UM SUS MELHOR.\"");
            Porta.WriteLine("\n\n\n\n\n\n\n");
            //Porta.WriteLine("x6D");
            
            Fecha_Porta();
            /*"<bmp><tb><tb><tb><tb><b>UBS HOMERO GIL</tb></tb></tb></tb>" +
                "<l></l>        Rua Divinópolis, 153<l></l>        Tel: 3595 - 7777</b></bmp>" +
                "<tc>~</tc><l></l><e>Box Saud. Criança/Mulher</e><l></l><l></l><tb><tb>Senha:   <e><b>" + 
                senha + "</b></e></tb></tb><l></l><tc>~</tc><l></l>" +
                "Data: "+ DateTime.Now.ToShortDateString() + "<tb><tb>Hora: " + DateTime.Now.ToShortTimeString() +
            "</tb></tb>" + "<sl>1</sl>Aguarde sua vez!<l></l>\"UBS Homero Gil, Em Busca da Qualidade...\"<sl>6</sl>"*/
            
        }

        
        /// <summary>
        /// Imprime texto com a equipe
        /// </summary>
        /// <param name="titulo">Tipo da senha</param>
        /// <param name="senha">num senha</param>
        /// <param name="equipe">composicao da equipe</param>
        public void imprimeTexto(string titulo, string senha, string equipe)
        {
            AbrePorta();
            Porta.WriteLine("\t\t   UBS HOMERO GIL");
            Porta.WriteLine("\t\tRua Divinópolis, 153");
            Porta.WriteLine("\t\tTel.: 3595 - 7777");
            Porta.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Porta.WriteLine("\x0E" + titulo + "\x14");
            Porta.WriteLine("");
            Porta.WriteLine(equipe);
            Porta.WriteLine("\tSenha: " + "\x1B\x45\x0E" + senha + "\x1B\x46\x14");
            Porta.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Porta.WriteLine("Data: " + DateTime.Now.ToShortDateString() + "\t\tHora: " + DateTime.Now.ToLongTimeString());
            Porta.WriteLine("\t\tAguarde a sua vez!");
            Porta.WriteLine("\"UBS Homero Gil, INOVANDO POR UM SUS MELHOR.\"");
            Porta.WriteLine("\n\n\n\n\n\n\n");
            //Porta.WriteLine("x6D");

            Fecha_Porta();
            /*"<bmp><tb><tb><tb><tb><b>UBS HOMERO GIL</tb></tb></tb></tb>" +
                "<l></l>        Rua Divinópolis, 153<l></l>        Tel: 3595 - 7777</b></bmp>" +
                "<tc>~</tc><l></l><e>Box Saud. Criança/Mulher</e><l></l><l></l><tb><tb>Senha:   <e><b>" + 
                senha + "</b></e></tb></tb><l></l><tc>~</tc><l></l>" +
                "Data: "+ DateTime.Now.ToShortDateString() + "<tb><tb>Hora: " + DateTime.Now.ToShortTimeString() +
            "</tb></tb>" + "<sl>1</sl>Aguarde sua vez!<l></l>\"UBS Homero Gil, Em Busca da Qualidade...\"<sl>6</sl>"*/

        }
    }
}
