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
    public class CadastrarRxFinalAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool CadastrarRxFinal(string IDCONSULTA,string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO,string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string VLODADICAO, string VLOEADICAO, string VPODADICAO, string VPOEADICAO, string VLODPRISMA, 
            string VLOEPRISMA, string VPODPRISMA, string VPOEPRISMA, string VLODBASE, string VLOEBASE, string VPODBASE, string VPOEBASE, string TIPOLENTE, string MATERIAL, string COR, string ESTADO,
            string OBSERVACAORXFINAL)
        {
            try
            {
                sql.Append(" insert into rxFinal(idConsulta,vlOdEsfera,vlOeEsfera,vpOdEsfera,vpOeEsfera,vlOdCilindro,vlOeCilindro,vpOdCilindro,vpOeCilindro,vlOdEixo,vlOeEixo,vpOdEixo,vpOeEixo, ");
                sql.Append("vlOdAdicao,vlOeAdicao,vpOdAdicao,vpOeAdicao,vlOdPrisma,vlOePrisma,vpOdPrisma,vpOePrisma,vlOdBase,vlOeBase,vpOdBase,vpOeBase,tipoLente,material,cor,estado, ");
                sql.Append("observacaoRxFinal,deletar) values (\'IDCONSULTA\',\'VLODESFERA\',\'VLOEESFERA\',\'VPODESFERA\',\'VPOEESFERA\',\'VLODCILINDRO\',\'VLOECILINDRO\',\'VPODCILINDRO\', ");
                sql.Append("\'VPOECILINDRO\',\'VLODEIXO\',\'VLOEEIXO\',\'VPODEIXO\',\'VPOEEIXO\',\'VLODADICAO\',\'VLOEADICAO\',\'VPODADICAO\',\'VPOEADICAO\',\'VLODPRISMA\',\'VLOEPRISMA\', ");
                sql.Append("\'VPODPRISMA\',\'VPOEPRISMA\',\'VLODBASE\',\'VLOEBASE\',\'VPODBASE\',\'VPOEBASE\',\'TIPOLENTE\',\'MATERIAL\',\'COR\',\'ESTADO\',\'OBSERVACAORXFINAL\',false);");

                sql = sql.Replace("IDCONSULTA",IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
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
                MessageBox.Show("Ocorreu um erro ao cadastrar o rxFinal(Classe CadastrarRxFinalAcesso, Método CadastrarRxFinal)","Erro de Cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
