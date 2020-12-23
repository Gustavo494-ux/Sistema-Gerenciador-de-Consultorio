using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class LocalizarProfissionalAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabelaAcesso = new DataTable();
        public DataTable TodosProfissionais()
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("SELECT * FROM profissional where deletar = false order by idProfissional asc");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn; 
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método TodosProfissionais) do profissional, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoProfissional(int codigo)
        {
            try
            {
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("SELECT * FROM profissional WHERE idProfissional = @idProfissional and deletar = false order by idProfissional asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idProfissional", codigo));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método CodigoProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomeProfissional(string nome)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where nomeprofissional LIKE '%"+ @nome + "%' and deletar = false order by idProfissional asc");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método NomeProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CPFProfissional(string cpf)
        {

            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where cpf LIKE '%"+ cpf + "%' and deletar = false order by idProfissional asc");


                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf", cpf));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método CpfProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgProfissional(string rg)
        {

            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where rg LIKE '" +@rg + "%' and deletar = false order by idProfissional asc");


                comandoSql.Parameters.Add(new NpgsqlParameter("@rg", rg));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método RgProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CrooProfissional(string croo)
        {

            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where croo LIKE '" + @croo + "%' and deletar=false order by idProfissional asc");


                comandoSql.Parameters.Add(new NpgsqlParameter("@croo", croo));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método CrooProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable EspecialidadeProfissional(string especialidade)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where especialidade LIKE '%" + especialidade + "%' and deletar = false order by idProfissional asc");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método Profissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}
