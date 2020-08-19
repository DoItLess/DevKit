using System.Collections;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Object
{
    public class PipeTest
    {
        #region 测试执行

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public string Test1(string obj)
        {
            return obj.Pipe(s => s + "_pipe1")
                      .Pipe(s => s + "_pipe2");
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case2))]
        public string Test2(MyClass obj)
        {
            obj.Pipe(o =>
               {
                   o.Name += "_pipe1";
                   return o;
               })
               .Pipe(o =>
               {
                   o.Name += "_pipe2";
                   return o;
               });

            return obj.Name;
        }

        #endregion

        #region 用例

        public class MyClass
        {
            public string Name { get; set; }
        }

        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("a").Returns("a_pipe1_pipe2");
                    yield return new TestCaseData("b").Returns("b_pipe1_pipe2");
                }
            }

            public static IEnumerable Case2
            {
                get { yield return new TestCaseData(new MyClass {Name = "c"}).Returns("c_pipe1_pipe2"); }
            }
        }

        #endregion
    }
}