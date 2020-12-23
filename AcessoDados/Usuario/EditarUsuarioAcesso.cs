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
    public class EditarUsuarioAcesso
    {
        public DataTable retornarDados(int idUsuario)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
			try
			{
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.senhaUsuario,nivelAcesso.nomeNivel,usuario.statusUsuario,usuario.observacaoUsuario from usuario ");
                sql.Append("inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where idUsuario = @idUsuario and usuario.deletar = false");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario",idUsuario));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabela;
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao pesquisar os dados do usuario para serem editados(Classe EditarUsuarioAcesso,metodo retornarDados)","Erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return tableVazia;
        }

        public bool Atualizar(int idUsuario, string nomeUsuario,string loginUsuario,string senhaUsuario,int idNivel, string statusUsuario,string observacaoUsuario)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update usuario set nomeUsuario = @nomeUsuario, loginUsuario= @loginUsuario, senhaUsuario = @senhaUsuario, idNivel = @idNivel, statusUsuario = @statusUsuario,");
                sql.Append("observacaoUsuario = @observacaoUsuario where idUsuario = @idUsuario");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeUsuario",nomeUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@loginUsuario",loginUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@senhaUsuario",senhaUsuario)); 
                comandoSql.Parameters.Add(new NpgsqlParameter("@idNivel",idNivel+1));
                comandoSql.Parameters.Add(new NpgsqlParameter("@statusUsuario",statusUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoUsuario",observacaoUsuario));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a atualização dos dados do usuario(Classe retornarDados,Método Atualizar)","Erro de atualização/edição",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
