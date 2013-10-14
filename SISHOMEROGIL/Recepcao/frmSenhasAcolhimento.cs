using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.Controles;
using System.IO;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmSenhasAcolhimento : frmModelo
    {
        NUMEROS_MICROAREA _objNumMicroarea;
        Imprimir _imprimir;
        
        int ContaMarcacaoPrioridade = 0;
        int ContaMarcacao = 0;
        
        int ContaAcolhimentoAlfa = 0;
        int ContaAcolhimentoAlfaPrioridade = 0;
        
        int ContaAcolhimentoBeta = 0;
        int ContaAcolhimentoBetaPrioridade = 0;
        
        int ContaAcolhimentoNormal = 0;
        int ContaAcolhimentoNormalPrioridade = 0;

        string _Equipe = string.Empty;



        public frmSenhasAcolhimento()
        {
            InitializeComponent();
            _objNumMicroarea = new NUMEROS_MICROAREA();
            _imprimir = new Imprimir();
            
        }

        private void txLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _objNumMicroarea._CEP.Logradouro = txLogradouro.Text;
                    if (_objNumMicroarea._CEP.PesquisaLogradouro())
                    {
                        lbBairro.Text = "Bairro: " + _objNumMicroarea._CEP.Bairro;
                        GpTipo.Visible = true;
                        GPMarcacao.Visible = true;
                        gpEnderecos.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Mais de um endereço localizado pesquise cep ");
                        Pesquisar();
                        GpTipo.Visible = true;
                        GPMarcacao.Visible = true;
                        gpEnderecos.Enabled = false;
                    }

                    if (_objNumMicroarea._CEP._CEP != null)
                    {
                        if (_objNumMicroarea.PreencheNumMicroarea())
                            if (_objNumMicroarea.Microarea.PreencheMicroarea())
                                if (_objNumMicroarea.Microarea.ACS.PreencheFuncionario())
                                    if (_objNumMicroarea.Microarea._AREA.PreencheArea())
                                        if (_objNumMicroarea.Microarea._AREA.Enfermeiro.PreencheFuncionario())
                                            if (_objNumMicroarea.Microarea._AREA.Medico.PreencheFuncionario())
                                                _Equipe = _objNumMicroarea.Microarea._AREA.Equipe;

                    }                  


                }             



            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void frmSenhasAcolhimento_Load(object sender, EventArgs e)
        {
            try
            {
                _objNumMicroarea._CEP.PreencheListaCEP();
                foreach (var item in _objNumMicroarea._CEP.ListaCEPCadastrados)
                {
                    txLogradouro.AutoCompleteCustomSource.Add(item.Logradouro);
                }

                DateTime data = DateTime.Now;


                string path = @"c:\temp\LogSenhasNova" + data.Day + data.Month + data.Year + ".txt";


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
                    string[] Senhas = File.ReadAllLines(path)[0].Split(';');

                    if (Senhas.Length > 0)
                    {
                        ContaMarcacao = int.Parse(Senhas[0]);
                        ContaMarcacaoPrioridade = int.Parse(Senhas[1]);
                        ContaAcolhimentoAlfa = int.Parse(Senhas[2]);
                        ContaAcolhimentoAlfaPrioridade = int.Parse(Senhas[3]);
                        ContaAcolhimentoBeta = int.Parse(Senhas[4]);
                        ContaAcolhimentoBetaPrioridade = int.Parse(Senhas[5]);
                        ContaAcolhimentoNormal = int.Parse(Senhas[6]);
                        ContaAcolhimentoNormalPrioridade = int.Parse(Senhas[7]);
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void linkConsultaCEP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pesquisar();
        }
        

        private void Pesquisar()
        {
            frmBuscaCEP busca = new frmBuscaCEP();
            busca.ShowDialog();
            _objNumMicroarea._CEP._CEP = int.Parse(busca.CEPSelecionado);
            if (_objNumMicroarea._CEP.PesquisaCEP())
                lbBairro.Text = "Bairro: " + _objNumMicroarea._CEP.Bairro;
 
        }

        private void btnMarcacaoPrioridade_Click(object sender, EventArgs e)
        {
            ContaMarcacaoPrioridade++;
            Escreve("Marcação Prioridade", ContaMarcacaoPrioridade);

        }       

        private void btnAcolhimentoPrioridade_Click(object sender, EventArgs e)
        {
            switch (_Equipe)
            {
                case "ALFA": ContaAcolhimentoAlfaPrioridade++; Escreve("Acolhimento Alfa - Prioridade",ContaAcolhimentoAlfaPrioridade); break;
                case "BETA": ContaAcolhimentoBetaPrioridade++; Escreve("Acolhimento Beta - Prioridade",ContaAcolhimentoBetaPrioridade); break;
                default: ContaAcolhimentoNormalPrioridade++; Escreve("Acolhimento Prioridade",ContaAcolhimentoNormalPrioridade); break;
            }
        }

        private void BtnAcolhimento_Click(object sender, EventArgs e)
        {
            switch (_Equipe)
            {
                case "ALFA": ContaAcolhimentoAlfa++; Escreve("Acolhimento Alfa",ContaAcolhimentoAlfa); break;
                case "BETA": ContaAcolhimentoBeta++; Escreve("Acolhimento Beta",ContaAcolhimentoBeta); break;
                default: ContaAcolhimentoNormal++; Escreve("Acolhimento",ContaAcolhimentoNormal); break;
            }

        }

        private void btnMarcacaoNormal_Click(object sender, EventArgs e)
        {
            ContaMarcacaoPrioridade++;
            
            Escreve("Marcação",ContaMarcacaoPrioridade);

        }
        
        /// <summary>
        /// Escrever senha
        /// </summary>
        /// <param name="titulo">Titulo da senha ex: box saude adulto</param>
        /// <param name="senha">numSenha</param>
        private void Escreve(string titulo, int senha)
        {
            _imprimir.imprimeTexto(titulo, senha.ToString());            
            
            //imprime.imprimeTexto("Box Saud. Adulto", senha); break;

            DateTime data = DateTime.Now;
            string path = @"c:\temp\LogSenhasNova" + data.Day + data.Month + data.Year + ".txt";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(ContaMarcacao + ";" + ContaMarcacaoPrioridade + ";" + ContaAcolhimentoAlfa + ";" +
                    ContaAcolhimentoAlfaPrioridade + ";" + ContaAcolhimentoBeta + ";" +
                    ContaAcolhimentoBetaPrioridade + ";" + ContaAcolhimentoNormal + ";" +
                    ContaAcolhimentoNormalPrioridade);
            }
            GPMarcacao.Visible = false;
            GpTipo.Visible = false;
            gpEnderecos.Enabled = true;
            lbBairro.Text = string.Empty;
            txLogradouro.Clear();
            _Equipe = string.Empty;
            this.ActiveControl = txLogradouro;
        }
        
    }
}
