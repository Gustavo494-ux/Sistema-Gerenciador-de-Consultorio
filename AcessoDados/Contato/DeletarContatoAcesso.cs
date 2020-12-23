using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class DeletarContatoAcesso
    {
        public bool idContato(int idUsuarioSistema,int idContato)
        {
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update contato set deletar = true,idUsuarioDeletar = @idUsuarioDeletar where idContato = @contato");
                comandoSql.Parameters.Add(new NpgsqlParameter("@contato", idContato));
                comandoSql.Parameters.Add(new NpgsqlParameter("@IdUsuarioDeletar", idUsuarioSistema));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe DeletarContaotAcesso, Método idContato)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema ,int idUsuario)
        {
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update contato set deletar = true, idUsuarioDeletar = @idUsuarioDeletar where idUsuario = @idUsuario");
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@IdUsuarioDeletar", idUsuarioSistema));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;   
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe DeletarContaotAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
