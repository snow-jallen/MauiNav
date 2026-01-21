using MauiNav4.ViewModels;

namespace MauiNav4;

public partial class MainPage : ContentPage
{

	public MainPage(MainPageViewModel vm)
	{
		BindingContext = vm;
		InitializeComponent();
	}
}
