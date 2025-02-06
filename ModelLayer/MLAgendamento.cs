using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class MLAgendamento
    {
        public int CodAgendamento { get; set; }
        public int CodCliente { get; set; }
        public int CodServico { get; set; }
        public string DataAgendamento { get; set; }
        public string HoraInicio { get; set; }
        public string HoraTermino { get; set; }
        public string ObsAgendamento { get; set; }
       
        
    }
}
