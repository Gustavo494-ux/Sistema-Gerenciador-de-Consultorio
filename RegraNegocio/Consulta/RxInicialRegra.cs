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
    public class RxInicialRegra
    {
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXINICIAL)
        {
            try
            {
                if (Validar( IDCONSULTA,  VLODESFERA,  VLOEESFERA,  VPODESFERA,  VPOEESFERA,  VLODCILINDRO,  VLOECILINDRO,  VPODCILINDRO,VPOECILINDRO,  VLODEIXO,  VLOEEIXO,  VPODEIXO,
                    VPOEEIXO,  AVVLOD,  AVVLOE,  AVVPOD,  AVVPOE,  ADICAO,TP,  TIPOMATERIAL,  COR,  USO,  TIPOLENTE,  OBSERVACAORXINICIAL) == true)
                {
                    RxInicialAcesso cadastrarAcesso = new RxInicialAcesso();
                    if (cadastrarAcesso.CadastrarRxInicial(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE, ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXINICIAL) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o Rx Inicial(Classe RxInicialRegra, Método Cadastrar)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Validar(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXINICIAL)
        {
            try
            {
                if (VLODESFERA.Length > 20) return false;
                if (VLOEESFERA.Length > 20) return false;
                if (VPODESFERA.Length > 20) return false;
                if (VPOEESFERA.Length > 20) return false;

                if ( VLODCILINDRO.Length > 20) return false;
                if (VLOECILINDRO.Length > 20) return false;
                if (VPODCILINDRO.Length > 20) return false;
                if (VPOECILINDRO.Length > 20) return false;

                if (VLODEIXO.Length > 20) return false;
                if (VLOEEIXO.Length > 20) return false;
                if (VPODEIXO.Length > 20) return false;
                if (VPOEEIXO.Length > 20) return false;

                if (AVVLOD.Length > 20) return false;
                if (AVVLOE.Length > 20) return false;
                if (AVVPOD.Length > 20) return false;
                if (AVVPOE.Length > 20) return false;

                if (ADICAO.Length > 50) return false;

                if (TP.Length > 50) return false;
                if (TIPOMATERIAL.Length > 50) return false;
                if (COR.Length > 50) return false;

                if (USO.Length > 50) return false;
                if (TIPOLENTE.Length > 50) return false;
                if (OBSERVACAORXINICIAL.GetType() != typeof(string) ) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar o Rx Inicial(Classe RxInicialRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public bool Editar(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXINICIAL)
        {
            try
            {
                if (Validar(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE, ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXINICIAL) == true)
                {
                    RxInicialAcesso EditarAcesso = new RxInicialAcesso();
                    if (EditarAcesso.EditarRxInicial(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE, ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXINICIAL) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o Rx Inicial(Classe RxInicialRegra, Método Editar)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarRxInicial(string idRxInicial)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                RxInicialAcesso pesquisar = new RxInicialAcesso();
                if (Convert.ToInt32(idRxInicial) > 0) dadosTabela = pesquisar.PesquisarRxInicial(idRxInicial);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxInicial(Classe RxInicialRegra, Método PesquisaRxInicial) ", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
