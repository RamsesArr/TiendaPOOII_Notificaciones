using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace TiendaPOOII_Notificaciones
{
    internal class NotificadorCorreo : Notificador
    {

        private string correoEmisor = "ramsesarroyo29@gmail.com";
        private string contrasena = "h u k m q s u s g p q f o v i v"; 
        private string smtpServidor = "smtp.gmail.com";
        private int puerto = 587;
        private bool usarSSL = true;
        private string correoReceptor = "113161@alumnouninter.mx";

        public override void Enviar(string mensaje)
        {
            try
            {
                using (SmtpClient cliente = new SmtpClient(smtpServidor, puerto))
                {
                    cliente.Credentials = new NetworkCredential(correoEmisor, contrasena);
                    cliente.EnableSsl = usarSSL;

                    MailMessage correo = new MailMessage();
                    correo.From = new MailAddress(correoEmisor, "Tienda POOII - Notificaciones");
                    correo.To.Add(correoReceptor);
                    correo.Subject = "Notificación Tienda POOII";
                    correo.Body = mensaje;

                    cliente.Send(correo);

                    Console.WriteLine(" Correo enviado exitosamente a " + correoReceptor);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Error al enviar correo: " + ex.Message);
            }
        }
    }
}