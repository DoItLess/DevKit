using System;

namespace DoItLess.DotNet.DeviceId.Modules
{
    /// <summary>
    ///     基础模块，用于构建 <see cref="IDeviceIdModule" />
    /// </summary>
    public class DeviceIdModule : IDeviceIdModule
    {
        private readonly Func<string> _func;

        /// <summary>
        ///     <see cref="DeviceIdModule" /> 构造函数
        /// </summary>
        /// <param name="name">模块名称</param>
        /// <param name="valueFunc">取值委托方法</param>
        public DeviceIdModule(string name, Func<string> valueFunc)
        {
            Name  = name;
            _func = valueFunc;
        }

        public string Name { get; }

        public string GetValue() => _func();
    }
}