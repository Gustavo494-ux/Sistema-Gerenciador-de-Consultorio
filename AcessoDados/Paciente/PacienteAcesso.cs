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
    public class PacienteAcesso
    {
        int contato;
        int endereco;
        DataTable tableVazia = new DataTable();
        DataTable dadosTabela = new DataTable();
        StringBuilder sql = new StringBuilder();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        Banco acessoBanco = new Banco();
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
        }
        public DataTable RetornarDadosConsulta(int idConslta)
        {
            try
            {
                ConexaoAcesso.Conectar();
                sql.Clear();
                sql.Append("SELECT * FROM paciente INNER JOIN endereco on endereco.idEndereco = ");
                sql.Append("paciente.idEndereco INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario INNER JOIN contato on contato.idContato = paciente.idContato ");
                sql.Append("INNER JOIN consulta on consulta.idpaciente = paciente.idpaciente and consulta.idConsulta = @codigo and paciente.deletar = false");
                comandoSql.Parameters.Add(new NpgsqlParameter("@codigo", idConslta));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa completa do paciente(Classe PacienteAcesso, Método RetornarDadosConsulta)", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int codigo, string paciente, string responsavel, string rg, string cpf, string ocupacao, string idade, string sexo, string dataNascimento, string observacao)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                DateTime nascimento = Convert.ToDateTime(dataNascimento);
                sql.Append("UPDATE paciente SET nomePaciente = @paciente, nomeResponsavel = @responsavel,rg = @rg, cpf= @cpf,ocupacao = @ocupacao, idade = @idade,");
                sql.Append("sexo = @sexo,datanascimento = @nascimento, observacaoPaciente = @observacao WHERE  idPaciente = @codigo");
                comandoSql.Parameters.Add(new NpgsqlParameter("@codigo", codigo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@paciente", paciente));
                comandoSql.Parameters.Add(new NpgsqlParameter("@responsavel", responsavel));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rg", rg));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf", cpf));
                comandoSql.Parameters.Add(new NpgsqlParameter("@ocupacao", ocupacao));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idade", idade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@sexo", sexo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nascimento", nascimento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacao", observacao));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do paciente(Classe PacienteAcesso, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable TodosPacientes()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel,paciente.rg,paciente.cpf, ");
                sql.Append("paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento, paciente.dataCadastro, paciente.horaCadastro, paciente.observacaoPaciente, ");
                sql.Append("usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where paciente.deletar = false  order by idPaciente asc ");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método TodosPacientes) do Paciente, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(int codigo)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM paciente INNER JOIN endereco on endereco.idEndereco = ");
                sql.Append("paciente.idEndereco INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario INNER JOIN contato on contato.idContato = paciente.idContato ");
                sql.Append("and paciente.idPaciente = \'CODIGO\' and paciente.deletar = false  order by idPaciente asc");

                return acessoBanco.Pesquisar(sql.Replace("\'CODIGO\'", Convert.ToString(codigo)).ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método CodigoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string Nome)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel, ");
                sql.Append("paciente.rg,paciente.cpf,paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento,paciente.dataCadastro,paciente.horaCadastro, ");
                sql.Append("paciente.observacaoPaciente, usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("WHERE paciente.nomePaciente LIKE '%" + @Nome + "%' and  paciente.deletar = false order by idPaciente asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método NomePaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfPaciente(string cpf)
        {
            try
            {
                sql.Clear();
                sql.Append("select idPaciente,idContato,idEndereco,paciente.idUsuario, nomePaciente, nomeResponsavel, rg,cpf,ocupacao,idade,sexo,dataNascimento,");
                sql.Append("paciente.dataCadastro,paciente.horaCadastro,observacaoPaciente,usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where cpf LIKE '" + cpf + "%' and paciente.deletar = false order by idPaciente asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método CpfPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgPaciente(string rg)
        {
            try
            {
                sql.Clear();
                sql.Append("select idPaciente,idContato,idEndereco,paciente.idUsuario, nomePaciente, nomeResponsavel, rg,cpf,ocupacao,idade,sexo,dataNascimento,");
                sql.Append("paciente.dataCadastro,paciente.horaCadastro,observacaoPaciente,usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where rg LIKE '" + rg + "%' and paciente.deletar = false order by idPaciente asc");


                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método RgPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public int UltimoPaciente()
        {
            try
            {
                int idPaciente = 0;
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select idPaciente from paciente order by idPaciente desc limit 1");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                var readerData = comandoSql.ExecuteReader();


                while (readerData.Read())
                {
                    idPaciente = Convert.ToInt32(readerData["idPaciente"].ToString());
                }
                ConexaoAcesso.Desconectar();
                return idPaciente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe PacienteAcesso, Método UltimoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        public bool exclusaoLogicaIdPaciente(string idUsuarioSistema, string idPaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("update paciente set deletar = true, idUsuarioDeletar = idUsuarioSistema where idPaciente = codPaciente");
                sql = sql.Replace("codPaciente", idPaciente).Replace("idUsuarioSistema", idUsuarioSistema);
                return acessoBanco.Executar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe PacienteAcesso, Método idPaciente)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool exclusaoLogicaIdUsuario(string idUsuarioSistema, string idUsuarioCadastro)
        {
            try
            {
                sql.Clear();
                sql.Append("update paciente set deletar = true,idUsuarioDeletar = idUsuarioSistema where idUsuario = idUsuarioCadastro");

                sql = sql.Replace("idUsuarioCadastro", idUsuarioCadastro).Replace("idUsuarioSistema", idUsuarioSistema);
                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe DeletarPacienteAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        //Os métodos abaixo retornam respéctivamente o ultimo idEndereco e idContato cadastrados no sistema para serem usados para cadastrar o paciente.
        int RetornarUltimoIdEndereco()
        {
            try
            {
                //Comando sql responsavel por inserir os dados
                sql.Clear();
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
                //Comando sql responsavel por inserir os dados
                sql.Clear();
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
