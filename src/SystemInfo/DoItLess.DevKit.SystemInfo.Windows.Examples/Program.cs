using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace DoItLess.DevKit.SystemInfo.Windows.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var x = RuntimeInformation.OSDescription;
            var a = SystemInfoCollector.GetOSInfo();
            var c = SystemInfoCollector.GetCpuInfo();
        }
    }
}
