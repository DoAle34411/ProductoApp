using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;

namespace ProductoApp;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
        InitializeComponent();
        listaProductos.ItemsSource = Utils.Utils.ListaProductos;
    }
    private async void OnClickNuevoProducto(object sender, EventArgs e) 
	{
        var toast = Toast.Make("On Click Boton Nuevo Producto", ToastDuration.Short, 14);

        await toast.Show();
        new NuevoProductoPage();
    }
}