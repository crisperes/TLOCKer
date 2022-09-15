using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Classes Mysql
using System.Data; // Classes de Banco Dados Padrão 

namespace DAO
{
    public class Conexao
    {
        #region Parametro 
        
        private MySqlParameterCollection mysqlparametrocolecao = new MySqlCommand().Parameters;

        #endregion

        #region Metodo Conexao
        
        private MySqlConnection ConexaoMySql()
        {
            return new MySqlConnection("user id=root;password=root;server=localhost;database=bd_tlocker;SslMode=none");

        }

        #endregion

        #region Metodo Adicionar Parametro
        
        public void AdicionarParametro(string nomeparametro, object valorparametro)
        {
            mysqlparametrocolecao.Add(new MySqlParameter(
                nomeparametro, valorparametro));
        }

        #endregion

        #region Metodo Limpar Parametro
        
        public void LimparParametro()
        {
            mysqlparametrocolecao.Clear();
        }


        #endregion

        #region Manipular dados
        
        public object ManipularDados(string comando, CommandType tipo)
        {
            MySqlConnection cn = ConexaoMySql();
            try
            {
                cn.Open();

                MySqlCommand sqlcommand = cn.CreateCommand();

                sqlcommand.CommandText = comando;
                sqlcommand.CommandType = tipo;

                foreach (MySqlParameter item in mysqlparametrocolecao)
                {
                    sqlcommand.Parameters.Add(new MySqlParameter(
                        item.ParameterName, item.Value));
                }

                return sqlcommand.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }
            
        }


        #endregion

        #region Metodo Consulta Registros
        
        public DataTable ConsultarRegistros(string comando, CommandType tipo)
        {
            MySqlConnection mysqlconnection = ConexaoMySql();
            try
            {
                mysqlconnection.Open();

                MySqlCommand sqlcommand = mysqlconnection.CreateCommand();

                sqlcommand.CommandText = comando;
                sqlcommand.CommandType = tipo;

                foreach (MySqlParameter sqlparametro in mysqlparametrocolecao)
                {
                    sqlcommand.Parameters.Add(new MySqlParameter(sqlparametro.ParameterName,
                        sqlparametro.Value));
                }

                MySqlDataAdapter mysqldataadapter = new MySqlDataAdapter(sqlcommand);

                DataTable dt = new DataTable();

                mysqldataadapter.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                mysqlconnection.Close();
            }
        }
        #endregion

        #region Manipular dados
        
        public object ManipularDados2(string comando, CommandType tipo)
        {
            MySqlConnection cn = ConexaoMySql();
            try
            {
                cn.Open();

                MySqlCommand sqlcommand = cn.CreateCommand();

                sqlcommand.CommandText = comando;
                sqlcommand.CommandType = tipo;

                foreach (MySqlParameter item in mysqlparametrocolecao)
                {
                    sqlcommand.Parameters.Add(new MySqlParameter(
                        item.ParameterName, item.Value));
                }

                return sqlcommand.ExecuteScalar();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cn.Close();
            }


        }


        #endregion
    }
}
