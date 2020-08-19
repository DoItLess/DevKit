using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Int
{
    public class IsEvenTest
    {
        #region 执行

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Int))]
        public bool Int_Test(int input)
        {
            return input.IsEven();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Long))]
        public bool Long_Test(long input)
        {
            return input.IsEven();
        }

        #endregion

        #region 用例

        private class TestCase
        {
            public static IEnumerable Int
            {
                get
                {
                    yield return new TestCaseData(0).Returns(true);
                    yield return new TestCaseData(1).Returns(false);
                    yield return new TestCaseData(-1).Returns(false);
                }
            }

            public static IEnumerable Long
            {
                get
                {
                    yield return new TestCaseData(0L).Returns(true);
                    yield return new TestCaseData(1L).Returns(false);
                    yield return new TestCaseData(-1L).Returns(false);
                }
            }
        }

        #endregion
    }
}