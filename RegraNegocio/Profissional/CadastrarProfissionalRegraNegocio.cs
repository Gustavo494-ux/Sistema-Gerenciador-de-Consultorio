
using System;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
	public class CadastrarProfissionalRegraNegocio
	{
		public bool Cadastrar(string idProfissional, string idEndereco, string idContato,string idUsuario , string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo,
			string dataNascimento, string dataCadastro, string horaCadastro, string observacaoProfissional)
		{
			try
			{
				if (Verificar(idProfissional,idEndereco,idContato, idUsuario, nomeProfissional,especialidade,rg,cpf, sexo,croo,dataNascimento,dataCadastro,horaCadastro, observacaoProfissional) == true)//Se a verificação der true as informações são inseridas
				{
					ProfissionalAcesso novoProfissional = new ProfissionalAcesso();
					return novoProfissional.Cadastrar(idProfissional, idEndereco, idContato, idUsuario,nomeProfissional.ToUpper(), especialidade.ToUpper(), rg, cpf, sexo, croo, dataNascimento, dataCadastro, horaCadastro, observacaoProfissional);
				}
				else
				{
					MessageBox.Show("Algumas informações do Profissional são inválidas,Tente novamente com informações diferentes, Caso o problema persista entre em contato com o suporte!",
						"Informações inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no método de validação das informações de cadastro do profissional(Classe profissionalAcesso, método Cadastrar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		public bool Verificar(string idProfissional, string idEndereco, string idContato ,string idUsuario, string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo,
			string dataNascimento, string dataCadastro, string horaCadastro, string observacaoProfissional)//Método responsável por validações das informações a serem inseridas
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

				if (observacaoProfissional.GetType() != typeof(string)) return false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erro no método de validação das informações de cadastro do profissional. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return true;
		}

		
	}
}
