using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_Pagamento
    {
        Conexao conexao = new Conexao();

        #region Adicionar Pagamento

        public string Adicionar(DTO_Pagamento pagamento)
        {
            try
            {
                string comando = "insert into tb_pagamento (tb_pagamento_id,  tb_pagamento_responsavel,tb_pagamento_data, tb_pagamento_valor, tb_armario_id)"
                + "values(@pag_id, @pag_resp,@pag_data, @pag_valor, @Armario_id)";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@pag_id", pagamento.Pag_id);
                conexao.AdicionarParametro("@pag_resp", pagamento.Pag_resp_nome);
                conexao.AdicionarParametro("@pag_data", pagamento.Pag_data);
                conexao.AdicionarParametro("@pag_valor", pagamento.Pag_valor);
                conexao.AdicionarParametro("@Armario_id", pagamento.Id_armario);


                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        #endregion

        #region Alterar Pagamento

        public string Alterar(DTO_Pagamento pagamento)
        {
            try
            {

                string comando = "update tb_pagamento set  tb_pagamento_responsavel=@pag_resp, tb_pagamento_data=@pag_data,"
                                + "tb_pagamento_valor=@pag_valor  where tb_pagamento_id=@pag_id and tb_armario_id=@Armario_id";

             
                conexao.LimparParametro();
                conexao.AdicionarParametro("@pag_id", pagamento.Pag_id);
                conexao.AdicionarParametro("@pag_resp", pagamento.Pag_resp_nome);
                conexao.AdicionarParametro("@pag_data", pagamento.Pag_data);
                conexao.AdicionarParametro("@pag_valor", pagamento.Pag_valor);
                conexao.AdicionarParametro("@Armario_id", pagamento.Id_armario);


                string retorno = Convert.ToString(conexao.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        #endregion

        #region Deletar Pagamento

        public string Excluir(DTO_Pagamento pagamento)
        {
            try
            {
                string comando = @"delete from tb_pagamento where tb_pagamento_id=@pag_id";

                conexao.LimparParametro();
                conexao.AdicionarParametro("@pag_id", pagamento.Pag_id);

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

        #region Selecionar todos os pagamentos

        public DTO_ColecaoPagamento SelecionarPagamento()
        {

            try
            {

                DTO_ColecaoPagamento colecaopagamento = new DTO_ColecaoPagamento();
                string comando = "select * from tb_pagamento LIMIT 100";

                DataTable dt = conexao.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)

                {
                    DTO_Pagamento pagamento = new DTO_Pagamento();
                    pagamento.Pag_id = Convert.ToInt32(linha["tb_pagamento_id"]);
                    pagamento.Pag_resp_nome = linha["tb_pagamento_responsavel"].ToString();
                    pagamento.Pag_data = Convert.ToDateTime(linha["tb_pagamento_data"]);
                    pagamento.Pag_valor = Convert.ToDecimal(linha["tb_pagamento_valor"]);
                    pagamento.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                  
                    




                    colecaopagamento.Add(pagamento);

                }

                return colecaopagamento;

            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        #endregion

        #region Selecionar Pagamento especifico

        public DTO_ColecaoPagamento SelecionarPagamentoEspecifico(DTO_Pagamento pagamento)
        {

            try
            {

                DTO_ColecaoPagamento colecaopagamento = new DTO_ColecaoPagamento();
                string comando = "select * from tb_pagamento where tb_armario_id like '%" + pagamento.Id_armario + "%'";

                conexao.LimparParametro();

                DataTable dt = conexao.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Pagamento pagamento2 = new DTO_Pagamento();
                    pagamento2.Pag_id = Convert.ToInt32(linha["tb_pagamento_id"]);
                    pagamento2.Pag_resp_nome = linha["tb_pagamento_responsavel"].ToString();
                    pagamento2.Pag_data = Convert.ToDateTime(linha["tb_pagamento_data"]);
                    pagamento2.Pag_valor = Convert.ToDecimal(linha["tb_pagamento_valor"]);
                    pagamento2.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);






                    colecaopagamento.Add(pagamento2);

                }

                return colecaopagamento;

            }


            catch (Exception erro)
            {

                throw erro;
            }


        }
        #endregion

        #region Carregar Locacao

        public DataTable CarregarLocacao()
        {
            string comando = "select * from tb_locacao";

            DataTable dataS = conexao.ConsultarRegistros(comando, CommandType.Text);

            return dataS;
        }
        #endregion


    }
}
