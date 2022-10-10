using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace tech_test_payment_api_main.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase
    {
        

        //Registrar venda: Recebe os dados do vendedor + itens vendidos. Registra venda com status "Aguardando pagamento";
        //Buscar venda: Busca pelo Id da venda;
        //Atualizar venda: Permite que seja atualizado o status da venda.
        //OBS.: Possíveis status:



        [HttpGet("{id}")]
        public IActionResult ObterVendaPorId(int id)
        {
            var sale = (id);

            if (sale == null)
                return NotFound();
            return Ok(sale);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarVenda(int id)
        {
            
           return Ok();
           
        }

         [HttpPost]
        public IActionResult RegistrarVenda(int id)
        {
            return Ok();
        }
    }
}