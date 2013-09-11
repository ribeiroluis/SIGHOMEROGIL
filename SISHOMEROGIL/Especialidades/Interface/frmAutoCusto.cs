using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.Especialidades.Controles;

namespace SISHOMEROGIL.Especialidades.Interface
{
    public partial class frmAutoCusto : frmModelo
    {
        Pessoa Usuario;
        public frmAutoCusto()
        {
            InitializeComponent();
            this.ActiveControl = txCartaoSus;
        }        

        private void frmAutoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: btnLimpar_Click(sender, e);
                    break;
                case Keys.Escape: btnSair_Click(sender,e);
                    break;
                case Keys.F10: btnConfirmar_Click(sender, e);
                    break;
                case Keys.F12: btnEditar_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txCep.ReadOnly = true;
            txCep.Clear();

            txComplemento.ReadOnly = true;
            txComplemento.Clear();

            txCPF.ReadOnly = true;
            txCPF.Clear();

            txNome.ReadOnly = true;
            txNome.Clear();

            txNomeMae.ReadOnly = true;
            txNomeMae.Clear();

            txNumero.ReadOnly = true;
            txNumero.Clear();

            txProntuario.ReadOnly = true;
            txProntuario.Clear();

            txTelCelular.ReadOnly = true;
            txTelCelular.Clear();

            txTelFixo.ReadOnly = true;
            txTelFixo.Clear();

            DataNascimento.Enabled = false;
            DataNascimento.Value = Convert.ToDateTime("01/01/1970");

            txIDUsuario.Clear();
            TxLogradouro.Clear();
            txBairro.Clear();
            txCartaoSus.Clear();
            txCartaoSus.ReadOnly = false;
            this.ActiveControl = txCartaoSus;
            
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txCartaoSus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Usuario = new Pessoa();
                    Usuario.CNS = txCartaoSus.Text;

                    if (Usuario.ValidaCNS())
                    {
                        
                        if (Usuario.PesquisaUsuarioPorCartaoSUS())
                        {
                            PreencheCampos();
                            btnConfirmar.Text = "Confirmar";
                        }
                        else
                        {
                            MessageBox.Show("Usuário não localizado, cadastre novo");
                            txCartaoSus.ReadOnly = true;
                            LiberaCampos();
                            btnConfirmar.Text = "Incluir";
                            btnConfirmar.Enabled = true;
                            btnLimpar.Enabled = true;
                            this.ActiveControl = txProntuario;
                        }
                    }
                    else
                        MessageBox.Show("Cartão SUS inválido, verifique");
                }
            }
            catch (Exception err )
            {
                MessageBox.Show(err.Message);
            }
        }

        private void PreencheCampos()
        {
            txBairro.Text = Usuario.Bairro;
            txCep.Text = Usuario.CEP;
            txCartaoSus.Text = Usuario.CNS;
            txComplemento.Text = Usuario.Complemento;
            txCPF.Text = Usuario.CPF;
            txIDUsuario.Text = Usuario.IDUsuario;
            txNome.Text = Usuario.Nome;
            txNomeMae.Text = Usuario.Mae;
            txProntuario.Text = Usuario.Prontuario;
            txTelCelular.Text = Usuario.TelefoneCelular;
            txTelFixo.Text = Usuario.TelefoneFixo;
            DataNascimento.Text = Usuario.DataNascimento;
            TxLogradouro.Text = Usuario.Logradouro;
            txNumero.Text = Usuario.Numero;
            txBairro.Text = Usuario.Bairro;
            btnConfirmar.Enabled = true;
            btnEditar.Enabled = true;
            btnLimpar.Enabled = true;
            txCartaoSus.ReadOnly = true;

        }

        private void LiberaCampos()
        {
            txCep.ReadOnly = false;
            txComplemento.ReadOnly = false;
            txCPF.ReadOnly = false;
            txNome.ReadOnly = false;
            txNomeMae.ReadOnly = false;
            txNumero.ReadOnly = false;
            txProntuario.ReadOnly = false;
            txTelCelular.ReadOnly = false;
            txTelFixo.ReadOnly = false;
            DataNascimento.Enabled = true;
        }

        private void txProntuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Usuario.Prontuario = txProntuario.Text.PadLeft(7, '0');
                    txProntuario.Text = Usuario.Prontuario;
                    if (Usuario.PesquisaUsuarioPorProntuarioFireBird())
                    {
                        PreencheCampos();
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
