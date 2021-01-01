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
    public class AgendamentosAcesso
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
                MessageBox.Show("Ocorreu um erro ao agendar uma nova consulta(Classe AgendamentosAcesso, Método AgendarConsulta)", "Erro de agendamento",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Ocorreu um erro ao incluir o paciente na ordem de atendimento(Classe AgendamentosAcesso, Método ChegadaPaciente)", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
       }
        //Função para Consultar um paciente agendado, assim alterando o status do agendamento para o 3.
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
                MessageBox.Show("Ocorreu um erro ao consultar um paciente agendado(Classe AgendamentosAcesso, Método ConsultarPacienteAgendado)", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Função para finalizar a consulta agendada, assim alterando o status do agendamento para o 4.
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
                MessageBox.Show("Ocorreu um erro ao finalizar uma consulta de um paciente agendado(Classe AgendamentosAcesso, Método FinalizarConsultaAgendada)", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        //Função para atualizar/Editar os dados do agendamento.
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
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do agendamento(Classe AgendamentosAcesso, Método AtualizarAgendamentos)",
                    "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        //Funções para realizar pesquisas dos agendamentos com diferentes filtros de pesquisa.
        public DataTable TodosAgendamentos()
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento, agendamento.idPaciente, paciente.nomePaciente, paciente.nomeResponsavel, paciente.rg, paciente.cpf, paciente.dataNascimento,");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where agendamento.deletar = false AND paciente.deletar = false AND ");
                sql.Append("usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc ");


                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por todas as consultas agendadas(Classe AgendamentosAcesso ,Método TodosAgendamentos)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
        public DataTable NomePaciente(string nomePaciente)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento, agendamento.idPaciente, paciente.nomePaciente, paciente.nomeResponsavel, paciente.rg, paciente.cpf, paciente.dataNascimento, ");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.nomePaciente like '%" + nomePaciente + "%' AND agendamento.deletar = false ");
                sql.Append("AND paciente.deletar = false AND usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@nomePaciente", nomePaciente));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do nome do paciente(Classe AgendamentosAcesso ,Método NomePaciente)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
        public DataTable RG(string RG)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento,agendamento.idPaciente,paciente.nomePaciente,paciente.nomeResponsavel,paciente.rg, paciente.cpf, paciente.dataNascimento, ");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.Rg like '%" + RG + "%' AND agendamento.deletar = false ");
                sql.Append("AND paciente.deletar = false AND usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@RG", RG));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do RG do paciente(Classe AgendamentosAcesso ,Método RG)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
        public DataTable CPF(string CPF)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento,agendamento.idPaciente,paciente.nomePaciente,paciente.nomeResponsavel,paciente.rg, paciente.cpf, paciente.dataNascimento, ");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.CPF like '%" + CPF + "%' AND agendamento.deletar = false ");
                sql.Append("AND paciente.deletar = false AND usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@CPF", CPF));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do CPF do paciente(Classe AgendamentosAcesso ,Método CPF)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
        public DataTable DataNascimento(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento, agendamento.idPaciente, paciente.nomePaciente, paciente.nomeResponsavel, paciente.rg, paciente.cpf, paciente.dataNascimento, ");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN  ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.dataNascimento > @dataInicial and paciente.dataNascimento ");
                sql.Append("< @dataFinal AND agendamento.deletar = false AND paciente.deletar = false AND usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial", dataInicial));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataFinal", dataFinal));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de nascimento dos pacientes(Classe AgendamentosAcesso ,Método DataNascimento)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
        public DataTable DataConsulta(DateTime dataInicial, DateTime dataFinal)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento, agendamento.idPaciente, paciente.nomePaciente, paciente.nomeResponsavel, paciente.rg, paciente.cpf, paciente.dataNascimento, ");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN  ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where agendamento.dataConsulta > @dataInicial and agendamento.dataConsulta ");
                sql.Append("< @dataFinal AND agendamento.deletar = false AND paciente.deletar = false AND usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial", dataInicial));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataFinal", dataFinal));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de consultas(Classe AgendamentosAcesso ,Método DataConsulta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
        public DataTable StatusAgendamento(string status)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            tableVazia = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT agendamento.idAgendamento, agendamento.idPaciente, paciente.nomePaciente, paciente.nomeResponsavel, paciente.rg, paciente.cpf, paciente.dataNascimento, ");
                sql.Append("agendamento.idAgendamento, agendamento.dataConsulta, agendamento.horaChegada, agendamento.observacaoAgendamento, usuario.loginUsuario, statusAgendamento.nomeStatus ");
                sql.Append("FROM agendamento INNER JOIN paciente ON paciente.idPaciente = agendamento.idPaciente INNER JOIN usuario ON usuario.idUsuario = agendamento.idUsuario INNER JOIN ");
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where statusAgendamento.nomeStatus  like '%" + status + "%' AND agendamento.deletar = false ");
                sql.Append("AND paciente.deletar = false AND usuario.deletar = false AND statusAgendamento.deletar = false order by horaChegada,idAgendamento asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@status", status));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();

                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do status do agendamento(Classe AgendamentosAcesso ,Método StatusAgendamento)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
        }
    }
}
