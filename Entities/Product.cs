using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Manipulando_Arquivos.Entities {
    internal class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Qt { get; set; }

        public Product (string name, double price, int qt) {
            Name = name;
            Price = price;
            Qt = qt;
        }

        public double Total() {
            return Price * Qt;
        }
    }
}
