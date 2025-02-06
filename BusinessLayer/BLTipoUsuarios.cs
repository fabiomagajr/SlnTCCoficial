using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BLTipoUsuarios
    {
        #region "Excluir"
        public int Excluir(int CodTipo)
        {
            var objDLTipoUsuarios = new DLTipoUsuarios();

            try
            {
                return objDLTipoUsuarios.Excluir(CodTipo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                objDLTipoUsuarios = null;
            }
            
        }
        #endregion

        #region "Atualizar"
        public int Atualizar(MLTipoUsuarios objMLTipoUsuarios)
        {
            var objDLTipoUsuarios = new DLTipoUsuarios();

            try
            {
                return objDLTipoUsuarios.Atualizar(objMLTipoUsuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLTipoUsuarios = null;
            }            
        }
        #endregion

        #region "Gravar"
        public int Gravar(MLTipoUsuarios objMLTipoUsuarios)
        {
            var objDLTipoUsuarios = new DLTipoUsuarios();            

            try
            {
                return objDLTipoUsuarios.Gravar(objMLTipoUsuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLTipoUsuarios = null;
            }                        
        }
        #endregion

        #region "Consultar"
        public List<MLTipoUsuarios> Consultar(MLTipoUsuarios objMLTipoUsuarios)
        {
            var objDLTipoUsuarios = new DLTipoUsuarios();

            try
            {
                return objDLTipoUsuarios.Consultar(objMLTipoUsuarios);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLTipoUsuarios = null;
            }                        
        }
        #endregion
    }
}
