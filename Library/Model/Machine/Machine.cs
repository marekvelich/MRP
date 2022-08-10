using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public abstract class Machine : IElectricalDevice
    {
        private readonly int currentYear = DateTime.Now.Year;

        public string Description { get; protected set; }
        protected int usedSince;
        public string department { get; protected set; }
        public int HourlyCosts { get ; protected set; }

        public virtual void GenerateHeat()
        {

        }

        public virtual void Start()
        {

        }

        public void InUse()
        {

        }

        public void ShutDown()
        {

        }
        
        public string Department
        {
            get { return department; }
            set 
            {if (value == "preparation" || value == "production" || value == "finishing" || value == "quality")
                {
                    department = value;
                }
                else { department = "non manufacturing department - "+ value; }
            }
        }

        protected int UsedSince
        {
            get { return usedSince; }
            set 
            { 
                if( value >= 1980 && value <= currentYear)
                {
                    usedSince = value;
                }
            }
        }
        public Machine(string description, int usedSince, string department, int hourlyCosts)
        {
            Description = description;
            UsedSince = usedSince;
            Department = department;
            HourlyCosts = hourlyCosts;
        }
    }
}
