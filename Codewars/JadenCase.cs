using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    //Jaden Case - Phrase in which all first letters are capitalized
    // Example: "Hello, This Is Jaden Cased"
    public static class JadenCase
    {
        public static string Run()
        {
            // Member Variables (HAS A)
            //Constructor (SPAWNER)
            //Member Methods (CAN DO)
            Console.WriteLine("Hello, this is the Jaden Case program");
            Console.WriteLine("This will capitalize all first letters of your input below");
            Console.WriteLine("Enter phrase: ");
            string phrase = Console.ReadLine();
            var charArray = phrase.ToCharArray();
            var jadenCasedString = Capitalize(charArray);
            Console.WriteLine("The Jaden Cased string is: {0}", jadenCasedString);
           
            return phrase;
        }
        private static string Capitalize(char[] charArray)
        {
            var reformattedCharArray = charArray;
            //first letter to be capitalized
            reformattedCharArray[0] = char.ToUpper(charArray[0]);
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ' ')
                {
                    reformattedCharArray[i] = char.ToUpper(charArray[i]);
                    reformattedCharArray[i + 1] = char.ToUpper(charArray[i + 1]);
                }
            }
            String reformattedString = new String(reformattedCharArray);
            return reformattedString;
        }

    }
}
