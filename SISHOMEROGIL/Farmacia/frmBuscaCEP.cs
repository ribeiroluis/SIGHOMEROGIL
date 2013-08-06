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
    public partial class frmBuscaCEP : frmModelo
    {
        AcessoDados acessar = new AcessoDados();
        public string CEPSelecionado = "";
        public frmBuscaCEP()
        {
            InitializeComponent();
        }

        private void txLogradouro_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void dtgDados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            
        }

        private void txLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    viewBuscaCEPTableAdapter busca = new viewBuscaCEPTableAdapter();
                    dtgDados.DataSource = busca.RetornaDataTablePorPartedoNome("%" + txLogradouro.Text + "%"); 
                    
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void dtgDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string selecionado = dtgDados.CurrentRow.Cells["CEP"].Value.ToString() +
                dtgDados.CurrentRow.Cells["ENDERECO"].Value.ToString() +
                dtgDados.CurrentRow.Cells["BAIRRO"].Value.ToString();
                CEPSelecionado = dtgDados.CurrentRow.Cells["CEP"].Value.ToString();
                DialogResult resultado = MessageBox.Show("Confirmar seleção do cep?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }
    }
}
