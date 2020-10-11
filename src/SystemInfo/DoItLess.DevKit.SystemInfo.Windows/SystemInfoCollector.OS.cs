using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// <returns></returns>
        public static OSCls GetOSInfo()
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

            using var mos = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem").Get();
            if (mos.IsNull() || mos.Count < 1) return null;

            var mo = mos.Cast<ManagementObject>()
                        .FirstOrDefault();

            return new OSCls
            {
                BuildNumber           = GetMoValue<string>(mo, "BuildNumber"),
                Caption               = GetMoValue<string>(mo, "Caption"),
                CSDVersion            = GetMoValue<string>(mo, "CSDVersion"),
                CSName                = GetMoValue<string>(mo, "CSName"),
                CurrentTimeZone       = GetMoValue<uint>(mo, "CurrentTimeZone"),
                WMIDescription        = GetMoValue<string>(mo, "Description"),
                InstallDate           = ManagementDateTimeConverter.ToDateTime(GetMoValue<string>(mo, "InstallDate")),
                LastBootUpTime        = ManagementDateTimeConverter.ToDateTime(GetMoValue<string>(mo, "LastBootUpTime")),
                Manufacturer          = GetMoValue<string>(mo, "Manufacturer"),
                Name                  = GetMoValue<string>(mo, "Name"),
                NumberOfLicensedUsers = GetMoValue<uint>(mo, "NumberOfLicensedUsers"),
                OSArchitecture        = RuntimeInformation.OSArchitecture,
                OSLanguage            = GetMoValue<uint>(mo, "OSLanguage"),
                RegisteredUser        = GetMoValue<string>(mo, "RegisteredUser"),
                SerialNumber          = GetMoValue<string>(mo, "SerialNumber"),
                Status                = GetMoValue<string>(mo, "Status"),
                SystemDirectory       = GetMoValue<string>(mo, "SystemDirectory"),
                SystemDrive           = GetMoValue<string>(mo, "SystemDrive"),
                Version               = GetMoValue<string>(mo, "Version"),
                WindowsDirectory      = GetMoValue<string>(mo, "WindowsDirectory"),
                Description           = RuntimeInformation.OSDescription,
                NtVersion             = Environment.OSVersion.ToString(),
                MachineName           = Environment.MachineName,
                UserName              = Environment.UserName,
                UserDomainName        = Environment.UserDomainName,
            };
        }
    }
}