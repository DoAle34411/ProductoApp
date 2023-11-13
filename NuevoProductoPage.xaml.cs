using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using ProductoApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProductoApp;

public partial class NuevoProductoPage : ContentPage
{
    public NuevoProductoPage()
	{
        InitializeComponent();
    }

    private  void OnClickGuardarProducto(object sender, EventArgs e) 
    {
        int id = Utils.Utils.ListaProductos.Count + 1;
        Utils.Utils.ListaProductos.Add(new Producto
        {
            IdProducto = id,
            Nombre = Nombre.Text,
            Descripcion = Descripcion.Text,
            cantidad = Int32.Parse(cantidad.Text),
        }
        );
    }
}