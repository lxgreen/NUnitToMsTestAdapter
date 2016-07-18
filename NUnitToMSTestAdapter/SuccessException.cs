using System;

namespace NUnitToMSTestAdapter
{
    public class SuccessException : Exception
    {
        private object[] args;

        public SuccessException(string message) : base(message)
        {
        }

        public SuccessException(string message, object[] args) : base(message)
        {
            this.args = args;
        }

        public SuccessException()
        {
        }
    }
}