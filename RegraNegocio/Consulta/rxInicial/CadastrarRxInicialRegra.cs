using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcessoDados;
using System.Windows.Forms;

namespace RegraNegocio
{
    public class CadastrarRxInicialRegra
    {
        public bool Cadastrar(string idConsulta,string vlOdEsfera, string vlOeEsfera, string vpOdEsfera, string vpOeEsfera, string vlOdCilindro, string vlOeCilindro, string vpOdCilindro, string vpOeCilindro, string vlOdEixo,
            string vlOeEixo, string vpOdEixo, string vpOeEixo, string vlOdAdicao, string vlOeAdicao, string vpOdAdicao, string vpOeAdicao, string vlOdPrisma, string vlOePrisma, string vpOdPrisma, string vpOePrisma,
            string vlOdBase, string vlOeBase, string vpOdBase, string vpOeBase, string tipoLente, string material, string cor, string estado, string observacaoRxFinal)
        {
            try
            {
                if (Validar(vlOdEsfera, vlOeEsfera, vpOdEsfera, vpOeEsfera, vlOdCilindro, vlOeCilindro, vpOdCilindro, vpOeCilindro, vlOdEixo, vlOeEixo, vpOdEixo, vpOeEixo, vlOdAdicao, vlOeAdicao, vpOdAdicao, vpOeAdicao, vlOdPrisma,
                vlOePrisma, vpOdPrisma, vpOePrisma, vlOdBase, vlOeBase, vpOdBase, vpOeBase, tipoLente, material, cor, estado, observacaoRxFinal) == true)
                {
                    CadastrarRxInicialAcesso cadastrarAcesso = new CadastrarRxInicialAcesso();
                    if (cadastrarAcesso.CadastrarRxInicial(idConsulta,vlOdEsfera, vlOeEsfera, vpOdEsfera, vpOeEsfera, vlOdCilindro, vlOeCilindro, vpOdCilindro, vpOeCilindro, vlOdEixo, vlOeEixo, vpOdEixo, vpOeEixo, vlOdAdicao, vlOeAdicao, vpOdAdicao, vpOeAdicao, vlOdPrisma,
                    vlOePrisma, vpOdPrisma, vpOePrisma, vlOdBase, vlOeBase, vpOdBase, vpOeBase, tipoLente, material, cor, estado, observacaoRxFinal) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o Rx Inicial(Classe CadastrarRxInicialRegra, Método Cadastrar)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
        public bool Validar(string vlOdEsfera, string vlOeEsfera, string vpOdEsfera, string vpOeEsfera, string vlOdCilindro, string vlOeCilindro, string vpOdCilindro, string vpOeCilindro, string vlOdEixo,
            string vlOeEixo, string vpOdEixo, string vpOeEixo, string vlOdAdicao, string vlOeAdicao, string vpOdAdicao, string vpOeAdicao, string vlOdPrisma, string vlOePrisma, string vpOdPrisma, string vpOePrisma,
            string vlOdBase, string vlOeBase, string vpOdBase, string vpOeBase, string tipoLente, string material, string cor, string estado, string observacaoRxFinal)
        {
            try
            {
                if (vlOdEsfera.GetType() != typeof(string) || vlOdEsfera.Length > 5) return false;
                if (vlOeEsfera.GetType() != typeof(string) || vlOeEsfera.Length > 5) return false;
                if (vpOdEsfera.GetType() != typeof(string) || vpOdEsfera.Length > 5) return false;
                if (vpOeEsfera.GetType() != typeof(string) || vpOeEsfera.Length > 5) return false;

                if (vlOdCilindro.GetType() != typeof(string) || vlOdCilindro.Length > 5) return false;
                if (vlOeCilindro.GetType() != typeof(string) || vlOeCilindro.Length > 5) return false;
                if (vpOdCilindro.GetType() != typeof(string) || vpOdCilindro.Length > 5) return false;
                if (vpOeCilindro.GetType() != typeof(string) || vpOeCilindro.Length > 5) return false;

                if (vlOdEixo.GetType() != typeof(string) || vlOdEixo.Length > 5) return false;
                if (vlOeEixo.GetType() != typeof(string) || vlOeEixo.Length > 5) return false;
                if (vpOdEixo.GetType() != typeof(string) || vpOdEixo.Length > 5) return false;
                if (vpOeEixo.GetType() != typeof(string) || vpOeEixo.Length > 5) return false;

                if (vlOdAdicao.GetType() != typeof(string) || vlOdAdicao.Length > 5) return false;
                if (vlOeAdicao.GetType() != typeof(string) || vlOeAdicao.Length > 5) return false;
                if (vpOdAdicao.GetType() != typeof(string) || vpOdAdicao.Length > 5) return false;
                if (vpOeAdicao.GetType() != typeof(string) || vpOeAdicao.Length > 5) return false;

                if (vlOdPrisma.GetType() != typeof(string) || vlOdPrisma.Length > 5) return false;
                if (vlOePrisma.GetType() != typeof(string) || vlOePrisma.Length > 5) return false;
                if (vpOdPrisma.GetType() != typeof(string) || vpOdPrisma.Length > 5) return false;
                if (vpOePrisma.GetType() != typeof(string) || vpOePrisma.Length > 5) return false;

                if (vlOdBase.GetType() != typeof(string) || vlOdBase.Length > 5) return false;
                if (vlOeBase.GetType() != typeof(string) || vlOeBase.Length > 5) return false;
                if (vpOdBase.GetType() != typeof(string) || vpOdBase.Length > 5) return false;
                if (vpOeBase.GetType() != typeof(string) || vpOeBase.Length > 5) return false;

                if (tipoLente.GetType() != typeof(string) || tipoLente.Length > 50) return false;

                if (material.GetType() != typeof(string) || material.Length > 50) return false;

                if (cor.GetType() != typeof(string) || cor.Length > 50) return false;

                if (estado.GetType() != typeof(string) || estado.Length > 50) return false;

                if (observacaoRxFinal.GetType() != typeof(string)) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar o Rx Inicial(Classe CadastrarRxInicialRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
