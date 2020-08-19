using System.Collections.Generic;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Collections.Generic.IEnumerable
{
    public class DistinctTest
    {
        [Test]
        [Ignore("skip")]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(IEnumerable<string> input, IEnumerable<string> items)
        {
            return input.ContainsAll(items);
        }


        private class TestCase
        {
            public static IEnumerable<TestCaseData> Case1
            {
                get { yield return new TestCaseData(new List<string> {"dd", "ddd"}, new[] {"aaa"}).Returns(false); }
            }
        }
    }
}