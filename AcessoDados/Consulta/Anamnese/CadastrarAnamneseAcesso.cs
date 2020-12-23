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
    public class CadastrarAnamneseAcesso
    {
        StringBuilder sql = new StringBuilder();
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
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro da Anamnese(Classe CadastrarAnamneseAcesso, Método Cadastrar)",
                "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
            return false;
        }
    }
}
