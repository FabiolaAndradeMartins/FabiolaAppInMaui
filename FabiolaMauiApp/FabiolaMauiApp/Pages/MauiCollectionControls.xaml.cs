using FabiolaMauiApp.Models;

namespace FabiolaMauiApp.Pages;

public partial class MauiCollectionControls : ContentPage
{
	public MauiCollectionControls()
	{
		InitializeComponent();
		BindingContext = new FotoViewModel();
	}

	private void AlertaCinto_OnChanged(object sender, ToggledEventArgs e)
	{
		DisplayAlert("Alerta Cinto de Segurança",
			"Você selecionou/deselecionou esta acessório", "Ok");
	}

	//private async void CarouselView_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
	//{
	//	if (e.CurrentItem != null && e.PreviousItem != null)
	//	{
	//		Foto anterior = e.PreviousItem as Foto;
	//		Foto proximo = e.CurrentItem as Foto;

	//		await DisplayAlert("CarouselView",
	//			$"anterior = {anterior.Nome} \n\npróximo = {proximo.Nome}", "Ok");
	//	}
	//}
}