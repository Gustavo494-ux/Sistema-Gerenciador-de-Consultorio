using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;


namespace RegraNegocio
{
    public class RelatorioBasicoUsuarioRegra
    {
		DataTable tableVazia = new DataTable();
        public DataTable TodosUsuarios()
        {
			try
			{
				RelatorioBasicoUsuarioAcesso pesquisar = new RelatorioBasicoUsuarioAcesso();
				return pesquisar.TodosUsuarios();
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro de usuario(Classe RelatorioBasicoUsuarioRegra, Método TodosPacientesCadastroSimples)",
					   "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia; 
        }
		public DataTable TodosNivelAcessoUsuarioUsuarios(string idNivel)
		{
			try
			{
				RelatorioBasicoUsuarioAcesso pesquisar = new RelatorioBasicoUsuarioAcesso();
				return pesquisar.NivelAcessoUsuario(Convert.ToInt32(idNivel)+1);
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro de usuario(Classe RelatorioBasicoUsuarioRegra, Método TodosNivelAcessoUsuarioUsuarios)",
					   "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}
		public DataTable StatusUsuario(string status)
		{
			try
			{
				RelatorioBasicoUsuarioAcesso pesquisar = new RelatorioBasicoUsuarioAcesso();
				return pesquisar.StatusUsuario(status);
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro de usuario(Classe RelatorioBasicoUsuarioRegra, Método StatusUsuario)",
					   "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}
	}
}
