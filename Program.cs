using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbers
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Print instructions to console
            Console.WriteLine("Reverse Numbers");
            Console.WriteLine("Enter Number: ");

            // Read String input from console
            string sInput = Console.ReadLine();

            // Convert String to an array of Int
            var aIntArray = sInput.Select(c => c - '0').ToArray();

            // Convert Int Array to Int List
            List<int> lIntList = aIntArray.OfType<int>().ToList();

            // Reverse List
            lIntList.Reverse();

            // Convert reversed list back to string
            var sAnswer = string.Join("", lIntList);

            // Print String answer to Console
            Console.WriteLine("The reverse of: " + sInput + " is: " + sAnswer);

        }
    }
}
