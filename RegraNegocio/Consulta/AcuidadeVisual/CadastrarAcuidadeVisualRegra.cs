using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class CadastrarAcuidadeVisualRegra
    {
        public bool Cadastrar(string idConsulta,string vlOdSg, string vlOeSg, string vlAoSg, string vlPh, string vlOdCc, string vlOeCc, string vlAoCc, string vpOdSc, string vpOeSc, string vpAoSc, string vpOdCc,
            string vpOeCc, string vpAoCc, string tipoOptotipo)
        {
            try
            {
                if (Validar(vlOdSg,vlOeSg,vlAoSg,vlPh,vlOdCc,vlOeCc,vlAoCc,vpOdSc,vpOeSc,vpAoSc,vpOdCc,vpOeCc,vpAoCc,tipoOptotipo) == true)
                {
                    CadastrarAcuidadeVisualAcesso AcuidadeVisual = new CadastrarAcuidadeVisualAcesso();
                    if (AcuidadeVisual.CadastrarAcuidadeVisual(idConsulta,vlOdSg, vlOeSg, vlAoSg, vlPh, vlOdCc, vlOeCc, vlAoCc, vpOdSc, vpOeSc, vpAoSc, vpOdCc, vpOeCc, vpAoCc, tipoOptotipo)==true) return true;return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Acuidade Visual(Classe CadastrarAcuidadeVisualRegra, Método Cadastrar)", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
         bool Validar(string vlOdSg, string vlOeSg, string vlAoSg, string vlPh, string vlOdCc, string vlOeCc, string vlAoCc, string vpOdSc, string vpOeSc, string vpAoSc, string vpOdCc,
            string vpOeCc, string vpAoCc, string tipoOptotipo)
        {
            try
            {
                if (vlOdSg.GetType() != typeof(string) || vlOdSg.Length >10) return false;
                if (vlOeSg.GetType() != typeof(string) || vlOeSg.Length > 10) return false;
                if (vlAoSg.GetType() != typeof(string) || vlAoSg.Length > 10) return false;

                if (vlPh.GetType() != typeof(string) || vlPh.Length > 10) return false;

                if (vlOdCc.GetType() != typeof(string) || vlOdCc.Length > 10) return false;
                if (vlOeCc.GetType() != typeof(string) || vlOeCc.Length > 10) return false;
                if (vlAoCc.GetType() != typeof(string) || vlAoCc.Length > 10) return false;

                if (vpOdSc.GetType() != typeof(string) || vpOdSc.Length > 10) return false;
                if (vpOeSc.GetType() != typeof(string) || vpOeSc.Length > 10) return false;
                if (vpAoSc.GetType() != typeof(string) || vpAoSc.Length > 10) return false;

                if (vpOdCc.GetType() != typeof(string) || vpOdCc.Length > 10) return false;
                if (vpOeCc.GetType() != typeof(string) || vpOeCc.Length > 10) return false;
                if (vpAoCc.GetType() != typeof(string) || vpAoCc.Length > 10) return false;

                if (tipoOptotipo.GetType() != typeof(string) || tipoOptotipo.Length > 100) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Acuidade Visual(Classe CadastrarAcuidadeVisualRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
