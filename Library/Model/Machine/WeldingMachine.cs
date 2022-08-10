using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class WeldingMachine : Machine
    {
        public string Method { get; private set; } //mm
        public WeldingMachine(string description, int usedSince, string department, int hourlyCosts, string method) : base(description, usedSince, department, hourlyCosts)
        {
            Method = method;
        }
    }
}
