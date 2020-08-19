using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace DoItLess.DotNet.DeviceId.Encoders
{
    /// <summary>
    ///     默认格式化器
    /// </summary>
    public class DefaultEncoder : IDeviceIdEncoder
    {
        /// <summary>
        ///     盐
        /// </summary>
        private const string Salt = @"https://github.com/doitless";

        public string Generate(IEnumerable<IDeviceIdModule> modules)
        {
            var misc = modules.Aggregate(string.Empty, (current, module) => $"{current}_{module.GetValue() ?? string.Empty}");
            return SaltHash(misc, Salt);
        }

        /// <summary>
        ///     加盐Hash
        /// </summary>
        /// <param name="src">源字符</param>
        /// <param name="salt">盐</param>
        /// <param name="length"></param>
        /// <returns></returns>
        private static string SaltHash(string src, string salt, int length = 36)
        {
            src  ??= string.Empty;
            salt ??= string.Empty;
            var srcAndSaltStr   = src + salt;                                       // 源+盐
            var srcAndSaltBytes = Encoding.UTF8.GetBytes(srcAndSaltStr);            // 转换bytes
            var hashBytes       = new SHA256Managed().ComputeHash(srcAndSaltBytes); // 计算Hash
            return BitConverter.ToString(hashBytes)                                 // 十六进制
                               .Replace("-", "")                                    // 替换 -
                               .PadLeft(length, 'X')                                // 长度不足 补齐
                               .Substring(0, length)                                // 裁切
                               .ToUpper();                                          // 转大写
        }
    }
}