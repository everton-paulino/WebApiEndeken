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
        void Update(Produto produtoUpdate);
        IEnumerable<Produto> GetAll();
        Produto GetToId(string id);
        void Remover(string id);
    }
}
