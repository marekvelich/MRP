using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class Operation
    {
        public Machine Machine { get; private set; }
        public Material Material1 { get; set; }
        public Material Material2 { get; set; }
        public Employee Employee { get; set; }
        public string Description { get; private set; }
        public double ConsumptionMaterial1 { get; private set; } //per one operation
        public double ConsumptionMaterial2 { get; private set; } //per one operation
        public int Duration { get; private set; } //min

        public Operation(string description, int duration, Employee employee)
        {
            Description = description;
            Duration = duration;
        }
            public Operation(string description, Machine mach, int duration, Employee employee)
        {
            Description = description;
            Duration = duration;
            Machine = mach;
            Employee = employee;
        }
        public Operation(string description, Machine mach, int duration, Material material, double consumptionMaterial, Employee employee)
        {
            Description = description;
            Duration = duration;
            ConsumptionMaterial1 = consumptionMaterial;
            Material1 = material;
            Machine = mach;
            Employee = employee;
        }
        public Operation(string description, Machine mach, int duration, Material material1, double consumptionMaterial1, Material material2, double consumptionMaterial2, Employee employee)
        {
            Description = description;
            Duration = duration;
            ConsumptionMaterial1 = consumptionMaterial1;
            ConsumptionMaterial2 = consumptionMaterial2;
            Material1 = material1;
            Material2 = material2;
            Machine = mach;
            Employee = employee;
        }
    }
}
