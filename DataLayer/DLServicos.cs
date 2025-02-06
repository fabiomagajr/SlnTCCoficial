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
    public class DLServicos
    {
        #region Conexão

        public string strConnection = ConfigurationManager.ConnectionStrings["conTCC"].ConnectionString;

        #endregion
        #region Comandos SQL

        public const string strDelete = "DELETE FROM Servicos WHERE COD_SERVICO = @COD_SERVICO";
        public const string strInsert = "INSERT INTO Servicos Values (@NOME_SERVICO, @DURACAO_SERVICO, @OBS_SERVICO) SELECT SCOPE_IDENTITY()";
        public const string strUpdate = "UPDATE Servicos SET NOME_SERVICO = @NOME_SERVICO, DURACAO_SERVICO = @DURACAO_SERVICO, OBS_SERVICO = @OBS_SERVICO WHERE COD_SERVICO = @COD_SERVICO";
        public const string strSelect = "SELECT COD_SERVICO, NOME_SERVICO, DURACAO_SERVICO, OBS_SERVICO FROM Servicos WHERE (@NOME_SERVICO IS NULL OR NOME_SERVICO LIKE '%' + @NOME_SERVICO + '%')";

        #endregion
        #region Métodos SQL

        public int Excluir(int CodServico)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_SERVICO", CodServico);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Gravar(MLServicos objMLServicos)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@NOME_SERVICO", objMLServicos.NomeServico);
                    objComando.Parameters.AddWithValue("@DURACAO_SERVICO", objMLServicos.DuracaoServico);
                    objComando.Parameters.AddWithValue("@OBS_SERVICO", objMLServicos.ObsServico);
                    objConexao.Open();
                    retorno = Convert.ToInt32(objComando.ExecuteScalar());
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Atualizar(MLServicos objMLServicos)
        {
            int retorno = 0;

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_SERVICO", objMLServicos.CodServico);
                    objComando.Parameters.AddWithValue("@NOME_SERVICO", objMLServicos.NomeServico);
                    objComando.Parameters.AddWithValue("@DURACAO_SERVICO", objMLServicos.DuracaoServico);
                    objComando.Parameters.AddWithValue("@OBS_SERVICO", objMLServicos.ObsServico);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public List<MLServicos> Consultar(MLServicos objMLServicos)
        {
            List<MLServicos> lstMLServicos = new List<MLServicos>();

            using (SqlConnection objConexao = new SqlConnection(strConnection))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    if (String.IsNullOrEmpty(objMLServicos.NomeServico))
                    {
                        objComando.Parameters.AddWithValue("@NOME_SERVICO", DBNull.Value);
                    }
                    else
                    {
                        objComando.Parameters.AddWithValue("@NOME_SERVICO", objMLServicos.NomeServico);
                    }

                    objConexao.Open();
                    SqlDataReader objDataReader = objComando.ExecuteReader();

                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            MLServicos objMLServicosRetorno = new MLServicos();

                            objMLServicosRetorno.CodServico = Convert.ToInt32(objDataReader["COD_SERVICO"].ToString());
                            objMLServicosRetorno.NomeServico = objDataReader["NOME_SERVICO"].ToString();
                            objMLServicosRetorno.DuracaoServico = objDataReader["DURACAO_SERVICO"].ToString();
                            objMLServicosRetorno.ObsServico = objDataReader["OBS_SERVICO"].ToString();

                            lstMLServicos.Add(objMLServicosRetorno);
                        }
                    }

                }
            }
            return lstMLServicos;
        }

        #endregion
    }
}
