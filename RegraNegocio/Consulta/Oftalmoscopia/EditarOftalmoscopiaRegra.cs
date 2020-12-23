using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;

namespace RegraNegocio
{
    public class EditarOftalmoscopiaRegra
    {
        public bool Editar(int idOftalmoscopia, string distanciaBruckner, string papilaOd, string papilaOe, string escavacaoOd, string escavacaoOe, string maculaOd, string maculaOe, string fixacaoOd, string ficacaoOe,
           string relacaoAVOd, string relacaoAVOe, string corOd, string corOe, string lenteOd, string lenteOe, string observacaoOftalmoscopia)
        {
            try
            {
                if (Validar(idOftalmoscopia,distanciaBruckner,papilaOd,papilaOe,escavacaoOd,escavacaoOe,maculaOd,maculaOe,fixacaoOd,ficacaoOe,relacaoAVOd,relacaoAVOe,corOd,corOe,lenteOd,lenteOe,observacaoOftalmoscopia) ==true)
                {
                    EditarOftalmoscopiaAcesso editarAcesso = new EditarOftalmoscopiaAcesso();
                    if (editarAcesso.EditarOftalmoscopia(Convert.ToString(idOftalmoscopia), distanciaBruckner, papilaOd, papilaOe, escavacaoOd, escavacaoOe, maculaOd, maculaOe, fixacaoOd, ficacaoOe, relacaoAVOd,
                        relacaoAVOe, corOd, corOe, lenteOd, lenteOe, observacaoOftalmoscopia) == true) return true;return false;
                }else return false;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Oftalmoscopia(Classe EditarOftalmoscopiaRegra, Método Editar)", "Erro de atualização/edição",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
        public bool Validar(int idOftalmoscopia, string distanciaBruckner, string papilaOd, string papilaOe, string escavacaoOd, string escavacaoOe, string maculaOd, string maculaOe, string fixacaoOd, string ficacaoOe,
           string relacaoAVOd, string relacaoAVOe, string corOd, string corOe, string lenteOd, string lenteOe, string observacaoOftalmoscopia)
        {
            try
            {
                if (idOftalmoscopia < 1 &&  idOftalmoscopia.GetType() != typeof(int)) return false;

                if (distanciaBruckner.GetType() != typeof(string) || distanciaBruckner.Length > 100) return false;

                if (papilaOd.GetType() != typeof(string) || papilaOd.Length > 100) return false;
                if (papilaOe.GetType() != typeof(string) || papilaOe.Length > 100) return false;

                if (escavacaoOd.GetType() != typeof(string) || escavacaoOd.Length > 100) return false;
                if (escavacaoOe.GetType() != typeof(string) || escavacaoOe.Length > 100) return false;

                if (maculaOd.GetType() != typeof(string) || maculaOd.Length > 100) return false;
                if (maculaOe.GetType() != typeof(string) || maculaOe.Length > 100) return false;

                if (fixacaoOd.GetType() != typeof(string) || fixacaoOd.Length > 100) return false;
                if (ficacaoOe.GetType() != typeof(string) || ficacaoOe.Length > 100) return false;

                if (relacaoAVOd.GetType() != typeof(string) || relacaoAVOd.Length > 100) return false;
                if (relacaoAVOe.GetType() != typeof(string) || relacaoAVOe.Length > 100) return false;

                if (corOd.GetType() != typeof(string) || corOd.Length > 100) return false;
                if (corOe.GetType() != typeof(string) || corOe.Length > 100) return false;

                if (lenteOd.GetType() != typeof(string) || lenteOd.Length > 100) return false;
                if (lenteOe.GetType() != typeof(string) || lenteOe.Length > 100) return false;

                if (observacaoOftalmoscopia.GetType() != typeof(string) || observacaoOftalmoscopia.Length > 100) return false;

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao validar a oftalmoscopia(Classe EditarOftalmoscopiaRegra, Método validar)", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return false;
        }
    }
}
