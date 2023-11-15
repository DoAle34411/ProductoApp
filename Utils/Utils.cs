using ProductoApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductoApp.Utils
{
    internal class Utils
    {

        static public ObservableCollection<Producto> ListaProductos = new ObservableCollection<Producto>()
        {
            new Producto{
                IdProducto=1,
                Nombre="Producto 1",
                Descripcion="Descripcion 1",
                cantidad=1
            },

            new Producto{
                IdProducto=2,
                Nombre = "Producto 2",
                Descripcion="Descripcion 2",
                cantidad=2
            }

        };
    }
}
