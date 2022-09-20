using ByeBills.Models;
using ByeBills.Services;
using ByeBills.Views;

namespace ByeBills;

public partial class App : Application
{

    public static CategoriaService _categoriaService;

    public static CategoriaService CategoriaService
    {
        get
        {
            if (_categoriaService == null)
            {
                _categoriaService = new CategoriaService(System.IO.Path.Combine(FileSystem.AppDataDirectory, "ByeBills.db3"));
                
            }
            return _categoriaService;
        }
    }


    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
