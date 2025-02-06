using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class BLServicos
    {
        #region "Excluir"
        public int Excluir(int codServico)
        {
            var objDLServicos = new DLServicos();

            try
            {
                return objDLServicos.Excluir(codServico);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLServicos = null;
            }

        }
        #endregion
        #region "Atualizar"
        public int Atualizar(MLServicos objMLServicos)
        {
            var objDLServicos = new DLServicos();

            try
            {
                return objDLServicos.Atualizar(objMLServicos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLServicos = null;
            }
        }
        #endregion
        #region "Gravar"
        public int Gravar(MLServicos objMLServicos)
        {
            var objDLServicos = new DLServicos();

            try
            {
                return objDLServicos.Gravar(objMLServicos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLServicos = null;
            }
        }
        #endregion
        #region "Consultar"
        public List<MLServicos> Consultar(MLServicos objMLServicos)
        {
            var objDLServicos = new DLServicos();
            try
            {
                return objDLServicos.Consultar(objMLServicos);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objDLServicos = null;
            }
        }
        #endregion
    }
}
