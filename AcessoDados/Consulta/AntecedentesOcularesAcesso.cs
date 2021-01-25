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
    public class AntecedentesOcularesAcesso
    {
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        DataTable tableVazia = new DataTable();
        public bool CadastrarAntecedentesOculares(string IDCONSULTA,string TRAUMAOCULAR, string TRAUMAOCULARTRATAMENTO, string CORPOESTRANHO, string CORPOESTRANHOTRATAMENTO, string QUEIMADURAS, string QUEIMADURASTRATAMENTO,
            string CIRURGICOS, string CIRURGICOSTRATAMENTO, string INFLAMACOES, string INFLAMACOESTRATAMENTO, string CATARATA, string CATARATATRATAMENTO, string GLAUCOMA, string GLAUCOMATRATAMENTO,
            string CEGUEIRA, string CEGUEIRATRATAMENTO, string DESCOLAMENTORETINA, string DESCOLAMENTORETINATRATAMENTO, string TOXOPLASMOSE, string TOXOPLASMOSETRATAMENTO, string ESTRABISMO, string ESTRABISMOTRATAMENTO,
            string ALERGICOS, string ALERGICOSTRATAMENTO, string PTERIGIO, string PTERIGIOTRATAMENTO, string DEFEITOSREFRACAO, string DEFEITOSREFRACAOTRATAMENTO, string OUTRO,string OUTROSCONFIRM, string OUTROTRATAMENTO)
        {
            try
            {
                sql.Clear();
                sql.Append("insert into antecedentesOculares(idConsulta,traumaOcular,traumaOcularTratamento,corpoEstranho,corpoEstranhoTratamento,queimaduras,queimadurasTratamento,cirurgicos,cirurgicosTratamento,");
                sql.Append("inflamacoes,inflamacoesTratamento,catarata,catarataTratamento,glaucoma,glaucomaTratamento,cegueira,cegueiraTratamento,descolamentoRetina,descolamentoRetinaTratamento,");
                sql.Append("toxoplasmose,toxoplasmoseTratamento,estrabismo,estrabismoTratamento,alergicos,alergicosTratamento,pterigio,pterigioTratamento,defeitosRefracao,defeitosRefracaoTratamento,");
                sql.Append("outro,outrosConfirm,outroTratamento,deletar)");

                sql.Append("values (\'IDCONSULTA\',\'TRAUMAOCULAR\',\'TRAUMAOCULTRATAMENTO\',\'CORPOESTRANHO\',\'CORPOESTRATRATAMENTO\',\'QUEIMADURAS\',\'QUEIMADUTRATAMENTO\', \'CIRURGICOS\', ");
                sql.Append("\'CIRURGITRATAMENTO\',\'INFLAMACOES\',\'INFLAMACTRATAMENTO\',\'CATARATA\',\'CATARTRATAMENTO\',\'GLAUCOMA\',\'GLAUCTRATAMENTO\',\'CEGUEIRA\', ");
                sql.Append("\'CEGUETRATAMENTO\',\'DESCOLAMENTORETINA\',\'DESCOLAMENTORETTRATAMENTO\',\'TOXOPLASMOSE\',\'TOXOPLASMTRATAMENTO\',\'ESTRABISMO\',\'ESTRABITRATAMENTO\' ");
                sql.Append(",\'ALERGICOS\',\'ALERGITRATAMENTO\',\'PTERIGIO\',\'PTERITRATAMENTO\',\'DEFEITOSREFRACAO\',\'DEFEITOSREFRATRATAMENTO\',");
                sql.Append("\'OUTRO\',\'OUTROSCONFIRM\',\'OUTRATAMENTO\',false)");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                sql = sql.Replace("TRAUMAOCULTRATAMENTO", TRAUMAOCULARTRATAMENTO).Replace("CORPOESTRATRATAMENTO", CORPOESTRANHOTRATAMENTO).Replace("QUEIMADUTRATAMENTO", QUEIMADURASTRATAMENTO);
                sql = sql.Replace("CIRURGITRATAMENTO", CIRURGICOSTRATAMENTO).Replace("INFLAMACTRATAMENTO", INFLAMACOESTRATAMENTO).Replace("CATARTRATAMENTO", CATARATATRATAMENTO);
                sql = sql.Replace("GLAUCTRATAMENTO", GLAUCOMATRATAMENTO).Replace("CEGUETRATAMENTO", CEGUEIRATRATAMENTO).Replace("DESCOLAMENTORETTRATAMENTO", DESCOLAMENTORETINATRATAMENTO);
                sql = sql.Replace("TOXOPLASMTRATAMENTO", TOXOPLASMOSETRATAMENTO).Replace("ESTRABITRATAMENTO", ESTRABISMOTRATAMENTO).Replace("ALERGITRATAMENTO", ALERGICOSTRATAMENTO);
                sql = sql.Replace("PTERITRATAMENTO", PTERIGIOTRATAMENTO).Replace("DEFEITOSREFRATRATAMENTO", DEFEITOSREFRACAOTRATAMENTO).Replace("OUTRATAMENTO", OUTROTRATAMENTO);

                sql = sql.Replace("TRAUMAOCULAR", TRAUMAOCULAR).Replace("CORPOESTRANHO", CORPOESTRANHO).Replace("QUEIMADURAS", QUEIMADURAS).Replace("CIRURGICOS", CIRURGICOS);
                sql = sql.Replace("INFLAMACOES", INFLAMACOES).Replace("CATARATA", CATARATA).Replace("GLAUCOMA", GLAUCOMA).Replace("CEGUEIRA", CEGUEIRA).Replace("DESCOLAMENTORETINA", DESCOLAMENTORETINA);
                sql = sql.Replace("TOXOPLASMOSE", TOXOPLASMOSE).Replace("ESTRABISMO", ESTRABISMO).Replace("ALERGICOS", ALERGICOS).Replace("PTERIGIO", PTERIGIO);
                sql = sql.Replace("DEFEITOSREFRACAO", DEFEITOSREFRACAO).Replace("OUTROSCONFIRM", OUTROSCONFIRM).Replace("OUTRO", OUTRO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro dos antecedentesOculares(Classe AntedecentesOcularesAcesso, Método CadastrarAntecedentesOculares)",
                    "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }

        public bool EditarAntecedentesOculare(string IDCONSULTA, string TRAUMAOCULAR, string TRAUMAOCULARTRATAMENTO, string CORPOESTRANHO, string CORPOESTRANHOTRATAMENTO, string QUEIMADURAS, string QUEIMADURASTRATAMENTO,
          string CIRURGICOS, string CIRURGICOSTRATAMENTO, string INFLAMACOES, string INFLAMACOESTRATAMENTO, string CATARATA, string CATARATATRATAMENTO, string GLAUCOMA, string GLAUCOMATRATAMENTO,
          string CEGUEIRA, string CEGUEIRATRATAMENTO, string DESCOLAMENTORETINA, string DESCOLAMENTORETINATRATAMENTO, string TOXOPLASMOSE, string TOXOPLASMOSETRATAMENTO, string ESTRABISMO, string ESTRABISMOTRATAMENTO,
          string ALERGICOS, string ALERGICOSTRATAMENTO, string PTERIGIO, string PTERIGIOTRATAMENTO, string DEFEITOSREFRACAO, string DEFEITOSREFRACAOTRATAMENTO, string OUTRO,string OUTROSCONFIRM, string OUTROTRATAMENTO)
        {
            try
            {
                sql.Clear();
                sql.Append("UPDATE antecedentesOculares set traumaOcular= \'TRAUMAOCULAR\',traumaOcularTratamento= \'TRAUMAOCULTRATAMENTO\',corpoEstranho= \'CORPOESTRANHO\', ");
                sql.Append("corpoEstranhoTratamento= \'CORPOESTRATRATAMENTO\',queimaduras = \'QUEIMADURAS\',queimadurasTratamento= \'QUEIMADUTRATAMENTO\', ");
                sql.Append("cirurgicos= \'CIRURGICOS\',cirurgicosTratamento= \'CIRURGITRATAMENTO\',inflamacoes= \'INFLAMACOES\',inflamacoesTratamento= \'INFLAMACTRATAMENTO\',");
                sql.Append("catarata= \'CATARATA\',catarataTratamento= \'CATARTRATAMENTO\',glaucoma= \'GLAUCOMA\',glaucomaTratamento= \'GLAUCTRATAMENTO\',cegueira= \'CEGUEIRA\',");
                sql.Append("cegueiraTratamento= \'CEGUETRATAMENTO\',descolamentoRetina= \'DESCOLAMENTORETINA\',descolamentoRetinaTratamento= \'DESCOLAMENTORETTRATAMENTO\', ");
                sql.Append("toxoplasmose= \'TOXOPLASMOSE\',toxoplasmoseTratamento= \'TOXOPLASMTRATAMENTO\',estrabismo= \'ESTRABISMO\',estrabismoTratamento= \'ESTRABITRATAMENTO\', ");
                sql.Append("alergicos= \'ALERGICOS\',alergicosTratamento= \'ALERGITRATAMENTO\',pterigio= \'PTERIGIO\',pterigioTratamento= \'PTERITRATAMENTO\', ");
                sql.Append("defeitosRefracao= \'DEFEITOSREFRACAO\',defeitosRefracaoTratamento= \'DEFEITOSREFRATRATAMENTO\',");
                sql.Append("outro= \'OUTRO\',outrosConfirm = \'OUTROSCONFIRM\',outroTratamento= \'OUTRATAMENTO\' where idConsulta = \'IDCONSULTA\'");

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                sql = sql.Replace("TRAUMAOCULTRATAMENTO", TRAUMAOCULARTRATAMENTO).Replace("CORPOESTRATRATAMENTO", CORPOESTRANHOTRATAMENTO).Replace("QUEIMADUTRATAMENTO", QUEIMADURASTRATAMENTO);
                sql = sql.Replace("CIRURGITRATAMENTO", CIRURGICOSTRATAMENTO).Replace("INFLAMACTRATAMENTO", INFLAMACOESTRATAMENTO).Replace("CATARTRATAMENTO", CATARATATRATAMENTO);
                sql = sql.Replace("GLAUCTRATAMENTO", GLAUCOMATRATAMENTO).Replace("CEGUETRATAMENTO", CEGUEIRATRATAMENTO).Replace("DESCOLAMENTORETTRATAMENTO", DESCOLAMENTORETINATRATAMENTO);
                sql = sql.Replace("TOXOPLASMTRATAMENTO", TOXOPLASMOSETRATAMENTO).Replace("ESTRABITRATAMENTO", ESTRABISMOTRATAMENTO).Replace("ALERGITRATAMENTO", ALERGICOSTRATAMENTO);
                sql = sql.Replace("PTERITRATAMENTO", PTERIGIOTRATAMENTO).Replace("DEFEITOSREFRATRATAMENTO", DEFEITOSREFRACAOTRATAMENTO).Replace("OUTRATAMENTO", OUTROTRATAMENTO);

                sql = sql.Replace("TRAUMAOCULAR", TRAUMAOCULAR).Replace("CORPOESTRANHO", CORPOESTRANHO).Replace("QUEIMADURAS", QUEIMADURAS).Replace("CIRURGICOS", CIRURGICOS);
                sql = sql.Replace("INFLAMACOES", INFLAMACOES).Replace("CATARATA", CATARATA).Replace("GLAUCOMA", GLAUCOMA).Replace("CEGUEIRA", CEGUEIRA).Replace("DESCOLAMENTORETINA", DESCOLAMENTORETINA);
                sql = sql.Replace("TOXOPLASMOSE", TOXOPLASMOSE).Replace("ESTRABISMO", ESTRABISMO).Replace("ALERGICOS", ALERGICOS).Replace("PTERIGIO", PTERIGIO);
                sql = sql.Replace("DEFEITOSREFRACAO", DEFEITOSREFRACAO).Replace("OUTROSCONFIRM", OUTROSCONFIRM).Replace("OUTRO", OUTRO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os antecedentesOculares(Classe AntedecentesOcularesAcesso, Método EditarAntecedentesOculare)",
                    "Erro de atualização/edicao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarAntecedentesOculares(String IDCONSULTA)
        {
            try
            {
                sql.Append("SELECT * FROM AntecedentesOculares WHERE idConsulta = IDCONSULTA AND deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Oculares(Classe AntedecentesOcularesAcesso, Método PesquisarAntecedentesOculares)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
