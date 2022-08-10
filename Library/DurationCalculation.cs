using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public static class DurationCalculation
    {
        public static int ProductManufactureDuration(int productAmount, Product product)
        {
            int totalDuration = 0;
            for (int i = 0; i < product.component.Count; i++)
            {
                for (int j = 0; j < product.component[i].operations.Count; j++)
                {
                    int duration = product.component[i].operations[j].Duration;
                    totalDuration += duration;
                }
            }
            return totalDuration * productAmount;
        }
    }
}
