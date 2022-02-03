using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ICanCall
    {
        string Call(string phoneNumber);
    }
}
