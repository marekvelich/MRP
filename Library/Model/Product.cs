using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class Product
    {
        public List<Component> component = new List<Component>();
        public string NamePlural { get; set; }
        public int AssemblyTime { get; set; } //min
        
        public Product(string namePlural, int assemblyTime, List<KeyValuePair<int, Product>> productss, int amount)
        {
            NamePlural = namePlural;
            AssemblyTime = assemblyTime;
            productss.Add(new KeyValuePair<int, Product>(amount, this));
        }
    }
}
