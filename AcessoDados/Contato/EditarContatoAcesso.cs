using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class EditarContatoAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabela = new DataTable();
        StringBuilder sql = new StringBuilder();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        public bool Atualizar(int codigo, string email, string telefone1, string telefone2, string telefone3, string outro, string observacao)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                sql.Append(" update contato SET email = @email, telefone1= @telefone1, telefone2 = @telefone2,telefone3 = @telefone3, outro = @outro, observacaoContato = @observacao ");
                sql.Append("WHERE idContato = @codigo ");
                comandoSql.Parameters.Add(new NpgsqlParameter("@codigo", codigo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@email", email)); 
                comandoSql.Parameters.Add(new NpgsqlParameter("@telefone1", telefone1)); 
                comandoSql.Parameters.Add(new NpgsqlParameter("@telefone2", telefone2));
                comandoSql.Parameters.Add(new NpgsqlParameter("@telefone3", telefone3));
                comandoSql.Parameters.Add(new NpgsqlParameter("@outro", outro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacao", observacao));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }

            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do Contato(Classe EditarContatoAcesso, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
