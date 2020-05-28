using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class MiddleCharacter
    {

        public static string MethodRun(string inputString )
        {
            var inputArray = inputString.ToCharArray();

            if(inputArray.Length % 2 == 0)
            {
                var middleIndex = inputArray.Length / 2;
                return  inputArray[middleIndex-1].ToString() + inputArray[middleIndex].ToString();
            } else
            {
                var middleIndex = inputArray.Length / 2;
                return inputArray[middleIndex].ToString();
            }
        }
    }
}
