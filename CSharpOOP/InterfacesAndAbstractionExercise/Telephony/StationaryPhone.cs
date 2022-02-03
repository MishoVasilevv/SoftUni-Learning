﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone
        : ICanCall
    {
        public string Call(string phoneNumber)
        {
            return $"Dialing... {phoneNumber}";
        }
    }
}
