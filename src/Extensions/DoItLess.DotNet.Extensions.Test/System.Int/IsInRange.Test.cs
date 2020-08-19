using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Int
{
    public class IsInRangeTest
    {
        #region 执行

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Int))]
        public bool Int_Test(int input, int min, int max)
        {
            return input.IsInRange(min, max);
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Long))]
        public bool Long_Test(long input, long min, long max)
        {
            return input.IsInRange(min, max);
        }

        #endregion

        #region 用例

        private class TestCase
        {
            public static IEnumerable Int
            {
                get
                {
                    yield return new TestCaseData(0, -3, 2).Returns(true);
                    yield return new TestCaseData(1, 2, 3).Returns(false);
                    yield return new TestCaseData(-1, -1, 10).Returns(true);
                }
            }

            public static IEnumerable Long
            {
                get
                {
                    yield return new TestCaseData(0L, -3L, 2L).Returns(true);
                    yield return new TestCaseData(1L, 2L, 3L).Returns(false);
                    yield return new TestCaseData(-1L, -1L, 10).Returns(true);
                }
            }
        }

        #endregion
    }
}