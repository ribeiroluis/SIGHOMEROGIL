using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.Administrador;


namespace SISHOMEROGIL
{
    public partial class frmMenuPrincipal : frmModelo
    {
        int Setor;
        int Acesso;
        int IDFuncionario;
        string NomeFuncionario = "";
        DateTime hora = new DateTime();
        AcessoDados Objacessar = new AcessoDados();
        DataTable TabelaUsuarioFirebird;

        public frmMenuPrincipal(int setor, int acesso, int idfuncionario, DataTable usuarioFirebird)
        {
            InitializeComponent();
            Setor = setor;
            Acesso = acesso;
            IDFuncionario = idfuncionario;
            TabelaUsuarioFirebird = usuarioFirebird;
            LiberaAcesso();

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                NomeFuncionario = Objacessar.Funcionarios_RetornaNomePorID(IDFuncionario);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora = DateTime.Now;
            lbToolStrip.Text = "Olá " + NomeFuncionario +"     Dia: "+hora.ToLongDateString()+"     Hora: "+ hora.ToShortTimeString();
        }

        private void LiberaAcesso()
        {
            string _setor = Objacessar.Funcionarios_RetornaSetorPorIDFuncionario(IDFuncionario);
            switch (_setor)
            {
                case "FARMACIA": 
                    LiberaFarmarcia(); 
                    break;

                case "RECEPCAO": ;
                    break;

                case "ASSISTENCIA": ; 
                    break;

                case "CONSULTAS ESPECIALIZADAS": ;
                    break;

                case "GERENCIA": LiberaGerencia();
                    break;
                case "ADMIN": LiberaGerencia();
                    break;
            }
        }

        private void LiberaFarmarcia()
        {
            SubMenuFarmacia.Enabled = true;
            if (Acesso == 1)
            {
                gerenciarMedicamentoToolStripMenuItem.Enabled = true;
            }            
        }

        private void LiberaGerencia()
        {
            SubMenuAcolhimento.Enabled = true;            
            SubMenuFarmacia.Enabled = true;
            SubMenuGerencia.Enabled = true;
            SubMenuConsultaEspecializada.Enabled = true;
            SubMenuRecepcao.Enabled = true;
            gerenciarMedicamentoToolStripMenuItem.Enabled = true;
            
            if (Setor == 5)
                adminToolStripMenuItem.Visible = true;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alterarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmLogin login = new frmLogin(TabelaUsuarioFirebird);
            login.ShowDialog();
            this.Close();
        }

        private void dispensarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDispensacao dispensar = new frmDispensacao(IDFuncionario);
            dispensar.ShowDialog();
        }

        private void GerenciarEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoqueFarmacia estoque = new frmEstoqueFarmacia(IDFuncionario);
            estoque.ShowDialog();
        }

        private void SubMenuRecepcao_Click(object sender, EventArgs e)
        {
           
        }

        private void SubMenuAcolhimento_Click(object sender, EventArgs e)
        {            
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gerenciarUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciaUsuarios frm = new frmGerenciaUsuarios();
            frm.ShowDialog();
        }
    }
}
