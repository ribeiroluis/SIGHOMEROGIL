using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.Especialidades.Controles;

namespace SISHOMEROGIL.Especialidades.Interface
{
    public partial class frmAutoCusto : frmModelo
    {
        Pessoa Usuario;
        public frmAutoCusto()
        {
            InitializeComponent();
            this.ActiveControl = txCartaoSus;
        }        

        private void frmAutoCusto_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F2: btnLimpar_Click(sender, e);
                    break;
                case Keys.Escape: btnSair_Click(sender,e);
                    break;
                case Keys.F10: btnConfirmar_Click(sender, e);
                    break;
                case Keys.F12: btnEditar_Click(sender, e);
                    break;
                default:
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txCartaoSus_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Usuario = new Pessoa();
                    if (Usuario.ConsultaCNS(txCartaoSus.Text))
                    {
                        MessageBox.Show("Válido");
                        txCPF.Enabled = true;
                        this.ActiveControl = txCPF;
                    }
                    else
                        MessageBox.Show("Cartão SUS inválido, verifique");
                }
            }
            catch (Exception err )
            {

                MessageBox.Show(err.Message);
            }
        }      
        
        
    }
}
