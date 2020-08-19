using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class IntExtensions
    {
        /// <summary>
        ///     重复N次操作
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action">执行的操作(参数是从0开始的 index)</param>
        /// <exception cref="ArgumentOutOfRangeException">执行次数 <paramref name="this" /> 小于0</exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var rs2 = 0L;
        /// 10L.RepeatTimes(l => rs2 += l); // rs2 == 45
        ///         ]]>
        ///     </code>
        /// </example>
        public static void RepeatTimes(this long @this, Action<long> action)
        {
            for (var i = 0; i < @this; i++) action(i);
        }

        /// <summary>
        ///     重复N次操作
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action">执行的操作(参数是从0开始的 index)</param>
        /// <exception cref="ArgumentOutOfRangeException">执行次数 <paramref name="this" /> 小于0</exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var rs2 = 0;
        /// 10.RepeatTimes(i => rs2 += i); // rs2 == 45
        ///         ]]>
        ///     </code>
        /// </example>
        public static void RepeatTimes(this int @this, Action<int> action)
        {
            if (@this < 0) throw new ArgumentOutOfRangeException(nameof(@this), $"执行次数小于0 : {@this}");
            for (var i = 0; i < @this; i++) action(i);
        }
    }
}