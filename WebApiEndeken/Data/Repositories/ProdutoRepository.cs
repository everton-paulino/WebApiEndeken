using System.Collections.Generic;
using WebApiEndeken.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEndeken.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {


        public IEnumerable<Produto> Get()
        {
            throw new System.NotImplementedException();
        }

        public Produto Get(string Id)
        {
            throw new System.NotImplementedException();
        }

        public void Post(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public void Update(string id, Produto produtoUpdate)
        {
            throw new System.NotImplementedException();
        }
    }
}
