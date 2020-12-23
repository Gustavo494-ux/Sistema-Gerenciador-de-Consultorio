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
    public class EditarAntecedentesGeraisAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool EditarAntecedentesGerais(string IDCONSULTA, string VASCULARES, string VASCULARESTRATAMENTO, string DIABETES, string DIABETESTRATAMENTO, string IMUNES, string IMUNESTRATAMENTO, string NEUROLOGICOS,
            string NEUROLOGICOSTRATAMENTO, string OUTROS, string OUTROSTRATAMENTO, string OBSERVACAOANTECEDENTESGERAIS)
        {
            try
            {

                sql.Append("UPDATE antecedentesGerais SET vasculares = \'VASCULARES\', vascularTratamento = \'VASCULARESTRATAMENTO\', diabetes = \'DIABETES\', diabetesTratamento = \'DIABETESTRATAMENTO\', ");
                sql.Append("imunes = \'IMUNES\', imunesTratamento = \'IMUNESTRATAMENTO\',neurologicos = \'NEUROLOGICOS\', neurologicosTratamento = \'NEUROLOGICOSTRATAMENTO\', outros = \'OUTROS\', ");
                sql.Append("outrosTratamento = \'OUTROSTRATAMENTO\',observacaoAntecedentesGerais = \'OBSERVACAOANTECEDENTESGERAIS\' where idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("VASCULARESTRATAMENTO", VASCULARESTRATAMENTO).Replace("DIABETESTRATAMENTO", DIABETESTRATAMENTO).Replace("IMUNESTRATAMENTO", IMUNESTRATAMENTO);
                sql = sql.Replace("NEUROLOGICOSTRATAMENTO", NEUROLOGICOSTRATAMENTO).Replace("OUTROSTRATAMENTO", OUTROSTRATAMENTO);
                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VASCULARES", VASCULARES).Replace("DIABETES", DIABETES).Replace("IMUNES", IMUNES);
                sql = sql.Replace("NEUROLOGICOS", NEUROLOGICOS).Replace("OUTROS", OUTROS).Replace("OBSERVACAOANTECEDENTESGERAIS", OBSERVACAOANTECEDENTESGERAIS);
               

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os Atecedentes Gerais(Classe EditarAntecedentesGeraisAcesso, Método EditarAntecedentesGerais)",
                    "Erro de atualização/edição",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
