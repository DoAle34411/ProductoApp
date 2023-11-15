using static System.Net.Mime.MediaTypeNames;
using System.Threading.Tasks;
using System.Threading;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Alerts;
using ProductoApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.ObjectModel;

namespace ProductoApp;

public partial class DetalleProductoPage : ContentPage
{
    public DetalleProductoPage()
	{
        InitializeComponent();
    }

    private async void OnClickRegresoGeneral(object sender, EventArgs e) 
    {
        await Navigation.PopAsync();
    }

    protected override void OnAppearing() 
    {
        base.OnAppearing();
        Producto producto = BindingContext as Producto;
        Nombre.Text = producto.Nombre;
        Cantidad.Text=producto.cantidad.ToString();
        Descripcion.Text = producto.Descripcion;
    }

    private async void OnClickEditar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductoPage());
    }
    private async void OnClickBorrar(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductoPage());
    }
}