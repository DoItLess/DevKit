using System.Collections.Generic;
using DoItLess.DotNet.DeviceId.Encoders;
using DoItLess.DotNet.DeviceId.Internal;

namespace DoItLess.DotNet.DeviceId
{
    /// <summary>
    ///     DeviceId 生成器
    /// </summary>
    public class DeviceIdBuilder
    {
        /// <summary>
        ///     默认 <c>Builder</c>
        /// </summary>
        public static DeviceIdBuilder Default { get; } = new DeviceIdBuilder();

        public readonly ISet<IDeviceIdModule> Modules = new HashSet<IDeviceIdModule>(new EncoderEqualityComparer());

        public IDeviceIdEncoder Encoder = new DefaultEncoder();

        /// <summary>
        ///     生成 DeviceId
        /// </summary>
        /// <returns></returns>
        public override string ToString() => Encoder.Generate(Modules);

        /// <summary>
        ///     隐式转换
        /// </summary>
        /// <param name="builder"></param>
        public static implicit operator string(DeviceIdBuilder builder) => builder.ToString();
    }
}