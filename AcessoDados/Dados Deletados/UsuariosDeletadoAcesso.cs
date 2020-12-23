using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados.Dados_Deletados
{
    public class UsuariosDeletadoAcesso
    {
        StringBuilder sql = new StringBuilder();
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();

        public DataTable PesquisarTodosUsuarios()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\", usuario.nomeUsuario as \"Nome\", usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel as \"Nível de Acesso\",usuario.statusUsuario as \"Status\" ");
                sql.Append(",usuarioDeletar.loginUsuario as \"Usuário\" from usuario INNER JOIN usuario as usuarioDeletar on usuarioDeletar.idUsuario = usuario.idUsuarioDeletar INNER JOIN nivelAcesso on ");
                sql.Append("nivelAcesso.idNivelAcesso = usuario.idNivel order by usuario.idUsuario desc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoAcesso, Método PesquisarTodosUsuarios) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNomeUsuario(string nome)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\", usuario.nomeUsuario as \"Nome\", usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel as \"Nível de Acesso\",usuario.statusUsuario as \"Status\" ");
                sql.Append(",usuarioDeletar.loginUsuario as \"Usuário\" from usuario INNER JOIN usuario as usuarioDeletar on usuarioDeletar.idUsuario = usuario.idUsuarioDeletar INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel ");
                sql.Append("WHERE usuario.nomeUsuario like '%nameUser%' ");
                sql.Append("order by usuario.idUsuario desc");

                return acessoBanco.Pesquisar(sql.Replace("nameUser", nome).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoAcesso, Método PesquisarNomeUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCPFUsuario(string CPF)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\", usuario.nomeUsuario as \"Nome\", usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel as \"Nível de Acesso\",usuario.statusUsuario as \"Status\" ");
                sql.Append(",usuarioDeletar.loginUsuario as \"Usuário\" from usuario INNER JOIN usuario as usuarioDeletar on usuarioDeletar.idUsuario = usuario.idUsuarioDeletar INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel ");
                sql.Append("WHERE usuario.rg like '%UserCpf%' ");
                sql.Append("order by usuario.idUsuario desc");

                return acessoBanco.Pesquisar(sql.Replace("UserCpf", CPF).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoAcesso, Método PesquisarCPFUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarRgUsuario(string rg)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\", usuario.nomeUsuario as \"Nome\", usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel as \"Nível de Acesso\",usuario.statusUsuario as \"Status\" ");
                sql.Append(",usuarioDeletar.loginUsuario as \"Usuário\" from usuario INNER JOIN usuario as usuarioDeletar on usuarioDeletar.idUsuario = usuario.idUsuarioDeletar INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel ");
                sql.Append("WHERE usuario.rg like '%UserRG%' ");
                sql.Append("order by usuario.idUsuario desc");

                return acessoBanco.Pesquisar(sql.Replace("UserRG", rg).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoAcesso, Método PesquisarRgUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarStatusUsuario(string statusUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\", usuario.nomeUsuario as \"Nome\", usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel as \"Nível de Acesso\",usuario.statusUsuario as \"Status\" ");
                sql.Append(",usuarioDeletar.loginUsuario as \"Usuário\" from usuario INNER JOIN usuario as usuarioDeletar on usuarioDeletar.idUsuario = usuario.idUsuarioDeletar INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel ");
                sql.Append("WHERE usuario.statususuario =  'UsuarioStatus' ");
                sql.Append("order by usuario.idUsuario desc");

                return acessoBanco.Pesquisar(sql.Replace("UsuarioStatus", statusUsuario).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoAcesso, Método PesquisarStatusUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNivelAcessoUsuario(string codNivelAcesso)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT usuario.idUsuario as \"Código\", usuario.nomeUsuario as \"Nome\", usuario.loginUsuario as \"Login\",nivelAcesso.nomeNivel as \"Nível de Acesso\",usuario.statusUsuario as \"Status\" ");
                sql.Append(",usuarioDeletar.loginUsuario as \"Usuário\" from usuario INNER JOIN usuario as usuarioDeletar on usuarioDeletar.idUsuario = usuario.idUsuarioDeletar INNER JOIN nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel ");
                sql.Append("WHERE usuario.idNivel = codNivelAcesso ");
                sql.Append("order by usuario.idUsuario desc");

                return acessoBanco.Pesquisar(sql.Replace("codNivelAcesso", codNivelAcesso).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoAcesso, Método PesquisarNivelAcessoUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool DeletarIdUsuario(string codUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("delete from usuario WHERE idUsuario = codUsuario AND deletar = true AND idUsuarioDeletar > 0");

                return acessoBanco.Executar(sql.Replace("codUsuario", codUsuario).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Exclusão(Classe UsuariosDeletadoAcesso, Método DeletarIdUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarTodosUsuario()
        {
            try
            {
                sql.Clear();
                sql.Append("delete from usuario WHERE deletar = true AND idUsuarioDeletar > 0");

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Exclusão(Classe UsuariosDeletadoAcesso, Método DeletarTodosUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarIdUsuario(string codUsuario)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE usuario SET deletar = false,idUsuarioDeletar = 0 WHERE deletar = true and idUsuarioDeletar != 0 AND idUsuario = codUsuario");

                return acessoBanco.Executar(sql.Replace("codUsuario", codUsuario).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Restauração(Classe UsuariosDeletadoAcesso, Método RestaurarIdUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarTodosUsuario()
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE usuario SET deletar = false,idUsuarioDeletar = 0 WHERE deletar = true and idUsuarioDeletar != 0;");

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Restauração(Classe UsuariosDeletadoAcesso, Método RestaurarTodosUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
