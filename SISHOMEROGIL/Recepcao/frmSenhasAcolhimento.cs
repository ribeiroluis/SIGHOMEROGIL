using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.Controles;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmSenhasAcolhimento : frmModelo
    {
        CEP _objCEP;


        public frmSenhasAcolhimento()
        {
            InitializeComponent();
            _objCEP = new CEP();
            
        }

        private void txLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    _objCEP.Logradouro = txLogradouro.Text;
                    if (_objCEP.PesquisaLogradouro())
                        lbBairro.Text = "Bairro: " + _objCEP.Bairro;
                    else
                    {
                        MessageBox.Show("Mais de um endereço localizado pesquise cep ");
                        btnPesquisar_Click(sender, e);
                    }
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void frmSenhasAcolhimento_Load(object sender, EventArgs e)
        {
            try
            {
                _objCEP.PreencheListaCEP();
                foreach (var item in _objCEP.ListaCEPCadastrados)
                {
                    txLogradouro.AutoCompleteCustomSource.Add(item.Logradouro);
                }



                //txLogradouro.AutoCompleteCustomSource.Add(

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void linkConsultaCEP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBuscaCEP busca = new frmBuscaCEP();
            busca.ShowDialog();
            _objCEP._CEP = int.Parse(busca.CEPSelecionado);            
            if (_objCEP.PesquisaCEP())
                lbBairro.Text = "Bairro: " + _objCEP.Bairro;

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmBuscaCEP busca = new frmBuscaCEP();
            busca.ShowDialog();
            _objCEP._CEP = int.Parse(busca.CEPSelecionado);
            if (_objCEP.PesquisaCEP())
            {
                lbBairro.Text = "Bairro: " + _objCEP.Bairro;
                txLogradouro.Text = _objCEP.Logradouro;
            }

        }
    }
}
