using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public interface IElectricalDevice
    {
        
        void Start();
        void InUse();
        void ShutDown();
        void GenerateHeat();
        string Department
        {
            get; set;
        }

    }
}
