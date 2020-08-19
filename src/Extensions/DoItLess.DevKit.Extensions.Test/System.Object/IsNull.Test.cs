using System;
using System.Collections;
using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace DoItLess.DevKit.Extensions.Test.System.Object
{
    public class IsNullTest
    {
        #region 执行测试

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test(object obj)
        {
            return obj.IsNull();
        }

        #endregion


        #region 测试用例

        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(null).Returns(true);
                    yield return new TestCaseData("dddd").Returns(false);
                    yield return new TestCaseData(DBNull.Value).Returns(false);
                }
            }
        }

        #endregion
    }
}