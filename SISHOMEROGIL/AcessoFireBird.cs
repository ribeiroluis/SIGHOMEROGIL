using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FirebirdSql.Data.FirebirdClient;
using FirebirdSql.Data;
using System.Configuration;
using System.Data;

namespace SISHOMEROGIL
{
    class AcessoFireBird
    {
        string Datasource = "DataSource=10.5.124.102; ";
        //string Datasource = "DataSource=localhost; ";
        string DataBase = @"Database=C:\Sistema de Registro da Producao Ambulatorial\FBCADASTRO_AGENDA.fdb; ";        
        string user = "user=SYSDBA; ";
        string password = "password=masterkey";
        string conexao;
        

        public AcessoFireBird()
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

        public DataTable RetornaTabelaUsuariosCadastrados()
        {
            FbConnection conex = new FbConnection(conexao);

            string query = "SELECT CDUSUARIO AS PRONTUARIO, DSUSUARIO AS NOME, DSMAE AS NOMEMAE, DTNASCIMENTO AS DATANASCIMENTO FROM TBUSUARIO";
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

        public DataTable RetornaNomeUsuarioCadastrado(string prontuario)
        {
            FbConnection conex = new FbConnection(conexao);

            string query = "SELECT * FROM TBUSUARIO WHERE CDUSUARIO = '"+prontuario+"'";
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

        public DataTable RetornaTabelaNomeUsuarioPorNome(string pesquisa)
        {
            FbConnection conex = new FbConnection(conexao);

            string query = "SELECT CDUSUARIO, DSUSUARIO, DSMAE FROM TBUSUARIO WHERE DSUSUARIO LIKE '" + pesquisa + "'";
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
