using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class ProfissionalAcesso
    {
        int contato, endereco;

        DataTable dadosTabela = new DataTable();
        public bool Cadastrar(string idProfissional, string idEndereco, string idContato, string idUsuario, string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo,
            string dataNascimento, string dataCadastro, string horaCadastro, string observacaoProfissional)
        {
            try
            {
                ////Chama os métodos que retornam os ultimo id do contato e endereco
                RetornarUltimoIdContato();
                RetornarUltimoIdEndereco();

                //Efetua o tratamento de dados para que possam ser inseridos da maneira correta no banco de dados.
                int usuario = Convert.ToInt32(idUsuario);
                DateTime nascimento= Convert.ToDateTime(dataNascimento), cadastro= Convert.ToDateTime(dataCadastro), HoraCadastro = Convert.ToDateTime(horaCadastro);
                string CPF = cpf.Replace("-", "").Replace(",", "").Replace(".","");

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO profissional(idEndereco, idContato,idUsuario, nomeProfissional, especialidade, rg, cpf");
                sql.Append(",sexo, croo,dataNascimento, dataCadastro, horaCadastro, observacaoProfissional,deletar)");

                sql.Append("VALUES(@idEndereco,@idContato,@idUsuario,@nomeProfissional,@especialidade,@rg,@cpf");
                sql.Append(",@sexo,@croo,@dataNascimento,@dataCadastro,@horaCadastro,@observacaoProfissional,false)");

                //Relaciona cada valor com seu respectivo parametro.
                comandoSql.Parameters.Add(new NpgsqlParameter("@idEndereco", endereco));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idContato", contato));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", usuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeProfissional",nomeProfissional ));
                comandoSql.Parameters.Add(new NpgsqlParameter("@especialidade", especialidade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rg", rg));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf",CPF ));
                comandoSql.Parameters.Add(new NpgsqlParameter("@sexo", sexo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@croo", croo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataNascimento", nascimento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataCadastro", cadastro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@horaCadastro", HoraCadastro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoProfissional", observacaoProfissional));


                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.
                comandoSql.ExecuteNonQuery();//Executa o código sql.
                ConexaoAcesso.Desconectar();//Fecha a conexão com o banco de dados
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Profissional. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Os métodos abaixo retornam respéctivamente o ultimo idEndereco e idContato cadastrados no sistema para serem usados para cadastrar o profissional.
        int RetornarUltimoIdEndereco()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                //Comando sql responsavel por inserir os dados
                sql.Append("select idEndereco from endereco order by idEndereco desc limit 1");

                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.
                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.

                endereco = Convert.ToInt32(comandoSql.ExecuteScalar());
                ConexaoAcesso.Desconectar();
                return endereco;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar retornar o código indentificador do endereço. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        int RetornarUltimoIdContato()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                //Comando sql responsavel por inserir os dados
                sql.Append("select idContato from contato order by idContato desc limit 1");

                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.
                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.

                contato = Convert.ToInt32(comandoSql.ExecuteScalar());
                ConexaoAcesso.Desconectar();
                return contato;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar retornar o código indentificador do endereço. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
    }
}
