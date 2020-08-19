using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Array
{
    public class ReverseTest
    {
        [Test]
        public void Test1()
        {
            var input = new[] {"a", "B"};
            input.Reverse();
            Assert.AreEqual(input[0], "B");
        }
    }
}