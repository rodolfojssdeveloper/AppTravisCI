using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTravisCI.Domain
{
    public class Product
    {
        public Product(string name, decimal value)
        {
            Name = name;
            Value = value;
        }
        public string Name { get; private set; }
        public decimal Value { get; private set; }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Name) && Value > 0;
        }

    }
}
