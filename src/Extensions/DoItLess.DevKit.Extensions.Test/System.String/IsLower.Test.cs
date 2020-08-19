using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.String
{
    public class IsLowerTestTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(string input)
        {
            return input.IsLower();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("abcd").Returns(true);
                    yield return new TestCaseData("ABCd").Returns(false);
                }
            }
        }
    }
}