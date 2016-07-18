using System;

namespace NUnitToMSTestAdapter
{
    public class AssertionException : Exception
    {
        private object[] args;

        public AssertionException(string message) : base(message)
        {
        }

        public AssertionException(string message, object[] args) : base(message)
        {
            this.args = args;
        }

        public AssertionException()
        {
        }
    }
}