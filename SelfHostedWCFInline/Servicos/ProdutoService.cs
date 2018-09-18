using SelfHostedWCFInline.Contratos;
using SelfHostedWCFInline.Modelos;
using System.Collections.Generic;

namespace SelfHostedWCFInline.Servicos
{
    public class ProdutoService : IProdutoService
    {
        public List<Produto> Listar()
        {
            return new List<Produto> {
                new Produto { Id = 1, Nome = "Laranja", Preco = 3.99m },
                new Produto { Id = 1, Nome = "Maçã", Preco = 5.99m }
            };
        }
    }
}
