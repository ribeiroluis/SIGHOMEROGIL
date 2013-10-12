using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.BancoDados.MovimentoDiarioTableAdapters;

namespace SISHOMEROGIL.Acolhimento
{
    public partial class frmInserirVagas : frmModelo
    {
        string diaInicio, diaFim, Mes, Ano, dataInicio, dataFim;

        public frmInserirVagas()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                MEDICOSTableAdapter medicos = new MEDICOSTableAdapter();
                DataTable tbMedicos = medicos.GetData();
                foreach (DataRow linha in tbMedicos.Rows)
                {
                    progressBar1.Value = 0;
                    GeraData();
                    string nome = linha["NOME"].ToString();
                    int id = (int)linha["IDMEDICO"];
                    InsereMovimento(nome, id);
                }
                progressBar1.Value = 100;
                MessageBox.Show("Vagas geradas com sucesso");
            }                            
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        /// <summary>
        /// Pesquisa se já foi cadastrado agenda
        /// </summary>
        /// <returns>Verdadeiro: se já existe vagas para o mes, Falso: se não há vagas para o mês.</returns>
        private void GeraData()
        {
            try
            {
                DateTime agora = DateTime.Now;
                Ano = agora.Year.ToString();
                diaInicio = "01/";
                diaFim = "";
                Mes = "";

                switch (txMeses.SelectedItem.ToString())
                {
                    case "JANEIRO":{Mes = "01/"; diaFim = "31/";}break;
                    case "FEVEREIRO": { Mes = "02/"; diaFim = "28/"; } break;
                    case "MARCO": { Mes = "03/"; diaFim = "31/"; } break;
                    case "ABRIL": { Mes = "04/"; diaFim = "30/"; } break;
                    case "MAIO": { Mes = "05/"; diaFim = "31/"; } break;
                    case "JUNHO": { Mes = "06/"; diaFim = "30/"; } break;
                    case "JULHO": { Mes = "07/"; diaFim = "31/"; } break;
                    case "AGOSTO": { Mes = "08/"; diaFim = "31/"; } break;
                    case "SETEMBRO": { Mes = "09/"; diaFim = "30/"; } break;
                    case "OUTUBRO": { Mes = "10/"; diaFim = "31/"; } break;
                    case "NOVEMBRO": { Mes = "11/"; diaFim = "30/"; } break;
                    case "DEZEMBRO": { Mes = "12/"; diaFim = "31/"; } break;
                    default:
                        break;
                }

                dataInicio = diaInicio + Mes + Ano;
                dataFim = diaFim + Mes + Ano;                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void InsereMovimento(string _nome, int _idMedico)
        {
            try
            {
                DateTime dtInicio = DateTime.Parse(dataInicio);
                DateTime dtFim = DateTime.Parse(dataFim);
                TimeSpan dias = dtFim - dtInicio;
                MOVIMENTOTableAdapter movimento;
                VAGASTableAdapter vagas;
                int dia = dtInicio.Day;
                int mes = dtInicio.Month;
                int ano = dtInicio.Year;
                for (int i = 0; i <= dias.Days; i++)
                {
                    progressBar1.Value += 3;
                    string _data = dia + "/" + mes + "/" + ano;
                    dtInicio = DateTime.Parse(_data);
                    movimento = new MOVIMENTOTableAdapter();
                    int qtdMovimento = (int)movimento.ContaMovimento(dtInicio.ToShortDateString(),_idMedico);
                    if (qtdMovimento == 0)
                    {
                        movimento.Insert(_idMedico, dtInicio, null);
                        int idMovimento = (int)movimento.RetornaUltimoID();
                        //int idMovimento = 1;
                        InsereVagas(idMovimento, dtInicio, _nome);
                        vagas = new VAGASTableAdapter();
                        int qtdVagas = (int)vagas.ContaVagas(idMovimento);
                        if (qtdVagas < 1)
                            movimento.DeletaMovimentoNulo(idMovimento);
                        else
                            movimento.AtualizaNumVagas(qtdVagas, idMovimento);
                    }

                    dia++;
                }
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void InsereVagas(int idMovimento, DateTime data, string medico)
        {
            VAGASTableAdapter vagas = new VAGASTableAdapter();
            TimeSpan hora = new TimeSpan();
            try
            {
                switch (medico)
                {
                    #region Jackelyne
                    case "JACKELYNE APARECIDA RESENDE SANTANA":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                    #region Segunda
                                case "Monday":
                                    {
                                        for (int i = 1; i <= 30; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("13:00");
                                            else if (i > 7 && i <16)
                                                hora = TimeSpan.Parse("14:00");
                                            else if (i > 15 && i < 24)
                                                hora = TimeSpan.Parse("15:00");
                                            else 
                                                hora = TimeSpan.Parse("16:00");

                                            vagas.Insert(idMovimento, hora, null, null,null);
                                        }
 
                                    }break;
                                #endregion 
                                
                                    #region Terca
                                case "Tuesday":
                                    {
                                        for (int i = 1; i <= 30; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 7 && i < 16)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 15 && i < 24)
                                                hora = TimeSpan.Parse("09:00");
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }

                                    } break;
                                #endregion 
                                    
                                    #region Sexta
                                case "Friday":
                                    {
                                        for (int i = 1; i <= 30; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 7 && i < 16)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 15 && i < 24)
                                                hora = TimeSpan.Parse("09:00");
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }

                                    } break;
                                #endregion 
                                
                                default:
                                    break;
                            }
                        }break;
                    #endregion

                    #region Jose Carlos
                    case "JOSE CARLOS DA SILVA DUTRA":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                    #region Segunda
                                case "Monday":
                                    {
                                        for (int i = 1; i <= 32; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 7 && i < 15)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 14 && i < 22)
                                                hora = TimeSpan.Parse("09:00");
                                            else if (i > 21 && i < 28)
                                                hora = TimeSpan.Parse("10:00");
                                            else
                                                hora = TimeSpan.Parse("10:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }} break;
                                #endregion
                                    
                                    #region Quarta
                                case "Wednesday":
                                    {
                                        for (int i = 1; i <= 32; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 7 && i < 15)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 14 && i < 22)
                                                hora = TimeSpan.Parse("09:00");
                                            else if (i > 21 && i < 28)
                                                hora = TimeSpan.Parse("10:00");
                                            else
                                                hora = TimeSpan.Parse("10:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                                    
                                    #region Quinta
                                case "Thursday":
                                    {
                                        for (int i = 1; i <= 32; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 7 && i < 15)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 14 && i < 22)
                                                hora = TimeSpan.Parse("09:00");
                                            else if (i > 21 && i < 28)
                                                hora = TimeSpan.Parse("10:00");
                                            else
                                                hora = TimeSpan.Parse("10:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                                    
                                    #region Sexta
                                case "Friday":
                                    {
                                        for (int i = 1; i <= 32; i++)
                                        {
                                            if (i < 8)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 7 && i < 15)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 14 && i < 22)
                                                hora = TimeSpan.Parse("09:00");
                                            else if (i > 21 && i < 28)
                                                hora = TimeSpan.Parse("10:00");
                                            else
                                                hora = TimeSpan.Parse("10:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                                
                                default:
                                    break;
                            }
                        } break;
                    #endregion

                    #region Alexssandro
                    case "ALEXSSANDRO DE SOUZA":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                #region Terça
                                case "Tuesday":
                                    {
                                        for (int i = 1; i <= 12; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("07:30");
                                            else if (i > 6 && i < 13)
                                                hora = TimeSpan.Parse("08:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                                    
                                #region Quarta
                                case "Wednesday":
                                    {
                                        for (int i = 1; i <= 26; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("14:00");
                                            else if (i > 6 && i < 13)
                                                hora = TimeSpan.Parse("15:00");
                                            else if (i > 12 && i < 21)
                                                hora = TimeSpan.Parse("16:00");                                            
                                            else
                                                hora = TimeSpan.Parse("17:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                #region Quinta
                                case "Thursday":
                                    {
                                        for (int i = 1; i <= 26; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 6 && i < 13)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 12 && i < 21)
                                                hora = TimeSpan.Parse("09:00");
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion  

                                #region Sexta
                                case "Friday":
                                    {
                                        for (int i = 1; i <= 26; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("14:00");
                                            else if (i > 6 && i < 13)
                                                hora = TimeSpan.Parse("15:00");
                                            else if (i > 12 && i < 21)
                                                hora = TimeSpan.Parse("16:00");
                                            else
                                                hora = TimeSpan.Parse("17:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion  

                            }}break;
                    #endregion

                    #region Silvana
                    case "SILVANA MARIA FONSECA":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                #region Segunda
                                case "Monday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("14:00");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("15:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("15:30");                                            
                                            else
                                                hora = TimeSpan.Parse("16:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                #region Terça
                                case "Tuesday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("10:00");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("11:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("11:30");
                                            else
                                                hora = TimeSpan.Parse("12:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("12:30");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("13:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("13:30");
                                            else
                                                hora = TimeSpan.Parse("14:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                #region Quinta
                                case "Thursday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("14:30");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("15:30");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("16:00");
                                            else
                                                hora = TimeSpan.Parse("16:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                                default:
                                    break;
                            }
                        } break;

                    #endregion

                    #region Rosangela
                        case "ROSANGELA CONCEICAO CAMPOS MEDEIROS":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                    #region Segunda
                                case "Monday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("09:00");                                            
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                    #region Terça
                                case "Tuesday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("09:00");                                            
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                    #region Quarta
                                case "Wednesday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("09:00");                                            
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                              
                                    #region Quinta
                                case "Thursday":
                                    {
                                        for (int i = 1; i <= 16; i++)
                                        {
                                            if (i < 4)
                                                hora = TimeSpan.Parse("07:00");
                                            else if (i > 3 && i < 9)
                                                hora = TimeSpan.Parse("08:00");
                                            else if (i > 8 && i < 13)
                                                hora = TimeSpan.Parse("09:00");                                            
                                            else
                                                hora = TimeSpan.Parse("10:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                 default:
                                    break;
                            }
                        } break;
                    #endregion

                    #region Jose Helvecio
                        case "JOSE HELVECIO KALIL DE SOUZA":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                    #region Segunda
                                case "Monday":
                                    {
                                        for (int i = 1; i <= 20; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("07:30");
                                            else if (i > 6 && i < 15)
                                                hora = TimeSpan.Parse("08:30");                                            
                                            else
                                                hora = TimeSpan.Parse("09:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                    #region Terça
                                case "Tuesday":
                                    {
                                        for (int i = 1; i <= 20; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("07:30");
                                            else if (i > 6 && i < 15)
                                                hora = TimeSpan.Parse("08:30");                                            
                                            else
                                                hora = TimeSpan.Parse("09:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                    #region Quarta
                                case "Wednesday":
                                    {
                                        for (int i = 1; i <= 20; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("07:30");
                                            else if (i > 6 && i < 15)
                                                hora = TimeSpan.Parse("08:30");
                                            else
                                                hora = TimeSpan.Parse("09:00");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                                
                                default:
                                    break;
                            }
                        } break;
                    #endregion
 
                    #region Artur
                    case "ARTUR BRAGA MARTINS":
                        {
                            switch (data.DayOfWeek.ToString())
                            {
                                    #region Segunda
                                case "Monday":
                                    {
                                        for (int i = 1; i <= 15; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("10:00");
                                            else if (i > 6 && i < 12)
                                                hora = TimeSpan.Parse("11:00");                                            
                                            else
                                                hora = TimeSpan.Parse("11:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                    #region Terça
                                case "Tuesday":
                                    {
                                        for (int i = 1; i <= 15; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("13:00");
                                            else if (i > 6 && i < 12)
                                                hora = TimeSpan.Parse("14:00");                                            
                                            else
                                                hora = TimeSpan.Parse("14:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                    #region Quarta
                                case "Wednesday":
                                    {
                                        for (int i = 1; i <= 15; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("10:00");
                                            else if (i > 6 && i < 12)
                                                hora = TimeSpan.Parse("11:00");                                            
                                            else
                                                hora = TimeSpan.Parse("11:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion
                              
                                    #region Quinta
                                case "Thursday":
                                    {
                                        for (int i = 1; i <= 15; i++)
                                        {
                                            if (i < 7)
                                                hora = TimeSpan.Parse("10:00");
                                            else if (i > 6 && i < 12)
                                                hora = TimeSpan.Parse("11:00");                                            
                                            else
                                                hora = TimeSpan.Parse("11:30");

                                            vagas.Insert(idMovimento, hora, null, null, null);
                                        }
                                    } break;
                                #endregion

                                 default:
                                    break;
                            }
                        } break;    
                    #endregion


                    default:
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void frmInserirVagas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'movimentoDiario.MEDICOS' table. You can move, or remove it, as needed.
            this.mEDICOSTableAdapter.Fill(this.movimentoDiario.MEDICOS);
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
