using ByeBills.Models;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeBills.ViewModels
{
    public partial class AddCategoriaViewModel : BaseCategoriaViewModel
    {
        public AddCategoriaViewModel()
        {
            Categoria = new Categoria();
        }

        [RelayCommand]
        public async void SalvarCategoria()
        {
            var categoria = Categoria;
            await App.CategoriaService.AddUpdateCategoriaAsync(categoria);

            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        public async void OnCancelar()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
