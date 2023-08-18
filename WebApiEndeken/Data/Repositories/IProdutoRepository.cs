using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEndeken.Models;

namespace WebApiEndeken.Data
{
    public interface IProdutoRepository
    {
        void Post(Produto produto);
        void Update(string id, Produto produtoUpdate);
        IEnumerable<Produto> Get();
        Produto Get(string Id);
    }
}
