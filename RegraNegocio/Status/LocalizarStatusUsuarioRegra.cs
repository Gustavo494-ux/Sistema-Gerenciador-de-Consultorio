using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcessoDados;



namespace RegraNegocio
{
    public class LocalizarStatusUsuarioRegra
    {
        DataTable dadosTabelaRegra = new DataTable();
        DataTable tableVazia = new DataTable();
        public DataTable TodosStatus()
        {
            try
            {
                LocalizarstatusUsuarioAcesso pesquisarStatusUsuario = new LocalizarstatusUsuarioAcesso();
                dadosTabelaRegra = pesquisarStatusUsuario.TodosStatus();
                if (dadosTabelaRegra.Rows.Count >0) return dadosTabelaRegra;MessageBox.Show("Registros de status não encontrados","Consulta bem Sucedida!",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar os status do usuario(Classe LocalizarStatusUsuarioRegra, Método TodosStatus","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return tableVazia;
        }
    }
}
