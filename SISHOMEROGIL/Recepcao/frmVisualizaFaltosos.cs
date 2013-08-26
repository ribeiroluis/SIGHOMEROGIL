using System;
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
    public partial class frmVisualizaFaltosos : frmModelo
    {
        int idmovimento;
        public frmVisualizaFaltosos(int id)
        {
            InitializeComponent();
            idmovimento = id;
        }

        private void frmVisualizaFaltosos_Load(object sender, EventArgs e)
        {
            FALTOSOSTableAdapter fal = new FALTOSOSTableAdapter();
            dataGridView1.DataSource = fal.RetornaFaltosos(idmovimento);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }
    }
}
