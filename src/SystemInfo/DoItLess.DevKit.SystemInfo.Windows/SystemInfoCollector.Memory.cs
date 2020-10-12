using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Management;
using DoItLess.DevKit.Extensions;

namespace DoItLess.DevKit.SystemInfo.Windows
{
    /// <summary>
    ///     系统信息收集器
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class SystemInfoCollector
    {
        /// <summary>
        ///     获取OS信息
        /// </summary>
        /// <returns>
        ///     查询失败返回 null
        /// </returns>
        public static List<Memory> GetMemoryList()
        {
            var mos = new ManagementObjectSearcher(Utils.WQL_Memory).Get();
            if (mos.IsNull() || mos.Count < 1) return null;
            return mos.Cast<ManagementObject>()
                      .Where(mo => !mo.IsNull())
                      .Select(mo => new Memory
                      {
                          Capacity             = Utils.GetMoValue<ulong>(mo, "Capacity"),
                          Caption              = Utils.GetMoValue<string>(mo, "Caption"),
                          ConfiguredClockSpeed = Utils.GetMoValue<uint>(mo, "ConfiguredClockSpeed"),
                          Description          = Utils.GetMoValue<string>(mo, "Description"),
                          Manufacturer         = Utils.GetMoValue<string>(mo, "Manufacturer"),
                          MemoryType           = GetMemoryType(Utils.GetMoValue<ushort>(mo, "MemoryType")),
                          Model                = Utils.GetMoValue<string>(mo, "Model"),
                          Name                 = Utils.GetMoValue<string>(mo, "Name"),
                          PartNumber           = Utils.GetMoValue<string>(mo, "PartNumber"),
                          SerialNumber         = Utils.GetMoValue<string>(mo, "SerialNumber"),
                          Speed                = Utils.GetMoValue<uint>(mo, "Speed"),
                      }).ToList();
        }

        private static MemoryType GetMemoryType(ushort type)
        {
            return !Enum.TryParse(type.ToString(), out MemoryType o) ? MemoryType.Unknown : o;
        }
    }
}