    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Net.Mail;
using System.Net;

namespace DAO
{
    public class DAO_Usuario
    {
        Conexao conexaomysql = new Conexao();

        #region Inserir Usuario

        public object Inserir(DTO_Usuario usuario)
        {
            try
            {
                string comando = "insert into TB_USUARIO(TB_USUARIO_NOME, TB_USUARIO_CPF, TB_USUARIO_EMAIL," +
                    "TB_USUARIO_TELEFONE, TB_USUARIO_LOGIN, TB_USUARIO_SENHA, RECUPERARSENHA)" +
                    "values(@nome, @cpf, @email, @telefone, @login, @senha, @recuperarsenha)";

                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@nome", usuario.Nome_usu);
                conexaomysql.AdicionarParametro("@cpf", usuario.Cpf_usu);
                conexaomysql.AdicionarParametro("@email", usuario.Email_usu);
                conexaomysql.AdicionarParametro("@telefone", usuario.Telefone_usu);
                conexaomysql.AdicionarParametro("@login", usuario.Login_usu);
                conexaomysql.AdicionarParametro("@senha", usuario.Senha_usu);
                conexaomysql.AdicionarParametro("@recuperarsenha", usuario.RecuperarSenha);


                string retorno = Convert.ToString(conexaomysql.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        #endregion

        #region Alterar Usuario

        public string Alterar(DTO_Usuario usuario)
        {
            try
            {

                string comando = "update TB_USUARIO set TB_USUARIO_NOME = @nome, TB_USUARIO_CPF = @cpf,"
                                + "TB_USUARIO_TELEFONE = @telefone, TB_USUARIO_EMAIL = @email, TB_USUARIO_SENHA = @senha," +
                                "TB_USUARIO_LOGIN = @login where TB_USUARIO_ID = @id";

                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@nome", usuario.Nome_usu);
                conexaomysql.AdicionarParametro("@cpf", usuario.Cpf_usu);
                conexaomysql.AdicionarParametro("@email", usuario.Email_usu);
                conexaomysql.AdicionarParametro("@telefone", usuario.Telefone_usu);
                conexaomysql.AdicionarParametro("@login", usuario.Login_usu);
                conexaomysql.AdicionarParametro("@senha", usuario.Senha_usu);


                conexaomysql.AdicionarParametro("@id", usuario.Id_usu);

                string retorno = Convert.ToString(conexaomysql.ManipularDados(comando, CommandType.Text));

                return retorno;

            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }
        #endregion

        #region Deletar Usuario

        public string Excluir(DTO_Usuario usuario)
        {
            try
            {
                string comando = @"delete from TB_USUARIO where TB_USUARIO_ID = @id";

                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@id", usuario.Id_usu);

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

        #region Selecionar Todos Usuários
        public DTO_ColecaoUsuario SelecionarUsuario()
        {
            try
            {
                DTO_ColecaoUsuario colecaousuario = new DTO_ColecaoUsuario();
                string comando = "select * from TB_USUARIO order by tb_usuario_nome LIMIT 100";

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Usuario usuario = new DTO_Usuario();
                    usuario.Id_usu = Convert.ToInt32(linha["TB_USUARIO_ID"]);
                    usuario.Nome_usu = linha["TB_USUARIO_NOME"].ToString();
                    usuario.Cpf_usu = linha["TB_USUARIO_CPF"].ToString();
                    usuario.Email_usu = linha["TB_USUARIO_EMAIL"].ToString();
                    usuario.Telefone_usu = linha["TB_USUARIO_TELEFONE"].ToString();
                    usuario.Login_usu = linha["TB_USUARIO_LOGIN"].ToString();
                    usuario.Senha_usu = linha["TB_USUARIO_SENHA"].ToString();
                    colecaousuario.Add(usuario);
                }

                return colecaousuario;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {

            }

        }

        #endregion

        #region Seleciona Usuário Especifico

        public DTO_ColecaoUsuario SelecionarUsuarioEspecifico(DTO_Usuario usuario)
        {
            try
            {
                DTO_ColecaoUsuario colecaousuario = new DTO_ColecaoUsuario();
                string comando = "select * from TB_USUARIO where TB_USUARIO_NOME like '%" + usuario.Nome_usu + "%' order by tb_usuario_nome";

                conexaomysql.LimparParametro();

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.Text);

                foreach (DataRow linha in dt.Rows)
                {
                    DTO_Usuario usuario1 = new DTO_Usuario();
                    usuario1.Id_usu = Convert.ToInt32(linha["TB_USUARIO_ID"]);
                    usuario1.Nome_usu = linha["TB_USUARIO_NOME"].ToString();
                    usuario1.Cpf_usu = linha["TB_USUARIO_CPF"].ToString();
                    usuario1.Email_usu = linha["TB_USUARIO_EMAIL"].ToString();
                    usuario1.Telefone_usu = linha["TB_USUARIO_TELEFONE"].ToString();
                    usuario1.Login_usu = linha["TB_USUARIO_LOGIN"].ToString();
                    usuario1.Senha_usu = linha["TB_USUARIO_SENHA"].ToString();

                    colecaousuario.Add(usuario1);
                }

                return colecaousuario;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        #endregion

        #region Login do usuário
        public DTO_Usuario Login_usuario(DTO_Usuario usuario)
        {
            try
            {
                string comando = "sp_Login";
                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@login", usuario.Login_usu);
                conexaomysql.AdicionarParametro("@senha", usuario.Senha_usu);

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.StoredProcedure);

                foreach (DataRow linha in dt.Rows)
                {
                    usuario.Id_usu = Convert.ToInt32(linha["TB_USUARIO_ID"]);
                    usuario.Nome_usu = linha["TB_USUARIO_NOME"].ToString();
                    usuario.Cpf_usu = linha["TB_USUARIO_CPF"].ToString();
                    usuario.Email_usu = linha["TB_USUARIO_EMAIL"].ToString();
                    usuario.Telefone_usu = linha["TB_USUARIO_TELEFONE"].ToString();
                    usuario.Login_usu = linha["TB_USUARIO_LOGIN"].ToString();
                    usuario.Senha_usu = linha["TB_USUARIO_SENHA"].ToString();
                }

                return usuario;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        #endregion

        // Métodos recuperar senha do botão ESQUECI MINHA SENHA

        #region Recuperar Senha
        public DTO_Usuario RecuperarSenha(DTO_Usuario usu)
        {
            try
            {
                string comando = "sp_Recuperar";
                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@email", usu.Email_usu);

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.StoredProcedure);

                foreach (DataRow linha in dt.Rows)
                {
                    usu.Id_usu = Convert.ToInt32(linha["TB_USUARIO_ID"]);
                    usu.Nome_usu = linha["TB_USUARIO_NOME"].ToString();
                    usu.Email_usu = linha["TB_USUARIO_EMAIL"].ToString();
                    usu.Login_usu = linha["TB_USUARIO_LOGIN"].ToString();
                    usu.RecuperarSenha = Convert.ToInt32(linha["RECUPERARSENHA"]);

                }

                return usu;

            }
            catch (Exception)
            {

                throw;
            }
            
        }
        
        #endregion

        #region Enviar Senha

        public void EnviarEmail(DTO_Usuario usu)
        {
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("tlockersystem@gmail.com", "123abc456def");

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("tlockersystem@gmail.com", "T-LOCKER");
            mail.To.Add(new MailAddress(usu.Email_usu, usu.Nome_usu));
            mail.Subject = "Recuperação de Senha - T-LOCKER";
            mail.Body = "Mensagem recuperação de senha" +
                Environment.NewLine +
                "e-mail -" + usu.Email_usu + Environment.NewLine +
                "Código Recuperação -" + usu.RecuperarSenha;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                client.Send(mail);
            }
            catch (Exception erro)
            {

                throw erro;
            }
        }
        
        #endregion

        #region Verificar Código Usuário

        public DTO_Usuario VerificarUsuario(DTO_Usuario usu)
        {
            try
            {
                string comando = "sp_VerificarCodigo";
                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@codigo", usu.RecuperarSenha);
                conexaomysql.AdicionarParametro("@email", usu.Email_usu);

                DataTable dt = conexaomysql.ConsultarRegistros(comando, CommandType.StoredProcedure);

                foreach (DataRow linha in dt.Rows)
                {

                    usu.Id_usu = Convert.ToInt32(linha["Id_usu"]);

                }

                return usu;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion

        #region Alterar Senha

        public string AlterarSenha(DTO_Usuario usu)
        {
            try
            {
                string comando = "sp_AterarSenha";

                conexaomysql.LimparParametro();
                conexaomysql.AdicionarParametro("@codusu", usu.Id_usu);
                conexaomysql.AdicionarParametro("@senha", usu.Senha_usu);

                string retorno = conexaomysql.ManipularDados(comando, CommandType.StoredProcedure).ToString();

                return retorno;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #endregion
    }
}
