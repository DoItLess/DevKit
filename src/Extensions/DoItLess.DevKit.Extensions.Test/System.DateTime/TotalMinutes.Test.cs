﻿using System.Collections;
using NUnit.Framework;

namespace DoItLess.DevKit.Extensions.Test.System.DateTime
{
    public class TotalMinutesTest
    {
        [Test]
        [TestCaseSource(typeof(TestCase), nameof(TestCase.Case1))]
        public double Test1(global::System.DateTime input)
        {
            return input.TotalMinutes();
        }


        private class TestCase
        {
            public static IEnumerable Case1
            {
                get
                {
                    yield return new TestCaseData(new global::System.DateTime(2019, 4, 1, 11, 11, 11))
                       .Returns(25901951.183333334);
                }
            }
        }
    }
}