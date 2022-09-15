using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class DAO_Aluno
    {
        Conexao conexaomysql = new Conexao();

        #region Inserir Aluno

        public string Inserir(DTO_Aluno aluno)
        {
            try
            {
                string comando = "insert into TB_ALUNO (TB_ALUNO_RM, TB_ALUNO_TURMA, TB_ALUNO_NOME, TB_ALUNO_CPF,"
                    + "TB_ALUNO_EMAIL, TB_ALUNO_TELEFONE, TB_ALUNO_RESP_NOME, TB_ALUNO_RESP_CPF, TB_ALUNO_RESP_EMAIL, TB_ALUNO_RESP_TELEFONE)"
                + "values(@rm, @turma, @aluno_nome, @aluno_cpf, @aluno_email, @aluno_telefone, @resp_nome, "
                + "@resp_cpf, @resp_email, @resp_telefone)";

                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@rm", aluno.Rm_alu);
                conexaomysql.AdicionarParametro("@turma", aluno.Turma_alu);
                conexaomysql.AdicionarParametro("@aluno_nome", aluno.Nome_alu);
                conexaomysql.AdicionarParametro("@aluno_cpf", aluno.Cpf_alu);
                conexaomysql.AdicionarParametro("@aluno_email", aluno.Email_alu);
                conexaomysql.AdicionarParametro("@aluno_telefone", aluno.Telefone_alu);
                conexaomysql.AdicionarParametro("@resp_nome", aluno.Resp_nome_alu);
                conexaomysql.AdicionarParametro("@resp_cpf", aluno.Resp_cpf_alu);
                conexaomysql.AdicionarParametro("@resp_email", aluno.Resp_email_alu);
                conexaomysql.AdicionarParametro("@resp_telefone", aluno.Resp_telefone_alu);

                string retorno = Convert.ToString(conexaomysql.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        #endregion

        #region Alterar Aluno

        public string Alterar(DTO_Aluno aluno)
        {
            try
            {

                string comando = "update tb_aluno set tb_aluno_rm=@rm, tb_aluno_turma=@turma,"
                                + "tb_aluno_nome=@aluno_nome, tb_aluno_cpf=@aluno_cpf, tb_aluno_email=@aluno_email, "
                                + "tb_aluno_telefone=@aluno_telefone, tb_aluno_resp_nome=@resp_nome, tb_aluno_resp_cpf=@resp_cpf,"
                                + " tb_aluno_resp_email=@resp_email, tb_aluno_resp_telefone=@resp_telefone  where tb_aluno_rm=@rm";

                conexaomysql.LimparParametro();
                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@rm", aluno.Rm_alu);
                conexaomysql.AdicionarParametro("@turma", aluno.Turma_alu);
                conexaomysql.AdicionarParametro("@aluno_nome", aluno.Nome_alu);
                conexaomysql.AdicionarParametro("@aluno_cpf", aluno.Cpf_alu);
                conexaomysql.AdicionarParametro("@aluno_email", aluno.Email_alu);
                conexaomysql.AdicionarParametro("@aluno_telefone", aluno.Telefone_alu);
                conexaomysql.AdicionarParametro("@resp_nome", aluno.Resp_nome_alu);
                conexaomysql.AdicionarParametro("@resp_cpf", aluno.Resp_cpf_alu);
                conexaomysql.AdicionarParametro("@resp_email", aluno.Resp_email_alu);
                conexaomysql.AdicionarParametro("@resp_telefone", aluno.Resp_telefone_alu);

                string retorno = Convert.ToString(conexaomysql.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }


        #endregion

        #region Deletar Aluno

        public string Excluir(DTO_Aluno aluno)
        {
            try
            {
                string comando = @"delete from tb_aluno where tb_aluno_rm=@rm";

                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@rm", aluno.Rm_alu);

                //executANDO O METODO DE MANIPULAÇÃO
                string retorno = Convert.ToString(conexaomysql.ManipularDados(comando, CommandType.Text));

                return retorno;
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        #endregion

        #region Seleciona Aluno

        public ColecaoAluno SelecionarAlunos()
        {

            try
            {

                ColecaoAluno colecaoaluno = new ColecaoAluno();
                string comando = "select * from tb_aluno alu left join tb_locacao loc  on loc.tb_aluno_rm = alu.tb_aluno_rm left join tb_armario arm on arm.tb_armario_id = loc.tb_armario_id order by alu.tb_aluno_rm asc LIMIT 100";

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Aluno aluno = new DTO_Aluno();
                    aluno.Rm_alu = Convert.ToInt32(linha["tb_aluno_rm"]);
                    aluno.Turma_alu = linha["tb_aluno_turma"].ToString();
                    aluno.Nome_alu = linha["tb_aluno_nome"].ToString();
                    aluno.Cpf_alu = linha["tb_aluno_cpf"].ToString();
                    aluno.Email_alu = linha["tb_aluno_email"].ToString();
                    aluno.Telefone_alu = linha["tb_aluno_telefone"].ToString();
                    aluno.Resp_nome_alu = linha["tb_aluno_resp_nome"].ToString();
                    aluno.Resp_cpf_alu = linha["tb_aluno_resp_cpf"].ToString();
                    aluno.Resp_email_alu = linha["tb_aluno_resp_email"].ToString();
                    aluno.Resp_telefone_alu = linha["tb_aluno_resp_telefone"].ToString();
                    aluno.Locacao_tipo = linha["tb_locacao_tipo"].ToString();
                    if (linha["tb_armario_id"] != DBNull.Value)
                        aluno.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                    else
                    {
                        
                    }
                     
                    
                    colecaoaluno.Add(aluno);


                }

                return colecaoaluno;


            }


            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Selecionar Aluno especifico

        public ColecaoAluno SelecionarAlunoEspecifico(DTO_Aluno aluno)
        {

            try
            {

                ColecaoAluno colecaoaluno = new ColecaoAluno();
                string comando = "select * from tb_aluno alu left join tb_locacao loc  on loc.tb_aluno_rm = alu.tb_aluno_rm left join tb_armario arm on arm.tb_armario_id = loc.tb_armario_id  where alu.tb_aluno_rm like '%" + aluno.Rm_alu + "%'order by alu.tb_aluno_rm asc";

                conexaomysql.LimparParametro();

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Aluno aluno1 = new DTO_Aluno();
                    aluno1.Rm_alu = Convert.ToInt32(linha["tb_aluno_rm"]);
                    aluno1.Turma_alu = linha["tb_aluno_turma"].ToString();
                    aluno1.Nome_alu = linha["tb_aluno_nome"].ToString();
                    aluno1.Cpf_alu = linha["tb_aluno_cpf"].ToString();
                    aluno1.Email_alu = linha["tb_aluno_email"].ToString();
                    aluno1.Telefone_alu = linha["tb_aluno_telefone"].ToString();
                    aluno1.Resp_nome_alu = linha["tb_aluno_resp_nome"].ToString();
                    aluno1.Resp_cpf_alu = linha["tb_aluno_resp_cpf"].ToString();
                    aluno1.Resp_email_alu = linha["tb_aluno_resp_email"].ToString();
                    aluno1.Resp_telefone_alu = linha["tb_aluno_resp_telefone"].ToString();
                       aluno1.Locacao_tipo = linha["tb_locacao_tipo"].ToString();
                    if (linha["tb_armario_id"] != DBNull.Value)
                        aluno1.Id_armario = Convert.ToInt32(linha["tb_armario_id"]);
                    else
                    {
                        
                    }

                    colecaoaluno.Add(aluno1);



                }

                return colecaoaluno;

            }


            catch (Exception erro)
            {

                throw erro;
            }


        }
        #endregion


    }
}
