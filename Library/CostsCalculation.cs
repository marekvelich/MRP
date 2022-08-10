using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public static class CostsCalculation 
    {
        public static double MachineCosts(int productAmount, Product product)
        {
            double totalCosts = 0; 
            for (int i = 0; i < product.component.Count; i++)
            {
                for (int j = 0; j < product.component[i].operations.Count; j++)
                {
                    if (product.component[i].operations[j].Machine == null)
                    {

                    }
                    else
                    {
                        double duration = product.component[i].operations[j].Duration;

                        double costs = product.component[i].operations[j].Machine.HourlyCosts * duration;
                        totalCosts += costs;
                    }
                }
            }
            return (totalCosts * productAmount) / 60;
        }
        public static double MaterialCosts(int productAmount, Product product)
        {
            double totalCosts = 0;
            for (int i = 0; i < product.component.Count; i++)
            {
                for (int j = 0; j < product.component[i].operations.Count; j++)
                {
                    double consumptionMaterial1 = product.component[i].operations[j].ConsumptionMaterial1;
                    double consumptionMaterial2 = product.component[i].operations[j].ConsumptionMaterial2;

                    if(product.component[i].operations[j].Material2 == null && product.component[i].operations[j].Material1 == null)
                    {

                    }

                    else if (product.component[i].operations[j].Material2 == null) {
                        double costsM1 = product.component[i].operations[j].Material1.Price * consumptionMaterial1;
                        totalCosts += costsM1;
                    }
                    else
                    {
                        double costsM1 = product.component[i].operations[j].Material1.Price * consumptionMaterial1;
                        double costsM2 = product.component[i].operations[j].Material2.Price * consumptionMaterial2;
                        totalCosts = totalCosts + costsM1 + costsM2;
                    }
                }
            }
            return totalCosts * productAmount;
        }

        public static double EmployeeCosts(int productAmount, Product product)
        {
            double totalCosts = 0;
            for (int i = 0; i < product.component.Count; i++)
            {
                for (int j = 0; j < product.component[i].operations.Count; j++)
                {
                    if(product.component[i].operations[j].Employee == null)
                    { 
                    
                    }
                    else
                    { 
                        double duration = product.component[i].operations[j].Duration;

                        double costs = product.component[i].operations[j].Employee.HourlyRate * duration;
                        totalCosts += costs;
                    }
                }
            }
            return (totalCosts * productAmount) / 60;
        }

    }
}
