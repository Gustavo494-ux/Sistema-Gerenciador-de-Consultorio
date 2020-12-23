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
    public class CadastrarAntecedentesGeraisAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool CadastrarAntecentesGerais(string IDCONSULTA,string VASCULARES, string VASCULARESTRATAMENTO, string DIABETES, string DIABETESTRATAMENTO, string IMUNES, string IMUNESTRATAMENTO, string NEUROLOGICOS,
            string NEUROLOGICOSTRATAMENTO, string OUTROS, string OUTROSTRATAMENTO, string OBSERVACAOANTECEDENTESGERAIS)
        {
            try
            {
                sql.Append("INSERT INTO antecedentesGerais(idConsulta,vasculares,vascularTratamento,diabetes,diabetesTratamento,imunes,imunesTratamento,neurologicos,neurologicosTratamento,");
                sql.Append(" outros,outrosTratamento,observacaoAntecedentesGerais,deletar) values(\'IDCONSULTA\',\'VASCULARES\',\'VASCULTRATAMENTO\',\'DIABETES\',\'DIABETTRATAMENTO\', ");
                sql.Append("\'IMUNES\',\'IMUNTRATAMENTO\',\'NEUROLOGICOS\',\'NEUROLOGTRATAMENTO\',\'OUTROS\',\'OUTTRATAMENTO\',\'OBSERVACAOANTECEDENTESGERAIS\',false);");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VASCULARES", VASCULARES).Replace("DIABETES", DIABETES).Replace("IMUNES", IMUNES);
                sql = sql.Replace("NEUROLOGICOS", NEUROLOGICOS).Replace("OUTROS", OUTROS);

                sql = sql.Replace("DIABETTRATAMENTO", DIABETESTRATAMENTO).Replace("IMUNTRATAMENTO", IMUNESTRATAMENTO).Replace("VASCULTRATAMENTO", VASCULARESTRATAMENTO);
                sql = sql.Replace("NEUROLOGTRATAMENTO", NEUROLOGICOSTRATAMENTO).Replace("OUTTRATAMENTO", OUTROSTRATAMENTO).Replace("OBSERVACAOANTECEDENTESGERAIS", OBSERVACAOANTECEDENTESGERAIS);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Gerais(Classe CadastrarAntecedentesGeraisAcesso, Método CadastrarAntecentesGerais)",
                    "Erro de Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
