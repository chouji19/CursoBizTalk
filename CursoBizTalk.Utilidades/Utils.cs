using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoBizTalk.Utilidades
{
    public class Utils
    {
        public string ObtenerTipoDocumento(int tipoId)
        {
            switch (tipoId)
            {
                case 1:
                    return "CC";
                case 2:
                    return "NIT";
                case 3:
                    return "CE";
                default:
                    return "CC";
            }
        }

        public static string ObtenerTipoCliente(int tipoId)
        {
            if (tipoId == 2)
                return "Persona Juridica";
            else
                return "Persona Natural";
        }

        public static void WriteLog(string text)
        {
            string source = "CursoBizTalk";
            EventLog systemEventLog = new EventLog("CursoBizTalk");
            if (!EventLog.SourceExists(source))
            {
                EventLog.CreateEventSource(source, "CursoBizTalk");
            }
            systemEventLog.Source = source;
            systemEventLog.WriteEntry(text, EventLogEntryType.Information, 150);
        }


        
    }

}
