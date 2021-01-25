using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AcessoDados
{
    public class BiomicroscopiaAcesso
    {
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();

        public bool CadastrarBiomicroscopia(string IDCONSULTA,string SOBRANCELHAOD,string SOBRANCELHAOE, string CILIOOD,string CILIOE, string PALPEBRAOD, string PALPEBRAOE, string CONJUNTIVAOD, 
            string CONJUNTIVAOE,string ESCLEROTICAOD,string ESCLEROTICAOE, string CORNEAOD, string CORNEAOE,string IRISOD, string IRISOE,string CRISTALINOOD, string CRISTALINOOE,
            string CAMARAANTERIOROD, string CAMARAANTERIOROE,string OBSERVACAOBIOMICROSCOPIA)
        {
            try
            {
                sql.Clear();
                sql.Append("INSERT INTO Biomicroscopia(idConsulta,sobrancelhaOd,sobrancelhaOe,cilioOd,cilioOe,palpebraOd,palpebraOe,conjuntivaOd,conjuntivaOe,escleroticaOd,escleroticaOe, ");
                sql.Append("corneaOd,corneaOe,irisOd,irisOe,cristalinoOd,cristalinoOe,camaraAnteriorOd,camaraAnteriorOe,observacaoBiomicroscopia) VALUES(\'IDCONSULTA\',\'SOBRANCELHAOD\', ");
                sql.Append("\'SOBRANCELHAOE\',\'CILIOOD\',\'CILIOOE\',\'PALPEBRAOD\',\'PALPEBRAOE\',\'CONJUNTIVAOD\',\'CONJUNTIVAOE\',\'ESCLEROTICAOD\',\'ESCLEROTICAOE\', ");
                sql.Append("\'CORNEAOD\',\'CORNEAOE\',\'IRISOD\',\'IRISOE\',\'CRISTALINOOD\',\'CRISTALINOOE\',\'CAMARAANTERIOROD\',\'CAMARAANTERIOROE\',\'OBSERVACAOBIOMICROSCOPIA\' )");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("SOBRANCELHAOD", SOBRANCELHAOD).Replace("SOBRANCELHAOE", SOBRANCELHAOE).Replace("CILIOOD", CILIOOD).Replace("CILIOOE", CILIOE);
                sql = sql.Replace("PALPEBRAOD", PALPEBRAOD).Replace("PALPEBRAOE", PALPEBRAOE).Replace("CONJUNTIVAOD", CONJUNTIVAOD).Replace("CONJUNTIVAOE", CONJUNTIVAOE);
                sql = sql.Replace("ESCLEROTICAOD", ESCLEROTICAOD).Replace("ESCLEROTICAOE", ESCLEROTICAOE).Replace("ESCLEREOTICAOE", ESCLEROTICAOE).Replace("CORNEAOD", CORNEAOD);
                sql = sql.Replace("CORNEAOE", CORNEAOE).Replace("IRISOD", IRISOD).Replace("IRISOE", IRISOE).Replace("CRISTALINOOD", CRISTALINOOD).Replace("CRISTALINOOE", CRISTALINOOE);
                sql = sql.Replace("CAMARAANTERIOROD", CAMARAANTERIOROD).Replace("CAMARAANTERIOROE", CAMARAANTERIOROE).Replace("OBSERVACAOBIOMICROSCOPIA", OBSERVACAOBIOMICROSCOPIA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Biomicroscopia(Classe BiomicroscopiaAcesso ,Método CadastrarBiomicroscopia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool AtualizarBiomicroscopia(string IDCONSULTA, string SOBRANCELHAOD, string SOBRANCELHAOE, string CILIOOD, string CILIOE, string PALPEBRAOD, string PALPEBRAOE, string CONJUNTIVAOD,
            string CONJUNTIVAOE, string ESCLEROTICAOD, string ESCLEROTICAOE, string CORNEAOD, string CORNEAOE, string IRISOD, string IRISOE, string CRISTALINOOD, string CRISTALINOOE,
            string CAMARAANTERIOROD, string CAMARAANTERIOROE, string OBSERVACAOBIOMICROSCOPIA)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE biomicroscopia SET sobrancelhaOd = \'SOBRANCELHAOD\',sobrancelhaOe =\'SOBRANCELHAOE\',cilioOd = \'CILIOOD\',cilioOe = \'CILIOE\', palpebraOd = \'PALPEBRAOD\', ");
                sql.Append("palpebraOe = \'PALPEBRAOE\',conjuntivaOd = \'CONJUNTIVAOD\', conjuntivaOe = \'CONJUNTIVAOE\', escleroticaOd = \'ESCLEROTICAOD\',escleroticaOe = \'ESCLEROTICAOE\', ");
                sql.Append("corneaod = \'CORNEAOD\',corneaOe = \'CORNEAOE\',irisOd = \'IRISOD\',irisOe = \'IRISOE\',cristalinoOd = \'CRISTALINOOD\',cristalinoOe = \'CRISTALINOOE\', ");
                sql.Append("camaraAnteriorOd = \'CAMARAANTERIOROD\',camaraAnteriorOe = \'CAMARAANTERIOROE\',observacaoBiomicroscopia = \'OBSERVACAOBIOMICROSCOPIA\' ");
                sql.Append("WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA).Replace("SOBRANCELHAOD", SOBRANCELHAOD).Replace("SOBRANCELHAOE", SOBRANCELHAOE).Replace("CILIOOD", CILIOOD).Replace("CILIOE", CILIOE);
                sql = sql.Replace("PALPEBRAOD", PALPEBRAOD).Replace("PALPEBRAOE", PALPEBRAOE).Replace("CONJUNTIVAOD", CONJUNTIVAOD).Replace("CONJUNTIVAOE", CONJUNTIVAOE);
                sql = sql.Replace("ESCLEROTICAOD", ESCLEROTICAOD).Replace("ESCLEROTICAOD", ESCLEROTICAOD).Replace("ESCLEROTICAOE", ESCLEROTICAOE).Replace("CORNEAOD", CORNEAOD);
                sql = sql.Replace("CORNEAOE", CORNEAOE).Replace("IRISOD", IRISOD).Replace("IRISOE", IRISOE).Replace("CRISTALINOOD", CRISTALINOOD).Replace("CRISTALINOOE", CRISTALINOOE);
                sql = sql.Replace("CAMARAANTERIOROD", CAMARAANTERIOROD).Replace("CAMARAANTERIOROE", CAMARAANTERIOROE).Replace("OBSERVACAOBIOMICROSCOPIA", OBSERVACAOBIOMICROSCOPIA);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Biomicroscopia(Classe BiomicroscopiaAcesso, Método AtualizaBiomicroscopia)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarBiomicroscopia(string IDCONSULTA)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT idConsulta as \"Código Consulta\", sobrancelhaOd as \"Sobrancelha OD\",sobrancelhaOe as \"Sobrancelha OE\",cilioOd as \"Cílio OD\",cilioOe as \"Cílio OE\", ");
                sql.Append("palpebraOd as \"Pálpebra OD\", palpebraOe as \"Pálpebra OE\",ConjuntivaOd as \"Conjuntiva OD\",conjuntivaOe as \"Conjuntiva OE\", escleroticaOd as \"Esclerotica OD\", ");
                sql.Append("escleroticaOe as \"Esclerotica OE\",corneaOd as \"Córnea OD\",corneaOe as \"Córnea OE\",irisOd as \"Íris OD\",irisOe as \"Íris OE\",cristalinoOd as \"Cristalino OD\",  ");
                sql.Append("cristalinoOe as \"Cristalino OE\",camaraAnteriorOd as \"Câmara Anterior OD\",camaraAnteriorOe as \"Câmara Anterior OE\",observacaoBiomicroscopia as ");
                sql.Append("\"Observação Bimicroscopia\" FROM Biomicroscopia WHERE idConsulta = \'IDCONSULTA\' ");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro pesquisar a Biomicroscopia(Classe BiomicroscopiaAcesso, Método PesquisarBiomicroscopia)","Erro de Pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
