using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
        public sealed class Xray : Machine
    {
        public int Depth { get; private set; } //mm
        public Xray(string description, int usedSince, string department, int hourlyCosts, int depth) : base(description, usedSince, department, hourlyCosts)
        {
            Depth = depth;
        }

    }
}

