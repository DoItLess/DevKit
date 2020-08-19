using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Int
{
    public class IsOddTest
    {
        #region 执行

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Int))]
        public bool Int_Test(int input)
        {
            return input.IsOdd();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Long))]
        public bool Long_Test(long input)
        {
            return input.IsOdd();
        }

        #endregion

        #region 用例

        private class TestCase
        {
            public static IEnumerable Int
            {
                get
                {
                    yield return new TestCaseData(0).Returns(false);
                    yield return new TestCaseData(1).Returns(true);
                    yield return new TestCaseData(-1).Returns(true);
                }
            }

            public static IEnumerable Long
            {
                get
                {
                    yield return new TestCaseData(0L).Returns(false);
                    yield return new TestCaseData(1L).Returns(true);
                    yield return new TestCaseData(-1L).Returns(true);
                }
            }
        }

        #endregion
    }
}