using System;

namespace FixingVol2
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 30;
            int secondNumber = 60;

            byte result;

            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);
                Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
            }
            catch (OverflowException ex)
            {
                throw new OverflowException(ex.Message);
            }
        }
    }
}
