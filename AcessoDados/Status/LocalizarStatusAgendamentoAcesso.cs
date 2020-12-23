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
        public DataTable TodosStatus()
        {
			DataTable dadosTabela = new DataTable();
			DataTable tableVazia = new DataTable();

			try
			{
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();
				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();

				sql.Append("select * from statusAgendamento where deletar = false");

				comandoSql.CommandText = sql.ToString();
				comandoSql.Connection = ConexaoAcesso.conn;

				dadosTabela.Load(comandoSql.ExecuteReader());

				ConexaoAcesso.Desconectar();

				return dadosTabela;
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa dos Status de Agendamento(Classe LocalizarStatusAgendamentoAcesso, Método TodosStatus)","Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return tableVazia;
        }
		public DataTable RetornarIdStatus(string status)
		{
			DataTable dadosTabela = new DataTable();
			DataTable tableVazia = new DataTable();

			try
			{
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();
				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();

				sql.Append("select idStatusAgendamento from statusAgendamento where nomeStatus= @status and deletar = false");
				comandoSql.Parameters.Add(new NpgsqlParameter("@status",status));

				comandoSql.CommandText = sql.ToString();
				comandoSql.Connection = ConexaoAcesso.conn;

				dadosTabela.Load(comandoSql.ExecuteReader());

				ConexaoAcesso.Desconectar();

				return dadosTabela;
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa dos Status de Agendamento(Classe LocalizarStatusAgendamentoAcesso, Método RetornarIdStatus)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}


	}
}
