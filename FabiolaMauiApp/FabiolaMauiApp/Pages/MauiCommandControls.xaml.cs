namespace FabiolaMauiApp.Pages;

public partial class MauiCommandControls : ContentPage
{
	public MauiCommandControls()
	{
        InitializeComponent();
	}

    private async void btnDemo_Clicked(object sender, EventArgs e)
    {
		await lblDemo.RelRotateTo(360, 2000);
        await DisplayAlert("Button", "Tarefa conclu�da", "Ok");
    }

    private async void btnImgDemo_Clicked(object sender, EventArgs e)
    {
        await lblDemo.RelRotateTo(360, 5000);
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton selectedRadioButton = ((RadioButton)sender);
        if(lblPets != null && selectedRadioButton.IsChecked)
        {
            lblPets.Text = $"Selecionou: {selectedRadioButton.Content}";
            lblPets.FontSize = 20;
        }
    }

    private async void SearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        SearchBar searchBar = ((SearchBar)sender);
        await DisplayAlert("Pesquisando...", $"{searchBar.Text}", "Ok");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("SwipeView", $"Elemento tocado", "Ok");
    }
}