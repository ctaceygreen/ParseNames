using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseNames
{
    class Program
    {
        //Output an array of the strings in the form "a is from a b c" from a set of
        //inputs such as "a b c","d e f"
        static void Main(string[] args)
        {
            List<string> testInputs = new List<string>
            {
                "a b c",
                "d e f",
                "",
                "a"
            };
            foreach(var input in testInputs)
            {
                Console.WriteLine($"{input} : {String.Join("|", ParseStringsFromFullString(input))}");
            }
            Console.ReadLine();
        }

        public static string[] ParseStringsFromFullString(string fullString)
        {
            string cleanedFullString = fullString.TrimEnd();
            cleanedFullString = cleanedFullString.TrimStart();
            string[] splitString = cleanedFullString.Split(' ');
            string[] resultArray = new string[splitString.Length];

            for(int wordIndex = 0; wordIndex < splitString.Length; wordIndex++)
            {
                string word = splitString[wordIndex];
                resultArray[wordIndex] = $"{word} is from {fullString}";
            }
            return resultArray;
        }
    }
}
