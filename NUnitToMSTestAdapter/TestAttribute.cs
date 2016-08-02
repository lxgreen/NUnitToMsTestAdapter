using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NUnitToMSTestAdapter
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class TestAttribute : Attribute
    {
        public TestAttribute()
        {
            //var testClasses = Assembly.GetAssembly()
            //var members = from member in type.GetMembers()
            //              from attribute in member.GetCustomAttributes(typeof(TestAttribute), true)
            //              select member;
        }
    }
}