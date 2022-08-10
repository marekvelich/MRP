using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class Material
    {

        public string Description { get; private set; }
        public double Price { get; private set; } //€ per kg

        public Material(string description, double price)
        {
            Description = description;
            Price = price;
        }
    }
}
