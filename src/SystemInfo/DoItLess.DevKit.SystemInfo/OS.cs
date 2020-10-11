using System;
using System.Runtime.InteropServices;

namespace DoItLess.DevKit.SystemInfo
{
    public class OSCls
    {
        /// <summary>
        ///     构建版本
        /// </summary>
        public string BuildNumber { get; set; }

        /// <summary>
        ///     说明
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        ///     服务包名称
        /// </summary>
        public string CSDVersion { get; set; }

        /// <summary>
        ///     计算机名称
        /// </summary>
        public string CSName { get; set; }

        /// <summary>
        ///     当前时区(分钟)
        /// </summary>
        public uint CurrentTimeZone { get; set; }

        /// <summary>
        ///     WMI 系统描述
        /// </summary>
        public string WMIDescription { get; set; }

        /// <summary>
        ///     安装日期
        /// </summary>
        public DateTime InstallDate { get; set; }

        /// <summary>
        ///     上次启动时间
        /// </summary>
        public DateTime LastBootUpTime { get; set; }

        /// <summary>
        ///     制造商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        ///     系统名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     用户许可数量
        /// </summary>
        public uint NumberOfLicensedUsers { get; set; }

        /// <summary>
        ///     系统架构
        /// </summary>
        public Architecture OSArchitecture { get; set; }


        public uint OSLanguage { get; set; }

        /// <summary>
        ///     系统注册用户的名称
        /// </summary>
        public string RegisteredUser { get; set; }

        /// <summary>
        ///     系统序列号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        ///     系统状态
        /// </summary>
        /// <returns>
        ///     <para>
        ///         <c>OK</c> - 正常 <br />
        ///         <c>Error</c> - 错误 <br />
        ///         <c>Degraded</c> - 被降级的 <br />
        ///         <c>Unknown</c> - 未知 <br />
        ///         <c>Pred Fail</c> - 预示故障 <br />
        ///         <c>Starting</c> - 启动中 <br />
        ///         <c>Stopping</c> - 停止中 <br />
        ///         <c>Service</c> - 服务 <br />
        ///         <c>Stressed</c> - 有压力的 <br />
        ///         <c>NonRecover</c> - 不可恢复 <br />
        ///         <c>No Contact</c> - 没有接触 <br />
        ///         <c>Lost Comm</c> - 失去通信 <br />
        ///     </para>
        /// </returns>
        public string Status { get; set; }

        /// <summary>
        ///     系统目录
        /// </summary>
        public string SystemDirectory { get; set; }

        /// <summary>
        ///     系统驱动器
        /// </summary>
        public string SystemDrive { get; set; }

        /// <summary>
        ///     版本
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        ///     Windows 目录
        /// </summary>
        public string WindowsDirectory { get; set; }

        /// <summary>
        ///     系统描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     系统NT版本
        /// </summary>
        public string NtVersion { get; set; }

        /// <summary>
        ///     机器名
        /// </summary>
        public string MachineName { get; set; }

        /// <summary>
        ///     当前用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     用户网络域名
        /// </summary>
        public string UserDomainName { get; set; }

        /// <summary>
        ///     系统运行时间(毫秒)
        /// </summary>
        public TimeSpan TickCount => DateTime.Now - LastBootUpTime;
    }
}