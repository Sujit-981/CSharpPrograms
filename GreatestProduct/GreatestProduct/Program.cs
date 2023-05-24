using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestProduct
{
    class Program
    {
        //method to find the product of four digits in a number.
        public int Product(int num)
        {
            int result = 1;
            while (num != 0)
            {

                result = result * (num % 10);
                num = num / 10; 

            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number which is greater than 999.");
            string number = Console.ReadLine();
            int greatest = 0;

            if (number.Length < 4)
            {
                Console.WriteLine("Invalid Input, Enter a valid one.");
                Console.ReadKey();
            }
            else
            {
                Program obj = new Program();

                //iterating through every four digit numbers in the number variable, to find the greatest product.
                for (int i = 0; i < number.Length - 3; i++)
                {
                    int check = obj.Product(Convert.ToInt32(number.Substring(i, 4)));
                    if (greatest < check)
                    {
                        greatest = check;
                    }
                }

                Console.WriteLine($"The greatest possible product here is {greatest}");
                Console.ReadKey();
            }
            

        }
    }
}
