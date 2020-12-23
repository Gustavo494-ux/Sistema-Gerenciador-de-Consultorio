    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using AcessoDados;

namespace RegraNegocio
{
    public class ImpressaoPacienteRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(string idPaciente)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                imprimirPacienteAcesso pesquisar = new imprimirPacienteAcesso();
                dadosTabela = pesquisar.impressaoCompleta(Convert.ToInt32(idPaciente));
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do paciente(Classe ImpressaoPacienteRegra,Método impressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
