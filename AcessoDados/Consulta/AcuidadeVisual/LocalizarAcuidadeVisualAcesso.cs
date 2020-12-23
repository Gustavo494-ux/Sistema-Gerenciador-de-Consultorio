using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Npgsql;

namespace AcessoDados
{
    public class LocalizarAcuidadeVisualAcesso
    {
        DataTable tableVazia =new DataTable();
        Banco acessoBanco = new Banco();
        public DataTable PesquisarAcuidade(string IDCONSULTA)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * from acuidadeVisual");
                sql.Append(" WHERE idConsulta = \'IDCONSULTA\' AND deletar = false;");
                sql = sql.Replace("IDCONSULTA", IDCONSULTA);
                
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar pela AcuidadeVisual(Classe LocalizarAcuidadeVisualAcesso, MétodoPesquisarAcuidade)","Erro de pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
