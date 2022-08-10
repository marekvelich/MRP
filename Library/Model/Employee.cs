using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class Employee
    {
        public double HourlyRate { get; set; } //€ per h

        public Employee(double hourlyRate)
        {
            HourlyRate = hourlyRate;
        }
    }
}
