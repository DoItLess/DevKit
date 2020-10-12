using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DoItLess.DevKit.SystemInfo
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class CPU
    {
        /// <summary>
        ///     Cpu 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     标题
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     处理器唯一标识(不准确)
        /// </summary>
        public string DeviceID { get; set; }

        /// <summary>
        ///     物理核心数
        /// </summary>
        public uint NumberOfCores { get; set; }

        /// <summary>
        ///     逻辑核心数
        /// </summary>
        public uint NumberOfLogicalProcessors { get; set; }

        /// <summary>
        ///     每个处理器插槽的线程数
        /// </summary>
        public uint ThreadCount { get; set; }

        /// <summary>
        ///     制造商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        ///     最大时钟速度(MHz)
        /// </summary>
        public uint MaxClockSpeed { get; set; }

        /// <summary>
        ///     CPU支持虚拟化
        /// </summary>
        public bool VirtualizationFirmwareEnabled { get; set; }

        /// <summary>
        ///     二级缓存大小
        /// </summary>
        public uint L2CacheSize { get; set; }

        /// <summary>
        ///     三级缓存大小
        /// </summary>
        public uint L3CacheSize { get; set; }

        public override string ToString()
        {
            return new StringBuilder()
                   .AppendLine("名称 " + Name)
                   .AppendLine("说明 " + Caption)
                   .AppendLine("描述 " + Description)
                   .AppendLine("物理核心数 " + NumberOfCores)
                   .AppendLine("逻辑核心数 " + NumberOfLogicalProcessors)
                   .AppendLine("线程数 " + ThreadCount)
                   .AppendLine("最大频率 " + MaxClockSpeed + "MHz")
                   .AppendLine("制造商 " + Manufacturer)
                   .AppendLine("唯一标识 " + DeviceID)
                   .AppendLine("CPU支持虚拟化 " + VirtualizationFirmwareEnabled)
                   .ToString();
        }
    }
}