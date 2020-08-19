using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Int
{
    public class RepeatTimesTest
    {
        #region 执行

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Int))]
        public int Int_Test(int input)
        {
            var rs = 0;
            input.RepeatTimes(i => rs += i);
            return rs;
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Long))]
        public long Long_Test(long input)
        {
            var rs = 0L;
            input.RepeatTimes(l => rs += l);
            return rs;
        }

        #endregion

        #region 用例

        private class TestCase
        {
            public static IEnumerable Int
            {
                get { yield return new TestCaseData(10).Returns(45); }
            }

            public static IEnumerable Long
            {
                get { yield return new TestCaseData(10L).Returns(45L); }
            }
        }

        #endregion
    }
}