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
        DataTable dadosTabela = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable TodosProfissionais()
        {
			try
			{
                sql.Clear();
                sql.Append("Select profissional.idProfissional,profissional.nomeProfissional,profissional.especialidade,profissional.croo,usuario.loginUsuario ");
                sql.Append("from profissional inner join usuario on usuario.idUsuario = profissional.idUsuario where profissional.deletar = false and ");
                sql.Append(" usuario.deletar = false order by profissional.idProfissional asc ");
                return acessoBanco.Pesquisar(sql.ToString());
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
                sql.Clear();
                sql.Append("Select profissional.idProfissional,profissional.nomeProfissional,profissional.especialidade,profissional.croo,usuario.loginUsuario ");
                sql.Append("from profissional inner join usuario on usuario.idUsuario = profissional.idUsuario where profissional.deletar = false and ");
                sql.Append(" usuario.deletar = false and profissional.dataNascimento BETWEEN \'DATAINICIAL\' and \'DATAFINAL\' order by profissional.idProfissional asc ");

                sql = sql.Replace("DATAINICIAL",dataInicial.ToString()).Replace("DATAFINAL",dataFinal.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
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
                sql.Clear();
                sql.Append("Select profissional.idProfissional,profissional.nomeProfissional,profissional.especialidade,profissional.croo,usuario.loginUsuario ");
                sql.Append("from profissional inner join usuario on usuario.idUsuario = profissional.idUsuario where profissional.deletar = false and ");
                sql.Append(" usuario.deletar = false and profissional.dataCadastro BETWEEN \'DATAINICIAL\' and \'DATAFINAL\' order by profissional.idProfissional asc");

                sql = sql.Replace("DATAINICIAL", dataInicial.ToString()).Replace("DATAFINAL", dataFinal.ToString());

                return acessoBanco.Pesquisar(sql.ToString());
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
