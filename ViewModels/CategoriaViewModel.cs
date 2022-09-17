using ByeBills.Models;
using ByeBills.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ByeBills.ViewModels
{
    public partial class CategoriaViewModel : BaseCategoriaViewModel
    {
        public CategoriaViewModel()
        {

        }

        [RelayCommand]
        async void OnAddCategoria()
        {
            await Shell.Current.GoToAsync(nameof(AddCategoriaPage));
        }
    }
}
