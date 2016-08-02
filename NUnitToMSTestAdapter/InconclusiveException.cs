using System;

namespace NUnitToMSTestAdapter
{
    public class InconclusiveException : Exception
    {
        public InconclusiveException()
        {
        }

        public InconclusiveException(string message) : base(message)
        {
        }

        public InconclusiveException(string message, object[] args) : this(message)
        {
        }
    }
}