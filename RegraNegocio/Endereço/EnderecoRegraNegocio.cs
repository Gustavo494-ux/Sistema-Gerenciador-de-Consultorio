using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
   public  class EnderecoRegraNegocio
	{
		//Método responsável por validar as informações.
		public bool Validar(string idEndereco, string idUsuario, string estado, string cidade, string bairro, string rua, string numero, string cep, string pontoReferencia, string observacao)
		{

			try
			{
				if (idEndereco != "0") return false;

				if (Convert.ToInt32(idUsuario) < 1) return false;

				if (estado.Length > 30) return false;

				if (cidade.Length > 30) return false;

				if (bairro.Length > 30) return false;

				if (rua.Length > 50) return false;

				if (numero.Trim().Length > 5) return false;

				if (cep.GetType() != typeof(string)) return false;

				if (pontoReferencia.GetType() != typeof(string)) return false;

				if (observacao.GetType() != typeof(string)) return false;
			}
			catch (Exception ex)
			{

				MessageBox.Show("Erro no método de validação das informações de cadastro do endereço. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return true;
		}
		//Método responsável por enviar as informações para a classe responsável por inserir os dados no banco se a verificação dos campos der true
		public bool Cadastrar(string idEndereco, string idUsuario, string estado, string cidade, string bairro, string rua, string numero, string cep, string pontoReferencia, string observacaoEndereco)
		{
			try

			{
				if (Validar(idEndereco, idUsuario, estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco) == true)//Se a verificação der true as informações são inseridas
				{
					EnderecoAcesso novoEndereco = new EnderecoAcesso();
					return novoEndereco.Cadastrar(idEndereco, idUsuario, estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco);
				}
				else
				{
					MessageBox.Show("Algumas informações do endereço são inválidas,Tente novamente com informações diferentes, Caso o problema persista entre em contato com o suporte!",
						"Informações inválidas!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}

			}

			catch (Exception ex)
			{
				
				MessageBox.Show("Erro no método de validação das informações de cadastro do contato(Classe Contato, método Cadastrar). Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
				   MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return false;
		}
		
   }
		
}
