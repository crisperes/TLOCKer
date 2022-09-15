using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
   public class DAO_Locacao
    {
        Conexao conexao = new Conexao();

        #region Adicionar Locação

        public string Adicionar(DTO_Locacao locacao)
        {
            try
            {
                string comando = "insert into tb_locacao (tb_locacao_id,  tb_locacao_data,tb_locacao_tipo, tb_locacao_valor, tb_aluno_rm, tb_armario_id, tb_usuario_id,tb_pagamento_id)"
                + "values(@Locacao_id, @Locacao_data,@Locacao_tipo, @Locacao_valor, @rm, @Armario_id, @id,@pag_id)";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@Locacao_id", locacao.Locacao_id);
                conexao.AdicionarParametro("@Locacao_data", locacao.Locacao_data);
                conexao.AdicionarParametro("@Locacao_tipo", locacao.Locacao_tipo);
                conexao.AdicionarParametro("@Locacao_valor", locacao.Locacao_valor);
                conexao.AdicionarParametro("@rm", locacao.Rm_alu);
                conexao.AdicionarParametro("@Armario_id", locacao.Id_armario);
                conexao.AdicionarParametro("@id", locacao.Id_usu);
                conexao.AdicionarParametro("@pag_id", locacao.Pag_id);
                

                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        #endregion

        #region Alterar Locação

        public string Alterar(DTO_Locacao locacao)
        {
            try
            {

                string comando = "update tb_locacao set  tb_locacao_data=@Locacao_data,tb_locacao_tipo=@Locacao_tipo, tb_locacao_valor=@Locacao_valor,"
                                + "tb_aluno_rm=@rm, tb_armario_id=@Armario_id, tb_usuario_id=@id,tb_pagamento_id=@pag_id where tb_locacao_id=@Locacao_id";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@Locacao_id", locacao.Locacao_id);
                conexao.AdicionarParametro("@Locacao_data", locacao.Locacao_data);
                conexao.AdicionarParametro("@Locacao_tipo", locacao.Locacao_tipo);
                conexao.AdicionarParametro("@Locacao_valor", locacao.Locacao_valor);
                conexao.AdicionarParametro("@rm", locacao.Rm_alu);
                conexao.AdicionarParametro("@Armario_id", locacao.Id_armario);
                conexao.AdicionarParametro("@id", locacao.Id_usu);
                conexao.AdicionarParametro("@pag_id", locacao.Pag_id);

                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        #endregion

        #region Selecionar locacao

        public DTO_ColecaoLocacao SelecionarLocacao()
        {

            try
            {

                DTO_ColecaoLocacao colecaolocacao = new DTO_ColecaoLocacao();
                string comando = "select * from tb_locacao inner join tb_aluno on tb_locacao.tb_aluno_rm = tb_aluno.tb_aluno_rm LIMIT 100";

                DataTable dt = conexao.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)

                {
                    DTO_Locacao locacao = new DTO_Locacao();
                    locacao.Locacao_id = Convert.ToInt32(linha["tb_locacao_id"]);
                    locacao.Locacao_data = Convert.ToDateTime(linha["tb_locacao_data"]);
                    locacao.Locacao_tipo = linha["tb_locacao_tipo"].ToString();
                    locacao.Locacao_valor = Convert.ToDecimal(linha["tb_locacao_valor"]);
                    locacao.Rm_alu = Convert.ToInt32(linha["tb_aluno_rm"]);
                    locacao.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                    locacao.Id_usu = Convert.ToInt32(linha["tb_usuario_id"]);
                    locacao.Pag_id = Convert.ToInt32(linha["tb_pagamento_id"]);
                    locacao.Nome_alu = linha["tb_aluno_nome"].ToString();




                    colecaolocacao.Add(locacao);

                }

                return colecaolocacao;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        #endregion

        #region Selecionar Locação especifica

        public DTO_ColecaoLocacao SelecionarLocacaoEspecifica(DTO_Locacao locacao)
        {

            try
            {

                DTO_ColecaoLocacao colecaolocacao = new DTO_ColecaoLocacao();
                string comando = "select * from tb_locacao inner join tb_aluno on tb_locacao.tb_aluno_rm = tb_aluno.tb_aluno_rm   where tb_armario_id like '%" + locacao.Id_armario + "%'";

                conexao.LimparParametro();

                DataTable dt = conexao.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Locacao locacao2 = new DTO_Locacao();
                    locacao2.Locacao_id = Convert.ToInt32(linha["tb_locacao_id"]);
                    locacao2.Locacao_data = Convert.ToDateTime(linha["tb_locacao_data"]);
                    locacao2.Locacao_tipo = linha["tb_locacao_tipo"].ToString();
                    locacao2.Locacao_valor = Convert.ToDecimal(linha["tb_locacao_valor"]);
                    locacao2.Rm_alu = Convert.ToInt32(linha["tb_aluno_rm"]);
                    locacao2.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                    locacao2.Id_usu = Convert.ToInt32(linha["tb_usuario_id"]);
                    locacao2.Pag_id = Convert.ToInt32(linha["tb_pagamento_id"]);
                    locacao2.Nome_alu = linha["tb_aluno_nome"].ToString();

                    colecaolocacao.Add(locacao2);



                }

                return colecaolocacao;

            }


            catch (Exception erro)
            {

                throw erro;
            }


        }
        #endregion

        #region Carregar Usuario

        public DataTable CarregarUsuario()
        {
            string comando = "select * from tb_usuario";

            DataTable dataR = conexao.ConsultarRegistros(comando, CommandType.Text);

            return dataR;
        }
        #endregion


        #region Carregar Aluno

        public DataTable CarregarAluno()
        {
            string comando = "select * from tb_aluno";

            DataTable dataT = conexao.ConsultarRegistros(comando, CommandType.Text);

            return dataT;
        }
        #endregion

        #region Carregar Armario

        public DataTable CarregarArmario()
        {
            string comando = "select * from tb_armario";

            DataTable dataS = conexao.ConsultarRegistros(comando, CommandType.Text);

            return dataS;
        }
        #endregion

        #region Deletar Locacao

        public string Excluir(DTO_Locacao locacao)
        {
            try
            {
                string comando = @"delete from tb_locacao where tb_locacao_id=@Locacao_id";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@Locacao_id", locacao.Locacao_id);

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
    }
}
