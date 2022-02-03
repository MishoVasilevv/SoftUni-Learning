using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class SmarthPhone
        : ICanBrowse
    {
        public string Browse(string adress)
        {
            return $"Browsing: {adress}!";
        }

        public string Call(string phoneNumber)
        {
            return $"Calling... {phoneNumber}";
        }
    }
}
