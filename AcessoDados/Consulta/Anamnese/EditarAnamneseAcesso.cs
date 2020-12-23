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
    public class EditarAnamneseAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
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
                MessageBox.Show("Ocorreu um erro ao realizar uma atualização dos dados da Anamnese(Classe EditarAnamneseAcesso, Método Atualizar)",
                    "Erro de atualização",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
