using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class MexicanWave
    {

        public static void MethodRun()
        {
            Console.WriteLine("Mexican Wave: Please enter string: ");
            string input = Console.ReadLine();
            var output = WaveMethod(input);
            Console.WriteLine("Output: ");
            GenericMethods.consoleLog(output);
        }
        public static List<string> WaveMethod(string userString)
        {
            List<string> outputList = new List<string>();
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != 32)
                {
                    var some = userString[i].ToString().ToUpper();
                    StringBuilder clone = new StringBuilder(userString);
                    clone[i] = some.ToCharArray()[0];
                    outputList.Add(clone.ToString());
                }
                
            }
            return outputList;
        }
    }
}
