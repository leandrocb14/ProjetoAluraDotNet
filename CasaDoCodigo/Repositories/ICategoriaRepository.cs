using CasaDoCodigo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Repositories
{
    public interface ICategoriaRepository
    {
        IList<Categoria> GetCategorias();
        Categoria GetCategoria(string name);
        Task AddCategoria(string name);
    }
}
