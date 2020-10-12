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
        public static List<BIOS> GetBIOSList()
        {
            var mos = new ManagementObjectSearcher(Utils.WQL_BIOS).Get();
            if (mos.IsNull() || mos.Count < 1) return null;
            return mos.Cast<ManagementObject>()
                      .Where(mo => !mo.IsNull())
                      .Select(mo => new BIOS
                      {
                          Caption         = Utils.GetMoValue<string>(mo, "Caption"),
                          CurrentLanguage = Utils.GetMoValue<string>(mo, "CurrentLanguage"),
                          Description     = Utils.GetMoValue<string>(mo, "Description"),
                          Manufacturer    = Utils.GetMoValue<string>(mo, "Manufacturer"),
                          Name            = Utils.GetMoValue<string>(mo, "Name"),
                          PrimaryBIOS     = Utils.GetMoValue<bool>(mo, "PrimaryBIOS"),
                          ReleaseDate     = ManagementDateTimeConverter.ToDateTime(Utils.GetMoValue<string>(mo, "ReleaseDate")),
                          SerialNumber    = Utils.GetMoValue<string>(mo, "SerialNumber"),
                          Version         = Utils.GetMoValue<string>(mo, "Version"),
                      }).ToList();
        }
    }
}