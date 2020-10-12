namespace DoItLess.DevKit.SystemInfo
{
    /// <summary>
    ///     主板
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        ///     标题
        /// </summary>
        public string Caption { get; set; }

        /// <summary>
        ///     描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     制造商
        /// </summary>
        public string Manufacturer { get; set; }

        /// <summary>
        ///     Model
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
        ///     主板编号
        /// </summary>
        public string Product { get; set; }

        /// <summary>
        ///     是否可拆卸
        /// </summary>
        public bool Removable { get; set; }

        /// <summary>
        ///     是否可替换
        /// </summary>
        public bool Replaceable { get; set; }

        /// <summary>
        ///     序列号
        /// </summary>
        public string SerialNumber { get; set; }
    }
}