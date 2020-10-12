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
        ///     获取主板信息
        /// </summary>
        /// <returns>
        ///     查询失败返回 null
        /// </returns>
        public static List<Motherboard> GetMotherboardList()
        {
            var mos = new ManagementObjectSearcher(Utils.WQL_Motherboard).Get();
            if (mos.IsNull() || mos.Count < 1) return null;
            return mos.Cast<ManagementObject>()
                      .Where(mo => !mo.IsNull())
                      .Select(mo => new Motherboard
                      {
                          Caption      = Utils.GetMoValue<string>(mo, "Caption"),
                          Description  = Utils.GetMoValue<string>(mo, "Description"),
                          Manufacturer = Utils.GetMoValue<string>(mo, "Manufacturer"),
                          Model        = Utils.GetMoValue<string>(mo, "Model"),
                          Name         = Utils.GetMoValue<string>(mo, "Name"),
                          PartNumber   = Utils.GetMoValue<string>(mo, "PartNumber"),
                          Product      = Utils.GetMoValue<string>(mo, "Product"),
                          Removable    = Utils.GetMoValue<bool>(mo, "Removable"),
                          Replaceable  = Utils.GetMoValue<bool>(mo, "Replaceable"),
                          SerialNumber = Utils.GetMoValue<string>(mo, "SerialNumber")
                      }).ToList();
        }
    }
}