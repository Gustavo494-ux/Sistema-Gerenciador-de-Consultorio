using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Data;

namespace AcessoDados
{
    public class EditarProfissionalAcesso
    {
        public DataTable RetornarDados(int idProfissional)
        {
            DataTable tableVazia = new DataTable();
            DataTable dadosTabela = new DataTable();
            StringBuilder sql = new StringBuilder();
            NpgsqlCommand comandoSql = new NpgsqlCommand();
            try
            {
                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("SELECT profissional.idProfissional,profissional.idEndereco,profissional.idContato,profissional.nomeProfissional,profissional.especialidade,profissional.rg,profissional.cpf,profissional.sexo, ");
                sql.Append("profissional.croo, profissional.dataNascimento, profissional.observacaoProfissional, contato.email, contato.telefone1, contato.telefone2, contato.telefone3, contato.outro, ");
                sql.Append("contato.observacaoContato, endereco.estado, endereco.cidade, endereco.bairro, endereco.rua, endereco.numero, endereco.cep, endereco.pontoReferencia, endereco.observacaoEndereco ");
                sql.Append("FROM profissional INNER JOIN contato on contato.idContato = profissional.idContato INNER JOIN endereco on endereco.idEndereco = profissional.idEndereco ");
                sql.Append("WHERE profissional.idProfissional = @idProfissional AND profissional.deletar = false order by idProfissional asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idProfissional",idProfissional));
                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                dadosTabela.Load(comandoSql.ExecuteReader());
                ConexaoAcesso.Desconectar();
                return dadosTabela;
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar uma pesquisa completa do profissional(Classe EditarProfissionalAcesso, Método RetornarDados)","Erro de Pesquisa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
       public bool Atualizar(int idProfissional, string nomeProfissional, string especialidade, string rg, string cpf,string sexo, string croo, DateTime dataNascimento, string observacaoProfissional)
       {
			try
			{
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                sql.Append("update profissional set nomeProfissional =@nomeProfissional,especialidade = @especialidade, rg = @rg, cpf = @cpf, sexo = @sexo, croo = @croo, ");
                sql.Append("dataNascimento = @dataNascimento, observacaoProfissional = @observacaoProfissional where idProfissional = @idProfissional");

                comandoSql.Parameters.Add(new NpgsqlParameter("@idProfissional",idProfissional));
                comandoSql.Parameters.Add(new NpgsqlParameter("@nomeProfissional", nomeProfissional));
                comandoSql.Parameters.Add(new NpgsqlParameter("@especialidade", especialidade));
                comandoSql.Parameters.Add(new NpgsqlParameter("@rg", rg));
                comandoSql.Parameters.Add(new NpgsqlParameter("@cpf", cpf));
                comandoSql.Parameters.Add(new NpgsqlParameter("@sexo", sexo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@croo", croo));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataNascimento", dataNascimento));
                comandoSql.Parameters.Add(new NpgsqlParameter("@observacaoProfissional", observacaoProfissional));

                comandoSql.Connection = ConexaoAcesso.conn;
                comandoSql.CommandText = sql.ToString();
                comandoSql.ExecuteNonQuery();
                ConexaoAcesso.Desconectar();
                return true;
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe EditarProfissionalAcesso)","Erro de Atualização",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return false;
       }
    }
}
