using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;
using System.Data;
using AcessoDados.Dados_Deletados;

namespace RegraNegocio
{
    public class UsuariosDeletadosRegra
    {
        UsuariosDeletadoAcesso usuarioDeletado = new UsuariosDeletadoAcesso();
        DataTable tableVazia = new DataTable();
        public DataTable PesquisarTodosUsuarios()
        {
            try
            {
                return usuarioDeletado.PesquisarTodosUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoRegra, Método PesquisarTodosUsuarios) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNomeUsuario(string nome)
        {
            try
            {
                return usuarioDeletado.PesquisarNomeUsuario(nome);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoRegra, Método PesquisarNomeUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarRgUsuario(string rg)
        {
            try
            {
                return usuarioDeletado.PesquisarRgUsuario(rg);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoRegra, Método PesquisarRgUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCPFUsuario(string CPF)
        {
            try
            {
                return usuarioDeletado.PesquisarCPFUsuario(CPF);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoRegra, Método PesquisarCPFUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarStatusUsuario(string status)
        {
            try
            {
                return usuarioDeletado.PesquisarStatusUsuario(status);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoRegra, Método PesquisarStatusUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNivelAcessoUsuario(string idNivel)
        {
            try
            {
                return usuarioDeletado.PesquisarNivelAcessoUsuario(idNivel);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe UsuariosDeletadoRegra, Método PesquisarNivelAcessoUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool DeletarIdUsuario(string codUsuario)
        {
            try
            {
                return usuarioDeletado.DeletarIdUsuario(codUsuario);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Exclusão(Classe UsuariosDeletadosRegra, Método DeletarIdUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarTodosUsuario()
        {
            try
            {
                return usuarioDeletado.DeletarTodosUsuario();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Exclusão(Classe UsuariosDeletadosRegra, Método DeletarTodosUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarIdUsuario(string codUsuario)
        {
            try
            {
                return usuarioDeletado.RestaurarIdUsuario(codUsuario);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Restauração(Classe UsuariosDeletadosRegra, Método RestaurarIdUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarTodosUsuario()
        {
            try
            {
                return usuarioDeletado.RestaurarTodosUsuario();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de Restauração(Classe UsuariosDeletadosRegra, Método RestaurarTodosUsuario) do Usuário, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

    }
}
