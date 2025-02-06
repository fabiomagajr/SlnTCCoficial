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
    public class DLClientes
    {
        
        
        #region Conexao

        public string strConection = ConfigurationManager.ConnectionStrings["conTCC"].ConnectionString;

        #endregion

        #region Comandos SQL
        public const string strDelete = "DELETE FROM Clientes WHERE COD_CLIENTE = @COD_CLIENTE";
        public const string strInsert = "INSERT INTO Clientes VALUES (@NOME_CLIENTE, @TIPO_CLIENTE, @CPF_CNPJ_CLIENTE, @IDENTIDADE_CLIENTE, @DATA_NASCIMENTO_CLIENTE, @EMAIL_CLIENTE, @ENDERECO_CLIENTE, @NUMERO_ENDERECO_CLIENTE, @COMPLEMENTO_CLIENTE, @BAIRRO_CLIENTE, @CIDADE_CLIENTE, @CEP_CLIENTE, @UF_CLIENTE, @TELEFONE_CLIENTE, @CELULAR1_CLIENTE, @CELULAR2_CLIENTE, @OBS_CLIENTE) SELECT SCOPE_IDENTITY()";
        public const string strUpdate = "UPDATE Clientes SET NOME_CLIENTE=@NOME_CLIENTE, CPF_CNPJ_CLIENTE=@CPF_CNPJ_CLIENTE, IDENTIDADE_CLIENTE=@IDENTIDADE_CLIENTE, DATA_NASCIMENTO_CLIENTE=@DATA_NASCIMENTO_CLIENTE, EMAIL_CLIENTE=@EMAIL_CLIENTE, ENDERECO_CLIENTE=@ENDERECO_CLIENTE, NUMERO_ENDERECO_CLIENTE=@NUMERO_ENDERECO_CLIENTE, COMPLEMENTO_CLIENTE=@COMPLEMENTO_CLIENTE,BAIRRO_CLIENTE=@BAIRRO_CLIENTE, CIDADE_CLIENTE=@CIDADE_CLIENTE, CEP_CLIENTE=@CEP_CLIENTE,UF_CLIENTE=@UF_CLIENTE, TELEFONE_CLIENTE=@TELEFONE_CLIENTE, CELULAR1_CLIENTE=@CELULAR1_CLIENTE,CELULAR2_CLIENTE=@CELULAR2_CLIENTE, OBS_CLIENTE=@OBS_CLIENTE WHERE COD_CLIENTE=@COD_CLIENTE";
        public const string strSelect = "SELECT COD_CLIENTE, NOME_CLIENTE, TIPO_CLIENTE, CPF_CNPJ_CLIENTE, IDENTIDADE_CLIENTE, DATA_NASCIMENTO_CLIENTE, EMAIL_CLIENTE, ENDERECO_CLIENTE, NUMERO_ENDERECO_CLIENTE, COMPLEMENTO_CLIENTE, BAIRRO_CLIENTE, CIDADE_CLIENTE,CEP_CLIENTE, UF_CLIENTE, TELEFONE_CLIENTE, CELULAR1_CLIENTE, CELULAR2_CLIENTE, OBS_CLIENTE FROM Clientes WHERE (@NOME_CLIENTE IS NULL OR NOME_CLIENTE LIKE '%' + @NOME_CLIENTE + '%')";
                                                                      
        #endregion

        #region Metodos SQL

        public int Excluir(int CodCliente)
        {
            int retorno = 0;
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strDelete, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_CLIENTE", CodCliente);
                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Gravar(MLClientes objMLClientes)
        {
            int retorno = 0;
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strInsert, objConexao))
                {
                    objComando.Parameters.AddWithValue("@NOME_CLIENTE", objMLClientes.NomeCliente);
                    objComando.Parameters.AddWithValue("@TIPO_CLIENTE", objMLClientes.TipoCliente);
                    objComando.Parameters.AddWithValue("@CPF_CNPJ_CLIENTE", objMLClientes.CpfCnpjCliente);
                    objComando.Parameters.AddWithValue("@IDENTIDADE_CLIENTE", objMLClientes.IdentidadeCliente);
                    objComando.Parameters.AddWithValue("@DATA_NASCIMENTO_CLIENTE", objMLClientes.DataNascCliente);
                    objComando.Parameters.AddWithValue("@EMAIL_CLIENTE", objMLClientes.EmailCliente);
                    objComando.Parameters.AddWithValue("@ENDERECO_CLIENTE", objMLClientes.EnderecoCliente);
                    objComando.Parameters.AddWithValue("@NUMERO_ENDERECO_CLIENTE", objMLClientes.NEnderecoClienteE);
                    objComando.Parameters.AddWithValue("@COMPLEMENTO_CLIENTE", objMLClientes.ComplementoCliente);
                    objComando.Parameters.AddWithValue("@BAIRRO_CLIENTE", objMLClientes.BairroCliente);
                    objComando.Parameters.AddWithValue("@CIDADE_CLIENTE", objMLClientes.CidadeCliente);
                    objComando.Parameters.AddWithValue("@CEP_CLIENTE", objMLClientes.CepCliente);
                    objComando.Parameters.AddWithValue("@UF_CLIENTE", objMLClientes.UfCliente);
                    objComando.Parameters.AddWithValue("@TELEFONE_CLIENTE", objMLClientes.TelefoneCliente);
                    objComando.Parameters.AddWithValue("@CELULAR1_CLIENTE", objMLClientes.Celular1Cliente);
                    objComando.Parameters.AddWithValue("@CELULAR2_CLIENTE", objMLClientes.Celular2Cliente);
                    objComando.Parameters.AddWithValue("@OBS_CLIENTE", objMLClientes.ObsCliente);

                    objConexao.Open();
                    retorno = Convert.ToInt32(objComando.ExecuteScalar());
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public int Atualizar(MLClientes objMLClientes)
        {
            int retorno = 0;
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strUpdate, objConexao))
                {
                    objComando.Parameters.AddWithValue("@COD_CLIENTE", objMLClientes.CodCliente);
                    objComando.Parameters.AddWithValue("@NOME_CLIENTE", objMLClientes.NomeCliente);
                    objComando.Parameters.AddWithValue("@CPF_CNPJ_CLIENTE", objMLClientes.CpfCnpjCliente);
                    objComando.Parameters.AddWithValue("@IDENTIDADE_CLIENTE", objMLClientes.IdentidadeCliente);
                    objComando.Parameters.AddWithValue("@DATA_NASCIMENTO_CLIENTE", objMLClientes.DataNascCliente);
                    objComando.Parameters.AddWithValue("@EMAIL_CLIENTE", objMLClientes.EmailCliente);
                    objComando.Parameters.AddWithValue("@ENDERECO_CLIENTE", objMLClientes.EnderecoCliente);
                    objComando.Parameters.AddWithValue("@NUMERO_ENDERECO_CLIENTE", objMLClientes.NEnderecoClienteE);
                    objComando.Parameters.AddWithValue("@COMPLEMENTO_CLIENTE", objMLClientes.ComplementoCliente);
                    objComando.Parameters.AddWithValue("@BAIRRO_CLIENTE", objMLClientes.BairroCliente);
                    objComando.Parameters.AddWithValue("@CIDADE_CLIENTE", objMLClientes.CidadeCliente);
                    objComando.Parameters.AddWithValue("@CEP_CLIENTE", objMLClientes.CidadeCliente);
                    objComando.Parameters.AddWithValue("@UF_CLIENTE", objMLClientes.UfCliente);
                    objComando.Parameters.AddWithValue("@TELEFONE_CLIENTE", objMLClientes.TelefoneCliente);
                    objComando.Parameters.AddWithValue("@CELULAR1_CLIENTE", objMLClientes.Celular1Cliente);
                    objComando.Parameters.AddWithValue("@CELULAR2_CLIENTE", objMLClientes.Celular2Cliente);
                    objComando.Parameters.AddWithValue("@OBS_CLIENTE", objMLClientes.ObsCliente);

                    objConexao.Open();
                    retorno = objComando.ExecuteNonQuery();
                    objConexao.Close();
                }
            }
            return retorno;
        }

        public List<MLClientes> Consultar(MLClientes objMLClientes)
        {
            List<MLClientes> lstMLClientes = new List<MLClientes>();
            using (SqlConnection objConexao = new SqlConnection(strConection))
            {
                using (SqlCommand objComando = new SqlCommand(strSelect, objConexao))
                {
                    if (String.IsNullOrEmpty(objMLClientes.NomeCliente))
                    {
                        objComando.Parameters.AddWithValue("@NOME_CLIENTE", DBNull.Value);
                    }
                    else
                    {
                        objComando.Parameters.AddWithValue("@NOME_CLIENTE", objMLClientes.NomeCliente);
                    }
                    objConexao.Open();
                    SqlDataReader objDataReader = objComando.ExecuteReader();
                    if (objDataReader.HasRows)
                    {
                        while (objDataReader.Read())
                        {
                            MLClientes objMLClienteRetorno = new MLClientes();
                            objMLClienteRetorno.CodCliente = Convert.ToInt32(objDataReader["COD_CLIENTE"].ToString());
                            objMLClienteRetorno.NomeCliente = (objDataReader["NOME_CLIENTE"].ToString());
                            objMLClienteRetorno.TipoCliente = (objDataReader["TIPO_CLIENTE"].ToString());
                            objMLClienteRetorno.CpfCnpjCliente = (objDataReader["CPF_CNPJ_CLIENTE"].ToString());
                            objMLClienteRetorno.IdentidadeCliente = (objDataReader["IDENTIDADE_CLIENTE"].ToString());
                            objMLClienteRetorno.DataNascCliente = (objDataReader["DATA_NASCIMENTO_CLIENTE"].ToString());
                            objMLClienteRetorno.EmailCliente = (objDataReader["EMAIL_CLIENTE"].ToString());
                            objMLClienteRetorno.EnderecoCliente = (objDataReader["ENDERECO_CLIENTE"].ToString());
                            objMLClienteRetorno.NEnderecoClienteE = (objDataReader["NUMERO_ENDERECO_CLIENTE"].ToString());
                            objMLClienteRetorno.ComplementoCliente = (objDataReader["COMPLEMENTO_CLIENTE"].ToString());
                            objMLClienteRetorno.BairroCliente = (objDataReader["BAIRRO_CLIENTE"].ToString());
                            objMLClienteRetorno.CidadeCliente = (objDataReader["CIDADE_CLIENTE"].ToString());
                            objMLClienteRetorno.CepCliente = (objDataReader["CEP_CLIENTE"].ToString());
                            objMLClienteRetorno.UfCliente = (objDataReader["UF_CLIENTE"].ToString());
                            objMLClienteRetorno.TelefoneCliente = (objDataReader["TELEFONE_CLIENTE"].ToString());
                            objMLClienteRetorno.Celular1Cliente = (objDataReader["CELULAR1_CLIENTE"].ToString());
                            objMLClienteRetorno.Celular2Cliente = (objDataReader["CELULAR2_CLIENTE"].ToString());
                            objMLClienteRetorno.ObsCliente = (objDataReader["OBS_CLIENTE"].ToString());

                            lstMLClientes.Add(objMLClienteRetorno);
                        }
                    }
                    objConexao.Close();
                }
            }
            return lstMLClientes;
        }



        #endregion
        
    }
}
