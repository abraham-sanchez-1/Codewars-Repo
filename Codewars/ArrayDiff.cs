using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class ArrayDiff
    {
        public static int[] MethodRun(int[] arrayOne, int[]arrayTwo)
        {
            // Member Variables (HAS A)
            //Constructor (SPAWNER)
            //Member Methods (CAN DO)
            Console.WriteLine("This method will remove items from first array contained in the second.");
            Console.WriteLine("First Array {0}, Second Array {1}", arrayOne, arrayTwo);
            var newArray = arrayOne.Where(integer => !arrayTwo.Contains(integer)).ToArray();
            Console.WriteLine("New Array: {0}", newArray);
            Console.ReadLine();
            return newArray;

        }
        

    }
}
