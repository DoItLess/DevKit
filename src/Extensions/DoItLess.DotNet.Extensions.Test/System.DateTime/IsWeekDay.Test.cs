using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.DateTime
{
    public class IsWeekDayTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(global::System.DateTime input)
        {
            return input.IsWeekDay();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(new global::System.DateTime(2019, 5, 1)).Returns(true);
                    yield return new TestCaseData(new global::System.DateTime(2019, 6, 1)).Returns(false);
                }
            }
        }
    }
}