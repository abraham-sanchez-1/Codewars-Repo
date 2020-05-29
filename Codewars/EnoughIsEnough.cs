using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class EnoughIsEnough
    {

        public static int[] MethodRun(int[] intArray, int limit)
        {

            Console.WriteLine("This method will create a new array from array:") ;
            GenericMethods.consoleLog(intArray);

            Dictionary<int, int> valuePairs = new Dictionary<int, int>();
            List<int> tempList = new List<int>();
            for (int i = 0; i < intArray.Length; i++)
            {
                if (valuePairs.ContainsKey(intArray[i])  )
                {
                    if (valuePairs[intArray[i]] < limit)
                    {
                        valuePairs[intArray[i]]++;
                        tempList.Add(intArray[i]);
                    }
                    continue;
                }
                else
                {
                    valuePairs[intArray[i]] = 1;
                    tempList.Add(intArray[i]);
                }
            }

            int[] finalArray = tempList.ToArray();


            //var newArray = valuePairs.Values.ToArray();

            return finalArray;
        }

        
    }
}
