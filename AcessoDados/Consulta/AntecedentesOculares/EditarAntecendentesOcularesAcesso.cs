using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Npgsql;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class EditarAntecendentesOcularesAcesso
    {
        Banco acessoBanco = new Banco();


        public bool EditarAntecedentesOculare(string IDCONSULTA, string TRAUMAOCULAR, string TRAUMAOCULARTRATAMENTO, string CORPOESTRANHO, string CORPOESTRANHOTRATAMENTO, string QUEIMADURAS, string QUEIMADURASTRATAMENTO,
            string CIRURGICOS, string CIRURGICOSTRATAMENTO, string INFLAMACOES, string INFLAMACOESTRATAMENTO, string CATARATA, string CATARATATRATAMENTO, string GLAUCOMA, string GLAUCOMATRATAMENTO,
            string CEGUEIRA, string CEGUEIRATRATAMENTO, string DESCOLAMENTORETINA, string DESCOLAMENTORETINATRATAMENTO, string TOXOPLASMOSE, string TOXOPLASMOSETRATAMENTO, string ESTRABISMO, string ESTRABISMOTRATAMENTO,
            string ALERGICOS, string ALERGICOSTRATAMENTO, string PTERIGIO, string PTERIGIOTRATAMENTO, string DEFEITOSREFRACAO, string DEFEITOSREFRACAOTRATAMENTO, string OUTRO, string OUTROTRATAMENTO)
        {
            try
            {StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE antecedentesOculares set traumaOcular= \'TRAUMAOCULAR\',traumaOcularTratamento= \'TRAUMAOCULTRATAMENTO\',corpoEstranho= \'CORPOESTRANHO\', ");
                sql.Append("corpoEstranhoTratamento= \'CORPOESTRATRATAMENTO\',queimaduras = \'QUEIMADURAS\',queimadurasTratamento= \'QUEIMADUTRATAMENTO\', ");
                sql.Append("cirurgicos= \'CIRURGICOS\',cirurgicosTratamento= \'CIRURGITRATAMENTO\',inflamacoes= \'INFLAMACOES\',inflamacoesTratamento= \'INFLAMACTRATAMENTO\',");
                sql.Append("catarata= \'CATARATA\',catarataTratamento= \'CATARTRATAMENTO\',glaucoma= \'GLAUCOMA\',glaucomaTratamento= \'GLAUCTRATAMENTO\',cegueira= \'CEGUEIRA\',");
                sql.Append("cegueiraTratamento= \'CEGUETRATAMENTO\',descolamentoRetina= \'DESCOLAMENTORETINA\',descolamentoRetinaTratamento= \'DESCOLAMENTORETTRATAMENTO\', ");
                sql.Append("toxoplasmose= \'TOXOPLASMOSE\',toxoplasmoseTratamento= \'TOXOPLASMTRATAMENTO\',estrabismo= \'ESTRABISMO\',estrabismoTratamento= \'ESTRABITRATAMENTO\', ");
                sql.Append("alergicos= \'ALERGICOS\',alergicosTratamento= \'ALERGITRATAMENTO\',pterigio= \'PTERIGIO\',pterigioTratamento= \'PTERITRATAMENTO\', ");
                sql.Append("defeitosRefracao= \'DEFEITOSREFRACAO\',defeitosRefracaoTratamento= \'DEFEITOSREFRATRATAMENTO\',");
                sql.Append("outro= \'OUTRO\',outroTratamento= \'OUTRATAMENTO\' where idConsulta = \'IDCONSULTA\'");

                /*sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                sql = sql.Replace("TRAUMAOCULAR", TRAUMAOCULAR).Replace("TRAUMAOCULARTRATAMENTO", TRAUMAOCULARTRATAMENTO).Replace("CORPOESTRANHO", CORPOESTRANHO);
                sql = sql.Replace("CORPOESTRANHOTRATAMENTO", CORPOESTRANHOTRATAMENTO).Replace("QUEIMADURAS", QUEIMADURAS).Replace("QUEIMADURASTRATAMENTO", QUEIMADURASTRATAMENTO);
                sql = sql.Replace("CIRURGICOS", CIRURGICOS).Replace("CIRURGICOSTRATAMENTO", CIRURGICOSTRATAMENTO).Replace("INFLAMACOES", INFLAMACOES);
                sql = sql.Replace("INFLAMACOESTRATAMENTO", INFLAMACOESTRATAMENTO).Replace("CATARATA", CATARATA).Replace("CATARATATRATAMENTO", CATARATATRATAMENTO);
                sql = sql.Replace("GLAUCOMA", GLAUCOMA).Replace("GLAUCOMATRATAMENTO", GLAUCOMATRATAMENTO).Replace("CEGUEIRA", CEGUEIRA).Replace("CEGUEIRATRATAMENTO", CEGUEIRATRATAMENTO);
                sql = sql.Replace("DESCOLAMENTORETINA", DESCOLAMENTORETINA).Replace("DESCOLAMENTORETINATRATAMENTO", DESCOLAMENTORETINATRATAMENTO).Replace("TOXOPLASMOSE", TOXOPLASMOSE);
                sql = sql.Replace("TOXOPLASMOSETRATAMENTO", TOXOPLASMOSETRATAMENTO).Replace("ESTRABISMO", ESTRABISMO).Replace("ESTRABISMOTRATAMENTO", ESTRABISMOTRATAMENTO);
                sql = sql.Replace("ALERGICOS", ALERGICOS).Replace("ALERGICOSTRATAMENTO", ALERGICOSTRATAMENTO).Replace("PTERIGIO", PTERIGIO).Replace("PTERIGIOTRATAMENTO", PTERIGIOTRATAMENTO);
                sql = sql.Replace("DEFEITOSREFRACAO", DEFEITOSREFRACAO).Replace("DEFEITOSREFRACAOTRATAMENTO", DEFEITOSREFRACAOTRATAMENTO).Replace("OUTRO", OUTRO);
                sql = sql.Replace("OUTROTRATAMENTO", OUTROTRATAMENTO);*/

                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                sql = sql.Replace("TRAUMAOCULTRATAMENTO", TRAUMAOCULARTRATAMENTO).Replace("CORPOESTRATRATAMENTO", CORPOESTRANHOTRATAMENTO).Replace("QUEIMADUTRATAMENTO", QUEIMADURASTRATAMENTO);
                sql = sql.Replace("CIRURGITRATAMENTO", CIRURGICOSTRATAMENTO).Replace("INFLAMACTRATAMENTO", INFLAMACOESTRATAMENTO).Replace("CATARTRATAMENTO", CATARATATRATAMENTO);
                sql = sql.Replace("GLAUCTRATAMENTO", GLAUCOMATRATAMENTO).Replace("CEGUETRATAMENTO", CEGUEIRATRATAMENTO).Replace("DESCOLAMENTORETTRATAMENTO", DESCOLAMENTORETINATRATAMENTO);
                sql = sql.Replace("TOXOPLASMTRATAMENTO", TOXOPLASMOSETRATAMENTO).Replace("ESTRABITRATAMENTO", ESTRABISMOTRATAMENTO).Replace("ALERGITRATAMENTO", ALERGICOSTRATAMENTO);
                sql = sql.Replace("PTERITRATAMENTO", PTERIGIOTRATAMENTO).Replace("DEFEITOSREFRATRATAMENTO", DEFEITOSREFRACAOTRATAMENTO).Replace("OUTRATAMENTO", OUTROTRATAMENTO);

                sql = sql.Replace("TRAUMAOCULAR", TRAUMAOCULAR).Replace("CORPOESTRANHO", CORPOESTRANHO).Replace("QUEIMADURAS", QUEIMADURAS).Replace("CIRURGICOS", CIRURGICOS);
                sql = sql.Replace("INFLAMACOES", INFLAMACOES).Replace("CATARATA", CATARATA).Replace("GLAUCOMA", GLAUCOMA).Replace("CEGUEIRA", CEGUEIRA).Replace("DESCOLAMENTORETINA", DESCOLAMENTORETINA);
                sql = sql.Replace("TOXOPLASMOSE", TOXOPLASMOSE).Replace("ESTRABISMO", ESTRABISMO).Replace("ALERGICOS", ALERGICOS).Replace("PTERIGIO", PTERIGIO);
                sql = sql.Replace("DEFEITOSREFRACAO", DEFEITOSREFRACAO).Replace("OUTRO", OUTRO);

                return acessoBanco.Executar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os antecedentesOculares(Classe EditarAntecendentesOcularesAcesso, Método EditarAntecedentesOculare)",
                    "Erro de atualização/edicao",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
