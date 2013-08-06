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
    public partial class frmMotivoBaixa : frmModelo
    {
        public string Texto = "";
        public frmMotivoBaixa()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (TexMotivoBaixa.TextLength < 20)
                MessageBox.Show("Especifique melhor a baixa");
            else
            {
                Texto = TexMotivoBaixa.Text.ToUpper();
                this.Close();
            }
        }
    }
}
