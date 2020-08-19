using System;
using NUnit.Framework;

namespace DoItLess.DotNet.DeviceId.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var rs1 = DeviceIdBuilder.Default
                                     .WithMachineName()
                                     .ToString();
            var rs2 = DeviceIdBuilder.Default
                                     .WithMachineName()
                                     .ToString();

            Assert.AreEqual(rs1, rs2, "使用同一机器同用参数生成的设备ID不一致");
            Console.WriteLine(rs1);
        }

        [Test]
        public void Test2()
        {
            var rs1 = DeviceIdBuilder.Default
                                     .WithMachineName()
                                     .WithCurrentUserName()
                                     .ToString();
            var rs2 = DeviceIdBuilder.Default
                                     .WithMachineName()
                                     .WithCurrentUserName()
                                     .ToString();

            Assert.AreEqual(rs1, rs2, "使用同一机器同用参数生成的设备ID不一致");
            Console.WriteLine(rs1);
        }
    }
}