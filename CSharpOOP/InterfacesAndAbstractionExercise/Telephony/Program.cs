using System;
using System.Linq;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(" ");
            string[] webSites = Console.ReadLine().Split(" ");

            SmarthPhone smarthPhone = new SmarthPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            bool isNumber = false;

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string currentPhoneNumber = phoneNumbers[i];

                foreach (char character in currentPhoneNumber)
                {
                    if (!Char.IsDigit(character))
                    {
                        isNumber = false;
                        break;
                    }
                    else
                    {
                        isNumber = true;
                    }
                }

                if (isNumber == true)
                {
                    if (currentPhoneNumber.Length == 10)
                    {
                        Console.WriteLine(smarthPhone.Call(currentPhoneNumber));
                    }
                    else if (currentPhoneNumber.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(currentPhoneNumber));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            bool isWebSite = false;

            for (int i = 0; i < webSites.Length; i++)
            {
                string currentWebSite = webSites[i];

                foreach (char character in currentWebSite)
                {
                    if (Char.IsDigit(character))
                    {
                        isWebSite = false;
                        break;
                    }
                    else
                    {
                        isWebSite = true;
                    }
                }

                if (isWebSite == true)
                {
                    Console.WriteLine(smarthPhone.Browse(currentWebSite));
                }
                else
                {
                    Console.WriteLine("Invalid URL!");
                }

            }
        }
    }
}
