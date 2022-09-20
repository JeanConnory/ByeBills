using ByeBills.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ByeBills.ViewModels
{
    public partial class BaseCategoriaViewModel : BaseViewModel
    {
        [ObservableProperty]
        public Categoria _categoria;

        public INavigation Navigation { get; set; }
    }
}
