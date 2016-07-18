using System;

namespace NUnitToMSTestAdapter
{
    public class Assert
    {
        private static int _counter = 0;

        /// <summary>
        /// Gets the number of assertions executed so far and
        /// resets the counter to zero.
        /// </summary>
        public static int Counter
        {
            get { return _counter; }
        }

        /// <summary>
        /// Throws a <see cref="T:NUnit.Framework.SuccessException" /> with the message and arguments
        /// that are passed in. This allows a test to be cut short, with a result
        /// of success returned to NUnit.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Pass(string message, params object[] args)
        {
            throw new SuccessException(message, args);
        }

        /// <summary>
        /// Throws a <see cref="T:NUnit.Framework.SuccessException" /> with the message and arguments
        /// that are passed in. This allows a test to be cut short, with a result
        /// of success returned to NUnit.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        public static void Pass(string message)
        {
            throw new SuccessException(message);
        }

        /// <summary>
        /// Throws a <see cref="T:NUnit.Framework.SuccessException" /> with the message and arguments
        /// that are passed in. This allows a test to be cut short, with a result
        /// of success returned to NUnit.
        /// </summary>
        public static void Pass()
        {
            throw new SuccessException();
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.AssertionException" /> with the message and arguments
        /// that are passed in. This is used by the other Assert functions.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Fail(string message, params object[] args)
        {
            throw new AssertionException(message, args);
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.AssertionException" /> with the message that is
        /// passed in. This is used by the other Assert functions.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        public static void Fail(string message)
        {
            throw new AssertionException(message);
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.AssertionException" />.
        /// This is used by the other Assert functions.
        /// </summary>
        public static void Fail()
        {
            throw new AssertionException();
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.IgnoreException" /> with the message and arguments
        /// that are passed in.  This causes the test to be reported as ignored.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Ignore(string message, params object[] args)
        {
            throw new IgnoreException(message, args);
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.IgnoreException" /> with the message that is
        /// passed in. This causes the test to be reported as ignored.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.AssertionException" /> with.</param>
        public static void Ignore(string message)
        {
            throw new IgnoreException(message);
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.IgnoreException" />.
        /// This causes the test to be reported as ignored.
        /// </summary>
        public static void Ignore()
        {
            throw new IgnoreException();
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.InconclusiveException" /> with the message and arguments
        /// that are passed in.  This causes the test to be reported as inconclusive.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.InconclusiveException" /> with.</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void Inconclusive(string message, params object[] args)
        {
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.InconclusiveException" /> with the message that is
        /// passed in. This causes the test to be reported as inconclusive.
        /// </summary>
        /// <param name="message">The message to initialize the <see cref="T:NUnit.Framework.InconclusiveException" /> with.</param>
        public static void Inconclusive(string message)
        {
        }

        /// <summary>
        /// Throws an <see cref="T:NUnit.Framework.InconclusiveException" />.
        /// This causes the test to be reported as Inconclusive.
        /// </summary>
        public static void Inconclusive()
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        public static void That(object actual, IResolveConstraint expression)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static void That(object actual, IResolveConstraint expression, string message)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That(object actual, IResolveConstraint expression, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display if the condition is false</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That(bool condition, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display if the condition is false</param>
        public static void That(bool condition, string message)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void That(bool condition)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="del">An ActualValueDelegate returning the value to be tested</param>
        /// <param name="expr">A Constraint expression to be applied</param>
        public static void That<T>(ActualValueDelegate<T> del, IResolveConstraint expr)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="del">An ActualValueDelegate returning the value to be tested</param>
        /// <param name="expr">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static void That<T>(ActualValueDelegate<T> del, IResolveConstraint expr, string message)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="del">An ActualValueDelegate returning the value to be tested</param>
        /// <param name="expr">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That<T>(ActualValueDelegate<T> del, IResolveConstraint expr, string message, params object[] args)
        {
        }

        /// <summary>
        /// Apply a constraint to a referenced value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        public static void That<T>(ref T actual, IResolveConstraint expression)
        {
        }

        /// <summary>
        /// Apply a constraint to a referenced value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static void That<T>(ref T actual, IResolveConstraint expression, string message)
        {
        }

        /// <summary>
        /// Apply a constraint to a referenced value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void That<T>(ref T actual, IResolveConstraint expression, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that the code represented by a delegate throws an exception
        /// that satisfies the constraint provided.
        /// </summary>
        /// <param name="code">A TestDelegate to be executed</param>
        /// <param name="constraint">A ThrowsConstraint used in the test</param>
        public static void That(TestDelegate code, IResolveConstraint constraint)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// Used as a synonym for That in rare cases where a private setter
        /// causes a Visual Basic compilation error.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        public static void ByVal(object actual, IResolveConstraint expression)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// Used as a synonym for That in rare cases where a private setter
        /// causes a Visual Basic compilation error.
        /// </summary>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static void ByVal(object actual, IResolveConstraint expression, string message)
        {
        }

        /// <summary>
        /// Apply a constraint to an actual value, succeeding if the constraint
        /// is satisfied and throwing an assertion exception on failure.
        /// Used as a synonym for That in rare cases where a private setter
        /// causes a Visual Basic compilation error.
        /// </summary>
        /// <remarks>
        /// This method is provided for use by VB developers needing to test
        /// the value of properties with private setters.
        /// </remarks>
        /// <param name="actual">The actual value to test</param>
        /// <param name="expression">A Constraint expression to be applied</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void ByVal(object actual, IResolveConstraint expression, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static Exception Throws(IResolveConstraint expression, TestDelegate code, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static Exception Throws(IResolveConstraint expression, TestDelegate code, string message)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expression">A constraint to be satisfied by the exception</param>
        /// <param name="code">A TestDelegate</param>
        public static Exception Throws(IResolveConstraint expression, TestDelegate code)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static Exception Throws(Type expectedExceptionType, TestDelegate code, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static Exception Throws(Type expectedExceptionType, TestDelegate code, string message)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <param name="expectedExceptionType">The exception Type expected</param>
        /// <param name="code">A TestDelegate</param>
        public static Exception Throws(Type expectedExceptionType, TestDelegate code)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="T">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static T Throws<T>(TestDelegate code, string message, params object[] args) where T : Exception;

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="T">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static T Throws<T>(TestDelegate code, string message) where T : Exception;

        /// <summary>
        /// Verifies that a delegate throws a particular exception when called.
        /// </summary>
        /// <typeparam name="T">Type of the expected exception</typeparam>
        /// <param name="code">A TestDelegate</param>
        public static T Throws<T>(TestDelegate code) where T : Exception;

        /// <summary>
        /// Verifies that a delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static Exception Catch(TestDelegate code, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static Exception Catch(TestDelegate code, string message)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws an exception when called
        /// and returns it.
        /// </summary>
        /// <param name="code">A TestDelegate</param>
        public static Exception Catch(TestDelegate code)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static Exception Catch(Type expectedExceptionType, TestDelegate code, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static Exception Catch(Type expectedExceptionType, TestDelegate code, string message)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <param name="expectedExceptionType">The expected Exception Type</param>
        /// <param name="code">A TestDelegate</param>
        public static Exception Catch(Type expectedExceptionType, TestDelegate code)
        {
        }

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <typeparam name="T">The expected Exception Type</typeparam>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static T Catch<T>(TestDelegate code, string message, params object[] args) where T : Exception;

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <typeparam name="T">The expected Exception Type</typeparam>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static T Catch<T>(TestDelegate code, string message) where T : Exception;

        /// <summary>
        /// Verifies that a delegate throws an exception of a certain Type
        /// or one derived from it when called and returns it.
        /// </summary>
        /// <typeparam name="T">The expected Exception Type</typeparam>
        /// <param name="code">A TestDelegate</param>
        public static T Catch<T>(TestDelegate code) where T : Exception;

        /// <summary>Verifies that a delegate does not throw an exception</summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        /// <param name="args">Arguments to be used in formatting the message</param>
        public static void DoesNotThrow(TestDelegate code, string message, params object[] args)
        {
        }

        /// <summary>Verifies that a delegate does not throw an exception.</summary>
        /// <param name="code">A TestDelegate</param>
        /// <param name="message">The message that will be displayed on failure</param>
        public static void DoesNotThrow(TestDelegate code, string message)
        {
        }

        /// <summary>Verifies that a delegate does not throw an exception.</summary>
        /// <param name="code">A TestDelegate</param>
        public static void DoesNotThrow(TestDelegate code)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void True(bool condition, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void True(bool condition, string message)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void True(bool condition)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsTrue(bool condition, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsTrue(bool condition, string message)
        {
        }

        /// <summary>
        /// Asserts that a condition is true. If the condition is false the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void IsTrue(bool condition)
        {
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void False(bool condition, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void False(bool condition, string message)
        {
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void False(bool condition)
        {
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsFalse(bool condition, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsFalse(bool condition, string message)
        {
        }

        /// <summary>
        /// Asserts that a condition is false. If the condition is true the method throws
        /// an <see cref="T:NUnit.Framework.AssertionException" />.
        /// </summary>
        /// <param name="condition">The evaluated condition</param>
        public static void IsFalse(bool condition)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void NotNull(object anObject, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void NotNull(object anObject, string message)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void NotNull(object anObject)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotNull(object anObject, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotNull(object anObject, string message)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is not equal to <code>null</code>
        /// If the object is <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void IsNotNull(object anObject)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Null(object anObject, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Null(object anObject, string message)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void Null(object anObject)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNull(object anObject, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNull(object anObject, string message)
        {
        }

        /// <summary>
        /// Verifies that the object that is passed in is equal to <code>null</code>
        /// If the object is not <code>null</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="anObject">The object that is to be tested</param>
        public static void IsNull(object anObject)
        {
        }

        /// <summary>
        /// Verifies that two ints are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(int expected, int actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two ints are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(int expected, int actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two ints are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(int expected, int actual)
        {
        }

        /// <summary>
        /// Verifies that two longs are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(long expected, long actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two longs are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(long expected, long actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two longs are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(long expected, long actual)
        {
        }

        /// <summary>
        /// Verifies that two unsigned ints are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreEqual(uint expected, uint actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two unsigned ints are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreEqual(uint expected, uint actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two unsigned ints are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreEqual(uint expected, uint actual)
        {
        }

        /// <summary>
        /// Verifies that two unsigned longs are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreEqual(ulong expected, ulong actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two unsigned longs are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreEqual(ulong expected, ulong actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two unsigned longs are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreEqual(ulong expected, ulong actual)
        {
        }

        /// <summary>
        /// Verifies that two decimals are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(decimal expected, decimal actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two decimals are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(decimal expected, decimal actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two decimals are equal. If they are not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(decimal expected, decimal actual)
        {
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(double expected, double actual, double delta, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(double expected, double actual, double delta, string message)
        {
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        public static void AreEqual(double expected, double actual, double delta)
        {
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(double expected, double? actual, double delta, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(double expected, double? actual, double delta, string message)
        {
        }

        /// <summary>
        /// Verifies that two doubles are equal considering a delta. If the
        /// expected value is infinity then the delta value is ignored. If
        /// they are not equal then an <see cref="T:NUnit.Framework.AssertionException" /> is
        /// thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        public static void AreEqual(double expected, double? actual, double delta)
        {
        }

        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreEqual(object expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreEqual(object expected, object actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two objects are equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are not equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(object expected, object actual)
        {
        }

        /// <summary>
        /// Verifies that two ints are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(int expected, int actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two ints are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(int expected, int actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two ints are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(int expected, int actual)
        {
        }

        /// <summary>
        /// Verifies that two longs are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(long expected, long actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two longs are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(long expected, long actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two longs are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(long expected, long actual)
        {
        }

        /// <summary>
        /// Verifies that two unsigned ints are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(uint expected, uint actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two unsigned ints are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(uint expected, uint actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two unsigned ints are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(uint expected, uint actual)
        {
        }

        /// <summary>
        /// Verifies that two unsigned longs are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(ulong expected, ulong actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two unsigned longs are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(ulong expected, ulong actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two unsigned longs are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        [CLSCompliant(false)]
        public static void AreNotEqual(ulong expected, ulong actual)
        {
        }

        /// <summary>
        /// Verifies that two decimals are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(decimal expected, decimal actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two decimals are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(decimal expected, decimal actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two decimals are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(decimal expected, decimal actual)
        {
        }

        /// <summary>
        /// Verifies that two floats are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(float expected, float actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two floats are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(float expected, float actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two floats are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(float expected, float actual)
        {
        }

        /// <summary>
        /// Verifies that two doubles are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(double expected, double actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two doubles are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(double expected, double actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two doubles are not equal. If they are equal, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(double expected, double actual)
        {
        }

        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotEqual(object expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotEqual(object expected, object actual, string message)
        {
        }

        /// <summary>
        /// Verifies that two objects are not equal.  Two objects are considered
        /// equal if both are null, or if both have the same value. NUnit
        /// has special semantics for some object types.
        /// If they are equal an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreNotEqual(object expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreSame(object expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreSame(object expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that two objects refer to the same object. If they
        /// are not the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        public static void AreSame(object expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void AreNotSame(object expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void AreNotSame(object expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that two objects do not refer to the same object. If they
        /// are the same an <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The actual object</param>
        public static void AreNotSame(object expected, object actual)
        {
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNaN(double aDouble, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNaN(double aDouble, string message)
        {
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        public static void IsNaN(double aDouble)
        {
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNaN(double? aDouble, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNaN(double? aDouble, string message)
        {
        }

        /// <summary>
        /// Verifies that the double that is passed in is an <code>NaN</code> value.
        /// If the object is not <code>NaN</code> then an <see cref="T:NUnit.Framework.AssertionException" />
        /// is thrown.
        /// </summary>
        /// <param name="aDouble">The value that is to be tested</param>
        public static void IsNaN(double? aDouble)
        {
        }

        /// <summary>
        /// Assert that a string is empty - that is equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsEmpty(string aString, string message, params object[] args)
        {
        }

        /// <summary>
        /// Assert that a string is empty - that is equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsEmpty(string aString, string message)
        {
        }

        /// <summary>
        /// Assert that a string is empty - that is equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        public static void IsEmpty(string aString)
        {
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing ICollection</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsEmpty(IEnumerable collection, string message, params object[] args)
        {
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing ICollection</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsEmpty(IEnumerable collection, string message)
        {
        }

        /// <summary>
        /// Assert that an array, list or other collection is empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing ICollection</param>
        public static void IsEmpty(IEnumerable collection)
        {
        }

        /// <summary>
        /// Assert that a string is not empty - that is not equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotEmpty(string aString, string message, params object[] args)
        {
        }

        /// <summary>
        /// Assert that a string is not empty - that is not equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotEmpty(string aString, string message)
        {
        }

        /// <summary>
        /// Assert that a string is not empty - that is not equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        public static void IsNotEmpty(string aString)
        {
        }

        /// <summary>
        /// Assert that an array, list or other collection is not empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing ICollection</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotEmpty(IEnumerable collection, string message, params object[] args)
        {
        }

        /// <summary>
        /// Assert that an array, list or other collection is not empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing ICollection</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotEmpty(IEnumerable collection, string message)
        {
        }

        /// <summary>
        /// Assert that an array, list or other collection is not empty
        /// </summary>
        /// <param name="collection">An array, list or other collection implementing ICollection</param>
        public static void IsNotEmpty(IEnumerable collection)
        {
        }

        /// <summary>
        /// Assert that a string is either null or equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNullOrEmpty(string aString, string message, params object[] args)
        {
        }

        /// <summary>
        /// Assert that a string is either null or equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNullOrEmpty(string aString, string message)
        {
        }

        /// <summary>
        /// Assert that a string is either null or equal to string.Empty
        /// </summary>
        /// <param name="aString">The string to be tested</param>
        public static void IsNullOrEmpty(string aString)
        {
        }

        /// <summary>Assert that a string is not null or empty</summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotNullOrEmpty(string aString, string message, params object[] args)
        {
        }

        /// <summary>Assert that a string is not null or empty</summary>
        /// <param name="aString">The string to be tested</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotNullOrEmpty(string aString, string message)
        {
        }

        /// <summary>Assert that a string is not null or empty</summary>
        /// <param name="aString">The string to be tested</param>
        public static void IsNotNullOrEmpty(string aString)
        {
        }

        /// <summary>
        /// Asserts that an object may be assigned a  value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsAssignableFrom(Type expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object may be assigned a  value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsAssignableFrom(Type expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object may be assigned a  value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        public static void IsAssignableFrom(Type expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that an object may be assigned a  value of a given Type.
        /// </summary>
        /// <typeparam name="T">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsAssignableFrom<T>(object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object may be assigned a  value of a given Type.
        /// </summary>
        /// <typeparam name="T">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsAssignableFrom<T>(object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object may be assigned a  value of a given Type.
        /// </summary>
        /// <typeparam name="T">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        public static void IsAssignableFrom<T>(object actual)
        {
        }

        /// <summary>
        /// Asserts that an object may not be assigned a  value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotAssignableFrom(Type expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object may not be assigned a  value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotAssignableFrom(Type expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object may not be assigned a  value of a given Type.
        /// </summary>
        /// <param name="expected">The expected Type.</param>
        /// <param name="actual">The object under examination</param>
        public static void IsNotAssignableFrom(Type expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that an object may not be assigned a  value of a given Type.
        /// </summary>
        /// <typeparam name="T">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotAssignableFrom<T>(object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object may not be assigned a  value of a given Type.
        /// </summary>
        /// <typeparam name="T">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotAssignableFrom<T>(object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object may not be assigned a  value of a given Type.
        /// </summary>
        /// <typeparam name="T">The expected Type.</typeparam>
        /// <param name="actual">The object under examination</param>
        public static void IsNotAssignableFrom<T>(object actual)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsInstanceOf(Type expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsInstanceOf(Type expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        public static void IsInstanceOf(Type expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [Obsolete]
        public static void IsInstanceOfType(Type expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        [Obsolete]
        public static void IsInstanceOfType(Type expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        [Obsolete]
        public static void IsInstanceOfType(Type expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsInstanceOf<T>(object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsInstanceOf<T>(object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object is an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        public static void IsInstanceOf<T>(object actual)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotInstanceOf(Type expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotInstanceOf(Type expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        public static void IsNotInstanceOf(Type expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [Obsolete]
        public static void IsNotInstanceOfType(Type expected, object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        [Obsolete]
        public static void IsNotInstanceOfType(Type expected, object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <param name="expected">The expected Type</param>
        /// <param name="actual">The object being examined</param>
        [Obsolete]
        public static void IsNotInstanceOfType(Type expected, object actual)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void IsNotInstanceOf<T>(object actual, string message, params object[] args)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void IsNotInstanceOf<T>(object actual, string message)
        {
        }

        /// <summary>
        /// Asserts that an object is not an instance of a given type.
        /// </summary>
        /// <typeparam name="T">The expected Type</typeparam>
        /// <param name="actual">The object being examined</param>
        public static void IsNotInstanceOf<T>(object actual)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(int arg1, int arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Greater(int arg1, int arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(int arg1, int arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void Greater(uint arg1, uint arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void Greater(uint arg1, uint arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        [CLSCompliant(false)]
        public static void Greater(uint arg1, uint arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(long arg1, long arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Greater(long arg1, long arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(long arg1, long arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void Greater(ulong arg1, ulong arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void Greater(ulong arg1, ulong arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        [CLSCompliant(false)]
        public static void Greater(ulong arg1, ulong arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(decimal arg1, decimal arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Greater(decimal arg1, decimal arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(decimal arg1, decimal arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(double arg1, double arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Greater(double arg1, double arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(double arg1, double arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(float arg1, float arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Greater(float arg1, float arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(float arg1, float arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Greater(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Greater(IComparable arg1, IComparable arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void Greater(IComparable arg1, IComparable arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(int arg1, int arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Less(int arg1, int arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(int arg1, int arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void Less(uint arg1, uint arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void Less(uint arg1, uint arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        [CLSCompliant(false)]
        public static void Less(uint arg1, uint arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(long arg1, long arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Less(long arg1, long arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(long arg1, long arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void Less(ulong arg1, ulong arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void Less(ulong arg1, ulong arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        [CLSCompliant(false)]
        public static void Less(ulong arg1, ulong arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(decimal arg1, decimal arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Less(decimal arg1, decimal arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(decimal arg1, decimal arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(double arg1, double arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Less(double arg1, double arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(double arg1, double arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(float arg1, float arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Less(float arg1, float arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(float arg1, float arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Less(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Less(IComparable arg1, IComparable arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void Less(IComparable arg1, IComparable arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(int arg1, int arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void GreaterOrEqual(int arg1, int arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(int arg1, int arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void GreaterOrEqual(uint arg1, uint arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void GreaterOrEqual(uint arg1, uint arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        [CLSCompliant(false)]
        public static void GreaterOrEqual(uint arg1, uint arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(long arg1, long arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void GreaterOrEqual(long arg1, long arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(long arg1, long arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void GreaterOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void GreaterOrEqual(ulong arg1, ulong arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        [CLSCompliant(false)]
        public static void GreaterOrEqual(ulong arg1, ulong arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void GreaterOrEqual(decimal arg1, decimal arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(decimal arg1, decimal arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(double arg1, double arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void GreaterOrEqual(double arg1, double arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(double arg1, double arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(float arg1, float arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void GreaterOrEqual(float arg1, float arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(float arg1, float arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void GreaterOrEqual(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void GreaterOrEqual(IComparable arg1, IComparable arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is greater than or equal tothe second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be greater</param>
        /// <param name="arg2">The second value, expected to be less</param>
        public static void GreaterOrEqual(IComparable arg1, IComparable arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(int arg1, int arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void LessOrEqual(int arg1, int arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(int arg1, int arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void LessOrEqual(uint arg1, uint arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void LessOrEqual(uint arg1, uint arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        [CLSCompliant(false)]
        public static void LessOrEqual(uint arg1, uint arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(long arg1, long arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void LessOrEqual(long arg1, long arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(long arg1, long arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        [CLSCompliant(false)]
        public static void LessOrEqual(ulong arg1, ulong arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        [CLSCompliant(false)]
        public static void LessOrEqual(ulong arg1, ulong arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        [CLSCompliant(false)]
        public static void LessOrEqual(ulong arg1, ulong arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(decimal arg1, decimal arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void LessOrEqual(decimal arg1, decimal arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(decimal arg1, decimal arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(double arg1, double arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void LessOrEqual(double arg1, double arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(double arg1, double arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(float arg1, float arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void LessOrEqual(float arg1, float arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(float arg1, float arg2)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void LessOrEqual(IComparable arg1, IComparable arg2, string message, params object[] args)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void LessOrEqual(IComparable arg1, IComparable arg2, string message)
        {
        }

        /// <summary>
        /// Verifies that the first value is less than or equal to the second
        /// value. If it is not, then an
        /// <see cref="T:NUnit.Framework.AssertionException" /> is thrown.
        /// </summary>
        /// <param name="arg1">The first value, expected to be less</param>
        /// <param name="arg2">The second value, expected to be greater</param>
        public static void LessOrEqual(IComparable arg1, IComparable arg2)
        {
        }

        /// <summary>Asserts that an object is contained in a list.</summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The list to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        public static void Contains(object expected, ICollection actual, string message, params object[] args)
        {
        }

        /// <summary>Asserts that an object is contained in a list.</summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The list to be examined</param>
        /// <param name="message">The message to display in case of failure</param>
        public static void Contains(object expected, ICollection actual, string message)
        {
        }

        /// <summary>Asserts that an object is contained in a list.</summary>
        /// <param name="expected">The expected object</param>
        /// <param name="actual">The list to be examined</param>
        public static void Contains(object expected, ICollection actual)
        {
        }

        /// <summary>
        /// Helper for Assert.AreEqual(double expected, double actual, ...)
        /// allowing code generation to work consistently.
        /// </summary>
        /// <param name="expected">The expected value</param>
        /// <param name="actual">The actual value</param>
        /// <param name="delta">The maximum acceptable difference between the
        /// the expected and the actual</param>
        /// <param name="message">The message to display in case of failure</param>
        /// <param name="args">Array of objects to be used in formatting the message</param>
        protected static void AssertDoublesAreEqual(double expected, double actual, double delta, string message, object[] args)
        {
        }
    }
}
}