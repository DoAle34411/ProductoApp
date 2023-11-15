using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using ProductoApp.Models;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ProductoApp;

public partial class ProductoPage : ContentPage
{
    private ObservableCollection<Producto> observableCollection;

    public ProductoPage()
	{
        InitializeComponent();
        listaProductos.ItemsSource = Utils.Utils.ListaProductos;
    }
    private async void OnClickNuevoProducto(object sender, EventArgs e) 
	{
        var toast = Toast.Make("On Click Boton Nuevo Producto", ToastDuration.Short, 14);

        await toast.Show();
        await Navigation.PushAsync(new NuevoProductoPage());
    }

    private void OnAppearing(object sender, EventArgs e) 
    {
        ObservableCollection<Producto> observableCollection = new ObservableCollection<Producto>(Utils.Utils.ListaProductos);
        listaProductos.ItemsSource = observableCollection;
    }
}