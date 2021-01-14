using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class MotilidadeOcularRegra
    {
        MotilidadeOcularAcesso motilidadeAcesso = new MotilidadeOcularAcesso();
        public bool CadastrarMotilidadeOcular(string IDCONSULTA, string KAPPAOD, string KAPPAOE, string HIRSCHBERG, string DUCAOOD, string DUCAOOE, string VERSAOOD, string VERSAOOE,
            string OBSERVACAOMOTILIDADE, string FOTOMOTOROD, string FOTOMOTOROE, string CONSENSUALOD, string CONSENSUALOE, string ACOMODATIVOOD, string ACOMODATIVOOE, string BALANCO)
        {
            try
            {
                if(ValidarMotilidadeOcular(IDCONSULTA,KAPPAOD,KAPPAOE,HIRSCHBERG,DUCAOOD,DUCAOOE,VERSAOOD,VERSAOOE,OBSERVACAOMOTILIDADE,FOTOMOTOROD,FOTOMOTOROE,CONSENSUALOD, 
                    CONSENSUALOE,ACOMODATIVOOD,ACOMODATIVOOE,BALANCO)) 
                {
                    return motilidadeAcesso.CadastrarMotilidadeOcular(IDCONSULTA, KAPPAOD, KAPPAOE, HIRSCHBERG, DUCAOOD, DUCAOOE, VERSAOOD, VERSAOOE, OBSERVACAOMOTILIDADE,
                        FOTOMOTOROD, FOTOMOTOROE, CONSENSUALOD,CONSENSUALOE, ACOMODATIVOOD, ACOMODATIVOOE, BALANCO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Motilidade Ocular(Classe MotilidadeOcularRegra, Método CadastrarMotilidadeOcular)", "Erro de cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarMotilidadeOcular(string IDCONSULTA, string KAPPAOD, string KAPPAOE, string HIRSCHBERG, string DUCAOOD, string DUCAOOE, string VERSAOOD, string VERSAOOE,
            string OBSERVACAOMOTILIDADE, string FOTOMOTOROD, string FOTOMOTOROE, string CONSENSUALOD, string CONSENSUALOE, string ACOMODATIVOOD, string ACOMODATIVOOE, string BALANCO)
        {
            try
            {
                if (ValidarMotilidadeOcular(IDCONSULTA, KAPPAOD, KAPPAOE, HIRSCHBERG, DUCAOOD, DUCAOOE, VERSAOOD, VERSAOOE, OBSERVACAOMOTILIDADE, FOTOMOTOROD, FOTOMOTOROE, CONSENSUALOD,
                   CONSENSUALOE, ACOMODATIVOOD, ACOMODATIVOOE, BALANCO))
                {
                    return motilidadeAcesso.AtualizarMotilidadeOcular(IDCONSULTA, KAPPAOD, KAPPAOE, HIRSCHBERG, DUCAOOD, DUCAOOE, VERSAOOD, VERSAOOE, OBSERVACAOMOTILIDADE,
                        FOTOMOTOROD, FOTOMOTOROE, CONSENSUALOD, CONSENSUALOE, ACOMODATIVOOD, ACOMODATIVOOE, BALANCO);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Motilidade Ocular(Classe MotilidadeRegra, Método AtualizarMotilidadeOcular)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarMotilidadeOcular(string IDCONSULTA, string KAPPAOD, string KAPPAOE, string HIRSCHBERG, string DUCAOOD, string DUCAOOE, string VERSAOOD, string VERSAOOE,
            string OBSERVACAOMOTILIDADE, string FOTOMOTOROD, string FOTOMOTOROE, string CONSENSUALOD, string CONSENSUALOE, string ACOMODATIVOOD, string ACOMODATIVOOE, string BALANCO)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) > 0) return false;

                if (KAPPAOD.Length > 100) return false;
                if (KAPPAOE.Length > 100) return false;

                if (HIRSCHBERG.Length > 100) return false;

                if (DUCAOOD.Length > 100) return false;
                if (DUCAOOE.Length > 100) return false;

                if (VERSAOOD.Length > 100) return false;
                if (VERSAOOE.Length > 100) return false;

                if (OBSERVACAOMOTILIDADE.Length > 100) return false;

                if (FOTOMOTOROD.Length > 100) return false;
                if (FOTOMOTOROE.Length > 100) return false;

                if (CONSENSUALOD.Length > 100) return false;
                if (CONSENSUALOE.Length > 100) return false;

                if (ACOMODATIVOOD.Length > 100) return false;
                if (ACOMODATIVOOE.Length > 100) return false;

                if (BALANCO.Length > 100) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar os dados da Motilidade Ocular(Classe MotilidadeOcularRegra, Método ValidarMotilidadeOcular)", "Erro de validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            return true;
        }
        public DataTable PesquisarMotilidadeOcular(string IDCONSULTA)
        {
            try
            {
                return motilidadeAcesso.PesquisarMotilidadeOcular(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a MotilidadeOcular(Classe MotilidadeOcularRegra,Método PesquisarMotilidadeOcular)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public string ConcatenarVersoes(string VERSAO1,string VERSAO2, string VERSAO3,string VERSAO4,string VERSAO5, string VERSAO6)
        {
            try
            {
                string versaoConcatenada = VERSAO1 + "#" + VERSAO2 + "#" + VERSAO3 + "#" + VERSAO4 + "#" + VERSAO5 + "#" + VERSAO6;
                return versaoConcatenada;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro concetenar as versão(Classe MotilidadeOcularRegra, Método ConcatenarVersoes)", "Erro de concatenação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public string[] DesconcetenarVersoes(string versaoConcatenada)
        {
            try
            {
                string[] versaoDesconcatenada = versaoConcatenada.Split('#');
                return versaoDesconcatenada;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao desconcatenar as versões(Classe MotilidadeOcularRegra, Método DesconcatenarVersoes)", "Erro de Desconcatenação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
