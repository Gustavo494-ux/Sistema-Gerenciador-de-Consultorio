using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class CadastrarAnamneseRegra
    {
        public bool Cadastrar(string idConsulta,string motivoConsulta, string tempoQueixa, string observacaoAnamnese)
        {
            try
            {
                CadastrarAnamneseAcesso cadastrarAcesso = new CadastrarAnamneseAcesso();
                if (Validar(motivoConsulta, tempoQueixa, observacaoAnamnese) == true)
                {
                    if (cadastrarAcesso.Cadastrar(idConsulta,motivoConsulta, tempoQueixa, observacaoAnamnese) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Anamnese(Classe CadastrarAnamneseRegra, Método Cadastrar)", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
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
                MessageBox.Show("Ocorreu um erro ao validar a Anamnese(Classe CadastrarAnamneseRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
