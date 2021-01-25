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
    public class SintomasReferidosRegra
    {
        DataTable tableVazia = new DataTable();
        public bool Validar(bool visaoBorrada,bool cefaleia,bool lacrimejamento,bool olhoVermelho,bool visaoDupla, bool fotopsias_fosfenos,bool miodesopsias,bool dorCabeca,bool astenopia,bool dorOcular,
            bool ardencia, bool secrecoes, bool coceira, bool fotofobia, bool halos,bool estrabismo,string outros,bool outrosConfirm)
        {
            try
            {
                if (visaoBorrada.GetType() != typeof(bool)) return false;
                if (cefaleia.GetType() != typeof(bool)) return false;
                if (lacrimejamento.GetType() != typeof(bool)) return false;
                if (olhoVermelho.GetType() != typeof(bool)) return false;
                if (visaoDupla.GetType() != typeof(bool)) return false;
                if (fotopsias_fosfenos.GetType() != typeof(bool)) return false;
                if (miodesopsias.GetType() != typeof(bool)) return false;
                if (dorCabeca.GetType() != typeof(bool)) return false;
                if (astenopia.GetType() != typeof(bool)) return false;
                if (dorOcular.GetType() != typeof(bool)) return false;
                if (ardencia.GetType() != typeof(bool)) return false;
                if (secrecoes.GetType() != typeof(bool)) return false;
                if (coceira.GetType() != typeof(bool)) return false;
                if (fotofobia.GetType() != typeof(bool)) return false;
                if (halos.GetType() != typeof(bool)) return false;
                if (estrabismo.GetType() != typeof(bool)) return false;
                if (outros.GetType() != typeof(string)) return false;
                if (outrosConfirm.GetType() != typeof(bool)) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar os Sintomas Referidos(Classe SintomasReferidosRegra, Método Validar)", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Cadastrar(string idConsulta,bool visaoBorrada, bool cefaleia, bool lacrimejamento, bool olhoVermelho, bool visaoDupla, bool fotopsias_fosfenos, bool miodesopsias, bool dorCabeca, bool astenopia, bool dorOcular,
            bool ardencia, bool secrecoes, bool coceira, bool fotofobia, bool halos, bool estrabismo, string outros,bool outrosConfirm)
        {
            try
            {
                if (Validar(visaoBorrada,cefaleia,lacrimejamento,olhoVermelho,visaoDupla,fotopsias_fosfenos,miodesopsias,dorCabeca,astenopia,dorOcular,ardencia,secrecoes,coceira,
                    fotofobia,halos,estrabismo,outros, outrosConfirm))
                {
                   SintomasReferidosAcesso SintomasAcesso = new SintomasReferidosAcesso();
                   bool confirm = SintomasAcesso.CadastrarSintomasReferidos(idConsulta,Convert.ToString(visaoBorrada), Convert.ToString(cefaleia), Convert.ToString(lacrimejamento), 
                       Convert.ToString(olhoVermelho), Convert.ToString(visaoDupla), Convert.ToString(fotopsias_fosfenos), Convert.ToString(miodesopsias), Convert.ToString(dorCabeca),
                       Convert.ToString(astenopia), Convert.ToString(dorOcular), Convert.ToString(ardencia), Convert.ToString(secrecoes), Convert.ToString(coceira),
                   Convert.ToString(fotofobia), Convert.ToString(halos), Convert.ToString(estrabismo), Convert.ToString(outros), Convert.ToString(outrosConfirm));
                    return confirm;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar os Sintomas Referidos(Classe SintomasReferidosRegra, Método Cadastrar)", "Erro de cadastro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }

        public bool Editar(int idSintomasReferidos, bool visaoBorrada, bool cefaleia, bool lacrimejamento, bool olhoVermelho, bool visaoDupla, bool fotopsias_fosfenos, bool miodesopsias, bool dorCabeca, bool astenopia, bool dorOcular,
            bool ardencia, bool secrecoes, bool coceira, bool fotofobia, bool halos, bool estrabismo, string outros,bool outrosConfirm)
        {
            try
            {
                SintomasReferidosAcesso sintomasAcesso = new SintomasReferidosAcesso();
                if (Validar(visaoBorrada, cefaleia, lacrimejamento, olhoVermelho, visaoDupla, fotopsias_fosfenos, miodesopsias, dorCabeca, astenopia, dorOcular, ardencia, secrecoes, coceira,
                    fotofobia, halos, estrabismo, outros,outrosConfirm) == true)
                {
                    bool sintomas = sintomasAcesso.EditarSintomasReferidos(Convert.ToString(idSintomasReferidos), Convert.ToString(visaoBorrada), Convert.ToString(cefaleia),
                        Convert.ToString(lacrimejamento), Convert.ToString(olhoVermelho), Convert.ToString(visaoDupla), Convert.ToString(fotopsias_fosfenos), Convert.ToString(miodesopsias),
                        Convert.ToString(dorCabeca), Convert.ToString(astenopia), Convert.ToString(dorOcular), Convert.ToString(ardencia), Convert.ToString(secrecoes), Convert.ToString(coceira),
                    Convert.ToString(fotofobia), Convert.ToString(halos), Convert.ToString(estrabismo), Convert.ToString(outros), Convert.ToString(outrosConfirm));
                    return sintomas;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao editar os Sintomas Referidos(Classe SintomasReferidosRegra, Método Editar)", "Erro de atualizãção/edição",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarSintomasReferidos(string idSintomasReferidos)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                SintomasReferidosAcesso pesquisar = new SintomasReferidosAcesso();
                if (Convert.ToInt32(idSintomasReferidos) > 0) dadosTabela = pesquisar.PesquisarSintomasReferidos(idSintomasReferidos);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo Sintomas Referidos(Classe SintomasReferidosRegra, Método PesquisaSintomasReferidos) ", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
