using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new FormatException("Invalid Number");
                }

                double result = Math.Sqrt(n);

                Console.WriteLine(result);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid number");
            }
            catch (OverflowException)
            {
                throw new OverflowException("Invalid number");
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Invalid number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
