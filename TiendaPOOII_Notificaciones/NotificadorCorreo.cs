using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal class NotificadorCorreo: Notificador
    {
      
        public override void Enviar(string mensaje)
        {
            Console.WriteLine("Notificación por correo electrónico: " + mensaje);
        }
    }
}
