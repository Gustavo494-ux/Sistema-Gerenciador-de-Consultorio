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
    public class LocalizarConsultaAgendadaAcesso
    {
       
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
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por todas as consultas agendadas(Classe LocalizarConsultaAgendadaAcesso ,Método TodosAgendamentos)", "Erro de pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return tableVazia;
			}
            return tableVazia;
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
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.nomePaciente like '%"+nomePaciente+"%' AND agendamento.deletar = false ");
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
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do nome do paciente(Classe LocalizarConsultaAgendadaAcesso ,Método NomePaciente)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
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
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.Rg like '%"+RG+"%' AND agendamento.deletar = false ");
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

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do RG do paciente(Classe LocalizarConsultaAgendadaAcesso ,Método RG)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
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
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where paciente.CPF like '%"+CPF+"%' AND agendamento.deletar = false ");
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

                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do CPF do paciente(Classe LocalizarConsultaAgendadaAcesso ,Método CPF)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
        }
        public DataTable DataNascimento(DateTime dataInicial,DateTime dataFinal)
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
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de nascimento dos pacientes(Classe LocalizarConsultaAgendadaAcesso ,Método DataNascimento)",
                    "Erro de pesquisa",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
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
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves de um intervalo de datas de consultas(Classe LocalizarConsultaAgendadaAcesso ,Método DataConsulta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
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
                sql.Append("statusAgendamento ON statusAgendamento.idStatusAgendamento = agendamento.idStatusAgendamento where statusAgendamento.nomeStatus  like '%"+ status +"%' AND agendamento.deletar = false ");
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
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa por consultas agendadas atráves do status do agendamento(Classe LocalizarConsultaAgendadaAcesso ,Método StatusAgendamento)", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return tableVazia;
            }
            return tableVazia;
        }

    }
}
