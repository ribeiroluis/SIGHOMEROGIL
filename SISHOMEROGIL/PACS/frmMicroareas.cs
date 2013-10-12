using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.BancoDados.DataSetACSTableAdapters;

namespace SISHOMEROGIL.PACS
{
    public partial class frmMicroareas : frmModelo
    {
        DataTable TabelaCEP = new DataTable();
        int CEP, idArea, idEnfermeiro, idMicroarea, idAcs, Numero;
        string complemento;

        public frmMicroareas()
        {
            InitializeComponent();
        }

        private void frmMicroareas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetACS.ViewAcs' table. You can move, or remove it, as needed.
            this.viewAcsTableAdapter.Fill(this.dataSetACS.ViewAcs);
            // TODO: This line of code loads data into the 'dataSetACS.ViewEnfermeiros' table. You can move, or remove it, as needed.
            this.viewEnfermeirosTableAdapter.Fill(this.dataSetACS.ViewEnfermeiros);
            // TODO: This line of code loads data into the 'dataSetACS.TB_AREA' table. You can move, or remove it, as needed.
            this.tB_AREATableAdapter.Fill(this.dataSetACS.TB_AREA);
            
            
            viewBuscaCEPTableAdapter cep = new viewBuscaCEPTableAdapter();
            TabelaCEP = cep.GetData();

            txLogradouro.AutoCompleteCustomSource.Clear();
            foreach (DataRow linha in TabelaCEP.Rows)
            {
                txLogradouro.AutoCompleteCustomSource.Add(linha["ENDERECO"].ToString());
            }
            //this.viewAcsTableAdapter.Fill(this.dataSetACS.ViewAcs);
            //this.viewEnfermeirosTableAdapter.Fill(this.dataSetACS.ViewEnfermeiros);
            //this.tB_AREATableAdapter.Fill(this.dataSetACS.TB_AREA);
            tbArea.SelectedIndex = 0;
            tbEnfemreiro.SelectedValue = tbArea.SelectedValue;
            cbAcs.SelectedIndex = 0;
            cbAcs.SelectedText = null;
            this.WindowState = FormWindowState.Maximized;


        }

