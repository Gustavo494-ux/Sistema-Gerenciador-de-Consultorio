using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class PacienteDeletadoRegra
    {
        DataTable dadosTabela = new DataTable();
        DataTable tableVazia = new DataTable();

        PacientesDeletadosAcesso pesquisar = new PacientesDeletadosAcesso();
        PacientesDeletadosAcesso deletar = new PacientesDeletadosAcesso();
        public DataTable PesquisarTodosPacientes()
        {
            try
            {
                return dadosTabela = pesquisar.TodosPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacientesDeletadosRegra, Método TodosPacientes) do Paciente , " +
                    "Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCodigoPaciente(int codigo)
        {
            try
            {
                if (codigo > 0)
                {
                    return dadosTabela = pesquisar.CodigoPaciente(codigo);
                }
                else
                {
                    MessageBox.Show("Código Indentificador é inválido, para proseguir com a pesquisa insira um código valido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacientesDeletadosRegra, Método CodigoPaciente) do Paciente atráves do Código Indentificador, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarNomePaciente(string nome)
        {
            try
            {
                if (nome.Length > 0)
                {
                    return dadosTabela = pesquisar.NomePaciente(nome);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacientesDeletadosRegra, Método NomePaciente) do Paciente atráves do nome, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarCpfPaciente(string cpf)
        {
            try
            {
                if (cpf.Length > 0)
                {
                    return dadosTabela = pesquisar.CpfPaciente(cpf);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacientesDeletadosRegra, Método CpfPaciente) do Paciente atráves do CPF, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable PesquisarRgPaciente(string rg)
        {
            try
            {
                if (rg.Length > 0)
                {
                    return dadosTabela = pesquisar.RgPaciente(rg);
                }
                else
                {
                    MessageBox.Show("Nome ausente, para proseguir com a pesquisa insira um Nome.", "Nome Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarPacientesDeletadosRegra, Método RgPacinete) do Paciente atráves do RG, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte! Error: \n\n" + ex.Message, "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool DeletarTodosPacientes()
        {
            try
            {
                return deletar.DeletarTodosPacientes();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente o paciente!Classes PacienteDeletadoRegra, Método DeletarTodosPacientes",
                "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool DeletarIdPaciente(string idPaciente)
        {
            try
            {
                return deletar.DeletarIdPaciente(Convert.ToInt32(idPaciente));
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu algum erro ao deletar fisicamente o paciente!Classes PacienteDeletadoRegra, Método DeletarIdPaciente",
                "Erro de exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool RecuperarTodosPacientes()
        {
            try
            {
                return deletar.RecuperarTodosPacientes();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao restaurar o paciente(Classe PacienteDeletadoRegra, Método RecuperarTodosPacientes)", "Erro de exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
        public bool RecuperarIdPaciente(int idPaciente)
        {
            try
            {

                return deletar.RecuperarIdPaciente(Convert.ToInt32(idPaciente));
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao deletar o paciente(Classe PacienteDeletadoRegra, Método RecuperarIdPaciente)", "Erro de exclusão",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return false;
        }
    }
}
