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
    public class EnderecoAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabela = new DataTable();
        StringBuilder sql = new StringBuilder();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        public bool Cadastrar(string idUsuario, string estado, string cidade, string bairro, string rua, string numero, string cep, string pontoReferencia, 
            string observacaoEndereco)
        {

            try
            {
                string CEP = cep.Replace("_", "").Replace(",", "").Replace(".", "").Replace("-", "").Trim();
                int usuario = Convert.ToInt32(idUsuario);

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO endereco(idUsuario, estado, cidade, bairro, rua, numero, cep, pontoReferencia, observacaoEndereco,deletar)");
                sql.Append("VALUES(@idUsuario, @estado, @cidade, @bairro,@rua, @numero, @cep, @pontoReferencia, @observacaoEndereco,false)");

                //Relaciona cada valor com seu respectivo parametro.
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", usuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@estado", estado));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cidade", cidade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@bairro", bairro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rua", rua));
                comandoSql.Parameters.Add(new NpgsqlParameter("@numero", numero));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cep", CEP));
                comandoSql.Parameters.Add(new NpgsqlParameter("@pontoReferencia", pontoReferencia));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoEndereco", observacaoEndereco));


                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.
                comandoSql.ExecuteNonQuery();//Executa o código sql.
                ConexaoAcesso.Desconectar();//Fecha a conexão com o banco de dados
                return true;
            }
            catch (Exception ex)
            { 
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Endereço. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool Atualizar(int codigo, string estado, string cidade, string bairro, string rua, string numero, string cep, string referencia, string observacao)
        {
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
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do endereço(Classe EnderecoAcesso, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool idEndereco(int idUsuarioSistema, int idEndereco)
        {
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
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe EnderecoAcesso, Método idEndereco)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema, int idUsuario)
        {
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
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe EnderecoAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
