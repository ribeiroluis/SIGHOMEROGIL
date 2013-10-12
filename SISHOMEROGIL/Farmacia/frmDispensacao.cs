using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters;

namespace SISHOMEROGIL
{
    public partial class frmDispensacao : frmModelo
    {
        int IDFuncionario;
        AcessoFireBird firebird = new AcessoFireBird();
        AcessoDados acessar = new AcessoDados();

        public frmDispensacao(int _idfuncionario)
        {
            InitializeComponent();
            IDFuncionario = _idfuncionario;            
        }

        #region UsuarioDados

        private bool PesquisaProntuarioUsuarioFireBird(string prontuario)
        {
            try
            {
                DataTable tabela = firebird.RetornaTabelaUsuariosCadastrados();
                DataRow Linha;
                string _prontuario;

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    Linha = tabela.Rows[i];
                    _prontuario = Linha["PRONTUARIO"].ToString();

                    if (_prontuario.Equals(prontuario))
                        return true;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
            
            return false;
        }

        private bool PesquisaProntuarioUsuarioSQLServer(string prontuario)
        {
            try
            {
                USUARIOTableAdapter user = new USUARIOTableAdapter();
                var _prontuario = user.RetornaPronturarioporProntuario(prontuario);


                if (_prontuario == null)
                    return false;
                else if (_prontuario.ToString().Equals(prontuario))
                    return true;
                else
                    return false;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            return false;
            
        }

        private void txProntuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (txProntuario.Text.Equals(""))
                    {
                        txNome.ReadOnly = false;
                        this.ActiveControl = txNome;
                    }
                    else
                    {   
                        if (PesquisaProntuarioUsuarioFireBird(txProntuario.Text.PadLeft(7,'0')))
                        {
                            string prontuario = txProntuario.Text.PadLeft(7, '0');
                            txProntuario.Clear();
                            txProntuario.Text = prontuario;
                            PreencheCamposProntuarioFireBird(txProntuario.Text);
                            PreencheCamposNomeSqlServer(txNome.Text);
                        }
                        else if (PesquisaProntuarioUsuarioSQLServer(txProntuario.Text))
                        {
                            USUARIOTableAdapter user = new USUARIOTableAdapter();
                            DataTable tabela = user.RetornaDataTableUsuarioPorProntuario(txProntuario.Text);
                            if (tabela.Rows.Count > 1)
                            {
                                MessageBox.Show("Mais de um usuario com o mesmo prontuario, procure pelo nome!");
                                this.ActiveControl = txNome;
                                txNome.ReadOnly = false;
                            }
                            else if (tabela.Rows.Count == 1)
                            {
                                txNome.Text = tabela.Rows[0]["NOME"].ToString();
                                PreencheCamposNomeSqlServer(txNome.Text);
                            }
                            else
                            {
                                MessageBox.Show("Prontuario não localizado, procure pelo nome");
                                this.ActiveControl = txNome;
                            }
                        }
                        else
                        {                            
                            txNome.ReadOnly = false;
                            this.ActiveControl = txNome;
                            MessageBox.Show("Prontuario não encontrado procure pelo nome ou cadastre novo!");
                        }
                    }
                }
            }
            catch (Exception err) 
            {

                MessageBox.Show(err.Message);
            }
        }

