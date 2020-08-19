using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.DateTime
{
    public class IsBetweenTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(global::System.DateTime input, global::System.DateTime start, global::System.DateTime end)
        {
            return input.IsBetween(start, end);
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(new global::System.DateTime(2019, 4, 1),
                                                  new global::System.DateTime(2019, 4, 1, 0, 0, 1),
                                                  new global::System.DateTime(2019, 5, 1))
                       .Returns(false);
                    yield return new TestCaseData(new global::System.DateTime(2019, 4, 1),
                                                  new global::System.DateTime(2019, 3, 1, 0, 0, 1),
                                                  new global::System.DateTime(2019, 5, 1))
                       .Returns(true);
                }
            }
        }
    }
}