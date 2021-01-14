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
    public class RxFinalAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public bool CadastrarRxFinal(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE,string OBSERVACAORXFINAL)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO rxFinal(idConsulta,vlOdEsfera,vlOeEsfera,vpOdEsfera,vpOeEsfera,vlOdCilindro,vlOeCilindro,vpOdCilindro,vpOeCilindro,vlOdEixo,vlOeEixo,vpOdEixo, ");
                sql.Append("vpOeEixo,avVlOd,avVleOe,avVpOd,avVpOe,adicao,tp,tipoMatrial,cor,uso,tipoLente,observacaoRxFinal) values ");
                sql.Append("(\'IDCONSULTA\',\'VLODESFERA\',\'VLOEESFERA\',\'VPODESFERA\',\'VPOEESFERA\',\'VLODCILINDRO\',\'VLOECILINDRO\',\'VPODCILINDRO\',\'VPOECILINDRO\',\'VLODEIXO\', ");
                sql.Append("\'VLOEEIXO\',\'VPODEIXO\',\'VPOEEIXO\',\'AVVLOD\',\'AVVLOE\',\'AVVPOD,AVVPOE\',\'ADICAO\',\'TP\',\'TIPOMATERIAL\',\'COR\',\'USO\',\'TIPOLENTE\',\'OBSERVACAORXFINAL\')");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO).Replace("VPOECILINDRO", VPOECILINDRO);
                sql = sql.Replace("VLODEIXO", VLODEIXO);
                sql = sql.Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO).Replace("VPOEEIXO", VPOEEIXO).Replace("AVVLOD", AVVLOD).Replace("AVVLOE", AVVLOE);
                sql = sql.Replace("AVVPOD", AVVPOD).Replace("AVVPOE", AVVPOE).Replace("TP", TP).Replace("TIPOMATERIAL", TIPOMATERIAL).Replace("TIPOLENTE", TIPOLENTE);
                sql = sql.Replace("COR", COR).Replace("USO", USO).Replace("OBSERVACAORXFINAL", OBSERVACAORXFINAL);

                return acessoBanco.Executar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o rxFinal(Classe RxFinalAcesso, Método CadastrarRxFinal)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool EditarRxFinal(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXFINAL)
        {
            try
            {

                sql.Append("UPDATE rxFinal set vlOdEsfera= \'VLODESFERA\',vlOeEsfera= \'VLOEESFERA\',vpOdEsfera= \'VPODESFERA\',vpOeEsfera= \'VPOEESFERA\',vlOdCilindro=\'VLODCILINDRO\', ");
                sql.Append("vlOeCilindro= \'VLOECILINDRO\',vpOdCilindro=\'VPODCILINDRO\',vpOeCilindro= \'VPOECILINDRO\',vlOdEixo = \'VLODEIXO\',vlOeEixo= \'VLOEEIXO\',vpOdEixo = \'VPODEIXO\', ");
                sql.Append("vpOeEixo= \'VPOEEIXO\',avVlOd= \'AVVLOD\',avVlOe=\'AVVLOE\',avVpOd=\'AVVPOD\',vlVpOe=\'AVVPOE\',adicao=\'ADICAO\', ");
                sql.Append("tp= \'TP\',tipoMaterial=\'TIPOMATERIAL\',cor=\'COR\',uso=\'USO\',tipoLente=\'TIPOLENTE\',observacaorxFinal=\'OBSERVACAORXFINALL\' where idConsulta=\'IDCONSULTA\'");


                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO).Replace("VPOECILINDRO", VPOECILINDRO);
                sql = sql.Replace("VLODEIXO", VLODEIXO);
                sql = sql.Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO).Replace("VPOEEIXO", VPOEEIXO).Replace("AVVLOD", AVVLOD).Replace("AVVLOE", AVVLOE);
                sql = sql.Replace("AVVPOD", AVVPOD).Replace("AVVPOE", AVVPOE).Replace("TP", TP).Replace("TIPOMATERIAL", TIPOMATERIAL).Replace("TIPOLENTE", TIPOLENTE);
                sql = sql.Replace("COR", COR).Replace("USO", USO).Replace("OBSERVACAORXFINAL", OBSERVACAORXFINAL);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o rxFinal(Classe RxFinalAcesso, Método EditarRxFinal)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable PesquisarRxFinal(string IDCONSULTA)
        {
            try
            {
                sql.Append("select * from RxFinal ");
                sql.Append("where idConsulta = \'IDCONSULTA\' and deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxFinal(Classe RxFinalAcesso, Método PesquisarRxFinal)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}

