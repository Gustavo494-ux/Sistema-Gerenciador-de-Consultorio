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
    public class RxInicialAcesso
    {
        Banco acessoBanco = new Banco();
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        public bool CadastrarRxInicial(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE,string OBSERVACAORXINICIAL)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO rxInicial(idConsulta,vlOdEsfera,vlOeEsfera,vpOdEsfera,vpOeEsfera,vlOdCilindro,vlOeCilindro,vpOdCilindro,vpOeCilindro,vlOdEixo,vlOeEixo,vpOdEixo, ");
                sql.Append("vpOeEixo,avVlOd,avVleOe,avVpOd,avVpOe,adicao,tp,tipoMatrial,cor,uso,tipoLente,observacaoRxInicial) values ");
                sql.Append("(\'IDCONSULTA\',\'VLODESFERA\',\'VLOEESFERA\',\'VPODESFERA\',\'VPOEESFERA\',\'VLODCILINDRO\',\'VLOECILINDRO\',\'VPODCILINDRO\',\'VPOECILINDRO\',\'VLODEIXO\', ");
                sql.Append("\'VLOEEIXO\',\'VPODEIXO\',\'VPOEEIXO\',\'AVVLOD\',\'AVVLOE\',\'AVVPOD,AVVPOE\',\'ADICAO\',\'TP\',\'TIPOMATERIAL\',\'COR\',\'USO\',\'TIPOLENTE\',\'OBSERVACAORXINICIAL\')");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO).Replace("VPOECILINDRO", VPOECILINDRO);
                sql = sql.Replace("VLODEIXO", VLODEIXO);
                sql = sql.Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO).Replace("VPOEEIXO", VPOEEIXO).Replace("AVVLOD", AVVLOD).Replace("AVVLOE", AVVLOE);
                sql = sql.Replace("AVVPOD", AVVPOD).Replace("AVVPOE", AVVPOE).Replace("TP", TP).Replace("TIPOMATERIAL", TIPOMATERIAL).Replace("TIPOLENTE", TIPOLENTE);
                sql = sql.Replace("COR", COR).Replace("USO", USO).Replace("OBSERVACAORXINICIAL", OBSERVACAORXINICIAL);

                return acessoBanco.Executar(sql.ToString());

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o rxInicial(Classe RxInicialAcesso, Método CadastrarRxInicial)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool EditarRxInicial(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXINICIAL)
        {
            try
            {

                sql.Append("UPDATE rxInicial set vlOdEsfera= \'VLODESFERA\',vlOeEsfera= \'VLOEESFERA\',vpOdEsfera= \'VPODESFERA\',vpOeEsfera= \'VPOEESFERA\',vlOdCilindro=\'VLODCILINDRO\', ");
                sql.Append("vlOeCilindro= \'VLOECILINDRO\',vpOdCilindro=\'VPODCILINDRO\',vpOeCilindro= \'VPOECILINDRO\',vlOdEixo = \'VLODEIXO\',vlOeEixo= \'VLOEEIXO\',vpOdEixo = \'VPODEIXO\', ");
                sql.Append("vpOeEixo= \'VPOEEIXO\',avVlOd= \'AVVLOD\',avVlOe=\'AVVLOE\',avVpOd=\'AVVPOD\',vlVpOe=\'AVVPOE\',adicao=\'ADICAO\', ");
                sql.Append("tp= \'TP\',tipoMaterial=\'TIPOMATERIAL\',cor=\'COR\',uso=\'USO\',tipoLente=\'TIPOLENTE\',observacaorxInicial=\'OBSERVACAORXINICIAL\' where idConsulta=\'IDCONSULTA\'");


                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO).Replace("VPOECILINDRO", VPOECILINDRO);
                sql = sql.Replace("VLODEIXO", VLODEIXO);
                sql = sql.Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO).Replace("VPOEEIXO", VPOEEIXO).Replace("AVVLOD", AVVLOD).Replace("AVVLOE", AVVLOE);
                sql = sql.Replace("AVVPOD", AVVPOD).Replace("AVVPOE", AVVPOE).Replace("TP", TP).Replace("TIPOMATERIAL", TIPOMATERIAL).Replace("TIPOLENTE", TIPOLENTE);
                sql = sql.Replace("COR", COR).Replace("USO", USO).Replace("OBSERVACAORXINICIAL", OBSERVACAORXINICIAL);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o rxInicial(Classe RxInicialAcesso, Método EditarRxInicial)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public DataTable PesquisarRxInicial(string IDCONSULTA)
        {
            try
            {
                sql.Append("select * from RxInicial ");
                sql.Append("where idConsulta = \'IDCONSULTA\' and deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxInicial(Classe RxInicialAcesso, Método PesquisarRxInicial)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
