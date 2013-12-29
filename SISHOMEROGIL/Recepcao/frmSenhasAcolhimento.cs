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
        
        int ContaAcolhimento = 0;
        int ContaAcolhimentoPrioridade = 0;

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
                        txCEP.Text = _objNumMicroarea._CEP._CEP.ToString();
                        PreencheCbNumeros();
                        this.ActiveControl = cbNumero;
                    }
                    else
                    {
                        MessageBox.Show("Mais de um endereço localizado pesquise cep ");
                        Pesquisar();
                        //GpTipo.Visible = true;
                        //GPMarcacao.Visible = true;
                        //gpEnderecos.Enabled = false;
                    }

                    
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void frmSenhasAcolhimento_Load(object sender, EventArgs e)
        {
            try
            {
                lbMedico.Text = string.Empty;
                lbEnfermeiro.Text = string.Empty;
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
                    
                    //contamarcacao;contamarcacaoprioridade;contaacolhimentopsf;contaacolhimentopsfprioridade;contaacolhimentonormal;contaacolhimentoprioridade
                    using (StreamWriter writer = new StreamWriter(path, false))
                    {
                        writer.WriteLine(ContaMarcacao + ";" + ContaMarcacaoPrioridade + ";" + ContaAcolhimento+ ";" +
                            ContaAcolhimentoPrioridade);
                    }
                    
                }
                else
                {
                    string[] Senhas = File.ReadAllLines(path)[0].Split(';');

                    if (Senhas.Length > 0)
                    {
                        ContaMarcacao = int.Parse(Senhas[0]);
                        ContaMarcacaoPrioridade = int.Parse(Senhas[1]);
                        ContaAcolhimento = int.Parse(Senhas[2]);
                        ContaAcolhimentoPrioridade = int.Parse(Senhas[3]);
                    }
                }

                lbMarcacao.Text = (ContaMarcacao + ContaMarcacaoPrioridade).ToString();
                lbAcolhimento.Text = (ContaAcolhimento + ContaAcolhimentoPrioridade).ToString();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void linkConsultaCEP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Pesquisar();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            
        }
        
        private bool Pesquisar()
        {
            bool pesquisa = false;
            frmBuscaCEP busca = new frmBuscaCEP();
            busca.ShowDialog();
            _objNumMicroarea._CEP._CEP = int.Parse(busca.CEPSelecionado);
            if (_objNumMicroarea._CEP.PesquisaCEP())
            {
                lbBairro.Text = "Bairro: " + _objNumMicroarea._CEP.Bairro;
                txCEP.Text = _objNumMicroarea._CEP._CEP.ToString();
                txLogradouro.Text = _objNumMicroarea._CEP.Logradouro;
                pesquisa = true;
                PreencheCbNumeros();
                this.ActiveControl = cbNumero;
            }
            return pesquisa;
        }

        private void btnMarcacaoPrioridade_Click(object sender, EventArgs e)
        {
            ContaMarcacaoPrioridade++;
            Escreve("Marcação Prioridade", ContaMarcacaoPrioridade);

        }       

        private void btnAcolhimentoPrioridade_Click(object sender, EventArgs e)
        {
            if (_Equipe.Equals(string.Empty))
            {
                ContaAcolhimentoPrioridade++;
                string titulo = "PACS\nAcolhimento\nPrioridade";
                Escreve(titulo,ContaAcolhimentoPrioridade);
            }
            else
            {
                ContaAcolhimentoPrioridade++;
                string titulo = "ESF - "+ _Equipe +"\nAcolhimento\nPrioridade";
                Escreve(titulo,ContaAcolhimentoPrioridade, true);
            }
        }

        private void BtnAcolhimento_Click(object sender, EventArgs e)
        {
            if (_Equipe.Equals(string.Empty))
            {
                ContaAcolhimento++;
                string titulo = "PACS\nAcolhimento";
                Escreve(titulo, ContaAcolhimento);
            }
            else
            {
                ContaAcolhimento++;
                string titulo = "ESF - " + _Equipe + "\nAcolhimento";
                Escreve(titulo, ContaAcolhimento,true);
            }
        }

        private void btnMarcacaoNormal_Click(object sender, EventArgs e)
        {
            ContaMarcacao++;            
            Escreve("Marcação",ContaMarcacao);
        }
        
        /// <summary>
        /// Escrever senha
        /// </summary>
        /// <param name="titulo">Titulo da senha ex: box saude adulto</param>
        /// <param name="senha">numSenha</param>
        private void Escreve(string titulo, int senha)
        {
            if (_Equipe.Equals(string.Empty))
                titulo += "\nArea não encontrada/nãocadastrada";

            _imprimir.imprimeTexto(titulo, senha.ToString());            
            
            //imprime.imprimeTexto("Box Saud. Adulto", senha); break;
            

            DateTime data = DateTime.Now;
            string path = @"c:\temp\LogSenhasNova" + data.Day + data.Month + data.Year + ".txt";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(ContaMarcacao + ";" + ContaMarcacaoPrioridade + ";" + ContaAcolhimento + ";" +
                            ContaAcolhimentoPrioridade);
            }
            Limpar();
        }
        
        private void Escreve(string titulo, int senha, bool tipo)
        {
            string equipe;
            if (_objNumMicroarea.Microarea._AREA.Medico.Apelido != null)
                equipe = "Médico: " + _objNumMicroarea.Microarea._AREA.Medico.Apelido + " Enfermeiro(a): " + _objNumMicroarea.Microarea._AREA.Enfermeiro.Apelido;
            else if (_objNumMicroarea.Microarea._AREA.Enfermeiro.Apelido != null)
                equipe = "\nEnfermeiro(a): " + _objNumMicroarea.Microarea._AREA.Enfermeiro.Apelido;
            else
                equipe = string.Empty;
                

            _imprimir.imprimeTexto(titulo, senha.ToString(), equipe);

            //imprime.imprimeTexto("Box Saud. Adulto", senha); break;

            DateTime data = DateTime.Now;
            string path = @"c:\temp\LogSenhasNova" + data.Day + data.Month + data.Year + ".txt";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLine(ContaMarcacao + ";" + ContaMarcacaoPrioridade + ";" + ContaAcolhimento + ";" +
                            ContaAcolhimentoPrioridade);
            }
            Limpar();
            
        }

        private void frmSenhasAcolhimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                btnLimpar_Click(sender, e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
            
        }

        private void Limpar()
        {

            _objNumMicroarea.Microarea._AREA.Medico = new FUNCIONARIO();
            _objNumMicroarea.Microarea._AREA.Enfermeiro = new FUNCIONARIO();
            
            GPMarcacao.Visible = false;
            GpTipo.Visible = false;
            gpEnderecos.Enabled = true;
            lbBairro.Text = string.Empty;
            lbMedico.Text = string.Empty;
            lbEnfermeiro.Text = string.Empty;
            lbACS.Text = string.Empty;
            txCEP.Text = string.Empty;
            cbNumero.Items.Clear();
            cbNumero.Text = string.Empty;
            cbComplemento.Items.Clear();
            cbComplemento.Text = string.Empty;

            PnProfissionais.Visible = false;
            cbComplemento.Visible = false;
            lbComplemento.Visible = false;
            txLogradouro.Clear();
            _Equipe = string.Empty;
            this.ActiveControl = txLogradouro;
            lbMarcacao.Text = (ContaMarcacao + ContaMarcacaoPrioridade).ToString();
            lbAcolhimento.Text = (ContaAcolhimento + ContaAcolhimentoPrioridade).ToString();
 
        }

        private void txCEP_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txCEP.Text.Length == 8)
                    {
                        _objNumMicroarea._CEP._CEP = int.Parse(txCEP.Text);

                        if (_objNumMicroarea._CEP.PesquisaCEP())
                        {
                            txLogradouro.Text = _objNumMicroarea._CEP.Logradouro;
                            lbBairro.Text = "Bairro: " + _objNumMicroarea._CEP.Bairro;
                            PreencheCbNumeros();
                            this.ActiveControl = cbNumero;

                        }
                        else
                        {
                            MessageBox.Show("Cep não localizado");
                            this.ActiveControl = txLogradouro;
                            txCEP.Clear();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Digite o cep corretamente");
                        txCEP.Clear();
                        this.ActiveControl = txCEP;
                    }
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }       
                
        /// <summary>
        /// Retorna true se houver mais de um complemento
        /// </summary>
        /// <returns>true ou false</returns>
        private bool pesquisaComplementos()
        {
            try
            {
                cbComplemento.Items.Clear();
                var list = _objNumMicroarea.RetornaComplementos();
                foreach (var comp in list)
                {
                    cbComplemento.Items.Add(comp);                    
                }
                if (list.Count > 2)
                {
                    
                    return true;
                }
                else
                    return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return false;
            }
        }

        private void PesquisaEquipe()
        {
            try
            {
                if (_objNumMicroarea._CEP._CEP != null)
                {
                    if (_objNumMicroarea.PreencheNumMicroarea())
                        if (_objNumMicroarea.Microarea.PreencheMicroarea())
                            if (_objNumMicroarea.Microarea.ACS.PreencheFuncionario())
                                if (_objNumMicroarea.Microarea._AREA.PreencheArea())
                                {
                                    if (_objNumMicroarea.Microarea._AREA.Enfermeiro.PreencheFuncionario())
                                    {
                                        lbEnfermeiro.Text = "Enfermeiro: " + _objNumMicroarea.Microarea._AREA.Enfermeiro.Apelido;
                                        lbACS.Text = "ACS: " + _objNumMicroarea.Microarea.ACS.Apelido;

                                        if (_objNumMicroarea.Microarea._AREA.Medico.PreencheFuncionario())
                                        {
                                            _Equipe = _objNumMicroarea.Microarea._AREA.Equipe;
                                            lbMedico.Text = "Médico: " + _objNumMicroarea.Microarea._AREA.Medico.Apelido;
                                        }
                                        else
                                            lbMedico.Text = string.Empty;
                                    }
                                }
                }
                GPMarcacao.Visible = true;
                GpTipo.Visible = true;
                gpEnderecos.Enabled = false;
                PnProfissionais.Visible = true;    

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
 
        }

        private void cbComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _objNumMicroarea.Complemento = cbComplemento.Text;
                    PesquisaEquipe();
                }
                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void PreencheCbNumeros()
        {
            try
            {
                cbNumero.Items.Clear();
                List<string> lista = _objNumMicroarea.NumerosCadastrados();
                bool existe = false;
                foreach (var numeros in lista)
                {
                    foreach (var item in cbNumero.Items)
                    {
                        if (item.Equals(numeros))
                            existe = true;
                    }
                    if (!existe)
                        cbNumero.Items.Add(numeros);
                    else
                        existe = false;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void cbNumero_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _objNumMicroarea.Numero = int.Parse(cbNumero.Text);
                    if (pesquisaComplementos())
                    {
                        cbComplemento.Visible = true;
                        lbComplemento.Visible = true;
                        this.ActiveControl = cbComplemento;

                    }
                    else
                    {
                        _objNumMicroarea.Complemento = string.Empty;
                        PesquisaEquipe();

                    }                    
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
    }
}
