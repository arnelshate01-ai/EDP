using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    internal class CustomException
    { 

public class NumberFormatException : Exception
    {
        public NumberFormatException(string message) : base(message) { }
    }

    public class StringFormatException : Exception
    {
        public StringFormatException(string message) : base(message) { }
    }

    public class CurrencyFormatException : Exception
    {
        public CurrencyFormatException(string message) : base(message) { }
    }
}
}
