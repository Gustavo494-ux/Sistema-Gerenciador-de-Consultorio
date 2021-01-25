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
    public class LensometriaRegra
    {
        DataTable tableVazia = new DataTable();
        LensometriaAcesso lensometria = new LensometriaAcesso();

        public bool CadastrarLensometria(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string VLODADICAO, string VLOEADICAO, string VPODADICAO, string VPOEADICAO, string VLODPRISMA,
            string VLOEPRISMA, string VPODPRISMA, string VPOEPRISMA, string VLODBASE, string VLOEBASE, string VPODBASE, string VPOEBASE, string TIPOLENTE, string MATERIAL, string COR, string ESTADO,
            string OBSERVACAOLENSOMETRIA)
        {
            try
            {
                if (ValidarLensometria(IDCONSULTA,VLODESFERA,VLOEESFERA,VPODESFERA,VPOEESFERA,VLODCILINDRO,VLOECILINDRO,VPODCILINDRO,VPOECILINDRO,VLODEIXO,VLOEEIXO,VPODEIXO,VPOEEIXO, VLODADICAO,
                    VLOEADICAO,VPODADICAO,VPOEADICAO,VLODPRISMA,VLOEPRISMA,VPODPRISMA,VPOEPRISMA,VLODBASE,VLOEBASE,VPODBASE,VPOEBASE,TIPOLENTE,MATERIAL,COR,ESTADO,OBSERVACAOLENSOMETRIA))
                {
                    return lensometria.CadastrarLensometria(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO,
                        VLOEEIXO, VPODEIXO, VPOEEIXO, VLODADICAO, VLOEADICAO, VPODADICAO, VPOEADICAO, VLODPRISMA, VLOEPRISMA, VPODPRISMA, VPOEPRISMA, VLODBASE, VLOEBASE,
                        VPODBASE, VPOEBASE, TIPOLENTE, MATERIAL, COR, ESTADO, OBSERVACAOLENSOMETRIA);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar o cadastro da Lensometria(Classe LensometriaRegra, Método CadastrarLensometria)", "Erro de Cadastro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
        public bool AtualizarLensometria(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string VLODADICAO, string VLOEADICAO, string VPODADICAO, string VPOEADICAO, string VLODPRISMA,
            string VLOEPRISMA, string VPODPRISMA, string VPOEPRISMA, string VLODBASE, string VLOEBASE, string VPODBASE, string VPOEBASE, string TIPOLENTE, string MATERIAL, string COR, string ESTADO,
            string OBSERVACAOLENSOMETRIA)
        {
            try
            {
                if (ValidarLensometria(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO, VLOEEIXO, VPODEIXO, VPOEEIXO, VLODADICAO,
                   VLOEADICAO, VPODADICAO, VPOEADICAO, VLODPRISMA, VLOEPRISMA, VPODPRISMA, VPOEPRISMA, VLODBASE, VLOEBASE, VPODBASE, VPOEBASE, TIPOLENTE, MATERIAL, COR, ESTADO, OBSERVACAOLENSOMETRIA))
                {
                    return lensometria.AtualizarLensometria(IDCONSULTA, VLODESFERA, VLOEESFERA, VPODESFERA, VPOEESFERA, VLODCILINDRO, VLOECILINDRO, VPODCILINDRO, VPOECILINDRO, VLODEIXO,
                        VLOEEIXO, VPODEIXO, VPOEEIXO, VLODADICAO, VLOEADICAO, VPODADICAO, VPOEADICAO, VLODPRISMA, VLOEPRISMA, VPODPRISMA, VPOEPRISMA, VLODBASE, VLOEBASE,
                        VPODBASE, VPOEBASE, TIPOLENTE, MATERIAL, COR, ESTADO, OBSERVACAOLENSOMETRIA);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar a Lensometria(Classe LensometriaAcesso, Método AtualizarLensometria)", "Erro de Atualização",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        public bool ValidarLensometria(string IDCONSULTA, string VLODESFERA, string VLOEESFERA, string VPODESFERA, string VPOEESFERA, string VLODCILINDRO, string VLOECILINDRO, string VPODCILINDRO,
            string VPOECILINDRO, string VLODEIXO, string VLOEEIXO, string VPODEIXO, string VPOEEIXO, string VLODADICAO, string VLOEADICAO, string VPODADICAO, string VPOEADICAO, string VLODPRISMA,
            string VLOEPRISMA, string VPODPRISMA, string VPOEPRISMA, string VLODBASE, string VLOEBASE, string VPODBASE, string VPOEBASE, string TIPOLENTE, string MATERIAL, string COR, string ESTADO,
            string OBSERVACAOLENSOMETRIA)
        {
            try
            {
                if (Convert.ToInt32(IDCONSULTA) < 0) return false;

                if (VLODESFERA.Length > 5) return false;
                if (VLOEESFERA.Length > 5) return false;
                if (VPODESFERA.Length > 5) return false;
                if (VPOEESFERA.Length > 5) return false;

                if (VLODCILINDRO.Length > 5) return false;
                if (VLOECILINDRO.Length > 5) return false;
                if (VPODCILINDRO.Length > 5) return false;
                if (VPOECILINDRO.Length > 5) return false;

                if (VLODEIXO.Length > 5) return false;
                if (VLOEEIXO.Length > 5) return false;
                if (VPODEIXO.Length > 5) return false;
                if (VPOEEIXO.Length > 5) return false;

                if (VLODADICAO.Length > 5) return false;
                if (VLOEADICAO.Length > 5) return false;
                if (VPODADICAO.Length > 5) return false;
                if (VPOEADICAO.Length > 5) return false;

                if (VLODPRISMA.Length > 5) return false;
                if (VLOEPRISMA.Length > 5) return false;
                if (VPODPRISMA.Length > 5) return false;
                if (VPOEPRISMA.Length > 5) return false;

                if (VLODBASE.Length > 5) return false;
                if (VLOEBASE.Length > 5) return false;
                if (VPODBASE.Length > 5) return false;
                if (VPOEBASE.Length > 5) return false;

                if (TIPOLENTE.Length > 50) return false;
                if (MATERIAL.Length > 50) return false;
                if (COR.Length > 50) return false;
                if (ESTADO.Length > 50) return false;
                if (OBSERVACAOLENSOMETRIA.GetType() != typeof(string)) ;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao realizar a validação da Lensometria(Classe LensometriaRegra, Método ValidarLensometria)", "Erro de Validação",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return true;
        }

        public DataTable PesquisarLensometria(string idConsulta)
        {
            try
            {
                return lensometria.PesquisarLensometria(idConsulta);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao pesquisar a Lensometria(Classe LensometriaRegra, método PesquisarLensometria)", "Erro de Pesquisa",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tableVazia;
        }
    }
}
