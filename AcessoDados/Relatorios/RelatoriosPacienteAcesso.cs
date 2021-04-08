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
		DataTable dadosTabela = new DataTable();
		StringBuilder sql = new StringBuilder();
		Banco acessoBanco = new Banco();
		public DataTable TodosPacientesCadastroSimples()
		{ 
			try
			{
				sql.Clear();
				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false order by paciente.idPaciente asc ");

				return acessoBanco.Pesquisar(sql.ToString());
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
				sql.Clear();
				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false and paciente.dataNascimento BETWEEN \'DATAINICIAL\' and \'DATAFINAL\' ");
				sql.Append("order by paciente.idPaciente asc");
				
				sql = sql.Replace("DATAINICIAL",dataInicial.ToString()).Replace("DATAFINAL",dataFinal.ToString());
				return acessoBanco.Pesquisar(sql.ToString());
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
				sql.Clear();
				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false and paciente.dataCadastro BETWEEN \'DATAINICIAL\' and \'DATAFINAL\' ");
				sql.Append("order by paciente.idPaciente asc");

				sql = sql.Replace("DATAINICIAL", dataInicial.ToString()).Replace("DATAFINAL", dataFinal.ToString());
				return acessoBanco.Pesquisar(sql.ToString());
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
				sql.Clear();
				sql.Append("SELECT paciente.idPaciente,paciente.nomePaciente,paciente.cpf,paciente.dataNascimento,usuario.loginUsuario FROM paciente ");
				sql.Append("INNER JOIN usuario ON usuario.idUsuario = paciente.idUsuario ");
				sql.Append("WHERE paciente.deletar = false and usuario.deletar = false and paciente.idade BETWEEN \'IDADEINICIAL\' and \'IDADEFINAL\' ");
				sql.Append("order by paciente.idPaciente asc ");

				sql = sql.Replace("IDADEINICIAL", idadeInicial.ToString()).Replace("IDADEFINAL", idadeFinal.ToString());
				return acessoBanco.Pesquisar(sql.ToString());

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
