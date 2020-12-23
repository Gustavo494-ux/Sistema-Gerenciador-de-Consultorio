using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AcessoDados
{
    public class LocalizarConsultaAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabelaAcesso = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarUltimoId()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta from consulta ORDER BY idConsulta DESC LIMIT 1");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelas chaves Estrangeiras da consulta(Classe LocalizarConsultaAcesso, Método PesquisarChavesEstrangeiras)", 
                   "erro de pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable TodasConsultas()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("WHERE consulta.deletar = false  order by idConsulta asc ");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarProfissionalAcesso, Método TodasConsultas) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoConsulta(string codigo)//Utilizado para Quando for editar a consulta
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("where consulta.idConsulta = codigo and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.Replace("codigo", codigo).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarConsultaAcesso, Método CodigoConsulta) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(string codPaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("where paciente.idPaciente = codPaciente and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.Replace("codPaciente", codPaciente).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarConsultaAcesso, Método CodigoPaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string nomePaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append("where paciente.nomePaciente like '%"+@nomePaciente+"%' and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarConsultaAcesso, Método NomePaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable cpfPaciente(string cpf)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append(" where paciente.cpf like '%"+@cpf+"%' and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarConsultaAcesso, Método cpfPaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable rgPaciente(string rg)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT consulta.idConsulta, paciente.nomePaciente, profissional.nomeProfissional,consulta.idProfissional,consulta.idUsuario, ");
                sql.Append("usuario.loginUsuario,consulta.origem,consulta.hobbies,consulta.encaminhadoPor,/*consulta*/ consulta.ajudaOpticaPrescrita, ");
                sql.Append("consulta.dataUltimoExame,consulta.transcricaoLentes,consulta.observacaoReceita,consulta.dataConsulta, consulta.horaConsulta, ");
                sql.Append("consulta.statusConsulta, consulta.observacaoConsulta FROM consulta INNER JOIN paciente ON consulta.idPaciente = paciente.idPaciente ");
                sql.Append("INNER JOIN profissional on profissional.idProfissional = consulta.idProfissional INNER JOIN usuario on usuario.idUsuario = consulta.idUsuario ");
                sql.Append(" where paciente.rg like '%"+@rg+"%' and paciente.deletar = false and consulta.deletar = false order by idConsulta asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no método de pesquisa(Classe LocalizarConsultaAcesso, Método rgPaciente) das Consultas, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }


    }
}
