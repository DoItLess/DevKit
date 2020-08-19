using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        ///     对象强转换
        /// </summary>
        /// <param name="this"></param>
        /// <typeparam name="T">目标类型</typeparam>
        /// <returns>转换失败返回 default(<typeparamref name="T" />)</returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var s = new ClassA();
        /// var rs = s.As<BaseClass>(); // if failed, rs == default(BaseClass) 
        ///         ]]>
        ///     </code>
        /// </example>
        /// ///
        public static T As<T>(this object @this)
        {
            return @this.As(default(T));
        }

        /// <summary>
        ///     对象强转换
        /// </summary>
        /// <param name="this"></param>
        /// <param name="func"></param>
        /// <typeparam name="T">目标类型</typeparam>
        /// <returns>转换失败返回 <paramref name="func" /></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var s = new ClassA();
        /// s.As<BaseClass>(() => new BaseClass());
        ///         ]]>
        ///     </code>
        /// </example>
        public static T As<T>(this object @this, Func<T> func)
        {
            return @this.As(func.Invoke());
        }

        /// <summary>
        ///     对象强转换
        /// </summary>
        /// <param name="this"></param>
        /// <param name="defaultValue"></param>
        /// <typeparam name="T">目标类型</typeparam>
        /// <returns>转换失败返回 <paramref name="defaultValue" /></returns>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var s = new ClassA();
        /// s.As<BaseClass>();
        ///         ]]>
        ///     </code>
        /// </example>
        public static T As<T>(this object @this, T defaultValue)
        {
            try
            {
                return (T) @this;
            }
            catch
            {
                return defaultValue;
            }
        }
    }
}