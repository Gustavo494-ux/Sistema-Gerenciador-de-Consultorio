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
    public class LocalizarPacienteAcesso
    {
        DataTable tableVazia = new DataTable();
        DataTable dadosTabelaAcesso = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable TodosPacientes()
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel,paciente.rg,paciente.cpf, ");
                sql.Append("paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento, paciente.dataCadastro, paciente.horaCadastro, paciente.observacaoPaciente, ");
                sql.Append("usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where paciente.deletar = false  order by idPaciente asc ");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarPacienteAcesso, Método TodosPacientes) do Paciente, " +
                "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CodigoPaciente(int codigo)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel,paciente.rg,paciente.cpf, ");
                sql.Append("paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento, paciente.dataCadastro, paciente.horaCadastro, paciente.observacaoPaciente, ");
                sql.Append("usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("WHERE paciente.idPaciente = codigo and paciente.deletar = false order by paciente.idPaciente asc");

                return acessoBanco.Pesquisar(sql.Replace("codigo",Convert.ToString(codigo)).ToString()); 
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarPacientesAcesso, Método CodigoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable NomePaciente(string Nome)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,paciente.nomePaciente,paciente.nomeResponsavel, ");
                sql.Append("paciente.rg,paciente.cpf,paciente.ocupacao, paciente.idade, paciente.sexo, paciente.dataNascimento,paciente.dataCadastro,paciente.horaCadastro, ");
                sql.Append("paciente.observacaoPaciente, usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("WHERE paciente.nomePaciente LIKE '%" + @Nome + "%' and  paciente.deletar = false order by idPaciente asc");

                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarPacientesAcesso, Método NomePaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable CpfPaciente(string cpf)
        {

            try
            {
                sql.Clear();
                sql.Append("select idPaciente,idContato,idEndereco,paciente.idUsuario, nomePaciente, nomeResponsavel, rg,cpf,ocupacao,idade,sexo,dataNascimento,");
                sql.Append("paciente.dataCadastro,paciente.horaCadastro,observacaoPaciente,usuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where cpf LIKE '" + cpf + "%' and paciente.deletar = false order by idPaciente asc");


                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarPacienteAcesso, Método CpfPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable RgPaciente(string rg)
        {

            try
            {
                sql.Clear();
                sql.Append("select idPaciente,idContato,idEndereco,idUsuario, nomePaciente, nomeResponsavel, rg,cpf,ocupacao,idade,sexo,dataNascimento,");
                sql.Append("dataCadastro,horaCadastro,observacaoPacienteusuario.loginUsuario FROM paciente INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("where rg LIKE '" + rg + "%' and deletar = false order by idPaciente asc");


                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarPacienteAcesso, Método RgPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public int UltimoPaciente()
        {

            try
            {
                int idPaciente =0;
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("select idPaciente from paciente order by idPaciente desc limit 1");

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                var readerData = comandoSql.ExecuteReader();


                while (readerData.Read())
                {
                    idPaciente = Convert.ToInt32(readerData["idPaciente"].ToString());
                }
                ConexaoAcesso.Desconectar();
                return idPaciente;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") no método de pesquisa(Classe LocalizarPacienteAcesso, Método UltimoPaciente) do Paciente, " +
                  "Tente Novamente com uma informação diferente, Caso o Problema persista entre em contato com o suporte!", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
    }
}
