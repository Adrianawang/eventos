using MauiAppmodel.Resources.Views;

namespace MauiAppmodel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventoPage());
        }

    }
}
