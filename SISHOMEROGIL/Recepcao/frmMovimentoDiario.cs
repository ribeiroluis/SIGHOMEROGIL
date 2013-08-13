using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.BancoDados.MovimentoDiarioTableAdapters;
using SISHOMEROGIL.Recepcao.Controles;


namespace SISHOMEROGIL.Recepcao
{
    public partial class frmMovimentoDiario : frmModelo
    {
        int idMovimento = 0;

        public frmMovimentoDiario()
        {
            InitializeComponent();
        }

        private void frmMovimentoDiario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movimentoDiario.MEDICOS' table. You can move, or remove it, as needed.
            this.mEDICOSTableAdapter.Fill(this.movimentoDiario.MEDICOS);
            txMedico.SelectedItem = null;
            txDia.Items.Clear();
            txDia.SelectedItem = null;
        }
        
        private void txMedico_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                txDia.Items.Clear();
                if (txMedico.SelectedItem != null)
                {
                    MOVIMENTOTableAdapter movimento = new MOVIMENTOTableAdapter();
                    DataTable tbDias = movimento.RetornaDiasMovimento((int)txMedico.SelectedValue);
                    DateTime mes = DateTime.Now;
                    DateTime dia = new DateTime();
                    foreach (DataRow linha in tbDias.Rows)
                    {
                        dia = (DateTime)linha["DATA"];
                        if (dia.Month == mes.Month || dia.Month == (mes.Month + 1))
                            txDia.Items.Add(dia.ToShortDateString());
                    }                    
                }
                txDia.ResetText();
                txDia.SelectedItem = null;
            }
            catch (Exception err) 
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txDia.SelectedItem != null && txMedico.SelectedItem != null)
            {
                btnConfirmar.Enabled = true;
                this.ActiveControl = btnConfirmar;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                PainelMovimento.Enabled = true;
                txMedico.Enabled = false;
                txDia.Enabled = false;
                btnConfirmar.Enabled = false;
                btnLimpar.Enabled = true;
                this.ActiveControl = txProntuario;
                MOVIMENTOTableAdapter mov = new MOVIMENTOTableAdapter();
                idMovimento = (int)mov.RetornaIDMovimento((int)txMedico.SelectedValue, txDia.SelectedItem.ToString());
                CarregaHoraConsulta();
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txMedico.Enabled = true;
            PainelMovimento.Enabled = false;
            txMedico.SelectedItem = null;
            txDia.Enabled = true;
            txDia.Items.Clear();
            txDia.ResetText();
            btnLimpar.Enabled = false;
            DtgDadosConsultas.DataSource = null;
        }

        private void txProntuario_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                PacienteFirebird firebird = new PacienteFirebird();

                if (e.KeyCode == Keys.Enter)
                {
                    if (txProntuario.Text.Equals(""))
                    {
                        txNome.ReadOnly = false;
                        this.ActiveControl = txNome;
                    }
                    else
                    {
                        
                        DataTable tabela = firebird.RetornaNomeUsuarioCadastrado(txProntuario.Text.PadLeft(7, '0'));
                        DataRow Linha;
                        string _prontuario = txProntuario.Text.PadLeft(7, '0');
                        txProntuario.Text = _prontuario;

                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            Linha = tabela.Rows[i];
                            string prontuario = Linha["CDUSUARIO"].ToString();

                            if (_prontuario.Equals(prontuario))
                            {
                                txNome.Text = Linha["DSUSUARIO"].ToString();

                                DialogResult resultado = MessageBox.Show(txNome.Text,"Confirmar nome?",MessageBoxButtons.YesNo);
                                if (resultado == System.Windows.Forms.DialogResult.No)
                                {
                                    txNome.Text = "";
                                    this.ActiveControl = txNome;
                                    break;
                                }
                                else
                                {
                                    btnInserir.Enabled = true;
                                    this.ActiveControl = btnInserir;
                                }
                            }
                        }

                        if (txNome.Text.Equals(""))
                        {
                            MessageBox.Show("Prontuario não localizado.\n Digite o nome!");
                            txNome.ReadOnly = false;
                            this.ActiveControl = txNome;
                        }
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                VAGASTableAdapter vagas = new VAGASTableAdapter();

                if (!txProntuario.Text.Equals("") || !txNome.Text.Equals(""))
                {
                    vagas.InsereMovimentoVaga(txProntuario.Text, txNome.Text, int.Parse(txIdvaga.Text));
                }
                else
                    MessageBox.Show("Faltam dados!");
                
                btnInserir.Enabled = false;
                txNome.ReadOnly = true;
                txHora.Clear();
                txNome.Clear();
                txIdvaga.Clear();
                txProntuario.Clear();
                this.ActiveControl = txProntuario;
                CarregaHoraConsulta();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInserir.Enabled = true;
                this.ActiveControl = btnInserir;
                txNome.Text = txNome.Text.ToUpper();
            }
        }

        private void CarregaHoraConsulta()
        {
            try
            {
                VAGASTableAdapter vagas = new VAGASTableAdapter();
                DataTable tbHora = vagas.RetornaHorarios(idMovimento);
                foreach (DataRow linh in tbHora.Rows)
                {
                    var nome = linh["NOME"].ToString();
                    var hora = linh["HORARIO"].ToString();
                    var idvaga = linh["IDVAGA"].ToString();
                    var pront = linh["PRONTUARIO"].ToString();
                    if (nome.Equals(""))
                    {
                        txIdvaga.Text = idvaga;
                        txHora.Text = hora;
                        break;
                    }
                }

                if (txIdvaga.Text.Equals(""))
                {
                    MessageBox.Show("Não há mais vagas para a data e o médico selecionado!");
                    PainelMovimento.Enabled = false;
                }

                ViewMovimentoDiaTableAdapter view = new ViewMovimentoDiaTableAdapter();
                DtgDadosConsultas.DataSource= view.RetornaMovimentoDia(idMovimento);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void DtgDadosConsultas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Excluir registro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    /var nome = DtgDadosConsultas.CurrentRow.Cells[4].ToString();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
