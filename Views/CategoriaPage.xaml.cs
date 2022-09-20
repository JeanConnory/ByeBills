using ByeBills.ViewModels;
using CommunityToolkit.Mvvm.Input;

namespace ByeBills.Views;

public partial class CategoriaPage : ContentPage
{
	private readonly CategoriaViewModel _categoriaViewModel;

	public CategoriaPage(CategoriaViewModel categoriaViewModel)
	{
		InitializeComponent();
		BindingContext = categoriaViewModel;
		_categoriaViewModel = categoriaViewModel;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		_categoriaViewModel.OnAppearing();
	}
}