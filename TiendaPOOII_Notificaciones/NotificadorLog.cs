using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System .IO;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal class NotificadorLog: Notificador
    {
        public override void Enviar(string mensaje)
        {
            string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Define el nombre del archivo log
            string rutaArchivo = Path.Combine(rutaEscritorio, "log.txt");

            // Escribe (o agrega) la notificación en el archivo del Escritorio
            File.AppendAllText(rutaArchivo, $"🗒️ {DateTime.Now}: {mensaje}{Environment.NewLine}");

            Console.WriteLine($"🗒️ Notificación guardada en: {rutaArchivo}");
        }
    }
}
