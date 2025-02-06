using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
   public class BLAgendamento
    {
       #region "Excluir"
       public int Excluir(int CodAgendamento)
       {
           var objDLAgendamento = new DLAgendamento();
           try
           {
               return objDLAgendamento.Excluir(CodAgendamento);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objDLAgendamento = null;
           }
       }
       #endregion
       #region "Gravar"
       public int Gravar(MLAgendamento objMLAgendamento)
       {
           var objDLAgendamento = new DLAgendamento();

           try
           {
               return objDLAgendamento.Gravar(objMLAgendamento);
           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally
           {
               objDLAgendamento = null;
           }
       }
       #endregion
       #region "Atualizar"
       public int Atualizar(MLAgendamento objMLAgendamento)
       {
           var objDLAgendamento = new DLAgendamento();

           try
           {
               return objDLAgendamento.Atualizar(objMLAgendamento);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objDLAgendamento = null;
           }
       }
       #endregion
       #region "Consultar"
       public List<MLAgendamento> Consultar(MLAgendamento objMLAgendamento)
       {
           var objDLAgendamento = new DLAgendamento();

           try
           {
               return objDLAgendamento.Consultar(objMLAgendamento);
           }
           catch (Exception ex)
           {
               throw ex;
           }
           finally
           {
               objDLAgendamento = null;
           }
       }
       #endregion

    }
}
