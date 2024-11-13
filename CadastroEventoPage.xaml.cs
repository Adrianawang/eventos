using MauiAppmodel.Resources.Models;

namespace MauiAppmodel.Resources.Views;

public partial class CadastroEventoPage : ContentPage
{
	public CadastroEventoPage()
    {
        NewMethod();
        BindingContext = new Evento();
    }

    private static void NewMethod()
    {
        InitializeComponente();
    }

    private static void InitializeComponente()
    {
        throw new NotImplementedException();
    }

    private async void OnCadastrarEventoClicked(object sender, EventArgs e)
    {

        var evento = (Evento)BindingContext;

        await Navigation.PushAsync(new ResumoEventoPage(evento));
    
    }

}