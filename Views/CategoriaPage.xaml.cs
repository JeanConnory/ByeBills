using ByeBills.ViewModels;
using CommunityToolkit.Mvvm.Input;

namespace ByeBills.Views;

public partial class CategoriaPage : ContentPage
{
	CategoriaViewModel categoriaViewModel;

	public CategoriaPage()
	{
		InitializeComponent();
		this.BindingContext = categoriaViewModel = new CategoriaViewModel(Navigation);
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		categoriaViewModel.OnAppearing();
	}
}