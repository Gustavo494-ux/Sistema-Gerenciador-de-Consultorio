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
        public bool CadastrarRxFinal(string IDCONSULTA, string ESFERAVLOD, string ESFERAVLOE, string ESFERAVPOD, string ESFERAVPOE, string CILINDROVLOD, string CILINDROVLOE, 
            string CILINDROVPOD,string CILINDROVPOE, string EIXOVLOD, string EIXOVLOE, string EIXOVPOD, string EIXOVPOE, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE,
            string ADICAO,string DP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE,string OBSERVACAORXFINAL)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.Append("INSERT INTO rxFinal(idConsulta,esferaVlOd,esferaVlOe,esferaVpOd,esferaVpOe,cilindroVlOd,cilindroVlOe,cilindroVpOd,cilindroVpOe,eixoVlOd,eixoVlOe, ");
                sql.Append("eixoVpOd,eixoVpOe,avVlOd,avVlOe,avVpOd,avVpOe,adicao,dp,tipoMaterial,cor,uso,tipoLente,observacaoRxFinal) values ");
                sql.Append("(\'IDCONSULTA\',\'ESFERAVLOD\',\'ESFERAVLOE\',\'ESFERAVPOD\',\'ESFERAVPOE\',\'CILINDROVLOD\',\'CILINDROVLOE\',\'CILINDROVPOD\',\'CILINDROVPOE\', ");
                sql.Append("\'EIXOVLOD\',\'EIXOVLOE\',\'EIXOVPOD\',\'EIXOVPOE\',\'AVVLOD\',\'AVVLOE\',\'AVVPOD\',\'AVVPOE\',\'ADICAO\',\'DP\',\'TIPOMATERIAL\',\'COR\',\'USO\', ");
                sql.Append("\'TIPOLENTE\',\'OBSERVACAORXFINAL\')");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("ESFERAVLOD", ESFERAVLOD).Replace("ESFERAVLOE", ESFERAVLOE).Replace("ESFERAVPOD", ESFERAVPOD);
                sql = sql.Replace("ESFERAVPOE", ESFERAVPOE).Replace("CILINDROVLOD", CILINDROVLOD).Replace("CILINDROVLOE", CILINDROVLOE).Replace("CILINDROVPOD", CILINDROVPOD);
                sql = sql.Replace("CILINDROVPOE", CILINDROVPOE).Replace("EIXOVLOD", EIXOVLOD).Replace("EIXOVLOE", EIXOVLOE).Replace("EIXOVPOD", EIXOVPOD).Replace("EIXOVPOE", EIXOVPOE);
                sql = sql.Replace("AVVLOD", AVVLOD).Replace("AVVLOE", AVVLOE).Replace("AVVPOD", AVVPOD).Replace("AVVPOE", AVVPOE).Replace("ADICAO", ADICAO).Replace("DP", DP);
                sql = sql.Replace("TIPOMATERIAL", TIPOMATERIAL).Replace("TIPOLENTE", TIPOLENTE).Replace("COR", COR).Replace("USO", USO).Replace("OBSERVACAORXFINAL", OBSERVACAORXFINAL);

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
            string DP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXFINAL)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE rxFinal set esferaVlOd= \'VLODESFERA\',esferaVlOe= \'VLOEESFERA\',esferaVpOd= \'VPODESFERA\',esferaVpOe= \'VPOEESFERA\', ");
                sql.Append("cilindroVlOd=\'VLODCILINDRO\',cilindroVlOe= \'VLOECILINDRO\',cilindroVpOd=\'VPODCILINDRO\',cilindroVpOe= \'VPOECILINDRO\',eixoVlOd = \'VLODEIXO\', ");
                sql.Append("eixoVlOe= \'VLOEEIXO\',eixoVpOd = \'VPODEIXO\',eixoVpOe= \'VPOEEIXO\',avVlOd= \'AVVLOD\',avVlOe=\'AVVLOE\',avVpOd=\'AVVPOD\',avVpOe=\'AVVPOE\',adicao=\'ADICAO\', ");
                sql.Append("dp= \'DP\',tipoMaterial=\'TIPOMATERIAL\',cor=\'COR\',uso=\'USO\',tipoLente=\'TIPOLENTE\',observacaorxFinal=\'OBSERVACAORXFINAL\' where idConsulta=\'IDCONSULTA\'");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("VLODESFERA", VLODESFERA).Replace("VLOEESFERA", VLOEESFERA).Replace("VPODESFERA", VPODESFERA).Replace("VPOEESFERA", VPOEESFERA);
                sql = sql.Replace("VLODCILINDRO", VLODCILINDRO).Replace("VLOECILINDRO", VLOECILINDRO).Replace("VPODCILINDRO", VPODCILINDRO).Replace("VPOECILINDRO", VPOECILINDRO);
                sql = sql.Replace("VLODEIXO", VLODEIXO).Replace("VLOEEIXO", VLOEEIXO).Replace("VPODEIXO", VPODEIXO).Replace("VPOEEIXO", VPOEEIXO).Replace("AVVLOD", AVVLOD);
                sql = sql.Replace("AVVLOE", AVVLOE).Replace("AVVPOD", AVVPOD).Replace("AVVPOE", AVVPOE).Replace("ADICAO", ADICAO).Replace("DP", DP);
                sql = sql.Replace("TIPOMATERIAL", TIPOMATERIAL).Replace("TIPOLENTE", TIPOLENTE).Replace("COR", COR).Replace("USO", USO).Replace("OBSERVACAORXFINAL", OBSERVACAORXFINAL);

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
                sql.Append("where idConsulta = \'IDCONSULTA\'");

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

