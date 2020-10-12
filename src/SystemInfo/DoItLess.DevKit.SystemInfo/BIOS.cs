using System;
using System.Diagnostics.CodeAnalysis;

namespace DoItLess.DevKit.SystemInfo
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class BIOS
    {
        /// <summary>
        ///     标题
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        ///     当前语言
        /// </summary>
        public string CurrentLanguage { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     制造商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        ///     名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     是否主BIOS
        /// </summary>
        public bool PrimaryBIOS { get; set; }


        /// <summary>
        ///     发布时间
        /// </summary>
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        ///     序列号
        /// </summary>
        public string SerialNumber { get; set; }

        /// <summary>
        ///     版本
        /// </summary>
        public string Version { get; set; }
    }
}