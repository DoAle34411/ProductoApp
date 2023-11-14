using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using ProductoApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Java.Lang;

namespace ProductoApp;

public partial class NuevoProductoPage : ContentPage
{
    public NuevoProductoPage()
	{
        InitializeComponent();
    }

    private async void OnClickGuardarProducto(object sender, EventArgs e) 
    {
        try {
            int id = Utils.Utils.ListaProductos.Count + 1;
            Utils.Utils.ListaProductos.Add(new Producto
            {
                IdProducto = id,
                Nombre = Nombre.Text,
                Descripcion = Descripcion.Text,
                cantidad = Int32.Parse(Cantidad.Text),
            }
            );
            await Navigation.PopAsync();
        }
        catch (NullPointerException ex)
        {
            var toast = Toast.Make("Agregue un producto primero o regrese", ToastDuration.Short, 14);

            await toast.Show();
        }
    }
}