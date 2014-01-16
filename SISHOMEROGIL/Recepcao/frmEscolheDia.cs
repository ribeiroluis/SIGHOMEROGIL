using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SISHOMEROGIL.BancoDados.MovimentoDiarioTableAdapters;
using System.IO;
using System.Diagnostics;

namespace SISHOMEROGIL.Recepcao
{
    public partial class frmEscolheDia : frmModelo
    {
        viewMovimentoDiaTableAdapter Movimento;
        public frmEscolheDia()
        {
            InitializeComponent();
            Movimento = new viewMovimentoDiaTableAdapter();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void frmEscolheDia_Load(object sender, EventArgs e)
        {
            try
            {

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
                GeraImpressao();
                this.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

            
        }

        private void GeraImpressao()
        {
            try
            {
                if (!Directory.Exists(@"c:\temp"))
                    Directory.CreateDirectory(@"c:\temp");
                if (!File.Exists(@"c:\temp\index.html"))
                {
                    var x = File.Create(@"c:\temp\index.html");
                    x.Close();
                }

                if (File.Exists(@"c:\temp\index.html"))
                {

                    string data = cbData.Value.ToShortDateString();
                    DataTable tbMovimento = Movimento.RetornaMivimentosPorData(data);
                    string html = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">" +
                    "<html><head><style media=\"screen\" type=\"text/css\">@media print {p.test {font-family: 'Times New Roman','Comic Sans MS',Arial;font-size: 12pt;}"+
                    "}</style><title>Movimenento Dia: " + cbData.Value.ToLongDateString();
                    html += "</title></head><body><h2>Movimento dia: " + cbData.Value.ToLongDateString();
                    html += "</h2><table border=\"1\"><tr><td style=\"background-color: #FFFFCC\">Medico</td> " +
                    "<td style=\"background-color: #FFFFCC\">Horario</td><td style=\"background-color: #FFFFCC\">" +
                    "Prontuario</td><td style=\"background-color: #FFFFCC\">Paciente</td></tr>";
                    foreach (DataRow  linha in tbMovimento.Rows)
                    {
                        var pront = linha["PRONTUARIO"].ToString();
                        if (!pront.Equals(""))
                        {
                            html += "<tr><td>" + linha["MEDICO"] + "</td>";
                            html += "<td>" + linha["HORARIO"] + "</td>";
                            html += "<td>" + linha["PRONTUARIO"] + "</td>";
                            html += "<td>" + linha["PACIENTE"] + "</td><tr>";
                        }
                    }
                    html += "</table></body></html>";
                    File.WriteAllText(@"c:\temp\index.html", html);
                    Process.Start("IExplore.exe", @"c:\temp\index.html");
                }
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

    }
}
