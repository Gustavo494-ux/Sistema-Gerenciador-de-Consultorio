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
    public class ImprimirUsuarioAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(int idUsuario)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT * FROM usuario INNER JOIN nivelAcesso ON nivelAcesso.idNivelAcesso = usuario.idNivel WHERE usuario.deletar= false AND idUsuario = @id ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@id",idUsuario));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do usuario(Classe ImprimirUsuarioAcesso,Método impressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
