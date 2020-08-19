using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DoItLess.DotNet.Extensions
{
    public static partial class DataTableExtensions
    {
        /// <summary>
        ///     获取DataColumn可枚举对象
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"><see cref="DataColumn" />为空</exception>
        /// <exception cref="InvalidCastException"></exception>
        /// <example>
        ///     <code>
        ///         <![CDATA[
        /// var rs = dataTable.ColumnsEnumerable();
        ///         ]]>
        ///     </code>
        /// </example>
        public static IEnumerable<DataColumn> ColumnsEnumerable(this DataTable @this)
        {
            return @this.Columns.Cast<DataColumn>();
        }
    }
}
