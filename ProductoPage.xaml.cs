using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using ProductoApp.Models;
using System.Collections.ObjectModel;

namespace ProductoApp;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
        InitializeComponent();
        ObservableCollection<Producto> observableCollection = new ObservableCollection<Producto>(Utils.Utils.ListaProductos);
        listaProductos.ItemsSource = observableCollection;
    }
    private async void OnClickNuevoProducto(object sender, EventArgs e) 
	{
        var toast = Toast.Make("On Click Boton Nuevo Producto", ToastDuration.Short, 14);

        await toast.Show();
        await Navigation.PushAsync(new NuevoProductoPage());
    }
}