using System;

namespace NUnitToMSTestAdapter
{
    public class IgnoreException : Exception
    {
        private object[] args;

        public IgnoreException(string message, object[] args) : base(message)
        {
            this.args = args;
        }

        public IgnoreException(string message) : base(message)
        {
        }

        public IgnoreException()
        {
        }
    }
}