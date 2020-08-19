using System;

namespace DoItLess.DevKit.Extensions
{
    public static partial class ObjectExtensions
    {
        /// <summary>
        ///     管道操作 - action
        /// </summary>
        /// <param name="this"></param>
        /// <param name="action"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="this" /> is null </exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var obj1 = new MyClass();
        /// obj1.Pipe(o =>
        /// {
        ///     o.Name += "_pipe1";
        ///     return o;
        /// })
        /// .Pipe(o =>
        /// {
        ///     o.Name += "_pipe2";
        ///     return o;
        /// });
        ///
        /// // obj1.Name == "_pipe1_pipe2";
        ///         ]]>
        ///     </code>
        /// </example>
        public static T Pipe<T>(this T @this, Action<T> action)
        {
            if (@this == null) throw new ArgumentNullException(nameof(@this), $"{nameof(@this)} is null");
            action(@this);
            return @this;
        }

        /// <summary>
        ///     管道操作 - func
        /// </summary>
        /// <param name="this"></param>
        /// <param name="func"></param>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><paramref name="this" /> is null </exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var obj = "a";
        /// var rs2 = obj.Pipe(s => s + "_pipe1")
        ///              .Pipe(s => s + "_pipe2");
        /// // rs2 = "a_pipe1_pipe2"
        ///         ]]>
        ///     </code>
        /// </example>
        public static TResult Pipe<TSource, TResult>(this TSource @this, Func<TSource, TResult> func)
        {
            if (@this == null) throw new ArgumentNullException(nameof(@this), $"{nameof(@this)} is null");
            return func(@this);
        }
    }
}