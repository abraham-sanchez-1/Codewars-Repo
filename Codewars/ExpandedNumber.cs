using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class ExpandedNumber
    {



        public static void MethodRun()
        {
            Console.WriteLine("Enter number to be expanded: ");
            //char[] numbers = ( Console.ReadLine()).ToCharArray();
            string number = Console.ReadLine();

            string newString = null;
            for (int i = 0; i < number.Length; i++)
            {
                if (newString == null && number[i] != 0)
                {
                    newString = number[i] + string.Concat(Enumerable.Repeat("0", number.Length - 1));
                }
                else if (number[i] != 48)
                {
                    newString = newString + " + " + number[i] + string.Concat(Enumerable.Repeat("0", (number.Length - (i+1))));
                }
            }

            //string addedNumbers = null;
            //List<string> stringCollection = new List<string>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (addedNumbers == null && numbers[i] != 0)
            //    {
            //        addedNumbers = numbers[i] + string.Concat(Enumerable.Repeat("0", numbers.Length - 1));
            //    }
            //    else if (numbers[i] != 48 || number[i] != 0)
            //    {
            //        addedNumbers = addedNumbers + " + " + numbers[i] + string.Concat(Enumerable.Repeat("0", (numbers.Length - i)));
            //    }
            //}

            Console.WriteLine("Method Complete, Value Returned: {0}", newString );
        }
        
    }
}
