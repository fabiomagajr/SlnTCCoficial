using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BLClientes
    {   
        #region "Excluir"
        public int Excluir(int CodCliente)
        {
            var objDLCliente = new DLClientes();
            try
            {
                return objDLCliente.Excluir(CodCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLCliente = null;
            }
        }
        #endregion
        #region "Gravar"
        public int Gravar(MLClientes objMLClientes)
        {
            var objDLClientes = new DLClientes();
            
            try
            {
                return objDLClientes.Gravar(objMLClientes);
            }
            catch (Exception ex)
            {
               
                throw ex;
            }
            finally
            {
                objDLClientes = null;
            }
        }
        #endregion
        #region "Atualizar"
        public int Atualizar(MLClientes objMLClientes)
        {
            var objDLClientes = new DLClientes();

            try
            {
                return objDLClientes.Atualizar(objMLClientes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLClientes = null;
            }
        }
        #endregion
        #region "Consultar"
        public List<MLClientes> Consultar(MLClientes objMLClientes)
        {
            var objDLClientes = new DLClientes();

            try
            {
                return objDLClientes.Consultar(objMLClientes);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLClientes = null;
            }
        }
        #endregion
    }
}
