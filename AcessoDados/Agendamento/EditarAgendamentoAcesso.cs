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
    public class EditarAgendamentoAcesso
    {
        public bool AtualizarAgendamentos(int idAgendamento, int idStatusAgendamento, DateTime dataConsulta, string observacaoAgendamento)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update agendamento set idStatusAgendamento = @idStatusAgendamento, dataConsulta = @dataConsulta, observacaoAgendamento = @observacaoAgendamento where idAgendamento =@idAgendamento ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idAgendamento", idAgendamento));
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
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do agendamento(Classe EditarAgendamentoAcesso, Método AtualizarAgendamentos)",
                    "Erro de Atualização",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
