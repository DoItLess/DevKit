using System;
using System.Text;

namespace DoItLess.DotNet.Extensions
{
    public static partial class StringExtensions
    {
        /// <summary>
        ///     进行 BASE6 4解码
        /// </summary>
        /// <param name="this"></param>
        /// <param name="encoding">默认使用 <see cref="Encoding.UTF8" /></param>
        /// <returns>转换失败返回 <c>null</c></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var base64 = "QUJDRA==";
        /// base64.Base64Decode(); // "ABCD"
        ///         ]]>
        ///     </code>
        /// </example>
        public static string Base64Decode(this string @this, Encoding encoding = null)
        {
            encoding ??= Encoding.UTF8;

            var bytes = Convert.FromBase64String(@this);
            return encoding.GetString(bytes);
        }
    }
}