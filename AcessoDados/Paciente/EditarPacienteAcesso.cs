using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using Npgsql;
using System.Windows.Forms;

namespace AcessoDados
{
    public class EditarPacienteAcesso
    {
  
        public DataTable RetornarDados(int codigo)
        {
            DataTable dadosTabela = new DataTable();
            DataTable tableVazia = new DataTable();
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
               

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                sql.Append("SELECT paciente.idPaciente,paciente.idContato,paciente.idEndereco,paciente.idUsuario,usuario.loginUsuario,paciente.nomePaciente,paciente.nomeResponsavel, paciente.Rg,paciente.cpf, ");
                sql.Append("paciente.ocupacao,paciente.idade, paciente.sexo, paciente.dataNascimento, paciente.observacaoPaciente,endereco.estado,endereco.cidade, endereco.bairro,endereco.rua,endereco.numero, ");
                sql.Append("endereco.cep,endereco.pontoReferencia,endereco.observacaoEndereco,contato.email,contato.telefone1,contato.telefone2,contato.telefone3,contato.outro,contato.observacaoContato ");
                sql.Append("FROM paciente INNER JOIN endereco on endereco.idEndereco = paciente.idEndereco INNER JOIN usuario on usuario.idUsuario = paciente.idUsuario ");
                sql.Append("INNER JOIN contato on contato.idContato = paciente.idContato and paciente.idPaciente = @codigo and paciente.deletar = false  order by idPaciente asc");
                comandoSql.Parameters.Add(new NpgsqlParameter("@codigo",codigo));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load (comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma pesquisa completa do paciente(Classe EditarPacienteAcesso, Método RetornarDados)", "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public bool Atualizar(int codigo, string paciente,string responsavel, string rg,string cpf, string ocupacao, string idade,string sexo, string dataNascimento, string observacao)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();
                
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();
                DateTime nascimento = Convert.ToDateTime(dataNascimento);
                sql.Append("UPDATE paciente SET nomePaciente = @paciente, nomeResponsavel = @responsavel,rg = @rg, cpf= @cpf,ocupacao = @ocupacao, idade = @idade,");
                sql.Append("sexo = @sexo,datanascimento = @nascimento, observacaoPaciente = @observacao WHERE  idPaciente = @codigo");
                comandoSql.Parameters.Add(new NpgsqlParameter("@codigo", codigo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@paciente",paciente));
                comandoSql.Parameters.Add(new NpgsqlParameter("@responsavel",responsavel));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rg",rg ));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf",cpf));
                comandoSql.Parameters.Add(new NpgsqlParameter("@ocupacao", ocupacao));
                comandoSql.Parameters.Add(new NpgsqlParameter("@idade", idade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@sexo", sexo)); 
                comandoSql.Parameters.Add(new NpgsqlParameter("@nascimento", nascimento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacao", observacao));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização de dados do paciente(Classe EditarPacienteAcesso, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
