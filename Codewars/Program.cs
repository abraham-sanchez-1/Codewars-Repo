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
            //MiddleCharacter.MethodRun("Example"); //should return 'm'
            //MiddleCharacter.MethodRun("Examples"); //should return 'mp'

            //Enough is Enough! Return a new int array that oncly contains each number at most X times.
            //int[] arrayName = { 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5}; 
            //int repeatLimit = 2;
            //EnoughIsEnough.MethodRun(arrayName, repeatLimit); // Will display array: [1,2,2,3,3,4,4,5,5]

            //Encryption Part #1: Take every 2nd char from the string, then the other chars that are not every 2nd char, and concat them as new String.
            //var value = EncryptionPartOne.Encrypt("This is a test!", 1);
            //Console.WriteLine("This is the encrypted form: {0}", value);
            //var newValue = EncryptionPartOne.Decrypt(value, 1);//Prints
            //Console.WriteLine("Now it has been decrypted: {0}", newValue);

            //Number in Expanded Form: return expanded form of a number, example: 4032 -> 4000 + 30 + 2
            //ExpandedNumber.MethodRun();

            //Mexican Wave: As seen in stadiums accross the world, the Mexican wave (as it originated in Mexico) is refers to the wave like pattern that 
            //          fans in a stadium create by standing up in a successive pattern.  This will be replicated by the method below by taking in a lowercase string
            //          and returning a list of strings that imitates this wave via a slightly altered version of the input string
            //          example: Input: "hello" -> Output: ["Hello", "hEllo", "heLlo", "helLo", ""hellO"]
            MexicanWave.MethodRun();

            //Ending for all programs
            Console.WriteLine("End of program");
            Console.ReadLine();


        }
    }
}
