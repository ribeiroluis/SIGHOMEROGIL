using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmImrimirMovimento : frmModelo
    {
        public frmImrimirMovimento()
        {
            InitializeComponent();
        }

        private void frmImrimirMovimento_Load(object sender, EventArgs e)
        {
            MovimentoDia11.Refresh();
        }
    }
}
