using ByeBills.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeBills.Services
{
    public interface ICategoriaService
    {
        Task<bool> AddUpdateCategoriaAsync(Categoria categoria);

        Task<bool> DeleteCategoriaAsync(int categoriaId);

        Task<Categoria> GetCategoriaAsync(int categoriaId);

        Task<IEnumerable<Categoria>> GetCategoriaAsync();
    }
}
