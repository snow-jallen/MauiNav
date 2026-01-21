using MauiNav4.ViewModels;

namespace MauiNav4;

public partial class ItemDetails : ContentPage
{
	public ItemDetails(ItemDetailsViewModel vm)
	{
		BindingContext = vm;
        InitializeComponent();
	}
}