        private void btnConfirmarArea_Click(object sender, EventArgs e)
        {
            try
            {
                TB_AREATableAdapter bd = new TB_AREATableAdapter();
                int area = int.Parse(tbArea.Text);
                bd.AtualizaArea((int)tbEnfemreiro.SelectedValue, area);

                TB_MICROAREATableAdapter Microareabd = new TB_MICROAREATableAdapter();
                DataTable tabela = Microareabd.RetornaMicroareas(area);
                tbMicroarea.Items.Clear();
                foreach (DataRow linha in tabela.Rows)
                {
                    tbMicroarea.Items.Add(linha["NUM_MICROAREA"].ToString());
                }

                tbArea.Enabled = false;
                tbEnfemreiro.Enabled = false;
                btnConfirmarArea.Enabled = false;
                GbMicroarea.Visible = true;
                tbMicroarea.SelectedIndex = 0;
                tbMicroarea_TextChanged(sender, e);

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void tbArea_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tbArea.SelectedValue != null)                
                {
                    int idEnfermeiro = (int)tbArea.SelectedValue;
                    tbEnfemreiro.SelectedValue = idEnfermeiro;
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void tbMicroarea_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TB_MICROAREATableAdapter bd = new TB_MICROAREATableAdapter();
                int idAcs = (int)bd.RetornaIDACS(int.Parse(tbMicroarea.Text));
                cbAcs.SelectedValue = idAcs;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSalvarMicroarea_Click(object sender, EventArgs e)
        {
            try
            {
                TB_MICROAREATableAdapter tb = new TB_MICROAREATableAdapter();
                idMicroarea = int.Parse(tbMicroarea.Text);
                idArea = int.Parse(tbArea.Text);
                idAcs = (int)cbAcs.SelectedValue;
                tb.AtualizaMicroarea(idAcs, idMicroarea);
                tbMicroarea.Enabled = false;
                cbAcs.Enabled = false;
                btnSalvarMicroarea.Enabled = false;
                GbEndereco.Visible = true;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataRow linha in TabelaCEP.Rows)
                {
                    if (txLogradouro.Text.Equals(linha["ENDERECO"].ToString()))
                    {
                        txBairro.Text = linha["BAIRRO"].ToString();
                        CEP = int.Parse(linha["CEP"].ToString());
                        txCep.Text = CEP.ToString();
                        break;
                    }
                }
                this.ActiveControl = btnSalvarEndereco;
            }
        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            try
            {
                txLogradouro.Enabled = false;
                txBairro.Enabled = false;
                btnSalvarEndereco.Enabled = false;
                GbNumeros.Visible = true;
                CarregaDados();
                this.ActiveControl = txNumero;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbArea.Enabled = true;
            tbEnfemreiro.Enabled = true;
            tbMicroarea.Enabled = true;
            cbAcs.Enabled = true;
            txBairro.Enabled = true;
            txLogradouro.Enabled = true;
            GbEndereco.Visible = false;
            GbMicroarea.Visible = false;
            GbNumeros.Visible = false;
            btnConfirmarArea.Enabled = true;
            btnIncluirNumero.Enabled = true;
            btnSalvarMicroarea.Enabled = true;
            tbArea.SelectedIndex = 0;
            tbEnfemreiro.SelectedValue = tbArea.SelectedValue;
            cbAcs.SelectedText = null;
            btnSalvarEndereco.Enabled = true;
            
        }

        private void txNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Numero = int.Parse(txNumero.Text);
                    this.ActiveControl = txComplemento;
                }
                catch (Exception ERR)
                {

                    MessageBox.Show(ERR.Message);
                }
                
            }
        }

        private void txComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                complemento = txComplemento.Text;
                this.ActiveControl = btnIncluirNumero;
            }
        }

        private void btnIncluirNumero_Click(object sender, EventArgs e)
        {
            try
            {
                TB_NUMEROSMICROAREATableAdapter bdnumero = new TB_NUMEROSMICROAREATableAdapter();
                var consulta = bdnumero.VerificaExistente(Numero, complemento, CEP, idMicroarea);
                if (consulta == null)
                    bdnumero.Insert(idMicroarea, CEP, Numero, complemento.ToUpper());
                else
                    MessageBox.Show("Numero já existe");

                txNumero.Clear();
                txComplemento.Clear();
                this.ActiveControl = txNumero;
                CarregaDados();
            }
            catch (Exception err) 
            {

                MessageBox.Show(err.Message);
            }
        }

        private void CarregaDados()
        {
            try
            {
                TB_NUMEROSMICROAREATableAdapter num = new TB_NUMEROSMICROAREATableAdapter();
                dtgDados.DataSource = num.RetornaNumerosPorCEP(CEP,idMicroarea);
                dtgDados.Columns["NUM_MICROAREA"].Visible = false;
                dtgDados.Columns["CEP"].Visible = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void dtgDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TB_NUMEROSMICROAREATableAdapter tb = new TB_NUMEROSMICROAREATableAdapter();

                var _COMPLEMENTO = dtgDados.CurrentRow.Cells["COMPLEMENTO"].Value.ToString();
                var _NUMERO = (int)dtgDados.CurrentRow.Cells["NUMERO"].Value;
                var _result = tb.DeletaNumero(CEP, _NUMERO, _COMPLEMENTO, idMicroarea);
                MessageBox.Show(_result.ToString());
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void btnLimparEndereco_Click(object sender, EventArgs e)
        {
            btnSalvarEndereco.Enabled = true;
            txLogradouro.Enabled = true;
            txBairro.Enabled = true;
            dtgDados.DataSource = null;
            txBairro.Clear();
            txLogradouro.Clear();
            txCep.Clear();
            this.ActiveControl = txLogradouro;
        }

        private void txCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (DataRow linha in TabelaCEP.Rows)
                {
                    if (txCep.Text.Equals(linha["CEP"].ToString()))
                    {
                        txBairro.Text = linha["BAIRRO"].ToString();
                        txLogradouro.Text = linha["ENDERECO"].ToString();
                        CEP = int.Parse(txCep.Text);
                        break;
                    }
                }
                this.ActiveControl = btnSalvarEndereco;
            }
        }

        private void tbEnfemreiro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = tbEnfemreiro.SelectedValue;
            int codenf;
            if (x!= null)
                codenf = (int)tbEnfemreiro.SelectedValue;

        }
    }
}
