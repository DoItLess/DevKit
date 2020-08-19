using System.Collections;
using System.Reflection;
using NUnit.Framework;

#pragma warning disable 414

namespace DoItLess.DotNet.Extensions.Test.System.Type
{
    public class HasFieldTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(global::System.Type type, string fieldName)
        {
            return type.HasField(fieldName);
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.TestCase2))]
        public bool Test2(global::System.Type type, string fieldName, BindingFlags bindingFlags)
        {
            return type.HasField(fieldName, bindingFlags);
        }

        private class MyClass
        {
            public    string PublicField    = "";
            protected string ProtectedField = "";
        }

        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(typeof(MyClass), "PublicField").Returns(true);
                    yield return new TestCaseData(typeof(MyClass), "ProtectedField").Returns(false);
                }
            }

            public static IEnumerable TestCase2
            {
                get
                {
                    yield return new TestCaseData(typeof(MyClass), "ProtectedField", BindingFlags.NonPublic | BindingFlags.Instance)
                        .Returns(true);
                }
            }
        }
    }
}