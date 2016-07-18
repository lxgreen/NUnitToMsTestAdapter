using System;
using System.Diagnostics;

namespace NUnitTestProject
{
    public class SUT
    {
        public enum Enum
        {
            Value1,
            Value2
        }

        public void Setup()
        {
            Debug.WriteLine($"Setup called for {GetHashCode()}");
        }

        public void TearDown()
        {
            Debug.WriteLine($"TearDown called for {GetHashCode()}");
        }

        public void ValidatedParamException(string param1)
        {
            Debug.WriteLine($"ValidatedParamException called for {GetHashCode()}");
            if (param1 == null) throw new ArgumentNullException(nameof(param1));
            Debug.WriteLine($"ValidatedParamException: param1 = {param1}, no exception thrown");
        }

        public T ReturnExpected<T>(T expected)
        {
            return expected;
        }

        public T ReturnDefault<T>(T expected)
        {
            return default(T);
        }
    }
}