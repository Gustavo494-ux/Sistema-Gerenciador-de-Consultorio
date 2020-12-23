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
    public class ImpressaoUsuarioRegra
    {
        DataTable tableVazia = new DataTable();
        public DataTable impressaoCompleta(string idUsuario)
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                ImprimirUsuarioAcesso pesquisar = new ImprimirUsuarioAcesso();
                dadosTabela = pesquisar.impressaoCompleta(Convert.ToInt32(idUsuario));
                return dadosTabela;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do usuario(Classe ImpressaoUsuarioRegra,Método impressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
