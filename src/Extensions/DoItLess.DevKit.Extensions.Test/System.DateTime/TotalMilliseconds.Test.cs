using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.DateTime
{
    public class TotalMillisecondsTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public double Test1(global::System.DateTime input)
        {
            return input.TotalMilliseconds();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(new global::System.DateTime(2019, 4, 1, 11, 11, 11))
                       .Returns(1554117071000);
                }
            }
        }
    }
}