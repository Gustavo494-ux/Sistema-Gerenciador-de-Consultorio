using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;


namespace AcessoDados
{
    public class RelatorioBasicoUsuarioAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabela = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable TodosUsuarios()
        {
            try
            {
                sql.Clear();
                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.dataCadastro,usuario.statusUsuario ");
                sql.Append("from usuario inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where usuario.deletar = false order by usuario.idUsuario asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de usuários(Classe RelatorioBasicoUsuarioAcesso, Método TodosUsuarios)", 
                    "Erro de Pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NivelAcessoUsuario(int idNivel)
        {
            try
            {
                sql.Clear();
                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.dataCadastro,usuario.statusUsuario ");
                sql.Append("from usuario inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where usuario.deletar = false ");
                sql.Append("and nivelAcesso.idNivelAcesso = NIVEL order by usuario.idUsuario asc ");

                sql = sql.Replace("NIVEL",idNivel.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de usuários(Classe RelatorioBasicoUsuarioAcesso, Método NivelAcessoUsuario)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable StatusUsuario(string status)
        {
            try
            {
                sql.Clear();
                sql.Append("select usuario.idUsuario,usuario.nomeUsuario,usuario.loginUsuario,usuario.dataCadastro,usuario.statusUsuario ");
                sql.Append("from usuario inner join nivelAcesso on nivelAcesso.idNivelAcesso = usuario.idNivel where usuario.deletar = false ");
                sql.Append("and usuario.statusUsuario = \'STATUS\' order by usuario.idUsuario asc");
                sql = sql.Replace("STATUS", status);
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o relatório de usuários(Classe RelatorioBasicoUsuarioAcesso, Método StatusUsuario)",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
