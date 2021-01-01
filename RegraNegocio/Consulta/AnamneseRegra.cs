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
    public class AnamneseRegra
    {
        DataTable tableVazia = new DataTable();
        AnamneseAcesso anamnese = new AnamneseAcesso();
        public bool Cadastrar(string idConsulta,string motivoConsulta, string tempoQueixa, string observacaoAnamnese)
        {
            try
            {
                if (Validar(motivoConsulta, tempoQueixa, observacaoAnamnese) == true)
                {
                    if (anamnese.Cadastrar(idConsulta,motivoConsulta, tempoQueixa, observacaoAnamnese) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Anamnese(Classe AnamneseRegra, Método Cadastrar)", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        bool Validar(string motivoConsulta, string tempoQueixa, string observacaoAnamnese)
        {
            try
            {
                if (motivoConsulta.GetType() != typeof(string) || motivoConsulta.Length > 100) return false;
                if (tempoQueixa.GetType() != typeof(string) || tempoQueixa.Length > 100) return false;
                if (observacaoAnamnese.GetType() != typeof(string)) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Anamnese(Classe AnamneseRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Editar(int idAnamnese, string motivoConsulta, string tempoQueixa, string observacaoAnamnese)
        {
            try
            {
                if (Validar(motivoConsulta, tempoQueixa, observacaoAnamnese) == true)
                {
                    if (anamnese.Atualizar(Convert.ToString(idAnamnese), motivoConsulta, tempoQueixa, observacaoAnamnese) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Anamnese(Classe AnamneseRegra, Método Editar)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarAnamnese(string idAnamnese)
        {
            try
            {
                if (Convert.ToInt32(idAnamnese) > 0) return anamnese.PesquisarAnamnese(idAnamnese);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela Anamnese(Classe AnamneseRegra, Método PesquisarAnamnese)", "Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
