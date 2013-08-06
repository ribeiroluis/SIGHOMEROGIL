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
    public partial class frmBuscaReceita : frmModelo
    {
        int IdUsuario;
        public string idReceita;
        public DateTime DataReceita;
        public DateTime ValidadeReceita;
        public string Ocupacao; 
        ViewReceitasTableAdapter receita;

        public frmBuscaReceita(int _IdUsuario)
        {
            InitializeComponent();
            IdUsuario = _IdUsuario;
            receita = new ViewReceitasTableAdapter();
            DataTable tabela = receita.RetornaReceitaPorUsuario(IdUsuario);
            dtgDadosReceitas.DataSource = tabela;
        }
       
        private void dtgDadosReceitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idReceita = dtgDadosReceitas.CurrentRow.Cells["IDRECEITA"].Value.ToString();
            DataReceita = Convert.ToDateTime(dtgDadosReceitas.CurrentRow.Cells["DATARECEITA"].Value);
            ValidadeReceita = Convert.ToDateTime(dtgDadosReceitas.CurrentRow.Cells["VALIDADERECEITA"].Value);
            Ocupacao = dtgDadosReceitas.CurrentRow.Cells["PROFISSIONAL"].Value.ToString();
            this.Close();

        }
    }
}
