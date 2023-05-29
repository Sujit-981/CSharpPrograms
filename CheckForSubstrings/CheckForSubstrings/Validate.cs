using System;


namespace CheckForSubstrings
{
    ///<summary>
    ///Validate class is to verify the constraints for the project
    ///</summary>
    class Validate
    {
        ///<summary>
        ///Validity methods checks for the constrains and returns a interger value which will tell what constraint is wrong
        ///</summary>
        public int Validity(string stringOne, string stringTwo)
        {
            if (stringOne.Length == 0)
            {
                return 1;
            }
            else if (stringTwo.Length == 0)
            {
                return 2;
            }
            else if (stringOne.Length < stringTwo.Length)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}
