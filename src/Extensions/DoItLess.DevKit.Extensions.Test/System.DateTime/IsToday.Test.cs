using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.DateTime
{
    public class IsTodayTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(global::System.DateTime input)
        {
            return input.IsToday();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(global::System.DateTime.Today).Returns(true);
                    yield return new TestCaseData(new global::System.DateTime()).Returns(false);
                    yield return new TestCaseData(new global::System.DateTime(2019, 4, 1)).Returns(false);
                }
            }
        }
    }
}