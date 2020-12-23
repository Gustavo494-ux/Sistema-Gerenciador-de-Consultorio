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
    public class EditarProfissionalRegra
    {
        public DataTable RetornarDados(string idProfissional)
        {
            DataTable tableVazia = new DataTable();
            DataTable dadosTabela = new DataTable();
            try
            {
                if (Convert.ToInt32(idProfissional) > 0)
                {

                    EditarProfissionalAcesso Editar = new EditarProfissionalAcesso();
                  dadosTabela=  Editar.RetornarDados(Convert.ToInt32(idProfissional));
                    return dadosTabela;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe EditarProfissionalRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;

        }
        public bool Atualizar(string idProfissional, string nomeProfissional, string especialidade, string rg, string cpf, string sexo, string croo, string dataNascimento, string observacaoProfissional)
        {
			try
			{
                if (Convert.ToInt32(idProfissional)>0)
                {
                    CadastrarProfissionalRegraNegocio validar = new CadastrarProfissionalRegraNegocio();
                    //As informações colocadas diretamente são informações que nunca são alteredas então não precisam passar por validação antes da atualização do registro no sistema.
                    if(validar.Verificar("0","1","1","1",nomeProfissional,especialidade,rg,cpf,sexo,croo,dataNascimento,"","",observacaoProfissional)==true)
                    {
                        EditarProfissionalAcesso Editar = new EditarProfissionalAcesso();
                        return Editar.Atualizar(Convert.ToInt32(idProfissional), nomeProfissional, especialidade, rg, cpf.Replace(".","").Replace("-","").Replace(",",""), sexo, croo, Convert.ToDateTime(dataNascimento),
                            observacaoProfissional);

                    }
                }
			}
			catch (Exception)
			{ 
                MessageBox.Show("Ocorreu um erro ao atualizar os dados do Profissional(Classe EditarProfissionalRegra, Método Atualizar)", "Erro de Atualização", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
