using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using System.Windows.Forms;

namespace AcessoDados
{
    public class AgendarConsultaAcesso
    {
        public bool AgendarConsulta(int idPaciente,int idUsuario, int idStatusAgendamento, DateTime dataConsulta,string observacaoAgendamento)
        {
			try
			{
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                sql.Append("insert into agendamento(idPaciente,idUsuario,idStatusAgendamento,dataConsulta,observacaoAgendamento,deletar) ");
                sql.Append("VALUES(@idPaciente, @idUsuario, @idStatusAgendamento, @dataConsulta,@observacaoAgendamento,false)");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idPaciente", idPaciente));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idStatusAgendamento", idStatusAgendamento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataConsulta", dataConsulta));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoAgendamento", observacaoAgendamento));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao agendar uma nova consulta(Classe AgendarConsultaAcesso, Método AgendarConsulta)","Erro de agendamento",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return false;
        }

       public bool ChegadaPaciente(int idAgendamento)
       {
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                DateTime horaAtual = Convert.ToDateTime(DateTime.Now.ToLongTimeString());
                sql.Append("update agendamento set horaChegada = @horaAtual,idStatusAgendamento =2 where idAgendamento = @idAgendamento");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idAgendamento", idAgendamento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@horaAtual", horaAtual));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao incluir o paciente na ordem de atendimento(Classe AgendarConsultaAcesso, Método ChegadaPaciente)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
       }
    }
}
