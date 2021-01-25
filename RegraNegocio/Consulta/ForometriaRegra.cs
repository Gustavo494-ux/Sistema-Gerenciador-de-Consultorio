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
    public class ForometriaRegra
    {
        ForometriaAcesso foroRegra = new ForometriaAcesso();

        public bool CadastrarForometria(string IDCONSULTA, string TESTEUTILIZADO, string CORRECAO, string VLOD, string VLOE, string QUARENTACMOD, string QUARENTACMOE, string VINTECMOD, string VINTECMOE,
            string PPCOR, string PPCLUZ, string PPCFILTRO, string PFPVL, string PFPVP, string RFNVL, string RFNVP, string AAOD, string AAOE, string FLEXIBILIDADEOD, string FLEXIBILIDADEOE,
            string METODO, string NIVELVISUAL, string DT)
        {
            try
            {
                if (ValidarForometria(IDCONSULTA, TESTEUTILIZADO, CORRECAO, VLOD, VLOE, QUARENTACMOD, QUARENTACMOE, VINTECMOD, VINTECMOE, PPCOR, PPCLUZ, PPCFILTRO, PFPVL, PFPVP, RFNVL, RFNVP, 
                    AAOD, AAOE, FLEXIBILIDADEOD, FLEXIBILIDADEOE, METODO, NIVELVISUAL, DT))
                {
                    if (CORRECAO != "True") CORRECAO = "False";
                    return foroRegra.CadastrarForometria(IDCONSULTA, TESTEUTILIZADO, CORRECAO, VLOD, VLOE, QUARENTACMOD, QUARENTACMOE, VINTECMOD, VINTECMOE, PPCOR, PPCLUZ, PPCFILTRO, PFPVL,
                        PFPVP, RFNVL, RFNVP, AAOD, AAOE, FLEXIBILIDADEOD, FLEXIBILIDADEOE, METODO, NIVELVISUAL, DT);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Forometria(Classe ForometriaRegra, Método CadastrarForometria)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool ValidarForometria(string IDCONSULTA, string TESTEUTILIZADO, string CORRECAO, string VLOD, string VLOE, string QUARENTACMOD, string QUARENTACMOE, string VINTECMOD, string VINTECMOE,
            string PPCOR, string PPCLUZ, string PPCFILTRO, string PFPVL, string PFPVP, string RFNVL, string RFNVP, string AAOD, string AAOE, string FLEXIBILIDADEOD, string FLEXIBILIDADEOE, 
            string METODO,string NIVELVISUAL, string DT)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) < 1) return false;

                if (TESTEUTILIZADO.Length > 100) return false;

                if (CORRECAO.Length > 100) return false;

                if (VLOD.Length > 100) return false;
                if (VLOE.Length > 100) return false;

                if (QUARENTACMOD.Length > 100) return false;
                if (QUARENTACMOE.Length > 100) return false;

                if (VINTECMOD.Length > 100) return false;
                if (VINTECMOE.Length > 100) return false;

                if (PPCOR.Length > 100) return false;

                if (PPCLUZ.Length > 100) return false;

                if (PPCFILTRO.Length > 100) return false;

                if (PFPVL.Length > 100) return false;
                if (PFPVP.Length > 100) return false;

                if (RFNVL.Length > 100) return false;
                if (RFNVP.Length > 100) return false;

                if (AAOD.Length > 100) return false;
                if (AAOE.Length > 100) return false;

                if (FLEXIBILIDADEOD.Length > 100) return false;
                if (FLEXIBILIDADEOE.Length > 100) return false;

                if (METODO.Length > 100) return false;
                if (NIVELVISUAL.Length > 100) return false;
                if (DT.Length > 100) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Forometria(Classe ForometriaRegra,Método ValidarForometria)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public bool AtualizarForometria(string IDCONSULTA, string TESTEUTILIZADO, string CORRECAO, string VLOD, string VLOE, string QUARENTACMOD, string QUARENTACMOE, string VINTECMOD, string VINTECMOE,
           string PPCOR, string PPCLUZ, string PPCFILTRO, string PFPVL, string PFPVP, string RFNVL, string RFNVP, string AAOD, string AAOE, string FLEXIBILIDADEOD, string FLEXIBILIDADEOE,
           string METODO, string NIVELVISUAL, string DT)
        {
            try
            {
                if (ValidarForometria(IDCONSULTA, TESTEUTILIZADO, CORRECAO, VLOD, VLOE, QUARENTACMOD, QUARENTACMOE, VINTECMOD, VINTECMOE, PPCOR, PPCLUZ, PPCFILTRO, PFPVL, PFPVP, RFNVL, RFNVP,
                    AAOD, AAOE, FLEXIBILIDADEOD, FLEXIBILIDADEOE, METODO, NIVELVISUAL, DT))
                {
                    if (CORRECAO != "True") CORRECAO = "False";
                    return foroRegra.AtualizarForometria(IDCONSULTA, TESTEUTILIZADO, CORRECAO, VLOD, VLOE, QUARENTACMOD, QUARENTACMOE, VINTECMOD, VINTECMOE, PPCOR, PPCLUZ, PPCFILTRO, PFPVL,
                        PFPVP, RFNVL, RFNVP, AAOD, AAOE, FLEXIBILIDADEOD, FLEXIBILIDADEOE, METODO, NIVELVISUAL, DT);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Forometria(Classe ForometriaRegra, Método AtualizarForometria)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public DataTable PesquisarForometria(string IDCONSULTA)
        {
            try
            {
                return foroRegra.PesquisarForometria(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Fotometria(Classe ForometriaRegra,Método PesquisarForometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
