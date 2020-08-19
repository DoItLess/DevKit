using System;
using System.Text;

namespace DoItLess.DevKit.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     转换为 byte 数组，默认 <see cref="Encoding.UTF8" />
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">编码格式</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="this" /> is null</exception>
        /// <exception cref="EncoderFallbackException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var source = "abcd";
        /// var rs = source.ToBytes(Encoding.Unicode);
        /// var rs2 = source.ToBytes();    // use Encoding.UTF8
        ///         ]]>
        ///     </code>
        /// </example>
        public static byte[] ToBytes(this string @this, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;
            return encoding.GetBytes(@this);
        }
    }
}