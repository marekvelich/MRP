using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class CuttingMachine : Machine
    {

        public CuttingMachine(string id, int usedSince, string department, int hourlyCosts) : base(id, usedSince, department, hourlyCosts)
        {
            
        }
    }
}
