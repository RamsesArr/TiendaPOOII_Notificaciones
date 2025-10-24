using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            NotificadorCorreo correo = new NotificadorCorreo();
            NotificadorConsola consola = new NotificadorConsola();
            NotificadorLog log = new NotificadorLog();

            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n====== 🏪 MENÚ PRINCIPAL ======");
                Console.WriteLine("1️) Agregar producto");
                Console.WriteLine("2️) Mostrar productos");
                Console.WriteLine("3️) Notificar por correo");
                Console.WriteLine("4️) Notificar en consola");
                Console.WriteLine("5️) Notificar en log");
                Console.WriteLine("6️) Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Precio: ");
                        decimal precio = decimal.Parse(Console.ReadLine());
                        Console.Write("Stock: ");
                        int stock = int.Parse(Console.ReadLine());
                        Console.Write("Categoría: ");
                        string categoria = Console.ReadLine();
                        Console.Write("Garantía (meses): ");
                        string garantia = Console.ReadLine();

                        ProductoElectronico p = new ProductoElectronico(nombre, precio, stock, categoria, garantia);
                        acciones.Agregar(p);
                        consola.Enviar("Producto agregado correctamente.");
                        break;

                    case "2":
                        var productos = acciones.Mostrar();
                        if (productos.Count == 0)
                            Console.WriteLine("No hay productos registrados.");
                        else
                        {
                            Console.WriteLine("\n LISTA DE PRODUCTOS:");
                            foreach (var prod in productos)
                            {
                                Console.WriteLine(prod.Nombre);
                                Console.WriteLine(prod.Precio);
                                Console.WriteLine(prod.Stock);
                                Console.WriteLine(prod.Categoria);
                                Console.WriteLine(prod.GarantiaMeses);
                            }
                        }
                        break;

                    case "3":
                        correo.Enviar("Se ha enviado una notificación por correo.");
                        break;

                    case "4":
                        consola.Enviar("Este es un mensaje de notificación en consola.");
                        break;

                    case "5":
                        log.Enviar("Se registró una notificación en log.txt.");
                        break;

                    case "6":
                        salir = true;
                        Console.WriteLine("👋 Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("❌ Opción no válida. Intente nuevamente.");
                        break;
                }
            }
        }
    }
}
