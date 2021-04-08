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
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        DataTable dadosTabela = new DataTable();
        public bool Cadastrar(string idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string observacaoUsuario, string statusUsuario)
        {
            try
            {
                string data = DateTime.Now.ToShortDateString(), HoraCadastro = DateTime.Now.ToLongTimeString();
                sql.Clear();
                sql.Append("INSERT INTO usuario(idNivel,nomeUsuario, loginUsuario, senhaUsuario, dataCadastro,horaCadastro, observacaoUsuario, statusUsuario,deletar)");
                sql.Append("VALUES(\'IDNIVEL\',\'NOMEUSUARIO\',\'LOGINUSUARIO\',\'SENHAUSUARIO\',\'DATACADASTRO\',\'HORACADASTRO\',\'OBSERVACAO\',\'STATUSUSUARIO\',false)");

                sql = sql.Replace("IDNIVEL", idNivel).Replace("NOMEUSUARIO", nomeUsuario).Replace("LOGINUSUARIO", loginUsuario).Replace("SENHAUSUARIO", senhaUsuario).Replace("DATACADASTRO", data);
                sql = sql.Replace("HORACADASTRO", HoraCadastro).Replace("OBSERVACAO", observacaoUsuario).Replace("STATUSUSUARIO", statusUsuario);
                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar inserir os dados do Usuario. Error: " + ex.Message + " ,Caso o problema persista entre em contato com o suporte!", "Erro na Inserção",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable retornarDados(int idUsuario)
        {

            try
            {
                sql.Clear();
                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.senhaUsuario,nivelAcesso.nomeNivel,usuario.statusUsuario,usuario.observacaoUsuario from usuario ");
                sql.Append("inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where idUsuario = \'IDUSUARIO\' and usuario.deletar = false");

                sql = sql.Replace("IDUSUARIO", idUsuario.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar os dados do usuario para serem editados(Classe UsuarioAcesso,metodo retornarDados)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int idUsuario, string nomeUsuario, string loginUsuario, string senhaUsuario, int idNivel, string statusUsuario, string observacaoUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("update usuario set nomeUsuario = \'NOMEUSUARIO\', loginUsuario= \'LOGINUSUARIO\', senhaUsuario = \'SENHAUSUARIO\', idNivel = \'IDNIVEL\', statusUsuario = \'STATUSUSUARIO\', ");
                sql.Append("observacaoUsuario = \'OBSERVACAO\' where idUsuario = \'IDUSUARIO\'; ");

                sql = sql.Replace("IDUSUARIO", idUsuario.ToString()).Replace("IDNIVEL", idNivel.ToString()).Replace("NOMEUSUARIO", nomeUsuario).Replace("LOGINUSUARIO", loginUsuario).Replace("SENHAUSUARIO", senhaUsuario);
                sql = sql.Replace("OBSERVACAO", observacaoUsuario).Replace("STATUSUSUARIO", statusUsuario);
                return acessoBanco.Executar(sql.ToString());
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
        //Função que retorna o idProfissional cado algum usuario tenha exatamente o mesmo nome de um profissional.
        public DataTable RetornarIdProfissional(string idUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT profissional.idProfissional,profissional.nomeProfissional FROM Profissional WHERE profissional.NomeProfissional ");
                sql.Append("= (select nomeUsuario from usuario where idUsuario = \'IDUSUARIO\') ");

                sql = sql.Replace("IDUSUARIO", idUsuario);

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao retornar o idProfissional do usuário do sistema,caso seja um profissional(Classe UsuarioAcesso,Método RetornarIdProfissional", "Erro de Verificação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
