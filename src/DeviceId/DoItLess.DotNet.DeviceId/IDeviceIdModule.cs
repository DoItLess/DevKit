namespace DoItLess.DotNet.DeviceId
{
    /// <summary>
    ///     DeviceId 模块接口
    /// </summary>
    public interface IDeviceIdModule
    {
        /// <summary>
        ///     名称
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     获取值
        /// </summary>
        /// <returns></returns>
        string GetValue();
    }
}