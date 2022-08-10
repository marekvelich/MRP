using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class Drill : Machine
    {
        public int Depth { get; private set; } //mm
        public string Material { get; private set; } 
        public int Angle { get; private set; }
        public Drill(string description, int usedSince, string department, int hourlyCosts, int depth, string material, int angle) : base(description, usedSince, department, hourlyCosts)
        {
            Depth = depth;
            Material = material;
            Angle = angle;
        }
    }
}
