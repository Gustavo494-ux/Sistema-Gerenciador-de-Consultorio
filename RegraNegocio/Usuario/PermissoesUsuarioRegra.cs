using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    /*Classe sujo objetivo é fazer a validação dos usuarios do sistema afim de liberar acesso ao recursos do sistemas apenas aos usuarios com a devida autorização*/
    public class PermissoesUsuarioRegra
    {
        public bool CadastrarOuEditarProfissional(string idNivel)
        {
            try
            {
                if (Convert.ToInt32(idNivel) < 1) return false;
                if (idNivel == "1" || idNivel == "4") return true; return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar a Autenticação das permissões do usuario(Classe PermissoesUsuarioRegra,Método CadastrarOuEditarProfissional)",
                    "Erro de Autenticação",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        public bool NovaConsulta(string idNivel)
        {
            try
            {
                if (Convert.ToInt32(idNivel) <1)return false;//Código Indentificador do Nivel de Acesso é menor que 1, sendo assim é inválido.
                if (idNivel =="1"||idNivel== "2" || idNivel == "4")return true;return false;//Código Identificador do Nivel de Acesso não é Correspondente ao de um Profissional ou Desenvolvedor
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar efetuar a Autenticação de Usuario(Classe PermissoesUsuarioRegra, Método NovaConsulta)\nErro:\n " + ex.Message ,"Erro de Auntenticação",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        } 
        public bool VisualizarEditarConsulta(string idProfissional,string idProfissionalCadastro)
        {
            try
            {
                if (Convert.ToInt32(idProfissional) > 0 && Convert.ToInt32(idProfissionalCadastro) > 0)
                {
                    if (idProfissionalCadastro == idProfissional)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Você não tem permissão para editar ou ler este registro pois não foi você que criou","Acesso Negado!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("O código identificador do profissional é inválido ou você não possui registro profissional no sistema","Acesso Negado!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar a Autenticação das permissões do usuario(Classe PermissoesUsuarioRegra ,Método VisualizarEditarConsulta)",
                    "Erro de Autenticação",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ControleTotalUsuario(string idNivel)
        {
            try
            {
                if (Convert.ToInt32(idNivel) < 1) return false;//Código Indentificador do Nivel de Acesso é menor que 1, sendo assim é inválido.
                if (idNivel == "1" || idNivel == "4") return true; return false;//Código Identificador do Nivel de Acesso não é correspondente ao de um Administrador ou Desenvolvedor

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao tentar efetuar a Autenticação de Usuario(Classe PermissoesUsuarioRegra, Método ControleTotalUsuario )\nErro:\n " + ex.Message, "Erro de Auntenticação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool EditarProprioUsuario(string idUsuarioSistema,string idUsuarioCadastrado)
        {
            try
            {
                if (idUsuarioCadastrado == idUsuarioSistema)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Não é possivel Editar os dados de outro usuario com seu nivel de acesso!Caso seja necessario editar realmente esse usuario" +
                       " ente em contato com o Administrador do sistema","Acesso Negado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar uma Autenticação de permissões do usuario(Classe PermissoesUsuarioRegra,Método EditarProprioUsuario)", 
                    "Erro de Autenticão de Permissões",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Relatorios(string idNivel)
        {
            try
            {
                if (idNivel == "1" || idNivel == "4")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Você não tem permissão de acessar o gerador de relatorios!","Acesso Negado!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro ao efetuar uma Autenticação de permissões do usuario(Classe PermissoesUsuarioRegra,Método Relatorios)",
                    "Erro de Autenticão de Permissões", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AcessarDadosDeletados(string idNivel)
        {
            try
            {
                //Caso o idNivel seja correspondente ao do desenvolvedor ou do adiminitrador ele terá acesso aos dados deletados caso contrario não terá acesso.
                if (idNivel == "1" || idNivel =="4")return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao efetuar uma Autenticação de permissões do usuario(Classe PermissoesUsuarioRegra,Método AcessarDadosDeletados)",
                   "Erro de Autenticão de Permissões", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
       
    }
}
