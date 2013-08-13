using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace SISHOMEROGIL.Recepcao.Controles
{
    class PacienteFirebird
    {
        string Datasource = "DataSource=10.5.124.102; ";
        //string Datasource = "DataSource=localhost; ";
        string DataBase = @"Database=C:\Sistema de Registro da Producao Ambulatorial\FBCADASTRO_AGENDA.fdb; ";
        string user = "user=SYSDBA; ";
        string password = "password=masterkey";
        string conexao;
        
        public PacienteFirebird()
        {
            FbConnection connex = new FbConnection(conexao);
            try
            {
                conexao = Datasource + DataBase + user + password;
                connex = new FbConnection(conexao);
                connex.Open();
            }
            catch (Exception err)
            {
                connex.Close();
                System.Windows.Forms.MessageBox.Show(err.Message);

            }
        }
        public DataTable RetornaNomeUsuarioCadastrado(string prontuario)
        {
            FbConnection conex = new FbConnection(conexao);

            string query = "SELECT * FROM TBUSUARIO WHERE CDUSUARIO = '" + prontuario + "'";
            FbCommand comando = new FbCommand(query, conex);
            try
            {
                conex.Open();
                FbDataAdapter datareader = new FbDataAdapter(comando);
                DataTable usuarios = new DataTable();
                datareader.Fill(usuarios);
                return usuarios;
            }
            catch (Exception err)
            {

                throw err;
            }
            finally
            {
                conex.Close();
            }
        }

    }
}
