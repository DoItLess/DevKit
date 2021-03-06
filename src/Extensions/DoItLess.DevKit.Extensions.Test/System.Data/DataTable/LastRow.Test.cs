﻿using System.Collections.Generic;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.Data.DataTable
{
    public class LastRowTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public bool Test1(global::System.Data.DataTable obj)
        {
            return obj.LastRow() == null;
        }

        private class TestCase
        {
            private static readonly global::System.Data.DataTable TestTable1 = InitTestTable1();
            private static readonly global::System.Data.DataTable TestTable2 = InitTestTable2();


            private static global::System.Data.DataTable InitTestTable1()
            {
                var rs = new global::System.Data.DataTable();
                rs.Columns.Add("FRowId", typeof(string));
                rs.Columns.Add("FName", typeof(string));
                10.RepeatTimes(i => rs.Rows.Add($"RowId_{i}", $"Name_{i}"));
                return rs;
            }

            private static global::System.Data.DataTable InitTestTable2()
            {
                var rs = new global::System.Data.DataTable();
                rs.Columns.Add("FRowId", typeof(string));
                rs.Columns.Add("FName", typeof(string));
                return rs;
            }

            public static IEnumerable<TestCaseData> Case1
            {
                get
                {
                    yield return new TestCaseData(TestTable1).Returns(false);
                    yield return new TestCaseData(TestTable2).Returns(true);
                }
            }
        }
    }
}