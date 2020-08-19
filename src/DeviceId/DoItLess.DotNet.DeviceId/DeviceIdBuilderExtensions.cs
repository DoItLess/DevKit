using DoItLess.DotNet.DeviceId.Modules;

namespace DoItLess.DotNet.DeviceId
{
    public static class DeviceIdBuilderExtensions
    {
        /// <summary>
        ///     使用编码器
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoder"></param>
        /// <returns></returns>
        public static DeviceIdBuilder UseEncoder(this DeviceIdBuilder @this, IDeviceIdEncoder encoder)
        {
            @this.Encoder = encoder;
            return @this;
        }

        #region SystemModule 系统模块

        /// <summary>
        ///     附加 本地计算机名称
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DeviceIdBuilder WithMachineName(this DeviceIdBuilder @this)
        {
            @this.Modules.Add(SystemModule.MachineName);
            return @this;
        }

        /// <summary>
        ///     附加 当前线程相关联的用户的用户名
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DeviceIdBuilder WithCurrentUserName(this DeviceIdBuilder @this)
        {
            @this.Modules.Add(SystemModule.UserName);
            return @this;
        }

        /// <summary>
        ///     附加 当前用户关联的网络域名
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DeviceIdBuilder WithCurrentUserDomainName(this DeviceIdBuilder @this)
        {
            @this.Modules.Add(SystemModule.UserDomainName);
            return @this;
        }

        /// <summary>
        ///     附加 当前计算机上的处理器数
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static DeviceIdBuilder WithProcessorCount(this DeviceIdBuilder @this)
        {
            @this.Modules.Add(SystemModule.ProcessorCount);
            return @this;
        }

        #endregion
    }
}