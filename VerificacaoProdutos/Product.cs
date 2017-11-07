using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificacaoProdutos
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString() => "#" + ProductId + " - " + ProductName + " - " + Category + " - " + String.Format("{0:0.00}", UnitPrice) + "e - " + UnitsInStock; 
    }
}
