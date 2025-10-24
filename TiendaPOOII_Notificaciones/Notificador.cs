using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal class Notificador
    {
        public virtual void Enviar(string mensaje)
        {
            Console.WriteLine("Notificación: " + mensaje);
        }
    }
}
