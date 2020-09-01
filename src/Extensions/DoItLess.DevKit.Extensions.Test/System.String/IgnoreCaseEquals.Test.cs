using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.String
{
    public class IgnoreCaseEqualsTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(string input, string expected) => input.IgnoreCaseEquals(expected);

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test2(string input, string expected) => input.XEquals(expected);


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("abcd", "Abcd").Returns(true);
                    yield return new TestCaseData("ABCd", "abcd").Returns(true);
                }
            }
        }
    }
}