using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class ConsultarPacienteAgendadoAcesso
    {
		
        public bool ConsultarPacienteAgendado(int id)
        {
			try
			{
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();

				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();


				sql.Append("update agendamento set idStatusAgendamento = 3 where idAgendamento = @id");
				comandoSql.Parameters.Add(new NpgsqlParameter("@id", id));

				comandoSql.Connection = ConexaoAcesso.conn;
				comandoSql.CommandText = sql.ToString();

				comandoSql.ExecuteNonQuery();
				ConexaoAcesso.Desconectar();
				return true;
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao consultar um paciente agendado(Classe ConsultarPacienteAgendadoAcesso, Método ConsultarPacienteAgendado)", "Erro",
					MessageBoxButtons.OK,MessageBoxIcon.Error);
				return false;
			}
			return false;
        }
		public bool FinalizarConsultaAgendada(int id)
		{
			try
			{
				StringBuilder sql = new StringBuilder();
				NpgsqlCommand comandoSql = new NpgsqlCommand();

				ConexaoAcesso.Desconectar();
				ConexaoAcesso.Conectar();


				sql.Append("update agendamento set idStatusAgendamento = 4 where idAgendamento = @id  and idStatusAgendamento = 3;");
				comandoSql.Parameters.Add(new NpgsqlParameter("@id", id));

				comandoSql.Connection = ConexaoAcesso.conn;
				comandoSql.CommandText = sql.ToString();

				comandoSql.ExecuteNonQuery();
				ConexaoAcesso.Desconectar();
				return true;
			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao finalizar uma consulta de um paciente agendado(Classe ConsultarPacienteAgendadoAcesso, Método FinalizarConsultaAgendada)", "Erro",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}

	}
}
