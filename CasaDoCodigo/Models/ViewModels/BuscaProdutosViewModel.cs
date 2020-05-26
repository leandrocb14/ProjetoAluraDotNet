using CasaDoCodigo.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CasaDoCodigo.Models.ViewModels
{
    public class BuscaProdutosViewModel
    {
        public IList<Categoria> Categorias { get; set; }
        public string Pesquisa { get; set; }

        public BuscaProdutosViewModel()
        {
            Categorias = new List<Categoria>();
        }
    }
}
