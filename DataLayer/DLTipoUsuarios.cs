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
    public class DLTipoUsuarios
    {
        #region Conexão

        public string strConnection = ConfigurationManager.ConnectionStrings["conTCC"].ConnectionString;

        #endregion

        #region Comandos SQL

        public const string strDelete = "DELETE FROM Tipo_Usuario WHERE COD_TIPO = @COD_TIPO";
        public const string strInsert = "INSERT INTO Tipo_Usuario Values (@NOME_TIPO) SELECT SCOPE_IDENTITY()";
        public const string strUpdate = "UPDATE Tipo_Usuario SET NOME_TIPO = @NOME_TIPO WHERE COD_TIPO = @COD_TIPO";
        public const string strSelect = "SELECT COD_TIPO, NOME_TIPO FROM Tipo_Usuario WHERE (@NOME_TIPO IS NULL OR NOME_TIPO LIKE '%' + @NOME_TIPO + '%')";

        #endregion

        #region Métodos SQL

        public int Excluir(int CodTipo) 
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection)) 
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_TIPO", CodTipo);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Gravar(MLTipoUsuarios objMLTipoUsuario)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {                    
                    objComando.Parameters.AddWithValue("@NOME_TIPO", objMLTipoUsuario.NomeTipo);
                    
                    objConexao.Open();
                    retorno = Convert.ToInt32(objComando.ExecuteScalar()); 
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Atualizar(MLTipoUsuarios objMLTipoUsuario)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_TIPO", objMLTipoUsuario.CodTipo);
                    objComando.Parameters.AddWithValue("@NOME_TIPO", objMLTipoUsuario.NomeTipo);
                    
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public List<MLTipoUsuarios> Consultar(MLTipoUsuarios objMLTipoUsuarios)
        {
            List<MLTipoUsuarios> lstMLTipoUsuarios = new List<MLTipoUsuarios>();
            
            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    if (String.IsNullOrEmpty(objMLTipoUsuarios.NomeTipo)) 
                    {
                        objComando.Parameters.AddWithValue("@NOME_TIPO", DBNull.Value);
                    }
                    else 
                    {
                        objComando.Parameters.AddWithValue("@NOME_TIPO", objMLTipoUsuarios.NomeTipo);
                    }
                    
                    objConexao.Open();
                    SqlDataReader objDataReader = objComando.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            MLTipoUsuarios objMLTipoUsuarioRetorno = new MLTipoUsuarios();

                            objMLTipoUsuarioRetorno.CodTipo = Convert.ToInt32(objDataReader["COD_TIPO"].ToString());
                            objMLTipoUsuarioRetorno.NomeTipo = objDataReader["NOME_TIPO"].ToString();

                            lstMLTipoUsuarios.Add(objMLTipoUsuarioRetorno);
                        }
                    }
                    
                }
            }
            return lstMLTipoUsuarios;
        }

        #endregion
    }
}
