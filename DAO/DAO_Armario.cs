using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace DAO
{
    public class DAO_Armario
    {
        Conexao conexao = new Conexao();

        #region Inserir Armario

        public string Inserir(DTO_Armario armario)
        {
            try
            {
                string comando = "insert into tb_armario (tb_armario_id, tb_armario_local, tb_armario_descricao, tb_armario_status, tb_armario_valor)"
                + "values(@Armario_ID, @Armario_LOCAL, @Armario_DESCRICAO, @Armario_STATUS, @Armario_VALOR)";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@Armario_ID", armario.Id_armario);
                conexao.AdicionarParametro("@Armario_LOCAL", armario.Local_armario);
                conexao.AdicionarParametro("@Armario_DESCRICAO", armario.Descricao_armario);
                conexao.AdicionarParametro("@Armario_STATUS", armario.Status_armario);
                conexao.AdicionarParametro("@Armario_VALOR", armario.Valor_armario);

                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        #endregion

        //alterar aluno
        #region Alterar Armario

        public string Alterar(DTO_Armario armario)
        {
            try
            {

                string comando = "update tb_armario set tb_armario_id=@Armario_ID, tb_armario_local=@Armario_LOCAL,"
                                + "tb_armario_descricao=@Armario_DESCRICAO, tb_armario_status=@Armario_STATUS, tb_armario_valor=@Armario_VALOR where tb_armario_id=@Armario_id";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@Armario_ID", armario.Id_armario);
                conexao.AdicionarParametro("@Armario_LOCAL", armario.Local_armario);
                conexao.AdicionarParametro("@Armario_DESCRICAO", armario.Descricao_armario);
                conexao.AdicionarParametro("@Armario_STATUS", armario.Status_armario);
                conexao.AdicionarParametro("@Armario_VALOR", armario.Valor_armario);

                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        #endregion

        //apagar aluno
        #region Deletar Armario

        public string Excluir(DTO_Armario armario)
        {
            try
            {
                string comando = @"delete from tb_armario where tb_armario_id=@Armario_ID";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@Armario_ID", armario.Id_armario);

                //executANDO O METODO DE MANIPULAÇÃO
                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        #endregion

        #region Seleciona Armario

        public ColecaoArmario SelecionarArmarios()
        {

            try
            {

                ColecaoArmario colecaoarmario = new ColecaoArmario();
                string comando = "select * from tb_armario LIMIT 100";

                DataTable dt = conexao.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Armario armario = new DTO_Armario();
                    armario.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                    armario.Local_armario = linha["tb_armario_local"].ToString();
                    armario.Descricao_armario = linha["tb_armario_descricao"].ToString();
                    armario.Status_armario = linha["tb_armario_status"].ToString();
                    armario.Valor_armario = Convert.ToDecimal(linha["tb_armario_valor"]);




                    colecaoarmario.Add(armario);



                }

                return colecaoarmario;


            }


            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion


        #region Selecionar Armario especifico

        public ColecaoArmario SelecionarArmEspecifico(DTO_Armario armario)
        {

            try
            {

                ColecaoArmario colecaoarmario = new ColecaoArmario();
                string comando = "select * from tb_armario where tb_armario_status like '%" + armario.Status_armario + "%'";

                conexao.LimparParametro();

                DataTable dt = conexao.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Armario armario1 = new DTO_Armario();
                    armario1.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                    armario1.Local_armario = linha["tb_armario_local"].ToString();
                    armario1.Descricao_armario = linha["tb_armario_descricao"].ToString();
                    armario1.Status_armario = linha["tb_armario_status"].ToString();
                    armario1.Valor_armario = Convert.ToDecimal(linha["tb_armario_valor"]);


                    colecaoarmario.Add(armario1);



                }

                return colecaoarmario;

            }


            catch (Exception erro)
            {

                throw erro;
            }


        }
        #endregion

    }
}
