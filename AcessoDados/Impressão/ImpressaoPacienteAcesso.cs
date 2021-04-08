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
    public class imprimirPacienteAcesso
    {
        DataTable tableVazia = new DataTable();
        StringBuilder sql = new StringBuilder();
        Banco acessoBanco = new Banco();
        public DataTable impressaoCompleta(int idPaciente)
        {
            try
            {
                sql.Clear();
                sql.Append("SELECT * FROM paciente INNER JOIN endereco ON endereco.idEndereco = paciente.idEndereco INNER JOIN contato ON contato.idContato = paciente.idContato ");
                sql.Append("WHERE paciente.deletar = false AND contato.deletar = false AND  endereco.deletar = false and paciente.idPaciente = \'ID\' ");

                sql = sql.Replace("id", idPaciente.ToString());
                return acessoBanco.Pesquisar(sql.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a impressão dos dados do paciente(Classe imprimirPacienteAcesso,Método impressaoCompleta)",
                    "Erro de pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return tableVazia;
        }
    }
}
