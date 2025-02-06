using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
//using System.DateTime;
using System.Data.SqlClient;
using ModelLayer;

namespace DataLayer
{
    public class DLAgendamento
    {
        #region Conexao

        public string strConection = ConfigurationManager.ConnectionStrings["conTCC"].ConnectionString;

        #endregion

        #region Comandos SQL
        public const string strDelete = "DELETE FROM Agendamentos WHERE COD_AGENDAMENTO = @COD_AGENDAMENTO";
        public const string strInsert = "INSERT INTO Agendamentos VALUES (@COD_CLIENTE, @COD_SERVICO, @DATA_AGENDAMENTO, @HORA_INICIO, @HORA_FIM, @OBS_AGENDAMENTO) SELECT SCOPE_IDENTITY()";
        public const string strUpdate = "UPDATE Agendamentos SET COD_Agendamento=@COD_Agendamento, COD_SERVICO=@COD_SERVICO, DATA_AGENDAMENTO=@DATA_AGENDAMENTO, HORA_INICIO=@HORA_INICIO, HORA_FIM=@HORA_FIM, OBS_AGENDAMENTO=@OBS_AGENDAMENTO WHERE COD_AGENDAMENTO=@COD_AGENDAMENTO";
        public const string strSelect = "SELECT COD_AGENDAMENTO, COD_CLIENTE, COD_SERVICO, DATA_AGENDAMENTO, HORA_INICIO, HORA_FIM, OBS_AGENDAMENTO FROM Agendamentos WHERE (@DATA_AGENDAMENTO IS NULL OR DATA_AGENDAMENTO = @DATA_AGENDAMENTO) AND (@COD_SERVICO IS NULL OR COD_SERVICO = @COD_SERVICO)";
        #endregion

        #region Métodos em SQL

        #region Excluir
        public int Excluir(int CodAgendamento)
        {
            int retorno = 0;
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_AGENDAMENTO", CodAgendamento);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }
        #endregion

        #region Gravar
        public int Gravar(MLAgendamento objMLAgendamento)
        {
            int retorno = 0;
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_CLIENTE", objMLAgendamento.CodCliente);
                    objComando.Parameters.AddWithValue("@COD_SERVICO", objMLAgendamento.CodServico);
                    objComando.Parameters.AddWithValue("@DATA_AGENDAMENTO", objMLAgendamento.DataAgendamento);
                    objComando.Parameters.AddWithValue("@HORA_INICIO", objMLAgendamento.HoraInicio);
                    objComando.Parameters.AddWithValue("@HORA_FIM", objMLAgendamento.HoraTermino);
                    objComando.Parameters.AddWithValue("@OBS_AGENDAMENTO", objMLAgendamento.ObsAgendamento);


                    objConexao.Open();
                    retorno = Convert.ToInt32(objComando.ExecuteScalar());
                    objConexao.Close();
                }
            }
            return retorno;

        }
        #endregion

        #region Atualizar
        public int Atualizar(MLAgendamento objMLAgendamento)
        {
            int retorno = 0;
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_AGENDAMENTO", objMLAgendamento.CodAgendamento);
                    objComando.Parameters.AddWithValue("@COD_CLIENTE", objMLAgendamento.CodCliente);
                    objComando.Parameters.AddWithValue("@COD_SERVICO", objMLAgendamento.CodServico);
                    objComando.Parameters.AddWithValue("@DATA_AGENDAMENTO", objMLAgendamento.DataAgendamento);
                    objComando.Parameters.AddWithValue("@HORA_INICIO", objMLAgendamento.HoraInicio);
                    objComando.Parameters.AddWithValue("@HORA_FIM", objMLAgendamento.HoraTermino);
                    objComando.Parameters.AddWithValue("@OBS_AGENDAMENTO", objMLAgendamento.ObsAgendamento);


                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }
#endregion

        #region Consultar
        public List<MLAgendamento> Consultar(MLAgendamento objMLAgendamento)
        {
            List<MLAgendamento> lstMLAgendamento = new List<MLAgendamento>();

            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    if (String.IsNullOrEmpty(Convert.ToString(objMLAgendamento.DataAgendamento)))
                    {
                        objComando.Parameters.AddWithValue("@DATA_AGENDAMENTO", DBNull.Value);
                    }
                    else
                    {
                        objComando.Parameters.AddWithValue("@DATA_AGENDAMENTO", objMLAgendamento.DataAgendamento);
                    }

                    if (String.IsNullOrEmpty(Convert.ToString(objMLAgendamento.CodServico)))
                    {
                        objComando.Parameters.AddWithValue("@COD_SERVICO", DBNull.Value);
                    }
                    else
                    {
                        objComando.Parameters.AddWithValue("@COD_SERVICO", objMLAgendamento.CodServico);
                    }

                    objConexao.Open();
                    SqlDataReader objDataReader = objComando.ExecuteReader();
                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            MLAgendamento objMLAgendamentoRetorno = new MLAgendamento();
                            objMLAgendamentoRetorno.CodAgendamento = Convert.ToInt32(objDataReader["COD_AGENDAMENTO"].ToString());
                            objMLAgendamentoRetorno.CodCliente = Convert.ToInt32(objDataReader["COD_CLIENTE"].ToString());
                            objMLAgendamentoRetorno.CodServico = Convert.ToInt32(objDataReader["COD_SERVICO"].ToString());
                            objMLAgendamentoRetorno.DataAgendamento = Convert.ToString(objDataReader["DATA_AGENDAMENTO"].ToString());//resolvido
                            objMLAgendamentoRetorno.HoraInicio = (objDataReader["HORA_INICIO"].ToString());
                            objMLAgendamentoRetorno.HoraTermino = (objDataReader["HORA_FIM"].ToString());
                            objMLAgendamentoRetorno.ObsAgendamento = (objDataReader["OBS_AGENDAMENTO"].ToString());


                            lstMLAgendamento.Add(objMLAgendamentoRetorno);
                        }
                    }
                    objConexao.Close();
                }
            }
            return lstMLAgendamento;
        } 
        #endregion
        #endregion
    }
} 
