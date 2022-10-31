using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_tech.Models
{
    public class Venda
    {
       
        public int Id { get; set; }
        public  DateTime Dt_venda { get; set; }
        public Vendedor vendedor { get; set; }
        public Produto produto { get; set; }
        public EnumVendaStatus Status { get; set; }        
    }
}