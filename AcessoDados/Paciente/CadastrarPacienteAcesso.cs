using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class CadastrarPacienteAcesso
    {
        int contato;
        int endereco;
        public bool Cadastrar(string idPaciente, string idContato, string idEndereco ,string idUsuario, string nomePaciente, string nomeResponsavel, string rg, string cpf, string ocupacao, string idade,
            string sexo, string dataNascimento, string dataCadastro, string horaCadastro, string observacaoPaciente)
        {
            try
            {
                RetornarUltimoIdContato();
                RetornarUltimoIdEndereco();
                int usuario = Convert.ToInt32(idUsuario);
                string CPF = cpf.Replace("-", "").Replace(",", "").Replace(".", "");
               
                DateTime nascimento = Convert.ToDateTime(dataNascimento), cadastro = Convert.ToDateTime(DateTime.Now.ToShortDateString()),HoraCadastro = Convert.ToDateTime(DateTime.Now.ToLongTimeString());

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();//Abre a conexão com o banco de dados.

                //Comando sql responsavel por inserir os dados
                sql.Append("INSERT INTO paciente(idContato,idEndereco,idUsuario,nomePaciente,nomeResponsavel,rg,cpf,");
                sql.Append(" ocupacao,idade,sexo,dataNascimento,dataCadastro,horaCadastro,observacaoPaciente,deletar,idUsuarioDeletar)");
                
                sql.Append("VALUES(@idContato,@idEndereco,@idUsuario,@nomePaciente,@nomeResponsavel,@rg,@cpf,");
                sql.Append("@ocupacao,@idade,@sexo,@dataNascimento,@dataCadastro,@horaCadastro,@observacaoPaciente,false,0)");

                //Relaciona cada valor com seu respectivo parametro.
                comandoSql.Parameters.Add(new NpgsqlParameter("@idContato", contato));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idEndereco",endereco));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", usuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomePaciente",nomePaciente.ToUpper()));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeResponsavel",nomeResponsavel.ToUpper()));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rg",rg));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf", CPF));
                comandoSql.Parameters.Add(new NpgsqlParameter("@ocupacao",ocupacao));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idade",idade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@sexo",sexo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataNascimento", nascimento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataCadastro", cadastro));
                comandoSql.Parameters.Add(new NpgsqlParameter("horaCadastro", HoraCadastro));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoPaciente", observacaoPaciente));



                comandoSql.CommandText = sql.ToString();// Indica o código sql que vai ser executado.
                comandoSql.Connection = ConexaoAcesso.conn;//Indica a conexão que os comando vão usar.
                comandoSql.ExecuteNonQuery();//Executa o código sql.
                ConexaoAcesso.Desconectar();//Fecha a conexão com o banco de dados
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Paciente. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        //Os métodos abaixo retornam respéctivamente o ultimo idEndereco e idContato cadastrados no sistema para serem usados para cadastrar o paciente.
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
