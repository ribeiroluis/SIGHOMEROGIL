using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISHOMEROGIL
{
    public partial class frmLogin : frmModelo
    {
        AcessoDados acessar = new AcessoDados();
        DataTable UsuariosFirebird;

        public frmLogin(DataTable tabelausuariofirebird)
        {
            InitializeComponent();
            UsuariosFirebird = tabelausuariofirebird;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable tabela = acessar.AcessoSistema(txLogin.Text);
                if (tabela.Rows.Count < 1)
                    MessageBox.Show("Usuário inválido...");
                else
                {
                    DataRow linha = tabela.Rows[0];
                    if (linha[5].ToString().Equals(txSenha.Text))
                    {
                        this.Visible = false;
                        int _idFuncionario = (int)linha[1];
                        int _formaAcesso = (int)linha[2];
                        int _setor = (int)linha[3];
                        frmMenuPrincipal menu = new frmMenuPrincipal(_setor, _formaAcesso, _idFuncionario, UsuariosFirebird);
                        this.Visible = false;
                        menu.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Senha inválida...");

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txSenha;
            }
        }

        private void txSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnConfirmar;
            }
        }


    }
}
