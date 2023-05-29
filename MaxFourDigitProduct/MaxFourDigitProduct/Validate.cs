
namespace MaxFourDigitProduct
{
    /// <summary>
    /// Validate class is for checking the constraints
    /// </summary>
    class Validate
    {
        public bool IsValid(string number)
        {
            if (number.Length < 4)
            {
                return true;
            }
            return false;
        }
    }
}
