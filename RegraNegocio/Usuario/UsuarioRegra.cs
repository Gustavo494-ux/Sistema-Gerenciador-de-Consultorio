using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class UsuarioRegra
    {
        string senhaEncriptada;
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string confirmacaoSenha, string observacaoUsuario, string statusUsuario)
        {
            try
            {
                if (verificar(idNivel, nomeUsuario,loginUsuario,senhaUsuario,confirmacaoSenha, observacaoUsuario, statusUsuario) == true)
                {
                    UsuarioAcesso novoUsuario = new UsuarioAcesso();
                    if (novoUsuario.Cadastrar(idNivel, nomeUsuario, loginUsuario, senhaEncriptada, observacaoUsuario, statusUsuario) == true) return true; return false;
                }
                else
                {
                    MessageBox.Show("Algumas informações de cadastro do usuario são inválidas, tente novamente com informações validas","Informações Inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o usuario, Error: "+ex.Message+ " (Erro na classe UsuarioRegra, Método Cadastrar), Caso o Problema persista entre em contato com o suporte! "
                    , "Erro de Cadastro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool verificar(string idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string confirmacaoSenha, string observacaoUsuario, string statusUsuario)
        {
            try
            {
                if (Convert.ToInt32(idNivel) < 0) return false;
                if (nomeUsuario.Trim().Length <1 || nomeUsuario.Length > 50) return false;

                if (loginUsuario.Trim().Length < 1 || loginUsuario.Length > 20)return false;

                if (senhaUsuario.Trim().Length <1)
                {
                    MessageBox.Show("A Senha de Login do Usuario é muito muito curta" + "Tente novamente com uma informação diferente, Caso o problema persista entre em contato com o suporte!",
                     "Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                if (senhaUsuario.Trim().Length > 1)
                {
                    if (senhaUsuario != confirmacaoSenha)
                    {
                        MessageBox.Show("As Senhas são diferentes" + "Tente novamente com uma informação diferente, Caso o problema persista entre em contato com o suporte!","Informações inválidas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;//Se a senhaUsuario e confirmação senha forem diferentes
                    }
                    else
                    {
                        Criptografar criptografarSenha = new Criptografar();
                        senhaEncriptada = criptografarSenha.EncriptarSenha(senhaUsuario);
                        if (senhaEncriptada.Length != 128)
                        {
                            MessageBox.Show("A senha("+senhaEncriptada+") pode não ter sido encriptada corretamente(Classe CadastrarUsuarioRegra)", "Erro de Encriptação");
                            return false;//Se a encriptada for diferente não tiver 128 caracteres
                        }
                    }
                }

                if (statusUsuario.GetType() != typeof(string) || statusUsuario.Length>15)return false;

                if (observacaoUsuario.GetType() != typeof(string)) return false;

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no método de validação das informações de cadastro do Usuario. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!",
                    "Erro na validação",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable RetornarDados(string idusuario)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            UsuarioAcesso editar = new UsuarioAcesso();

            try
            {
                if (Convert.ToInt32(idusuario) > 0)
                {
                    dadosTabela = editar.retornarDados(Convert.ToInt32(idusuario));
                    if (dadosTabela.Rows.Count > 0) return dadosTabela;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao retornar os dados a serem editados(Classe UsuarioRegra, Método RetornarDados)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int idUsuario, int idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string confirmacaoSenha, string observacaoUsuario, string statusUsuario)
        {
            try
            {
                UsuarioAcesso editar = new UsuarioAcesso();
                Criptografar encriptar = new Criptografar();
                string senhaEncriptada;
                if (idUsuario > 0)
                {
                    if (verificar(Convert.ToString(idNivel), nomeUsuario, loginUsuario, senhaUsuario, confirmacaoSenha, observacaoUsuario, statusUsuario) == true)
                    {
                        /*Se o tamanho da senha for igual a 128 caracteres a mesma já esta criptografada e não é necessario ela passar pela criptografia novamente*/
                        if (senhaUsuario.Length == 128)
                        {
                            bool confirm = editar.Atualizar(idUsuario, nomeUsuario, loginUsuario, senhaUsuario, idNivel, statusUsuario, observacaoUsuario);
                            return confirm;

                        }
                        else
                        {
                            senhaEncriptada = encriptar.EncriptarSenha(senhaUsuario);
                            bool confirm = editar.Atualizar(idUsuario, nomeUsuario, loginUsuario, senhaEncriptada, idNivel, statusUsuario, observacaoUsuario);
                            return confirm;
                        }
                    }

                }
                return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do usuario(Classe UsuarioRegra, Método Atualizar)", "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        //Funções para pesquisar o usuário com diversos filtros.
        public DataTable Todos()
        {
            try
            {
                UsuarioAcesso pesquisarUsuario = new UsuarioAcesso();
                return pesquisarUsuario.Todos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe UsuarioRegra, Método Todos)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Nivel(string nomeNivel)
        {
            try
            {
              UsuarioAcesso pesquisarUsuario = new UsuarioAcesso();
                return pesquisarUsuario.Nivel(nomeNivel);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe UsuarioRegra, Método Nivel)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Login(string nomeLogin)
        {
            try
            {
               UsuarioAcesso pesquisarUsuario = new UsuarioAcesso();
               return pesquisarUsuario.login(nomeLogin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe UsuarioRegra, Método Login)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Nome(string nome)
        {
            try
            {
                UsuarioAcesso pesquisarUsuario = new UsuarioAcesso();
                return pesquisarUsuario.Nome(nome);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe UsuarioRegra, Método Nome)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Status(string status)
        {
            try
            {
                UsuarioAcesso pesquisarUsuario = new UsuarioAcesso();
                return pesquisarUsuario.Status(status);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe LocalizarUsuariosRegra, Método Status)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        //Função para deletar lógicamente o usuário.
        public bool Deletar(string idUsuarioSistema, string idUsuario)
        {
            try
            {
                UsuarioAcesso delUsuario = new UsuarioAcesso();
                if (Convert.ToInt32(idUsuario) > 0)
                {
                    return delUsuario.DeletarUsuario(Convert.ToInt32(idUsuarioSistema), Convert.ToInt32(idUsuario));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o usuario(Classe UsuarioRegra,Método Deletar)", "Erro ao excluir dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
