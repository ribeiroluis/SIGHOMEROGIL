﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.BancoDados.MovimentoDiarioTableAdapters;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmEscolheDia : frmModelo
    {
        public frmEscolheDia()
        {
            InitializeComponent();
        }

        private void frmEscolheDia_Load(object sender, EventArgs e)
        {
            try
            {
                MOVIMENTOTableAdapter mov = new MOVIMENTOTableAdapter();
                DataTable tb = mov.RetornaDatas();
                foreach (DataRow item in tb.Rows)
                {
                    DateTime data = (DateTime)item["DATA"];

                    cbData.Items.Add(data.ToShortDateString());
                }
            

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            try
            {
                viewMovimentoTableAdapter view = new viewMovimentoTableAdapter();
                DataTable tabela = view.RetornaMovimento(cbData.Text);

                MOVIMENTO_TEMPTableAdapter temp = new MOVIMENTO_TEMPTableAdapter();
                temp.DeletaTodos();

                foreach (DataRow linha in tabela.Rows)
                {
                    string medico = linha[0].ToString();
                    string data = linha[1].ToString();
                    string horario = linha[2].ToString();
                    string prontuario = linha[3].ToString();
                    string nome = linha[4].ToString();
                    temp.Insere(medico, data, horario, prontuario, nome);
                }

                frmImrimirMovimento imp = new frmImrimirMovimento();
                imp.ShowDialog();
                this.Close();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

            
        }

    }
}