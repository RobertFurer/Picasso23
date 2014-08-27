using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Xml;
using System.Xml.Xsl;

namespace Roberlibrary.Utilidades
{
    class ToPDF
    {
    }
    public class Derp
    {
        public static void TransformXML()
        {
            // Create a resolver with default credentials.
            XmlUrlResolver resolver = new XmlUrlResolver();
            resolver.Credentials = System.Net.CredentialCache.DefaultCredentials;
            // transform the personnel.xml file to HTML
            XslTransform transform = new XslTransform();
            // load up the stylesheet
            transform.Load(@"C:\Users\Usuario\Desktop\SVN\PDV\DLL\2.xsl", resolver);
            // perform the transformation
            transform.Transform(@"C:\temp\100.xml", @"C:\temp\Personnel.html", resolver);
            // transform the personnel.xml file to comma delimited format
            // load up the stylesheet
           // transform.Load(@"..\PersonnelCSV.xsl", resolver);
            // perform the transformation
           // transform.Transform(@"..\Personnel.xml", @"..\Personnel.csv", resolver);
        }
        public static bool WriteDirectory()
        {
            try
            {
                MemoryStream PDFStream = new MemoryStream();
                MemoryStream PDF = Derp.GeneratePdf(PDFStream);
                byte[] byteArray1 = PDF.ToArray();
                File.WriteAllBytes(@"C:\temp\q.pdf", byteArray1);
                PDF.Flush();
                PDF.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static MemoryStream GeneratePdf(MemoryStream pdf)
        {
            using (StreamReader Html = new StreamReader(@"C:\temp\1.html"))
            {
                Process p;
                StreamWriter stdin;
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = @"C:\Program Files\wkhtmltopdf\bin\wkhtmltopdf.exe";
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                psi.Arguments = "-q -n --disable-smart-shrinking " + " - -";
                p = Process.Start(psi);
                try
                {
                    stdin = p.StandardInput;
                    stdin.AutoFlush = true;
                    stdin.Write(Html.ReadToEnd());
                    stdin.Dispose();
                    CopyStream(p.StandardOutput.BaseStream, pdf);
                    p.StandardOutput.Close();
                    pdf.Position = 0;
                    p.WaitForExit(10000);
                    return pdf;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    p.Dispose();
                }
            }
        }

        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[32768];
            int read;
            while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, read);
            }
        }
    }
}
