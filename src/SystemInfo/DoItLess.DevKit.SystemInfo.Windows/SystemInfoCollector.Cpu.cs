using System.Collections.Generic;
using System.Linq;
using System.Management;
using DoItLess.DevKit.Extensions;

namespace DoItLess.DevKit.SystemInfo.Windows
{
    /// <summary>
    ///     系统信息收集器
    /// </summary>
    public static partial class SystemInfoCollector
    {
        /// <summary>
        ///     获取Cpu清单
        /// </summary>
        /// <returns>
        ///     查询失败返回 null
        /// </returns>
        public static List<CPU> GetCpuList()
        {
            using var mos = new ManagementObjectSearcher(Utils.WQL_CPU).Get();
            if (mos.IsNull() || mos.Count < 1) return null;
            return mos.Cast<ManagementObject>()
                      .Where(mo => !mo.IsNull())
                      .Select(mo => new CPU
                      {
                          Name                          = Utils.GetMoValue<string>(mo, "Name"),
                          Caption                       = Utils.GetMoValue<string>(mo, "Caption"),
                          Description                   = Utils.GetMoValue<string>(mo, "Description"),
                          DeviceID                      = Utils.GetMoValue<string>(mo, "DeviceID"),
                          NumberOfCores                 = Utils.GetMoValue<uint>(mo, "NumberOfCores"),
                          NumberOfLogicalProcessors     = Utils.GetMoValue<uint>(mo, "NumberOfLogicalProcessors"),
                          ThreadCount                   = Utils.GetMoValue<uint>(mo, "ThreadCount"),
                          Manufacturer                  = Utils.GetMoValue<string>(mo, "Manufacturer"),
                          MaxClockSpeed                 = Utils.GetMoValue<uint>(mo, "MaxClockSpeed"),
                          VirtualizationFirmwareEnabled = Utils.GetMoValue<bool>(mo, "VirtualizationFirmwareEnabled"),
                          L2CacheSize                   = Utils.GetMoValue<uint>(mo, "L2CacheSize"),
                          L3CacheSize                   = Utils.GetMoValue<uint>(mo, "L3CacheSize")
                      }).ToList();
        }
    }
}