using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        ///     <para>对象转换</para>
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">
        ///     泛型约束 <see cref="IConvertible" />
        /// </typeparam>
        /// <returns>转换失败则返回 default(<typeparamref name="T" />)</returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var intVar = 11;
        /// intVar.To<string>(); // "11"
        /// 
        /// var dateTimeStr = "2018-01-01 23:59:59";
        /// var rs = dateTimeStr.To<DateTime>(); // rs = new DateTime(2018,1, 1, 23, 59, 59) 
        ///         ]]>
        ///     </code>
        /// </example>
        public static T To<T>(this object @this) where T : IConvertible
        {
            return @this.To(default(T));
        }

        /// <summary>
        ///     对象转换
        /// </summary>
        /// <param name="this"></param>
        /// <param name="func"></param>
        /// <typeparam name="T">
        ///     泛型约束 <see cref="IConvertible" />
        /// </typeparam>
        /// <returns>转换失败则返回 <paramref name="func" /></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dateTimeStr = "2018-01-01 23:59:59xxxxxxxx"; // will be fail
        /// var rs = dateTimeStr.To<DateTime>(() => new DateTime(2019,4,1)); // rs == new DateTime(2019, 4, 1)
        /// 
        /// var dateTimeStr = "2018-01-01 23:59:59"; // will be success
        /// var rs = dateTimeStr.To<DateTime>(() => new DateTime(2019,4,1)); // rs == new DateTime(2018, 1, 1, 23, 59, 59)
        ///         ]]>
        ///     </code>
        /// </example>
        public static T To<T>(this object @this, Func<T> func) where T : IConvertible
        {
            return @this.To(func.Invoke());
        }

        /// <summary>
        ///     对象转换
        /// </summary>
        /// <param name="this"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="T">
        ///     泛型约束 <see cref="IConvertible" />
        /// </typeparam>
        /// <returns>失败则返回 <paramref name="defaultValue" /></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var dateTimeStr = "2018-01-01 23:59:59xxxxxxxx"; // will be fail
        /// var rs = dateTimeStr.To<DateTime>(new DateTime(2019, 4, 1)); // rs == new DateTime(2019, 4, 1)
        ///         ]]>
        ///     </code>
        /// </example>
        public static T To<T>(this object @this, T defaultValue) where T : IConvertible
        {
            if (@this == null || @this == DBNull.Value) return defaultValue;
            if (typeof(T).IsEnum)
            {
                if (@this is int) return (T) @this;
                return (T) Enum.Parse(typeof(T), @this.ToString(), true);
            }

            try
            {
                return (T) Convert.ChangeType(@this, typeof(T));
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}