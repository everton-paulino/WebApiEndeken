using System.Collections.Generic;
using WebApiEndeken.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using WebApiEndeken.Data.Configuration;

namespace WebApiEndeken.Data.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly IMongoCollection<Produto> _produto;

        public ProdutoRepository(IDatabaseConfig databaseConfig)            
        {
            var client = new MongoClient(databaseConfig.ConnecionString);
            var database = client.GetDatabase(databaseConfig.DataBaseName);

            _produto = database.GetCollection<Produto>("produtos");
        }


        public IEnumerable<Produto> Get()
        {
            return _produto.Find(produto => true).ToList();            
        }

        public Produto Get(string id)
        {
            return _produto.Find(produto => produto.Id ==id).FirstOrDefault();
        }

        public void Post(Produto produto)
        {
            _produto.InsertOne(produto);            
        }

        public void Update(string id, Produto produtoUpdate)
        {

            _produto.ReplaceOne(produto => produto.Id == id, produtoUpdate);
        }
    }
}
