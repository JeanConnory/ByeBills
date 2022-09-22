using ByeBills.Models;
using ByeBills.ViewModels;

namespace ByeBills.Views;

public partial class AddCategoriaPage : ContentPage
{
	public Categoria Categoria { get; set; }

	public AddCategoriaPage()
	{
		InitializeComponent();
        this.BindingContext = new AddCategoriaViewModel();
    }

    public AddCategoriaPage(Categoria categoria)
    {
        InitializeComponent();
        BindingContext = new AddCategoriaViewModel();

        if(categoria != null)
        {
            ((AddCategoriaViewModel)BindingContext).Categoria = categoria;
        }
    }
}