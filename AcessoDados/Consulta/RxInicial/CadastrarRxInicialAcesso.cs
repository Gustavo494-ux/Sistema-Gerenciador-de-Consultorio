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
    public class CadastrarRxInicialAcesso
    {
        Banco acessoBanco = new Banco();
        public bool CadastrarRxInicial(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string VLODADICAO, string VLOEADICAO, string VPODADICAO, string VPOEADICAO, string VLODPRISMA,
            string VLOEPRISMA, string VPODPRISMA, string VPOEPRISMA, string VLODBASE, string VLOEBASE, string VPODBASE, string VPOEBASE, string TIPOLENTE, string MATERIAL, string COR, string ESTADO,
            string OBSERVACAORXINICIAL)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO rxInicial(idConsulta,vlOdEsfera,vlOeEsfera,vpOdEsfera,vpOeEsfera,vlOdCilindro,vlOeCilindro,vpOdCilindro,vpOeCilindro,vlOdEixo,vlOeEixo,vpOdEixo, ");
                sql.Append("vpOeEixo,vlOdAdicao,vlOeAdicao,vpOdAdicao,vpOeAdicao,vlOdPrisma,vlOePrisma,vpOdPrisma,vpOePrisma,vlOdBase,vlOeBase,vpOdBase,vpOeBase,tipoLente,material,cor, ");
                sql.Append("estado,observacaoRxInicial,deletar) values ");
                sql.Append("(\'IDCONSULTA\',\'VLODESFERA\',\'VLOEESFERA\',\'VPODESFERA\',\'VPOEESFERA\',\'VLODCILINDRO\',\'VLOECILINDRO\',\'VPODCILINDRO\',\'VPOECILINDRO\',\'VLODEIXO\', ");
                sql.Append("\'VLOEEIXO\',\'VPODEIXO\',\'VPOEEIXO\',\'VLODADICAO\',\'VLOEADICAO\',\'VPODADICAO\',\'VPOEADICAO\',\'VLODPRISMA\',\'VLOEPRISMA\',\'VPODPRISMA\',\'VPOEPRISMA\',\'VLODBASE\' ");
                sql.Append(",\'VLOEBASE\',\'VPODBASE\',\'VPOEBASE\',\'TIPOLENTE\',\'MATERIAL\',\'COR\',\'ESTADO\',\'OBSERVACAORXINICIAL\',false); ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO).Replace("VPOECILINDRO", VPOECILINDRO).Replace("VLODEIXO", VLODEIXO);
                sql = sql.Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO).Replace("VPOEEIXO", VPOEEIXO).Replace("VLODADICAO", VLODADICAO).Replace("VLOEADICAO", VLOEADICAO);
                sql = sql.Replace("VPODADICAO", VPODADICAO).Replace("VPOEADICAO", VPOEADICAO).Replace("VLODPRISMA", VLODPRISMA).Replace("VLOEPRISMA", VLOEPRISMA).Replace("VPODPRISMA", VPODPRISMA);
                sql = sql.Replace("VPOEPRISMA", VPOEPRISMA).Replace("VLODBASE", VLODBASE).Replace("VLOEBASE", VLOEBASE).Replace("VPODBASE", VPODBASE).Replace("VPOEBASE", VPOEBASE).Replace("TIPOLENTE", TIPOLENTE);
                sql = sql.Replace("MATERIAL", MATERIAL).Replace("COR", COR).Replace("ESTADO", ESTADO).Replace("OBSERVACAORXINICIAL", OBSERVACAORXINICIAL);

                return acessoBanco.Executar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o rxInicial(Classe CadastrarRxInicialAcesso, Método CadastrarRxInicial)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
