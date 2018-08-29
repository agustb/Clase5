using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Clase5.Ej2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly IClienteService ClienteService;

        public ValuesController(IClienteService clienteService)
        {
            this.ClienteService = clienteService;                
        }
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get(string nombre)
        {
            ClienteService.BuscarClientes(nombre);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            ClienteService.BuscarClientePorId(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Cliente cliente)
        {
            ClienteService.AltaCliente(cliente);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cliente cliente)
        {
            ClienteService.ModificarCliente(id, cliente);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ClienteService.EliminarCliente(id);
        }

    }
}
