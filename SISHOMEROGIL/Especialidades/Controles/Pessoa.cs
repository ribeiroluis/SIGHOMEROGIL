using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using SISHOMEROGIL.Especialidades.BD;
using System.Windows.Forms;

namespace SISHOMEROGIL.Especialidades.Controles
{
    class Pessoa
    {
        public string Prontuario { get; set; }
        public string IDUsuario { get; set; }
        public string Nome { get; set; }
        public string  DataNascimento { get; set; }
        public string CPF { get; set; }
        public string CNS { get; set; }
        public string Mae { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        AcessoDadosEspecialidades Dados;


        public Pessoa()
        {

        }

        
        /// <summary>
        /// Pesquisa na tabela se há usuario com o cartao sus selecionado
        /// </summary>
        /// <returns>verdadeiro ou falso</returns>
        public bool PesquisaUsuarioPorCartaoSUS()
        {
            try
            {
                Dados = new AcessoDadosEspecialidades();
                DataTable tabela = Dados.ConsultaCNS(CNS);
                if (tabela.Rows.Count == 1)
                {
                    PreencheDados(tabela);
                    return true;
                }
                else
                    return false;

            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return false;
            }
        }

        /// <summary>
        /// Preenche os dados utilizando a tabela retornada do banco de dados
        /// </summary>
        private void PreencheDados(DataTable _tabela)
        {
            DataRow linha = _tabela.Rows[0];
            Nome = linha["NOME"].ToString();
            IDUsuario = linha["IDUSUARIO"].ToString();
            Prontuario = linha["PRONTUARIO"].ToString();
            DataNascimento = linha["DTNASCIMENTO"].ToString();
            CNS = linha["CARTAOSUS"].ToString();
            CEP = linha["CEP"].ToString();            
            AcessoDadosEspecialidades access = new AcessoDadosEspecialidades();
            DataRow linhacep = access.ConsultaCEP(CEP).Rows[0];
            if (!linhacep[0].ToString().Equals(""))
            {
                Logradouro = linhacep["ENDERECO"].ToString();
                Bairro = linhacep["BAIRRO"].ToString();
            }
            Numero = linha["ENDNUMERO"].ToString();
            Complemento = linha["ENDCOMPLEMENTO"].ToString();
            CPF = linha["CPF"].ToString();
            Mae = linha["NOMEMAE"].ToString();
            TelefoneFixo = linha["TELFIXO"].ToString();
            TelefoneCelular = linha["TELCEL"].ToString();
        }


        public bool PesquisaUsuarioPorProntuarioFireBird()
        {
            try
            {
                AcessoFireBird acesso = new AcessoFireBird();
                DataTable tabela = acesso.RetornaNomeUsuarioCadastrado(Prontuario);
                if (tabela.Rows.Count == 1)
                {
                    DataRow linha = tabela.Rows[0];
                    Nome = linha["DSUSUARIO"].ToString();
                    DialogResult resultado = MessageBox.Show(Nome, 
                        "Selecionar nome", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        Prontuario = linha["CDUSUARIO"].ToString();
                        DataNascimento = linha["DTNASCIMENTO"].ToString();
                        CPF = linha["NRCPF"].ToString();
                        Mae = linha["DSMAE"].ToString();
                        CEP = linha["NRCEP"].ToString();
                        Numero = linha["NRLOGRADOURO"].ToString();
                        Complemento = linha["DSCOMPLEMENTO"].ToString();
                        TelefoneFixo = linha["NRTELEFONE"].ToString();
                        TelefoneCelular = linha["NRCELULAR"].ToString();
                        AcessoDadosEspecialidades access = new AcessoDadosEspecialidades();
                        DataRow linhacep = access.ConsultaCEP(CEP).Rows[0];
                        if (!linhacep[0].ToString().Equals(""))
                        {
                            Logradouro = linhacep["ENDERECO"].ToString();
                            Bairro = linhacep["BAIRRO"].ToString();
                        }
                        else
                            MessageBox.Show("CEP incorreto, confirme.");
                        return true;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        #region Valida CPF
        public bool ValidaCPF(string cpf)
        {
            // Caso coloque todos os numeros iguais

            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;
            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;



            digito = resto.ToString();
            tempCpf = tempCpf + digito;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];



            resto = soma % 11;
            if (resto < 2)
                resto = 0;

            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
        #endregion        

        #region Valida CNS
        
        /// <summary>
        /// Verifica se o número CNS informado é definitivo ou provisório e se ele é válido [FB]
        /// </summary>
        /// <param name="cns">Número de CNS a ser checado</param>
        /// <returns>True, se o número é válido; False, se for inválido.</returns>
        public bool ValidaCNS()
        {
            string cns = CNS;
            bool result = false;
            cns = cns.Trim();
            if ((cns.Substring(0, 1) == "8") || (cns.Substring(0, 1) == "9"))
            {
                result = chkNumeroProvisorio();
            }
            else
            {
                result = chkNumeroDefinitivo();
            }
            return result;
        }

        /// <summary>
        /// Verifica se um número CNS provisório é válido [FB]
        /// </summary>
        /// <param name="cns">Número de CNS a ser checado</param>
        /// <returns>True, se o número é válido; False, se for inválido.</returns>
        private bool chkNumeroProvisorio()
        {
            string cns = CNS;
            bool result = false;
            try
            {
                cns = cns.Trim();
                if (cns.Trim().Length == 15)
                {
                    float resto, soma;
                    soma = ((Convert.ToInt64(cns.Substring(0, 1))) * 15) +
                            ((Convert.ToInt64(cns.Substring(1, 1))) * 14) +
                            ((Convert.ToInt64(cns.Substring(2, 1))) * 13) +
                            ((Convert.ToInt64(cns.Substring(3, 1))) * 12) +
                            ((Convert.ToInt64(cns.Substring(4, 1))) * 11) +
                            ((Convert.ToInt64(cns.Substring(5, 1))) * 10) +
                            ((Convert.ToInt64(cns.Substring(6, 1))) * 9) +
                            ((Convert.ToInt64(cns.Substring(7, 1))) * 8) +
                            ((Convert.ToInt64(cns.Substring(8, 1))) * 7) +
                            ((Convert.ToInt64(cns.Substring(9, 1))) * 6) +
                            ((Convert.ToInt64(cns.Substring(10, 1))) * 5) +
                            ((Convert.ToInt64(cns.Substring(11, 1))) * 4) +
                            ((Convert.ToInt64(cns.Substring(12, 1))) * 3) +
                            ((Convert.ToInt64(cns.Substring(13, 1))) * 2) +
                            ((Convert.ToInt64(cns.Substring(14, 1))) * 1);
                    resto = soma % 11;
                    result = (resto == 0);
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        /// <summary>
        /// Verifica se um número CNS definitivo é válido [FB]
        /// </summary>
        /// <param name="cns">Número de CNS a ser checado</param>
        /// <returns>True, se o número é válido; False, se for inválido.</returns>
        private bool chkNumeroDefinitivo()
        {
            string cns = CNS;
            bool result = false;
            try
            {
                if (cns.Trim().Length == 15)
                {

                    float resto, soma, dv;
                    string pis = string.Empty;
                    string resultado = string.Empty;
                    pis = cns.Substring(0, 11);
                    soma = ((Convert.ToInt64(pis.Substring(0, 1))) * 15) +
                            ((Convert.ToInt64(pis.Substring(1, 1))) * 14) +
                            ((Convert.ToInt64(pis.Substring(2, 1))) * 13) +
                            ((Convert.ToInt64(pis.Substring(3, 1))) * 12) +
                            ((Convert.ToInt64(pis.Substring(4, 1))) * 11) +
                            ((Convert.ToInt64(pis.Substring(5, 1))) * 10) +
                            ((Convert.ToInt64(pis.Substring(6, 1))) * 9) +
                            ((Convert.ToInt64(pis.Substring(7, 1))) * 8) +
                            ((Convert.ToInt64(pis.Substring(8, 1))) * 7) +
                            ((Convert.ToInt64(pis.Substring(9, 1))) * 6) +
                            ((Convert.ToInt64(pis.Substring(10, 1))) * 5);
                    resto = soma % 11;
                    dv = 11 - resto;
                    if (dv == 11)
                    {
                        dv = 0;
                    }
                    if (dv == 10)
                    {
                        soma = ((Convert.ToInt64(pis.Substring(0, 1))) * 15) +
                                ((Convert.ToInt64(pis.Substring(1, 1))) * 14) +
                                ((Convert.ToInt64(pis.Substring(2, 1))) * 13) +
                                ((Convert.ToInt64(pis.Substring(3, 1))) * 12) +
                                ((Convert.ToInt64(pis.Substring(4, 1))) * 11) +
                                ((Convert.ToInt64(pis.Substring(5, 1))) * 10) +
                                ((Convert.ToInt64(pis.Substring(6, 1))) * 9) +
                                ((Convert.ToInt64(pis.Substring(7, 1))) * 8) +
                                ((Convert.ToInt64(pis.Substring(8, 1))) * 7) +
                                ((Convert.ToInt64(pis.Substring(9, 1))) * 6) +
                                ((Convert.ToInt64(pis.Substring(10, 1))) * 5) + 2;

                        resto = soma % 11;
                        dv = 11 - resto;
                        resultado = pis + "001" + Convert.ToString(Convert.ToInt16(dv)).Trim();
                    }
                    else
                    {
                        resultado = pis + "000" + Convert.ToString(Convert.ToInt16(dv)).Trim();
                    }
                    result = cns.Equals(resultado);
                }
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }
        
        #endregion


    }
}
