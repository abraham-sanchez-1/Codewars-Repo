using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class EncryptionPartOne
    {

        public static string Encrypt(string text, int n)
        {
            string holder = text;
            if (text == null)
            {
                return text;
            }
            if (n <= 0)
            {
                return text;
            }
            for (int i = 0; i < n; i++)
            {
                holder = EncryptMethod(holder);
            }

            return holder;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            string holder = encryptedText;
            if (encryptedText == null)
            {
                return encryptedText;
            }
            if (n <= 0)
            {
                return encryptedText;
            }
            for (int i = 0; i < n; i++)
            {
                holder = DecryptMethod(holder);
            }

            return holder;
        }

        public static string EncryptMethod(string text)
        {
            var charString = text.ToCharArray();
            string newString = null;
            for (int i = 1; i < charString.Length; i += 2)
            {
                newString += charString[i];
            }
            for (int i = 0; i < charString.Length; i += 2)
            {
                newString += charString[i];
            }
            return newString;
        }
        public static string DecryptMethod(string text)
        {
            var arrayText = text.ToArray();
            List<char> aggregator = new List<char>();
            var firstHalf = arrayText.Take(arrayText.Length / 2).ToArray();
            var secondHalf = arrayText.Skip(arrayText.Length / 2).ToArray();
            for (int i = 0; i < firstHalf.Length; i++)
            {
                aggregator.Add(secondHalf[i]);
                aggregator.Add(firstHalf[i]);
            }
            if(firstHalf.Length != secondHalf.Length)
            {
                aggregator.Add(secondHalf[secondHalf.Length-1]);
            }
            string final = new string(aggregator.ToArray());
                return final;
        }
    }
}
