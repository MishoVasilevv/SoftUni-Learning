using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public interface ICanBrowse 
        : ICanCall
    {
        string Browse(string adress);
    }
}
