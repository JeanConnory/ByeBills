using ByeBills.Views;

namespace ByeBills;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(CategoriaPage), typeof(CategoriaPage));
		Routing.RegisterRoute(nameof(AddCategoriaPage), typeof(AddCategoriaPage));
	}
}
