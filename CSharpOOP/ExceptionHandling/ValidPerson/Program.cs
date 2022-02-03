using System;

namespace ValidPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person personWithoutFirstName = new Person(string.Empty, "Peterson", 31);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            try
            {
                Person personWithNegativeAge = new Person("George", "Peterson", -1);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

        }
    }
}
