using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
   public class CadastrarUsuarioAcesso
   {
        public bool Cadastrar(string idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string observacaoUsaurio, string statusUsuario)
        {
			try
			{
                //Efetua o tratamento de dados para que possam ser inseridos da maneira correta no banco de dados.
                int nivel = Convert.ToInt32(idNivel);
                DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString()), HoraCadastro = Convert.ToDateTime(DateTime.Now.ToLongTimeString());


                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO usuario(idNivel,nomeUsuario, loginUsuario, senhaUsuario, dataCadastro,horaCadastro, observacaoUsuario, statusUsuario,deletar)");

                sql.Append("VALUES(@idNivel,@nomeUsuario,@loginUsuario,@senhaUsuario,@dataCadastro,@horaCadastro,@observacao,@statusUsuario,false)");

                //Relaciona cada valor com seu respectivo parametro.
                comandoSql.Parameters.Add(new NpgsqlParameter("@idNivel", nivel));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeUsuario", nomeUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@loginUsuario", loginUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@senhaUsuario", senhaUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataCadastro", data));
                comandoSql.Parameters.Add(new NpgsqlParameter("@HoraCadastro", HoraCadastro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacao", observacaoUsaurio));
                comandoSql.Parameters.Add(new NpgsqlParameter("@statusUsuario", statusUsuario));
                

                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.
                comandoSql.ExecuteNonQuery();//Executa o código sql.
                ConexaoAcesso.Desconectar();//Fecha a conexão com o banco de dados
                return true;
            }
			catch (Exception ex)
			{
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Usuario. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        } 
   }
}
