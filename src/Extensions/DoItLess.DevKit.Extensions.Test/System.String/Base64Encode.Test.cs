using System.Collections;
using System.Text;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.String
{
    public class Base64EncodeTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public string Test1(string input, Encoding encoding)
        {
            return input.Base64Encode(encoding);
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData("ABCD", Encoding.UTF8).Returns("QUJDRA==");
                    yield return new TestCaseData("ABCD", Encoding.Unicode).Returns("QQBCAEMARAA=");
                }
            }
        }
    }
}