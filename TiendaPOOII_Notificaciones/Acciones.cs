using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal class Acciones : IAcciones
    {
        List<ProductoElectronico> listaProductos = new List<ProductoElectronico>();
        public bool Agregar(ProductoElectronico producto)
        {
            try
            {
                listaProductos.Add(producto);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<ProductoElectronico> Mostrar()
        {
            return listaProductos;
        }
    }
}

