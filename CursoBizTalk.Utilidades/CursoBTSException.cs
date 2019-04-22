using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBizTalk.Utilidades
{
    public class CursoBTSException: Exception
    {
        public string MensajeError { get; set; }
        public int CodigoError { get; set; }

        public CursoBTSException(int _codigo, string _mensaje)
        {
            this.CodigoError = _codigo;
            this.MensajeError = _mensaje;
        }
    }
}
