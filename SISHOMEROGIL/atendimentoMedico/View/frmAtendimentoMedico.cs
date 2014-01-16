using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SISHOMEROGIL.atendimentoMedico.View
{
    public partial class frmAtendimentoMedico : Form
    {
        public frmAtendimentoMedico()
        {
            InitializeComponent();
        }

        private void frmAtendimentoMedico_Load(object sender, EventArgs e)
        {
            Paciente P = new Paciente();
            if (!File.Exists(@"Paciente.txt"))
            {
                AtualizaPacientes();
            }
        }

        private void AtualizaPacientes()
        {
            if (File.Exists(@"Paciente.txt"))
            {
                DialogResult resultado = MessageBox.Show("Substituir dados antigos?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Title = "Abra o arquivo Paciente.txt salvo";
                    open.Filter = "TXT|Paciente.txt";
                    open.ShowDialog();
                    if (open.FileName != "")
                    {
                        File.Copy(open.FileName, @"Paciente.txt", true);
                    }
                }

            } 
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizaPacientes();
        }


    }
}
