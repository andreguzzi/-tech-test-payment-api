using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api_main.Models
{
    //Uma venda contém informação sobre o vendedor que a efetivou, 
    //data, identificador do pedido e os itens que foram vendidos;
    public class Sale
    {
        public int Id { get; set; }
        public string NameSeller { get; set; }
        public List<Product> ListProducts { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusRequest Status { get; set; }
      
    }
}