using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Data.SqlClient;

namespace AcessoDados
{
    public class ContatoAcesso
    {
        StringBuilder sql = new StringBuilder();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        public bool cadastrar(string idContato, string idUsuario, string email, string telefone1, string telefone2, string telefone3, string outro, string observacaoContato)
        {
			try
            {
                //Variaveis para campos que precisam receber algum tipo de alteração antes de ir ao banco.
                int IDCONTATO, USUARIO;
                string EMAIL, TELEFONE1, TELEFONE2, TELEFONE3, OUTRO, OBSERVACAOcONTATO;

                //Converte o idContato e idLogin de string para int
                IDCONTATO = Convert.ToInt32(idContato);
                USUARIO = Convert.ToInt32(idUsuario);

                //Retira paranteses, pontos, virgulas, "-" e "_";
                TELEFONE1 = telefone1.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim();
                TELEFONE2 = telefone2.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim();
                TELEFONE3 = telefone3.Replace("(", "").Replace(")", "").Replace(",", "").Replace(".", "").Replace("_", "").Replace("-", "").Trim();

                //Converte tudo para string 
                EMAIL = Convert.ToString(email);
                OUTRO = Convert.ToString(outro);
                OBSERVACAOcONTATO = Convert.ToString(observacaoContato);



                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO contato(idUsuario, email, telefone1, telefone2, telefone3, outro, observacaoContato, deletar)");
                sql.Append("VALUES(@idUsuario, @email, @telefone1, @telefone2, @telefone3, @outro, @observacaoContato,false)");

                //Relaciona cada valor com seu respectivo parametro.
                comandoSql.Parameters.Add(new NpgsqlParameter("@idContato", IDCONTATO));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", USUARIO));
                comandoSql.Parameters.Add(new NpgsqlParameter("@email", EMAIL));
                comandoSql.Parameters.Add(new NpgsqlParameter("@telefone1", TELEFONE1));
                comandoSql.Parameters.Add(new NpgsqlParameter("@telefone2", TELEFONE2));
                comandoSql.Parameters.Add(new NpgsqlParameter("@telefone3", TELEFONE3));
                comandoSql.Parameters.Add(new NpgsqlParameter("@outro", OUTRO));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoContato", OBSERVACAOcONTATO));

                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.
                comandoSql.ExecuteNonQuery();//Executa o código sql.
                ConexaoAcesso.Desconectar();//Fecha a conexão com o banco de dados
                return true;
                
            }
			catch (Exception ex) 
			{
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do contato. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
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
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do Contato(Classe ContatoAcesso, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool idContato(int idUsuarioSistema, int idContato)
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
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe ContatoAcesso, Método idContato)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema, int idUsuario)
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
                MessageBox.Show("Ocorreu um erro ao deletar o endereço(Classe ContatoAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
