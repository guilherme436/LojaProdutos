using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace LojaProdutos.Pages
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Notebook", Preco = 3500.00 },
                new Produto { Nome = "Mouse Gamer", Preco = 250.00 },
                new Produto { Nome = "Teclado Mecânico", Preco = 450.00 }
            };
        }

        public class Produto
        {
            public string Nome { get; set; }
            public double Preco { get; set; }
        }
    }
}
