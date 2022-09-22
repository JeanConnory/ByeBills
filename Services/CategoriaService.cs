using ByeBills.Models;
using SQLite;

namespace ByeBills.Services
{
    public class CategoriaService : ICategoriaService
    {
        public SQLiteAsyncConnection _database;

        public string StatusMessage { get; set; }

        public CategoriaService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Categoria>();
        }

        public async Task<IEnumerable<Categoria>> GetCategoriaAsync()
        {
            return await _database.Table<Categoria>().ToListAsync();
        }

        public async Task<Categoria> GetCategoriaAsync(int categoriaId)
        {
            return await _database.Table<Categoria>().Where(c => c.Id == categoriaId).FirstOrDefaultAsync();
        }

        public async Task<bool> AddUpdateCategoriaAsync(Categoria categoria)
        {
            if (categoria.Id > 0)
            {
                await _database.UpdateAsync(categoria);
            }
            else
            {
                await _database.InsertAsync(categoria);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCategoriaAsync(int catId)
        {
            await _database.DeleteAsync<Categoria>(catId);
            return await Task.FromResult(true);
        }
    }
}