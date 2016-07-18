using System;
using System.Collections;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace NUnitTestProject
{
    [TestFixture]
    public class AssertTest
    {
        private SUT _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new SUT();
            _sut.Setup();
        }

        [TearDown]
        public void TearDown()
        {
            _sut.TearDown();
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void ExpectedException()
        {
            _sut.ValidatedParamException(null);
        }

        [Test, ExpectedException(typeof(SuccessException))]
        public void Pass(string message, params object[] args)
        {
            Assert.Pass(message, args);
        }

        [Test, ExpectedException(typeof(SuccessException))]
        public void Pass(string message)
        {
            Assert.Pass(message);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void Fail(string message, params object[] args)
        {
            Assert.Fail(message, args);
        }

        [Test, ExpectedException(typeof(AssertionException))]
        public void Fail(string message)
        {
            Assert.Fail(message);
        }

        [Test, ExpectedException(typeof(IgnoreException))]
        public void Ignore(string message, params object[] args)
        {
            Assert.Ignore(message, args);
        }

        [Test, ExpectedException(typeof(IgnoreException))]
        public void Ignore(string message)
        {
            Assert.Ignore(message);
        }

        [Test, ExpectedException(typeof(InconclusiveException))]
        public void Inconclusive(string message, params object[] args)
        {
            Assert.Inconclusive(message, args);
        }

        [Test, ExpectedException(typeof(InconclusiveException))]
        public void Inconclusive(string message)
        {
            Assert.Inconclusive(message);
        }

        [Test]
        public void That(object actual, IResolveConstraint expression)
        {
            Assert.That(actual, expression);
        }

        [Test]
        public void That(object actual, IResolveConstraint expression, string message)
        {
            Assert.That(actual, expression, message);
        }

        [Test]
        public void That(object actual, IResolveConstraint expression, string message, params object[] args)
        {
            Assert.That(actual, expression, message, args);
        }

        [Test]
        public void That(bool condition, string message, params object[] args)
        {
            Assert.That(condition, message, args);
        }

        [Test]
        public void That(bool condition, string message)
        {
            Assert.That(condition, message);
        }

        [Test]
        public void That(bool condition)
        {
            Assert.That(condition);
        }

        [Test]
        public void That<T>(ActualValueDelegate<T> del, IResolveConstraint expr)
        {
            Assert.That(del, expr);
        }

        [Test]
        public void That<T>(ActualValueDelegate<T> del, IResolveConstraint expr, string message)
        {
            Assert.That(del, expr, message);
        }

        [Test]
        public void That<T>(ActualValueDelegate<T> del, IResolveConstraint expr, string message, params object[] args)
        {
            Assert.That(del, expr, message, args);
        }

        [Test]
        public void That<T>(ref T actual, IResolveConstraint expression)
        {
            Assert.That(ref actual, expression);
        }

        [Test]
        public void That<T>(ref T actual, IResolveConstraint expression, string message)
        {
            Assert.That(ref actual, expression, message);
        }

        [Test]
        public void That<T>(ref T actual, IResolveConstraint expression, string message, params object[] args)
        {
            Assert.That(ref actual, expression, message, args);
        }

        [Test]
        public void That(TestDelegate code, IResolveConstraint constraint)
        {
            Assert.That(code, constraint);
        }

        [Test]
        public void DoesNotThrow(TestDelegate code, string message, params object[] args)
        {
            Assert.DoesNotThrow(code, message, args);
        }

        [Test]
        public void DoesNotThrow(TestDelegate code, string message)
        {
            Assert.DoesNotThrow(code, message);
        }

        [Test]
        public void DoesNotThrow(TestDelegate code)
        {
            Assert.DoesNotThrow(code);
        }

        [Test]
        public void True(bool condition, string message, params object[] args)
        {
            Assert.True(condition, message, args);
        }

        [Test]
        public void True(bool condition, string message)
        {
            Assert.True(condition, message);
        }

        [Test]
        public void True(bool condition)
        {
            Assert.True(condition);
        }

        [Test]
        public void IsTrue(bool condition, string message, params object[] args)
        {
            Assert.IsTrue(condition, message, args);
        }

        [Test]
        public void IsTrue(bool condition, string message)
        {
            Assert.IsTrue(condition, message);
        }

        [Test]
        public void IsTrue(bool condition)
        {
            Assert.IsTrue(condition);
        }

        [Test]
        public void False(bool condition, string message, params object[] args)
        {
            Assert.False(condition, message, args);
        }

        [Test]
        public void False(bool condition, string message)
        {
            Assert.False(condition, message);
        }

        [Test]
        public void False(bool condition)
        {
            Assert.False(condition);
        }

        [Test]
        public void IsFalse(bool condition, string message, params object[] args)
        {
            Assert.IsFalse(condition, message, args);
        }

        [Test]
        public void IsFalse(bool condition, string message)
        {
            Assert.IsFalse(condition, message);
        }

        [Test]
        public void IsFalse(bool condition)
        {
            Assert.IsFalse(condition);
        }

        [Test]
        public void NotNull(object anObject, string message, params object[] args)
        {
            Assert.NotNull(anObject, message, args);
        }

        [Test]
        public void NotNull(object anObject, string message)
        {
            Assert.NotNull(anObject, message);
        }

        [Test]
        public void NotNull(object anObject)
        {
            Assert.NotNull(anObject);
        }

        [Test]
        public void IsNotNull(object anObject, string message, params object[] args)
        {
            Assert.IsNotNull(anObject, message, args);
        }

        [Test]
        public void IsNotNull(object anObject, string message)
        {
            Assert.IsNotNull(anObject, message);
        }

        [Test]
        public void IsNotNull(object anObject)
        {
            Assert.IsNotNull(anObject);
        }

        [Test]
        public void Null(object anObject, string message, params object[] args)
        {
            Assert.Null(anObject, message, args);
        }

        [Test]
        public void Null(object anObject, string message)
        {
            Assert.Null(anObject, message);
        }

        [Test]
        public void Null(object anObject)
        {
            Assert.Null(anObject);
        }

        [Test]
        public void IsNull(object anObject, string message, params object[] args)
        {
            Assert.IsNull(anObject, message, args);
        }

        [Test]
        public void IsNull(object anObject, string message)
        {
            Assert.IsNull(anObject, message);
        }

        [Test]
        public void IsNull(object anObject)
        {
            Assert.IsNull(anObject);
        }

        [Test]
        public void AreEqual(int expected, int actual, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, message, args);
        }

        [Test]
        public void AreEqual(int expected, int actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }

        [Test]
        public void AreEqual(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreEqual(long expected, long actual, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, message, args);
        }

        [Test]
        public void AreEqual(long expected, long actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }

        [Test]
        public void AreEqual(long expected, long actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreEqual(uint expected, uint actual, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, message, args);
        }

        [Test]
        public void AreEqual(uint expected, uint actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }

        [Test]
        public void AreEqual(uint expected, uint actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreEqual(ulong expected, ulong actual, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, message, args);
        }

        [Test]
        public void AreEqual(ulong expected, ulong actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }

        [Test]
        public void AreEqual(ulong expected, ulong actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreEqual(decimal expected, decimal actual, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, message, args);
        }

        [Test]
        public void AreEqual(decimal expected, decimal actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }

        [Test]
        public void AreEqual(decimal expected, decimal actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreEqual(double expected, double actual, double delta, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, delta, message, args);
        }

        [Test]
        public void AreEqual(double expected, double actual, double delta, string message)
        {
            Assert.AreEqual(expected, actual, delta, message);
        }

        [Test]
        public void AreEqual(double expected, double actual, double delta)
        {
            Assert.AreEqual(expected, actual, delta);
        }

        [Test]
        public void AreEqual(double expected, double? actual, double delta, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, delta, message, args);
        }

        [Test]
        public void AreEqual(double expected, double? actual, double delta, string message)
        {
            Assert.AreEqual(expected, actual, delta, message);
        }

        [Test]
        public void AreEqual(double expected, double? actual, double delta)
        {
            Assert.AreEqual(expected, actual, delta);
        }

        [Test]
        public void AreEqual(object expected, object actual, string message, params object[] args)
        {
            Assert.AreEqual(expected, actual, message, args);
        }

        [Test]
        public void AreEqual(object expected, object actual, string message)
        {
            Assert.AreEqual(expected, actual, message);
        }

        [Test]
        public void AreEqual(object expected, object actual)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(int expected, int actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(int expected, int actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(int expected, int actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(long expected, long actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(long expected, long actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(long expected, long actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(uint expected, uint actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(uint expected, uint actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(uint expected, uint actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(ulong expected, ulong actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(ulong expected, ulong actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(ulong expected, ulong actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(decimal expected, decimal actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(decimal expected, decimal actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(decimal expected, decimal actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(float expected, float actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(float expected, float actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(float expected, float actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(double expected, double actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(double expected, double actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(double expected, double actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreNotEqual(object expected, object actual, string message, params object[] args)
        {
            Assert.AreNotEqual(expected, actual, message, args);
        }

        [Test]
        public void AreNotEqual(object expected, object actual, string message)
        {
            Assert.AreNotEqual(expected, actual, message);
        }

        [Test]
        public void AreNotEqual(object expected, object actual)
        {
            Assert.AreNotEqual(expected, actual);
        }

        [Test]
        public void AreSame(object expected, object actual, string message, params object[] args)
        {
            Assert.AreSame(expected, actual, message, args);
        }

        [Test]
        public void AreSame(object expected, object actual, string message)
        {
            Assert.AreSame(expected, actual, message);
        }

        [Test]
        public void AreSame(object expected, object actual)
        {
            Assert.AreSame(expected, actual);
        }

        [Test]
        public void AreNotSame(object expected, object actual, string message, params object[] args)
        {
            Assert.AreNotSame(expected, actual, message, args);
        }

        [Test]
        public void AreNotSame(object expected, object actual, string message)
        {
            Assert.AreNotSame(expected, actual, message);
        }

        [Test]
        public void AreNotSame(object expected, object actual)
        {
            Assert.AreNotSame(expected, actual);
        }

        [Test]
        public void IsNaN(double aDouble, string message, params object[] args)
        {
            Assert.IsNaN(aDouble, message, args);
        }

        [Test]
        public void IsNaN(double aDouble, string message)
        {
            Assert.IsNaN(aDouble, message);
        }

        [Test]
        public void IsNaN(double aDouble)
        {
            Assert.IsNaN(aDouble);
        }

        [Test]
        public void IsNaN(double? aDouble, string message, params object[] args)
        {
            Assert.IsNaN(aDouble, message, args);
        }

        [Test]
        public void IsNaN(double? aDouble, string message)
        {
            Assert.IsNaN(aDouble, message);
        }

        [Test]
        public void IsNaN(double? aDouble)
        {
            Assert.IsNaN(aDouble);
        }

        [Test]
        public void IsEmpty(string aString, string message, params object[] args)
        {
            Assert.IsEmpty(aString, message, args);
        }

        [Test]
        public void IsEmpty(string aString, string message)
        {
            Assert.IsEmpty(aString, message);
        }

        [Test]
        public void IsEmpty(string aString)
        {
            Assert.IsEmpty(aString);
        }

        [Test]
        public void IsEmpty(IEnumerable collection, string message, params object[] args)
        {
            Assert.IsEmpty(collection, message, args);
        }

        [Test]
        public void IsEmpty(IEnumerable collection, string message)
        {
            Assert.IsEmpty(collection, message);
        }

        [Test]
        public void IsEmpty(IEnumerable collection)
        {
            Assert.IsEmpty(collection);
        }

        [Test]
        public void IsNotEmpty(string aString, string message, params object[] args)
        {
            Assert.IsNotEmpty(aString, message, args);
        }

        [Test]
        public void IsNotEmpty(string aString, string message)
        {
            Assert.IsNotEmpty(aString, message);
        }

        [Test]
        public void IsNotEmpty(string aString)
        {
            Assert.IsNotEmpty(aString);
        }

        [Test]
        public void IsNotEmpty(IEnumerable collection, string message, params object[] args)
        {
            Assert.IsNotEmpty(collection, message, args);
        }

        [Test]
        public void IsNotEmpty(IEnumerable collection, string message)
        {
            Assert.IsNotEmpty(collection, message);
        }

        [Test]
        public void IsNotEmpty(IEnumerable collection)
        {
            Assert.IsNotEmpty(collection);
        }

        [Test]
        public void IsNullOrEmpty(string aString, string message, params object[] args)
        {
            Assert.IsNullOrEmpty(aString, message, args);
        }

        [Test]
        public void IsNullOrEmpty(string aString, string message)
        {
            Assert.IsNullOrEmpty(aString, message);
        }

        [Test]
        public void IsNullOrEmpty(string aString)
        {
            Assert.IsNullOrEmpty(aString);
        }

        [Test]
        public void IsNotNullOrEmpty(string aString, string message, params object[] args)
        {
            Assert.IsNotNullOrEmpty(aString, message, args);
        }

        [Test]
        public void IsNotNullOrEmpty(string aString, string message)
        {
            Assert.IsNotNullOrEmpty(aString, message);
        }

        [Test]
        public void IsNotNullOrEmpty(string aString)
        {
            Assert.IsNotNullOrEmpty(aString);
        }

        [Test]
        public void IsAssignableFrom(Type expected, object actual, string message, params object[] args)
        {
            Assert.IsAssignableFrom(expected, actual, message, args);
        }

        [Test]
        public void IsAssignableFrom(Type expected, object actual, string message)
        {
            Assert.IsAssignableFrom(expected, actual, message);
        }

        [Test]
        public void IsAssignableFrom(Type expected, object actual)
        {
            Assert.IsAssignableFrom(expected, actual);
        }

        [Test]
        public void IsAssignableFrom<T>(object actual, string message, params object[] args)
        {
            Assert.IsAssignableFrom<T>(actual, message, args);
        }

        [Test]
        public void IsAssignableFrom<T>(object actual, string message)
        {
            Assert.IsAssignableFrom<T>(actual, message);
        }

        [Test]
        public void IsAssignableFrom<T>(object actual)
        {
            Assert.IsAssignableFrom<T>(actual);
        }

        [Test]
        public void IsNotAssignableFrom(Type expected, object actual, string message, params object[] args)
        {
            Assert.IsNotAssignableFrom(expected, actual, message, args);
        }

        [Test]
        public void IsNotAssignableFrom(Type expected, object actual, string message)
        {
            Assert.IsNotAssignableFrom(expected, actual, message);
        }

        [Test]
        public void IsNotAssignableFrom(Type expected, object actual)
        {
            Assert.IsNotAssignableFrom(expected, actual);
        }

        [Test]
        public void IsNotAssignableFrom<T>(object actual, string message, params object[] args)
        {
            Assert.IsNotAssignableFrom<T>(actual, message, args);
        }

        [Test]
        public void IsNotAssignableFrom<T>(object actual, string message)
        {
            Assert.IsNotAssignableFrom<T>(actual, message);
        }

        [Test]
        public void IsNotAssignableFrom<T>(object actual)
        {
            Assert.IsNotAssignableFrom<T>(actual);
        }

        [Test]
        public void IsInstanceOf(Type expected, object actual, string message, params object[] args)
        {
            Assert.IsInstanceOf(expected, actual, message, args);
        }

        [Test]
        public void IsInstanceOf(Type expected, object actual, string message)
        {
            Assert.IsInstanceOf(expected, actual, message);
        }

        [Test]
        public void IsInstanceOf(Type expected, object actual)
        {
            Assert.IsInstanceOf(expected, actual);
        }

        [Test]
        [Obsolete]
        public void IsInstanceOfType(Type expected, object actual, string message, params object[] args)
        {
            Assert.IsInstanceOfType(expected, actual, message, args);
        }

        [Test]
        [Obsolete]
        public void IsInstanceOfType(Type expected, object actual, string message)
        {
            Assert.IsInstanceOfType(expected, actual, message);
        }

        [Test]
        [Obsolete]
        public void IsInstanceOfType(Type expected, object actual)
        {
            Assert.IsInstanceOfType(expected, actual);
        }

        [Test]
        public void IsInstanceOf<T>(object actual, string message, params object[] args)
        {
            Assert.IsInstanceOf<T>(actual, message, args);
        }

        [Test]
        public void IsInstanceOf<T>(object actual, string message)
        {
            Assert.IsInstanceOf<T>(actual, message);
        }

        [Test]
        public void IsInstanceOf<T>(object actual)
        {
            Assert.IsInstanceOf<T>(actual);
        }

        [Test]
        public void IsNotInstanceOf(Type expected, object actual, string message, params object[] args)
        {
            Assert.IsNotInstanceOf(expected, actual, message, args);
        }

        [Test]
        public void IsNotInstanceOf(Type expected, object actual, string message)
        {
            Assert.IsNotInstanceOf(expected, actual, message);
        }

        [Test]
        public void IsNotInstanceOf(Type expected, object actual)
        {
            Assert.IsNotInstanceOf(expected, actual);
        }

        [Test]
        [Obsolete]
        public void IsNotInstanceOfType(Type expected, object actual, string message, params object[] args)
        {
            Assert.IsNotInstanceOfType(expected, actual, message, args);
        }

        [Test]
        [Obsolete]
        public void IsNotInstanceOfType(Type expected, object actual, string message)
        {
            Assert.IsNotInstanceOfType(expected, actual, message);
        }

        [Test]
        [Obsolete]
        public void IsNotInstanceOfType(Type expected, object actual)
        {
            Assert.IsNotInstanceOfType(expected, actual);
        }

        [Test]
        public void IsNotInstanceOf<T>(object actual, string message, params object[] args)
        {
            Assert.IsNotInstanceOf<T>(actual, message, args);
        }

        [Test]
        public void IsNotInstanceOf<T>(object actual, string message)
        {
            Assert.IsNotInstanceOf<T>(actual, message);
        }

        [Test]
        public void IsNotInstanceOf<T>(object actual)
        {
            Assert.IsNotInstanceOf<T>(actual);
        }

        [Test]
        public void Greater(int arg1, int arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(int arg1, int arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(int arg1, int arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(uint arg1, uint arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(uint arg1, uint arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(long arg1, long arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(long arg1, long arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(long arg1, long arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(ulong arg1, ulong arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(ulong arg1, ulong arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(decimal arg1, decimal arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(decimal arg1, decimal arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(double arg1, double arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(double arg1, double arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(double arg1, double arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(float arg1, float arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(float arg1, float arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(float arg1, float arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Greater(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
            Assert.Greater(arg1, arg2, message, args);
        }

        [Test]
        public void Greater(IComparable arg1, IComparable arg2, string message)
        {
            Assert.Greater(arg1, arg2, message);
        }

        [Test]
        public void Greater(IComparable arg1, IComparable arg2)
        {
            Assert.Greater(arg1, arg2);
        }

        [Test]
        public void Less(int arg1, int arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(int arg1, int arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(int arg1, int arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(uint arg1, uint arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(uint arg1, uint arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(long arg1, long arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(long arg1, long arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(long arg1, long arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(ulong arg1, ulong arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(ulong arg1, ulong arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(decimal arg1, decimal arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(decimal arg1, decimal arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(double arg1, double arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(double arg1, double arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(double arg1, double arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(float arg1, float arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(float arg1, float arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(float arg1, float arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void Less(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
            Assert.Less(arg1, arg2, message, args);
        }

        [Test]
        public void Less(IComparable arg1, IComparable arg2, string message)
        {
            Assert.Less(arg1, arg2, message);
        }

        [Test]
        public void Less(IComparable arg1, IComparable arg2)
        {
            Assert.Less(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(int arg1, int arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(int arg1, int arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(int arg1, int arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(uint arg1, uint arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(uint arg1, uint arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(long arg1, long arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(long arg1, long arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(long arg1, long arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(ulong arg1, ulong arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(ulong arg1, ulong arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(decimal arg1, decimal arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(decimal arg1, decimal arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(double arg1, double arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(double arg1, double arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(double arg1, double arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(float arg1, float arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(float arg1, float arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(float arg1, float arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void GreaterOrEqual(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
            Assert.GreaterOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void GreaterOrEqual(IComparable arg1, IComparable arg2, string message)
        {
            Assert.GreaterOrEqual(arg1, arg2, message);
        }

        [Test]
        public void GreaterOrEqual(IComparable arg1, IComparable arg2)
        {
            Assert.GreaterOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(int arg1, int arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(int arg1, int arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(int arg1, int arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(uint arg1, uint arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(uint arg1, uint arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(uint arg1, uint arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(long arg1, long arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(long arg1, long arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(long arg1, long arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(ulong arg1, ulong arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(ulong arg1, ulong arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(decimal arg1, decimal arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(decimal arg1, decimal arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(double arg1, double arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(double arg1, double arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(double arg1, double arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(float arg1, float arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(float arg1, float arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(float arg1, float arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void LessOrEqual(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
            Assert.LessOrEqual(arg1, arg2, message, args);
        }

        [Test]
        public void LessOrEqual(IComparable arg1, IComparable arg2, string message)
        {
            Assert.LessOrEqual(arg1, arg2, message);
        }

        [Test]
        public void LessOrEqual(IComparable arg1, IComparable arg2)
        {
            Assert.LessOrEqual(arg1, arg2);
        }

        [Test]
        public void Contains(object expected, ICollection actual, string message, params object[] args)
        {
            Assert.Contains(expected, actual, message, args);
        }

        [Test]
        public void Contains(object expected, ICollection actual, string message)
        {
            Assert.Contains(expected, actual, message);
        }

        [Test]
        public void Contains(object expected, ICollection actual)
        {
            Assert.Contains(expected, actual);
        }
    }
}