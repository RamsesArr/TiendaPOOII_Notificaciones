using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal class ProductoElectronico: Producto
    {
        public ProductoElectronico()
        { }
        public ProductoElectronico(string nombre, decimal precio, int stock, string categoria, string garantiaMeses)
            :base(nombre, precio, stock, categoria)
        {
            GarantiaMeses = garantiaMeses;
        }
        public string GarantiaMeses { get; set; }
    }
}
