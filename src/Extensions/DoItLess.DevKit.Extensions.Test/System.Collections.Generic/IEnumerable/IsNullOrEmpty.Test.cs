using System.Collections.Generic;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Collections.Generic.IEnumerable
{
    public class IsNullOrEmptyTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(List<string> input)
        {
            return input.IsNullOrEmpty();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case2))]
        public bool Test2(string[] input)
        {
            return input.IsNullOrEmpty();
        }

        private class TestCase
        {
            public static IEnumerable<TestCaseData> Case1
            {
                get
                {
                    yield return new TestCaseData(new List<string> {"dd"}).Returns(false);
                    yield return new TestCaseData(new List<string>()).Returns(true);
                }
            }

            public static IEnumerable<TestCaseData> Case2
            {
                get { yield return new TestCaseData(null).Returns(true); }
            }
        }
    }
}