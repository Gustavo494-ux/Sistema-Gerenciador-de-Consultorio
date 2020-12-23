using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class EditarEnderecoRegra
    {
		EnderecoRegraNegocio verificar = new EnderecoRegraNegocio();
		EditarEnderecoAcesso editar = new EditarEnderecoAcesso();
		public bool Atualizar(int codigo, string estado, string cidade, string bairro, string rua, string numero,string cep, string referencia, string observacao)
        {
			try
			{
				if (codigo>0)
				{
					if (verificar.Validar("0", "1", estado, cidade, bairro, rua, numero, cep, referencia, observacao) == true)
					{
						return editar.Atualizar(codigo, estado, cidade, bairro, rua, numero, cep.Replace(",", "").Replace(".", "").Replace("-",""), referencia, observacao) ;
					}
				}
				else
				{
					MessageBox.Show("O código indentificador do Endereço é inválido, o mesmo não pode ser inferior a 1", "Dados Inválidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do endereco(classe EditarEnderecoRegra, Método Atualizar)","Erro de Atualização",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return false;
        }
    }
}
