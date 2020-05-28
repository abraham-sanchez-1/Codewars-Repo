using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello! Welcome to my program holding all solutions for Codewar related problems
            //To run any of the problems, simply uncomment method prior to running.
            
            //Jaden case class
            //JadenCase.Run();

            //ArrayDiff method, removes integers from array contained in another array
            //ArrayDiff.MethodRun(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2,4});

            //ATM Pin validator using Regex, will only accept a 4 or 6 digit pin, must be numbers
            //ValidatePinCode.Run();

            //Get the Middle Character: Return middle character of string, if odd, return middle, if even, return middle 2 characters.
            MiddleCharacter.MethodRun("Example"); //should return 'm'
            MiddleCharacter.MethodRun("Examples"); //should return 'mp'

            //Ending for all programs
            Console.WriteLine("End of program");
            Console.ReadLine();


        }
    }
}
