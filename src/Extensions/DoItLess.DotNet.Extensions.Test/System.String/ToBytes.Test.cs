using System.Collections;
using System.Text;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.String
{
    public class ToBytesTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public byte[] Test1(string input)
        {
            return input.ToBytes();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get { yield return new TestCaseData("abc").Returns(Encoding.UTF8.GetBytes("abc")); }
            }
        }
    }
}