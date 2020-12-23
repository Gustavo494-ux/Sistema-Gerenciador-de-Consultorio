using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class CadastrarUsuarioRegra
    {
        string senhaEncriptada;
        public bool Cadastrar(string idNivel, string nomeUsuario, string loginUsuario, string senhaUsuario, string confirmacaoSenha, string observacaoUsuario, string statusUsuario)
        {
            try
            {
                if (verificar(idNivel, nomeUsuario,loginUsuario,senhaUsuario,confirmacaoSenha, observacaoUsuario, statusUsuario) == true)
                {
                    CadastrarUsuarioAcesso novoUsuario = new CadastrarUsuarioAcesso();
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
                MessageBox.Show("Ocorreu um erro ao cadastrar o usuario, Error: "+ex.Message+" (Erro na classe CadastrarUsuarioRegra, Método Cadastrar), Caso o Problema persista entre em contato com o suporte! "
                    ,"Erro de Cadastro",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Erro no método de validação das informações de cadastro do Usuario. Error:  " + ex.Message + " Caso o problema persista entre em contato com o suporte!", "Erro na validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
