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
    public class AntecedentesGeraisRegra
    {
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string idConsulta,string vasculares, string vascularesTratamento, string diabetes, string diabetesTratamento, string imunes, string imunesTratamento, string neurologicos,
            string neurologicosTratamento, string outros, string outrosTratamento, string observacaoAntecedentesGerais)
        {
            try
            {
                if (Validar(vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos, neurologicosTratamento, outros, outrosTratamento, observacaoAntecedentesGerais) == true)
                {
                   AntecedentesGeraisAcesso cadastrarAcesso = new AntecedentesGeraisAcesso();
                    if (cadastrarAcesso.CadastrarAntecentesGerais(idConsulta,vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos, neurologicosTratamento,
                        outros, outrosTratamento, observacaoAntecedentesGerais) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Antecedentes Gerais(Classe AntecedentesGeraisRegra, Método Cadastrar)", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Validar(string vasculares, string vascularesTratamento, string diabetes, string diabetesTratamento, string imunes, string imunesTratamento, string neurologicos,
            string neurologicosTratamento, string outros, string outrosTratamento, string observacaoAntecedentesGerais)
        {
            try
            {
                if (vasculares.GetType() != typeof(string)) return false;
                if (vascularesTratamento.GetType() != typeof(string) || vascularesTratamento.Length > 100) return false;
                if (diabetes.GetType() != typeof(string)) return false;
                if (diabetesTratamento.GetType() != typeof(string) || diabetesTratamento.Length > 100) return false;
                if (imunes.GetType() != typeof(string)) return false;
                if (imunesTratamento.GetType() != typeof(string) || imunesTratamento.Length > 100) return false;
                if (neurologicos.GetType() != typeof(string)) return false;
                if (neurologicosTratamento.GetType() != typeof(string) || neurologicosTratamento.Length > 100) return false;
                if (outros.GetType() != typeof(string) || outros.Length >50) return false;
                if (outrosTratamento.GetType() != typeof(string) || outrosTratamento.Length > 100) return false;
                if (observacaoAntecedentesGerais.GetType() != typeof(string)) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar os AntecedentesGerais(Classe AntecedentesGeraisRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Editar(int idAntecedentesGerais, string vasculares, string vascularesTratamento, string diabetes, string diabetesTratamento, string imunes, string imunesTratamento, string neurologicos,
            string neurologicosTratamento, string outros, string outrosTratamento, string observacaoAntecedentesGerais)
        {
            try
            {
               AntecedentesGeraisAcesso Acesso = new AntecedentesGeraisAcesso();
                if (Validar(vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos, neurologicosTratamento,
                    outros, outrosTratamento, observacaoAntecedentesGerais) == true)
                {
                    bool gerais = Acesso.EditarAntecedentesGerais(Convert.ToString(idAntecedentesGerais), vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos, neurologicosTratamento,
                    outros, outrosTratamento, observacaoAntecedentesGerais);
                    return gerais;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar os Antecedentes Gerais (Classee AntecedentesGeraisRegra, Método Editar)", "erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarAntecedentesGerais(string idAntecedentesGerais)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                AntecedentesGeraisAcesso pesquisar = new AntecedentesGeraisAcesso();

                if (Convert.ToInt32(idAntecedentesGerais) > 0) dadosTabela = pesquisar.PesquisarAntecedentesGerais(idAntecedentesGerais);
                return dadosTabela;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Antecedentes Gerais(Classe AntecedentesGeraisRegra, Método PesquisarAntecedentesGerais)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
