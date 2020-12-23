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
    public class ProfissionaisDeletadosAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco AcessoBanco = new Banco();
        public DataTable PesquisarTodosProfissionais()
        {
            try
            {
                sql.Append("SELECT profissional.idProfissional as \"Código\" ,profissional.nomeProfissional as \"Nome\", profissional.CPF as \"CPF\" ");
                sql.Append(", profissional.CROO as \"CROO\", profissional.datanascimento as \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" FROM ");
                sql.Append("profissional INNER JOIN usuario ON usuario.idUsuario = profissional.idUsuarioDeletar WHERE profissional.deletar = true ORDER BY profissional.idProfissional asc");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de pesquisa(Classe ProfissionaisDeletadosAcesso, Método PesquisarTodosProfissionais",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNomeProfissional(string nome)
        {
            try
            { 
                sql.Append("SELECT profissional.idProfissional as \"Código\" ,profissional.nomeProfissional as \"Nome\", profissional.CPF as \"CPF\" ");
                sql.Append(", profissional.CROO as \"CROO\", profissional.datanascimento as \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" FROM ");
                sql.Append("profissional INNER JOIN usuario ON usuario.idUsuario = profissional.idUsuarioDeletar WHERE profissional.deletar = true ");
                sql.Append("AND profissional.nomeProfissional like '%@nome%' ORDER BY profissional.idProfissional asc");
                return AcessoBanco.Pesquisar(sql.Replace("@nome", nome.ToUpper()).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de pesquisa(Classe ProfissionaisDeletadosAcesso, Método PesquisarNomeProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarIdProfissional(string idProfissional)
        {
            try
            {
                sql.Append("SELECT profissional.idProfissional as \"Código\",profissional.nomeProfissional as \"Nome\",profissional.CPF as \"CPF\",profissional.CROO as \"CROO\", ");
                sql.Append("profissional.datanascimento as \"Data Nasc.\",usuario.loginUsuario as \"Usuário\" FROM profissional INNER JOIN usuario ON usuario.idUsuario = ");
                sql.Append("profissional.idUsuarioDeletar  WHERE profissional.deletar = true  and profissional.idProfissional = @idProfissional ");
                return AcessoBanco.Pesquisar(sql.Replace("@idProfissional", idProfissional).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de pesquisa(Classe ProfissionaisDeletadosAcesso, Método PesquisarIdProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCROOProfissional(string CROO)
        {
            try
            {
                sql.Append("SELECT profissional.idProfissional as \"Código\",profissional.nomeProfissional as \"Nome\",profissional.CPF as \"CPF\",profissional.CROO as \"CROO\", ");
                sql.Append("profissional.datanascimento as \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" FROM profissional INNER JOIN usuario ON usuario.idUsuario = ");
                sql.Append("profissional.idUsuarioDeletar  WHERE profissional.deletar = true  and profissional.croo like '%@CROO%' ");
                return AcessoBanco.Pesquisar(sql.Replace("@CROO", CROO).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de pesquisa(Classe ProfissionaisDeletadosAcesso, Método PesquisarCROOProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCPFProfissional(string CPF)
        {
            try
            {
                sql.Append("SELECT profissional.idProfissional \"Código\",profissional.nomeProfissional \"Nome\",profissional.CPF \"CPF\",profissional.CROO \"CROO\", ");
                sql.Append("profissional.datanascimento \"Data Nasc.\",usuario.loginUsuario \"Usuário\"FROM profissional INNER JOIN usuario ON usuario.idUsuario = ");
                sql.Append("profissional.idUsuarioDeletar  WHERE profissional.deletar = true  and profissional.cpf like '%@CPF%' ");
                return AcessoBanco.Pesquisar(sql.Replace("@CPF", CPF).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de pesquisa(Classe ProfissionaisDeletadosAcesso, Método PesquisarCPFProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool DeletarIdProfissional(string idProfissional)
        {
            try
            {
                sql.Append("Delete from profissional where idProfissional = @idProfissional and deletar = true;");
                return AcessoBanco.Executar(sql.Replace("@idProfissional", idProfissional).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de exclusão(Classe ProfissionaisDeletadosAcesso, Método DeletarIdProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarTodosProfissional()
        {
            try
            {
                sql.Append("Delete from profissional where deletar = true ");
                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de exclusão(Classe ProfissionaisDeletadosAcesso, Método DeletarTodosProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarIdProfissional(string idProfissional)
        {
            try
            {
                sql.Append("UPDATE profissional set deletar = false where deletar = true and  idProfissional = @idProfissional ");
                return AcessoBanco.Executar(sql.Replace("@idProfissional", idProfissional).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de restauração(Classe ProfissionaisDeletadosAcesso, Método RestaurarIdProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RestaurarTodosProfissional()
        {
            try
            {
                sql.Append("UPDATE Profissional set deletar = false where deletar = true ");
                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao criar a instrução de restauração(Classe ProfissionaisDeletadosAcesso, Método RestaurarTodosProfissional",
                    "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
