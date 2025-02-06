using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BLUsuarios
    {
        #region "Excluir"
        public int Excluir(int codUsuario)
        {
            var objDLUsuarios = new DLUsuarios();

            try
            {
                 return objDLUsuarios.Excluir(codUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                objDLUsuarios = null;
            }
            
        }
        #endregion

        #region "Atualizar"
        public int Atualizar(MLUsuarios objMLUsuarios)
        {
            var objDLUsuarios = new DLUsuarios();

            try
            {
                return objDLUsuarios.Atualizar(objMLUsuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLUsuarios = null;
            }            
        }
        #endregion

        #region "Gravar"
        public int Gravar(MLUsuarios objMLUsuarios)
        {
            var objDLUsuarios = new DLUsuarios();            

            try
            {
                return objDLUsuarios.Gravar(objMLUsuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLUsuarios = null;
            }                        
        }
        #endregion

        #region "Consultar"
        public List<MLUsuarios> Consultar(MLUsuarios objMLUsuarios)
        {
            var objDLUsuarios = new DLUsuarios();

            try
            {
                return objDLUsuarios.Consultar(objMLUsuarios);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                objDLUsuarios = null;
            }                        
        }
        #endregion

        public List<MLUsuarios> Login(string nome, string senha)
        {
            var objDLUsuarios = new DLUsuarios();

            try
            {
                return objDLUsuarios.Login(nome, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                objDLUsuarios = null;
            }
        }
    }
}
