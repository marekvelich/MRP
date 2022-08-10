using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public sealed class Lathe : Machine
    {
        public int MaxRPM { get; private set; }

        public Lathe(string description, int usedSince, string department, int hourlyCosts, int rpm) : base(description, usedSince, department, hourlyCosts)
        {
            MaxRPM = rpm;
        }

        public sealed class LatheSpecial : Machine
        {
            public int MaxRPM { get; private set; }

            public LatheSpecial(string description, int usedSince, string department, int hourlyCosts, int rpm) : base(description, usedSince, department, hourlyCosts)
            {
                MaxRPM = rpm;
            }
        }
    }
}
