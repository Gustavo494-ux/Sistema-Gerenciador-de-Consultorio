using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;
using System.Data;

namespace RegraNegocio
{
    public class AntecedentesOcularesRegra
    {
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string idConsulta,bool traumaOcular, string traumaOcularTratamento, bool corpoEstranho, string corpoEstranhoTratamento, bool queimaduras, string queimadurasTratamento,
            bool cirurgicos, string cirurgicosTratamento, bool inflamacoes, string inflamacoesTratamento, bool catarata, string catarataTratamento, bool glaucoma, string glaucomaTratamento,
            bool cegueira, string cegueiraTratamento, bool descolamentoRetina, string descolamentoRetinaTratamento, bool toxoplasmose, string toxoplasmoseTratamento, bool estrabismo, string estrabismoTratamento,
            bool alergicos, string alergicosTratamento, bool pterigio, string pterigioTratamento, bool defeitosRefracao, string defeitosRefracaoTratamento, string outro, string outroTratamento)
        {
            try
            {
                if (Validar(traumaOcular, traumaOcularTratamento, corpoEstranho, corpoEstranhoTratamento, queimaduras, queimadurasTratamento, cirurgicos, cirurgicosTratamento, inflamacoes, inflamacoesTratamento, catarata,
                catarataTratamento, glaucoma, glaucomaTratamento, cegueira, cegueiraTratamento, descolamentoRetina, descolamentoRetinaTratamento, toxoplasmose, toxoplasmoseTratamento, estrabismo, estrabismoTratamento,
                alergicos, alergicosTratamento, pterigio, pterigioTratamento, defeitosRefracao, defeitosRefracaoTratamento, outro, outroTratamento) == true)
                {
                    AntecedentesOcularesAcesso cadastrarAcesso = new AntecedentesOcularesAcesso();
                    if (cadastrarAcesso.CadastrarAntecedentesOculares(idConsulta, Convert.ToString(traumaOcular), traumaOcularTratamento, Convert.ToString(corpoEstranho), corpoEstranhoTratamento,
                        Convert.ToString(queimaduras), queimadurasTratamento, Convert.ToString(cirurgicos), cirurgicosTratamento, Convert.ToString(inflamacoes), inflamacoesTratamento, 
                        Convert.ToString(catarata),catarataTratamento, Convert.ToString(glaucoma), glaucomaTratamento, Convert.ToString(cegueira), cegueiraTratamento,
                        Convert.ToString(descolamentoRetina), descolamentoRetinaTratamento,Convert.ToString(toxoplasmose),toxoplasmoseTratamento, Convert.ToString(estrabismo), estrabismoTratamento,
                        Convert.ToString(alergicos), alergicosTratamento, Convert.ToString(pterigio), pterigioTratamento, Convert.ToString(defeitosRefracao), defeitosRefracaoTratamento, outro, 
                        outroTratamento) == true) return true;return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Oculares(Classe AntecedentesOcularesRegra, Método Cadastrar)", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Validar(bool traumaOcular, string traumaOcularTratamento, bool corpoEstranho, string corpoEstranhoTratamento, bool queimaduras, string queimadurasTratamento,
           bool cirurgicos, string cirurgicosTratamento, bool inflamacoes, string inflamacoesTratamento, bool catarata, string catarataTratamento, bool glaucoma, string glaucomaTratamento,
           bool cegueira, string cegueiraTratamento, bool descolamentoRetina, string descolamentoRetinaTratamento, bool toxoplasmose, string toxoplasmoseTratamento, bool estrabismo, string estrabismoTratamento,
           bool alergicos, string alergicosTratamento, bool pterigio, string pterigioTratamento, bool defeitosRefracao, string defeitosRefracaoTratamento, string outro, string outroTratamento)
        {
            try
            {
                if (traumaOcular.GetType() != typeof(bool)) return false;
                if (traumaOcularTratamento.GetType() != typeof(string) || traumaOcularTratamento.Length > 100) return false;

                if (corpoEstranho.GetType() != typeof(bool)) return false;
                if (corpoEstranhoTratamento.GetType() != typeof(string) || corpoEstranhoTratamento.Length > 100) return false;

                if (queimaduras.GetType() != typeof(bool)) return false;
                if (queimadurasTratamento.GetType() != typeof(string) || queimadurasTratamento.Length > 100) return false;


                if (cirurgicos.GetType() != typeof(bool)) return false;
                if (cirurgicosTratamento.GetType() != typeof(string) || cirurgicosTratamento.Length > 100) return false;

                if (inflamacoes.GetType() != typeof(bool)) return false;
                if (inflamacoesTratamento.GetType() != typeof(string) || inflamacoesTratamento.Length > 100) return false;

                if (catarata.GetType() != typeof(bool)) return false;
                if (catarataTratamento.GetType() != typeof(string) || catarataTratamento.Length > 100) return false;


                if (glaucoma.GetType() != typeof(bool)) return false;
                if (glaucomaTratamento.GetType() != typeof(string) || glaucomaTratamento.Length > 100) return false;

                if (cegueira.GetType() != typeof(bool)) return false;
                if (cegueiraTratamento.GetType() != typeof(string) || cegueiraTratamento.Length > 100) return false;

                if (descolamentoRetina.GetType() != typeof(bool)) return false;
                if (descolamentoRetinaTratamento.GetType() != typeof(string) || descolamentoRetinaTratamento.Length > 100) return false;

                if (toxoplasmose.GetType() != typeof(bool)) return false;
                if (toxoplasmoseTratamento.GetType() != typeof(string) || toxoplasmoseTratamento.Length > 100) return false;

                if (estrabismo.GetType() != typeof(bool)) return false;
                if (estrabismoTratamento.GetType() != typeof(string) || estrabismoTratamento.Length > 100) return false;

                if (alergicos.GetType() != typeof(bool)) return false;
                if (alergicosTratamento.GetType() != typeof(string) || alergicosTratamento.Length > 100) return false;

                if (pterigio.GetType() != typeof(bool)) return false;
                if (pterigioTratamento.GetType() != typeof(string) || pterigioTratamento.Length > 100) return false;

                if (defeitosRefracao.GetType() != typeof(bool)) return false;
                if (defeitosRefracaoTratamento.GetType() != typeof(string) || defeitosRefracaoTratamento.Length > 100) return false;

                if (outro.GetType() != typeof(string) || outro.Length>100) return false;
                if (outroTratamento.GetType() != typeof(string) || outroTratamento.Length > 100) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar os Antecedentes Oculares(Classe AntecedentesOcularesRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Editar(int idAntecedentesOculares, bool traumaOcular, string traumaOcularTratamento, bool corpoEstranho, string corpoEstranhoTratamento, bool queimaduras, string queimadurasTratamento,
           bool cirurgicos, string cirurgicosTratamento, bool inflamacoes, string inflamacoesTratamento, bool catarata, string catarataTratamento, bool glaucoma, string glaucomaTratamento,
           bool cegueira, string cegueiraTratamento, bool descolamentoRetina, string descolamentoRetinaTratamento, bool toxoplasmose, string toxoplasmoseTratamento, bool estrabismo, string estrabismoTratamento,
           bool alergicos, string alergicosTratamento, bool pterigio, string pterigioTratamento, bool defeitosRefracao, string defeitosRefracaoTratamento, string outro, string outroTratamento)
        {
            try
            {
                if (Validar(traumaOcular, traumaOcularTratamento, corpoEstranho, corpoEstranhoTratamento, queimaduras, queimadurasTratamento, cirurgicos, cirurgicosTratamento, inflamacoes,
                    inflamacoesTratamento, catarata, catarataTratamento, glaucoma, glaucomaTratamento, cegueira, cegueiraTratamento, descolamentoRetina, descolamentoRetinaTratamento, toxoplasmose, toxoplasmoseTratamento,
                    estrabismo, estrabismoTratamento, alergicos, alergicosTratamento, pterigio, pterigioTratamento, defeitosRefracao, defeitosRefracaoTratamento, outro, outroTratamento) == true)
                {
                    AntecedentesOcularesAcesso EditarAcesso = new AntecedentesOcularesAcesso();
                    if (EditarAcesso.EditarAntecedentesOculare(Convert.ToString(idAntecedentesOculares), Convert.ToString(traumaOcular), traumaOcularTratamento, Convert.ToString(corpoEstranho),
                        corpoEstranhoTratamento, Convert.ToString(queimaduras), queimadurasTratamento, Convert.ToString(cirurgicos), cirurgicosTratamento, Convert.ToString(inflamacoes),
                        inflamacoesTratamento, Convert.ToString(catarata), catarataTratamento, Convert.ToString(glaucoma), glaucomaTratamento, Convert.ToString(cegueira), cegueiraTratamento,
                        Convert.ToString(descolamentoRetina), descolamentoRetinaTratamento, Convert.ToString(toxoplasmose), toxoplasmoseTratamento, Convert.ToString(estrabismo), estrabismoTratamento,
                        Convert.ToString(alergicos), alergicosTratamento, Convert.ToString(pterigio), pterigioTratamento,
                        Convert.ToString(defeitosRefracao), defeitosRefracaoTratamento, outro, outroTratamento) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os Antecedentes Oculare(Classe AntecedentesOcularesRegra, Método Editar)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarAntecedentesOculares(string idAntecedentesOculares)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                AntecedentesOcularesAcesso pesquisar = new AntecedentesOcularesAcesso();

                if (Convert.ToInt32(idAntecedentesOculares) > 0) dadosTabela = pesquisar.PesquisarAntecedentesOculares(idAntecedentesOculares);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Oculares(Classe AntecedentesOcularesRegra, Método PesquisarAntecedentesOculares)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
