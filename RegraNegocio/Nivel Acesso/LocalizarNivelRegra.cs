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
    public class LocalizarNivelRegra

    {
        DataTable dadosTabelaRegra, tableVazia;
        string idNivel = null;
        public DataTable TodosNiveis()
        {
            try
            {
                localizarNivelAcesso pesquisarNivel = new localizarNivelAcesso();
                dadosTabelaRegra = pesquisarNivel.TodosNiveis();
                if (dadosTabelaRegra.Rows.Count > 0)return dadosTabelaRegra;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro("+ex.Message+") ao pesquisar os niveis de acesso(Classe LocalizarNivelRegra, Método TodosNiveis) ","Erro de Pesquisa",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
        public DataTable retornaridNivel(string nome)
        {
            try
            {
                localizarNivelAcesso pesquisarNivel = new localizarNivelAcesso();
                dadosTabelaRegra = pesquisarNivel.retornaridNivel(nome);
                if (dadosTabelaRegra.Rows.Count > 0)return dadosTabelaRegra;
                else
                {
                    MessageBox.Show("Registros não encontrados", "Pesquisa efetuada com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro(" + ex.Message + ") ao pesquisar os niveis de acesso(Classe LocalizarNivelRegra, Método retornaridNivel) ", "Erro de Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
