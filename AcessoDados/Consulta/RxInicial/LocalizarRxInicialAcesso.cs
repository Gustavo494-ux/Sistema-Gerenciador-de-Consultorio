using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace AcessoDados
{
    public class LocalizarRxInicialAcesso
    {
        DataTable tableVazia = new DataTable();
        Banco acessoBanco = new Banco();
        StringBuilder sql = new StringBuilder();
        public DataTable PesquisarRxInicial(string IDCONSULTA)
        {
            try
            {
                sql.Append("select vlOdEsfera,vlOeEsfera,vpOdEsfera,vpOeEsfera,vlOdCilindro,vlOeCilindro,vpOdCilindro,vpOeCilindro,vlOdEixo,vlOeEixo,vpOdEixo,vpOeEixo, ");
                sql.Append("vlOdAdicao,vlOeAdicao,vpOdAdicao,vpOeAdicao,vlOdPrisma,vlOePrisma,vpOdPrisma,vpOePrisma,vlOdBase,vlOeBase,vpOdBase, vpOeBase,tipoLente, ");
                sql.Append("material,cor,estado, observacaoRxInicial from RxInicial ");
                sql.Append("where idConsulta = IDCONSULTA and deletar = false;");

                return acessoBanco.Pesquisar(sql.Replace("IDCONSULTA", IDCONSULTA).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquiar pelo RxInicial(Classe LocalizarRxInicialAcesso, Método PesquisarRxInicial)", "Erro de pesquisa",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
