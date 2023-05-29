using System;


namespace MaxFourDigitProduct
{
    /// <summary>
    /// This program is to calculate the greatest product of the digits of every consecutive four digit number formed by the given number
    /// </summary>
    class Program
    {
        ///<summary>
        ///this method takes the inout from user and creates an object of validate class and claculate class and calls teh required methods.
        static void Main(string[] args)
        {
            //Taking the input from the user
            Console.WriteLine("Enter a number which is greater than 999.");
            string number = Console.ReadLine();
            int greatest = 0;

            //Creating an object for Validate class
            Validate validation = new Validate();

            if (validation.IsValid(number))
            {
                Console.WriteLine($"The number {number} is invalid, so enter a number greater than 999");
                Console.ReadKey();
            }
            else
            {
                //Creating an object for Calculate class
                Calculate calculate = new Calculate();

                greatest = calculate.GetGreatest(number);

                //Printing the output
                Console.WriteLine($"The greatest possible product here is {greatest}");
                Console.ReadKey();
            }
        }
    }
}
