using System;
using System.Collections;
using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace DoItLess.DevKit.Extensions.Test.System.Object
{
    public class IsDBNullTest
    {
        #region 执行测试

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(object obj)
        {
            return obj.IsDBNull();
        }

        #endregion


        #region 测试用例

        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(null).Returns(false);
                    yield return new TestCaseData("ddddd").Returns(false);
                    yield return new TestCaseData(DBNull.Value).Returns(true);
                }
            }
        }

        #endregion
    }
}