using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiEndeken.Models
{
    [BsonIgnoreExtraElements]
    public class Produto
    {
        

        public Produto()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public string Id{ get; set; }
        public DateTime CreatedAt{ get; set; }
        public DateTime UpdatedAt{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
    }
}
