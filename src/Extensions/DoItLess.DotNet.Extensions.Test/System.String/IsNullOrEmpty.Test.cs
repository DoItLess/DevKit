using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.String
{
    public class IsNullOrEmptyTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(string input)
        {
            return input.IsNullOrEmpty();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(" ").Returns(false);
                    yield return new TestCaseData("").Returns(true);
                    yield return new TestCaseData(string.Empty).Returns(true);
                }
            }
        }
    }
}