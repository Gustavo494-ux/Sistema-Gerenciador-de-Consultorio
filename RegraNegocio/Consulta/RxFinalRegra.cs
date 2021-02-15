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
    public class RxFinalRegra
    {
        DataTable tableVazia = new DataTable();
        public bool Cadastrar(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
             string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE,string DNPOD,string DNPOE, string ADICAO,
             string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXFINAL)
        {
            try
            {
                if (Validar(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE,DNPOD,DNPOE,ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXFINAL) == true)
                {
                    RxFinalAcesso cadastrarAcesso = new RxFinalAcesso();
                    if (cadastrarAcesso.CadastrarRxFinal(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE, DNPOD, DNPOE, ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXFINAL) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o RxFinal(Classe RxFinalRegra, Método Cadastrar)", "Erro de Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Validar(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE,string DNPOD,string DNPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXFINAL)
        {
            try
            {
                if (VLODESFERA.Length > 20) return false;
                if (VLOEESFERA.Length > 20) return false;
                if (VPODESFERA.Length > 20) return false;
                if (VPOEESFERA.Length > 20) return false;

                if (VLODCILINDRO.Length > 20) return false;
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

                if (DNPOD.Length > 20) return false;
                if (DNPOE.Length > 20) return false;

                if (ADICAO.Length > 50) return false;

                if (TP.Length > 50) return false;
                if (TIPOMATERIAL.Length > 50) return false;
                if (COR.Length > 50) return false;

                if (USO.Length > 50) return false;
                if (TIPOLENTE.Length > 50) return false;
                if (OBSERVACAORXFINAL.GetType() != typeof(string)) return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar o RxFinal(Classe RxFinalRegra, Método Validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }
        public bool Editar(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string AVVLOD, string AVVLOE, string AVVPOD, string AVVPOE,string DNPOD,string DNPOE, string ADICAO,
            string TP, string TIPOMATERIAL, string COR, string USO, string TIPOLENTE, string OBSERVACAORXFINAL)
        {
            try
            {
                if (Validar(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE,DNPOD,DNPOE, ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXFINAL) == true)
                {
                    RxFinalAcesso EditarAcesso = new RxFinalAcesso();
                    if (EditarAcesso.EditarRxFinal(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO,
                    VPOEEIXO, AVVLOD, AVVLOE, AVVPOD, AVVPOE,DNPOD,DNPOE, ADICAO, TP, TIPOMATERIAL, COR, USO, TIPOLENTE, OBSERVACAORXFINAL) == true) return true; return false;
                }
                else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o RxFinal(Classe RxFinalRegra, Método Editar)", "Erro de atualização/edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public DataTable PesquisarRxFinal(string idRxFinal)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                RxFinalAcesso pesquisar = new RxFinalAcesso();
                if (Convert.ToInt32(idRxFinal) > 0) dadosTabela = pesquisar.PesquisarRxFinal(idRxFinal);
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pelo RxFinal(Classe RxFinalRegra, Método PesquisarRxFinal) ", "Erro de pesquisa",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
