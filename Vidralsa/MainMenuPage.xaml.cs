namespace Vidralsa;
using Vidralsa.Pages;

public partial class MainMenuPage : ContentPage
{
	public MainMenuPage()
	{
		InitializeComponent();

		btnSelector.Clicked += async (s, e) => await Shell.Current.GoToAsync("////ArticuloPage");
    }
}