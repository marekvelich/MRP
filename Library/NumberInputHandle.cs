using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29072022
{
    public static class NumberInputHandle
    {
        public static int amount = 0;
        public static bool GreaterThanZero(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else
            {
                return true;
            }       
        }

        public static bool IsNumber(string userInput)
        {
            if (int.TryParse(userInput, out int number))
            {
                amount = number;
                return true;
                
            }
            else
            {
                return false;
            }
        }

        public static int IsValid(KeyValuePair<int, Product> kvp)
        {
            string userInput = Console.ReadLine();

            if(IsNumber(userInput) == false || GreaterThanZero (amount) == false)
            {
                Console.WriteLine("Please enter NUMBER greater or equal to 0.");
                IsValid(kvp);
            }
            else
            {
                
            }
            return amount;
        }
    }
}
