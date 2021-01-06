using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace AcessoDados
{
    public class PacientesDeletadosAcesso
    {
        DataTable tableVazia = new DataTable();
        Banco AcessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();
        public DataTable TodosPacientes()
        {
            try
            {
                sql.Append("SELECT paciente.idPaciente as \"Código\",paciente.nomePaciente as \"Nome\", paciente.cpf as \"CPF\", ");
                sql.Append("paciente.rg as \"RG\", paciente.dataNascimento \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" ");
                sql.Append("FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where paciente.deletar = true  order by idPaciente asc");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacientesDeletadosAcesso, Método TodosPacientes) do Paciente, " +
                    "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;     
        }
        public DataTable CodigoPaciente(int codigo)
        {
            try
            {
                sql.Append("SELECT paciente.idPaciente as \"Código\",paciente.nomePaciente as \"Nome\", paciente.cpf as \"CPF\", ");
                sql.Append("paciente.rg as \"RG\", paciente.dataNascimento \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" ");
                sql.Append("FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("WHERE paciente.idPaciente = @idPaciente and paciente.deletar = true order by paciente.idPaciente asc");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacientesDeletadosAcesso, Método CodigoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string Nome)
        {
            try
            {
                sql.Append("SELECT paciente.idPaciente as \"Código\",paciente.nomePaciente as \"Nome\", paciente.cpf as \"CPF\", ");
                sql.Append("paciente.rg as \"RG\", paciente.dataNascimento \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" ");
                sql.Append("FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("WHERE paciente.nomePaciente LIKE '%" + @Nome + "%' and  paciente.deletar = true order by idPaciente asc");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacientesDeletadosAcesso, Método NomePaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfPaciente(string cpf)
        {
            try
            {
                sql.Append("SELECT paciente.idPaciente as \"Código\",paciente.nomePaciente as \"Nome\", paciente.cpf as \"CPF\", ");
                sql.Append("paciente.rg as \"RG\", paciente.dataNascimento \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" ");
                sql.Append("FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where cpf LIKE '" + @cpf + "%' and paciente.deletar = true order by idPaciente asc");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacientesDeletadosAcesso, Método CpfPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgPaciente(string rg)
        {

            try
            {
                sql.Append("SELECT paciente.idPaciente as \"Código\",paciente.nomePaciente as \"Nome\", paciente.cpf as \"CPF\", ");
                sql.Append("paciente.rg as \"RG\", paciente.dataNascimento \"Data Nasc.\", usuario.loginUsuario as \"Usuário\" ");
                sql.Append("FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where rg LIKE '" + @rg + "%' and paciente.deletar = true order by idPaciente asc");
                return AcessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe PacientesDeletadosAcesso, Método RgPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool DeletarTodosPacientes()
        {
            try
            {
                sql.Append("delete from paciente where deletar = true"); 
                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente o paciente!Classes PacientesDeletadosAcesso, Método DeletarTodosPacientes",
                     "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarIdPaciente(int idPaciente)
        {
            try
            {
                sql.Append("delete from paciente where idPaciente = @idPaciente and deletar = true");
                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente o paciente!Classes PacientesDeletadosAcesso, Método exclusaoFisicaIdPaciente",
                    "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RecuperarTodosPacientes()
        {
            try
            {
                sql.Append("update paciente set deletar = false where deletar = true");
                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao restaurar o paciente(Classe PacientesDeletadosAcesso, Método RecuperarTodosPacientes)", "Erro de exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool RecuperarIdPaciente(int idPaciente)
        {
            try
            {
                sql.Append("update paciente set deletar = false where idPaciente = @idPaciente ");
                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao restaurar o paciente(Classe PacientesDeletadosAcesso, Método RecuperarIdPaciente)", "Erro de exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }

    }
}
