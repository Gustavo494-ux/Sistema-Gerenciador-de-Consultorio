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
    public class EditarAcuidadeVisualAcesso
    {
        Banco acessoBanco = new Banco();
        public bool EditarAcuidadeVisual(string IDCONSULTA, string VLODSG, string VLOESG, string VLAOSG, string VLPH, string VLODCC, string VLOECC, string VLAOCC, string VPODSC,
            string VPOESC, string VPAOSC, string VPODCC, string VPOECC, string VPAOCC, string TIPOOPTOTIPO)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("update acuidadeVisual set vlOdSg = \'VLODSG\', vlOeSg = \'VLOESG\', vlAoSg = \'VLAOSG\', vlPh = \'VLPH\', vlOdCc = \'VLODCC\', vlOeCc = \'VLOECC\', ");
                sql.Append("vlAoCc = \'VLAOCC\', vpOdSc = \'VPODSC\', vpOeSc = \'VPOESC\',vpAoSc = \'VPAOSC\', vpOdCc = \'VPODCC\', vpOeCc = \'VLOECC\', vpAoCc = \'VPAOCC\', ");
                sql.Append("tipoOptotipo = \'TIPOOPTOTIPO\' where idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODSG", VLODSG).Replace("VLOESG", VLOESG).Replace("VLAOSG", VLAOSG).Replace("VLPH", VLPH);
                sql = sql.Replace("VLODCC", VLODCC).Replace("VLOECC", VLOECC).Replace("VLAOCC", VLAOCC).Replace("VPODSC", VPODSC).Replace("VPOESC", VPOESC);
                sql = sql.Replace("VPAOSC", VPAOSC).Replace("VPODCC", VPODCC).Replace("VPOECC", VPOECC).Replace("VPAOCC", VPAOCC).Replace("TIPOOPTOTIPO", TIPOOPTOTIPO);

                acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Acuidade Visual(Classe EditarAcuidadeVisualAcesso, Método EditarAcuidadeVisual)", "Erro de atualização/edição"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            return false;
        }
    }
}
