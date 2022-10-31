using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using api_tech.Models;
using api_tech.Context;

namespace api_tech.Controllers
{   
    [ApiController]
    [Route ("[Controller]")]
    public class VendaController : ControllerBase
    {
         private readonly lojaContext _context;
       
        public VendaController(lojaContext context)
        { // aqui  é o construtor 
            _context = context;
        }

        [HttpPost("cadastrar produto")]
        public IActionResult Create(Produto produto)
        {
            _context.Add(produto);
            _context.SaveChanges();
            return Ok(produto);

        }

        [HttpPost("cadastrar vendedor")]
        public IActionResult Create(Vendedor vendedor)
        {
            _context.Add(vendedor);
            _context.SaveChanges();
            return Ok(vendedor);
        }

          [HttpPost("cadastrar venda")]
        public IActionResult Create(Venda venda)
        {
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
        } 

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id )
        {
           var venda = _context.Vendas.Find(id);
           if(venda == null)
           {
            return NotFound();
           }
            return Ok(venda);
        }
                 

          [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumVendaStatus status)
        {       
            var venda = _context.Vendas.Where(x => x.Status == status);
            
            return Ok(venda);
        }
    }
}