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

        DataTable tableVazia = new DataTable();
        DataTable dadosTabelaAcesso = new DataTable();
        StringBuilder sql = new StringBuilder();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string idProfissional, string idEndereco, string idContato, string idUsuario, string nomeProfissional, string especialidade, string rg, string cpf, 
            string sexo, string croo,string dataNascimento, string dataCadastro, string horaCadastro,string rodapeReceita, string observacaoProfissional)
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
                sql.Append(",sexo, croo,dataNascimento, dataCadastro, horaCadastro,rodapeReceita, observacaoProfissional,deletar)");

                sql.Append("VALUES(@idEndereco,@idContato,@idUsuario,@nomeProfissional,@especialidade,@rg,@cpf");
                sql.Append(",@sexo,@croo,@dataNascimento,@dataCadastro,@horaCadastro,@rodapeReceita,@observacaoProfissional,false)");

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
                comandoSql.Parameters.Add(new NpgsqlParameter("@rodapeReceita", rodapeReceita));
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
        public DataTable RetornarDados(int idProfissional)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT profissional.idProfissional,profissional.idEndereco,profissional.idContato,profissional.nomeProfissional,profissional.especialidade,profissional.rg,profissional.cpf, ");
                sql.Append("profissional.sexo,profissional.croo, profissional.dataNascimento,profissional.rodapeReceita, profissional.observacaoProfissional, contato.email, contato.telefone1, contato.telefone2, ");
                sql.Append("contato.telefone3, contato.outro,contato.observacaoContato, endereco.estado, endereco.cidade, endereco.bairro, endereco.rua, endereco.numero, endereco.cep, endereco.pontoReferencia, endereco.observacaoEndereco ");
                sql.Append("FROM profissional INNER JOIN contato on contato.idContato = profissional.idContato INNER JOIN endereco on endereco.idEndereco = profissional.idEndereco ");
                sql.Append("WHERE profissional.idProfissional = @idProfissional AND profissional.deletar = false order by idProfissional asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idProfissional", idProfissional));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar uma pesquisa completa do profissional(Classe ProfissionalAcesso, Método RetornarDados)", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int idProfissional, string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo, DateTime dataNascimento,string rodapeReceita,
            string observacaoProfissional)
        {
            try
            {
                ConexaoAcesso.Conectar();
                sql.Clear();
                sql.Append("update profissional set nomeProfissional =@nomeProfissional,especialidade = @especialidade, rg = @rg, cpf = @cpf, sexo = @sexo, croo = @croo, ");
                sql.Append("dataNascimento = @dataNascimento,rodapeReceita =@rodapeReceita, observacaoProfissional = @observacaoProfissional where idProfissional = @idProfissional");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idProfissional", idProfissional));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeProfissional", nomeProfissional));
                comandoSql.Parameters.Add(new NpgsqlParameter("@especialidade", especialidade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rg", rg));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf", cpf));
                comandoSql.Parameters.Add(new NpgsqlParameter("@sexo", sexo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@croo", croo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataNascimento", dataNascimento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rodapeReceita", rodapeReceita));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoProfissional", observacaoProfissional));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe ProfissionalAcesso, Método atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable TodosProfissionais()
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("SELECT * FROM profissional where deletar = false order by idProfissional asc");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método TodosProfissionais) do profissional, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoProfissional(int codigo)
        {
            try
            {
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Clear();
                sql.Append("SELECT * FROM profissional WHERE idProfissional = codProfissional and deletar = false order by idProfissional asc");

                sql = sql.Replace("codProfissional", codigo.ToString()) ;
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método CodigoProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomeProfissional(string nome)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where nomeprofissional LIKE '%" + @nome + "%' and deletar = false order by idProfissional asc");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método NomeProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CPFProfissional(string cpf)
        {

            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where cpf LIKE '%" + cpf + "%' and deletar = false order by idProfissional asc");


                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf", cpf));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método CpfProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgProfissional(string rg)
        {

            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where rg LIKE '" + @rg + "%' and deletar = false order by idProfissional asc");


                comandoSql.Parameters.Add(new NpgsqlParameter("@rg", rg));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método RgProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CrooProfissional(string croo)
        {

            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where croo LIKE '" + @croo + "%' and deletar=false order by idProfissional asc");


                comandoSql.Parameters.Add(new NpgsqlParameter("@croo", croo));
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método CrooProfissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable EspecialidadeProfissional(string especialidade)
        {
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                sql.Append("select * from profissional where especialidade LIKE '%" + especialidade + "%' and deletar = false order by idProfissional asc");
                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabelaAcesso.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabelaAcesso;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe ProfissionalAcesso, Método Profissional) do profissional, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
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
        //Função para deletar o profissional
        public bool idProfissional(int idUsuarioSistema, int idProfissional)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set deletar = true,idUsuarioDeletar = codUsuarioSistema where idProfissional = codProfissional");
                sql = sql.Replace("codProfissional", idProfissional.ToString()).Replace("codUsuarioSistema", idUsuarioSistema.ToString());
                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método idProfissional)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool idUsuario(int idUsuarioSistema, int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("update profissional set deletar = true,idUsuarioDeletar = codUsuarioDeletar where idUsuario = IDUSUARIO");
                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("codUsuarioDeletar", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar a consulta(Classe DeletaConsultaAcesso, Método idUsuario)", "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
