using System.Collections.Generic;

namespace DoItLess.DotNet.DeviceId
{
    /// <summary>
    ///     DeviceId 生成器 接口
    /// </summary>
    public interface IDeviceIdEncoder
    {
        /// <summary>
        ///     生成 DeviceId
        /// </summary>
        /// <param name="modules">模块集合</param>
        /// <returns></returns>
        string Generate(IEnumerable<IDeviceIdModule> modules);
    }
}