using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEndeken.Data;
using WebApiEndeken.Models;
using WebApiEndeken.Models.InputModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiEndeken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        private IProdutoRepository _produtoRepository;


        public ProdutosController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            var produtos= _produtoRepository.Get();
            return Ok(produtos);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var produto = _produtoRepository.Get();

            if (produto == null)
                return NotFound();

            return Ok(produto);

        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post([FromBody] Produto newProduto)        
        {
            var addProduto = new Produto();
            addProduto.Name = newProduto.Name;
            addProduto.Description = newProduto.Description;

            addProduto.Price = newProduto.Price;

            _produtoRepository.Post(addProduto);

            return Ok(addProduto);  


        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
