using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class DeletarEnderecoAcesso
    {
        public bool idEndereco(int idUsuarioSistema,int idEndereco)
        {
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update endereco set deletar = true,idUsuarioDeletar = @idUsuarioDeletar where idEndereco = @Endereco");
                comandoSql.Parameters.Add(new NpgsqlParameter("@Endereco", idEndereco));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuarioDeletar", idUsuarioSistema));

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe DeletarEnderecoAcesso, Método idEndereco)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema,int idUsuario)
        {
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update endereco set deletar = true,idUsuarioDeletar = @idUsuarioDeletar where idUsuario = @idUsuario");
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuarioDeletar", idUsuarioSistema));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe DeletarEnderecoAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
