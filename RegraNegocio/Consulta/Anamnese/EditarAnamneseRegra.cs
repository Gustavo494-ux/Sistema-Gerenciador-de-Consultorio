using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class EditarAnamneseRegra
    {
        public bool Editar(int idAnamnese, string motivoConsulta, string tempoQueixa, string observacaoAnamnese)
        {
            try
            {
                if (Validar(idAnamnese, motivoConsulta, tempoQueixa, observacaoAnamnese) == true)
                {
                    EditarAnamneseAcesso editarAcesso = new EditarAnamneseAcesso();
                    if (editarAcesso.Atualizar(Convert.ToString(idAnamnese), motivoConsulta, tempoQueixa, observacaoAnamnese) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Anamnese(Classe EditarAnamneseRegra, Método Editar)", "Erro de atualização/edição",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        public bool Validar(int idAnamnese, string motivoConsulta, string tempoQueixa, string observacaoAnamnese)
        {
            try
            {
                if (idAnamnese.GetType() != typeof(int) || idAnamnese <= 0) return false;
                if (motivoConsulta.GetType() != typeof(string) || motivoConsulta.Length > 100) return false;
                if (tempoQueixa.GetType() != typeof(string) || tempoQueixa.Length > 100) return false;
                if (observacaoAnamnese.GetType() != typeof(string)) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Anamnese(Classe EditarAnamneseRegra, Método Validar)","Erro de validação",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
