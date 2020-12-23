using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace AcessoDados
{
    public class RelatorioBasicoUsuarioAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable TodosUsuarios()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.dataCadastro,usuario.statusUsuario ");
                sql.Append("from usuario inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where usuario.deletar = false order by usuario.idUsuario asc");

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
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de usuários(Classe RelatorioBasicoUsuarioAcesso, Método TodosUsuarios)", 
                    "Erro de Pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NivelAcessoUsuario(int idNivel)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.dataCadastro,usuario.statusUsuario ");
                sql.Append("from usuario inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where usuario.deletar = false ");
                sql.Append("and nivelAcesso.idNivelAcesso = @nivel order by usuario.idUsuario asc ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@nivel",idNivel));
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
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de usuários(Classe RelatorioBasicoUsuarioAcesso, Método NivelAcessoUsuario)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable StatusUsuario(string status)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.dataCadastro,usuario.statusUsuario ");
                sql.Append("from usuario inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where usuario.deletar = false ");
                sql.Append("and usuario.statusUsuario = @status order by usuario.idUsuario asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@status",status));
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
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de usuários(Classe RelatorioBasicoUsuarioAcesso, Método StatusUsuario)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
