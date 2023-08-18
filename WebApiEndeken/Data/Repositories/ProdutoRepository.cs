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
            var client = new MongoClient(databaseConfig.ConnectionString;
            var database = client.GetDatabase(databaseConfig.DatabaseName);

            _produto = database.GetCollection<Produto>("produto");
        }


        public IEnumerable<Produto> Get()
        {
            return _produto.Find(produto => true).ToList();
            
        }

        public Produto Get(string id)
        {
            return _produto.Find(produto => produto.Id ==id).FirstOrDefault();
        }

        public IEnumerable<Produto> GetAll()
        {
            throw new NotImplementedException();
        }

        public Produto GetToId(string id)
        {
            throw new NotImplementedException();
        }

        public void Post(Produto produto)
        {
            _produto.InsertOne(produto);            
        }

        public void Remover(string id)
        {

            _produto.DeleteOne(t => t.Id == id);
        }

        public void Update( Produto produtoUpdate)
        {

            _produto.ReplaceOne(produto => produto.Id == produtoUpdate.Id, produtoUpdate);
        }
    }
}
