using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DoItLess.DotNet.Extensions
{
    public static partial class DataTableExtensions
    {
        /// <summary>
        ///     获取DataRow可枚举对象
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var rs = dataTable.RowsEnumerable();
        ///         ]]>
        ///     </code>
        /// </example>
        public static IEnumerable<DataRow> RowsEnumerable(this DataTable @this)
        {
            return @this.Rows.Cast<DataRow>();
        }
    }
}