        private void frmDispensacao_KeyDown(object sender, KeyEventArgs e)        
        {
            switch (e.KeyCode)
            {
                case Keys.F2: btnLimpar_Click(sender, e);
                    break;
                case Keys.Escape : this.Close();
                    break;
                case Keys.F10: btnConfirmar_Click(sender,e);
                    break;
                case Keys.F12: btnEditar_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void LimpaFormulario()
        {
            txIDUsuario.Clear();
            txProntuario.Clear();
            txProntuario.ReadOnly = false;
            txNome.ReadOnly = true;
            txNome.Clear();
            DataNascimento.ResetText();
            DataNascimento.Enabled = false;
            txCPF.ReadOnly = true;
            txCPF.Clear();
            txNomeMae.ReadOnly = true;
            txNomeMae.Clear();
            txCep.ReadOnly = true;
            txCep.Clear();
            TxLogradouro.ReadOnly = true;
            TxLogradouro.Clear();
            txNumero.ReadOnly = true;
            txNumero.Clear();
            txComplemento.ReadOnly = true;
            txComplemento.Clear();
            txBairro.ReadOnly = true;
            txBairro.Clear();
            txTelCelular.ReadOnly = true;
            txTelCelular.Clear();
            txTelFixo.ReadOnly = true;
            txTelFixo.Clear();
            txCartaoSus.Clear();
            txCartaoSus.ReadOnly = true;
            btnConfirmar.Enabled = false;
            this.ActiveControl = txProntuario;
            PainelTipoUsuario.Enabled = false;
            RadioCronico.Checked = false;
            RadioAgudo.Checked = false;
            btnEditar.Enabled = false;
            this.ActiveControl = DataNascimento;
            BackColorWhite();
            AbaDispensacao.Visible = false;
            PainelMedicamentos.Visible = false;
            painelListaMedicamentos.Visible = false;
            LiberaCamposReceita();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaFormulario();
            LiberaCamposReceita();
            LimpaAbaDispensacao();
        }

        private void PreencheCamposProntuarioFireBird(string prontuario)
        {
            DataTable _tabela = firebird.RetornaNomeUsuarioCadastrado(prontuario);
            DataRow _linha = _tabela.Rows[0];
            txProntuario.ReadOnly = true;
            txNome.Text = _linha["DSUSUARIO"].ToString();
            DataNascimento.Value = Convert.ToDateTime(_linha["DTNASCIMENTO"].ToString());
            txCPF.Text = _linha["NRCPF"].ToString();
            txNomeMae.Text = _linha["DSMAE"].ToString();
            txCep.Text = _linha["NRCEP"].ToString();
            txNumero.Text = _linha["NRLOGRADOURO"].ToString();
            txComplemento.Text = _linha["DSCOMPLEMENTO"].ToString();
            txTelFixo.Text = _linha["NRTELEFONE"].ToString();
            txTelCelular.Text = _linha["NRCELULAR"].ToString();
            txCartaoSus.Text = _linha["NRCNS"].ToString();
            LiberaCamposAlteracao();
        }

        private bool VerificaCaracteresEspeciais(string palavra)
        {
            palavra.ToUpper();
            for (int i = 0; i < palavra.Length; i++)
            {
                char teste = palavra[i];

                if ((int)palavra[i] == 32) continue;

                else if ((int)palavra[i] < 65 || (int)palavra[i] > 90)
                    return false;
            }
            return true;        
        }

        private void PreencheCamposNomeSqlServer(string nome)
        {
            USUARIOTableAdapter user = new USUARIOTableAdapter();
            
            DataTable _tabela = new DataTable();

            //string nome = "%" + txNome.Text.Substring(0, (int)(txNome.Text.Length / 2)) + "%";
            if (txNome.Text.Equals(""))
                _tabela = user.RetornaDataTableUsuarioPorProntuario(txProntuario.Text);
            else
                _tabela = user.RetornaDataTableUsuarioPorNome(nome);

            if (_tabela.Rows.Count < 1)
            {
                MessageBox.Show("Nome não encontrado no sistema. Por favor confirme os dados.");
                LiberaCampos();
                this.ActiveControl = DataNascimento;
                btnConfirmar.Text = "Incluir - F10";
                btnConfirmar.Enabled = true;
            }
            else if (_tabela.Rows.Count == 1)
            {
                DataRow linha = _tabela.Rows[0];

                if (!linha["NOME"].ToString().Equals("") && txNome.Text.Equals(""))
                    txNome.Text = linha["NOME"].ToString();

                if (!linha["CPF"].ToString().Equals(""))
                    txCPF.Text = linha["CPF"].ToString();

                if (!linha["CARTAOSUS"].ToString().Equals(""))
                    txCartaoSus.Text = linha["CARTAOSUS"].ToString();

                if (!linha["CEP"].ToString().Equals(""))
                    txCep.Text = linha["CEP"].ToString();

                if (!linha["ENDNUMERO"].ToString().Equals(""))
                    txNumero.Text = linha["ENDNUMERO"].ToString();

                if (!linha["ENDCOMPLEMENTO"].ToString().Equals(""))                    
                     txComplemento.Text = linha["ENDCOMPLEMENTO"].ToString();

                if (!linha["DTNASCIMENTO"].ToString().Equals(""))
                    DataNascimento.Value = (DateTime)linha["DTNASCIMENTO"];

                if (!txCep.Text.Equals(""))
                    PreencheCamposPorCEP(int.Parse(txCep.Text));

                if (!linha["NOMEMAE"].ToString().Equals(""))
                    txNomeMae.Text = linha["NOMEMAE"].ToString();


                if (!linha["TELFIXO"].ToString().Equals(""))
                    txTelFixo.Text = linha["TELFIXO"].ToString();

                if (!linha["TELCEL"].ToString().Equals(""))
                    txTelCelular.Text = linha["TELCEL"].ToString();

                if (linha["TIPOUSUARIO"].ToString().Equals("1"))
                    RadioAgudo.Checked = true;
                else if (linha["TIPOUSUARIO"].ToString().Equals("2"))
                    RadioCronico.Checked = true;

                txIDUsuario.Text = linha["IDUSUARIO"].ToString();
                BloqueiaItens();
                LiberaCamposAlteracao();
                btnConfirmar.Text = "Confirmar - F10";
                this.btnConfirmar.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
                btnConfirmar.Enabled = true;

                MessageBox.Show("Por favor confirme os dados!");
                this.ActiveControl = btnConfirmar;
            }
            else
            {
                MessageBox.Show("Mais de um prontuário localizado, verifique pelo nome");
                LimpaFormulario();
                txNome.ReadOnly = false;
                this.ActiveControl = txNome;
                
            }
        }

        private void PreencheCamposPorCEP(int cep)
        {
            try
            {
                if (txCep.Text.Equals(""))
                {
                    MessageBox.Show("Cep não localizado, verifique!");
                }
                else
                {
                    var tabela = acessar.CEP_RetornaLogradouroBairroPorCEP(cep);
                    DataRow _linha = tabela.Rows[0];
                    TxLogradouro.Text = _linha["ENDERECO"].ToString();
                    txBairro.Text = _linha["BAIRRO"].ToString();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void LiberaCampos()
        {
            txProntuario.ReadOnly = false;
            txNome.ReadOnly = false;
            txCPF.ReadOnly = false;
            txCartaoSus.ReadOnly = false;
            DataNascimento.Enabled = true;
            txNomeMae.ReadOnly = false;
            txCep.ReadOnly = false;
            txNumero.ReadOnly = false;
            txComplemento.ReadOnly = false;
            txTelFixo.ReadOnly = false;
            txTelCelular.ReadOnly = false;
            PainelTipoUsuario.Enabled = true;
            btnConfirmar.Text = "Salvar - F10";
            this.btnConfirmar.Image = global::SISHOMEROGIL.Properties.Resources.confirmar;
            btnConfirmar.Enabled = true;
        }

        private void txCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    DataTable tabela;
                    if (txCep.Text.Equals(""))
                    {
                        MessageBox.Show("Cep não localizado, verifique!");
                        frmBuscaCEP busca = new frmBuscaCEP();
                        busca.ShowDialog();
                        txCep.Text = busca.CEPSelecionado;
                        txCep_KeyDown(sender, e);
                    }
                    else
                    {
                        int cep = int.Parse(txCep.Text);
                        tabela = acessar.CEP_RetornaLogradouroBairroPorCEP(cep);
                        if (tabela.Rows.Count < 1)
                        {
                            MessageBox.Show("Cep não localizado, verifique!");
                            frmBuscaCEP busca = new frmBuscaCEP();
                            busca.ShowDialog();
                            txCep.Text = busca.CEPSelecionado;
                            txCep_KeyDown(sender, e);
                        }
                        else
                        {
                            TxLogradouro.Text = tabela.Rows[0]["ENDERECO"].ToString();
                            txBairro.Text = tabela.Rows[0]["BAIRRO"].ToString();
                            this.ActiveControl = txNumero;
                        }
                    }
                    

                    
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void DataNascimento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txCPF;
            }
        }

        private void txCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (ValidaCPF(txCPF.Text))
                        this.ActiveControl = txCartaoSus;
                    else
                    {
                        MessageBox.Show("CPF incorreto");
                        txCPF.Clear();
                        this.ActiveControl = txCPF;
                    }
                    
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void LiberaCamposAlteracao()
        {
            BackColorWhite();

            if (txProntuario.Text.Equals(""))
            {
                txProntuario.ReadOnly = false;
                txProntuario.BackColor = Color.Yellow;
            }
            if (txNome.Text.Equals(""))
            {
                txNome.ReadOnly = false;
                txNome.BackColor = Color.Yellow;
            }
            if (txCPF.Text.Equals(""))
            {
                txCPF.ReadOnly = false;
                txCPF.BackColor = Color.Yellow;
            }
            if (txCartaoSus.Text.Equals(""))
            {
                txCartaoSus.ReadOnly = false;
                txCartaoSus.BackColor = Color.Yellow;
            }
            if (DataNascimento.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
            {
                DataNascimento.Enabled = true;                
            }
            if (txNomeMae.Text.Equals(""))
            {
                txNomeMae.ReadOnly = false;
                txNomeMae.BackColor = Color.Yellow;
            }
            if (txCep.Text.Equals(""))
            {
                txCep.ReadOnly = false;
                txCep.BackColor = Color.Yellow;
            }
            if (txNumero.Text.Equals(""))
            {
                txNumero.ReadOnly = false;
                txNumero.BackColor = Color.Yellow;
            }
            if (txComplemento.Text.Equals(""))
            {
                txComplemento.ReadOnly = false;                
            }
            if (txTelFixo.Text.Equals(""))
            {
                txTelFixo.ReadOnly = false;
                txTelFixo.BackColor = Color.Yellow;
            }
            if (txTelCelular.Text.Equals(""))
            {
                txTelCelular.ReadOnly = false;
                txTelCelular.BackColor = Color.Yellow;
            }
            if (!RadioAgudo.Checked && !RadioCronico.Checked)
            {
                PainelTipoUsuario.Enabled = true;
                PainelTipoUsuario.BackColor = Color.Yellow;
            }
            else
            {
                PainelTipoUsuario.Enabled = false;
                PainelTipoUsuario.BackColor = Color.White;
            }

            if (txProntuario.Text.Equals(""))
                this.ActiveControl = txProntuario;
            else if (txNome.Text.Equals(""))
                this.ActiveControl = txNome;
            else if (DataNascimento.Value.ToShortDateString().Equals(DateTime.Now.ToShortDateString()))
                this.ActiveControl = DataNascimento;
            else if (txCPF.Text.Equals(""))
                this.ActiveControl = txCPF;
            else if (txCartaoSus.Text.Equals(""))
                this.ActiveControl = txCartaoSus;
            else if (txNomeMae.Text.Equals(""))
                this.ActiveControl = txNomeMae;
            else if (txCep.Text.Equals(""))
                this.ActiveControl = txCep;
            else if (txNumero.Text.Equals(""))
                this.ActiveControl = txNumero;
            else if (txComplemento.Text.Equals(""))
                this.ActiveControl = txComplemento;
            else if (txTelFixo.Text.Equals(""))
                this.ActiveControl = txTelFixo;
            else if (txTelCelular.Text.Equals(""))
                this.ActiveControl = txTelCelular;
            else if (!RadioAgudo.Checked && !RadioCronico.Checked)
                this.ActiveControl = PainelTipoUsuario;
        }

        private void txCartaoSus_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txNomeMae;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {               
            int tipousuario = 2;
            if (RadioAgudo.Checked)
                tipousuario = 1;

            USUARIOTableAdapter user = new USUARIOTableAdapter();
            if (txProntuario.Text.Equals("") || txNome.Text.Equals("") || txCPF.Text.Equals("") || txCartaoSus.Text.Equals("") ||
                DataNascimento.Value.Equals(DateTime.Now) || txNomeMae.Text.Equals("") || txCep.Text.Equals("") ||
                txNumero.Text.Equals("") || txNome.Text.Equals("NONONONO") || txNomeMae.Text.Equals("DSMAE"))
                MessageBox.Show("Há campos sem preenchimento, verifique!");
            else if (txTelFixo.Text.Equals("") && txTelCelular.Text.Equals(""))
                MessageBox.Show("Há campos sem preenchimento, verifique!");
            else if (!RadioAgudo.Checked && !RadioCronico.Checked)
                MessageBox.Show("Há campos sem preenchimento, verifique!");
            else if (!VerificaCaracteresEspeciais(txNome.Text) || !VerificaCaracteresEspeciais(txNomeMae.Text))
            {
                MessageBox.Show("Não utilize caracteres especiais");
                if (VerificaCaracteresEspeciais(txNome.Text))
                {
                    this.ActiveControl = txNome;
                    txNome.BackColor = Color.Yellow;
                }
                else
                {
                    this.ActiveControl = txNomeMae;
                    txNomeMae.BackColor = Color.Yellow;
                }                
            }
            else
            {
                
                if (btnConfirmar.Text.Equals("Incluir - F10"))
                {
                    int retorno = user.InserirNovoUsuario(tipousuario, txProntuario.Text, txNome.Text.ToUpper(), DataNascimento.Value.ToShortDateString(),
                        txCartaoSus.Text, int.Parse(txCep.Text), int.Parse(txNumero.Text), txComplemento.Text, txCPF.Text, txNomeMae.Text.ToUpper(),
                        txTelFixo.Text, txTelCelular.Text);
                    MessageBox.Show(retorno.ToString());
                    btnConfirmar.Enabled = false;
                    btnEditar.Enabled = false;
                    BloqueiaItens();
                    txIDUsuario.Text = user.RetornaIDUsuarioPorNome(txNome.Text).ToString();
                }
                else if (btnConfirmar.Text.Equals("Confirmar - F10"))
                {
                    MessageBox.Show("Confirmado");
                    btnConfirmar.Enabled = false;
                    btnEditar.Enabled = false;
                    BloqueiaItens();
                    user.AtualizaUsuario(tipousuario, txProntuario.Text, txNome.Text.ToUpper(), DataNascimento.Value.ToShortDateString(),
                        txCartaoSus.Text, int.Parse(txCep.Text), int.Parse(txNumero.Text), txComplemento.Text, txCPF.Text, txNomeMae.Text.ToUpper(),
                        txTelFixo.Text, txTelCelular.Text, int.Parse(txIDUsuario.Text));
                }
                else
                {
                    MessageBox.Show("Salvo");
                    btnConfirmar.Enabled = false;
                    btnEditar.Enabled = false;
                    user.AtualizaUsuario(tipousuario, txProntuario.Text, txNome.Text.ToUpper(), DataNascimento.Value.ToShortDateString(),
                        txCartaoSus.Text, int.Parse(txCep.Text), int.Parse(txNumero.Text), txComplemento.Text, txCPF.Text, txNomeMae.Text.ToUpper(),
                        txTelFixo.Text, txTelCelular.Text, int.Parse(txIDUsuario.Text));
                    BloqueiaItens();
                }
                AbaDispensacao.Visible = true;
                CarregaDispensacao();
            }
                
           

        }
        
        private void txNomeMae_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VerificaCaracteresEspeciais(txNomeMae.Text.ToUpper()))
                {
                    string aux = txNomeMae.Text.ToUpper();
                    txNomeMae.Text = aux;
                    this.ActiveControl = txCep;
                }
                else
                    MessageBox.Show("Não coloque caracteres especiais: \n ^~`´!@#$%¨&*(),.;");
                
            }
        }
        
        private void txNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txComplemento;
            }
        }

        private void txComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txTelFixo;
            }
        }

        private void txTelFixo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txTelCelular;
            }
        }
        
        private void txTelCelular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = PainelTipoUsuario;

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {   
            LiberaCampos();            
            this.ActiveControl = DataNascimento;
            btnEditar.Enabled = false;
        }

        private void BloqueiaItens()
        {
            txProntuario.ReadOnly = true;
            txNome.ReadOnly = true;
            DataNascimento.Enabled = false;
            txCPF.ReadOnly = true;
            txNomeMae.ReadOnly = true;
            txCep.ReadOnly = true;
            TxLogradouro.ReadOnly = true;
            txNumero.ReadOnly = true;
            txComplemento.ReadOnly = true;
            txBairro.ReadOnly = true;
            txTelCelular.ReadOnly = true;
            txTelFixo.ReadOnly = true;
            txCartaoSus.ReadOnly = true;            
            PainelTipoUsuario.Enabled = false;            
            btnEditar.Enabled = false;
            PainelTipoUsuario.Enabled = false;
            BackColorWhite();
            btnEditar.Enabled = true;
            btnConfirmar.Enabled = false;
        }

        private void BackColorWhite()
        {
            txProntuario.BackColor = Color.White;
            txNome.BackColor = Color.White;
            txCPF.BackColor = Color.White;
            txCartaoSus.BackColor = Color.White;
            DataNascimento.CalendarTitleBackColor = Color.White;
            txNomeMae.BackColor = Color.White;
            txCep.BackColor = Color.White;
            txNumero.BackColor = Color.White;
            txTelFixo.BackColor = Color.White;
            txTelCelular.BackColor = Color.White;
            PainelTipoUsuario.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txNome.Text.Length < 8)
                    MessageBox.Show("Especifique melhor o nome");
                else
                {
                    if (VerificaCaracteresEspeciais(txNome.Text.ToUpper()))
                    {
                        frmNomesUsuarios nomeusuario = new frmNomesUsuarios(txNome.Text.ToUpper());
                        nomeusuario.ShowDialog();
                        if (nomeusuario.NomeUsuario.Equals(""))
                        {
                            var quant = acessar.RetornaQuantidadeUsuariosCadastrados();

                            txProntuario.Text = "SP_" + quant;
                            LiberaCamposAlteracao();
                            string aux = txNome.Text.ToUpper();
                            txNome.Text = aux;
                            //this.ActiveControl = DataNascimento;
                            btnConfirmar.Enabled = true;
                            btnConfirmar.Text = "Incluir - F10";
                        }

                        else
                        {
                            txNome.Text = nomeusuario.NomeUsuario.ToUpper();
                            txProntuario.Text = nomeusuario.Prontuario;

                            if (nomeusuario.TipoBD.Equals("SQL"))
                                PreencheCamposNomeSqlServer(txNome.Text);
                            else
                                txProntuario_KeyDown(sender, e);
                        }
                    }
                    else
                        MessageBox.Show("Não coloque caracteres especiais: \n ^~`´!@#$%¨&*(),.;");
                }
            }
        }

        #endregion     


        #region Dispensacao

        private void GeraCustomSource()
        {
            try
            {
                DataTable table = acessar.Estoque_RetornaDataTableDescricao();
                txMedicamento.AutoCompleteCustomSource.Clear();
                txDescricaoDispensacao.AutoCompleteCustomSource.Clear();
                foreach (DataRow row in table.Rows)
                {
                    string aux = (string)row[1];
                    txMedicamento.AutoCompleteCustomSource.Add(aux);
                    txDescricaoDispensacao.AutoCompleteCustomSource.Add(aux);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void CarregaDispensacao()
        {
            try
            {
                radioCronicoDispensacao.Checked = true;
                painelSelecionarReceita.Visible = true;
                GeraHistorico();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }            
        }

        private void GeraHistorico()
        {
            try
            {
                ViewDispensacaoPorUsuarioTableAdapter dispensacao = new ViewDispensacaoPorUsuarioTableAdapter();
                dtgHistorico.DataSource = dispensacao.RetornaDataTable(int.Parse(txIDUsuario.Text));
                cbDataHistorico.Items.Clear();
                
                string data = ((DateTime)dtgHistorico[0, 0].Value).ToShortDateString();
                cbDataHistorico.Items.Add(data);
                
                for (int i = 1; i < dtgHistorico.Rows.Count; i++)
                {
                    data = ((DateTime)dtgHistorico[0, i].Value).ToShortDateString();
                    int count = 1;
                    for (int j = 0; j < cbDataHistorico.Items.Count; j++)
                    {
                        if (data.Equals(cbDataHistorico.Items[j].ToString()))
                            count++;                        
                    }
                    if (count < 2)
                        cbDataHistorico.Items.Add(data);
                    
                }


            }
            catch (Exception err) 
            {

                MessageBox.Show("Não há histórico para o paciente. " + err.Message);
            }           
           
        }

        private void frmDispensacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uBSHOMEROGILDataSet.OCUPACAO' table. You can move, or remove it, as needed.
            try
            {
                this.oCUPACAOTableAdapter.PreencheDataTableMedicosEnfermeiros(this.uBSHOMEROGILDataSet.OCUPACAO);
                GeraCustomSource();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnIncluirReceita_Click(object sender, EventArgs e)
        {
            int tipo = 1;
            DialogResult resultado = MessageBox.Show("Confirmar inclusão", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (RadioCronico.Checked == true)
                        tipo = 2;

                    DateTime vencimento = DataReceita.Value.AddMonths((int)txMeses.Value);
                    MEDICAMENTOSUSUARIOCRONICOTableAdapter receita = new MEDICAMENTOSUSUARIOCRONICOTableAdapter();
                    receita.Insert(int.Parse(txIDUsuario.Text), tipo, (int)txOcupacao.SelectedValue, DataReceita.Value, vencimento);
                    BloqueiaItensReceita();
                    ViewReceitasTableAdapter viewreceita = new ViewReceitasTableAdapter();
                    txIdReceita.Text = viewreceita.RetornaIDReceita(int.Parse(txIDUsuario.Text), DataReceita.Value.ToShortDateString(), vencimento.ToShortDateString()).ToString();
                    PainelMedicamentos.Visible = true;
                    painelListaMedicamentos.Visible = true;
                    this.ActiveControl = txMedicamento;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
                
                
            }
            else
            {
                MessageBox.Show("Cancelado pelo usuario");
            }
        }

        private void BloqueiaItensReceita()
        {
            try
            {
                btnIncluirReceita.Enabled = false;
                DataReceita.Enabled = false;
                txOcupacao.Enabled = false;
                txMeses.Enabled = false;
                PainelMedicamentos.Enabled = true;   
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

                    
            
        }

        private void LiberaCamposReceita()
        {
            try
            {
                DataReceita.Enabled = true;
                DataReceita.ResetText();
                txMeses.Enabled = true;
                //txMeses.ResetText();
                this.txMeses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
                this.txQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
                txQuantidade.Enabled = true;
                txOcupacao.Enabled = true;
                txIdReceita.Clear();
                btnIncluirReceita.Enabled = true;
                PainelMedicamentos.Visible = false;
                painelListaMedicamentos.Visible = false;
                txIdMedicamento.Clear();
                txMedicamento.Clear();
                txMedicamento.ReadOnly = false;
                dtgDadosMedicamentos.DataSource = null;
                btnIncluirMedicamento.Enabled = true;
                btnExcluirMedicamento.Enabled = false;

                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

            
        }

        private void btnBuscaReceita_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaReceita busca = new frmBuscaReceita(int.Parse(txIDUsuario.Text));
                if (busca.dtgDadosReceitas.Rows.Count < 1)
                {
                    MessageBox.Show("Não há receitas cadastradas, inclua nova");
                    this.ActiveControl = DataReceita;
                }
                else
                {
                    busca.ShowDialog();
                    txIdReceita.Text = busca.idReceita.ToString(); ;
                    DataReceita.Value = busca.DataReceita;
                    txOcupacao.Text = busca.Ocupacao;
                    int tempo = busca.ValidadeReceita.Month - busca.DataReceita.Month;
                    
                    if (tempo == 0)
                        txMeses.Value = 12;
                    else
                        txMeses.Value = tempo;

                    PainelMedicamentos.Visible = true;
                    painelListaMedicamentos.Visible = true;
                    BloqueiaItensReceita();
                    btnExcluirReceita.Enabled = true;
                    this.ActiveControl = txMedicamento;
                    CarregaMedicamentos();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btnExcluirReceita_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja excluir a receita e seus medicamentos cadastrados?", "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    int idreceita = int.Parse(txIdReceita.Text);

                    DISPENSACAOCRONICOTableAdapter dispensacronico = new DISPENSACAOCRONICOTableAdapter();

                    DataTable MedicamentosEntregues = dispensacronico.RetornaTabelaPorIDCronico(idreceita);

                    if (MedicamentosEntregues.Rows.Count > 0)
                    {
                        string resposta = "";
                        resposta += "Dia: " + MedicamentosEntregues.Rows[0][2].ToString();
                        
                        MessageBox.Show("Impossível exluir, já houve dispensação: \n" + resposta, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        ITENSUSUARIOCRONICOTableAdapter itens = new ITENSUSUARIOCRONICOTableAdapter();
                        MEDICAMENTOSUSUARIOCRONICOTableAdapter receita = new MEDICAMENTOSUSUARIOCRONICOTableAdapter();
                        int resultItens = itens.DeletaItensPorIDCronico(int.Parse(txIdReceita.Text));
                        int resultReceita = receita.DeletaReceitaPorIDCronico(int.Parse(txIdReceita.Text));
                        if (resultItens == 0 && resultReceita == 0)
                            MessageBox.Show("Não há itens para exlcuir!");
                        else
                            MessageBox.Show("Excluido com sucesso!");

                        LiberaCamposReceita(); 
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Selecione primeiro a receita que deseja exluir.\n"+err.Message);
                }
            }
        }

        private void txMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
                try
                {
                    txIdMedicamento.Text = estoque.RetornaIDDescricaoPorDescricao(txMedicamento.Text).ToString();
                    this.ActiveControl = txQuantidade;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }

            }
        }

        private void txQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    this.ActiveControl = btnIncluirMedicamento;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void CarregaMedicamentos()
        {
            try
            {
                ViewItensMedicamentoUsuarioCronicoTableAdapter viewitens = new ViewItensMedicamentoUsuarioCronicoTableAdapter();
                dtgDadosMedicamentos.DataSource = viewitens.RetornaDataTableMedicamentosUsuarioCronico(int.Parse(txIdReceita.Text));
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
        
        private void btnIncluirMedicamento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Realizar inclusão?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    ITENSUSUARIOCRONICOTableAdapter medicamentos = new ITENSUSUARIOCRONICOTableAdapter();
                    DateTime validade = DataReceita.Value.AddMonths((int)txMeses.Value);
                    int incluir = medicamentos.Insert(int.Parse(txIdMedicamento.Text), int.Parse(txIdReceita.Text), (int)txQuantidade.Value, DataReceita.Value, validade);
                    if (incluir == 1)
                        MessageBox.Show("Incluido com sucesso");
                    else
                        MessageBox.Show("Não foi possivel a inclusao");

                    txIdMedicamento.Clear();
                    txMedicamento.Clear();
                    this.txQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
                    this.ActiveControl = txMedicamento;
                    CarregaMedicamentos();
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void dtgDadosMedicamentos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnExcluirMedicamento.Enabled = true;
            btnIncluirMedicamento.Enabled = false;
            ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
            try
            {
                txQuantidade.Value = decimal.Parse(dtgDadosMedicamentos.CurrentRow.Cells["QUANTIDADE"].Value.ToString());
                txMedicamento.Text = dtgDadosMedicamentos.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                txIdMedicamento.Text = estoque.RetornaIDDescricaoPorDescricao(txMedicamento.Text).ToString();
                txMedicamento.ReadOnly = true;
                txQuantidade.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnLimparItensIncluirReceita_Click(object sender, EventArgs e)
        {
            LiberaCamposReceita();
        }

        private void btnExcluirMedicamento_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realizar a exclusão do medicamento?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    ITENSUSUARIOCRONICOTableAdapter itens = new ITENSUSUARIOCRONICOTableAdapter();
                    itens.DeletaMedicamentoPorIDDescricaoIDCronico(int.Parse(txIdMedicamento.Text), int.Parse(txIdReceita.Text));
                    this.txQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
                    txQuantidade.Enabled = true;
                    txMedicamento.ReadOnly = false;
                    txMedicamento.Clear();
                    txIdMedicamento.Clear();
                    CarregaMedicamentos();
                    btnExcluirMedicamento.Enabled = false;
                    btnIncluirMedicamento.Enabled = true;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void radioAgudoDispensacao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgudoDispensacao.Checked == false && radioCronicoDispensacao.Checked == false)
            {
                painelMedicamentosDispensacao.Visible = false;
                painelSelecionarReceita.Visible = false;                
            }
            else if (radioAgudoDispensacao.Checked == true)
            {
                painelMedicamentosDispensacao.Visible = true;
                painelSelecionarReceita.Visible = false;                
            }
            else
            {
                painelSelecionarReceita.Visible = true;
                painelMedicamentosDispensacao.Visible = false;                
            }
        }

        private void radioCronicoDispensacao_CheckedChanged(object sender, EventArgs e)
        {
            if (radioAgudoDispensacao.Checked == false && radioCronicoDispensacao.Checked == false)
            {
                painelMedicamentosDispensacao.Visible = false;
                painelSelecionarReceita.Visible = false;
            }
            else if (radioAgudoDispensacao.Checked == true)
            {
                painelMedicamentosDispensacao.Visible = true;
                painelSelecionarReceita.Visible = false;
            }
            else
            {
                
                painelSelecionarReceita.Visible = true;
                painelMedicamentosDispensacao.Visible = false;                

            }

        }
        
        private void LimpaAbaDispensacao()
        {
            radioAgudoDispensacao.Checked = false;
            radioCronicoDispensacao.Checked = false;
            painelSelecionarReceita.Visible = false;
            painelSelecionarReceita.Visible = false;
            txDescricaoDispensacao.Clear();
            txIdMedicamentoDispensasao.Clear();
            txIDReceitaDispencacao.Clear();
            txProfissionalDispensacao.Clear();
            txDescricaoDispensacao.Clear();
            txDataReceitaDispensacao.Refresh();
            txDataValidadeReceita.Refresh();
            txQuantidadeDispensacao.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txEstoqueDispensacao.Clear();
            painelDispensacaoMedicamentos.Visible = false;
            btnIncluirDispensacao.Visible = false;
            btnIncluirDispensacao.Enabled = true;
            dtgDadosMedicamentosDispensacao.Rows.Clear();
            dtgDadosMedicamentos.DataSource = null;
            dtgHistorico.DataSource = null;
            cbDataHistorico.Items.Clear();
            cbDataHistorico.Refresh();
        }

        private void btnBuscarReceita_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscaReceita busca = new frmBuscaReceita(int.Parse(txIDUsuario.Text));
                if (busca.dtgDadosReceitas.Rows.Count < 1)
                {
                    MessageBox.Show("Não há receitas cadastradas, inclua nova");
                    this.ActiveControl = DataReceita;
                }
                else                
                {   
                    busca.ShowDialog();
                    if (busca.ValidadeReceita > DateTime.Now)
                    {
                        
                        txIDReceitaDispencacao.Text = busca.idReceita.ToString(); ;
                        txProfissionalDispensacao.Text = busca.Ocupacao;
                        txDataReceitaDispensacao.Value = busca.DataReceita;
                        txDataValidadeReceita.Value = busca.ValidadeReceita;
                        painelDispensacaoMedicamentos.Visible = true;
                        PopulaGridMedicamentosCronicos();
                    }
                    else
                        MessageBox.Show("Receita vencida, escolha outra ou insira nova!");
                    
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void PopulaGridMedicamentosCronicos()
        {
            try
            {
                //dtgDadosMedicamentos.Columns[0].ReadOnly = false;
                btnIncluirDispensacao.Visible = true;
                ITENSESTOQUETableAdapter estoque = new ITENSESTOQUETableAdapter();
                ViewItensMedicamentoUsuarioCronicoTableAdapter viewitens = new ViewItensMedicamentoUsuarioCronicoTableAdapter();
                ITENSDISPENSACAOTableAdapter dispensacao = new ITENSDISPENSACAOTableAdapter();


                dtgDadosMedicamentosDispensacao.Rows.Clear();
                DataRow Linha;
                DataTable tabela = viewitens.RetornaDataTableMedicamentosUsuarioCronico(int.Parse(txIDReceitaDispencacao.Text));

                dtgDadosMedicamentosDispensacao.Rows.Add(tabela.Rows.Count);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    Linha = tabela.Rows[i];

                    int saldo = (int)estoque.RetornaQuantidadePorDescricao(Linha["DESCRICAO"].ToString());
                    int quantidade = int.Parse(Linha["QUANTIDADE"].ToString());

                    //fazer rotina para validar entrega no mes *****
                    dtgDadosMedicamentosDispensacao["MEDICAMENTO", i].Value = Linha["DESCRICAO"].ToString();
                    dtgDadosMedicamentosDispensacao["QUANTIDADE", i].Value = Linha["QUANTIDADE"].ToString();
                    dtgDadosMedicamentosDispensacao[0, i].Value = true;                    

                    DataTable itensdispensacao = dispensacao.RetornaDatatableDataDispDescricaoQuantidade(int.Parse(txIDUsuario.Text), Linha["DESCRICAO"].ToString());
                    if (itensdispensacao.Rows.Count > 0)
                    {
                        for (int k = 0; k < itensdispensacao.Rows.Count; k++)
                        {
                            DateTime aux = (DateTime)itensdispensacao.Rows[k]["DATA"];
                            if (aux.Month == DateTime.Now.Month && aux.Year == DateTime.Now.Year)
                            {
                                MessageBox.Show("O paciente já recebeu o medicamento este mês, confira no histórico.\n" + Linha["DESCRICAO"].ToString());
                                dtgDadosMedicamentosDispensacao[0, i].ReadOnly = true;
                                dtgDadosMedicamentosDispensacao[0, i].Value = null;
                                dtgDadosMedicamentosDispensacao["QUANTIDADE", i].Value = 0;
                                break;                                
                            }
                        }
                    }
                    else
                    {
                        if (saldo < quantidade)
                        {
                            if (saldo == 0)
                            {
                                MessageBox.Show("Não há saldo suficiente em estoque do medicamento: \n" + Linha["DESCRICAO"].ToString());
                                dtgDadosMedicamentosDispensacao[0, i].ReadOnly = true;
                                dtgDadosMedicamentosDispensacao[0, i].Value = null;
                                dtgDadosMedicamentosDispensacao["QUANTIDADE", i].Value = saldo;
                                
                            }
                            else
                            {
                                MessageBox.Show("Saldo inferior do medicamento: \n" + Linha["DESCRICAO"].ToString());
                                dtgDadosMedicamentosDispensacao["QUANTIDADE", i].Value = saldo;                                
                            }
                        }
                    }
                }
                for (int i = 0; i < dtgDadosMedicamentosDispensacao.Rows.Count; i++)
                {
                    if (dtgDadosMedicamentosDispensacao[0, i].Value != null)
                    {
                        btnIncluirDispensacao.Enabled = true;
                        break;
                    }
                    else
                    {
                        btnIncluirDispensacao.Enabled = false;
                        txIDReceitaDispencacao.Text = "";
                    }
                }
            }               

            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }            
        }

        private void btnLimparAaDispensacao_Click(object sender, EventArgs e)
        {
            LiberaCamposReceita();
            LimpaAbaDispensacao();
        }

        private void btnIncluirDispensacao_Click(object sender, EventArgs e)
        {
            
            btnIncluirDispensacao.Enabled = false;
            int tipousuario = 2;
            if (RadioAgudo.Checked == true)
                tipousuario = 1;          
            
            #region InsirDispensacaoAtualizarDispensacao  
            try
            {
                DISPENSACAOTableAdapter dispensacao = new DISPENSACAOTableAdapter();
                ITENSDISPENSACAOTableAdapter itensdispensacao = new ITENSDISPENSACAOTableAdapter();
                ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
                ITENSESTOQUETableAdapter _medicamento = new ITENSESTOQUETableAdapter();
                
                int idDispensacao = 0;

                
                for (int i = 0; i < dtgDadosMedicamentosDispensacao.Rows.Count; i++)
                {
                    bool tipo = Convert.ToBoolean(dtgDadosMedicamentosDispensacao[0, i].Value);
                    if (tipo)
                    {
                        dispensacao.Insert(DateTime.Now, int.Parse(txIDUsuario.Text), tipousuario, IDFuncionario);
                        idDispensacao = (int)dispensacao.RetornaIdDispensacao();
                        break;
                    }
                }

                if (idDispensacao == 0)
                {
                    btnIncluirDispensacao.Visible = false;
                    MessageBox.Show("Não há itens selecionados para dispensação...");
                }
                else 
                {
                    for (int i = 0; i < dtgDadosMedicamentosDispensacao.Rows.Count; i++)
                    {
                        bool tipo = Convert.ToBoolean(dtgDadosMedicamentosDispensacao[0, i].Value);
                        if (tipo)
                        {
                            int iddescricao = (int)estoque.RetornaIDDescricaoPorDescricao(dtgDadosMedicamentosDispensacao[1, i].Value.ToString());
                            int idmedicamento = (int)_medicamento.RetornaIDPorDescricaoID(iddescricao);
                            int quantidade = int.Parse(dtgDadosMedicamentosDispensacao[2, i].Value.ToString());
                            itensdispensacao.Insert(idDispensacao, iddescricao, idmedicamento, quantidade);

                            int estoqueAtualizado = (int)_medicamento.RetornaQuantidadePorIdMedicamento(idmedicamento) - quantidade;

                            _medicamento.AtualizaEstoquePorIdItemEstoque(estoqueAtualizado, idmedicamento);
                        }
                        
                    }
                    if (!txIDReceitaDispencacao.Text.Equals(""))
                    {
                        DISPENSACAOCRONICOTableAdapter dispensacronico = new DISPENSACAOCRONICOTableAdapter();
                        int idcronico = int.Parse(txIDReceitaDispencacao.Text);
                        dispensacronico.Insert(idcronico, DateTime.Now, idDispensacao);
                    }

                    DialogResult resultado = MessageBox.Show("Medicamento entreguem com sucesso!\n\nClique em SIM para nova dispensação...", "Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        btnLimpar_Click(sender, e);
                    }
                    
                }
            }

            #endregion 

            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txDescricaoDispensacao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                ITENSESTOQUETableAdapter _medicamento = new ITENSESTOQUETableAdapter();
                ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();

                if (e.KeyCode == Keys.Enter)
                {
                    int iddescricao = (int)estoque.RetornaIDDescricaoPorDescricao(txDescricaoDispensacao.Text);
                    txIdMedicamentoDispensasao.Text = _medicamento.RetornaIDPorDescricaoID(iddescricao).ToString();
                    txEstoqueDispensacao.Text = _medicamento.RetornaQuantidadePorIdMedicamento(int.Parse(txIdMedicamentoDispensasao.Text)).ToString();
                    this.ActiveControl = txQuantidadeDispensacao;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void cbDataHistorico_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ViewDispensacaoPorUsuarioTableAdapter dispensacao = new ViewDispensacaoPorUsuarioTableAdapter();
                dtgHistorico.DataSource = dispensacao.RetornaDataTablePorIdusuarioData(int.Parse(txIDUsuario.Text), cbDataHistorico.SelectedItem.ToString());
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnLimparHistorico_Click(object sender, EventArgs e)
        {
            GeraHistorico();
        }

        private void txQuantidadeDispensacao_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                    this.ActiveControl = btnIncluirMedicamentoDispensacao;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnIncluirMedicamentoDispensacao_Click(object sender, EventArgs e)
        {
            try
            {
                ViewDispensacaoPorUsuarioTableAdapter dispensacao = new ViewDispensacaoPorUsuarioTableAdapter();
                DateTime data = DateTime.Now;
                string dataInicio = "1/" + data.Month + "/" + data.Year;
                string dataFim = data.ToShortDateString();
                DataTable tabela = dispensacao.ConsultaMedicamentosNoMes(int.Parse(txIDUsuario.Text), dataInicio, dataFim, txDescricaoDispensacao.Text);
                if ((int)txQuantidadeDispensacao.Value <= int.Parse(txEstoqueDispensacao.Text))
                {
                    if (tabela.Rows.Count > 0)
                    {
                        DialogResult resultado = MessageBox.Show("Medicamento já entregue neste mês.\nConfirmar entrega?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                        if (resultado == System.Windows.Forms.DialogResult.Yes)
                        {
                            ITENSESTOQUETableAdapter itens = new ITENSESTOQUETableAdapter();
                            dtgDadosMedicamentosDispensacao.Rows.Add(1);
                            int indice = dtgDadosMedicamentosDispensacao.Rows.Count - 1;
                            painelDispensacaoMedicamentos.Visible = true;
                            dtgDadosMedicamentosDispensacao[0, indice].Value = true;
                            dtgDadosMedicamentosDispensacao[1, indice].Value = txDescricaoDispensacao.Text;
                            dtgDadosMedicamentosDispensacao[2, indice].Value = txQuantidadeDispensacao.Value.ToString();
                            btnIncluirDispensacao.Visible = true;
                        }
                        else
                            MessageBox.Show("Cancelado pelo usuário.");
                    }
                    else
                    {
                        ITENSESTOQUETableAdapter itens = new ITENSESTOQUETableAdapter();
                        dtgDadosMedicamentosDispensacao.Rows.Add(1);
                        int indice = dtgDadosMedicamentosDispensacao.Rows.Count - 1;
                        painelDispensacaoMedicamentos.Visible = true;
                        dtgDadosMedicamentosDispensacao[0, indice].Value = true;
                        dtgDadosMedicamentosDispensacao[1, indice].Value = txDescricaoDispensacao.Text;
                        dtgDadosMedicamentosDispensacao[2, indice].Value = txQuantidadeDispensacao.Value.ToString();
                        btnIncluirDispensacao.Visible = true;
                    }
                }
                else
                    MessageBox.Show("Não a saldo para a dispensação solicitada. ");

                LimpaCamposDispensacaoAgudo();
                btnIncluirDispensacao.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void LimpaCamposDispensacaoAgudo()
        {
            txIdMedicamentoDispensasao.Clear();
            txDescricaoDispensacao.Clear();
            txQuantidadeDispensacao.Value = new decimal(new int[] { 1, 0, 0, 0 });
            txEstoqueDispensacao.Clear();
            btnExcluirMedicamentoDispensacao.Enabled = false;
            this.ActiveControl = txDescricaoDispensacao;
        }
        
        
        
        
        #endregion 

        #region ValidaCPF
        public bool ValidaCPF(string cpf)        
        {
            // Caso coloque todos os numeros iguais

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            
            resto = soma % 11;
            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;

 

            digito = resto.ToString();
            tempCpf = tempCpf + digito; 

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

 

            resto = soma % 11;
            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto; 

            digito = digito + resto.ToString();
            
            return cpf.EndsWith(digito);
        }
        #endregion        
               
               
                
    }
}
