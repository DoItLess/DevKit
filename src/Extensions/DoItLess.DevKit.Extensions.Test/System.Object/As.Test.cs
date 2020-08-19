using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Object
{
    public class AsTest
    {
        #region 测试执行

        [Test]
        [Ignore("没想好怎么测")]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(SubClass sourceObj)
        {
            var baseClass = sourceObj.As<BaseClass>();
            return Assert.Equals(baseClass.Name, sourceObj.Name);
        }

        #endregion

        #region 用例

        public class BaseClass
        {
            public string Name { get; set; }
        }

        public class SubClass : BaseClass
        {
            public string SubName { get; set; }
        }

        private class TestCase
        {
            /// <summary>
            ///     BaseClass To SubClass 用例
            /// </summary>
            public static IEnumerable Case1
            {
                get { yield return new TestCaseData(new BaseClass() {Name = "abc"}).Returns(true); }
            }
        }

        #endregion
    }
}