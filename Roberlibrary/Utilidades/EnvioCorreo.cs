using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mail;
using System.Configuration;

namespace Roberlibrary.Utilidades
{
    public class EnvioCorreo
    {
        public void EnviaCorreo(String From, String To, String Subject, String Mensaje, String sFile, String sFile2,
            String SmtpServer, int port, String username, String passwor, String NombreReceptor, String NombreEmisor)
        {

            try
            {
                MailMessage omsg = new MailMessage();

                omsg.From = From;

                omsg.To = To;

                MailAttachment oarch = new MailAttachment(sFile, MailEncoding.Base64);
                omsg.Attachments.Add(oarch);

                if (false == string.IsNullOrEmpty(sFile2))
                {
                    MailAttachment oarch2 = new MailAttachment(sFile2, MailEncoding.Base64);
                    omsg.Attachments.Add(oarch2);
                }

                omsg.Body = NombreReceptor + "\r\n" + "\r\n" + Mensaje.Replace(@"\r\n", "\r\n") + "\r\n" + "\r\n" + NombreEmisor + "\r\n" + "\r\n" + "Esta factura fue emitida por InvoiceONE" + "\r\n" + "Visítanos en www.invoiceone.com.mx" + "\r\n" + "contacto@invoiceone.com.mx";
                omsg.Subject = Subject;

                omsg.BodyFormat = MailFormat.Text;

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(passwor))
                {
                    if (ConfigurationSettings.AppSettings["enableSsl"].ToString().Trim() == "true")
                        omsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
                    else
                        omsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "0");

                    omsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", username);
                    omsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", passwor);

                }

                omsg.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", port.ToString());

                SmtpMail.SmtpServer = SmtpServer;
                SmtpMail.Send(omsg);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
