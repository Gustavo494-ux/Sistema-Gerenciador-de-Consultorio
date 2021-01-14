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
    public class BiomicroscopiaRegra
    {
        BiomicroscopiaAcesso bioAcesso = new BiomicroscopiaAcesso();


        public bool CadastrarBiomicroscopia(string IDCONSULTA, string SOBRANCELHAOD, string SOBRANCELHAOE, string CILIOOD, string CILIOOE, string PALPEBRAOD, string PALPEBRAOE, string CONJUNTIVAOD,
            string CONJUNTIVAOE, string ESCLEROTICAOD, string ESCLEROTICAOE, string CORNEAOD, string CORNEAOE, string IRISOD, string IRISOE, string CRISTALINOOD, string CRISTALINOOE,
            string CAMARAANTERIOROD, string CAMARAANTERIOROE, string OBSERVACAOBIOMICROSCOPIA)
        {
            try
            {
                if(ValidarBiomicroscopia(IDCONSULTA,SOBRANCELHAOD,SOBRANCELHAOE,CILIOOD,CILIOOE,PALPEBRAOD,PALPEBRAOE,CONJUNTIVAOD,CONJUNTIVAOE,ESCLEROTICAOD,ESCLEROTICAOE,CORNEAOD,CORNEAOE,IRISOD,IRISOE,CRISTALINOOD,
                    CRISTALINOOE, CAMARAANTERIOROD, CAMARAANTERIOROE, OBSERVACAOBIOMICROSCOPIA))
                {
                    return bioAcesso.CadastrarBiomicroscopia(IDCONSULTA, SOBRANCELHAOD, SOBRANCELHAOE, CILIOOD, CILIOOE, PALPEBRAOD, PALPEBRAOE, CONJUNTIVAOD, CONJUNTIVAOE, ESCLEROTICAOD, ESCLEROTICAOE, CORNEAOD, CORNEAOE, IRISOD, IRISOE, CRISTALINOOD,
                    CRISTALINOOE, CAMARAANTERIOROD, CAMARAANTERIOROE, OBSERVACAOBIOMICROSCOPIA);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar a Biomicroscopia(Classe BiomicroscopiaRegra, Método CadastrarBiomicroscopia)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool AtualizarBiomicroscopia(string IDCONSULTA, string SOBRANCELHAOD, string SOBRANCELHAOE, string CILIOOD, string CILIOOE, string PALPEBRAOD, string PALPEBRAOE, string CONJUNTIVAOD,
            string CONJUNTIVAOE, string ESCLEROTICAOD, string ESCLEROTICAOE, string CORNEAOD, string CORNEAOE, string IRISOD, string IRISOE, string CRISTALINOOD, string CRISTALINOOE,
            string CAMARAANTERIOROD, string CAMARAANTERIOROE, string OBSERVACAOBIOMICROSCOPIA)
        {
            try
            {
                if (ValidarBiomicroscopia(IDCONSULTA, SOBRANCELHAOD, SOBRANCELHAOE, CILIOOD, CILIOOE, PALPEBRAOD, PALPEBRAOE, CONJUNTIVAOD, CONJUNTIVAOE, ESCLEROTICAOD, ESCLEROTICAOE, CORNEAOD, CORNEAOE, IRISOD, IRISOE, CRISTALINOOD,
                    CRISTALINOOE, CAMARAANTERIOROD, CAMARAANTERIOROE, OBSERVACAOBIOMICROSCOPIA))
                {
                    return bioAcesso.AtualizarBiomicroscopia(IDCONSULTA, SOBRANCELHAOD, SOBRANCELHAOE, CILIOOD, CILIOOE, PALPEBRAOD, PALPEBRAOE, CONJUNTIVAOD, CONJUNTIVAOE, ESCLEROTICAOD, ESCLEROTICAOE, CORNEAOD, CORNEAOE, IRISOD, IRISOE, CRISTALINOOD,
                    CRISTALINOOE, CAMARAANTERIOROD, CAMARAANTERIOROE, OBSERVACAOBIOMICROSCOPIA);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Biomicroscopia(Classe BiomicroscopiaRegra, Método AtualizarBiomicroscopia)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool ValidarBiomicroscopia(string IDCONSULTA, string SOBRANCELHAOD, string SOBRANCELHAOE, string CILIOOD, string CILIOOE, string PALPEBRAOD, string PALPEBRAOE, string CONJUNTIVAOD,
            string CONJUNTIVAOE, string ESCLEROTICAOD, string ESCLEROTICAOE, string CORNEAOD, string CORNEAOE, string IRISOD, string IRISOE, string CRISTALINOOD, string CRISTALINOOE,
            string CAMARAANTERIOROD, string CAMARAANTERIOROE, string OBSERVACAOBIOMICROSCOPIA)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) > 0) return false;

                if (SOBRANCELHAOD.Length > 100) return false;
                if (SOBRANCELHAOE.Length > 100) return false;

                if (CILIOOD.Length > 100) return false;
                if (CILIOOE.Length > 100) return false;

                if (PALPEBRAOD.Length > 100) return false;
                if (PALPEBRAOE.Length > 100) return false;

                if (CONJUNTIVAOD.Length > 100) return false;
                if (CONJUNTIVAOE.Length > 100) return false;

                if (ESCLEROTICAOD.Length > 100) return false;
                if (ESCLEROTICAOE.Length > 100) return false;

                if (CORNEAOD.Length > 100) return false;
                if (CORNEAOE.Length > 100) return false;

                if (IRISOD.Length > 100) return false;
                if (IRISOE.Length > 100) return false;

                if (CRISTALINOOD.Length > 100) return false;
                if (CRISTALINOOE.Length > 100) return false;

                if (CAMARAANTERIOROD.Length > 100) return false;
                if (CAMARAANTERIOROE.Length > 100) return false;

                if (OBSERVACAOBIOMICROSCOPIA.Length > 100) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a Biomicroscopia(Classe BiomicroscopiaRegra, Método ValidarBiomicroscopia)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public DataTable PesquisarBiomicroscopia(string IDCONSULTA)
        {
            try
            {
                return bioAcesso.PesquisarBiomicroscopia(IDCONSULTA);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Biomicroscopia(Classe BiomicroscopiaRegra, Método PesquisarBiomicroscopia)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
