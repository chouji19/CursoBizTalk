using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBizTalk.Utilidades
{
    public class CustomException : Exception
    {
        public string CodigoError { get; set; }

        public string Mensaje { get; set; }

        public CustomException(string _codigo, string _mensaje)
        {
            this.CodigoError = _codigo;
            this.Mensaje = _mensaje;
        }
    }
}
