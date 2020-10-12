using System.Diagnostics.CodeAnalysis;

namespace DoItLess.DevKit.SystemInfo
{
    public class Memory
    {
        /// <summary>
        ///     容量 (单位byte)
        /// </summary>
        public ulong Capacity { get; set; }

        /// <summary>
        ///     标题
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        ///     配置时钟速度(MHz)
        /// </summary>
        public uint ConfiguredClockSpeed { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     制造商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        ///     内存类型
        /// </summary>
        public MemoryType MemoryType { get; set; }

        /// <summary>
        ///     模型
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        ///     名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     零件编号
        /// </summary>
        public string PartNumber { get; set; }

        /// <summary>
        ///     序列号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        ///     物理内存速度 (纳秒)
        /// </summary>
        public uint Speed { get; set; }
    }

    /// <summary>
    ///     内存类型
    ///     <para>
    ///         <a href="https://docs.microsoft.com/zh-cn/windows/win32/cimwin32prov/win32-physicalmemory#members"></a>
    ///     </para>
    /// </summary>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public enum MemoryType
    {
        /// <summary>
        ///     Unknown
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     Other
        /// </summary>
        Other = 1,

        /// <summary>
        ///     DRAM
        /// </summary>
        DRAM = 2,

        /// <summary>
        ///     Synchronous DRAM
        /// </summary>
        SynchronousDRAM = 3,

        /// <summary>
        ///     Cache DRAM
        /// </summary>
        CacheDRAM = 4,

        /// <summary>
        ///     EDO
        /// </summary>
        EDO = 5,

        /// <summary>
        ///     EDRAM
        /// </summary>
        EDRAM = 6,

        /// <summary>
        ///     VRAM
        /// </summary>
        VRAM = 7,

        /// <summary>
        ///     SRAM
        /// </summary>
        SRAM = 8,

        /// <summary>
        ///     RAM
        /// </summary>
        RAM = 9,

        /// <summary>
        ///     ROM
        /// </summary>
        ROM = 10,

        /// <summary>
        ///     Flash
        /// </summary>
        Flash = 11,

        /// <summary>
        ///     EEPROM
        /// </summary>
        EEPROM = 12,

        /// <summary>
        ///     FEPROM
        /// </summary>
        FEPROM = 13,

        /// <summary>
        ///     EPROM
        /// </summary>
        EPROM = 14,

        /// <summary>
        ///     CDRAM
        /// </summary>
        CDRAM = 15,

        ///3DRAM
        _3DRAM = 16,

        /// <summary>
        ///     SDRAM
        /// </summary>
        SDRAM = 17,

        /// <summary>
        ///     SGRAM
        /// </summary>
        SGRAM = 18,

        /// <summary>
        ///     RDRAM
        /// </summary>
        RDRAM = 19,

        /// <summary>
        ///     DDR
        /// </summary>
        DDR = 20,

        /// <summary>
        ///     DDR2，可能无法获取
        /// </summary>
        DDR2 = 21,

        /// <summary>
        ///     DDR2—FB-DIMM，可能无法获取
        /// </summary>
        DDR2FBDIMM = 22,

        /// <summary>
        ///     DDR3，可能无法获取
        /// </summary>
        DDR3 = 24,

        /// <summary>
        ///     FBD2
        /// </summary>
        FBD2 = 25,

        /// <summary>
        ///     DDR4
        /// </summary>
        DDR4 = 26,
    }
}