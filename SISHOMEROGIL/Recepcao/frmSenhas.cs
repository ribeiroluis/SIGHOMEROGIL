using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmSenhas: Form
    {
        Imprimir imprime;
        string path;
        
        int contSenhaMulherCrianca = 0;
        int contSenhaMulherCriancaPrioridade = 0;
        
        int contSenhaAdulto = 0;
        int contSenhaAdultoPrioridade = 0;
        
        int contSenhaMarcacao = 0;
        int contSenhaMarcacaoPrioridade = 0;

        string tipo;
      
        public frmSenhas()
        {
            InitializeComponent();
            imprime = new Imprimir();
            imprime.VerificaPorta();
        }

        private void btnAdulto_Click(object sender, EventArgs e)
        {
            pnAcolhimento.Visible = false;
            tipo = "AD";
        }

        private void btnMulherCrianca_Click(object sender, EventArgs e)
        {
            pnAcolhimento.Visible = false;
            tipo = "MU";
        }

        private void btnMarcacao_Click(object sender, EventArgs e)
        {
            pnAcolhimento.Visible = false;
            tipo = "MC";
        }
        
        private void btnSim_Click(object sender, EventArgs e)
        {
            pnAcolhimento.Visible = true;
            switch (tipo)
            {
                case "AD": contSenhaAdultoPrioridade++; ImprimeSenha(1, contSenhaAdultoPrioridade); break;
                case "MU": contSenhaMulherCriancaPrioridade++; ImprimeSenha(1, contSenhaMulherCriancaPrioridade); break;
                case "MC": contSenhaMarcacaoPrioridade++; ImprimeSenha(1, contSenhaMarcacaoPrioridade); break;
                default:
                    break;
            }
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            pnAcolhimento.Visible = true;
            switch (tipo)
            {
                case "AD": contSenhaAdulto++; ImprimeSenha(0, contSenhaAdulto); break;
                case "MU": contSenhaMulherCrianca++; ImprimeSenha(0, contSenhaMulherCrianca); break;
                case "MC": contSenhaMarcacao++; ImprimeSenha(0, contSenhaMarcacao); break;
                default:
                    break;
            }
        }

        private void frmSenhas_Load(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            
            path = @"c:\temp\LogSenhas" + data.Day + data.Month + data.Year + ".txt";

            
            if (!Directory.Exists(@"c:\temp"))
            {
                var a = Directory.CreateDirectory(@"c:\temp");
                
            }
            if (!File.Exists(path))
            {
                var a = File.Create(path);
                a.Close();                
            }
            else
            {
                string[] Senhas = File.ReadAllLines(path);

                foreach (var item in Senhas)
                {
                    string[] aux = item.Split(';');

                    
                    //Adulto
                    if (aux[0].Equals("AD"))
                    {
                        //Prioridade
                        if (aux[1].Equals("1")) { 
                            contSenhaAdultoPrioridade++; }
                        else
                            contSenhaAdulto++; //Sem prioridade
                    }
                    //Mulher
                    else if (aux[0].Equals("MU"))
                    {
                        //Prioridade
                        if (aux[1].Equals("1"))
                        {
                            contSenhaMulherCriancaPrioridade++;
                        }
                        else
                            contSenhaMulherCrianca++; //Sem prioridade
                    }
                    //Marcacao de consultas
                    else if (aux[0].Equals("MC"))
                    {
                        //Prioridade
                        if (aux[1].Equals("1"))
                        {
                            contSenhaMarcacaoPrioridade++;
                        }
                        else
                            contSenhaMarcacao++; //Sem prioridade
                    }
                }


                DirectoryInfo diretorio = new DirectoryInfo(@"c:\LOGSENHAS");
                FileInfo arquivo = new FileInfo(path);

                int adulto = (contSenhaAdulto + contSenhaAdultoPrioridade);
                int mulher = (contSenhaMulherCrianca + contSenhaMulherCriancaPrioridade);
                int marca = (contSenhaMarcacao + contSenhaMarcacaoPrioridade);
                lbClinica.Text = adulto.ToString();
                lbGinceco.Text = mulher.ToString();
                lbMarc.Text = marca.ToString();
                lbtotal.Text = "Total senhas: " + (adulto + mulher + marca).ToString();


            }
        }

        private void ImprimeSenha(int prioridade, int numero)
        {

            int adulto = (contSenhaAdulto + contSenhaAdultoPrioridade);
            int mulher = (contSenhaMulherCrianca + contSenhaMulherCriancaPrioridade);
            int marca = (contSenhaMarcacao + contSenhaMarcacaoPrioridade);
            lbClinica.Text = adulto.ToString();
            lbGinceco.Text = mulher.ToString();
            lbMarc.Text = marca.ToString();
            lbtotal.Text = "Total de senhas: " + (adulto + mulher + marca).ToString();

            using (StreamWriter writer = new StreamWriter(path,true))
            {
                writer.WriteLine(tipo + ";" + prioridade + ";" + numero);
            }
            if (prioridade == 0)
            {
                try
                {
                    string senha = tipo + "_" + numero;
                    switch (tipo)
                    {
                        case "AD": imprime.imprimeTexto("Box Saud. Adulto", senha); break;
                        case "MU": imprime.imprimeTexto("Box Saud. Criança/Mulher", senha); break;
                        case "MC": imprime.imprimeTexto("Marcação de Consultas", senha); break;
                        default:
                            break;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }               
            }
            else
            {
                try
                {
                    string senha = "Prioridade - " + tipo + "_" + numero;
                    switch (tipo)
                    {
                        case "AD": imprime.imprimeTexto("Box Saud. Adulto", senha); break;
                        case "MU": imprime.imprimeTexto("Box Saud. Criança/Mulher", senha); break;
                        case "MC": imprime.imprimeTexto("Marcação de Consultas", senha); break;
                        default:
                            break;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                
            }
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FileInfo arquivo = new FileInfo(path);
            MessageBox.Show(arquivo.FullName);
        }

        
    }
}
