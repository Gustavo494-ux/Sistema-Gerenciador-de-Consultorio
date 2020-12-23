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
    public class EditarEnderecoAcesso
    {
        public bool Atualizar(int codigo, string estado,string cidade,string bairro, string rua,string numero, string cep, string referencia, string observacao)
        {

            DataTable tableVazia = new DataTable();
            DataTable dadosTabela = new DataTable();
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                sql.Append("UPDATE endereco SET estado = @estado,cidade = @cidade, bairro = @bairro,rua = @rua,numero = @numero,cep = @cep,pontoReferencia = @referencia,observacaoEndereco = @observacao");
                sql.Append(" WHERE idEndereco = @codigo ");
                comandoSql.Parameters.Add(new NpgsqlParameter("@codigo", codigo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@estado", estado));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cidade", cidade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@bairro", bairro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rua", rua));
                comandoSql.Parameters.Add(new NpgsqlParameter("@numero", numero));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cep", cep));
                comandoSql.Parameters.Add(new NpgsqlParameter("@referencia", referencia));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacao", observacao));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do endereço(Classe EditarEnderecoAcesso, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
