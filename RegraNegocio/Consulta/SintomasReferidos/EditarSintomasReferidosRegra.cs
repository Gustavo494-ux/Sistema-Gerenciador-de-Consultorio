using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class EditarSintomasReferidosRegra
    {
        public bool Editar(int idSintomasReferidos, bool visaoBorrada, bool cefaleia, bool lacrimejamento, bool olhoVermelho, bool visaoDupla, bool fotopsias_fosfenos, bool miodesopsias, bool dorCabeca, bool astenopia, bool dorOcular,
            bool ardencia, bool secrecoes, bool coceira, bool fotofobia, bool halos, bool estrabismo, string outros)
        {
            try
            {
                CadastrarSintomasReferidosRegra SintomasRegra = new CadastrarSintomasReferidosRegra();
                EditarSintomasReferidosAcesso sintomasAcesso = new EditarSintomasReferidosAcesso();
                if (SintomasRegra.Editar(visaoBorrada, cefaleia, lacrimejamento, olhoVermelho, visaoDupla, fotopsias_fosfenos, miodesopsias, dorCabeca, astenopia, dorOcular, ardencia, secrecoes, coceira,
                    fotofobia, halos, estrabismo, outros)==true)
                {
                    bool sintomas = sintomasAcesso.EditarSintomasReferidos(Convert.ToString(idSintomasReferidos), Convert.ToString(visaoBorrada), Convert.ToString(cefaleia),
                        Convert.ToString(lacrimejamento), Convert.ToString(olhoVermelho), Convert.ToString(visaoDupla), Convert.ToString(fotopsias_fosfenos), Convert.ToString(miodesopsias),
                        Convert.ToString(dorCabeca), Convert.ToString(astenopia), Convert.ToString(dorOcular), Convert.ToString(ardencia), Convert.ToString(secrecoes), Convert.ToString(coceira),
                    Convert.ToString(fotofobia), Convert.ToString(halos), Convert.ToString(estrabismo), Convert.ToString(outros));
                    return sintomas;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar os Sintomas Referidos(Classe EditarSintomasReferidosRegra, Método Editar)","Erro de atualizãção/edição",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
