using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
    public class RelatoriosPacienteAcesso
	{
		DataTable tableVazia = new DataTable();
        public DataTable TodosPacientesCadastroSimples()
		{ 
			try
			{
				DataTable dadosTabela = new DataTable();
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();

				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false order by paciente.idPaciente asc ");

				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();

				comandoSql.Connection = ConexaoAcesso.conn;
				comandoSql.CommandText = sql.ToString();
				dadosTabela.Load(comandoSql.ExecuteReader());

				ConexaoAcesso.Desconectar();
				return dadosTabela;
				
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de paciente(Classe RelatoriosAcesso, Método TodosPacientesCadastroSimples)", 
					"Erro de Pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			return tableVazia;
        }

		public DataTable DataNascimentoPacientesCadastroSimples(DateTime dataInicial, DateTime dataFinal)
		{
			try
			{
				DataTable dadosTabela = new DataTable();
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();

				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false and paciente.dataNascimento BETWEEN @dataInicial and @dataFinal ");
				sql.Append("order by paciente.idPaciente asc");

				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();

				comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial",dataInicial));
				comandoSql.Parameters.Add(new NpgsqlParameter("@DataFinal",dataFinal));

				comandoSql.Connection = ConexaoAcesso.conn;
				comandoSql.CommandText = sql.ToString();
				dadosTabela.Load(comandoSql.ExecuteReader());

				ConexaoAcesso.Desconectar();
				return dadosTabela;

			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de paciente(Classe RelatoriosAcesso, Método DataNascimentoPacientesCadastroSimples)",
					"Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}

		public DataTable DataCadastroPacientesCadastroSimples(DateTime dataInicial, DateTime dataFinal)
		{
			try
			{
				DataTable dadosTabela = new DataTable();
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();

				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false and paciente.dataCadastro BETWEEN @dataInicial and @dataFinal ");
				sql.Append("order by paciente.idPaciente asc");

				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();

				comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial", dataInicial));
				comandoSql.Parameters.Add(new NpgsqlParameter("@DataFinal", dataFinal));

				comandoSql.Connection = ConexaoAcesso.conn;
				comandoSql.CommandText = sql.ToString();
				dadosTabela.Load(comandoSql.ExecuteReader());

				ConexaoAcesso.Desconectar();
				return dadosTabela;

			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de paciente(Classe RelatoriosAcesso, Método DataCadastroPacientesCadastroSimples)",
					"Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}

		//Não é utilizado
		public DataTable IdadePacientesCadastroSimples(string idadeInicial ,string idadeFinal)
		{
			try
			{
				DataTable dadosTabela = new DataTable();
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();

				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false and paciente.idade BETWEEN @idadeInicial and @idadeFinal ");
				sql.Append("order by paciente.idPaciente asc ");

				comandoSql.Parameters.Add(new NpgsqlParameter("@idadeInicial", idadeInicial));
				comandoSql.Parameters.Add(new NpgsqlParameter("@idadeFinal", idadeFinal));

				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();

				comandoSql.Connection = ConexaoAcesso.conn;
				comandoSql.CommandText = sql.ToString();
				dadosTabela.Load(comandoSql.ExecuteReader());

				ConexaoAcesso.Desconectar();
				return dadosTabela;

			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de paciente(Classe RelatoriosAcesso, Método IdadePacientesCadastroSimples)",
					"Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return tableVazia;
		}
	}
}
