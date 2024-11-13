namespace MauiAppmodel.Resources.Views;

public partial class ResumoEventoPage : ContentPage
{
	public ResumoEventoPage(Models.Evento evento)
	{
		InitializeComponent();
        BindingContext = evento;

    }
}