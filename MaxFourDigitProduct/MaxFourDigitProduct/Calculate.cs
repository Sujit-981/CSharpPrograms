
using System;

namespace MaxFourDigitProduct
{
    /// <summary>
    /// Calculate class is for the calculations like finding product and finding greatest product in this project
    /// </summary>
    class Calculate
    {
        ///<summary>
        ///GetProduct method accepts an integer value and returns the product of its digits
        ///</summary>
        public int GetProduct(int num)
        {
            int result = 1;
            while (num != 0)
            {

                result = result * (num % 10);
                num = num / 10;

            }
            return result;
        }

        //GetGreatest method accepts a string value and calls GetProduct method for finding greatest product
        public int GetGreatest(string number)
        {
            int greatest = 0;
            //iterating through every four digit numbers in the number variable, to find the greatest product.
            for (int i = 0; i < number.Length - 3; i++)
            {
                int check = this.GetProduct(Convert.ToInt32(number.Substring(i, 4)));
                if (greatest < check)
                {
                    greatest = check;
                }
            }
            return greatest;
        }
    }
}
