using System;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using DoItLess.DevKit.Extensions;

namespace DoItLess.DevKit.SystemInfo.Windows
{
    /// <summary>
    ///     系统信息收集器
    /// </summary>
    public static partial class SystemInfoCollector
    {
        /// <summary>
        ///     获取OS信息
        /// </summary>
        /// <returns>
        ///     查询失败返回 null
        /// </returns>
        public static OSCls GetOSInfo()
        {
            using var mos = new ManagementObjectSearcher(Utils.WQL_OS).Get();
            if (mos.IsNull() || mos.Count < 1) return null;
            var mo = mos.Cast<ManagementObject>().FirstOrDefault();

            return new OSCls
            {
                BuildNumber           = Utils.GetMoValue<string>(mo, "BuildNumber"),
                Caption               = Utils.GetMoValue<string>(mo, "Caption"),
                CSDVersion            = Utils.GetMoValue<string>(mo, "CSDVersion"),
                CSName                = Utils.GetMoValue<string>(mo, "CSName"),
                CurrentTimeZone       = Utils.GetMoValue<short>(mo, "CurrentTimeZone"),
                WMIDescription        = Utils.GetMoValue<string>(mo, "Description"),
                InstallDate           = ManagementDateTimeConverter.ToDateTime(Utils.GetMoValue<string>(mo, "InstallDate")),
                LastBootUpTime        = ManagementDateTimeConverter.ToDateTime(Utils.GetMoValue<string>(mo, "LastBootUpTime")),
                Manufacturer          = Utils.GetMoValue<string>(mo, "Manufacturer"),
                Name                  = Utils.GetMoValue<string>(mo, "Name"),
                NumberOfLicensedUsers = Utils.GetMoValue<uint>(mo, "NumberOfLicensedUsers"),
                OSArchitecture        = RuntimeInformation.OSArchitecture,
                OSLanguage            = Utils.GetMoValue<uint>(mo, "OSLanguage"),
                RegisteredUser        = Utils.GetMoValue<string>(mo, "RegisteredUser"),
                SerialNumber          = Utils.GetMoValue<string>(mo, "SerialNumber"),
                Status                = Utils.GetMoValue<string>(mo, "Status"),
                SystemDirectory       = Utils.GetMoValue<string>(mo, "SystemDirectory"),
                SystemDrive           = Utils.GetMoValue<string>(mo, "SystemDrive"),
                Version               = Utils.GetMoValue<string>(mo, "Version"),
                WindowsDirectory      = Utils.GetMoValue<string>(mo, "WindowsDirectory"),
                Description           = RuntimeInformation.OSDescription,
                NtVersion             = Environment.OSVersion.ToString(),
                MachineName           = Environment.MachineName,
                UserName              = Environment.UserName,
                UserDomainName        = Environment.UserDomainName,
            };
        }
    }
}