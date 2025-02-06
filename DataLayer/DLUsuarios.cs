using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ModelLayer;

namespace DataLayer
{
    public class DLUsuarios
    {
        #region Conexão

        public string strConnection = ConfigurationManager.ConnectionStrings["conTCC"].ConnectionString;

        #endregion

        #region Comandos SQL

        public const string strDelete = "DELETE FROM Usuarios WHERE COD_USUARIO = @COD_USUARIO";
        public const string strInsert = "INSERT INTO Usuarios Values (@LOGIN_USUARIO, @SENHA_USUARIO, @TIPO_USUARIO) SELECT SCOPE_IDENTITY()";
        public const string strUpdate = "UPDATE Usuarios SET LOGIN_USUARIO = @LOGIN_USUARIO, SENHA_USUARIO = @SENHA_USUARIO, TIPO_USUARIO = @TIPO_USUARIO WHERE COD_USUARIO = @COD_USUARIO";
        public const string strSelect = "SELECT COD_USUARIO, LOGIN_USUARIO, SENHA_USUARIO, TIPO_USUARIO FROM Usuarios WHERE (@LOGIN_USUARIO IS NULL OR LOGIN_USUARIO LIKE '%' + @LOGIN_USUARIO + '%')";
        public const string strSelectLogin = "SELECT COD_USUARIO, LOGIN_USUARIO, SENHA_USUARIO, TIPO_USUARIO FROM Usuarios WHERE (LOGIN_USUARIO = @LOGIN_USUARIO) AND (SENHA_USUARIO = @SENHA_USUARIO)";
        #endregion

        #region Métodos SQL

        public int Excluir(int CodUsuario) 
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection)) 
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_USUARIO", CodUsuario);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Gravar(MLUsuarios objMLUsuario)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {                    
                    objComando.Parameters.AddWithValue("@LOGIN_USUARIO", objMLUsuario.LoginUsuario);
                    objComando.Parameters.AddWithValue("@SENHA_USUARIO", objMLUsuario.SenhaUsuario);
                    objComando.Parameters.AddWithValue("@TIPO_USUARIO", objMLUsuario.TipoUsuario);
                    objConexao.Open();
                    retorno = Convert.ToInt32(objComando.ExecuteScalar()); 
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Atualizar(MLUsuarios objMLUsuario)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_USUARIO", objMLUsuario.CodUsuario);
                    objComando.Parameters.AddWithValue("@LOGIN_USUARIO", objMLUsuario.LoginUsuario);
                    objComando.Parameters.AddWithValue("@SENHA_USUARIO", objMLUsuario.SenhaUsuario);
                    objComando.Parameters.AddWithValue("@TIPO_USUARIO", objMLUsuario.TipoUsuario);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public List<MLUsuarios> Consultar(MLUsuarios objMLUsuarios)
        {
            List<MLUsuarios> lstMLUsuarios = new List<MLUsuarios>();
            
            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    if (String.IsNullOrEmpty(objMLUsuarios.LoginUsuario)) 
                    {
                        objComando.Parameters.AddWithValue("@LOGIN_USUARIO", DBNull.Value);
                    }
                    else 
                    {
                        objComando.Parameters.AddWithValue("@LOGIN_USUARIO", objMLUsuarios.LoginUsuario);
                    }
                    
                    objConexao.Open();
                    SqlDataReader objDataReader = objComando.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            MLUsuarios objMLUsuarioRetorno = new MLUsuarios();

                            objMLUsuarioRetorno.CodUsuario = Convert.ToInt32(objDataReader["COD_USUARIO"].ToString());
                            objMLUsuarioRetorno.LoginUsuario = objDataReader["LOGIN_USUARIO"].ToString();
                            objMLUsuarioRetorno.SenhaUsuario = objDataReader["SENHA_USUARIO"].ToString();
                            objMLUsuarioRetorno.TipoUsuario = Convert.ToInt32(objDataReader["TIPO_USUARIO"].ToString());

                            lstMLUsuarios.Add(objMLUsuarioRetorno);
                        }
                    }
                    
                }
            }
            return lstMLUsuarios;
        }
        public List<MLUsuarios> Login(string nome, string senha)
        {
            List<MLUsuarios> lstMLUsuarios = new List<MLUsuarios>();

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strSelectLogin, objConexao))
                {
                    objComando.Parameters.AddWithValue("@LOGIN_USUARIO", nome);
                    objComando.Parameters.AddWithValue("@SENHA_USUARIO", senha);

                    objConexao.Open();
                    SqlDataReader objDataReader = objComando.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            MLUsuarios objMLUsuarioRetorno = new MLUsuarios();

                            objMLUsuarioRetorno.CodUsuario = Convert.ToInt32(objDataReader["COD_USUARIO"].ToString());
                            objMLUsuarioRetorno.LoginUsuario = objDataReader["LOGIN_USUARIO"].ToString();
                            objMLUsuarioRetorno.SenhaUsuario = objDataReader["SENHA_USUARIO"].ToString();
                            objMLUsuarioRetorno.TipoUsuario = Convert.ToInt32(objDataReader["TIPO_USUARIO"].ToString());

                            lstMLUsuarios.Add(objMLUsuarioRetorno);
                        }
                    }
                }
            }
            return lstMLUsuarios;
        }
        #endregion
    }
}
