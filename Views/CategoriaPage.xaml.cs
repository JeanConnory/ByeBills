using ByeBills.ViewModels;
using CommunityToolkit.Mvvm.Input;

namespace ByeBills.Views;

public partial class CategoriaPage : ContentPage
{

	public CategoriaPage(CategoriaViewModel categoriaViewModel)
	{
		InitializeComponent();
		BindingContext = categoriaViewModel;
	}
}