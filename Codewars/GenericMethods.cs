using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class GenericMethods
    {

        public static void consoleLog(int[] intArray)
        {
            foreach (var item in intArray)
            {
                Console.Write(item);
            }
        }
       
    }
}
