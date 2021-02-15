
using System;
using System.Data;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
	public class ProfissionalRegra
	{
        DataTable tableVazia = new DataTable();
		public bool Cadastrar(string idProfissional, string idEndereco, string idContato,string idUsuario , string nomeProfissional, string especialidade,string rg, string cpf,
            string sexo, string croo,string dataNascimento, string dataCadastro, string horaCadastro,string rodapeReceita, string observacaoProfissional)
		{
			try
			{
				if (Verificar(idProfissional,idEndereco,idContato, idUsuario, nomeProfissional,especialidade,rg,cpf, sexo,croo,dataNascimento,dataCadastro,horaCadastro,
                    rodapeReceita, observacaoProfissional) == true)//Se a verificação der true as informações são inseridas
				{
					ProfissionalAcesso novoProfissional = new ProfissionalAcesso();
					return novoProfissional.Cadastrar(idProfissional, idEndereco, idContato, idUsuario,nomeProfissional.ToUpper(), especialidade.ToUpper(), rg, cpf, sexo, croo, 
                        dataNascimento, dataCadastro, horaCadastro, rodapeReceita, observacaoProfissional);
				}
				else
				{
					MessageBox.Show("Algumas informações do Profissional são inválidas,Tente novamente com informações diferentes, Caso o problema persista entre em contato com o suporte!",
						"Informações inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no método de validação das informações de cadastro do profissional(Classe ProfissionalRegra, método Cadastrar). Error:  " + ex.Message + 
                    " Caso o problema persista entre em contato com o suporte!", "Erro na validação",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public bool Verificar(string idProfissional, string idEndereco, string idContato ,string idUsuario, string nomeProfissional, string especialidade,
            string rg, string cpf, string sexo, string croo,
			string dataNascimento, string dataCadastro, string horaCadastro,string rodapeReceita, string observacaoProfissional)//Método responsável por validações das informações a serem inseridas
		{
			try
			{
				#region Códigos indentificadores
				if (idProfissional != "0")//Se o idProfissional for igual a 0 é inválido.
				{
					MessageBox.Show("O código indentificador do profissional(" + idProfissional + ") é inválido" + "Tente novamente com uma informação diferente, Caso o problema persista entre em contato com o suporte!",
						"Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}
				if (Convert.ToInt32(idUsuario) < 1)
				{
					MessageBox.Show("O código indentificador do usuario(" + idUsuario + ") é inválido" + "Tente novamente com uma informação diferente, Caso o problema persista entre em contato com o suporte!",
					"Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return false;
				}
				#endregion
				if (nomeProfissional.Length <1 || nomeProfissional.Length > 50)return false;

				if (especialidade.Length > 30) return false;

				if (rg.Trim().Length > 20)return false;

				if (cpf.Replace(",", "").Replace(".", "").Replace("-", "").Trim().Length == 11)
				{
					string campoCPF = cpf.Replace(",", "").Replace(".", "").Replace("-", "").Trim();
					int NumerosVariaveis = 0;
					string[] arrayCPF = null;


					int[] PrimeiroDigito = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
					int[] SegundoDigito = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
					int resultadoPrimeiroDigito = 0;
					int resultadoSegundoDigito = 0;

					for (int i = 0; i < PrimeiroDigito.Length; i++)
					{
						NumerosVariaveis = Int32.Parse(Convert.ToString(campoCPF[i]));//Convert o numero do cpf a ser utilizado para string e depois para int
						resultadoPrimeiroDigito = resultadoPrimeiroDigito + (NumerosVariaveis * PrimeiroDigito[i]);//efetua o calculo de acordo com o algoritimo de validação
					}
					int digitoVerificador1 = Int32.Parse(Convert.ToString(campoCPF[9]));//
					int PrimeiroVerificador = (resultadoPrimeiroDigito * 10) % 11;
					if (PrimeiroVerificador == digitoVerificador1)
					{
						for (int i = 0; i < SegundoDigito.Length; i++)
						{
							NumerosVariaveis = Int32.Parse(Convert.ToString(campoCPF[i]));//Convert o numero do cpf a ser utilizado para string e depois para int
							resultadoSegundoDigito = resultadoSegundoDigito + (NumerosVariaveis * SegundoDigito[i]);//efetua o calculo de acordo com o algoritimo de validação
						}
						int digitoVerificador2 = Int32.Parse(Convert.ToString(campoCPF[10]));//
						int SegundoVerificador = (resultadoSegundoDigito * 10) % 11;
						if (SegundoVerificador != digitoVerificador2)
						{
							MessageBox.Show("O CPF do Profissional(" + cpf + ") é inválido" + "Tente novamente com uma informação diferente, Caso o problema persista entre em contato com o suporte!",
						   "Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
							return false;
						}
					}
					if (PrimeiroVerificador != digitoVerificador1)
					{
						MessageBox.Show("O CPF do Profissional(" + cpf + ") é inválido" + "Tente novamente com uma informação diferente, Caso o problema persista entre em contato com o suporte!",
						"Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return false;
					}
				}
                else
                {
					return false;
                }

			    if (sexo != "F" && sexo != "O" && sexo != "M")return false;

				if (croo.GetType() != typeof(string) || croo.Length > 30) return false;

				if (Convert.ToDateTime(dataNascimento) > Convert.ToDateTime(DateTime.Now.ToShortDateString()))return false;

                if (rodapeReceita.Length > 200) return false;

				if (observacaoProfissional.GetType() != typeof(string)) return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no método de validação das informações de cadastro do profissional. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return true;
		}
        public DataTable RetornarDados(string idProfissional)
        {
            DataTable tableVazia = new DataTable();
            try
            {
                if (Convert.ToInt32(idProfissional) > 0)
                {
                    ProfissionalAcesso Editar = new ProfissionalAcesso();
                    return Editar.RetornarDados(Convert.ToInt32(idProfissional));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe ProfissionalRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;

        }
        public bool Atualizar(string idProfissional, string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo,
            string dataNascimento,string rodapeReceita, string observacaoProfissional)
		{
			try
			{
				if (Convert.ToInt32(idProfissional) > 0)
				{
			        ProfissionalRegra validar = new ProfissionalRegra();
					//As informações colocadas diretamente são informações que nunca são alteredas então não precisam passar por validação antes da atualização do registro no sistema.
					if (validar.Verificar("0", "1", "1", "1", nomeProfissional, especialidade, rg, cpf, sexo, croo, dataNascimento, "", "", rodapeReceita, observacaoProfissional) == true)
					{
						ProfissionalAcesso Editar = new ProfissionalAcesso();
						return Editar.Atualizar(Convert.ToInt32(idProfissional), nomeProfissional, especialidade, rg, cpf.Replace(".", "").Replace("-", "").Replace(",", ""), sexo, croo,
                            Convert.ToDateTime(dataNascimento), rodapeReceita,observacaoProfissional);
					}
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe ProfissionalRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}

        //Funções para pesquisa do profissional com diversos filtros.
        public DataTable TodosProfissionais()
        {
            try
            {
                ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                return LocalizarProfissional.TodosProfissionais();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método TodosProfissionais) do profissional , " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoProfissional(int codigo)
        {
            try
            {
                if (codigo > 0)
                {
                    ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                    return LocalizarProfissional.CodigoProfissional(codigo);
                }
                else
                {
                    MessageBox.Show("Código Indentificador é inválido, para proseguir com a pesquisa insira um código valido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método CodigoProfissional) do profissional atráves do Código Indentificador, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomeProfissional(string nome)
        {
            try
            {
                if (nome.Length > 0)
                {
                    ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                    return LocalizarProfissional.NomeProfissional(nome);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método NomeProfissional) do profissional atráves do nome, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfProfissional(string cpf)
        {
            try
            {
                if (cpf.Length > 0)
                {
                    ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                    return LocalizarProfissional.CPFProfissional(cpf);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método CpfProfissional) do profissional atráves do CPF, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgProfissional(string rg)
        {
            try
            {
                if (rg.Length > 0)
                {
                    ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                    return LocalizarProfissional.RgProfissional(rg);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método RgProfissional) do profissional atráves do RG, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CrooProfissional(string croo)
        {
            try
            {
                if (croo.Length > 0)
                {
                    ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                    return LocalizarProfissional.CrooProfissional(croo);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método CrooProfissional) do profissional atráves do CROO, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable EspecialidadeProfissional(string especialidade)
        {
            try
            {
                if (especialidade.Length > 0)
                {
                    ProfissionalAcesso LocalizarProfissional = new ProfissionalAcesso();
                    return LocalizarProfissional.EspecialidadeProfissional(especialidade);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe ProfissionalRegra, Método EspecialidadeProfissional) do profissional atráves da Especialidade, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        //Função para deletar lógicamente o profissional
        public bool idProfissional(string idUsuarioSistema, string idProfissional)
        {
            try
            {
                if (Convert.ToInt32(idProfissional) > 0)
                {
                    ProfissionalAcesso deletar = new ProfissionalAcesso();
                    return deletar.idProfissional(Convert.ToInt32(idUsuarioSistema), Convert.ToInt32(idProfissional));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o profissional(classe ProfissionalRegra, Método idProfissional)", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool idUsuario(string idUsuarioSistema, string idUsuario)
        {
            try
            {
                if (Convert.ToInt32(idUsuario) > 0)
                {
                    ProfissionalAcesso deletar = new ProfissionalAcesso();
                    return deletar.idUsuario(Convert.ToInt32(idUsuarioSistema), Convert.ToInt32(idUsuario));
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o profissional(classe ProfissionalRegra, Método idUsuario)", "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
