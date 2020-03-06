

using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationContext contexto) : base(contexto)
        {
        }

        public async Task AddCategoria(string name)
        {
            var categorias = GetCategorias();
            if (categorias != null && !categorias.Any(c => c.Nome.ToLower() == name.ToLower()))
            {
                dbSet.Add(new Categoria() { Nome = name });
                await contexto.SaveChangesAsync();
            }
        }

        public Categoria GetCategoria(string name)
        {
            return GetCategorias().FirstOrDefault(c => c.Nome.ToLower() == name.ToLower());
        }

        public IList<Categoria> GetCategorias()
        {
            return dbSet.ToList();
        }
    }
}
