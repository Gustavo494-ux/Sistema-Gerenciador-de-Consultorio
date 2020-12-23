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
    public class EditarRxFinalAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool EditarRxFinal(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string VLODADICAO, string VLOEADICAO, string VPODADICAO, string VPOEADICAO, string VLODPRISMA,
            string VLOEPRISMA, string VPODPRISMA, string VPOEPRISMA, string VLODBASE, string VLOEBASE, string VPODBASE, string VPOEBASE, string TIPOLENTE, string MATERIAL, string COR, string ESTADO,
            string OBSERVACAORXFINAL)
        {
            try
            {

                sql.Append("UPDATE rxFinal set vlOdEsfera= \'VLODESFERA\',vlOeEsfera= \'VLOEESFERA\' ,vpOdEsfera= \'VPODESFERA\',vpOeEsfera= \'VPOEESFERA\',vlOdCilindro= \'VLODCILINDRO\', ");
                sql.Append("vlOeCilindro= \'VLOECILINDRO\',vpOdCilindro= \'VPODCILINDRO\',vpOeCilindro= \'VPOECILINDRO\',vlOdEixo = \'VLODEIXO\',vlOeEixo= \'VLOEEIXO\',vpOdEixo = \'VPODEIXO\', ");
                sql.Append("vpOeEixo= \'VPOEEIXO\',vlOdAdicao= \'VLODADICAO\',vlOeAdicao=\'VLODEIXO\',vpOdAdicao=\'VPODADICAO\',vpOeAdicao=\'VPOEADICAO\',vlOdPrisma=\'VLODPRISMA\', ");
                sql.Append("vlOePrisma=\'VLOEPRISMA\',vpOdPrisma=\'VPODPRISMA\',vpOePrisma=\'VPOEPRISMA\',vlOdBase=\'VLODBASE\',vlOeBase=\'VLOEBASE\',");
                sql.Append("vpOdBase=\'VPODBASE\',vpOeBase=\'VPOEBASE\',tipoLente=\'TIPOLENTE\',material=\'MATERIAL\',cor=\'COR\',estado=\'ESTADO\',observacaoRxFinal=\'OBSERVACAORXFINAL\' where ");
                sql.Append("idConsulta=\'IDCONSULTA\'");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO);
                sql = sql.Replace("VPOECILINDRO", VPOECILINDRO).Replace("VLODEIXO", VLODEIXO).Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO);
                sql = sql.Replace("VPOEEIXO", VPOEEIXO).Replace("VLODADICAO", VLODADICAO).Replace("VLOEADICAO", VLOEADICAO).Replace("VPODADICAO", VPODADICAO);
                sql = sql.Replace("VPOEADICAO", VPOEADICAO).Replace("VLODPRISMA", VLODPRISMA).Replace("VLOEPRISMA", VLOEPRISMA).Replace("VPODPRISMA", VPODPRISMA);
                sql = sql.Replace("VPOEPRISMA", VPOEPRISMA).Replace("VLODBASE", VLODBASE).Replace("VLOEBASE", VLOEBASE).Replace("VPODBASE", VPODBASE).Replace("VPOEBASE", VPOEBASE);
                sql = sql.Replace("TIPOLENTE", TIPOLENTE).Replace("MATERIAL", MATERIAL).Replace("COR", COR).Replace("ESTADO", ESTADO).Replace("OBSERVACAORXFINAL", OBSERVACAORXFINAL);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o rxFinal(Classe EditarRxFinalAcesso, Método EditarRxFinal)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
