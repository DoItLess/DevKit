using System.Collections;
using System.Data;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Type
{
    public class TypeHasProperty
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(global::System.Type type, string propertyName)
        {
            return type.HasProperty(propertyName);
        }

        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(typeof(DataTable), "Rows").Returns(true); 
                    yield return new TestCaseData(typeof(DataTable), "rows").Returns(true);
                }
            }
        }
    }
}
