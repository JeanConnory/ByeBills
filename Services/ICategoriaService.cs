using ByeBills.Models;

namespace ByeBills.Services
{
    public interface ICategoriaService
    {
        Task<IEnumerable<Categoria>> GetCategoriaAsync();
        Task<Categoria> GetCategoriaAsync(int categoriaId);
        Task<bool> AddUpdateCategoriaAsync(Categoria categoria);
        Task<bool> DeleteCategoriaAsync(int catId);

    }
}
