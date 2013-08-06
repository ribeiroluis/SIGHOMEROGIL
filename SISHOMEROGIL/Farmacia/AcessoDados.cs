using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SISHOMEROGIL.UBSHOMEROGILDataSetTableAdapters;
using System.Data;

namespace SISHOMEROGIL
{
    class AcessoDados
    {

        public DataTable UsuariosFireBird;

        public AcessoDados()
        {
            
        }

        public void ConexaoFireBird()
        {
            try
            {
                AcessoFireBird acessoFirebird = new AcessoFireBird();
                UsuariosFireBird = acessoFirebird.RetornaTabelaUsuariosCadastrados();
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.Message);
            }
        }

        public DataTable AcessoSistema(string login)
        {
            ACESSOSISTEMATableAdapter query = new ACESSOSISTEMATableAdapter();
            DataTable tabela = query.RetornaDataTablePorLogin(login);
            return tabela;
            
        }

        public string Funcionarios_RetornaNomePorID(int id)
        {
            FUNCIONARIOTableAdapter func = new FUNCIONARIOTableAdapter();
            string nome = func.RetrornaNomeFuncionarioPorID(id).ToString();
            return nome;
        }

        public string Funcionarios_RetornaSetorPorIDFuncionario(int id)
        {
            SETORTableAdapter acesso = new SETORTableAdapter();
            string nome = acesso.RetornaNomeSetorPorId(id).ToString();
            return nome;
        }

        public string Estoque_RetornaDescricaoPorCodigo(string codigo)
        {
            ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
            string descricao = estoque.RetornaDescricaoPorCodigo(codigo).ToString();
            return descricao;

        }

        public DataTable Estoque_RetornaDataTableDescricao()
        {
            ESTOQUETableAdapter query = new ESTOQUETableAdapter();
            DataTable tabela  = query.GetData();
            return tabela;
        }

        public DataTable Estoque_RetornaPorDescricao(string descricao)
        {
            ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
            DataTable tabela = estoque.RetornaDataTablePorDescricao(descricao);
            return tabela;
        }

        public bool Estoque_RetornaSeExisteCodigo(string Codigo)
        {
            ESTOQUETableAdapter estoque = new ESTOQUETableAdapter();
            var descricao = estoque.RetornaDescricaoPorCodigo(Codigo);
            if (descricao == null)
                return false;
            else
                return true;
        }

        public DataTable ItensEstoque_RetornaDatatablePorIDDescricao(string idDescricao)
        {
            ITENSESTOQUETableAdapter itens = new ITENSESTOQUETableAdapter();
            DataTable tabela = itens.RetornaDatatablePorIDDescricao(int.Parse(idDescricao));
            return tabela;

            
        }

        public void ItensEstoque_AtualizaItens(int idmedicamento, int quantidade, DateTime validade)
        {
            ITENSESTOQUETableAdapter itens = new ITENSESTOQUETableAdapter();
            itens.AtualizaItensEstoque(quantidade, validade.ToShortDateString(), idmedicamento);
        }

        public DataTable ItensEstoque_RetornaDataTableItensEstoques()
        {
            VizualizacoesBDTableAdapter ver = new VizualizacoesBDTableAdapter();
            DataTable tabela = ver.RetornaDataTableItensEstoque();
            return tabela;
        }

        public DataTable ItensEstoque_RetornaDataTableParteNome(string Descricao)
        {
            VizualizacoesBDTableAdapter ver = new VizualizacoesBDTableAdapter();
            string nome = "%" + Descricao + "%";
            DataTable tabela = ver.RetornaDatatablePorPartedoNome(Descricao);
            return tabela;
        }

        public void ItensEstoque_InsereBaixaNoEstoque(int idMedicamento, int idDescricao, int Quantidae)
        {
            frmMotivoBaixa formmotivo = new frmMotivoBaixa();
            formmotivo.ShowDialog();
            string Motivo = formmotivo.Texto;
            DateTime Data;
            Data = DateTime.Now;
            BAIXAESTOQUETableAdapter baixar = new BAIXAESTOQUETableAdapter();
            baixar.BaixarItensEstoque(idMedicamento, idDescricao, Data.ToShortDateString(), Motivo, Quantidae);
        }

        public int ItensEstoque_RetornaIDPorIDDescricao(int iddescricao)
        {
            ITENSESTOQUETableAdapter estoque = new ITENSESTOQUETableAdapter();
            var tipo = estoque.RetornaIDPorDescricaoID(iddescricao);
            return (int)tipo;            
        }

        public DataTable CEP_RetornaDataTablePorPartedoNome(string logradouro)
        {
            viewBuscaCEPTableAdapter viewcep = new viewBuscaCEPTableAdapter();            
            DataTable tabela = new DataTable();
            tabela = viewcep.RetornaDataTablePorPartedoNome("%" + logradouro + "%");
            return tabela;
        }

        public DataTable CEP_RetornaLogradouroBairroPorCEP(int cep)
        {
            viewBuscaCEPTableAdapter viewcep = new viewBuscaCEPTableAdapter();            
            DataTable tabela = new DataTable();
            tabela = viewcep.RetornaDataTablePorCEP(cep);
            return tabela;
        }

        public string RetornaQuantidadeUsuariosCadastrados()
        {
            USUARIOTableAdapter user = new USUARIOTableAdapter();
            var quant = user.ContaUsuariosCadastrados() + 1;
            return quant.ToString();
        }



    }
}
