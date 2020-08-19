using System.Collections;
using System.Globalization;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.String
{
    public class IsEmptyTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(string input)
        {
            return input.IsEmpty();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("\r").Returns(false);
                    yield return new TestCaseData("").Returns(true);
                    yield return new TestCaseData("⁣⁣⁣⁣　").Returns(false);
                    yield return new TestCaseData(UnicodeToString("0D15"))
                                 .SetArgDisplayNames("unicode: 0D15")
                                 .Returns(false);
                    yield return new TestCaseData(UnicodeToString("1D161"))
                                 .SetArgDisplayNames("unicode: 1D161")
                                 .Returns(false);
                    yield return new TestCaseData(UnicodeToString("00AD"))
                                 .SetArgDisplayNames("unicode: 00AD https://unicode-table.com/cn/00AD/")
                                 .Returns(false);
                    yield return new TestCaseData(UnicodeToString("00A0"))
                                 .SetArgDisplayNames("unicode: 00A0 https://unicode-table.com/cn/00A0/")
                                 .Returns(false);
                }
            }

            private static string UnicodeToString(string code)
            {
                return char.ConvertFromUtf32(int.Parse(code, NumberStyles.HexNumber));
            }
        }
    }
}