using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace AcessoDados
{
    public class LocalizarStatusAgendamentoAcesso
    {
		DataTable dadosTabela = new DataTable();
		DataTable tableVazia = new DataTable();
		StringBuilder sql = new StringBuilder();
		Banco acessoBanco = new Banco();
		public DataTable TodosStatus()
        {
			try
			{
				sql.Clear();
				sql.Append("select * from statusAgendamento where deletar = false");

				return acessoBanco.Pesquisar(sql.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa dos Status de Agendamento(Classe LocalizarStatusAgendamentoAcesso, Método TodosStatus)","Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return tableVazia;
        }
		public DataTable RetornarIdStatus(string status)
		{
			try
			{
				sql.Clear();
				sql.Append("select idStatusAgendamento from statusAgendamento where nomeStatus= \'STATUS\' and deletar = false");
				sql = sql.Replace("STATUS",status);

				return acessoBanco.Pesquisar(sql.ToString());
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa dos Status de Agendamento(Classe LocalizarStatusAgendamentoAcesso, Método RetornarIdStatus)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}
	}
}
