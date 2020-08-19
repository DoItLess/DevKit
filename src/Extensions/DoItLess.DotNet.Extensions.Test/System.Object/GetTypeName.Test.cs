using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Object
{
    public class GetTypeNameTest
    {
        #region 执行测试

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public string Test1(object obj)
        {
            return obj.GetTypeName();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.WithDefaultTypeNameCase2))]
        public string WithDefault_Test2(object obj, string defaultTypeName)
        {
            return obj.GetTypeName(defaultTypeName);
        }

        #endregion


        #region 测试用例

        private class TestCase
        {
            public static IEnumerable WithDefaultTypeNameCase2
            {
                get
                {
                    yield return new TestCaseData("abc", "ddddd").Returns("String");
                    yield return new TestCaseData(null, "defaultTypeName").Returns("defaultTypeName");
                }
            }

            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("abc").Returns("String");
                    yield return new TestCaseData(null).Returns(string.Empty);
                }
            }
        }

        #endregion
    }
}