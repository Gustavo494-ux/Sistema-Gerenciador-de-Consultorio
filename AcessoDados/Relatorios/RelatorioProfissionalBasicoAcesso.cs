using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;
using System.CodeDom;

namespace AcessoDados
{
    public class RelatorioProfissionalBasicoAcesso
    {
        DataTable tableVazia = new DataTable();
        public DataTable TodosProfissionais()
        {
			try
			{
                DataTable dadosTabela = new DataTable(); 
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("Select profissional.idProfissional,profissional.nomeProfissional,profissional.especialidade,profissional.croo,usuario.loginUsuario ");
                sql.Append("from profissional inner join usuario on usuario.idUsuario = profissional.idUsuario where profissional.deletar = false and ");
                sql.Append(" usuario.deletar = false order by profissional.idProfissional asc ");

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;
                
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de profissional(Classe RelatorioProfissionalBasicoAcesso, Método TodosProfissionais)",
                       "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public DataTable DataNascimentoProfissional(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("Select profissional.idProfissional,profissional.nomeProfissional,profissional.especialidade,profissional.croo,usuario.loginUsuario ");
                sql.Append("from profissional inner join usuario on usuario.idUsuario = profissional.idUsuario where profissional.deletar = false and ");
                sql.Append(" usuario.deletar = false and profissional.dataNascimento BETWEEN @dataInicial and @dataFinal order by profissional.idProfissional asc ");

                comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial",dataInicial));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataFinal",dataFinal));

                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de profissional(Classe RelatorioProfissionalBasicoAcesso, Método DataNascimentoProfissional)",
                       "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }

        public DataTable DataCadastroProfissional(DateTime dataInicial, DateTime dataFinal )
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                StringBuilder sql = new StringBuilder();
                NpgsqlCommand comandoSql = new NpgsqlCommand();

                sql.Append("Select profissional.idProfissional,profissional.nomeProfissional,profissional.especialidade,profissional.croo,usuario.loginUsuario ");
                sql.Append("from profissional inner join usuario on usuario.idUsuario = profissional.idUsuario where profissional.deletar = false and ");
                sql.Append(" usuario.deletar = false and profissional.dataCadastro BETWEEN @dataInicial and @dataFinal order by profissional.idProfissional asc");

                comandoSql.Parameters.Add(new NpgsqlParameter("@dataInicial",dataInicial));
                comandoSql.Parameters.Add(new NpgsqlParameter("@dataFinal",dataFinal));


                ConexaoAcesso.Desconectar();
                ConexaoAcesso.Conectar();

                comandoSql.CommandText = sql.ToString();
                comandoSql.Connection = ConexaoAcesso.conn;
                dadosTabela.Load(comandoSql.ExecuteReader());

                ConexaoAcesso.Desconectar();
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o Relatório de cadastro simples de profissional(Classe RelatorioProfissionalBasicoAcesso, Método DataCadastroProfissional)",
                       "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
