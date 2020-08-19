using System.Collections.Generic;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Collections.Generic.IEnumerable
{
    public class ForEachTest
    {
        [Test]
        public void Test1()
        {
            var arr = new[] {"aa", "bb"};
            var rs  = new Dictionary<int, string>();
            arr.ForEach((index, str) => { rs.Add(index, str); });
            Assert.AreEqual(rs[0], arr[0]);
            Assert.AreEqual(rs[1], arr[1]);
        }

        [Test]
        public void Test2()
        {
            var arr = new[] {"aa", "bb"};
            var rs  = new List<string>();
            arr.ForEach(s => rs.Add(s));
            Assert.AreEqual(rs[0], arr[0]);
            Assert.AreEqual(rs[1], arr[1]);
        }
    }
}