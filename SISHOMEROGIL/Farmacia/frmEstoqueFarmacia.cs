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
    public partial class frmEstoqueFarmacia : frmModelo
    {
        AcessoDados acessar = new AcessoDados();
        int IdFuncionario;
        public frmEstoqueFarmacia( int idfuncionario)
        {
            InitializeComponent();
            IdFuncionario = idfuncionario;
            GeraCustomSource();
        }

        private void txCodigoMedicamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txCodigoMedicamento.Text.Equals(""))
                    {
                        txDescricao.ReadOnly = false;
                        this.ActiveControl = txDescricao;
                        txDescricao.BackColor = Color.White;
                        
                        
                    }
                    else
                    {
                        if (acessar.Estoque_RetornaSeExisteCodigo(txCodigoMedicamento.Text))
                        {
                            txCodigoMedicamento.ReadOnly = true;
                            txDescricao.Text = acessar.Estoque_RetornaDescricaoPorCodigo(txCodigoMedicamento.Text);
                            DataTable tabela = acessar.Estoque_RetornaPorDescricao(txDescricao.Text);
                            DataRow linha = tabela.Rows[0];
                            txIDMedicamento.Text = linha["IDDESCRICAO"].ToString();
                            txDescricao.Text = linha["DESCRICAO"].ToString();
                            txCodigoMedicamento.Text = linha["CODIGO"].ToString();
                            txQuantidade.Enabled = true;
                            this.ActiveControl = txQuantidade;
                            PreencheItens(txIDMedicamento.Text);
                            dateValidade.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Código não localizado!");
                            txCodigoMedicamento.Clear();
                        }

                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void GeraCustomSource()
        {
            try
            {
                DataTable table = acessar.Estoque_RetornaDataTableDescricao();
                txDescricao.AutoCompleteCustomSource.Clear();
                foreach (DataRow row in table.Rows)
                {
                    string aux = (string)row[1];
                    txDescricao.AutoCompleteCustomSource.Add(aux);
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txDescricao.Text.Equals(""))
                    {
                        MessageBox.Show("Digite algo...");
                    }
                    else
                    {
                        if (TestaSeExisteDescricao())
                        {
                            txCodigoMedicamento.ReadOnly = true;
                            txDescricao.ReadOnly = true;
                            DataTable tabela = acessar.Estoque_RetornaPorDescricao(txDescricao.Text);
                            DataRow linha = tabela.Rows[0];
                            txIDMedicamento.Text = linha["IDDESCRICAO"].ToString();
                            txDescricao.Text = linha["DESCRICAO"].ToString();
                            txCodigoMedicamento.Text = linha["CODIGO"].ToString();
                            txQuantidade.Enabled = true;
                            dateValidade.Enabled = true;
                            this.ActiveControl = txQuantidade;
                            PreencheItens(txIDMedicamento.Text);
                        }
                        else
                        {
                            ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
                            DialogResult resultado = MessageBox.Show("Medicamento não localizado!\nCadastrar novo?","Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (resultado == System.Windows.Forms.DialogResult.Yes)
                            {
                                string aux = txDescricao.Text.ToUpper();
                                txDescricao.Text = aux;
                                int linha = estoque.RetornaDataTablePorCodigoNP().Rows.Count + 1;
                                string codigo = "NP_" + linha.ToString().PadLeft(4, '0');
                                estoque.Insert(txDescricao.Text, codigo);

                                int descricao = int.Parse(estoque.RetornaIDDescricaoPorDescricao(txDescricao.Text).ToString());
                                ITENSESTOQUETableAdapter itens = new ITENSESTOQUETableAdapter();
                                itens.Insert(descricao, DateTime.Now, 0);
                                MessageBox.Show("Cadastrado com sucesso!\nCódigo: " + codigo);
                                GeraCustomSource();
                                txDescricao_KeyDown(sender, e);
                                
                            }
                            else
                                btnLimpar_Click(sender, e);
                            
                        }
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
            
        }

        private void frmEstoqueFarmacia_Load(object sender, EventArgs e)
        {
            try
            {
                dtgDadosItensEstoque.DataSource = acessar.ItensEstoque_RetornaDataTableItensEstoques();
                this.ActiveControl = txCodigoMedicamento;
                txDescricao.BackColor = SystemColors.Window;

                int indice = 1;
                foreach (DataGridViewRow linha in dtgDadosItensEstoque.Rows)
                {
                    if (linha.IsNewRow) continue;
                    linha.HeaderCell.Value = indice.ToString();
                    indice++;
                }

                dtgDadosItensEstoque.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                this.WindowState = FormWindowState.Maximized;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txCodigoMedicamento.Clear();
            txCodigoMedicamento.ReadOnly = false;
            this.ActiveControl = txCodigoMedicamento;
            txIDMedicamento.Clear();
            txDescricao.ReadOnly = true;
            txDescricao.Clear();
            txQuantidade.Enabled = false;
            txQuantidade.Clear();
            dateValidade.Enabled = false;
            btnExcluir.Enabled = false;
            txEstoqueAtual.Clear();
            frmEstoqueFarmacia_Load(sender, e);


        }

        private void PreencheCampos(string descricao)
        {
            DataTable tabela = acessar.Estoque_RetornaPorDescricao(descricao);
            DataRow linha = tabela.Rows[0];
            txIDMedicamento.Text = linha["IDDESCRICAO"].ToString();
            txDescricao.Text = linha["DESCRICAO"].ToString();
            txCodigoMedicamento.Text = linha["CODIGO"].ToString();
            txQuantidade.Enabled = true;
            this.ActiveControl = txQuantidade;
        }

        private void PreencheItens(string idMedicamento)
        {
            try
            {
                DataTable tabela = acessar.ItensEstoque_RetornaDatatablePorIDDescricao(idMedicamento);
                
                if (tabela.Rows.Count == 1)
                {
                    DataRow linha = tabela.Rows[0];
                    txEstoqueAtual.Text = linha["QUANTIDADE"].ToString();
                    dateValidade.Value = (DateTime)linha["VALIDADE"];
                }
                else
                {
                    MessageBox.Show("Não há itens cadastrados por favor cadastre.");
                    txQuantidade.Enabled = true;
                    dateValidade.Enabled = true;
                    this.ActiveControl = dateValidade;

                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void dateValidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = txQuantidade;
            }
        }

        private void txQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnIncluir;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txEstoqueAtual.Text.Equals(""))
                {
                    txEstoqueAtual.Text = "0";
                }

                int quantidade = int.Parse(txEstoqueAtual.Text) + int.Parse(txQuantidade.Text);
                int idmedicamento = int.Parse(txIDMedicamento.Text);
                acessar.ItensEstoque_AtualizaItens(idmedicamento, quantidade, dateValidade.Value);
                btnLimpar_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                btnLimpar_Click(sender, e);
            }
            
            
        }

        private bool TestaSeExisteDescricao()
        {
            try
            {
                DataTable tabela = acessar.Estoque_RetornaPorDescricao(txDescricao.Text);
                if (tabela.Rows.Count < 1)
                    return false;
                else
                    return true;
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
                return false;
            }
            
            
        }

        private void txDescricao_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dtgDadosItensEstoque.DataSource = acessar.ItensEstoque_RetornaDataTableParteNome(txDescricao.Text);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void dtgDadosItensEstoque_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string descricao = dtgDadosItensEstoque.CurrentRow.Cells["DESCRICAO"].Value.ToString();
            PreencheCampos(descricao);            
            PreencheItens(txIDMedicamento.Text);
            btnExcluir.Enabled = true;
            dateValidade.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja realmente excluir a quantidade de itens?","Atenção!",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    if (txQuantidade.Text.Equals("") || int.Parse(txQuantidade.Text) > int.Parse(txEstoqueAtual.Text))
                        MessageBox.Show("Verifique os dados");
                    else
                    {

                        int value = int.Parse(txQuantidade.Text) * (-1);
                        int quantidade = int.Parse(txEstoqueAtual.Text) + value;
                        acessar.ItensEstoque_AtualizaItens(int.Parse(txIDMedicamento.Text), quantidade, dateValidade.Value);
                        int iditemestoque = acessar.ItensEstoque_RetornaIDPorIDDescricao(int.Parse(txIDMedicamento.Text));


                        acessar.ItensEstoque_InsereBaixaNoEstoque(iditemestoque, int.Parse(txIDMedicamento.Text), int.Parse(txQuantidade.Text));
                        MessageBox.Show("Excluido com sucesso");
                        
                        

                        btnLimpar_Click(sender, e);

                    }
                }
                else
                {
                    MessageBox.Show("Cancelado pelo usuario");
                    btnLimpar_Click(sender, e);
                }
            }
            catch (Exception err) 
            {

                MessageBox.Show(err.Message);
            }
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
    }
}
