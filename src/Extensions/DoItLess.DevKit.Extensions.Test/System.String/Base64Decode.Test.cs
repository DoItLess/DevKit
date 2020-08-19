using System.Collections;
using System.Text;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.String
{
    public class Base64DecodeTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public string Test1(string input, Encoding encoding)
        {
            return input.Base64Decode(encoding);
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("QUJDRA==", Encoding.UTF8).Returns("ABCD");
                    yield return new TestCaseData("QQBCAEMARAA=", Encoding.Unicode).Returns("ABCD");
                }
            }
        }
    }
}