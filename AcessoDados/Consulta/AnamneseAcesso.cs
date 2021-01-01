using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class AnamneseAcesso
    {
        StringBuilder sql = new StringBuilder();
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        public bool Cadastrar(string IDCONSULTA, string MOTIVOCONSULTA, string TEMPOQUEIXA, string OBSERVACAOANAMNESE)
        {
			try
			{
                sql.Append("INSERT INTO anamnese(idConsulta,motivoConsulta,tempoQueixa,observacaoAnamnese,deletar) ");
                sql.Append("VALUES (\'IDCONSULTA\',\'MOTIVOCONSULTA\',\'TEMPOQUEIXA\',\'OBSERVACAOANAMNESE\',false); ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("MOTIVOCONSULTA", MOTIVOCONSULTA).Replace("TEMPOQUEIXA", TEMPOQUEIXA).Replace("OBSERVACAOANAMNESE", OBSERVACAOANAMNESE);

                return acessoBanco.Executar(sql.ToString());
			}
			catch (Exception)
			{
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro da Anamnese(Classe AnamneseAcesso, Método Cadastrar)",
                "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return false;
        }
        public bool Atualizar(string IDCONSULTA, string MOTIVOCONSULTA, string TEMPOQUEIXA, string OBSERVACAOANAMNESE)
        {
            try
            {

                sql.Append("UPDATE anamnese SET motivoConsulta = \'MOTIVOCONSULTA\', tempoQueixa = \'TEMPOQUEIXA\', observacaoAnamnese = \'OBSERVACAOANAMNESE\' ");
                sql.Append("WHERE idConsulta = \'IDCONSULTA\' AND deletar = false;");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("MOTIVOCONSULTA", MOTIVOCONSULTA);
                sql = sql.Replace("TEMPOQUEIXA", TEMPOQUEIXA).Replace("OBSERVACAOANAMNESE", OBSERVACAOANAMNESE);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização dos dados da Anamnese(Classe AnamneseAcesso, Método Atualizar)",
                    "Erro de atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarAnamnese(string IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM Anamnese ");
                sql.Append("where idConsulta = IDCONSULTA AND deletar = false;");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                return acessoBanco.Pesquisar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Anamnese(Classe AnamneseAcesso, Método PesquisarAnamnese)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
