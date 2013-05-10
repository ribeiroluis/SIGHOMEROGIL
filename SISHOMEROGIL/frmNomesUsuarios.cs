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
    public partial class frmNomesUsuarios : frmModelo
    {
        public string NomeUsuario;
        public string TipoBD = "";
        public string Prontuario;

        USUARIOTableAdapter user = new USUARIOTableAdapter();
        AcessoFireBird fire = new AcessoFireBird();
        DataTable _tabelaSQL;
        DataTable _tabelaFireBird;


        public frmNomesUsuarios(string nome)
        {
            InitializeComponent();
            NomeUsuario = nome;
        }

        private void frmNomesUsuarios_Load(object sender, EventArgs e)
        {
            
            string pesquisa = "%" + NomeUsuario + "%";
            _tabelaSQL = user.RetornaDataTableNomesPorNome(pesquisa);
            _tabelaFireBird = fire.RetornaTabelaNomeUsuarioPorNome(pesquisa);

            dtgDadosNomes.Columns.Add("PRONTUARIO", "PRONTUÁRIO");
            dtgDadosNomes.Columns.Add("NOME", "NOME USUARIO");
            dtgDadosNomes.Columns.Add("MAE", "NOME DA MÃE");
            
            int tamanho = _tabelaFireBird.Rows.Count + _tabelaSQL.Rows.Count;

            if (tamanho > 0)
            {

                if (_tabelaSQL.Rows.Count > 0)
                {
                    

                    for (int i = 0; i < _tabelaSQL.Rows.Count; i++)
                    {
                        dtgDadosNomes.Rows.Add(1);
                        dtgDadosNomes["NOME", i].Value = _tabelaSQL.Rows[i]["NOME"].ToString();
                        dtgDadosNomes["PRONTUARIO", i].Value = _tabelaSQL.Rows[i]["PRONTUARIO"].ToString();
                        dtgDadosNomes["MAE", i].Value = _tabelaSQL.Rows[i]["NOMEMAE"].ToString();
                    }
                }
                
                
                int indice = _tabelaSQL.Rows.Count;

                for (int i = 0; i < _tabelaFireBird.Rows.Count; i++)
                {                    
                    int soma = 0;
                    string _nomeFirebird = _tabelaFireBird.Rows[i]["DSUSUARIO"].ToString();
                    for (int k = 0; k < _tabelaSQL.Rows.Count; k++)
                    {
                        string _nomeSQL = _tabelaSQL.Rows[k]["NOME"].ToString();                        
                        if (_nomeSQL.Equals(_nomeFirebird))
                        {
                            soma++;                                                     
                        }
                    }
                    if (soma == 0)
                    {                       
                        dtgDadosNomes.Rows.Add(1);                        
                        dtgDadosNomes["NOME", indice].Value = _tabelaFireBird.Rows[i]["DSUSUARIO"].ToString();
                        dtgDadosNomes["PRONTUARIO", indice].Value = _tabelaFireBird.Rows[i]["CDUSUARIO"].ToString();
                        dtgDadosNomes["MAE", indice].Value = _tabelaFireBird.Rows[i]["DSMAE"].ToString();
                        indice++;
                    }
                }

                dtgDadosNomes.Sort(dtgDadosNomes.Columns["NOME"], ListSortDirection.Ascending);                
            }
            else
            {
                MessageBox.Show("Nome não encontrado, cadastre novo");
                NomeUsuario = "";
                this.Close();
            }
            
        }

        private void dtgDadosNomes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            DialogResult resultado = MessageBox.Show("Selecionar este nome?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                NomeUsuario = dtgDadosNomes.CurrentRow.Cells["NOME"].Value.ToString();
                Prontuario = dtgDadosNomes.CurrentRow.Cells["PRONTUARIO"].Value.ToString();

                for (int i = 0; i < _tabelaSQL.Rows.Count; i++)
                {
                    string nome = _tabelaSQL.Rows[i]["NOME"].ToString();
                    if (nome.Equals(NomeUsuario))
                    {
                        TipoBD = "SQL";
                        this.Close();
                        break;
                    }
                }

                if (!TipoBD.Equals("SQL"))
                {
                    for (int i = 0; i < _tabelaFireBird.Rows.Count; i++)
                    {
                        string nome = _tabelaFireBird.Rows[i]["DSUSUARIO"].ToString();
                        if (nome.Equals(NomeUsuario))
                        {
                            TipoBD = "FIREBIRD";
                            this.Close();
                        }
                    }
                }
                else
                    this.Close();
                
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NomeUsuario = "";
            this.Close();
        }
    }
}
