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
        ///     获取Cpu信息
        /// </summary>
        /// <returns></returns>
        public static List<CpuCls> GetCpuInfo()
        {
            T GetMoValue<T>(ManagementObject mo, string property)
            {
                try
                {
                    var obj = mo[property];
                    return !obj.IsNull() ? (T) obj : default;
                }
                catch
                {
                    return default;
                }
            }

            using var mos = new ManagementObjectSearcher("SELECT * FROM Win32_Processor").Get();
            if (mos.IsNull() || mos.Count < 1) return null;
            return mos.Cast<ManagementObject>()
                      .Where(mo => !mo.IsNull())
                      .Select(mo => new CpuCls
                      {
                          Name                          = GetMoValue<string>(mo, nameof(CpuCls.Name)),
                          Caption                       = GetMoValue<string>(mo, nameof(CpuCls.Caption)),
                          Description                   = GetMoValue<string>(mo, nameof(CpuCls.Description)),
                          DeviceID                      = GetMoValue<string>(mo, nameof(CpuCls.DeviceID)),
                          NumberOfCores                 = GetMoValue<uint>(mo, nameof(CpuCls.NumberOfCores)),
                          NumberOfLogicalProcessors     = GetMoValue<uint>(mo, nameof(CpuCls.NumberOfLogicalProcessors)),
                          ThreadCount                   = GetMoValue<uint>(mo, nameof(CpuCls.ThreadCount)),
                          Manufacturer                  = GetMoValue<string>(mo, nameof(CpuCls.Manufacturer)),
                          MaxClockSpeed                 = GetMoValue<uint>(mo, nameof(CpuCls.MaxClockSpeed)),
                          VirtualizationFirmwareEnabled = GetMoValue<bool>(mo, nameof(CpuCls.VirtualizationFirmwareEnabled)),
                          L2CacheSize                   = GetMoValue<uint>(mo, nameof(CpuCls.L2CacheSize)),
                          L3CacheSize                   = GetMoValue<uint>(mo, nameof(CpuCls.L3CacheSize))
                      }).ToList();
        }
    }
}