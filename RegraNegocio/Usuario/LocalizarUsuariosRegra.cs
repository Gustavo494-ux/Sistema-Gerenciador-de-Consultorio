using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class LocalizarUsuariosRegra
    {
        DataTable dadosTabelaRgra;
        DataTable tableVazia;
        public DataTable Todos()
        {
            try
            {
                LocalizarUsuarioAcesso pesquisarUsuario = new LocalizarUsuarioAcesso();
                dadosTabelaRgra = pesquisarUsuario.Todos();

                if (dadosTabelaRgra.Rows.Count > 0) return dadosTabelaRgra;

            }
            catch (Exception ex )
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar pelos usuarios(Classe LocalizarUsuariosRegra, Método Todos)","Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Nivel(string nomeNivel)
        {
            try
            {
                LocalizarUsuarioAcesso pesquisarUsuario = new LocalizarUsuarioAcesso();
                dadosTabelaRgra = pesquisarUsuario.Nivel(nomeNivel);
                if (dadosTabelaRgra.Rows.Count > 0) return dadosTabelaRgra;// MessageBox.Show("Registros não encontrados", "Pesquisa concluida com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe LocalizarUsuariosRegra, Método Nivel)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Login(string nomeLogin)
        {
            try
            {
                LocalizarUsuarioAcesso pesquisarUsuario = new LocalizarUsuarioAcesso();
                dadosTabelaRgra = pesquisarUsuario.login(nomeLogin);
                if (dadosTabelaRgra.Rows.Count > 0)return dadosTabelaRgra; //MessageBox.Show("Registros não encontrados", "Pesquisa concluida com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe LocalizarUsuariosRegra, Método Login)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Nome(string nome)
        {
            try
            {
                LocalizarUsuarioAcesso pesquisarUsuario = new LocalizarUsuarioAcesso();
                dadosTabelaRgra = pesquisarUsuario.Nome(nome);
                if (dadosTabelaRgra.Rows.Count > 0) return dadosTabelaRgra;//MessageBox.Show("Registros não encontrados", "Pesquisa concluida com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe LocalizarUsuariosRegra, Método Nome)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable Status(string status)
        {
            try
            {
                LocalizarUsuarioAcesso pesquisarUsuario = new LocalizarUsuarioAcesso();
                dadosTabelaRgra = pesquisarUsuario.Status(status);
                if (dadosTabelaRgra.Rows.Count > 0) return dadosTabelaRgra;// MessageBox.Show("Registros não encontrados", "Pesquisa concluida com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar pelos usuarios(Classe LocalizarUsuariosRegra, Método Status)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

    }
}
