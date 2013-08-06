using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISHOMEROGIL
{
    public partial class frmTelaSplash : frmModelo
    {
        //AcessoDados acessar;
        DataTable TabelaUsuariosFireBird;


        public frmTelaSplash()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                if (ProgressBar.Value < 100)
                    ProgressBar.Value += 5;

                if (ProgressBar.Value == 20)
                {
                    lbStatus.Text = "Acessando o banco de dados - FireBird";
                    if (!Acessodados())
                    {
                        timer1.Enabled = false;
                        this.Close();
                    }
                }
                    

                if (ProgressBar.Value > 50)
                    lbStatus.Text = "Aguarde mais um pouco...";

                if (ProgressBar.Value == 100)
                {
                    timer1.Enabled = false;
                    this.Visible = false;
                    frmLogin log = new frmLogin(TabelaUsuariosFireBird);
                    log.ShowDialog();
                    this.Close();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }

        }

        private bool Acessodados()
        {
            try
            {
                lbStatus.Text = "Acessando o banco de dados - FireBird";
                AcessoFireBird acesso = new AcessoFireBird();
                TabelaUsuariosFireBird = acesso.RetornaTabelaUsuariosCadastrados();
                lbStatus.Text = "Acessando o banco de dados - SQL Server";
                //MessageBox.Show(acessar.Funcionarios_RetornaNomePorID(1));
                return true;
            }
            catch (Exception err)
            {
                timer1.Enabled = false;
                MessageBox.Show(err.Message + "Impossivel conectar");
                return false;
            }
        }
    }
}
