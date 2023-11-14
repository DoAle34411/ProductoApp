namespace ProductoApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitializeComponent();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}