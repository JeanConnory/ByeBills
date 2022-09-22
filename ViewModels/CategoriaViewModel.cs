using ByeBills.Models;
using ByeBills.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ByeBills.ViewModels
{
    public partial class CategoriaViewModel : BaseCategoriaViewModel
    {
        public ObservableCollection<Categoria> categoriaList { get; }

        public CategoriaViewModel(INavigation navigation)
        {
            categoriaList = new ObservableCollection<Categoria>();
            Navigation = navigation;
        }


        [RelayCommand]
        async void OnAddCategoria()
        {
            await Shell.Current.GoToAsync(nameof(AddCategoriaPage));
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        [RelayCommand]
        private async Task LoadCategorias()
        {
            IsBusy = true;

            try
            {
                categoriaList.Clear();
                var catList = await App.CategoriaService.GetCategoriaAsync();
                foreach (var item in catList)
                {
                    categoriaList.Add(item);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        private async Task CategoriaTappedDelete(Categoria categoria)
        {
            if (categoria == null)
                return;
            await App.CategoriaService.DeleteCategoriaAsync(categoria.Id);
            await LoadCategorias();
            OnAppearing();
        }

        [RelayCommand]
        private async Task CategoriaTappedEdit(Categoria categoria)
        {
            if (categoria == null)
                return;
            await Navigation.PushAsync(new AddCategoriaPage(categoria));
        }


    }
}
