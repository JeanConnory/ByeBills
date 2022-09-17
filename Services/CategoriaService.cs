using ByeBills.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByeBills.Services
{
    public class CategoriaService : ICategoriaService
    {
        public SQLiteAsyncConnection _database;

        public CategoriaService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Categoria>().Wait();
        }

        public async Task<bool> AddUpdateCategoriaAsync(Categoria categoria)
        {
            if(categoria.Id > 0)
            {
                await _database.UpdateAsync(categoria);
            }
            else
            {
                await _database.InsertAsync(categoria);
            }

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteCategoriaAsync(int categoriaId)
        {
            await _database.DeleteAsync<Categoria>(categoriaId);
            return await Task.FromResult(true);
        }

        public async Task<Categoria> GetCategoriaAsync(int categoriaId)
        {
            return await _database.Table<Categoria>().Where(c => c.Id == categoriaId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Categoria>> GetCategoriaAsync()
        {
            return await Task.FromResult(await _database.Table<Categoria>().ToListAsync());
        }
    }
}
