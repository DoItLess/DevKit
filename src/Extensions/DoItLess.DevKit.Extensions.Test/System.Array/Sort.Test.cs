using System;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Array
{
    public class SortTest
    {
        [Test]
        public void Test1()
        {
            var input = new[] {"a", "B", "0"};
            input.Sort();
            Assert.AreEqual(input[0], "0");
        }

        [Test]
        public void Test2()
        {
            var input = new[] {"C", "a", "A", "B"};
            input.Sort(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(input[0], "a");
        }

        [Test]
        public void Test3()
        {
            var input = new[] {"C", "A", "a", "B"};
            input.Sort(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(input[0], "A");
        }
    }
}