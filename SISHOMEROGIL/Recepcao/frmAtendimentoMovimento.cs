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
using System.Collections;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmAtendimentoMovimento : frmModelo
    {
        int idMedico = 0;
        int idMovimento;
        ArrayList Horarios;
        public frmAtendimentoMovimento()
        {
            InitializeComponent();
        }

        private void frmAtendimentoMovimento_Load(object sender, EventArgs e)
        {
            try
            {
                MEDICOSTableAdapter med = new MEDICOSTableAdapter();
                DataTable tbMedicos = med.RetornaMedicoDoDia(DateTime.Now.ToShortDateString());
                foreach (DataRow linha in tbMedicos.Rows)
                {
                    txNomeMedico.Items.Add(linha["NOME"].ToString());
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txNomeMedico_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                btnLimpar.Enabled = true;
                Controles.Enabled = true;
                txNomeMedico.Enabled = false;
                MEDICOSTableAdapter med = new MEDICOSTableAdapter();
                idMedico = (int)med.RetornaIDMedico(txNomeMedico.Text);
                MOVIMENTOTableAdapter mov = new MOVIMENTOTableAdapter();
                idMovimento = (int)mov.RetornaIDMovimento(idMedico, DateTime.Now.ToShortDateString());
                painelMovimento.Text = "Movimento: " + txNomeMedico.Text + " - " + DateTime.Now.ToShortDateString();
                this.ActiveControl = txProntuarioDesistencia;
                ExibeConsultas();
                timerDesistencias.Enabled = true;
                Horarios = new ArrayList();
                var x = DtgDadosConsultas[6, 0].Value;

                Horarios = new ArrayList();
                Horarios.Add(x);
                foreach (DataGridViewRow linha in DtgDadosConsultas.Rows)
                {
                    x = linha.Cells[6].Value;
                    if (!x.Equals(Horarios[Horarios.Count - 1]))
                        Horarios.Add(x);
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnLimpar.Enabled = false;
            Controles.Enabled = false;
            txNomeMedico.Enabled = true;
            painelMovimento.Text = "Movimento";
            Controles.SelectTab(0);
            DtgDadosConsultas.DataSource = null;
            //outros controles...
            timerDesistencias.Enabled = false;
            dtgDesistencias.DataSource = null;

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

                                DialogResult resultado = MessageBox.Show(txNome.Text, "Confirmar nome?", MessageBoxButtons.YesNo);
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
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void Controles_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaHoraConsulta();
            if (Controles.SelectedIndex == 1)
                this.ActiveControl = txProntuario;
            else
                this.ActiveControl = txProntuarioDesistencia;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                VAGASTableAdapter vagas = new VAGASTableAdapter();

                if (!txProntuario.Text.Equals("") || !txNome.Text.Equals(""))
                {
                    vagas.InsereMovimentoVaga(txProntuario.Text, txNome.Text.ToUpper(), int.Parse(txIdvaga.Text));
                }
                else
                    MessageBox.Show("Faltam dados!");

                btnInserir.Enabled = false;
                txNome.ReadOnly = true;
                txHora.Clear();
                txNome.Clear();
                txIdvaga.Clear();
                txProntuario.Clear();
                txProntuarioDesistencia.Clear();
                txNomeDesistencia.Clear();
                this.ActiveControl = txProntuarioDesistencia;
                CarregaHoraConsulta();
                Controles.SelectedIndex = 0;
                ExibeConsultas();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txProntuarioDesistencia_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                PacienteFirebird firebird = new PacienteFirebird();

                if (e.KeyCode == Keys.Enter)
                {
                    if (txProntuarioDesistencia.Text.Equals(""))
                    {
                        txNomeDesistencia.ReadOnly = false;
                        this.ActiveControl = txNomeDesistencia;
                    }
                    else
                    {

                        DataTable tabela = firebird.RetornaNomeUsuarioCadastrado(txProntuarioDesistencia.Text.PadLeft(7, '0'));
                        DataRow Linha;
                        string _prontuario = txProntuarioDesistencia.Text.PadLeft(7, '0');
                        txProntuarioDesistencia.Text = _prontuario;

                        for (int i = 0; i < tabela.Rows.Count; i++)
                        {
                            Linha = tabela.Rows[i];
                            string prontuario = Linha["CDUSUARIO"].ToString();

                            if (_prontuario.Equals(prontuario))
                            {
                                txNomeDesistencia.Text = Linha["DSUSUARIO"].ToString();

                                DialogResult resultado = MessageBox.Show(txNomeDesistencia.Text, "Confirmar nome?", MessageBoxButtons.YesNo);
                                if (resultado == System.Windows.Forms.DialogResult.No)
                                {
                                    txNomeDesistencia.Text = "";
                                    this.ActiveControl = txNomeDesistencia;
                                    break;
                                }
                                else
                                {
                                    NPrioridade.ReadOnly = false;
                                    this.ActiveControl = NPrioridade;
                                }
                            }
                        }

                        if (txNomeDesistencia.Text.Equals(""))
                        {
                            MessageBox.Show("Prontuario não localizado.\n Digite o nome!");
                            txNomeDesistencia.ReadOnly = false;
                            this.ActiveControl = txNomeDesistencia;
                        }
                    }
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void txNomeDesistencia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NPrioridade.ReadOnly = false;
                this.ActiveControl = NPrioridade;
                txNomeDesistencia.Text = txNomeDesistencia.Text.ToUpper();
            }
        }

        private void NPrioridade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInserirDesistencia.Enabled = true;
                this.ActiveControl = btnInserirDesistencia;                
            }
        }

        private void btnInserirDesistencia_Click(object sender, EventArgs e)
        {
            try
            {
                DESISTENCIASTableAdapter dese = new DESISTENCIASTableAdapter();
                if (!txNomeDesistencia.Text.Equals("") && !txProntuarioDesistencia.Text.Equals(""))
                    dese.InsereDesistencia(idMovimento, txProntuarioDesistencia.Text, txNomeDesistencia.Text, (int)NPrioridade.Value, DateTime.Now.ToLongTimeString());
                else
                    MessageBox.Show("Faltam dados, confira");

                txNomeDesistencia.Clear();
                txProntuarioDesistencia.Clear();
                txNomeDesistencia.ReadOnly = true;
                NPrioridade.ReadOnly = true;
                btnInserirDesistencia.Enabled = false;
                NPrioridade.Value = 1;
                this.ActiveControl = txProntuarioDesistencia;
                ExibeConsultas();
                    
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime hora = DateTime.Now;
            lbRelogio.Text = hora.ToLongTimeString();
        }

        private void ExibeConsultas()
        {
            try
            { 
                #region Movimento
            DtgDadosConsultas.DataSource = null;
            MOVIMENTOTableAdapter mov = new MOVIMENTOTableAdapter();
            DtgDadosConsultas.DataSource = mov.RetornaMovimentoDia(idMovimento);
            DtgDadosConsultas.Columns[0].Visible = false;
            DtgDadosConsultas.Columns[1].Visible = false;
            DtgDadosConsultas.Columns[2].Visible = false;
            DtgDadosConsultas.Columns[3].Visible = false;
            DtgDadosConsultas.Columns[4].Visible = false;
            DtgDadosConsultas.Columns[5].Visible = false;
            int indice = 1;
            foreach (DataGridViewRow linha in DtgDadosConsultas.Rows)
            {
                if (linha.IsNewRow) continue;
                linha.HeaderCell.Value = indice.ToString();
                indice++;
            }
            DtgDadosConsultas.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            #endregion

                #region Desistencias
            DESISTENCIASTableAdapter des = new DESISTENCIASTableAdapter();
            dtgDesistencias.DataSource = des.RetornaDesistencias(idMovimento);
            dtgDesistencias.Columns["IDDESISTENCIA"].Visible = false;
            dtgDesistencias.Columns["IDMOVIMENTO"].Visible = false;
            indice = 1;
            foreach (DataGridViewRow linha in dtgDesistencias.Rows)
            {
                if (linha.IsNewRow) continue;
                linha.HeaderCell.Value = indice.ToString();
                indice++;
            }
            dtgDesistencias.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            #endregion

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

           
        }

        private void DtgDadosConsultas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var horario = DtgDadosConsultas.CurrentRow.Cells[6].Value;
            var pront = DtgDadosConsultas.CurrentRow.Cells[7].Value;
            var nome = DtgDadosConsultas.CurrentRow.Cells[8].Value;
            var senha = DtgDadosConsultas.CurrentRow.Cells[9].Value.ToString();
            int idvaga = (int)DtgDadosConsultas.CurrentRow.Cells[4].Value;
            try
            {
                int somaSenha = 1;
                DialogResult result = MessageBox.Show("Entregar senha?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes && senha.Equals(""))
                {
                    VAGASTableAdapter vag = new VAGASTableAdapter();                    
                    foreach (DataGridViewRow  linha in DtgDadosConsultas.Rows)
                    {
                        var auxsenha = linha.Cells[9].Value.ToString();
                        if (!auxsenha.Equals(""))
                            somaSenha++;
                    }

                    int qtdVagas = (int)vag.ContaVagas(idMovimento);

                    if (somaSenha <= qtdVagas)
                    {
                        vag.InsereSenha(somaSenha, idvaga);
                        EmiteSenha(txNomeMedico.Text, somaSenha.ToString());
                    }
                    else
                        MessageBox.Show("Não há mais senhas para ser entrege");

                }
                else
                    MessageBox.Show("Senha já entregue.");
                ExibeConsultas();
            }
            catch (Exception err)
            {
                ExibeConsultas();
                MessageBox.Show(err.Message);
            }
        }

        private void timerDesistencias_Tick(object sender, EventArgs e)
        {
            timerDesistencias.Enabled = false;

            DateTime horaAtual = DateTime.Now;

            TimeSpan x = (TimeSpan)Horarios[0];
            if (horaAtual.Hour >= x.Hours)
            {
                foreach (var item in Horarios)
                {
                    TimeSpan hora = (TimeSpan)item;

                    if (horaAtual.Hour > hora.Hours) // && horaAtual.Minute > 20)
                    {
                        // o minuto precisa ser trabalhado
                        EntregaDesistencia(hora);
                    }
                    else if (horaAtual.Hour == hora.Hours && horaAtual.Minute > (hora.Minutes+20))
                    {
                        EntregaDesistencia(hora);
                    }
                }
            }
            timerDesistencias.Enabled = true;
        }

        private void EntregaDesistencia(TimeSpan _hora)
        {
            try
            {
                string hora = _hora.ToString();
                string horadesistencia, senha, prontuario, nome;

                foreach (DataGridViewRow linha in DtgDadosConsultas.Rows)
                {
                    horadesistencia = linha.Cells[6].Value.ToString();
                    senha = linha.Cells[9].Value.ToString();
                    prontuario = linha.Cells[7].Value.ToString();
                    nome = linha.Cells[8].Value.ToString();
                    int idvaga = (int)linha.Cells[4].Value;

                    if (horadesistencia.Equals(hora) && senha.Equals(""))
                    {
                        foreach (var item in dtgDesistencias.Rows)
                        {                            
                            string text = "Entregar senha para " + dtgDesistencias[3,0].Value.ToString();
                            DialogResult result = MessageBox.Show(text, "Atenção", MessageBoxButtons.YesNo);
                            
                            if (result == System.Windows.Forms.DialogResult.Yes)
                            {
                                VAGASTableAdapter vag = new VAGASTableAdapter();                                

                                FALTOSOSTableAdapter falta = new FALTOSOSTableAdapter();
                                falta.InsereFaltoso(idMovimento, hora, prontuario, nome, DateTime.Now.ToLongTimeString());
                                vag.RemoveVaga(dtgDesistencias[2,0].Value.ToString(), dtgDesistencias[3, 0].Value.ToString(), idvaga);

                                DESISTENCIASTableAdapter des = new DESISTENCIASTableAdapter();
                                int idDesistencia = (int)dtgDesistencias[0,0].Value;
                                des.ExcluiDesistencia(idDesistencia);                                

                                //entregar senha tambem
                                int somaSenha = 1 + (int)vag.ContaSenhas(idMovimento);
                                vag.InsereSenha(somaSenha, idvaga);
                                EmiteSenha(txNomeMedico.Text, somaSenha.ToString());
                                ExibeConsultas();                                
                                break;
                            }
                            else
                            {
                                dtgDesistencias.Rows.RemoveAt(0);
                                
                            }                                                        
                        }
                    }                    
                }                
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void EmiteSenha(string medico, string senha)
        {
            try
            {
                MEDICOSTableAdapter med = new MEDICOSTableAdapter();
                var nome = med.RetornaApelidoMedico(medico).ToString();            
                Imprimir imprime = new Imprimir();
                imprime.imprimeTexto(nome, senha);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

            
        }

        private void lkFaltosos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                frmVisualizaFaltosos falta = new frmVisualizaFaltosos(idMovimento);
                falta.ShowDialog();

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
            
        }

        private void dtgDesistencias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idDesistencia = (int)dtgDesistencias.CurrentRow.Cells[0].Value;
                DialogResult resultado = MessageBox.Show("Excluir desistencia?", "Atencao",MessageBoxButtons.YesNo);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    DESISTENCIASTableAdapter de = new DESISTENCIASTableAdapter();
                    de.ExcluiDesistencia(idDesistencia);
                    ExibeConsultas();
                }
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
