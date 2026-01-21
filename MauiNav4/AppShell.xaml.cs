namespace MauiNav4;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute("ItemDetails", typeof(ItemDetails));
	}
}
