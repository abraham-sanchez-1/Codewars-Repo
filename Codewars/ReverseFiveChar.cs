using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class ReverseFiveChar
    {

        public static void MethodRun()
        {

            Console.WriteLine("Enter string to reverse (will only reverse characters that are 5 or more in length):");
            
            
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Count(); i++)
            {
                if (input[i].Length >= 5)
                {
                    var some = input[i];
                    input[i] = Reverse(input[i]);           
                }
                
            }
            string output = string.Join(" ", input);
            Console.WriteLine("Output completed, result => {0}", output);


        }

        public static string Reverse(string input)
        {
            string output = new string(input.Reverse().ToArray());
            return output;

        }





    }
}
