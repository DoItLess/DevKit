using System.Diagnostics.CodeAnalysis;
using System.Management;
using DoItLess.DevKit.Extensions;

namespace DoItLess.DevKit.SystemInfo.Windows
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Utils
    {
        /// <summary>
        ///     WQL - OS
        /// </summary>
        public const string WQL_OS = "SELECT * FROM Win32_OperatingSystem";

        /// <summary>
        ///     WQL - CPU
        /// </summary>
        public const string WQL_CPU = "SELECT * FROM Win32_Processor";

        /// <summary>
        ///     WQL - BIOS
        /// </summary>
        public const string WQL_BIOS = "SELECT * FROM Win32_BIOS";

        /// <summary>
        ///     WQL - Memory
        /// </summary>
        public const string WQL_Memory = "SELECT * FROM Win32_PhysicalMemory";

        /// <summary>
        ///     获取 <see cref="ManagementObject" /> 值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mo"></param>
        /// <param name="property"></param>
        /// <returns></returns>
        public static T GetMoValue<T>(ManagementBaseObject mo, string property)
        {
            try
            {
                var obj = mo[property];
                return !obj.IsNull() ? (T) obj : default;
            }
            catch
            {
                return default;
            }
        }
    }
}