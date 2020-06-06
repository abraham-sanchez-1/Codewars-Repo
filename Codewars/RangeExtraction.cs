using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class RangeExtraction
    {

        public static void Run(int[] inputArray)
        {
            Console.WriteLine("This program will take input array and convert it to a string that has been edited to minimize space");
            Console.WriteLine("Example: [-3, -1, 2, 4, 5] , '-3,-1,2,4,5'");
            StringBuilder convertedString = new StringBuilder(inputArray[0].ToString());
            string comma = ",";
            for (int i = 1; i < inputArray.Length; i++)
            {
                convertedString.Append(comma + inputArray[i].ToString());
            }

            Console.WriteLine("Output -> {0}", convertedString);
            
        }


    }
}
