using System;
using System.Collections;
using System.Data;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Object
{
    public class DeepCloneTest
    {
        #region 执行测试

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public void Test1(MyClass obj)
        {
            var clone = obj.DeepClone();
            Assert.AreEqual(clone.Name, obj.Name);
            Assert.AreNotEqual(clone, obj);
            Assert.AreNotEqual(clone.GetHashCode(), obj.GetHashCode());
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case2))]
        public void Test2(object obj)
        {
            var clone = obj.DeepClone();
            Assert.AreNotEqual(clone, obj);
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case3))]
        public void Test3(NoSerializableClass obj)
        {
            Assert.Throws<ArgumentException>(() => obj.DeepClone());
        }

        #endregion


        #region 测试用例

        [Serializable]
        public class MyClass
        {
            public string Name { get; set; }
        }

        public class NoSerializableClass
        {
            public string Name { get; set; }
        }

        private class TestCase
        {
            public static IEnumerable Case1
            {
                get { yield return new TestCaseData(new MyClass {Name = "a"}); }
            }

            public static IEnumerable Case2
            {
                get { yield return new TestCaseData(new DataTable()); }
            }

            public static IEnumerable Case3
            {
                get { yield return new TestCaseData(new NoSerializableClass {Name = "d"}); }
            }
        }

        #endregion
    }
}