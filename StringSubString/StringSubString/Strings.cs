using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
//Program to find number of times the string 2 is present in string 1.
namespace StringSubString
{
    class Strings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string with length smaller than string 1:");
            string str2 = Console.ReadLine();

            int count = 0;
            int index = 0;

            if ((index = str1.IndexOf(str2, index)) == -1)
            {
                Console.WriteLine("There is no substring str2 in str1");
                Console.ReadKey();
            }
            else
            {
                Console.Write("The substring str2 is found at indexes: ");

                //iterating to print the indexes of the str2 in str1 and  to find the count of str2 in str1.
                while ((index = str1.IndexOf(str2, index)) != -1)
                {
                    Console.Write($"{index} ");
                    count++;
                    index += str2.Length;
                }

                Console.WriteLine($"\nTotal occurrences of '{str2}' in '{str1}': {count}");
                Console.ReadKey();

            }
            
        }
    }

}
