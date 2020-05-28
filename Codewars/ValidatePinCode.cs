using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Codewars
{
    public static class ValidatePinCode
    {

        public static void Run()
        {
            Console.WriteLine("This is a mock ATM pin validator, this will");
            Console.WriteLine("only accept a 4 or 6 digit pin.");
            Console.WriteLine("Enter Pin: ");
            string pin = Console.ReadLine();
            if(RegexValidate(pin))
            {
                Console.WriteLine("Pin Was accepted");
            }
            else {
                Console.WriteLine("Pin was not accepted");
            }
            


        }
        public static bool RegexValidate(string pin)
        {
            return Regex.IsMatch(pin, @"^((\d{4})|(\d{6}$))\z");
        }
    }
}
