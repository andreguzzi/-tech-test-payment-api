using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api_main.Models
{
    //O vendedor deve possuir id, cpf, nome, e-mail e telefone;
    public class Seller
    {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }
     
    }
}