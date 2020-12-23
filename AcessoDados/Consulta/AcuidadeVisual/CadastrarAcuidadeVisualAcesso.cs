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
    public class CadastrarAcuidadeVisualAcesso
    {
        public bool CadastrarAcuidadeVisual(string IDCONSULTA,string VLODSG, string VLOESG, string VLAOSG, string VLPH, string VLODCC, string VLOECC, string VLAOCC, string VPODSC, 
            string VPOESC, string VPAOSC, string VPODCC,string VPOECC, string VPAOCC, string TIPOOPTOTIPO)
        {
            Banco AcessoBanco = new Banco();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("insert into acuidadeVisual(idConsulta,vlOdSg,vlOeSg,vlAoSg,vlPh,vlOdCc,vlOeCc,vlAoCc,vpOdSc,vpOeSc,vpAoSc,vpOdCc,vpOeCc,vpAoCc,tipoOptotipo,deletar) ");
                sql.Append("values(\'IDCONSULTA\',\'VLODSG\',\'VLOESG\',\'VLAOSG\',\'VLPH\',\'VLODCC\',\'VLOECC\',\'VLAOCC\',\'VPODSC\',\'VPOESC\',\'VPAOSC\',\'VPODCC\',\'VPOECC\', ");
                sql.Append("\'VPAOCC\',\'TIPOOPTOTIPO\',false)");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODSG", VLODSG).Replace("VLOESG", VLOESG).Replace("VLAOSG", VLAOSG).Replace("VLPH", VLPH);
                sql = sql.Replace("VLODCC", VLODCC).Replace("VLOECC", VLOECC).Replace("VLAOCC", VLAOCC).Replace("VPODSC", VPODSC).Replace("VPOESC", VPOESC);
                sql = sql.Replace("VPAOSC", VPAOSC).Replace("VPODCC", VPODCC).Replace("VPOECC", VPOECC).Replace("VPAOCC", VPAOCC).Replace("TIPOOPTOTIPO", TIPOOPTOTIPO);

                return AcessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Acuidade Visual(Classe CadastrarAcuidadeVisualAcesso, Método CadastrarAcuidadeVisual)", "Erro de Cadastro",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
