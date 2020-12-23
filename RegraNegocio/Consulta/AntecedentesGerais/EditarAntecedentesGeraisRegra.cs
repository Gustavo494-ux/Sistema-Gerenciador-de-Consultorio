using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class EditarAntecedentesGeraisRegra
    {
        public bool Editar(int idAntecedentesGerais, string vasculares, string vascularesTratamento, string diabetes, string diabetesTratamento, string imunes, string imunesTratamento, string neurologicos,
            string neurologicosTratamento, string outros, string outrosTratamento, string observacaoAntecedentesGerais)
        {
            try
            {
                EditarAntecedentesGeraisAcesso Acesso = new EditarAntecedentesGeraisAcesso();
                CadastrarAntecedentesGeraisRegra GeraisRegra = new CadastrarAntecedentesGeraisRegra();
                if (GeraisRegra.Validar(vasculares,vascularesTratamento,diabetes,diabetesTratamento,imunes,imunesTratamento,neurologicos,neurologicosTratamento,
                    outros,outrosTratamento,observacaoAntecedentesGerais)== true)
                {
                    bool gerais = Acesso.EditarAntecedentesGerais(Convert.ToString(idAntecedentesGerais),vasculares, vascularesTratamento, diabetes, diabetesTratamento, imunes, imunesTratamento, neurologicos, neurologicosTratamento,
                    outros, outrosTratamento, observacaoAntecedentesGerais);
                    return gerais;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar os Antecedentes Gerais (Classee EditarAntecedentesGeraisRegra, Método Editar)", "erro de atualização/edição",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
