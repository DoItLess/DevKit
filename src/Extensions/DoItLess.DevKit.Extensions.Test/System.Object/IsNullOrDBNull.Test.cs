using System;
using System.Collections;
using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace DoItLess.DevKit.Extensions.Test.System.Object
{
    public class IsNullOrDBNullTest
    {
        #region 执行测试

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(object obj)
        {
            return obj.IsNullOrDbNull();
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
                    yield return new TestCaseData(DBNull.Value).Returns(true);
                    yield return new TestCaseData("ddddd").Returns(false);
                }
            }
        }

        #endregion
    }
}