using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Web;
using System.Net.Mime;
using System.IO;

namespace Climbox.Repositorio.Repos
{
    public class Email
    {
        public static void EnviarCorreo(string de, string para, string asunto, string cuerpo, string user, string pass)
        {
            try
            {
                var mensaje = new MailMessage { From = new MailAddress(de), IsBodyHtml = true };

                foreach (var email in para.Split(';'))
                    mensaje.To.Add(email);


                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.IsBodyHtml = true;

                var cliente = new SmtpClient();
                
                if (cliente.Host == "smtp.gmail.com")
                {
                    cliente.EnableSsl = true;
                    cliente.Port = 587;
                    cliente.UseDefaultCredentials = true;
                    cliente.Credentials = new NetworkCredential(user, pass);
                }
                    

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {
                //if (ParametrosGlobales.HabilitarLogCorreos)
                //    LogHelper.EscribirLogGeneral(ex.Message + "" + ex.InnerException, "EnviarCorreo1", "");
            }
        }

        public static void EnviarCorreoAdj(string de, string para, string asunto, string cuerpo, string adjunto)
        {
            try
            {
                var mensaje = new MailMessage { From = new MailAddress(de), IsBodyHtml = true };
                mensaje.To.Add(para);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;

                if (adjunto != null)                  
                    {
                        var adjuntoCorreo = new Attachment(adjunto, MediaTypeNames.Application.Octet);
                        ContentDisposition disposition = adjuntoCorreo.ContentDisposition;
                        disposition.CreationDate = File.GetCreationTime(adjunto);
                        disposition.ModificationDate = File.GetLastWriteTime(adjunto);
                        disposition.ReadDate = File.GetLastAccessTime(adjunto);
                        mensaje.Attachments.Add(adjuntoCorreo);
                    }

                var cliente = new SmtpClient();

                if (cliente.Host == "smtp.gmail.com")
                    cliente.EnableSsl = true;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
                cliente.Send(mensaje);
            }
            catch (Exception ex)
            {
                //if (ParametrosGlobales.HabilitarLogCorreos)
                //    LogHelper.EscribirLogGeneral(ex.Message + "" + ex.InnerException, "EnviarCorreo2", "");
            }
        }
    }
}   


