using System;
using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Object
{
    public class ObjectToTest
    {
        #region 测试执行

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.IntToString))]
        public string To_Int_To_String_Test(int sourceObj)
        {
            return sourceObj.To<string>();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.LongToString))]
        public string To_Long_To_String_Test(long sourceObj)
        {
            return sourceObj.To<string>();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.StringToDateTime))]
        public global::System.DateTime To_String_To_DateTime(string sourceObj)
        {
            return sourceObj.To<global::System.DateTime>();
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.StringToIntWithDefaultValue))]
        public int To_String_To_Int_With_DefaultValue_Test(string sourceObj, int defaultValue)
        {
            return sourceObj.To(defaultValue);
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.StringToIntWithFunc))]
        public int To_String_To_Int_With_Func_Test(string sourceObj, Func<int> func)
        {
            return sourceObj.To(func);
        }

        #endregion

        #region 用例

        private class TestCase
        {
            public static IEnumerable StringToIntWithFunc
            {
                get
                {
                    Func<int> func1 = () => 1;
                    yield return new TestCaseData("aaa", func1).Returns(func1.Invoke());
                }
            }

            public static IEnumerable StringToIntWithDefaultValue
            {
                get { yield return new TestCaseData("aaaa", 3).Returns(3); }
            }

            public static IEnumerable IntToString
            {
                get
                {
                    yield return new TestCaseData(11).Returns("11");
                    yield return new TestCaseData(int.MaxValue).Returns("2147483647");
                    yield return new TestCaseData(int.MinValue).Returns("-2147483648");
                    yield return new TestCaseData(11).Returns("11");
                }
            }

            public static IEnumerable LongToString
            {
                get
                {
                    yield return new TestCaseData(22123123L).Returns("22123123");
                    yield return new TestCaseData(long.MaxValue).Returns("9223372036854775807");
                    yield return new TestCaseData(long.MinValue).Returns("-9223372036854775808");
                }
            }

            public static IEnumerable StringToDateTime
            {
                get
                {
                    yield return new TestCaseData("2018-01-01 23:59:59").Returns(new global::System.DateTime(2018, 1, 1, 23, 59, 59));
                    yield return new TestCaseData("9999-12-31 23:59:59.9999999").Returns(global::System.DateTime.MaxValue);
                    yield return new TestCaseData("0001-01-01 00:00:00.0000000").Returns(global::System.DateTime.MinValue);
                }
            }
        }

        #endregion
    }
}