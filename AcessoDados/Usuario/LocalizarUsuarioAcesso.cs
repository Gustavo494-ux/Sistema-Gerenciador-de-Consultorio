using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcessoDados
{
    public class LocalizarUsuarioAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
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
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar os usuarios(Classe LocalizarUsuarioAcesso, Método Todos)","",MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar os usuarios(Classe LocalizarUsuarioAcesso, Método Nivel )", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar o usuario(Classe LocalizarUsuarioAcesso, Método Nome)", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar o usuario(classe localizarUsuarioAcesso, Método LoginUsuario)", "Erro de pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
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
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar o usuario(Classe LocalizarUsuarioAcesso, Método Status)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}
