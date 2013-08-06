using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters;

namespace SISHOMEROGIL.Administrador
{
    public partial class frmGerenciaUsuarios : frmModelo
    {
        FUNCIONARIOTableAdapter func = new FUNCIONARIOTableAdapter();
        ACESSOSISTEMATableAdapter acesso = new ACESSOSISTEMATableAdapter();

        public frmGerenciaUsuarios()
        {
            InitializeComponent();
        }

        private void frmGerenciaUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uBSHOMEROGILDataSet.ViewAcessoSistema' table. You can move, or remove it, as needed.
            this.viewAcessoSistemaTableAdapter.Fill(this.uBSHOMEROGILDataSet.ViewAcessoSistema);
            // TODO: This line of code loads data into the 'uBSHOMEROGILDataSet.ViewAcessoUsuarios' table. You can move, or remove it, as needed.
            this.sETORTableAdapter.Fill(this.uBSHOMEROGILDataSet.SETOR);
            // TODO: This line of code loads data into the 'uBSHOMEROGILDataSet.viewUsuariosFormadeAcesso' table. You can move, or remove it, as needed.
            this.tIPOACESSOTableAdapter.Fill(this.uBSHOMEROGILDataSet.TIPOACESSO);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txIdusuarios.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txMatricula.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbDescricao.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbAcesso.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cbSetor.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txLogin.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            btnSalvar.Text = "Salvar";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            frmGerenciaUsuarios_Load(sender,e);
            txIdusuarios.Clear();
            txNome.Clear();
            txMatricula.Clear();
            cbDescricao.ResetText();
            cbAcesso.ResetText();
            cbSetor.ResetText();
            txLogin.ResetText();
            txSenha.ResetText();
            txConfirmarSenha.ResetText();
            btnSalvar.Text = "Incluir";
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            switch (btnSalvar.Text)
            {
                case "Incluir": IncluirUsuario(); break;
                case "Salvar": AlterarUsuario(); break;
                default:
                    break;
            }
        }
        private void IncluirUsuario()
        {
            FUNCIONARIOTableAdapter func = new FUNCIONARIOTableAdapter();
            ACESSOSISTEMATableAdapter acesso = new ACESSOSISTEMATableAdapter();

            DataTable funcionarios = func.GetData();
            DialogResult resultado = MessageBox.Show("Atenção","Confirmar inclusão?",MessageBoxButtons.YesNo);
            int id = 0;

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                for (int i = 0; i < funcionarios.Rows.Count; i++)
                {
                    DataRow linha = funcionarios.Rows[i];                   

                    if (txNome.Text.ToUpper().Equals(linha["NOME"].ToString()))
                    {
                        id = int.Parse(linha[0].ToString());
                        break;
                    }
                }


                if (txSenha.Text.Equals(txConfirmarSenha.Text) && txSenha.Text != "" && txConfirmarSenha.Text != "" &&
                    txNome.Text != "" && txMatricula.Text != "" && txSenha.Text.Length > 5)
                {
                    if (id == 0)
                    {
                        func.Insert(txNome.Text.ToUpper(), txMatricula.Text);
                        id = (int)func.RetornaIDPorNome(txNome.Text.ToUpper());
                        acesso.Insert(id, (int)cbAcesso.SelectedValue, (int)cbSetor.SelectedValue, txLogin.Text, txSenha.Text);
                        MessageBox.Show("Ok!");
                        btnLimpar.PerformClick();
                    }
                    else
                        MessageBox.Show("Usuario já cadastrado");
                }
                else
                {
                    MessageBox.Show("Senhas não conferem!!\n Ou faltam alguns dados...");
                }
            }
            
        }

        private void AlterarUsuario()
        {
            DialogResult resultado = MessageBox.Show("Atenção", "Atualizar dados?", MessageBoxButtons.YesNo);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                if (txSenha.Text.Equals(txConfirmarSenha.Text) && txSenha.Text != "" && txConfirmarSenha.Text != "" &&
                    txNome.Text != "" && txMatricula.Text != "" && txSenha.Text.Length > 5)
                {
                    func.AtualizaFuncionario(txNome.Text.ToUpper(), txMatricula.Text, int.Parse(txIdusuarios.Text));
                    acesso.AtualizaFormadeAcesso((int)cbAcesso.SelectedValue, (int)cbSetor.SelectedValue, txLogin.Text, txSenha.Text, int.Parse(txIdusuarios.Text));
                    MessageBox.Show("Ok!");
                    btnLimpar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Senhas não conferem!!\n Ou faltam alguns dados...");
                }
            }

            
 
        }
        
    }
}
