using System;

namespace DoItLess.DotNet.DeviceId.Modules
{
    /// <summary>
    ///     系统模块
    /// </summary>
    public class SystemModule : IDeviceIdModule
    {
        private readonly Properties _property;

        private SystemModule(string name, Properties property)
        {
            Name      = name;
            _property = property;
        }

        /// <summary>
        ///     本地计算机名称
        /// </summary>
        public static IDeviceIdModule MachineName { get; } = new SystemModule("MachineName", Properties.MachineName);

        /// <summary>
        ///     当前线程相关联的用户的用户名
        /// </summary>
        public static IDeviceIdModule UserName { get; } = new SystemModule("UserName", Properties.UserName);

        /// <summary>
        ///     当前用户关联的网络域名
        /// </summary>
        public static IDeviceIdModule UserDomainName { get; } = new SystemModule("UserDomainName", Properties.UserDomainName);

        /// <summary>
        ///     当前计算机上的处理器数
        /// </summary>
        public static IDeviceIdModule ProcessorCount { get; } = new SystemModule("ProcessorCount", Properties.ProcessorCount);

        public string Name { get; }

        public string GetValue()
        {
            switch (_property)
            {
                case Properties.MachineName:
                    return Environment.MachineName;
                case Properties.UserName:
                    return Environment.UserName;
                case Properties.UserDomainName:
                    return Environment.UserDomainName;
                case Properties.ProcessorCount:
                    return Environment.ProcessorCount.ToString();
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        ///     系统模块 属性
        /// </summary>
        private enum Properties
        {
            /// <summary>
            ///     本地计算机名称
            /// </summary>
            MachineName,

            /// <summary>
            ///     当前线程相关联的用户的用户名
            /// </summary>
            UserName,

            /// <summary>
            ///     当前用户关联的网络域名
            /// </summary>
            UserDomainName,

            /// <summary>
            ///     当前计算机上的处理器数
            /// </summary>
            ProcessorCount
        }
    }
}