using System;


namespace CheckForSubstrings
{
    ///<summary>
    ///This Program will be used to find the indexes of the substring and count the number of occurances
    ///</summary>
    class Program
    {
        /// <summary>
        /// In main menthod the inputs are taken from the user and checked for validity in another class and if they are valid, then checked how many times stringTwo appears in stringOne and at what indexes
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            //Taking inputs from user
            Console.WriteLine("Enter the first string:");
            string stringOne = Console.ReadLine();

            Console.WriteLine("Enter the second string with length smaller than string 1:");
            string stringTwo = Console.ReadLine();

            int count = 0;
            int index = 0;

            //Creating object for validate class
            Validate CheckConstraints = new Validate();

            int check = CheckConstraints.Validity(stringOne, stringTwo);

            //Perfoming actions according to results obtained from validate class
            if (check == 4)
            {
                //Condition checking if stringTwo is present in stringOne or not
                if ((index = stringOne.IndexOf(stringTwo, index)) == -1)
                {
                    Console.WriteLine("There is no substring stringTwo in stringOne");
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("The substring stringTwo is found at indexes: ");

                    //iterating to print the indexes of the str2 in str1 and  to find the count of str2 in str1.
                    while ((index = stringOne.IndexOf(stringTwo, index)) != -1)
                    {
                        Console.Write($"{index} ");
                        count++;
                        index += stringTwo.Length;
                    }

                    Console.WriteLine($"\nTotal occurrences of '{stringTwo}' in '{stringOne}': {count}");
                    Console.ReadKey();

                }
            }
            else if (check == 1)
            {
                Console.WriteLine("Invalid stringOne declaration, give a valid one");
                Console.ReadKey();
            }
            else if (check == 2)
            {
                Console.WriteLine("Invalid stringTwo declaration, give a valid one");
                Console.ReadKey();
            }
            else if (check == 3)
            {
                Console.WriteLine("stringTwo is greater in size than stringOne, enter stringOne with length more than stringTwo");
                Console.ReadKey();
            }

        }
    }
}
