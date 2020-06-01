using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class FirstNonRepeating
    {

        public static void MethodRun()
        {
            Console.WriteLine("Enter string/sentence: ");
            string originalInput = Console.ReadLine();
            string input = originalInput.ToLower();

            char resultEdited = input.GroupBy(a => a).Where(b => b.Count() == 1).Select(g => g.Key).FirstOrDefault();
            char resultNormalized = originalInput.FirstOrDefault(x => x.ToString().ToLower() == resultEdited.ToString());
            if(resultEdited == 0)
            {
                Console.WriteLine("No value was found");
            }
            else
            {
                Console.WriteLine("Method complete, Value Returned is -> {0}", resultNormalized);
            }
            
            

            
        }
        public static string test()
        {
            return "";
        }
    }
}
