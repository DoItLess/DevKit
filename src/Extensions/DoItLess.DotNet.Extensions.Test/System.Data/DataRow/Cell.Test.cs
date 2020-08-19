using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace DoItLess.DotNet.Extensions.Test.System.Data.DataRow
{
    public class CellTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public string Test1(global::System.Data.DataRow row, string columnName)
        {
            return row.Cell<string>(columnName);
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case2))]
        public string Test2(global::System.Data.DataRow row, string columnName, string defaultValue)
        {
            return row.Cell(columnName, defaultValue);
        }

        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case3))]
        public string Test3(global::System.Data.DataRow row, string columnName, Func<string> func)
        {
            return row.Cell(columnName, func);
        }

        private class TestCase
        {
            private static readonly global::System.Data.DataTable TestTable1 = InitTestTable1();


            private static global::System.Data.DataTable InitTestTable1()
            {
                var rs = new global::System.Data.DataTable();
                rs.Columns.Add("FRowId", typeof(string));
                rs.Columns.Add("FName", typeof(string));
                10.RepeatTimes(i => rs.Rows.Add($"RowId_{i}", $"Name_{i}"));
                return rs;
            }

            public static IEnumerable<TestCaseData> Case1
            {
                get
                {
                    yield return new TestCaseData(TestTable1.FirstRow(), "FName").Returns("Name_0");
                    yield return new TestCaseData(TestTable1.FirstRow(), "NotExistColumn").Returns(default(string));
                }
            }

            public static IEnumerable<TestCaseData> Case2
            {
                get
                {
                    yield return new TestCaseData(TestTable1.FirstRow(), "NotExistColumn", "default").Returns("default");
                    yield return new TestCaseData(TestTable1.FirstRow(), "NotExistColumn", "ddddd").Returns("ddddd");
                }
            }

            public static IEnumerable<TestCaseData> Case3
            {
                get
                {
                    Func<string> defaultFunc = () => "default";
                    yield return new TestCaseData(TestTable1.FirstRow(), "NotExistColumn", defaultFunc).Returns("default");
                }
            }
        }
    }
}