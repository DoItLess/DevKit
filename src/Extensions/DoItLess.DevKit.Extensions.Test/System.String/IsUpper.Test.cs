using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.String
{
    public class StringIsUpperTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(string input)
        {
            return input.IsUpper();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("abcd").Returns(false);
                    yield return new TestCaseData("ABCD").Returns(true);
                }
            }
        }
    }
}