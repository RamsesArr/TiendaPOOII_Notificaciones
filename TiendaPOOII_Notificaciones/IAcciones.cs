using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaPOOII_Notificaciones
{
    internal interface IAcciones
    {
        bool Agregar(ProductoElectronico producto);
        List<ProductoElectronico> Mostrar();
    }
}
