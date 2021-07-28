using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climbox.Paramentros
{
   internal static class Parametros
    {
        public static string RemitenteCorreoPorDefecto
        {
            get
            {
                return ConfigurationManager.AppSettings["RemitenteCorreoPorDefecto"];
            }
        }
        public static string RutaPlantillaCorreo
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("rutaPlantilla") ?? string.Empty;
            }
        }

        public static string Usuario
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("usuario") ?? string.Empty;
            }
        }

        public static string Password
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("pass") ?? string.Empty;
            }
        }

        public static string Logo
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("logo") ?? string.Empty;
            }
        }
    }
}
