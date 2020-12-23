using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
	public class EditarContatoRegra
	{

		public bool Atualizar(int codigo, string email, string telefone1, string telefone2, string telefone3, string outro, string observacao)
		{
			try
			{
				ContatoRegraNegocio verificar = new ContatoRegraNegocio();
				EditarContatoAcesso editar = new EditarContatoAcesso();
				if (codigo > 0)
				{
					if (verificar.Verificar("0", "1", email, telefone1, telefone2, telefone3, outro, observacao) == true)
					{
						return editar.Atualizar(codigo, email, telefone1.Replace("(","").Replace(")","").Replace(".","").Replace("-",""), telefone2.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", ""),
							telefone3.Replace("(", "").Replace(")", "").Replace(".", "").Replace("-", ""), outro, observacao);
					}		
				}
				else
				{
					MessageBox.Show("O código indentificador do Contato é inválido, o mesmo não pode ser inferior a 1", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do Contato(classe EditarContatoRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
	}
}
