using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
   public class UsuarioAcesso
   {
        StringBuilder sql = new StringBuilder();
        NpgsqlCommand comandoSql = new NpgsqlCommand();
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string observacaoUsaurio, string statusUsuario)
        {
			try
			{
                //Efetua o tratamento de dados para que possam ser inseridos da maneira correta no banco de dados.
                int nivel = Convert.ToInt32(idNivel);
                DateTime data = Convert.ToDateTime(DateTime.Now.ToShortDateString()), HoraCadastro = Convert.ToDateTime(DateTime.Now.ToLongTimeString());

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
        }
        public DataTable retornarDados(int idUsuario)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.senhaUsuario,nivelAcesso.nomeNivel,usuario.statusUsuario,usuario.observacaoUsuario from usuario ");
                sql.Append("inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where idUsuario = @idUsuario and usuario.deletar = false");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                dadosTabela.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os dados do usuario para serem editados(Classe UsuarioAcesso,metodo retornarDados)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int idUsuario, string nomeUsuario, string loginUsuario, string senhaUsuario, int idNivel, string statusUsuario, string observacaoUsuario)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update usuario set nomeUsuario = @nomeUsuario, loginUsuario= @loginUsuario, senhaUsuario = @senhaUsuario, idNivel = @idNivel, statusUsuario = @statusUsuario,");
                sql.Append("observacaoUsuario = @observacaoUsuario where idUsuario = @idUsuario");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idUsuario", idUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeUsuario", nomeUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@loginUsuario", loginUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@senhaUsuario", senhaUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idNivel", idNivel + 1));
                comandoSql.Parameters.Add(new NpgsqlParameter("@statusUsuario", statusUsuario));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoUsuario", observacaoUsuario));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();

                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a atualização dos dados do usuario(Classe UsuarioAcesso,Método Atualizar)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        //Funções para pesquisar os usuários com diferentes filtros de pesquisa.
        public DataTable Todos()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\",usuario.nomeUsuario as \"Nome\",usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel \"Nível de Acesso\", ");
                sql.Append("usuario.statusUsuario as \"Status\", usuario.dataCadastro as \"Data Cadastro\",usuario.horaCadastro as \"Hora Cadastro\", ");
                sql.Append("usuario.observacaoUsuario as \"Observação\" FROM usuario INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = ");
                sql.Append("usuario.idNivel WHERE usuario.deletar = false order by idUsuario desc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar os usuarios(Classe UsuarioAcesso, Método Todos)", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return tableVazia;
        }
        public DataTable Nivel(string nomeNivel)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\",usuario.nomeUsuario as \"Nome\",usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel \"Nível de Acesso\", ");
                sql.Append("usuario.statusUsuario as \"Status\", usuario.dataCadastro as \"Data Cadastro\",usuario.horaCadastro as \"Hora Cadastro\", ");
                sql.Append("usuario.observacaoUsuario as \"Observação\" FROM usuario INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = ");
                sql.Append("usuario.idNivel where usuario.deletar = false and nivelAcesso.idNivel = COD order by idUsuario asc");

                sql = sql.Replace("COD", nomeNivel);
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar os usuarios(Classe UsuarioAcesso, Método Nivel )", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return tableVazia;
        }
        public DataTable Nome(string nome)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\",usuario.nomeUsuario as \"Nome\",usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel \"Nível de Acesso\", ");
                sql.Append("usuario.statusUsuario as \"Status\", usuario.dataCadastro as \"Data Cadastro\",usuario.horaCadastro as \"Hora Cadastro\", ");
                sql.Append("usuario.observacaoUsuario as \"Observação\" FROM usuario INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = ");
                sql.Append("usuario.idNivel WHERE usuario.deletar = false  usuario.nome like '%UserName%' order by idUsuario desc");

                sql = sql.Replace("UserName", nome);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar o usuario(Classe UsuarioAcesso, Método Nome)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable login(string login)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\",usuario.nomeUsuario as \"Nome\",usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel \"Nível de Acesso\", ");
                sql.Append("usuario.statusUsuario as \"Status\", usuario.dataCadastro as \"Data Cadastro\",usuario.horaCadastro as \"Hora Cadastro\", ");
                sql.Append("usuario.observacaoUsuario as \"Observação\" FROM usuario INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = ");
                sql.Append("usuario.idNivel WHERE usuario.deletar = false AND usuario.loginUsuario like '%userLogin%' order by idUsuario desc");

                sql = sql.Replace("userLogin", login);
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar o usuario(classe UsuarioAcesso, Método LoginUsuario)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Status(string status)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\",usuario.nomeUsuario as \"Nome\",usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel \"Nível de Acesso\", ");
                sql.Append("usuario.statusUsuario as \"Status\", usuario.dataCadastro as \"Data Cadastro\",usuario.horaCadastro as \"Hora Cadastro\", ");
                sql.Append("usuario.observacaoUsuario as \"Observação\" FROM usuario INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = ");
                sql.Append("usuario.idNivel WHERE usuario.deletar = false  and usuario.statusUsuario like '%userStatus%' order by idUsuario desc");

                sql = sql.Replace("userStatus", status);
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar o usuario(Classe UsuarioAcesso, Método Status)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        //Função para deletar lógicamente o usuário
        public bool DeletarUsuario(int idUsuarioSistema, int idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE usuario SET deletar = true,idUsuarioDeletar = CODUSUARIOSISTEMA WHERE idUsuario = IDUSUARIOCADASTRO");
                sql = sql.Replace("IDUSUARIOCADASTRO", idUsuario.ToString()).Replace("CODUSUARIOSISTEMA", idUsuarioSistema.ToString());

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o usuario(Classe UsuarioAcesso, Método idUsuario)", "Erro de deleção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
